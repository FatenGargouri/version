namespace cabinet
{
    partial class gestion_specialite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_specLabel;
            System.Windows.Forms.Label nom_specLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_specialite));
            this.gestion_cabinetDataSet1 = new cabinet.gestion_cabinetDataSet1();
            this.specialitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitesTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.specialitesTableAdapter();
            this.tableAdapterManager = new cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager();
            this.specialitesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialitesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.specialitesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_specTextBox = new System.Windows.Forms.TextBox();
            this.nom_specTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            id_specLabel = new System.Windows.Forms.Label();
            nom_specLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingNavigator)).BeginInit();
            this.specialitesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_specLabel
            // 
            id_specLabel.AutoSize = true;
            id_specLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_specLabel.ForeColor = System.Drawing.Color.Navy;
            id_specLabel.Location = new System.Drawing.Point(386, 139);
            id_specLabel.Name = "id_specLabel";
            id_specLabel.Size = new System.Drawing.Size(140, 25);
            id_specLabel.TabIndex = 2;
            id_specLabel.Text = "Id spécialité :";
            // 
            // nom_specLabel
            // 
            nom_specLabel.AutoSize = true;
            nom_specLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_specLabel.ForeColor = System.Drawing.Color.DarkBlue;
            nom_specLabel.Location = new System.Drawing.Point(386, 178);
            nom_specLabel.Name = "nom_specLabel";
            nom_specLabel.Size = new System.Drawing.Size(166, 25);
            nom_specLabel.TabIndex = 4;
            nom_specLabel.Text = "Nom spécialité :";
            // 
            // gestion_cabinetDataSet1
            // 
            this.gestion_cabinetDataSet1.DataSetName = "gestion_cabinetDataSet1";
            this.gestion_cabinetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialitesBindingSource
            // 
            this.specialitesBindingSource.DataMember = "specialites";
            this.specialitesBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // specialitesTableAdapter
            // 
            this.specialitesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dossiersTableAdapter = null;
            this.tableAdapterManager.medecinsTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.rendezvousTableAdapter = null;
            this.tableAdapterManager.specialitesTableAdapter = this.specialitesTableAdapter;
            this.tableAdapterManager.UpdateOrder = cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitesBindingNavigator
            // 
            this.specialitesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialitesBindingNavigator.BindingSource = this.specialitesBindingSource;
            this.specialitesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialitesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialitesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.specialitesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.specialitesBindingNavigatorSaveItem});
            this.specialitesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specialitesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialitesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialitesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialitesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialitesBindingNavigator.Name = "specialitesBindingNavigator";
            this.specialitesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialitesBindingNavigator.Size = new System.Drawing.Size(902, 27);
            this.specialitesBindingNavigator.TabIndex = 0;
            this.specialitesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // specialitesBindingNavigatorSaveItem
            // 
            this.specialitesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialitesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialitesBindingNavigatorSaveItem.Image")));
            this.specialitesBindingNavigatorSaveItem.Name = "specialitesBindingNavigatorSaveItem";
            this.specialitesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.specialitesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.specialitesBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialitesBindingNavigatorSaveItem_Click);
            // 
            // specialitesDataGridView
            // 
            this.specialitesDataGridView.AutoGenerateColumns = false;
            this.specialitesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.specialitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialitesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.specialitesDataGridView.DataSource = this.specialitesBindingSource;
            this.specialitesDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.specialitesDataGridView.Location = new System.Drawing.Point(327, 251);
            this.specialitesDataGridView.Name = "specialitesDataGridView";
            this.specialitesDataGridView.RowHeadersWidth = 51;
            this.specialitesDataGridView.RowTemplate.Height = 28;
            this.specialitesDataGridView.Size = new System.Drawing.Size(408, 232);
            this.specialitesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_spec";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Spécialité";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_spec";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom spécialité";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // id_specTextBox
            // 
            this.id_specTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.id_specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitesBindingSource, "id_spec", true));
            this.id_specTextBox.Location = new System.Drawing.Point(574, 139);
            this.id_specTextBox.Name = "id_specTextBox";
            this.id_specTextBox.Size = new System.Drawing.Size(132, 22);
            this.id_specTextBox.TabIndex = 3;
            // 
            // nom_specTextBox
            // 
            this.nom_specTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nom_specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitesBindingSource, "nom_spec", true));
            this.nom_specTextBox.Location = new System.Drawing.Point(574, 178);
            this.nom_specTextBox.Name = "nom_specTextBox";
            this.nom_specTextBox.Size = new System.Drawing.Size(132, 22);
            this.nom_specTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Andalus", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(357, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 64);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gestion spécialité";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(779, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 49);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(779, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 46);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(778, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 46);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(777, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 66);
            this.panel1.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 5);
            this.panel6.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 3);
            this.panel3.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(16, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 54);
            this.panel5.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Déconnexion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel27.Controls.Add(this.panel2);
            this.panel27.Controls.Add(this.label16);
            this.panel27.Location = new System.Drawing.Point(12, 207);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(286, 74);
            this.panel27.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 49);
            this.panel2.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(72, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Gestion patient";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Controls.Add(this.label14);
            this.panel18.Location = new System.Drawing.Point(12, 287);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(286, 71);
            this.panel18.TabIndex = 47;
            // 
            // panel20
            // 
            this.panel20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel20.BackgroundImage")));
            this.panel20.Location = new System.Drawing.Point(10, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(50, 43);
            this.panel20.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(59, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Gestion RendezVous";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(12, 364);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(286, 66);
            this.panel15.TabIndex = 46;
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.Location = new System.Drawing.Point(16, 9);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(50, 48);
            this.panel17.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(74, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Gestion dossier";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel22.Controls.Add(this.button5);
            this.panel22.Controls.Add(this.label17);
            this.panel22.Location = new System.Drawing.Point(12, 42);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(286, 77);
            this.panel22.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(70, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "Gestion Specialite";
            this.label17.Click += new System.EventHandler(this.label17_Click_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(12, 125);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 76);
            this.panel11.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(75, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Gestion medecin";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.Location = new System.Drawing.Point(10, 9);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(59, 51);
            this.panel12.TabIndex = 29;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Location = new System.Drawing.Point(13, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 39);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gestion_specialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_specLabel);
            this.Controls.Add(this.id_specTextBox);
            this.Controls.Add(nom_specLabel);
            this.Controls.Add(this.nom_specTextBox);
            this.Controls.Add(this.specialitesDataGridView);
            this.Controls.Add(this.specialitesBindingNavigator);
            this.Name = "gestion_specialite";
            this.Text = "gestion_specialite";
            this.Load += new System.EventHandler(this.gestion_specialite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingNavigator)).EndInit();
            this.specialitesBindingNavigator.ResumeLayout(false);
            this.specialitesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestion_cabinetDataSet1 gestion_cabinetDataSet1;
        private System.Windows.Forms.BindingSource specialitesBindingSource;
        private gestion_cabinetDataSet1TableAdapters.specialitesTableAdapter specialitesTableAdapter;
        private gestion_cabinetDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialitesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton specialitesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specialitesDataGridView;
        private System.Windows.Forms.TextBox id_specTextBox;
        private System.Windows.Forms.TextBox nom_specTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel12;
    }
}