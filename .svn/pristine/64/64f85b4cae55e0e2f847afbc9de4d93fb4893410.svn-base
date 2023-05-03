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
    public partial class txt_Enteros_MX : UserControl
    {
        public decimal Valor = 0;
        public TextBox txt_Valor
        {
            get { return this.Moneda; }
        }

        string msg = string.Empty;
        CultureInfo daDK = CultureInfo.CreateSpecificCulture("es-MX");

        public txt_Enteros_MX()
        {
            InitializeComponent();
            //Moneda.ContextMenu = new ContextMenu();

        }
        private void Moneda_Leave(object sender, EventArgs e)
        {
            if (Moneda.Text.Length > 0)
            {
                string numero = Limpia_Cadena(Moneda.Text);
                Moneda.Text = Asigna_Formato(numero);

                numero = numero.Replace('.', ',');

                decimal.TryParse(numero, out Valor);

                //MessageBox.Show(Valor.ToString());

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
                    Moneda.Tag = numero;
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

                    Moneda.Text = numero;

                    numero = numero.Replace('.', ',');

                    decimal.TryParse(numero, out Valor);
                }
            }
        }
        private string Limpia_Cadena(string cadena)
        {
            string[] parte = cadena.Split(',');
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
                                result = '.' + result;
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
                    //valido la posicion del punto si es el primero agrego un 0 y aviso que ya hay un punto
                    if (c == '.' && i == 0)
                    {
                        fraccion = true;
                        pos_punto = i;
                        puntos++;
                        result += "0" + c;
                    }
                    //si tiene una posicion mayor a la primera valido que no exista otro punto previo y guardo el valor
                    else if (c == '.' && i > 0)
                    {
                        puntos++;

                        if (puntos == 1)
                        {
                            fraccion = true;
                            pos_punto = i;
                            result += c;
                        }
                        else
                        {
                            msg = "ERROR: EXISTE MAS DE UN PUNTO DECIMAL";
                            Moneda.Text = Moneda.Text.Substring(0, Moneda.Text.Length - 1);
                            return false;

                        }
                    }
                    //Si el caracter no es un punto mando error
                    else
                    {
                        msg = "SOLO SE ADMITEN NÚMEROS";
                        Moneda.Text = Moneda.Text.Substring(0, Moneda.Text.Length - 1);
                        return false;
                    }

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
                                    format_num = num[y] + "," + format_num;
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
                        result = format_num;// + "." + num.Substring(0, 2);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            result = format_num;// +"." + num.Substring(0, 1);
                        }
                        catch (Exception)
                        {
                            result = format_num;// +".00";
                        }
                    }
                }
            }
            if (x == 1)
            {
                result = format_num + "";
            }


            return result;

        }
        private void inicio()
        {
            if (Moneda.Text.Length == 0)
            {
                Moneda.Text = "0";
            }

        }
        public void Formato(string numero)
        {
            if (numero != null)
            {
                if (numero.Length > 0)
                {
                    decimal.TryParse(numero, out Valor);
                    Moneda.Text = Valor.ToString("#,##0", daDK);
                }
                else
                {
                    Valor = nValor;
                    Moneda.Text = Valor.ToString("#,##0", daDK);
                }
            }



        }
        public void Dinero()
        {
            //Remove previous formatting, or the decimal check will fail
            string value = Moneda.Text.Replace(",", "").Replace("$", "");
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                //Unsub the event so we don't enter a loop
                Moneda.TextChanged -= Moneda_TextChanged;
                //Format the text as currency
                Moneda.Text = string.Format(CultureInfo.CreateSpecificCulture("es-MX"), "{0:C2}", ul);
                Moneda.TextChanged += Moneda_TextChanged;
            }
        }
        private void Moneda_TextChanged(object sender, EventArgs e)
        {

        }
        // Constants
        //private const Keys CopyKeys = Keys.Control | Keys.C;
        //private const Keys PasteKeys = Keys.Control | Keys.V;
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //   // if ((keyData == CopyKeys) || (keyData == PasteKeys))
        //   if ((keyData == PasteKeys))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //}


        private decimal _valor;
        public decimal nValor
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
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dValor = txt_Valor.Text.Replace('.', ',');

            }
        }

    }
}
