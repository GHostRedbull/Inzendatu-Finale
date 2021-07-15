using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendatu_Version1
{
    public class Supprimer : Interface1
    {
        /// </Ne fait pas parti de la classe (mais à laisser)>
        private string textPositionAdd = "";
        public string GetTextPositionAdd { get => textPositionAdd; set => textPositionAdd = value; }

        private string textBeforeOrAfter = "";
        public string GetTextBeforeOrAfter { get => textBeforeOrAfter; set => textBeforeOrAfter = value; }

        private string textAfterFirstMaj = "";
        public string GetTextAfterFirstMaj { get => textAfterFirstMaj; set => textAfterFirstMaj = value; }
        /// </Ne fait pas parti de la classe (mais à laisser)>

        BunifuTextBox textBox9;
        BunifuTextBox textBox10;
        BunifuTextBox textBox11;
        BunifuRadioButton radioButton17;
        BunifuRadioButton radioButton18;
        BunifuRadioButton radioButton19;

        private int buttonChoiceNumber = 0;
        public int GetButtonChoiceNumber { get => buttonChoiceNumber; set => buttonChoiceNumber = value; }

        private string textAjouter = "";
        public string GetTextAjouter { get => textAjouter; set => textAjouter = value; }

        private int txtDe = 0;
        public int GetDe { get => txtDe; set => txtDe = value; }

        private int txtA = 0;
        public int GetA { get => txtA; set => txtA = value; }

        public string Name { get => "Supprimer"; }

        public Supprimer(BunifuTextBox tBox9, BunifuTextBox tBox10, BunifuTextBox tBox11, BunifuRadioButton rButton17, BunifuRadioButton rButton18, BunifuRadioButton rButton19)
        {
            textBox9 = tBox9;
            textBox10 = tBox10;
            textBox11 = tBox11;
            radioButton17 = rButton17;
            radioButton18 = rButton18;
            radioButton19 = rButton19;

            if (rButton17.Checked == true)
            {
                buttonChoiceNumber = 1;
                textAjouter = textBox9.Text;
                textBox9.Enabled = true;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
            else if (rButton18.Checked == true)
            {
                buttonChoiceNumber = 2;
                textAjouter = textBox9.Text;
                textBox9.Enabled = true;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
            else if (rButton19.Checked == true)
            {
                buttonChoiceNumber = 3;
                txtDe = Convert.ToInt32(textBox10.Text);
                txtA = Convert.ToInt32(textBox11.Text);
                textBox9.Enabled = false;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
            }
        }

        public void Send()
        {
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;

            if (buttonChoiceNumber == 1)
            {
                radioButton17.Checked = true;
                textBox9.Text = textAjouter;
                textBox9.Enabled = true;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
            else if (buttonChoiceNumber == 2)
            {
                radioButton18.Checked = true;
                textBox9.Text = textAjouter;
                textBox9.Enabled = true;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
            else if (buttonChoiceNumber == 3)
            {
                radioButton19.Checked = true;
                textBox10.Text = txtDe.ToString();
                textBox11.Text = txtA.ToString();
                textBox9.Enabled = false;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
            }
        }

        public string ModificationText(string inp)
        {
            string ret = "";
            if (buttonChoiceNumber == 0)
            {
                ret = inp;
            }
            else if (buttonChoiceNumber == 1)
            {
                int Place = inp.Split('.')[0].IndexOf(textAjouter);
                ret = inp;
                if (Place != -1)
                {
                    ret = inp.Split('.')[0].Remove(Place, textAjouter.Length) + '.' + inp.Split('.')[1];
                }
            }
            else if (buttonChoiceNumber == 2)
            {
                int Place = inp.Split('.')[0].IndexOf(textAjouter);
                ret = inp.Split('.')[0];
                if (Place != -1)
                {
                    while (ret.Contains(textAjouter))
                    {
                        ret = ret.Remove(Place, textAjouter.Length);
                    }
                }
                ret = ret + '.' + inp.Split('.')[1];
            }
            else if (buttonChoiceNumber == 3)
            {
                ret =  inp.Split('.')[0].Remove(txtDe-1, txtA - txtDe) + '.' + inp.Split('.')[1];
            }

            return ret;
        }

        public string ModificationTextNuméro(string inp, int index, int count)
        {
            throw new NotImplementedException();
        }
    }
}
