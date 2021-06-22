namespace Inzendatu_Version1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel14 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.bunifuPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.listView1);
            this.bunifuPanel1.Controls.Add(this.bunifuTileButton4);
            this.bunifuPanel1.Controls.Add(this.bunifuTileButton3);
            this.bunifuPanel1.Controls.Add(this.bunifuTileButton2);
            this.bunifuPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuPanel1.Location = new System.Drawing.Point(9, 9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(401, 599);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(33, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 481);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Tile 1";
            this.bunifuTileButton4.Location = new System.Drawing.Point(189, 567);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(39, 25);
            this.bunifuTileButton4.TabIndex = 4;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Tile 1";
            this.bunifuTileButton3.Location = new System.Drawing.Point(323, 15);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(40, 40);
            this.bunifuTileButton3.TabIndex = 3;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Tile 1";
            this.bunifuTileButton2.Location = new System.Drawing.Point(69, 15);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuTileButton2.TabIndex = 2;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Tile 1";
            this.bunifuTileButton1.Location = new System.Drawing.Point(17, 15);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuTileButton1.TabIndex = 1;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Maroon;
            this.bunifuCards1.Controls.Add(this.bunifuPanel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(17, 130);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(419, 616);
            this.bunifuCards1.TabIndex = 1;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.6D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.bunifuPanel2;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.AllowDrop = true;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Maroon;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuPanel2.Location = new System.Drawing.Point(4, 4);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = false;
            this.bunifuPanel2.Size = new System.Drawing.Size(1492, 30);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 9;
            this.bunifuElipse2.TargetControl = this.bunifuPanel2;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowDrop = true;
            this.bunifuDataGridView1.AllowUserToOrderColumns = true;
            this.bunifuDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(453, 130);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(744, 425);
            this.bunifuDataGridView1.TabIndex = 3;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.SelectionChanged += new System.EventHandler(this.bunifuDataGridView1_SelectionChanged);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton5.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 20;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Tile 1";
            this.bunifuTileButton5.Location = new System.Drawing.Point(673, 754);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(57, 36);
            this.bunifuTileButton5.TabIndex = 4;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.pictureBox1);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel14);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel13);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel12);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel11);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel10);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel9);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel8);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel7);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel6);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel4.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel4.Location = new System.Drawing.Point(1203, 130);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(290, 448);
            this.bunifuPanel4.TabIndex = 5;
            // 
            // bunifuLabel14
            // 
            this.bunifuLabel14.AllowParentOverrides = false;
            this.bunifuLabel14.AutoEllipsis = false;
            this.bunifuLabel14.AutoSize = false;
            this.bunifuLabel14.CursorType = null;
            this.bunifuLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel14.Location = new System.Drawing.Point(145, 157);
            this.bunifuLabel14.Name = "bunifuLabel14";
            this.bunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel14.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel14.TabIndex = 19;
            this.bunifuLabel14.Text = "bunifuLabel14";
            this.bunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.AutoSize = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel13.Location = new System.Drawing.Point(145, 136);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel13.TabIndex = 18;
            this.bunifuLabel13.Text = "bunifuLabel13";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.AutoSize = false;
            this.bunifuLabel12.CursorType = null;
            this.bunifuLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel12.Location = new System.Drawing.Point(145, 115);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel12.TabIndex = 17;
            this.bunifuLabel12.Text = "bunifuLabel12";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.AutoSize = false;
            this.bunifuLabel11.CursorType = null;
            this.bunifuLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel11.Location = new System.Drawing.Point(145, 95);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel11.TabIndex = 16;
            this.bunifuLabel11.Text = "bunifuLabel11";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.AutoSize = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel10.Location = new System.Drawing.Point(145, 74);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel10.TabIndex = 15;
            this.bunifuLabel10.Text = "bunifuLabel10";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.AutoSize = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel9.Location = new System.Drawing.Point(145, 53);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel9.TabIndex = 14;
            this.bunifuLabel9.Text = "bunifuLabel9";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.AutoSize = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel8.Location = new System.Drawing.Point(145, 32);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(130, 15);
            this.bunifuLabel8.TabIndex = 13;
            this.bunifuLabel8.Text = "bunifuLabel8";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(12, 115);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(62, 15);
            this.bunifuLabel5.TabIndex = 6;
            this.bunifuLabel5.Text = "Dimensions";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel7.Location = new System.Drawing.Point(12, 157);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(73, 15);
            this.bunifuLabel7.TabIndex = 5;
            this.bunifuLabel7.Text = "Modifications";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel6.Location = new System.Drawing.Point(12, 136);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(45, 15);
            this.bunifuLabel6.TabIndex = 4;
            this.bunifuLabel6.Text = "Creation";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(12, 95);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(28, 15);
            this.bunifuLabel4.TabIndex = 3;
            this.bunifuLabel4.Text = "Taille";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(12, 74);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(26, 15);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Type";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 53);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(73, 15);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Emplacement";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 32);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(24, 13);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Nom";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 9;
            this.bunifuElipse3.TargetControl = this.pictureBox1;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 9;
            this.bunifuElipse4.TargetControl = this.bunifuDataGridView1;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(453, 584);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1040, 162);
            this.bunifuCards2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel14;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
    }
}

