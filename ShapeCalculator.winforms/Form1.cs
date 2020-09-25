using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Triangle")
            {
                AreaValue.Text = shapeCalc.triangleArea(Convert.ToDouble(Input1.Value),Convert.ToDouble(Input2.Value)).ToString();
            }
            if (comboBox1.Text == "Square")
            {
                AreaValue.Text = shapeCalc.squareArea(Convert.ToDouble(Input1.Value)).ToString();
            }
            if (comboBox1.Text == "Rectangle")
            {
                AreaValue.Text = shapeCalc.rectangleArea(Convert.ToDouble(Input1.Value), Convert.ToDouble(Input2.Value)).ToString();
            }
            if (comboBox1.Text == "Circle")
            {
                AreaValue.Text = shapeCalc.circleArea(Convert.ToDouble(Input1.Value)).ToString();
            }
            if (comboBox1.Text == "Pentagon")
            {
                AreaValue.Text = shapeCalc.pentagonArea(Convert.ToDouble(Input1.Value)).ToString();
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

        
    }
}
