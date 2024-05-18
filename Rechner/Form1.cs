using Tr;




namespace Rechner
{
    public partial class Form1 : Form
    {
        private string oper = ""; // speichert then operator
        private string[] nums = new string[2]; // speichert die nummern
        private double result = 0; // speichert den resultat
        Taschenrechner calc = new Taschenrechner();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            tB_input.Text += "1";

        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            tB_input.Text += "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            tB_input.Text += "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            tB_input.Text += "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            tB_input.Text += "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            tB_input.Text += "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            tB_input.Text += "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            tB_input.Text += "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            tB_input.Text += "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            tB_input.Text += "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            oper = "+";
            tB_input.Text += " + ";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            tB_input.Text += ",";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            oper = "-";
            tB_input.Text += " - ";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            oper = "*";
            tB_input.Text += " * ";
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            oper = "/";
            tB_input.Text += " / ";
        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(tB_input.Text);
            result = calc.Factorial(x);
            tB_input.Text = result.ToString();

            //make a second textbox later!!!!!!!!!!!
            //tB_input.Text = "!" + tB_input.Text;
        }


        private void btn_equals_Click(object sender, EventArgs e)
        {
            string temp = tB_input.Text.Trim(' '); // trims the empty spaces in the user input
            nums = temp.Split(oper); // splits the operator from the string and save the numbers to nums as a string
            double x = Convert.ToDouble(nums[0]);
            double y = Convert.ToDouble(nums[1]);


            switch (oper)
            {
                case "+":
                    result = calc.Add(x, y);
                    break;
                case "-":
                    result = calc.Sub(x, y);
                    break;
                case "*":
                    result = calc.Mul(x, y);
                    break;
                case "/":
                    result = calc.Div(x, y);
                    break;
                case "^":
                    result = calc.Exp(x, y);
                    break;
                case "tan":
                    result = calc.Tangent(x);
                    break;



            }

            tB_input.Text = result.ToString(); // prints the result in the texaBox
        }

        private void btn_expo_Click(object sender, EventArgs e)
        {
            oper = "^";
            tB_input.Text += "^";
        }

        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            // clears the text boxs
            tB_input.Clear();
        }
            
        private void btn_clear_Click(object sender, EventArgs e)
        {
            // removes the last number from the texBox
            string s = tB_input.Text;
            tB_input.Text = s.Remove(tB_input.Text.Length - 1);
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            tB_input.Text += Math.PI;
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            oper = "sqrt";
            double num = calc.SquareRoot(Convert.ToDouble(tB_input.Text));
            tB_input.Text = num.ToString();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tB_input.Text);
            oper = "log";
            tB_input.Text = calc.Logarithm(num, 10).ToString();
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(tB_input.Text);
            oper = "tan";
            tB_input.Text = "tan " + calc.Tangent(angle);
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(tB_input.Text);
            oper = "sin";
            tB_input.Text = "sin " + calc.Sine(angle);
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(tB_input.Text);
            oper = "cos";
            tB_input.Text = "cos " + calc.Cosine(angle);
        }




        // funktion to check if the operator doesnt have a value
        //private bool CheckIfOperatorIsNull()
        //{
        //    if(oper == "")
        //        return false;

        //    return true;
        //}
    }
}
