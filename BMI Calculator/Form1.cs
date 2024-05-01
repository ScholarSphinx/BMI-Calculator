using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double weight = double.Parse(textBox2.Text);
            double height = double.Parse(textBox3.Text);
            double bmi = CalculateBMI(weight, height);
            DisplayBMI(bmi, name);
        }

        public double CalculateBMI(double weight, double height)
        {
            // Calculate the BMI using the formula: weight / (height * height)
            double bmi = weight / (Math.Pow(height, 2));
            return Math.Round(bmi,1);
        }

        public void DisplayBMI(double bmi, string name)
        {
            // Determine the status based on the BMI value
            string status;
            if (bmi < 18.5)
            {
                status = "UNDERWEIGHT";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                status = "NORMAL";
            }
            else // bmi >= 25
            {
                status = "OVERWEIGHT";
            }

            // Display the name, BMI value, and status in a message box
            MessageBox.Show("Name: " + name + ", Your BMI is: " + bmi + " and you are " + status);
        }
    }
}
