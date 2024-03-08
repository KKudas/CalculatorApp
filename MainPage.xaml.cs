using System.Diagnostics;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        int operation = 0;
        decimal result = 0m;

        public MainPage()
        {
            InitializeComponent();
        }

        public void ShowNumber(string buttonNumber)
        {
            if (Screen.Text.Length < 8)
            {
                if (Screen.Text.Equals("0") || Screen.Text.Equals("Error"))
                {
                    Screen.Text = buttonNumber;
                }
                else
                {
                    Screen.Text += buttonNumber;
                }
            }
            operand2 = string.Empty;
            SemanticScreenReader.Announce(Screen.Text);
        }

        //Calculator Operations
        private void DeleteAll(object sender, EventArgs e)
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            operation = 0;
            Screen.Text = $"0";
            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Delete(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("Error"))
            {
                Screen.Text = "0";
                operand1 = string.Empty;
                operand2 = string.Empty;
                operation = 0;
            }
            else if (Screen.Text.Length > 1)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            }
            else
            {
                Screen.Text = "0";
            }
            SemanticScreenReader.Announce(Screen.Text);
        }

        private void ToDecimal(object sender, EventArgs e)
        {
            if(!(Screen.Text.Contains(".")) && !(Screen.Text.Equals("Error"))) 
            {
                Screen.Text += ".";
            }
        }

        private void Equals(object sender, EventArgs e)
        {
            if (operand2 == string.Empty)
            {
                operand2 = Screen.Text;
            }

            switch(operation)
            {
                case 1: //Division
                    if (!(Screen.Text.Equals("0"))){
                        result = Convert.ToDecimal(operand1) / Convert.ToDecimal(operand2);
                        operand1 = result.ToString();
                        Screen.Text = result.ToString();
                    } else
                    {
                        Screen.Text = "Error";
                        operand1 = string.Empty;
                        operation = 0;
                    }
                    break;
                case 2: //Subtraction 
                    result = Convert.ToDecimal(operand1) - Convert.ToDecimal(operand2);
                    operand1 = result.ToString();
                    Screen.Text = result.ToString();
                    break;
                case 3: //Addition 
                    result = Convert.ToDecimal(operand1) + Convert.ToDecimal(operand2);
                    operand1 = result.ToString();
                    Screen.Text = result.ToString();
                    break;
                case 4: //Multiply
                    result = Convert.ToDecimal(operand1) * Convert.ToDecimal(operand2);
                    operand1 = result.ToString();
                    Screen.Text = result.ToString("0.##");
                    break;

            }
            SemanticScreenReader.Announce(Screen.Text);
        }

        //Arithmethic Operations
        private void Divide(object sender, EventArgs e) //1
        {
            operand1 = Screen.Text;
            Screen.Text = "0";
            operation = 1;
        }

        private void Subtract(object sender, EventArgs e) //2
        {
            operand1 = Screen.Text;
            Screen.Text = "0";
            operation = 2;
        }

        private void Add(object sender, EventArgs e) //3
        {
            operand1 = Screen.Text;
            Screen.Text = "0";
            operation = 3;
        }

        private void Multiply(object sender, EventArgs e) //4
        {
            operand1 = Screen.Text;
            Screen.Text = "0";
            operation = 4;
        }

        //Numpad
        private void Button9(object sender, EventArgs e)
        {
            ShowNumber("9");
        }

        private void Button8(object sender, EventArgs e)
        {
            ShowNumber("8");
        }

        private void Button7(object sender, EventArgs e)
        {
            ShowNumber("7");
        }

        private void Button6(object sender, EventArgs e)
        {
            ShowNumber("6");
        }

        private void Button5(object sender, EventArgs e)
        {
            ShowNumber("5");
        }

        private void Button4(object sender, EventArgs e)
        {
            ShowNumber("4");
        }

        private void Button3(object sender, EventArgs e)
        {
            ShowNumber("3");
        }

        private void Button2(object sender, EventArgs e)
        {
            ShowNumber("2");
        }

        private void Button1(object sender, EventArgs e)
        {
            ShowNumber("1");
        }

        private void Button0(object sender, EventArgs e)
        {
            if (Screen.Text.Length < 8)
            {
                if (!(Screen.Text.Equals("0")) || Screen.Text.Equals("Error"))
                {
                    Screen.Text += "0";
                }
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        //Button Animation
        private void Button_Pressed(Object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromArgb("FF2F4F4F");
        }

        private void Button_Released(Object sender, EventArgs e)
        {

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromArgb("696969");

        }

        private void Button_Pressed1(Object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromArgb("FF808000");
        }

        private void Button_Released1(Object sender, EventArgs e)
        {

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromArgb("FFFFA500");

        }
    }


}
