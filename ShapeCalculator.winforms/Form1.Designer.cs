namespace ShapeCalculator.winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Input2 = new System.Windows.Forms.NumericUpDown();
            this.AreaValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateAreaButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).BeginInit();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(427, 73);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(150, 27);
            this.Input1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Area Shape Calculator";
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(427, 133);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(150, 27);
            this.Input2.TabIndex = 2;
            // 
            // AreaValue
            // 
            this.AreaValue.Location = new System.Drawing.Point(334, 319);
            this.AreaValue.Name = "AreaValue";
            this.AreaValue.Size = new System.Drawing.Size(137, 27);
            this.AreaValue.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Area";
            // 
            // CalculateAreaButton
            // 
            this.CalculateAreaButton.Location = new System.Drawing.Point(361, 199);
            this.CalculateAreaButton.Name = "CalculateAreaButton";
            this.CalculateAreaButton.Size = new System.Drawing.Size(84, 35);
            this.CalculateAreaButton.TabIndex = 11;
            this.CalculateAreaButton.Text = "Calculate";
            this.CalculateAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAreaButton.Click += new System.EventHandler(this.CalculateAreaButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Select Shape";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(334, 75);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(53, 20);
            this.Value1.TabIndex = 13;
            this.Value1.Text = "Value1";
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(334, 135);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(53, 20);
            this.Value2.TabIndex = 14;
            this.Value2.Text = "Value2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CalculateAreaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreaValue);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input1);
            this.Name = "Form1";
            this.Text = "Select Shape";
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Input2;
        private System.Windows.Forms.TextBox AreaValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateAreaButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
    }
}

