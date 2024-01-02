namespace Assignment3
{
    partial class MainForm
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
            label1 = new Label();
            txtName = new TextBox();
            lblHeight = new Label();
            lblWeight = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            groupBoxUnit = new GroupBox();
            rbtnUsUnit = new RadioButton();
            rbtnMetric = new RadioButton();
            btnCalculateBMI = new Button();
            grpResults = new GroupBox();
            lblResultWeightCategory = new TextBox();
            lblResultYourBmi = new TextBox();
            txtWeightCategory = new Label();
            txtYourBmi = new Label();
            groupBoxUnit.SuspendLayout();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Your Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(275, 38);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 27);
            txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(30, 97);
            lblHeight.Margin = new Padding(2, 0, 2, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(88, 20);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height (cm)";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(30, 140);
            lblWeight.Margin = new Padding(2, 0, 2, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(86, 20);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Weight (kg)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(158, 97);
            txtHeight.Margin = new Padding(2, 2, 2, 2);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(71, 27);
            txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(158, 137);
            txtWeight.Margin = new Padding(2, 2, 2, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(71, 27);
            txtWeight.TabIndex = 5;
            // 
            // groupBoxUnit
            // 
            groupBoxUnit.Controls.Add(rbtnUsUnit);
            groupBoxUnit.Controls.Add(rbtnMetric);
            groupBoxUnit.Location = new Point(275, 97);
            groupBoxUnit.Margin = new Padding(2, 2, 2, 2);
            groupBoxUnit.Name = "groupBoxUnit";
            groupBoxUnit.Padding = new Padding(2, 2, 2, 2);
            groupBoxUnit.Size = new Size(202, 110);
            groupBoxUnit.TabIndex = 6;
            groupBoxUnit.TabStop = false;
            groupBoxUnit.Text = "Name";
            // 
            // rbtnUsUnit
            // 
            rbtnUsUnit.AutoSize = true;
            rbtnUsUnit.Location = new Point(26, 72);
            rbtnUsUnit.Margin = new Padding(2, 2, 2, 2);
            rbtnUsUnit.Name = "rbtnUsUnit";
            rbtnUsUnit.Size = new Size(147, 24);
            rbtnUsUnit.TabIndex = 1;
            rbtnUsUnit.TabStop = true;
            rbtnUsUnit.Text = "US Unit (foot, lbs)";
            rbtnUsUnit.UseVisualStyleBackColor = true;
            rbtnUsUnit.CheckedChanged += rbtnUsUnit_CheckedChanged;
            // 
            // rbtnMetric
            // 
            rbtnMetric.AutoSize = true;
            rbtnMetric.Location = new Point(26, 36);
            rbtnMetric.Margin = new Padding(2, 2, 2, 2);
            rbtnMetric.Name = "rbtnMetric";
            rbtnMetric.Size = new Size(157, 24);
            rbtnMetric.TabIndex = 0;
            rbtnMetric.TabStop = true;
            rbtnMetric.Text = "Metric Unit (kg cm)";
            rbtnMetric.UseVisualStyleBackColor = true;
            rbtnMetric.CheckedChanged += rbtnMetric_CheckedChanged;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(189, 219);
            btnCalculateBMI.Margin = new Padding(2, 2, 2, 2);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(134, 50);
            btnCalculateBMI.TabIndex = 7;
            btnCalculateBMI.Text = "Calculate";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblResultWeightCategory);
            grpResults.Controls.Add(lblResultYourBmi);
            grpResults.Controls.Add(txtWeightCategory);
            grpResults.Controls.Add(txtYourBmi);
            grpResults.Location = new Point(30, 343);
            grpResults.Margin = new Padding(2, 2, 2, 2);
            grpResults.Name = "grpResults";
            grpResults.Padding = new Padding(2, 2, 2, 2);
            grpResults.Size = new Size(500, 127);
            grpResults.TabIndex = 8;
            grpResults.TabStop = false;
            grpResults.Text = "Results for";
            // 
            // lblResultWeightCategory
            // 
            lblResultWeightCategory.Location = new Point(246, 78);
            lblResultWeightCategory.Margin = new Padding(2, 2, 2, 2);
            lblResultWeightCategory.Name = "lblResultWeightCategory";
            lblResultWeightCategory.Size = new Size(236, 27);
            lblResultWeightCategory.TabIndex = 3;
            lblResultWeightCategory.TextChanged += btnCalculateBMI_Click;
            // 
            // lblResultYourBmi
            // 
            lblResultYourBmi.Location = new Point(362, 31);
            lblResultYourBmi.Margin = new Padding(2, 2, 2, 2);
            lblResultYourBmi.Name = "lblResultYourBmi";
            lblResultYourBmi.Size = new Size(121, 27);
            lblResultYourBmi.TabIndex = 2;
            lblResultYourBmi.TextChanged += btnCalculateBMI_Click;
            // 
            // txtWeightCategory
            // 
            txtWeightCategory.AutoSize = true;
            txtWeightCategory.Location = new Point(23, 80);
            txtWeightCategory.Margin = new Padding(2, 0, 2, 0);
            txtWeightCategory.Name = "txtWeightCategory";
            txtWeightCategory.Size = new Size(120, 20);
            txtWeightCategory.TabIndex = 1;
            txtWeightCategory.Text = "Weight Category";
            // 
            // txtYourBmi
            // 
            txtYourBmi.AutoSize = true;
            txtYourBmi.Location = new Point(23, 36);
            txtYourBmi.Margin = new Padding(2, 0, 2, 0);
            txtYourBmi.Name = "txtYourBmi";
            txtYourBmi.Size = new Size(68, 20);
            txtYourBmi.TabIndex = 0;
            txtYourBmi.Text = "Your BMI";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 518);
            Controls.Add(grpResults);
            Controls.Add(btnCalculateBMI);
            Controls.Add(groupBoxUnit);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            groupBoxUnit.ResumeLayout(false);
            groupBoxUnit.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private GroupBox groupBoxUnit;
        private RadioButton rbtnMetric;
        private RadioButton rbtnUsUnit;
        private Button btnCalculateBMI;
        private GroupBox grpResults;
        private Label txtYourBmi;
        private Label txtWeightCategory;
        private TextBox lblResultWeightCategory;
        private TextBox lblResultYourBmi;
    }
}
