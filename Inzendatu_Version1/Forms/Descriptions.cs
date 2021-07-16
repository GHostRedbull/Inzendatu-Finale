
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inzendatu_Version1
{
    public partial class Descriptions : Form
    {
        public Descriptions()
        {
            InitializeComponent();
        }

        public void pictureInit()
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        public void initLabelVide()
        {
            bunifuLabel1.Text = "";// Nom (Titre)
            bunifuLabel2.Text = ""; // Emplacement (Titre)
            bunifuLabel3.Text = ""; // Type (Titre)
            bunifuLabel4.Text = ""; // Taille (Titre)
            bunifuLabel5.Text = ""; // Dimensions (Titre)
            bunifuLabel6.Text = ""; // D.Creation (Titre)
            bunifuLabel7.Text = ""; // D.Modifi (Titre)
            bunifuLabel8.Text = "";// Nom
            bunifuLabel9.Text = ""; // Emplacement
            bunifuLabel10.Text = ""; // Type
            bunifuLabel11.Text = ""; // Taille
            bunifuLabel12.Text = ""; // Dimensions
            bunifuLabel13.Text = ""; // D.Creation
            bunifuLabel14.Text = ""; // D.Modifi
            pictureBox1.Image = null;
            pictureBox3.Image = null;
        }

        public void initLabelRempli(FileInfo fi, string path_)
        {
            bunifuLabel1.Text = "Nom";// Nom (Titre)
            bunifuLabel2.Text = "Emplacement"; // Emplacement (Titre)
            bunifuLabel3.Text = "Type"; // Type (Titre)
            bunifuLabel4.Text = "Taille"; // Taille (Titre)
            bunifuLabel5.Text = "Dimensions"; // Dimensions (Titre)
            bunifuLabel6.Text = "Creation"; // D.Creation (Titre)
            bunifuLabel7.Text = "Modifications"; // D.Modifi (Titre)
            bunifuLabel8.Text = fi.Name; // Nom
            bunifuLabel9.Text = fi.Directory.ToString(); // Emplacement
            bunifuLabel10.Text = fi.Extension; // Type
            bunifuLabel11.Text = fi.Length.ToString(); // Taille
            if (fi.Length >= (1 << 30))
                bunifuLabel11.Text = string.Format("{0} Go", fi.Length >> 30);
            else
                    if (fi.Length >= (1 << 20))
                bunifuLabel11.Text = string.Format("{0} Mo", fi.Length >> 20);
            else
                    if (fi.Length >= (1 << 10))
                bunifuLabel11.Text = string.Format("{0} Ko", fi.Length >> 10);
            else
                bunifuLabel11.Text = string.Format("{0} Octets", fi.Length >> 10);
            bunifuLabel12.Text = getDimensions(path_); // Dimensions
            bunifuLabel13.Text = fi.CreationTime.ToString(); // D.Creation
            bunifuLabel14.Text = fi.LastWriteTime.ToString(); // D.Modifi
            pictureBox3.Image = Icon.ExtractAssociatedIcon(path_).ToBitmap();
        }

        private string getDimensions(string path)
        {
            string ret = "";
            try
            {
                Image img = Image.FromFile(path);
                ret = img.Width + " x " + img.Height;
                pictureBox1.Image = img;
                pictureBox1.Refresh();
                this.Size = new Size(284, 477);
            }
            catch (Exception e)
            {
                pictureBox1.Image = null;
                pictureBox1.Refresh();
                this.Size = new Size(284, 250);
            }

            return ret;
        }
    }
}
