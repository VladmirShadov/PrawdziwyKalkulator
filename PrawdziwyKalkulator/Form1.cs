using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrawdziwyKalkulator
{

    public partial class Form1 : Form
    {
        Double wynik = 0;
        Double ostatniaLiczba = 0;
        string ostatniZnak = string.Empty;
        string znak = string.Empty;
        string znak2 = string.Empty;
        string first, second;
        bool stan = false;
        bool czyWybrana = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            buttonmnoz.Enabled = true;
            buttondziel.Enabled = true;
            buttondodaj.Enabled = true;
            buttonodejmij.Enabled = true;
            buttonplusminus.Enabled = true;
            buttonpow.Enabled = true;
            buttonprzecinek.Enabled = true;
            buttonsqrt.Enabled = true;
            buttonulamek.Enabled = true;
            buttonrownosc.Enabled = true;

            if (textBoxwynik.Text.Equals("0") || (stan))
                textBoxwynik.Text = string.Empty;
            if(label.Text.Contains("="))
            {
                textBoxwynik.Text = string.Empty;
                label.Text = string.Empty;
            }

            stan = false;
            var cliked = (sender as Button).Text;

            if (cliked.Equals(","))
            {
                if (!(textBoxwynik.Text.Contains(",")))
                {
                    textBoxwynik.Text += cliked;
                }
            }
            else
            {
                textBoxwynik.Text += cliked;
            }

            ostatniaLiczba = Double.Parse(textBoxwynik.Text);
            czyWybrana = true;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (wynik != 0)
            {
                //buttonrownosc.PerformClick();
            }
            else
            {
                wynik = Double.Parse(textBoxwynik.Text);
            }

            Button button = (Button)sender;
            znak = button.Text;
            stan = true;
            if(textBoxwynik.Text != "0")
            {
                label.Text = first = $"{wynik} {znak}";
                textBoxwynik.Text = string.Empty;
            }

            czyWybrana = false;
            ostatniZnak = znak;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxwynik.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxwynik.Text = "0";
            label.Text = string.Empty;
            wynik = 0;
        }

        private void buttoncofnij_Click(object sender, EventArgs e)
        {
            if(textBoxwynik.Text.Length>0)
            {
                textBoxwynik.Text = textBoxwynik.Text.Remove(textBoxwynik.Text.Length - 1, 1);
            }
            if(textBoxwynik.Text == string.Empty)
            {
                textBoxwynik.Text = "0";
            }
        }

        private void buttonop_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            znak2 = button.Text;
            if(textBoxwynik.Text=="")
            {
                textBoxwynik.Text = wynik.ToString();
            }
            switch(znak2)
            {
                case "sqrt":
                    if (Double.Parse(textBoxwynik.Text)>=0)
                    {
                        if (czyWybrana)
                        {
                            label.Text = $"{label.Text} √({textBoxwynik.Text})";
                            textBoxwynik.Text = Convert.ToString(Math.Sqrt(Double.Parse(textBoxwynik.Text)));
                            ostatniaLiczba = Double.Parse(textBoxwynik.Text);
                        }
                        else
                        {
                            label.Text = $"√({textBoxwynik.Text})";
                            textBoxwynik.Text = Convert.ToString(Math.Sqrt(Double.Parse(textBoxwynik.Text)));
                            
                        }
                    }
                    else
                    {
                        label.Text = "Nieprawidłowe dane wejścioweo";
                        buttonmnoz.Enabled = false;
                        buttondziel.Enabled = false;
                        buttondodaj.Enabled = false;
                        buttonodejmij.Enabled = false;
                        buttonplusminus.Enabled = false;
                        buttonpow.Enabled = false;
                        buttonprzecinek.Enabled = false;
                        buttonsqrt.Enabled = false;
                        buttonulamek.Enabled = false;
                        buttonrownosc.Enabled = false;

                        textBoxwynik.Text = string.Empty;
                        ostatniaLiczba = 0;
                        znak = string.Empty;
                        ostatniZnak = string.Empty;
                        wynik = 0;
                    }
                    break;
                case "x^2":
                    if (czyWybrana)
                    {
                        label.Text = $"{label.Text} ({textBoxwynik.Text})^2";
                        textBoxwynik.Text = Convert.ToString(Convert.ToDouble(textBoxwynik.Text) * Convert.ToDouble(textBoxwynik.Text));
                        ostatniaLiczba = Double.Parse(textBoxwynik.Text);

                    }
                    else
                    {
                        label.Text = $"({textBoxwynik.Text})^2";
                        textBoxwynik.Text = Convert.ToString(Convert.ToDouble(textBoxwynik.Text) * Convert.ToDouble(textBoxwynik.Text));
                    }
                    break;
                case "1/x":
                    if (!(Convert.ToDouble(textBoxwynik.Text)==0))
                    {
                        if (czyWybrana)
                        {
                            label.Text = $"{label.Text} 1/({textBoxwynik.Text})";
                            textBoxwynik.Text = Convert.ToString(1.0 / Convert.ToDouble(textBoxwynik.Text));
                            ostatniaLiczba = Double.Parse(textBoxwynik.Text);

                        }
                        else
                        {
                            label.Text = $"1/({textBoxwynik.Text})";
                            textBoxwynik.Text = Convert.ToString(1.0 / Convert.ToDouble(textBoxwynik.Text));
                        }
               
                    }
                    else
                    {
                        label.Text = "Nie można dzielić przez zero";
                        buttonmnoz.Enabled = false;
                        buttondziel.Enabled = false;
                        buttondodaj.Enabled = false;
                        buttonodejmij.Enabled = false;
                        buttonplusminus.Enabled = false;
                        buttonpow.Enabled = false;
                        buttonprzecinek.Enabled = false;
                        buttonsqrt.Enabled = false;
                        buttonulamek.Enabled = false;
                        buttonrownosc.Enabled = false;

                        textBoxwynik.Text = string.Empty;
                        ostatniaLiczba = 0;
                        znak = string.Empty;
                        ostatniZnak = string.Empty;
                        wynik = 0;
                    }
                    break;
                case "+/-":
                    if (czyWybrana)
                    {
                        textBoxwynik.Text = Convert.ToString(-1 * Convert.ToDouble(textBoxwynik.Text));
                        ostatniaLiczba = Double.Parse(textBoxwynik.Text);

                    }
                    else
                    {
                        textBoxwynik.Text = Convert.ToString(-1 * Convert.ToDouble(textBoxwynik.Text));
                    }
                    
                    break;
            }

            czyWybrana = false;
            ostatniZnak = znak;
        }

        private void button_Click2(object sender, EventArgs e)
        {
            if (stan)
                textBoxwynik.Text = string.Empty;

            if (label.Text.Contains("="))
            {
                textBoxwynik.Text = "0";
                label.Text = string.Empty;
            }

            stan = false;
            var cliked = (sender as Button).Text;

            if (cliked.Equals(","))
            {
                if (!(textBoxwynik.Text.Contains(",")))
                {
                    textBoxwynik.Text += cliked;
                }
            }
            else
            {
                textBoxwynik.Text += cliked;
            }
        }

        private void buttonrownosc_Click(object sender, EventArgs e)
        {
            if(!czyWybrana)
            {
                label.Text = $"{wynik} {ostatniZnak} {ostatniaLiczba} =";
                second = ostatniaLiczba.ToString();
            }
            else
            {
                second = textBoxwynik.Text;
                label.Text = $"{wynik} {znak} {second} =";
            }

           
            if (textBoxwynik.Text != string.Empty)
            {
                if(textBoxwynik.Text.Equals("0"))
                {
                    label.Text = string.Empty;
                }
                switch (ostatniZnak)
                {
                    case "+":
                        textBoxwynik.Text = (wynik + Double.Parse(second)).ToString();
                        break;
                    case "-":
                        textBoxwynik.Text = (wynik - Double.Parse(second)).ToString();
                        break;
                    case "*":
                        textBoxwynik.Text = (wynik * Double.Parse(second)).ToString();
                        break;
                    case "÷":
                        if (!(Double.Parse(textBoxwynik.Text) == 0))
                        {
                            textBoxwynik.Text = (wynik / Double.Parse(second)).ToString();
                        }
                        else
                        {
                            label.Text = "Nie można dzielić przez zero";

                            buttonmnoz.Enabled = false;
                            buttondziel.Enabled = false;
                            buttondodaj.Enabled = false;
                            buttonodejmij.Enabled = false;
                            buttonplusminus.Enabled = false;
                            buttonpow.Enabled = false;
                            buttonprzecinek.Enabled = false;
                            buttonsqrt.Enabled = false;
                            buttonulamek.Enabled = false;
                            buttonrownosc.Enabled = false;

                            textBoxwynik.Text = string.Empty;
                            ostatniaLiczba = 0;
                            znak = string.Empty;
                            ostatniZnak = string.Empty;
                            wynik = 0;
                        }
                        break;
                    default:
                        
                        //label.Text = $"{textBoxwynik.Text} {znak} =";
                        break;
                }
                if(textBoxwynik.Text != string.Empty)
                {
                    wynik = Double.Parse(textBoxwynik.Text);
                    znak = string.Empty;
                }
                

            }

            czyWybrana = false;
        }
    }
}
