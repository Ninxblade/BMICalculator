namespace BMICalculator
{
    partial class Form1
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
            this.UserTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTableLayoutPanel
            // 
            this.UserTableLayoutPanel.ColumnCount = 1;
            this.UserTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTableLayoutPanel.Controls.Add(this.ImperialUnitRadioButton, 0, 0);
            this.UserTableLayoutPanel.Controls.Add(this.MetricUnitRadioButton, 0, 1);
            this.UserTableLayoutPanel.Location = new System.Drawing.Point(12, 87);
            this.UserTableLayoutPanel.Name = "UserTableLayoutPanel";
            this.UserTableLayoutPanel.RowCount = 2;
            this.UserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.09489F));
            this.UserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.90511F));
            this.UserTableLayoutPanel.Size = new System.Drawing.Size(142, 97);
            this.UserTableLayoutPanel.TabIndex = 0;
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitRadioButton.CheckedChanged += new System.EventHandler(this.ImperialUnitRadioButton_CheckedChanged);
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(3, 52);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricUnitRadioButton.TabIndex = 1;
            this.MetricUnitRadioButton.TabStop = true;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitRadioButton.CheckedChanged += new System.EventHandler(this.MetricUnitRadioButton_CheckedChanged);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(24, 368);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(312, 38);
            this.AnswerTextBox.TabIndex = 0;
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.67626F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.32374F));
            this.MetricTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(15, 204);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(278, 88);
            this.MetricTableLayoutPanel.TabIndex = 5;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 48);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(155, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(120, 38);
            this.HeightTextBox.TabIndex = 2;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(155, 51);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(120, 38);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(47, 299);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(234, 35);
            this.Submitbutton.TabIndex = 6;
            this.Submitbutton.Text = "Calculate BMI";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 65);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.UserTableLayoutPanel);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UserTableLayoutPanel.ResumeLayout(false);
            this.UserTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UserTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

