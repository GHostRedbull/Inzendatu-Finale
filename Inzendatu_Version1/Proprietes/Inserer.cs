using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendatu_Version1
{
    public class Inserer : Interface1
    {
        /// </Ne fait pas parti de la classe (mais à laisser)>
        private string textAfterFirstMaj = "";
        public string GetTextAfterFirstMaj { get => textAfterFirstMaj; set => textAfterFirstMaj = value; }
        /// </Ne fait pas parti de la classe (mais à laisser)>

        BunifuTextBox textBox1;
        BunifuTextBox textBox2;
        BunifuTextBox textBox3;
        BunifuTextBox textBox4;
        BunifuTextBox textBox5;
        BunifuRadioButton radioButton2;
        BunifuRadioButton radioButton3;
        BunifuRadioButton radioButton4;
        BunifuRadioButton radioButton5;
        BunifuRadioButton radioButton6;
        BunifuRadioButton radioButton7;

        private string textAjouter = "";
        public string GetTextAjouter { get => textAjouter; set => textAjouter = value; }

        private int buttonChoiceNumber = 0;
        public int GetButtonChoiceNumber { get => buttonChoiceNumber; set => buttonChoiceNumber = value; }

        private string textPositionAdd = "";
        public string GetTextPositionAdd { get => textPositionAdd; set => textPositionAdd = value; }

        private string textBeforeOrAfter = "";
        public string GetTextBeforeOrAfter { get => textBeforeOrAfter; set => textBeforeOrAfter = value; }

        private string[] textBetween = { "", "" };
        public string[] GetTextBetween { get => textBetween; set => textBetween = value; }

        public string Name { get => "Insérer";  }

        public Inserer(BunifuTextBox tBox1, BunifuTextBox tBox2, BunifuTextBox tBox3, BunifuTextBox tBox4, BunifuTextBox tBox5, BunifuRadioButton rButton2, BunifuRadioButton rButton3, BunifuRadioButton rButton4, BunifuRadioButton rButton5, BunifuRadioButton rButton6, BunifuRadioButton rButton7)
        {
            textBox1 = tBox1;
            textBox2 = tBox2;
            textBox3 = tBox3;
            textBox4 = tBox4;
            textBox5 = tBox5;
            radioButton2 = rButton2;
            radioButton3 = rButton3;
            radioButton4 = rButton4;
            radioButton5 = rButton5;
            radioButton6 = rButton6;
            radioButton7 = rButton7;

            textAjouter = tBox1.Text;
            if (rButton2.Checked == true)
                buttonChoiceNumber = 1;
            else if (rButton3.Checked == true)
                buttonChoiceNumber = 2;
            else if (rButton4.Checked == true)
            {
                buttonChoiceNumber = 3;
                textPositionAdd = tBox2.Text;
            }
            else if (rButton5.Checked == true)
            {
                buttonChoiceNumber = 4;
                textBeforeOrAfter = tBox3.Text;
            }
            else if (rButton6.Checked == true)
            {
                buttonChoiceNumber = 5;
                textBeforeOrAfter = tBox3.Text;
            }
            else if (rButton7.Checked == true)
            {
                buttonChoiceNumber = 6;
                textBetween = new string[] { tBox4.Text, tBox5.Text };
            }
        }

        public void Send()
        {
            textBox1.Text = textAjouter;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            if (buttonChoiceNumber == 1)
            {
                radioButton2.Checked = true;
            }
            else if (buttonChoiceNumber == 2)
            {
                radioButton3.Checked = true;
            }
            else if (buttonChoiceNumber == 3)
            {
                radioButton4.Checked = true;
                textBox2.Text = textPositionAdd;
            }
            else if (buttonChoiceNumber == 4)
            {
                radioButton5.Checked = true;
                textBox3.Text = textBeforeOrAfter;
            }
            else if (buttonChoiceNumber == 5)
            {
                radioButton6.Checked = true;
                textBox3.Text = textBeforeOrAfter;
            }
            else if (buttonChoiceNumber == 6)
            {
                radioButton7.Checked = true;
                textBox4.Text = textBetween[0];
                textBox5.Text = textBetween[1];
            }
        }

        public string ModificationText(string inp)
        {
            string ret = "";
            if (buttonChoiceNumber == 1)
            {
                ret = textAjouter + inp;
            }
            else if (buttonChoiceNumber == 2)
            {
                ret = inp.Split('.')[0] + textAjouter + inp.Split('.')[1];
            }
            else if (buttonChoiceNumber == 3)
            {
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
                }
            }
            else if (buttonChoiceNumber == 4)
            {
                ret = inp.Insert(inp.IndexOf(textBeforeOrAfter), textAjouter);
            }
            else if (buttonChoiceNumber == 5)
            {
                ret = inp.Insert(inp.IndexOf(textBeforeOrAfter) + textBeforeOrAfter.Length, textAjouter);
            }
            else if (buttonChoiceNumber == 6)
            {
              
                //textBox4.Text = textBetween[0];
                //textBox5.Text = textBetween[1];
            }

            return ret;
        }
    }
}
