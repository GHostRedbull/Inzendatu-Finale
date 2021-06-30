﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inzendatu_Version1
{
    public partial class Form1 : Form
    {
        /// Arrondie les coins de la Form manuellement
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        private List<string> listFilesSelected = new List<string>();
        private bool checkPrev = false;
        private string Pathnow = "";
        private Bunifu.UI.WinForms.BunifuPanel panelPrev = new Bunifu.UI.WinForms.BunifuPanel();
        private Bunifu.UI.WinForms.BunifuDataGridView gridPrev = new Bunifu.UI.WinForms.BunifuDataGridView();
        private Boolean ouvertoupas = false;
        private bool radioisChecked = false;
        private bool check_State = false;

        private List<Interface1> listPropriete = new List<Interface1>();

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.Columns.Add("Id", "Numero");
            bunifuDataGridView1.Columns.Add("Nom", "Nom du ficher");
            bunifuDataGridView1.Columns[0].Width = 100;

            gridPrev.Columns.Add("Path", "Emplacement");
            gridPrev.Columns.Add("NO", "Nom Original");
            gridPrev.Columns.Add("NN", "Nouveau Nom");

            initLabelVide();

            listView1.MultiSelect = true;
            listView1.View = View.List;
            listView2.MultiSelect = false;

            bunifuVScrollBar1.BindTo(bunifuDataGridView1);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog() { Description = "Select tour path" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK) { 
                    Pathnow = folderDialog.SelectedPath;
                    listFilesSelected.Clear();
                    listView1.Items.Clear();
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
            /// Clean la description 
            bool check = false;
            try { if (bunifuDataGridView1.CurrentRow.Cells[0].Value.ToString() != string.Empty) { } }
            catch (Exception ee)
            {
                if (ee.ToString().Contains("System.NullReferenceException: La référence d'objet n'est pas définie à une instance d'un objet."))
                {
                    check = true;
                    initLabelVide();
                }
            }

            if (bunifuDataGridView1.SelectedRows.Count == 1 && ouvertoupas == true && bunifuDataGridView1.RowCount > 1 && check == false)
            {
                try
                {
                    string activePath = getEmplacement(bunifuDataGridView1.SelectedRows[0].Index);
                    FileInfo fileInfo = new FileInfo(activePath);
                    initLabelRempli(fileInfo, activePath);
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
            gridPrev.Rows.Clear();
            gridPrev.Refresh();
            //// Fix pour le focus du bunifuBouton2 "Previsualiser" -> Pressed/unpressed
            if (check_State == false)
            {
                bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
                bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
                check_State = true;
            }
            else
            {
                bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
                check_State = false;
            }
            ////
            
            if (checkPrev == false)
            {
                panelPrev.Size = new Size(1320, 250);
                panelPrev.Dock = DockStyle.Bottom;
                panelPrev.Padding = new Padding(12, 0, 12, 12);
                panelPrev.Controls.Add(gridPrev);

                Bunifu.Framework.UI.BunifuElipse elipse = new Bunifu.Framework.UI.BunifuElipse();
                elipse.TargetControl = gridPrev;

                gridPrev.AllowCustomTheming = true;
                gridPrev.Dock = DockStyle.Fill;
                gridPrev.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridPrev.AllowUserToResizeRows = false;
                gridPrev.AllowUserToOrderColumns = false;
                gridPrev.ReadOnly = true;
                gridPrev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridPrev.ColumnHeadersHeight = 35;
                gridPrev.RowHeadersWidth = 35;
                gridPrev.RowTemplate.Height = 35;
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

                this.Size = new Size(1320, 1050);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
                this.Controls.Add(panelPrev);
                checkPrev = true;
            }
            else
            {
                this.Size = new Size(1320, 800);
                this.Controls.Remove(panelPrev);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
                checkPrev = false;
            }

            foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[1].Value != null)
                    {
                        gridPrev.Rows.Add(Pathnow, row.Cells[1].Value.ToString(), getFromInserer(row.Cells[1].Value.ToString()));
                    }
                }
                catch (Exception ee)
                {

                }
            }
        }

        private string getFromInserer(string inp)
        {
            string ret = inp;
            Console.WriteLine(ret);
            foreach (Interface1 itm in listPropriete)
            {
                ret = itm.ModificationText(ret);
            }
            return ret;
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
                initLabelVide();
            }
            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
        }

        private void initLabelVide()
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

        private void initLabelRempli(FileInfo fi, string path_)
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

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentTab(bunifuPages1.SelectedIndex);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void setCurrentTab(int index)
        {
            switch (bunifuPages1.SelectedIndex)
            {
                case 0:
                    pictureBox4.Left = bunifuButton5.Right - bunifuButton5.Width;
                    break;
                case 1:
                    pictureBox4.Left = bunifuButton6.Right - bunifuButton6.Width;
                    break;
                case 2:
                    pictureBox4.Left = bunifuButton7.Right - bunifuButton7.Width;
                    break;
            }
        }

        ////// Tout les boutons "ajouter" à l'interieur des tabPages
        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Inserer ins = new Inserer(bunifuTextBox1, bunifuTextBox2, bunifuTextBox3, bunifuTextBox4, bunifuTextBox5, bunifuRadioButton2, bunifuRadioButton3, bunifuRadioButton4, bunifuRadioButton5, bunifuRadioButton6, bunifuRadioButton7);
            listPropriete.Add(ins);     
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();

            ClearAll();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            Capitalisation capi = new Capitalisation(bunifuTextBox6, bunifuRadioButton8, bunifuRadioButton9, bunifuRadioButton10, bunifuRadioButton11);
            listPropriete.Add(capi);
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();
        }
        ////// Tout les boutons "ajouter" à l'interieur des tabPages

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listView2.SelectedItems;
            int p = 0;

            if (selectedItems.Count > 0)
            {
                //// Ici si un item est selectionné dans la listView
                p = listView2.SelectedIndices[0];

                if (selectedItems[0].ToString().Contains("Insérer"))
                {
                    //// Ici si un l'item selectionné est de type Inserer
                    bunifuPages1.SelectedIndex = 0;
                    listPropriete[p].Send();

                    Console.WriteLine("Ici Inser " + listPropriete[p].GetTextAjouter);
                }
                else if (selectedItems[0].ToString().Contains("Capitalisation"))
                {
                    //// Ici si un l'item selectionné est de type Capitalisation
                    bunifuPages1.SelectedIndex = 2;
                    listPropriete[p].Send();

                    Console.WriteLine("Ici Capit");
                }
            }
            else
            {   //// Surtout ne pas enlever se If
                if (listView2.FocusedItem == null) { }
                else
                {
                    //// Ici si aucune propriete est choisie dans la listView
                    ClearAll();

                    Console.WriteLine("Rien");
                }

            }
        }



        /// </Clear tout les textbox et radiobuttons de tout les onglets>
        private void ClearAll()
        {
            bunifuTextBox1.Text = "";
            bunifuTextBox2.Text = "";
            bunifuTextBox3.Text = "";
            bunifuTextBox4.Text = "";
            bunifuTextBox5.Text = "";
            bunifuTextBox6.Text = "";
            bunifuRadioButton2.Checked = false;
            bunifuRadioButton3.Checked = false;
            bunifuRadioButton4.Checked = false;
            bunifuRadioButton5.Checked = false;
            bunifuRadioButton6.Checked = false;
            bunifuRadioButton7.Checked = false;
            bunifuRadioButton8.Checked = false;
            bunifuRadioButton9.Checked = false;
            bunifuRadioButton10.Checked = false;
            bunifuRadioButton11.Checked = false;
        }
        /// </Clear tout les textbox et radiobuttons de tout les onglets>

    }
}
