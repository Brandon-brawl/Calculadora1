using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        //Var globales
        double valor1, valor2;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

  

        private void Mimetodo_Click(object sender, EventArgs e)
        {
            string textoboton = ((Button)sender).Text;
           
            switch (textoboton)
            {
                case "+":
                    if (LBLNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(LBLNumeros.Text);
                    LBLNumeros.Text = "";
                    break;

                case "-":
                    if (LBLNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(LBLNumeros.Text);
                    LBLNumeros.Text = "";
                    break;
                 
                case "X":
                    if (LBLNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(LBLNumeros.Text);
                    LBLNumeros.Text = "";
                    break;

                case "/":
                    if (LBLNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(LBLNumeros.Text);
                    LBLNumeros.Text = "";
                    break;

                case "Raiz":
                    if (LBLNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoboton;
                    valor1 = double.Parse(LBLNumeros.Text);
                    LBLNumeros.Text = "";
                    break;

                case "=":
                    if (LBLNumeros.Text =="")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                            case "+":
                        valor2 = double.Parse(LBLNumeros.Text);
                            LBLNumeros.Text = (valor1 + valor2) + "";
                             break;
                            case "-":
                        valor2 = double.Parse(LBLNumeros.Text);
                            LBLNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "X":
                            valor2 = double.Parse(LBLNumeros.Text);
                            LBLNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                            valor2 = double.Parse(LBLNumeros.Text);
                            LBLNumeros.Text = (valor1 / valor2) + "";
                            break;
                        case "Raiz":
                            //valor1 = double.Parse(LBLNumeros.Text);
                            LBLNumeros.Text = Math.Sqrt(valor1).ToString();
                            break;

                    }
                    
                    break;
                case "AC":
                      LBLNumeros.Text = "";
                    break;
                case ".":
                  if (LBLNumeros.Text.IndexOf(".")== -1)
                    {
                        LBLNumeros.Text += textoboton;
                    }
                    break;

                default:
                    LBLNumeros.Text += textoboton; 
                    break;
            }
            //LBLNumeros.Text += ((Button)sender).Text;


        }
    }
}
