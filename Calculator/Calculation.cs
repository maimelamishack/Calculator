using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public virtual string Results(double val1, double val2, string oper)
        {
            double res;
            string message = "";
            switch (oper)
            {
                case "+":
                    res = val1 + val2;
                    message = res.ToString();
                    break;
                case "-":
                    res = val1 - val2;
                    message = res.ToString();
                    break;
                case "*":
                    res = val1 * val2;
                    message = res.ToString();
                    break;
                case "/":
                    if (val2 == 0)
                    {
                        message = "Error";
                    }
                    else
                    {
                        res = val1 / val2;
                        message = res.ToString();
                    }
                    break;
                default:
                    message = "Wrong Opearation";
                    break;
            }

            return message;
        }
      
    }
    public class Addition : Calculation
    {
        public override string Results(double val1, double val2, string oper)
        {
            //oper = "+";
            return base.Results(val1,val2,oper);
        }
    }
    public class Subtraction : Calculation
    {
        public override string Results(double val1, double val2, string oper)
        {
            //oper = "-";
            return base.Results(val1, val2, oper);
        }
    }
    public class Division : Calculation
    {
        public override string Results(double val1, double val2, string oper)
        {
           // oper = "/";
            return base.Results(val1, val2, oper);
        }
    }
    public class Multiplication : Calculation
    {
        public override string Results(double val1, double val2, string oper)
        {
            //oper = "*";
            return base.Results(val1, val2, oper);
        }
    }
}
