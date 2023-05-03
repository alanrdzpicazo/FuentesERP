using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class customTextBox : System.Windows.Forms.TextBox
    {

        protected override void OnLostFocus(EventArgs e)
        {
            this.Text = formatText();
            base.OnLostFocus(e);
        }

        //protected override void OnTextChanged(EventArgs e)
        //{
        //    this.Text = formatText();
        //    base.OnTextChanged(e);
        //}

        private string _workingText;

        public string WorkingText
        {
            get { return _workingText; }
            private set { _workingText = value; }
        }

        private string _preFix;

        /// <summary>
        /// Contains the prefix that preceed the inputted text.
        /// </summary>
        public string PreFix
        {
            get { return _preFix; }
            set { _preFix = value; }
        }

        private char _thousandsSeparator = ',';

        /// <summary>
        /// Contains the separator symbol for thousands.
        /// </summary>
        public char ThousandsSeparator
        {
            get { return _thousandsSeparator; }
            set { _thousandsSeparator = value; }

        }

        private char _decimalsSeparator = '.';

        /// <summary>
        /// Contains the separator symbol for decimals.
        /// </summary>
        public char DecimalsSeparator
        {
            get { return _decimalsSeparator; }
            set { _decimalsSeparator = value; }
        }

        private int _decimalPlaces = 2;

        /// <summary>
        /// Indicates the total places for decimal values.
        /// </summary>
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set { _decimalPlaces = value; }
        }

        /// <summary>
        /// Formats the entered text.
        /// </summary>
        /// <returns></returns>
        public string formatText()
        {
            //if (_preFix == null)
            //    return "";

            if (_preFix == null)
            {
                this.WorkingText = this.Text.Replace(
                  (_thousandsSeparator.ToString() != "") ?
                    _thousandsSeparator.ToString() : " ", String.Empty).Replace(
                  (_decimalsSeparator.ToString() != "") ?
                    _decimalsSeparator.ToString() : " ", String.Empty).Trim();
            }
            else
            {
                this.WorkingText = this.Text.Replace(
                  (_preFix != "") ? _preFix : " ", String.Empty).Replace(
                  (_thousandsSeparator.ToString() != "") ?
                    _thousandsSeparator.ToString() : " ", String.Empty).Replace(
                  (_decimalsSeparator.ToString() != "") ?
                    _decimalsSeparator.ToString() : " ", String.Empty).Trim();
            }

            if (this.WorkingText == null)
                return "";

            int counter = 1;
            int counter2 = 0;
            char[] charArray = this.WorkingText.ToCharArray();
            StringBuilder str = new StringBuilder();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                str.Insert(0, charArray.GetValue(i));
                if (this.DecimalPlaces == 0 && counter == 3)
                {
                    counter2 = counter;
                }

                if (counter == this.DecimalPlaces && i > 0)
                {
                    if (_decimalsSeparator != Char.MinValue)
                        str.Insert(0, _decimalsSeparator);
                    counter2 = counter + 3;
                }
                else if (counter == counter2 && i > 0)
                {
                    if (_thousandsSeparator != Char.MinValue)
                        str.Insert(0, _thousandsSeparator);
                    counter2 = counter + 3;
                }
                counter = ++counter;
            }
            return (this._preFix != "" && str.ToString() != "") ?
               _preFix + " " + str.ToString() :
               (str.ToString() != "") ? str.ToString() : "";
        }

        


        protected override void OnGotFocus(EventArgs e)
        {
            //this.Text = this.WorkingText;
            base.OnGotFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (!(e.KeyChar == Convert.ToChar(Keys.Back)) && e.KeyChar.ToString() != "."  )
                    e.Handled = true;                
            }

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                string[] vec = this.Text.Split('.');
                if (vec != null)
                {
                    if (vec.Length > 1)
                    {
                        if (vec[1].ToString().Length > 1)
                            e.Handled = true;
                    }
                }
            }




            base.OnKeyPress(e);
        }




    }

}
