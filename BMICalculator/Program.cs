using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author's Name: Jason Li
/// Author's Stuent#: 301012468
/// Date last Modified: 7/23/2019
/// Program Description: BMI Calcualtor using Imperial and Metric Units
/// Version: 7
/// </summary>

namespace BMICalculator
{
    static class Program
    {

        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new Splash());
            Forms.Add(FormName.BMI_CALCULATOR, new BMICalculator());

            Application.Run(Forms[FormName.SPLASH_FORM]);
           
        }
    }
}
