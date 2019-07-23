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
        double BMIHeight;
        double Weight;
        double answer;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UserInputTableLayoutPanel.Visible = true;
          
        }
        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UserInputTableLayoutPanel.Visible = true;
           
        }
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if (MetricUnitRadioButton.Checked == true)
            {
                BMIHeight = double.Parse(HeightTextBox.Text);
                Weight = double.Parse(WeightTextBox.Text);
                answer = Weight / (BMIHeight * BMIHeight);
                BMITextBox.Text = (answer).ToString();
                
            }
            if (ImperialUnitRadioButton.Checked == true)
            {
                BMIHeight = double.Parse(HeightTextBox.Text);
                Weight = double.Parse(WeightTextBox.Text);
                answer = (Weight * 703) / (BMIHeight * BMIHeight);
                BMITextBox.Text = (answer).ToString();
            }

        }
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMITextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MultiLineTextBox_TextChanged(object sender, EventArgs e)
        {
            answer = double.Parse(BMITextBox.Text);
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

        private void UnitTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
