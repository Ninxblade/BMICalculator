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
    public partial class BMICalculator : Form
    {
        float BMIHeight;
        float Weight;
        float answer;
        
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method controls final output 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if (MetricUnitRadioButton.Checked == true)
            {
                BMIHeight = float.Parse(HeightTextBox.Text);
                Weight = float.Parse(WeightTextBox.Text);
                answer = Weight / (BMIHeight * BMIHeight);
                BMITextBox.Text = (answer).ToString();
                
            }
            if (ImperialUnitRadioButton.Checked == true)
            {
                BMIHeight = float.Parse(HeightTextBox.Text);
                Weight = float.Parse(WeightTextBox.Text);
                answer = (Weight * 703) / (BMIHeight * BMIHeight);
                BMITextBox.Text = (answer).ToString();
            }
            if(WeightTextBox.Text== "0" && HeightTextBox.Text == "0")
            {
                BMITextBox.Text = "0";
            }
            // Display on the multi-line 
            answer = float.Parse(BMITextBox.Text);
            if (answer < 18.5)
            { 
                MultiLineTextBox.Text = "Underweight";
            }
            if (answer >= 18.5 && answer <= 24.9)
            {
                MultiLineTextBox.Text = "Normal";
            }
            if (answer >= 25 && answer <= 29.9)
            {
                MultiLineTextBox.Text = "Overweight";
            }
            if (answer >= 30)
            {
                MultiLineTextBox.Text = "Obese";
            }
           
        }
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            WeightTextBox.MaxLength = 5;
        }
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            HeightTextBox.MaxLength = 5;
        }
        private void BMITextBox_TextChanged(object sender, EventArgs e)
        {
            BMITextBox.MaxLength = 5;
        }
        /// <summary>
        /// This method checks for number press by the keyboard ,and checks a decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ImperialUnitRadioButton_Click(object sender, EventArgs e)
        {
            WeightLabel.Text = "pounds";
            HeightLabel.Text = "inches";
        }

        private void MetricUnitRadioButton_Click(object sender, EventArgs e)
        {
            WeightLabel.Text = "kilograms";
            HeightLabel.Text = "metres";
        }
        private void BMICalculator_Click(object sender, EventArgs e)
        {
            WeightLabel.Text = "My Weight";
            HeightLabel.Text = "My Height";
        }
        private void UnitTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MultiLineTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void HideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HideRadioButton.Hide();
        }
    }
}
