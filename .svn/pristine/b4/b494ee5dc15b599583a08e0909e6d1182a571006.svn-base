using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ProbeMedic.Controles
{
    public partial class txt_Enteros_UY : UserControl
    {
        public int Valor = 0;
        string msg = string.Empty;
        CultureInfo daDK = CultureInfo.CreateSpecificCulture("es-ES");
        public TextBox txt_Valor
        {
            get { return this.Moneda; }
        }

        public txt_Enteros_UY()
        {
            InitializeComponent();


        }

        private void Moneda_Leave(object sender, EventArgs e)
        {
            if (Moneda.Text.Length > 0)
            {
                string numero = Limpia_Cadena(Moneda.Text);
                Moneda.Tag = numero;
                Moneda.Text = Asigna_Formato(numero);

            }
            else
            {
                Moneda.Text = "0";
                Valor = 0;
            }

        }
        private void Moneda_KeyUp(object sender, KeyEventArgs e)
        {
            if (Moneda.Text.Length > 0)
            {
                string numero = Limpia_Cadena(Moneda.Text);

                if (!Valida_Tipo(numero))
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int.TryParse(numero, out Valor);
                }

            }

        }
        private void Moneda_Enter(object sender, EventArgs e)
        {
            if (Moneda.Text.Length > 0)
            {
                if (Moneda.Text == "0")
                {
                    Moneda.Text = "";
                }
                else
                {
                    string numero = Limpia_Cadena(Moneda.Text);

                    int.TryParse(numero, out Valor);

                    Moneda.Text = numero;
                }
            }
        }

        private string Limpia_Cadena(string cadena)
        {
            string[] parte = cadena.Split('.');
            string valor = string.Empty;
            foreach (string num in parte)
            {
                valor += num;
            }
            return valor;
        }
        private bool Valida_Tipo(string cadena)
        {
            string result = string.Empty;
            bool fraccion = false;
            int puntos = 0, pos_punto = 0;
            msg = string.Empty;

            for (int i = 0; i < cadena.Length; i++)
            {
                char c = ' ';
                c = cadena[i];
                //Si el primer caracter es un número  comienzo a guardar el valor
                if ((c >= '0' && c <= '9'))
                {
                    //valido que no este dentro de los decimales
                    if (fraccion == false)
                    {
                        /*if (i > 0)
                        {
                            if ((i % 3) == 0)
                            {
                                result = ',' + result;
                            }
                        }*/

                        result += c;
                    }
                    else
                    {
                        //Sección para cortar a 2 Decimales
                        if ((i - pos_punto) <= 2)
                        {
                            result += c;
                        }

                    }
                }
                //Si no es numero valido que sea un punto
                else
                {
                    
                        msg = "SOLO SE ADMITEN NÚMEROS";
                        if (result.Length > 0)
                        {
                            Moneda.Text = result;
                        }
                        else{
                            result = "0";
                            Moneda.Text = result;
                        }
                         
                        return false;
                    

                }
            }
            return true;

        }
        private string Asigna_Formato(string cadena)
        {
            //Pongo comas (primero quito decimales en caso de haber
            string[] parte = cadena.Split('.');
            string format_num = string.Empty, result = string.Empty;
            int x = 0, y = 0, z = 0;

            foreach (string num in parte)
            {
                x++;
                if (x == 1)
                {
                    y = num.Length - 1;
                    for (int j = num.Length; j > 0; j--)
                    {

                        if (j < num.Length)
                        {
                            if (z == 3 || z == 6 | z == 9 || z == 12 || z == 15)
                            {
                                if (j != num.Length && num.Length != 3)
                                {
                                    format_num = num[y] + "." + format_num;
                                    z++;
                                }
                                else
                                {
                                    format_num = num[y] + format_num;
                                    z++;
                                }
                            }
                            else
                            {
                                format_num = num[y] + format_num;
                                z++;
                            }
                        }
                        else
                        {
                            format_num = num[y] + format_num;
                            z++;
                        }

                        if (y > 0)
                        {
                            y--;
                        }
                    }


                }
                else
                {
                    try
                    {
                        result = format_num;
                    }
                    catch (Exception) { }
                }
            }
            if (x == 1)
            {
                result = format_num;
            }


            return result;

        }

        public void Formato(string numero)
        {


            if (numero != null)
            {
                if (numero.Length > 0)
                {
                    int.TryParse(numero, out Valor);
                    Moneda.Text = Valor.ToString("#,##0", daDK); ;
                }
                else
                {
                    Valor = nValor;
                    Moneda.Text = Valor.ToString("#,##0", daDK);
                }
            }
        }

        public void nulabe()
        {
            Moneda.Text = "";
        }

        private void Moneda_TextChanged(object sender, EventArgs e)
        {

        }


        private int _valor;
        public int nValor
        {
            get { return _valor; }
            set
            {

                _valor = value;
                Formato(string.Empty);

            }
        }

        private string _valord;
        public string dValor
        {
            get { return _valord; }
            set
            {
                _valord = value;
                Formato(_valord);

            }
        }


        private void SendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void Moneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dValor = txt_Valor.Text.Replace(',', '.');

            }        
        }

       

    }
}
