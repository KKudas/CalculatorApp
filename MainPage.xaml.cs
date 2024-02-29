using System.Diagnostics;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        string operand = null;
        int operation = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //Calculator Operations
        private void DeleteAll(object sender, EventArgs e)
        {
            operand = null;
            operation = 0;
            Screen.Text = $"0";
            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Delete(object sender, EventArgs e)
        {
            if(Screen.Text.Length > 1)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            } else
            {
                Screen.Text = "0";
            }
            SemanticScreenReader.Announce(Screen.Text);
        }
        private void ToDecimal(object sender, EventArgs e)
        {
            if(!(Screen.Text.Contains("."))) 
            {
                Screen.Text += ".";
            }
        }

        private void Equals(object sender, EventArgs e)
        {
            switch(operation)
            {
                case 1: //Division
                    if (!(Screen.Text.Equals("0"))){
                        operand = Convert.ToString(Convert.ToDouble(operand) / Convert.ToDouble(Screen.Text));
                        Screen.Text = operand;
                    } else
                    {
                        DisplayAlert("Error", "Can't Divide by Zero!", "OK");
                        operand = null;
                        Screen.Text = "0";
                    }
                    break;
                case 2: //Subtraction
                    operand = Convert.ToString(Convert.ToDouble(operand) - Convert.ToDouble(Screen.Text));
                    Screen.Text = operand;
                    break;
                case 3: //Addition
                    operand = Convert.ToString(Convert.ToDouble(operand) + Convert.ToDouble(Screen.Text));
                    Screen.Text = operand;
                    break;
                case 4: //Multiply
                    operand = Convert.ToString(Convert.ToDouble(operand) * Convert.ToDouble(Screen.Text));
                    Screen.Text = operand;
                    break;

            }
            SemanticScreenReader.Announce(Screen.Text);
        }

        //Arithmethic Operations
        private void Divide(object sender, EventArgs e) //1
        {
            operand = Screen.Text;
            Screen.Text = "0";
            operation = 1;
        }

        private void Subtract(object sender, EventArgs e) //2
        {
            operand = Screen.Text;
            Screen.Text = "0";
            operation = 2;
        }

        private void Add(object sender, EventArgs e) //3
        {
            operand = Screen.Text;
            Screen.Text = "0";
            operation = 3;
        }

        private void Multiply(object sender, EventArgs e) //4
        {
            operand = Screen.Text;
            Screen.Text = "0";
            operation = 4;
        }

        //Numpad
        private void Button9(object sender, EventArgs e)
        {
            if(Screen.Text.Equals("0"))
            {
                Screen.Text = "9";
            } else
            {
                Screen.Text += "9";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button8(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "8";
            }
            else
            {
                Screen.Text += "8";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button7(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "7";
            }
            else
            {
                Screen.Text += "7";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button6(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "6";
            }
            else
            {
                Screen.Text += "6";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button5(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "5";
            }
            else
            {
                Screen.Text += "5";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button4(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "4";
            }
            else
            {
                Screen.Text += "4";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button3(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "3";
            }
            else
            {
                Screen.Text += "3";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button2(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "2";
            }
            else
            {
                Screen.Text += "2";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button1(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("0"))
            {
                Screen.Text = "1";
            }
            else
            {
                Screen.Text += "1";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }

        private void Button0(object sender, EventArgs e)
        {
            if (!(Screen.Text.Equals("0")))
            {
                Screen.Text += "0";
            }

            SemanticScreenReader.Announce(Screen.Text);
        }
    }

}
