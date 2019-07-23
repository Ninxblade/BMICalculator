namespace BMICalculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.UserInputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MultiLineTextBox = new System.Windows.Forms.TextBox();
            this.UnitTableLayoutPanel.SuspendLayout();
            this.UserInputTableLayoutPanel.SuspendLayout();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitTableLayoutPanel
            // 
            this.UnitTableLayoutPanel.ColumnCount = 1;
            this.UnitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnitTableLayoutPanel.Controls.Add(this.MetricUnitRadioButton, 0, 1);
            this.UnitTableLayoutPanel.Controls.Add(this.ImperialUnitRadioButton, 0, 0);
            this.UnitTableLayoutPanel.Location = new System.Drawing.Point(12, 104);
            this.UnitTableLayoutPanel.Name = "UnitTableLayoutPanel";
            this.UnitTableLayoutPanel.RowCount = 2;
            this.UnitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.09489F));
            this.UnitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.90511F));
            this.UnitTableLayoutPanel.Size = new System.Drawing.Size(142, 97);
            this.UnitTableLayoutPanel.TabIndex = 0;
            this.UnitTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UnitTableLayoutPanel_Paint);
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(3, 52);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(130, 42);
            this.MetricUnitRadioButton.TabIndex = 1;
            this.MetricUnitRadioButton.TabStop = true;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitRadioButton.CheckedChanged += new System.EventHandler(this.MetricUnitRadioButton_CheckedChanged);
            this.MetricUnitRadioButton.Click += new System.EventHandler(this.MetricUnitRadioButton_Click);
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(136, 43);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitRadioButton.CheckedChanged += new System.EventHandler(this.ImperialUnitRadioButton_CheckedChanged);
            this.ImperialUnitRadioButton.Click += new System.EventHandler(this.ImperialUnitRadioButton_Click);
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BMITextBox.Location = new System.Drawing.Point(3, 49);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(274, 45);
            this.BMITextBox.TabIndex = 0;
            this.BMITextBox.TextChanged += new System.EventHandler(this.BMITextBox_TextChanged);
            // 
            // UserInputTableLayoutPanel
            // 
            this.UserInputTableLayoutPanel.ColumnCount = 2;
            this.UserInputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.UserInputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.UserInputTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.UserInputTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.UserInputTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.UserInputTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.UserInputTableLayoutPanel.Location = new System.Drawing.Point(15, 204);
            this.UserInputTableLayoutPanel.Name = "UserInputTableLayoutPanel";
            this.UserInputTableLayoutPanel.RowCount = 2;
            this.UserInputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.UserInputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.UserInputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UserInputTableLayoutPanel.Size = new System.Drawing.Size(275, 97);
            this.UserInputTableLayoutPanel.TabIndex = 5;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 52);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(123, 45);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(153, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(119, 45);
            this.HeightTextBox.TabIndex = 2;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(116, 52);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(153, 55);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(119, 45);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(36, 321);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(234, 35);
            this.Submitbutton.TabIndex = 6;
            this.Submitbutton.Text = "Calculate BMI";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 1;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BMITableLayoutPanel.Controls.Add(this.MultiLineTextBox, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.BMITextBox, 0, 1);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 2;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(280, 89);
            this.BMITableLayoutPanel.TabIndex = 7;
            // 
            // MultiLineTextBox
            // 
            this.MultiLineTextBox.BackColor = System.Drawing.Color.LightGray;
            this.MultiLineTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MultiLineTextBox.Location = new System.Drawing.Point(3, 3);
            this.MultiLineTextBox.Name = "MultiLineTextBox";
            this.MultiLineTextBox.ReadOnly = true;
            this.MultiLineTextBox.Size = new System.Drawing.Size(274, 45);
            this.MultiLineTextBox.TabIndex = 1;
            this.MultiLineTextBox.TextChanged += new System.EventHandler(this.MultiLineTextBox_TextChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.UnitTableLayoutPanel);
            this.Controls.Add(this.UserInputTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Click += new System.EventHandler(this.BMICalculator_Click);
            this.UnitTableLayoutPanel.ResumeLayout(false);
            this.UnitTableLayoutPanel.PerformLayout();
            this.UserInputTableLayoutPanel.ResumeLayout(false);
            this.UserInputTableLayoutPanel.PerformLayout();
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UnitTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.TableLayoutPanel UserInputTableLayoutPanel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.TextBox MultiLineTextBox;
    }
}

