using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendatu_Version1
{
    public class Capitalisation : Interface1
    {
        /// </Ne fait pas parti de la classe (mais à laisser)>
        private string textAjouter = "";
        public string GetTextAjouter { get => textAjouter; set => textAjouter = value; }

        private string textPositionAdd = "";
        public string GetTextPositionAdd { get => textPositionAdd; set => textPositionAdd = value; }

        private string textBeforeOrAfter = "";
        public string GetTextBeforeOrAfter { get => textBeforeOrAfter; set => textBeforeOrAfter = value; }

        private string[] textBetween = { "", "" };
        public string[] GetTextBetween { get => textBetween; set => textBetween = value; }
        /// </Ne fait pas parti de la classe (mais à laisser)>

        BunifuTextBox textBox6;
        BunifuRadioButton radioButton8;
        BunifuRadioButton radioButton9;
        BunifuRadioButton radioButton10;
        BunifuRadioButton radioButton11;

        private int buttonChoiceNumber = 0;
        public int GetButtonChoiceNumber { get => buttonChoiceNumber; set => buttonChoiceNumber = value; }

        private string textAfterFirstMaj = "";
        public string GetTextAfterFirstMaj { get => textAfterFirstMaj; set => textAfterFirstMaj = value; }


        public string Name { get => "Capitalisation"; }

        public Capitalisation(BunifuTextBox tBox6, BunifuRadioButton rButton8, BunifuRadioButton rButton9, BunifuRadioButton rButton10, BunifuRadioButton rButton11)
        {
            textBox6 = tBox6;
            radioButton8 = rButton8;
            radioButton9 = rButton9;
            radioButton10 = rButton10;
            radioButton11 = rButton11;

            if (rButton8.Checked == true)
                buttonChoiceNumber = 1;
            else if (rButton9.Checked == true)
                buttonChoiceNumber = 2;
            else if (rButton10.Checked == true)
                buttonChoiceNumber = 3;
            else if (rButton11.Checked == true)
            {
                buttonChoiceNumber = 4;
                textAfterFirstMaj = tBox6.Text;
            }
        }

        public void Send()
        {
            textBox6.Text = "";
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;

            if (buttonChoiceNumber == 1)
                radioButton8.Checked = true;
            else if (buttonChoiceNumber == 2)
                radioButton9.Checked = true;
            else if (buttonChoiceNumber == 3)
                radioButton10.Checked = true;
            else if (buttonChoiceNumber == 4)
            {
                radioButton11.Checked = true;
                textBox6.Text = textAfterFirstMaj;
            }
        }

        public string ModificationText(string inp)
        {
            string ret = "";
            if (buttonChoiceNumber == 1)
            {
                ret = inp.ToUpper();
            }
            else if (buttonChoiceNumber == 2)
            {
                ret = inp.ToLower();
            }
            else if (buttonChoiceNumber == 3)
            {
                ret = char.ToUpper(inp[0]) + inp.Substring(1);
            }
            else if (buttonChoiceNumber == 4)
            {
                ret = ret[0].ToString().ToUpper();
                for (int i = 1; i < inp.Length; i++)
                {
                    foreach (char car in textAfterFirstMaj)
                    {
                        if (inp[i] == car)
                        {
                            ret = ret + inp[i + 1].ToString().ToUpper();
                        }
                    }
                }
            }
            return ret;
        }
    }
}
