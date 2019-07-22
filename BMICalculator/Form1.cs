using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
          
        }

        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
        }

        private void MeticHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            MeticHeightTextBox.Text = string.Empty;
        }

        private void MeticHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MeticWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            MeticWeightTextBox.Text = string.Empty;
        }

        private void MeticWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checking for numbers 
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ImperialHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ImperialHeightTextBox.Text = string.Empty;
        }

        private void ImperialHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ImperialWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            ImperialHeightTextBox.Text = string.Empty;
        }

        private void ImperialWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
