using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.VENTAS
{
    public partial class Calculadora : Form
    {
        bool ceroinicial = true;    //para controlar el cero que tiene la calculadora al iniciar
        bool pdecimal = true;       //para controlar el punto decimal
        bool op = true;             //para controlar el resultado cuando se presiona cada signo aritmetico
        bool igual = true;          //para controlar el estado del boton de igualdad
        string operacion;           //variable usada en el case de la igualdad
        double numero1 = 0;         //variable para el primer valor
        double numero2 = 0;         //variabla para el segundo valor
        double temp = 0;            //variable para el resultado

        public Calculadora()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "1";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }

        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {

            }
            else
            {
                if (ceroinicial)
                {
                    txtPantalla.Text = " ";
                    txtPantalla.Text = "0";
                    ceroinicial = false;
                }
                else
                {
                    txtPantalla.Text = txtPantalla.Text + "0";
                }

            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (ceroinicial) //cuando el punto es el primer boton que presionas
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "0";
                ceroinicial = false;
            }

            if (pdecimal)  // cuando no hay punto en pantalla imprime el punto, de lo contrario no hace nada
            {
                txtPantalla.Text = txtPantalla.Text + ".";
                pdecimal = false;
            }


        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;
            if(txtPantalla.Text.Trim().Length>0)
            {
                if (op)   //Guarda primer valor en variable al presionar el boton suma por primera vez
                {
                    numero1 = double.Parse(txtPantalla.Text);
                    txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " + ";
                    op = false;
                }
                else    //Muestra el resultado al presionar el boton suma por segunda ocacion
                {
                    numero2 = double.Parse(txtPantalla.Text);
                    txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " + ";

                    switch (operacion)
                    {
                        case "+":

                            temp = numero1 + numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;

                        case "-":

                            temp = numero1 - numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);

                            break;

                        case "*":

                            temp = numero1 * numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);

                            break;

                        case "/":
                            if (numero2 == 0)
                            {

                                txtPantalla.Text = "Error";
                                break;
                            }
                            else
                            {

                                temp = numero1 / numero2;
                                txtPantalla.Text = temp.ToString();
                                numero1 = double.Parse(txtPantalla.Text);
                                break;
                            }

                    }

                }
                operacion = "+";
            }
           

        }

        private void Btn__Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)    //Guarda primer valor en variable al presionar el boton resta por primera vez
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " - ";
                op = false;
            }
            else    //Muestra el resultado al presionar el boton resta por segunda ocacion
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " - ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }

            }
            operacion = "-";


        }

        private void BtnAst_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)   //Guarda primer valor en variable al presionar el boton multiplicar por primera vez
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " * ";
                op = false;
            }
            else   //Muestra el resultado al presionar el boton multiplicar por segunda ocacion
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " * ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }

            }
            operacion = "*";

        }

        private void BtnDia_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)   //Guarda primer valor en variable al presionar el boton division por primera vez
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " / ";
                op = false;
            }
            else  //Muestra el resultado al presionar el boton division por segunda ocacion
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " / ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }
            }
            operacion = "/";

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            //devuelve las variables a su estado inicial
            ceroinicial = true;
            pdecimal = true;
            op = true;

            if (igual)   //  realiza la operacion correspondiente si es la primeravez que se presiona el boton
            {
                numero2 = double.Parse(txtPantalla.Text);
                switch (operacion)
                {
                    case "+":
                        txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "-":
                        txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "*":
                        txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "/":
                        if (numero2 == 0)
                        {
                            txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {
                            txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            break;
                        }

                }
                igual = false;
            }

            else  //Realiza la operacion correspondiente al seguir presionando el boton
            {
                switch (operacion)
                {
                    case "+":
                        temp = temp + numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "-":
                        temp = temp - numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "*":
                        temp = temp * numero2;
                        txtPantalla.Text = temp.ToString();
                        break;

                    case "/":
                        if (numero2 == 0)
                        {
                            txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {
                            temp = temp / numero2;
                            txtPantalla.Text = temp.ToString();
                            break;
                        }

                }

            }

            txtPrevio.Text = " "; //limpia la pantalla Previo



        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;
            operacion = null;
            op = true;
            igual = true;
            numero1 = 0;
            numero2 = 0;

            temp = 0;
            txtPrevio.Text = " ";
            txtPantalla.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;
            txtPantalla.Text = "0";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "7";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "8";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";

            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "9";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";

            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "4";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "5";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";

            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "6";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "2";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "3";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";

            }
        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar))||(e.KeyChar ==Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
