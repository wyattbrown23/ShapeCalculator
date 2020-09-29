using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculator.winforms
{
    public partial class Form1 : Form
    {
        ShapeAreaCalc shapeCalc;
        public Form1()
        {
            shapeCalc = new ShapeAreaCalc();
            InitializeComponent();
            this.comboBox1.Items.AddRange(new object[] { "Triangle", "Square", "Rectangle", "Circle", "Pentagon" });

            //SQLiteConnection conn = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");
            //SQLiteCommand sqlite_cmd;
            conn.Open();
            //string CreateAreaValuesTable = "CREATE TABLE AreaValueTable(Shape VARCHAR(20), Area DOUBLE)";
            //sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = CreateAreaValuesTable;
            //sqlite_cmd.ExecuteNonQuery();

            //string DropTable = "DROP TABLE AreaValueTable";
            //sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = DropTable;
            //sqlite_cmd.ExecuteNonQuery();
        }
        SQLiteConnection conn = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
           

            if (comboBox1.Text == "Triangle")
            {
                AreaValue.Text = shapeCalc.triangleArea(Convert.ToDouble(Input1.Value),Convert.ToDouble(Input2.Value)).ToString();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO AreaValueTable(Shape, Area) VALUES('Triangle ', @area); ";
                sqlite_cmd.Parameters.AddWithValue("@area", Convert.ToDouble(AreaValue.Text));
                sqlite_cmd.ExecuteNonQuery();
            }
            if (comboBox1.Text == "Square")
            {
                AreaValue.Text = shapeCalc.squareArea(Convert.ToDouble(Input1.Value)).ToString();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO AreaValueTable(Shape, Area) VALUES('Square ', @area); ";
                sqlite_cmd.Parameters.AddWithValue("@area", Convert.ToDouble(AreaValue.Text));
                sqlite_cmd.ExecuteNonQuery();
            }
            if (comboBox1.Text == "Rectangle")
            {
                AreaValue.Text = shapeCalc.rectangleArea(Convert.ToDouble(Input1.Value), Convert.ToDouble(Input2.Value)).ToString();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO AreaValueTable(Shape, Area) VALUES('Rectangle ', @area); ";
                sqlite_cmd.Parameters.AddWithValue("@area", Convert.ToDouble(AreaValue.Text));
                sqlite_cmd.ExecuteNonQuery();
            }
            if (comboBox1.Text == "Circle")
            {
                AreaValue.Text = shapeCalc.circleArea(Convert.ToDouble(Input1.Value)).ToString();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO AreaValueTable(Shape, Area) VALUES('Circle ', @area); ";
                sqlite_cmd.Parameters.AddWithValue("@area", Convert.ToDouble(AreaValue.Text));
                sqlite_cmd.ExecuteNonQuery();
            }
            if (comboBox1.Text == "Pentagon")
            {
                AreaValue.Text = shapeCalc.pentagonArea(Convert.ToDouble(Input1.Value)).ToString();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO AreaValueTable(Shape, Area) VALUES('Pentagon ', @area); ";
                sqlite_cmd.Parameters.AddWithValue("@area", Convert.ToDouble(AreaValue.Text));
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Triangle")
            {
                Value1.Text = "shape base";
                Value2.Text = "shape height";
            }
            if(comboBox1.Text == "Square")
            {
                Value1.Text = "side length";
                Value2.Text = "";
                Input2.Enabled = false;
            }
            if (comboBox1.Text == "Rectangle")
            {
                Value1.Text = "shape length";
                Value2.Text = "shape width";
            }
            if (comboBox1.Text == "Circle")
            {
                Value1.Text = "Radius";
                Value2.Text = "";
                Input2.Enabled = false;
            }
            if (comboBox1.Text == "Pentagon")
            {
                Value1.Text = "side length";
                Value2.Text = "";
                Input2.Enabled = false;
            }
        }

        private void DisplayData_Click(object sender, EventArgs e)
        {
            string query = "SELECT* from AreaValueTable";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
