using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendatu_Version1.Proprietes
{
    class Numéroter : Interface1
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

        private string textAfterFirstMaj = "";
        public string GetTextAfterFirstMaj { get => textAfterFirstMaj; set => textAfterFirstMaj = value; }
        /// </Ne fait pas parti de la classe (mais à laisser)>

        private int buttonChoiceNumber = 0;
        public int GetButtonChoiceNumber { get => buttonChoiceNumber; set => buttonChoiceNumber = value; }

        public string Name { get => "Numéroter"; }

        BunifuTextBox textBox1;
        BunifuTextBox textBox2;
        BunifuRadioButton radioButton1;
        BunifuRadioButton radioButton2;
        BunifuRadioButton radioButton3;
        BunifuRadioButton radioButton4;
        BunifuRadioButton radioButton5;

        public Numéroter(BunifuTextBox tBox1, BunifuTextBox tBox2, BunifuRadioButton rButton1, BunifuRadioButton rButton2, BunifuRadioButton rButton3, BunifuRadioButton rButton4, BunifuRadioButton rButton5)
        {
            textBox1 = tBox1;
            textBox2 = tBox2;
            radioButton1 = rButton1;
            radioButton2 = rButton2;
            radioButton3 = rButton3;
            radioButton4 = rButton4;
            radioButton5 = rButton5;

            if (rButton1.Checked == true)
                buttonChoiceNumber = 1;
            else if (rButton2.Checked == true)
                buttonChoiceNumber = 2;
            else if (rButton3.Checked == true)
            {
                buttonChoiceNumber = 3;
                textPositionAdd = textBox1.Text;
            }
            else if (rButton4.Checked == true)
            {
                buttonChoiceNumber = 4;
                textBeforeOrAfter = textBox2.Text;
            }
            else if (rButton5.Checked == true)
            {
                buttonChoiceNumber = 5;
                textBeforeOrAfter = textBox2.Text;
            }

        }

        public void Send()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            if (buttonChoiceNumber == 1)
            {
                radioButton1.Checked = true;
            }
            else if (buttonChoiceNumber == 2)
            {
                radioButton2.Checked = true;
            }
            else if (buttonChoiceNumber == 3)
            {
                radioButton3.Checked = true;
                textBox1.Text = textPositionAdd;
            }
            else if (buttonChoiceNumber == 4)
            {
                radioButton4.Checked = true;
                textBox2.Text = textBeforeOrAfter;
            }
            else if (buttonChoiceNumber == 5)
            {
                radioButton5.Checked = true;
                textBox2.Text = textBeforeOrAfter;
            }
        }

        public string ModificationText(string inp)
        {
            string ret = "";
            if (buttonChoiceNumber == 1)
            {
                //ret = textAjouter + inp;
            }
            else if (buttonChoiceNumber == 2)
            {
                //ret = inp.Split('.')[0] + textAjouter + inp.Split('.')[1];
            }
            else if (buttonChoiceNumber == 3)
            {
                /*
                for (int i = 0; i < inp.Length; i++)
                {
                    if (i == (Convert.ToInt32(textPositionAdd) - 1))
                    {
                        ret = ret + textAjouter + inp[i];
                    }
                    else
                    {
                        ret = ret + inp[i];
                    }
                }*/
            }
            else if (buttonChoiceNumber == 4)
            {
                //ret = inp.Insert(inp.IndexOf(textBeforeOrAfter), textAjouter);
            }
            else if (buttonChoiceNumber == 5)
            {
                //ret = inp.Insert(inp.IndexOf(textBeforeOrAfter) + textBeforeOrAfter.Length, textAjouter);
            }

            return ret;
        }
    }
}
