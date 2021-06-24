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
            bunifuDataGridView1.Columns[0].Width = 100;

            gridPrev.Columns.Add("Path", "Emplacement");
            gridPrev.Columns.Add("NO", "Nom Original");
            gridPrev.Columns.Add("NN", "Nouveau Nom");

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
            if (bunifuDataGridView1.SelectedRows.Count == 1 && ouvertoupas == true && bunifuDataGridView1.RowCount > 1)
            {
                try
                {
                    string activePath = getEmplacement(bunifuDataGridView1.SelectedRows[0].Index);
                    FileInfo fileInfo = new FileInfo(activePath);

                    bunifuLabel1.Text = "Nom";// Nom (Titre)
                    bunifuLabel2.Text = "Emplacement"; // Emplacement (Titre)
                    bunifuLabel3.Text = "Type"; // Type (Titre)
                    bunifuLabel4.Text = "Taille"; // Taille (Titre)
                    bunifuLabel5.Text = "Dimensions"; // Dimensions (Titre)
                    bunifuLabel6.Text = "Creation"; // D.Creation (Titre)
                    bunifuLabel7.Text = "Modifications"; // D.Modifi (Titre)
                    bunifuLabel8.Text = fileInfo.Name; // Nom
                    bunifuLabel9.Text = fileInfo.Directory.ToString(); // Emplacement
                    bunifuLabel10.Text = fileInfo.Extension; // Type
                    bunifuLabel11.Text = fileInfo.Length.ToString(); // Taille
                    bunifuLabel12.Text = getDimensions(activePath); // Dimensions
                    bunifuLabel13.Text = fileInfo.CreationTime.ToString(); // D.Creation
                    bunifuLabel14.Text = fileInfo.LastWriteTime.ToString(); // D.Modifi

                    pictureBox3.Image = Icon.ExtractAssociatedIcon(activePath).ToBitmap();
                }
                catch (Exception ee)
                {
                    //Console.WriteLine(ee.ToString());
                    pictureBox1.Image = null;
                    pictureBox1.Refresh();
                }
            }

            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
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
                //Console.WriteLine(e.ToString());
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

            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();

            if (checkPrev == false)
            {
                panelPrev.Size = new Size(1400, 250);
                panelPrev.Dock = DockStyle.Bottom;
                panelPrev.BackgroundColor = Color.Red;
                panelPrev.Controls.Add(gridPrev);

                Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                elipse.TargetControl = panelPrev;

                gridPrev.AllowCustomTheming = true;
                gridPrev.Dock = DockStyle.Fill;
                gridPrev.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridPrev.AllowUserToResizeRows = false;
                gridPrev.AllowUserToOrderColumns = false;
                gridPrev.ReadOnly = true;
                gridPrev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridPrev.ScrollBars = ScrollBars.None;
                gridPrev.CurrentTheme.BackColor = Color.White;
                gridPrev.CurrentTheme.GridColor = Color.White;
                gridPrev.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
                gridPrev.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(57, 47, 90);
                gridPrev.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.LightGray;
                gridPrev.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
                gridPrev.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(57, 47, 90);
                gridPrev.CurrentTheme.HeaderStyle.ForeColor = Color.White;
                gridPrev.CurrentTheme.HeaderStyle.SelectionBackColor = Color.White;
                gridPrev.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
                gridPrev.CurrentTheme.RowsStyle.BackColor = Color.White;
                gridPrev.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(57, 47, 90);
                gridPrev.CurrentTheme.RowsStyle.SelectionBackColor = Color.LightGray;
                gridPrev.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(57, 47, 90);
                gridPrev.HeaderBackColor = Color.FromArgb(57, 47, 90);
                gridPrev.HeaderForeColor = Color.White;

                this.Controls.Add(panelPrev);
                this.Size = new Size(1400, 1050);
                //transition.ShowSync(this, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);

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

        private void bunifuDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (bunifuDataGridView1.Rows.Count == 1)
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
                pictureBox3.Image = null;
            }
            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
        }
    }
}
