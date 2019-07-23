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
        private string outputString { get; set; }

        public float outputValue { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = true;
          
        }
        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
           // ImperialTableLayoutPanel.Visible = false;
        }
        private void Submitbutton_Click(object sender, EventArgs e)
        {
             double MeticHeight ;
            double MetricWeight;
            double Metricanswer;
            
            if (MetricUnitRadioButton.Checked == true)
            {

                MeticHeight = double.Parse(HeightTextBox.Text);
                MetricWeight = double.Parse(WeightTextBox.Text);
                Metricanswer = MetricWeight / (MeticHeight * MeticHeight);
                AnswerTextBox.Text = (Metricanswer).ToString();
            }
            if (ImperialUnitRadioButton.Checked == true)
            {
                MeticHeight = double.Parse(HeightTextBox.Text);
                MetricWeight = double.Parse(WeightTextBox.Text);
                Metricanswer = (MetricWeight * 703 )/ (MeticHeight * MeticHeight);
                AnswerTextBox.Text = (Metricanswer).ToString();
            }

        }
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
