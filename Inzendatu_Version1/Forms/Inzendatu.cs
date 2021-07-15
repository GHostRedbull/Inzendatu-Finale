using Bunifu.UI.WinForms.BunifuAnimatorNS;
using Inzendatu_Version1.Proprietes;
using System;
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
    public partial class Inzendatu : Form
    {
        #region Toutes les propriétés de la classe
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

        private Descriptions desc = new Descriptions();
        private List<string> listFilesSelected = new List<string>();
        private bool checkPrev = false;
        private string Pathnow = "";
        private Bunifu.UI.WinForms.BunifuPanel panelPrev = new Bunifu.UI.WinForms.BunifuPanel();
        private Bunifu.UI.WinForms.BunifuDataGridView gridPrev = new Bunifu.UI.WinForms.BunifuDataGridView();
        private Boolean ouvertoupas = false;
        private bool radioisChecked = false;
        private bool check_State = false;
        private string activePath = "";
        private List<Interface1> listPropriete = new List<Interface1>();
        private FolderBrowserDialog folderDialog;
        #endregion

        public Inzendatu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
        }

        private void Inzendatu_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.Columns.Add("Id", "Numero");
            bunifuDataGridView1.Columns.Add("Nom", "Nom du ficher");
            bunifuDataGridView1.Columns.Add("Path", "Emplacement");
            bunifuDataGridView1.Columns[2].Visible = false;
            bunifuDataGridView1.Columns[0].Width = 100;

            gridPrev.Columns.Add("Path", "Emplacement");
            gridPrev.Columns.Add("NO", "Nom Original");
            gridPrev.Columns.Add("NN", "Nouveau Nom");

            bunifuButton12.Visible = false;
            bunifuButton16.Visible = false;
            bunifuButton13.Visible = false;
            bunifuButton14.Visible = false;

            desc.initLabelVide();

            listView1.MultiSelect = true;
            listView1.View = View.List;
            listView2.MultiSelect = false;

            bunifuVScrollBar1.BindTo(bunifuDataGridView1);

            bunifuTextBox2.Enabled = false;
            bunifuTextBox3.Enabled = false;
            bunifuTextBox9.Enabled = true;
            bunifuTextBox10.Enabled = false;
            bunifuTextBox11.Enabled = false;
            bunifuTextBox7.Enabled = false;
            bunifuTextBox8.Enabled = false;
            bunifuTextBox6.Enabled = false;

            bunifuRadioButton2.Checked = true;
            bunifuRadioButton3.Checked = false;
            bunifuRadioButton4.Checked = false;
            bunifuRadioButton5.Checked = false;
            bunifuRadioButton6.Checked = false;
            bunifuRadioButton8.Checked = true;
            bunifuRadioButton9.Checked = false;
            bunifuRadioButton10.Checked = false;
            bunifuRadioButton11.Checked = false;
            bunifuRadioButton12.Checked = true;
            bunifuRadioButton13.Checked = false;
            bunifuRadioButton14.Checked = false;
            bunifuRadioButton15.Checked = false;
            bunifuRadioButton16.Checked = false;
            bunifuRadioButton17.Checked = true;
            bunifuRadioButton18.Checked = false;
            bunifuRadioButton19.Checked = false;
        }

        #region Tout les boutons de la "card Upload"
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog() { Description = "Select tour path" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            List<string> listtt = new List<string>();
            string fichierDeja = "";
            int fDeja = 0;
            int i = 0;
            if (bunifuDataGridView1.Rows.Count > 1)
                i = bunifuDataGridView1.Rows.Count - 1;

            foreach (var tt in listView1.SelectedItems)
            {
                bool deja = false;
                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                {
                    try
                    {
                        if (row.Cells["Nom"].Value.ToString() == tt.ToString().Split('{')[1].Split('}')[0])
                        {
                            fichierDeja = fichierDeja + tt.ToString().Split('{')[1].Split('}')[0] + ", ";
                            fDeja++;
                            deja = true;
                        }
                    }
                    catch { }
                }
                if (deja == false)
                {
                    listtt.Add(tt.ToString().Split('{')[1].Split('}')[0]);
                    bunifuDataGridView1.Rows.Add(++i, tt.ToString().Split('{')[1].Split('}')[0], Pathnow);
                }

                desc.Top = this.Top + 57;
                desc.Left = this.Right + 10;
            }

            if (fDeja == 1)
            {
                MessageBox.Show("Le fichier " + fichierDeja + "est déja dans votre liste, il n'a pas été transféré en double!", "Transférer");
            }
            else if (fDeja > 1)
            {
                MessageBox.Show("Les fichiers " + fichierDeja + "sont déja dans votre liste, ils n'ont pas étés transférés en double!", "Transférer");

            }

            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
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
        #endregion

        #region Tout les boutons de la "card Files selected"
        /// Deplacer vers le Haut
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows[0].Index != 0)
            {
                for (int j = 1; j < this.bunifuDataGridView1.Columns.Count; j++)
                {
                    object tmp = this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index].Value;
                    this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index].Value = this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index - 1].Value;
                    this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index - 1].Value = tmp;
                }
                int a = bunifuDataGridView1.SelectedRows[0].Index;
                bunifuDataGridView1.ClearSelection();
                this.bunifuDataGridView1.Rows[a - 1].Selected = true;
            }
            bunifuDataGridView1.Refresh();
            PrevisualisationRefresh();
        }

        /// Deplacer vers le Bas
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows[0].Index != bunifuDataGridView1.Rows.Count - 2)
            {
                for (int j = 1; j < this.bunifuDataGridView1.Columns.Count; j++)
                {
                    object tmp = this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index].Value;
                    this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index].Value = this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index + 1].Value;
                    this.bunifuDataGridView1[j, bunifuDataGridView1.SelectedRows[0].Index + 1].Value = tmp;
                }
                int i = bunifuDataGridView1.SelectedRows[0].Index;
                bunifuDataGridView1.ClearSelection();
                this.bunifuDataGridView1.Rows[i + 1].Selected = true;
            }
            bunifuDataGridView1.Refresh();
            PrevisualisationRefresh();
        }

        /// Supprimer Une ligne de la datagridview
        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            int currentIndex = bunifuDataGridView1.SelectedRows[0].Index;
            try { bunifuDataGridView1.Rows.RemoveAt(currentIndex); }
            catch { }
            for (int i = 0; i < this.bunifuDataGridView1.Rows.Count -1; i++)
            {
                bunifuDataGridView1[0, i].Value = (i + 1).ToString();
            }
            bunifuDataGridView1.Refresh();
            PrevisualisationRefresh();
        }

        /// Supprimer toutes les lignes de la datagridview
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                while (bunifuDataGridView1.Rows.Count > 0)
                {
                    bunifuDataGridView1.Rows.RemoveAt(0);
                }
            }
            catch { }       
            bunifuDataGridView1.Refresh();
            PrevisualisationRefresh();
        }
        #endregion

        #region Tout les boutons de la "card listView Propriétés"
        /// Boutons "deplacer vers le haut"
        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            int currentIndex = listView2.SelectedItems[0].Index;
            ListViewItem item = listView2.Items[currentIndex];
            var itemprop = listPropriete[currentIndex];

            if (currentIndex > 0)
            {
                listView2.Items.RemoveAt(currentIndex);
                listView2.Items.Insert(currentIndex - 1, item);

                listPropriete.RemoveAt(currentIndex);
                listPropriete.Insert(currentIndex - 1, itemprop);
            }
            else
            {
                /*If the item is the top item make it the last*/
                listView2.Items.RemoveAt(currentIndex);
                listView2.Items.Insert(listView2.Items.Count, item);

                listPropriete.RemoveAt(currentIndex);
                listPropriete.Insert(listPropriete.Count, itemprop);
            }

            foreach (ListViewItem itm in listView2.Items)
            {
                string text = itm.Text;
                itm.Text = (itm.Index + 1).ToString() + ". " + itm.Text.Split(' ')[1];
            }
            listView2.Refresh();
            PrevisualisationRefresh();
        }

        /// Boutons "deplacer vers le bas"
        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            int currentIndex = listView2.SelectedItems[0].Index;
            ListViewItem item = listView2.Items[currentIndex];
            var itemprop = listPropriete[currentIndex];

            if (currentIndex == listView2.Items.Count - 1)
            {
                listView2.Items.RemoveAt(currentIndex);
                listView2.Items.Insert(0, item);

                listPropriete.RemoveAt(currentIndex);
                listPropriete.Insert(0, itemprop);
            }
            else
            {
                /*If the item is the top item make it the last*/
                listView2.Items.RemoveAt(currentIndex);
                listView2.Items.Insert(currentIndex + 1, item);

                listPropriete.RemoveAt(currentIndex);
                listPropriete.Insert(currentIndex + 1, itemprop);
            }

            foreach (ListViewItem itm in listView2.Items)
            {
                string text = itm.Text;
                itm.Text = (itm.Index + 1).ToString() + ". " + itm.Text.Split(' ')[1];
            }
            listView2.Refresh();
            PrevisualisationRefresh();
        }

        /// Bouton "Supprimer une ligne"
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = listView2.SelectedItems[0].Index;
                listView2.Items.RemoveAt(currentIndex);
                listPropriete.RemoveAt(currentIndex);
                foreach (ListViewItem itm in listView2.Items)
                {
                    string text = itm.Text;
                    itm.Text = (itm.Index + 1).ToString() + ". " + itm.Text.Split(' ')[1];
                }
                listView2.Refresh();
                PrevisualisationRefresh();
            }
            catch
            {
                PrevisualisationRefresh();
            }
        }

        /// Boutons "Tout supprimer"
        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Items.Clear();
                listPropriete.Clear();
                PrevisualisationRefresh();
            }
            catch
            {
                PrevisualisationRefresh();
            }
        }
        #endregion

        #region Tout les boutons du menu de la "card Propiétés"
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentTab(bunifuPages1.SelectedIndex);
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
                case 3:
                    pictureBox4.Left = bunifuButton15.Right - bunifuButton15.Width;
                    break;
            }
        }
        #endregion

        #region Tout les boutons "ajouter" à l'interieur des tabPages de la "card Propiétés"
        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Inserer ins = new Inserer(bunifuTextBox1, bunifuTextBox2, bunifuTextBox3, bunifuRadioButton2, bunifuRadioButton3, bunifuRadioButton4, bunifuRadioButton5, bunifuRadioButton6);
            listPropriete.Add(ins);
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();
            ClearAll();
            PrevisualisationRefresh();
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            Supprimer supp = new Supprimer(bunifuTextBox9, bunifuTextBox10, bunifuTextBox11, bunifuRadioButton17, bunifuRadioButton18, bunifuRadioButton19);
            listPropriete.Add(supp);
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();
            ClearAll();
            PrevisualisationRefresh();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            Numéroter num = new Numéroter(bunifuTextBox7, bunifuTextBox8, bunifuRadioButton12, bunifuRadioButton13, bunifuRadioButton14, bunifuRadioButton15, bunifuRadioButton16, bunifuDataGridView1);
            listPropriete.Add(num);
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();
            ClearAll();
            PrevisualisationRefresh();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            Capitaliser capi = new Capitaliser(bunifuTextBox6, bunifuRadioButton8, bunifuRadioButton9, bunifuRadioButton10, bunifuRadioButton11);
            listPropriete.Add(capi);
            listView2.Items.Add((listPropriete.Count).ToString() + ". " + listPropriete.Last().Name);
            listView2.Refresh();
            ClearAll();
            PrevisualisationRefresh();
        }
        #endregion

        #region Tout les boutons "modifier" à l'interieur des tabPages de la "card Propiétés"
        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int p = listView2.SelectedIndices[0];
                listPropriete[p] = new Inserer(bunifuTextBox1, bunifuTextBox2, bunifuTextBox3, bunifuRadioButton2, bunifuRadioButton3, bunifuRadioButton4, bunifuRadioButton5, bunifuRadioButton6);
            }
            PrevisualisationRefresh();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int p = listView2.SelectedIndices[0];
                listPropriete[p] = new Supprimer(bunifuTextBox9, bunifuTextBox10, bunifuTextBox11, bunifuRadioButton17, bunifuRadioButton18, bunifuRadioButton19);
            }
            PrevisualisationRefresh();
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int p = listView2.SelectedIndices[0];
                listPropriete[p] = new Numéroter(bunifuTextBox7, bunifuTextBox8, bunifuRadioButton12, bunifuRadioButton13, bunifuRadioButton14, bunifuRadioButton15, bunifuRadioButton16, bunifuDataGridView1);
            }
            PrevisualisationRefresh();
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int p = listView2.SelectedIndices[0];
                listPropriete[p] = new Capitaliser(bunifuTextBox6, bunifuRadioButton8, bunifuRadioButton9, bunifuRadioButton10, bunifuRadioButton11);
            }
            PrevisualisationRefresh();
        }
        #endregion

        # region Tout les boutons de la form générale
        /// Bouton "prévisualiser"
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
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

            if (checkPrev == false)
            {
                panelPrev.Size = new Size(1010, 225);
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
                gridPrev.Enabled = true;
                this.Size = new Size(1010, 955);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
                this.Controls.Add(panelPrev);
                checkPrev = true;
            }
            else
            {
                this.Size = new Size(1010, 730);
                this.Controls.Remove(panelPrev);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9)); //Creer manuellement les corner arrondis
                checkPrev = false;
            }
            PrevisualisationRefresh();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sur de voulour appliquer le renommage ? Vous ne pourrez pas revenir en arrière !",
                      "Appliquer", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Appliquer();
                    bunifuButton2_Click(null, null);
                    break;
                case DialogResult.No:
                    break;
            }
        }
        #endregion

        #region Toutes les fonctions additionnelles
        private void PrevisualisationRefresh()
        {
            try
            {
                gridPrev.DataSource = null;
                gridPrev.Rows.Clear();

                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                {
                    if (row.Cells[1].Value != null)
                        gridPrev.Rows.Add(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), getFromInserer(row.Cells[1].Value.ToString(), row.Index));
                }
            }
            catch (Exception e) { }
        }

        private void Appliquer()
        {
            try
            {
                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                {
                    if (row.Cells[1].Value != null)
                        File.Move(row.Cells[2].Value.ToString() + @"/" + row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString() + @"/" + getFromInserer(row.Cells[1].Value.ToString(), row.Index));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            /// Raffraichit la listView1
            listFilesSelected.Clear();
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(folderDialog.SelectedPath))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFilesSelected.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }

            try
            {
                /// Raffraichit les fichiers selectionners
                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                    row.Cells[1].Value = getFromInserer(row.Cells[1].Value.ToString(), row.Index);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            /// Raffrait la listview2
            listView2.Items.Clear();
            listPropriete.Clear();
            listView2.Refresh();
        }

        private string getFromInserer(string inp, int index)
        {
            string ret = inp;
            Console.WriteLine(ret);
            foreach (Interface1 itm in listPropriete)
            {
                if (itm.Name == "Numéroter")
                {
                    ret = itm.ModificationTextNuméro(ret, index, bunifuDataGridView1.Rows.Count);
                }
                else
                {
                    ret = itm.ModificationText(ret);
                }
            }
            return ret;
        }

        /// Clear tout les textbox et radiobuttons de tout les onglets
        private void ClearAll()
        {
            bunifuTextBox1.Text = "";
            bunifuTextBox2.Text = "";
            bunifuTextBox3.Text = "";
            bunifuTextBox6.Text = "";
            bunifuTextBox7.Text = "";
            bunifuTextBox8.Text = "";
            bunifuTextBox9.Text = "";
            bunifuTextBox10.Text = "";
            bunifuTextBox11.Text = "";
            bunifuRadioButton2.Checked = true;
            bunifuRadioButton3.Checked = false;
            bunifuRadioButton4.Checked = false;
            bunifuRadioButton5.Checked = false;
            bunifuRadioButton6.Checked = false;
            bunifuRadioButton8.Checked = true;
            bunifuRadioButton9.Checked = false;
            bunifuRadioButton10.Checked = false;
            bunifuRadioButton11.Checked = false;
            bunifuRadioButton12.Checked = true;
            bunifuRadioButton13.Checked = false;
            bunifuRadioButton14.Checked = false;
            bunifuRadioButton15.Checked = false;
            bunifuRadioButton16.Checked = false;
            bunifuRadioButton17.Checked = true;
            bunifuRadioButton18.Checked = false;
            bunifuRadioButton19.Checked = false;
        }

        private string getEmplacement(int selectedRow_inDataGridViewCentrale)
        {
            return Pathnow + @"\" + bunifuDataGridView1.Rows[selectedRow_inDataGridViewCentrale].Cells[1].FormattedValue.ToString();
        }
        #endregion

        #region Ecouteurs d'evenements
        private void bunifuDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PrevisualisationRefresh();
        }

        private void bunifuDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (bunifuDataGridView1.Rows.Count == 1)
            {
                desc.initLabelVide();
            }
            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;

            PrevisualisationRefresh();
        }

        private void bunifuDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            desc.Top = this.Top + 57;
            desc.Left = this.Right + 10;

            /// Clean la description 
            bool check = false;

            /// Chope la selection "Vide"
            try { if (bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty) { } }
            catch (Exception ee)
            {
                if (ee.ToString().Contains("System.NullReferenceException: La référence d'objet n'est pas définie à une instance d'un objet."))
                {
                    check = true;
                    desc.initLabelVide();
                    desc.Hide();
                }
            }

            /// Chope la selection "Pleine"
            if (ouvertoupas == true && bunifuDataGridView1.RowCount > 1 && check == false)
            {
                try
                {
                    activePath = getEmplacement(e.RowIndex);
                    FileInfo fileInfo = new FileInfo(activePath);
                    desc.initLabelRempli(fileInfo, activePath);
                    desc.Show();
                }
                catch (Exception ee)
                {
                    //Console.WriteLine(ee.ToString());
                    desc.pictureInit();
                }
            }
            bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount + 5;
        }

        private void bunifuDataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            desc.Hide();
            desc.initLabelVide();
        }

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

                    bunifuButton8.Visible = false;
                    bunifuButton12.Visible = true;

                    Console.WriteLine("Ici Inser " + listPropriete[p].GetTextAjouter);
                }
                else if (selectedItems[0].ToString().Contains("Supprimer"))
                {
                    //// Ici si un l'item selectionné est de type Capitalisation
                    bunifuPages1.SelectedIndex = 1;
                    listPropriete[p].Send();

                    bunifuButton17.Visible = false;
                    bunifuButton16.Visible = true;

                    Console.WriteLine("Ici Supprimer");
                }
                else if (selectedItems[0].ToString().Contains("Numéroter"))
                {
                    //// Ici si un l'item selectionné est de type Capitalisation
                    bunifuPages1.SelectedIndex = 2;
                    listPropriete[p].Send();

                    bunifuButton9.Visible = false;
                    bunifuButton13.Visible = true;

                    Console.WriteLine("Ici Numéroter");
                }
                else if (selectedItems[0].ToString().Contains("Capitaliser"))
                {
                    //// Ici si un l'item selectionné est de type Capitalisation
                    bunifuPages1.SelectedIndex = 3;
                    listPropriete[p].Send();

                    bunifuButton10.Visible = false;
                    bunifuButton14.Visible = true;

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

                    bunifuButton8.Visible = true;
                    bunifuButton9.Visible = true;
                    bunifuButton10.Visible = true;
                    bunifuButton17.Visible = true;

                    bunifuButton12.Visible = false;
                    bunifuButton13.Visible = false;
                    bunifuButton14.Visible = false;
                    bunifuButton16.Visible = false;

                    Console.WriteLine("Rien");
                }
            }
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {
            desc.Top = this.Top + 57;
            desc.Left = this.Right + 10;
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            desc.Top = this.Top + 57;
            desc.Left = this.Right + 10;
        }
        #endregion Ecouteurs d'événements

        #region Ecouteurs d'evenements des radioButtons (Page "Insérer")
        private void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox2.Enabled = false;
                bunifuTextBox3.Enabled = false;
            }
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox2.Enabled = false;
                bunifuTextBox3.Enabled = false;
            }
        }

        private void bunifuRadioButton4_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox2.Enabled = true;
                bunifuTextBox3.Enabled = false;
            }
        }

        private void bunifuRadioButton5_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox2.Enabled = false;
                bunifuTextBox3.Enabled = true;
            }
        }

        private void bunifuRadioButton6_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox2.Enabled = false;
                bunifuTextBox3.Enabled = true;
            }
        }
        #endregion

        #region Ecouteurs d'evenements des radioButtons (Page "Supprimer")
        private void bunifuRadioButton17_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox9.Enabled = true;
                bunifuTextBox10.Enabled = false;
                bunifuTextBox11.Enabled = false;
            }
        }

        private void bunifuRadioButton18_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox9.Enabled = true;
                bunifuTextBox10.Enabled = false;
                bunifuTextBox11.Enabled = false;
            }
        }

        private void bunifuRadioButton19_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox9.Enabled = false;
                bunifuTextBox10.Enabled = true;
                bunifuTextBox11.Enabled = true;
            }
        }
        #endregion

        #region Ecouteurs d'evenements des radioButtons (Page "Numéroter")
        private void bunifuRadioButton12_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox7.Enabled = false;
                bunifuTextBox8.Enabled = false;
            }
        }

        private void bunifuRadioButton13_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox7.Enabled = false;
                bunifuTextBox8.Enabled = false;
            }
        }

        private void bunifuRadioButton14_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox7.Enabled = true;
                bunifuTextBox8.Enabled = false;
            }
        }

        private void bunifuRadioButton15_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox7.Enabled = false;
                bunifuTextBox8.Enabled = true;
            }
        }

        private void bunifuRadioButton16_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                bunifuTextBox7.Enabled = false;
                bunifuTextBox8.Enabled = true;
            }
        }
        #endregion

        #region Ecouteurs d'evenements des radioButtons (Page "Capitaliser")
        private void bunifuRadioButton8_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
                bunifuTextBox6.Enabled = false;
        }

        private void bunifuRadioButton9_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
                bunifuTextBox6.Enabled = false;
        }

        private void bunifuRadioButton10_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
                bunifuTextBox6.Enabled = false;
        }

        private void bunifuRadioButton11_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
                bunifuTextBox6.Enabled = true;
        }
        #endregion

    }
}
