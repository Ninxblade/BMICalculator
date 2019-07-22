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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Incheslabel = new System.Windows.Forms.Label();
            this.Poundslabel = new System.Windows.Forms.Label();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MeticHeightTextBox = new System.Windows.Forms.TextBox();
            this.MeticWeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialHeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialWeightTextBox = new System.Windows.Forms.TextBox();
            this.UserTableLayoutPanel.SuspendLayout();
            this.ImperialTableLayoutPanel.SuspendLayout();
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
            this.UserTableLayoutPanel.Size = new System.Drawing.Size(173, 97);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 69);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Controls.Add(this.Incheslabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.Poundslabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialHeightTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialWeightTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(15, 201);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(278, 91);
            this.ImperialTableLayoutPanel.TabIndex = 4;
            // 
            // Incheslabel
            // 
            this.Incheslabel.AutoSize = true;
            this.Incheslabel.Location = new System.Drawing.Point(3, 0);
            this.Incheslabel.Name = "Incheslabel";
            this.Incheslabel.Size = new System.Drawing.Size(93, 31);
            this.Incheslabel.TabIndex = 0;
            this.Incheslabel.Text = "inches";
            this.Incheslabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Poundslabel
            // 
            this.Poundslabel.AutoSize = true;
            this.Poundslabel.Location = new System.Drawing.Point(3, 45);
            this.Poundslabel.Name = "Poundslabel";
            this.Poundslabel.Size = new System.Drawing.Size(103, 31);
            this.Poundslabel.TabIndex = 1;
            this.Poundslabel.Text = "pounds";
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MeticHeightTextBox, 1, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.MeticWeightTextBox, 1, 1);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(15, 204);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(278, 88);
            this.MetricTableLayoutPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "meters";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "kilograms";
            // 
            // MeticHeightTextBox
            // 
            this.MeticHeightTextBox.Location = new System.Drawing.Point(142, 3);
            this.MeticHeightTextBox.Name = "MeticHeightTextBox";
            this.MeticHeightTextBox.Size = new System.Drawing.Size(133, 38);
            this.MeticHeightTextBox.TabIndex = 2;
            this.MeticHeightTextBox.Text = "My Height";
            this.MeticHeightTextBox.TextChanged += new System.EventHandler(this.MeticHeightTextBox_TextChanged);
            this.MeticHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MeticHeightTextBox_KeyPress);
            // 
            // MeticWeightTextBox
            // 
            this.MeticWeightTextBox.Location = new System.Drawing.Point(142, 47);
            this.MeticWeightTextBox.Name = "MeticWeightTextBox";
            this.MeticWeightTextBox.Size = new System.Drawing.Size(133, 38);
            this.MeticWeightTextBox.TabIndex = 3;
            this.MeticWeightTextBox.Text = "My Weight";
            this.MeticWeightTextBox.TextChanged += new System.EventHandler(this.MeticWeightTextBox_TextChanged);
            this.MeticWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MeticWeightTextBox_KeyPress);
            // 
            // ImperialHeightTextBox
            // 
            this.ImperialHeightTextBox.Location = new System.Drawing.Point(142, 3);
            this.ImperialHeightTextBox.Name = "ImperialHeightTextBox";
            this.ImperialHeightTextBox.Size = new System.Drawing.Size(133, 38);
            this.ImperialHeightTextBox.TabIndex = 2;
            this.ImperialHeightTextBox.Text = "My Height";
            this.ImperialHeightTextBox.TextChanged += new System.EventHandler(this.ImperialHeightTextBox_TextChanged);
            this.ImperialHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImperialHeightTextBox_KeyPress);
            // 
            // ImperialWeightTextBox
            // 
            this.ImperialWeightTextBox.Location = new System.Drawing.Point(142, 48);
            this.ImperialWeightTextBox.Name = "ImperialWeightTextBox";
            this.ImperialWeightTextBox.Size = new System.Drawing.Size(133, 38);
            this.ImperialWeightTextBox.TabIndex = 3;
            this.ImperialWeightTextBox.Text = "My Weight";
            this.ImperialWeightTextBox.TextChanged += new System.EventHandler(this.ImperialWeightTextBox_TextChanged);
            this.ImperialWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImperialWeightTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 433);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel3);
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
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UserTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.Label Incheslabel;
        private System.Windows.Forms.Label Poundslabel;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImperialHeightTextBox;
        private System.Windows.Forms.TextBox ImperialWeightTextBox;
        private System.Windows.Forms.TextBox MeticHeightTextBox;
        private System.Windows.Forms.TextBox MeticWeightTextBox;
    }
}

