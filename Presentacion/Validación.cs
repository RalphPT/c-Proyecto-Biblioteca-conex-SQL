using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Validación
    {

        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;

                }
            }
            catch (Exception)
            {


            }
        }

        public void solonumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;

                }
            }
            catch (Exception)
            {


            }
        }

       public void sinespacios(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

               
            }
        }
    } 
}
