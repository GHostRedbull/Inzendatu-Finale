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
    public partial class Form1 : Form
    {
        private List<string> listFilesSelected = new List<string>();
        private bool checkPrev = false;
        private string Pathnow = "";
        private Bunifu.UI.WinForms.BunifuPanel panelPrev = new Bunifu.UI.WinForms.BunifuPanel();
        private Bunifu.UI.WinForms.BunifuDataGridView gridPrev = new Bunifu.UI.WinForms.BunifuDataGridView();
        private Boolean ouvertoupas = false;
        private bool radioisChecked = false;

        public Form1()
        {
            InitializeComponent();

            listView1.MultiSelect = true;

            bunifuDataGridView1.Columns.Add("Id", "Numero");
            bunifuDataGridView1.Columns.Add("Nom", "Nom du ficher");

            gridPrev.Columns.Add("Path", "Emplacement");
            gridPrev.Columns.Add("NO", "Nom Original");
            gridPrev.Columns.Add("NN", "Nouveau Nom");

            bunifuLabel8.Text = "";
            bunifuLabel9.Text = "";
            bunifuLabel10.Text = "";
            bunifuLabel11.Text = "";
            bunifuLabel12.Text = "";
            bunifuLabel13.Text = "";
            bunifuLabel14.Text = "";

            listView1.View = View.List;

            bunifuVScrollBar1.BindTo(bunifuDataGridView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            listFilesSelected.Clear();
            listView1.Items.Clear();
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog() { Description = "Select tour path" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK) { 
                    Pathnow = folderDialog.SelectedPath;
                    foreach (string item in Directory.GetFiles(folderDialog.SelectedPath))
                    {
                        imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFilesSelected.Add(fi.FullName);
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    }
                    ouvertoupas = true;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.FocusedItem != null)
                //Console.WriteLine(listFilesSelected[listView1.FocusedItem.Index]);
        }


        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count == 1 && ouvertoupas == true)
            {
                try
                {
                    string activePath = getEmplacement(bunifuDataGridView1.SelectedRows[0].Index);
                    FileInfo fileInfo = new FileInfo(activePath);
                    bunifuLabel8.Text = fileInfo.Name; // Nom
                    bunifuLabel9.Text = fileInfo.Directory.ToString(); // Emplacement
                    bunifuLabel10.Text = fileInfo.Extension; // Type
                    bunifuLabel11.Text = fileInfo.Length.ToString(); // Taille
                    bunifuLabel12.Text = getDimensions(activePath); // Dimensions
                    bunifuLabel13.Text = fileInfo.CreationTime.ToString(); // D.Creation
                    bunifuLabel14.Text = fileInfo.LastWriteTime.ToString(); // D.Modifi

                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                    pictureBox1.Image = null;
                    pictureBox1.Refresh();
                }
            }
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
            }
            catch (Exception e)
            {
                pictureBox1.Image = null;
                pictureBox1.Refresh();
                Console.WriteLine(e.ToString());
            }

            return ret;
        }

        private string getEmplacement(int selectedRow_inDataGridViewCentrale)
        {
            return Pathnow + @"\" + bunifuDataGridView1.Rows[selectedRow_inDataGridViewCentrale].Cells[1].FormattedValue.ToString();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            List<string> listtt = new List<string>();
            int i = 0;

            foreach (var tt in listView1.SelectedItems)
            {
                listtt.Add(tt.ToString().Split('{')[1].Split('}')[0]);

                bunifuDataGridView1.Rows.Add(++i, tt.ToString().Split('{')[1].Split('}')[0]);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (checkPrev == false)
            {
                panelPrev.Size = new Size(1400, 250);
                panelPrev.Dock = DockStyle.Bottom;
                panelPrev.BackgroundColor = Color.Red;
                panelPrev.Controls.Add(gridPrev);

                Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                elipse.TargetControl = panelPrev;
                gridPrev.Dock = DockStyle.Fill;

                this.Size = new Size(1400, 1050);
                this.Controls.Add(panelPrev);

                checkPrev = true;
            }
            else
            {
                this.Size = new Size(1400, 800);
                this.Controls.Remove(panelPrev);

                checkPrev = false;
            }
        }

        private void bunifuRadioButton1_Click(object sender, EventArgs e)
        {
            if (bunifuRadioButton1.Checked && !radioisChecked)
            {
                bunifuRadioButton1.Checked = false;
                radioisChecked = true;
                listView1.View = View.LargeIcon;
            }
            else
            {
                bunifuRadioButton1.Checked = true;
                radioisChecked = false;
                listView1.View = View.List;
            }
        }
    }
}
