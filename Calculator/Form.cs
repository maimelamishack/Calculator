using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string val1 = "";
        public string val2 = "";
        public string oper = "";
        public string results = "";
        Calculation calc;
        public Form()
        {
            InitializeComponent();
        }

        private void val1TXT_TextChanged(object sender, EventArgs e)
        {

            val1 = val1TXT.Text;
            screenTXT.Text = val1 + " " + oper + " " + val2;

        }

        private void val2TXT_TextChanged(object sender, EventArgs e)
        {
            val2 = val2TXT.Text;
            screenTXT.Text = val1 + " " + oper + " " + val2;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            val1 = "";
            val2 = "";
            oper = "";
            screenTXT.Clear();
            val1TXT.Clear();
            val2TXT.Clear();
        }

        private void Clear()
        {
            val1 = "";
            val2 = "";
            oper = "";
            screenTXT.Clear();
            val1TXT.Clear();
            val2TXT.Clear();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            oper = addBTN.Text;
            if (val1 != "")
            {
                screenTXT.Text = val1 + " " + oper + " " + val2;
            }  
            calc = new Addition();
            
        }

        private void subtractBTN_Click(object sender, EventArgs e)
        {
            oper = subtractBTN.Text;
            if (val1 != "")
            {
                screenTXT.Text = val1 + " " + oper + " " + val2;
            }
            calc = new Subtraction();
        }

        private void multiplyBTN_Click(object sender, EventArgs e)
        {
            oper = multiplyBTN.Text;
            if (val1 != "")
            {
                screenTXT.Text = val1 + " " + oper + " " + val2;
            }
            calc = new Multiplication();
        }

        private void divisionBTN_Click(object sender, EventArgs e)
        {
            oper = divisionBTN.Text;
            if (val1 != "")
            {
                screenTXT.Text = val1 + " " + oper + " " + val2;
            }
            calc = new Division();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
           
            if (val1 == "" || val2 == "" || oper == ""
                || !Regex.IsMatch(val1TXT.Text, @"^-?[0-9]*\.?[0-9]+$")
                || !Regex.IsMatch(val2TXT.Text, @"^-?[0-9]*\.?[0-9]+$"))
            {
                screenTXT.Text = "Invalid operation";
            }
            else
            {
                results = calc.Results(Convert.ToDouble(val1TXT.Text, provider), Convert.ToDouble(val2TXT.Text, provider), oper);
                screenTXT.Text = val1 + " " + oper + " " + val2 + " = " + results;
            }
           
        }
    }
}
