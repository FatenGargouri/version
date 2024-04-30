namespace cabinet
{
    partial class gestion_medecin
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
            System.Windows.Forms.Label id_medLabel;
            System.Windows.Forms.Label nom_medLabel;
            System.Windows.Forms.Label email_medLabel;
            System.Windows.Forms.Label adresse_medLabel;
            System.Windows.Forms.Label tel_medLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_medecin));
            System.Windows.Forms.Label id_specLabel;
            this.gestion_cabinetDataSet1 = new cabinet.gestion_cabinetDataSet1();
            this.medecinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinsTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.medecinsTableAdapter();
            this.tableAdapterManager = new cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager();
            this.specialitesTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.specialitesTableAdapter();
            this.medecinsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medecinsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medecinsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_medTextBox = new System.Windows.Forms.TextBox();
            this.nom_medTextBox = new System.Windows.Forms.TextBox();
            this.email_medTextBox = new System.Windows.Forms.TextBox();
            this.adresse_medTextBox = new System.Windows.Forms.TextBox();
            this.tel_medTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.specialitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fKdbomedecinsdbospecialitesidspecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_specComboBox = new System.Windows.Forms.ComboBox();
            this.gestioncabinetDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            id_medLabel = new System.Windows.Forms.Label();
            nom_medLabel = new System.Windows.Forms.Label();
            email_medLabel = new System.Windows.Forms.Label();
            adresse_medLabel = new System.Windows.Forms.Label();
            tel_medLabel = new System.Windows.Forms.Label();
            id_specLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingNavigator)).BeginInit();
            this.medecinsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbomedecinsdbospecialitesidspecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncabinetDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_medLabel
            // 
            id_medLabel.AutoSize = true;
            id_medLabel.Location = new System.Drawing.Point(79, 58);
            id_medLabel.Name = "id_medLabel";
            id_medLabel.Size = new System.Drawing.Size(51, 16);
            id_medLabel.TabIndex = 2;
            id_medLabel.Text = "id med:";
            // 
            // nom_medLabel
            // 
            nom_medLabel.AutoSize = true;
            nom_medLabel.Location = new System.Drawing.Point(79, 86);
            nom_medLabel.Name = "nom_medLabel";
            nom_medLabel.Size = new System.Drawing.Size(66, 16);
            nom_medLabel.TabIndex = 4;
            nom_medLabel.Text = "nom med:";
            // 
            // email_medLabel
            // 
            email_medLabel.AutoSize = true;
            email_medLabel.Location = new System.Drawing.Point(79, 114);
            email_medLabel.Name = "email_medLabel";
            email_medLabel.Size = new System.Drawing.Size(73, 16);
            email_medLabel.TabIndex = 6;
            email_medLabel.Text = "email med:";
            // 
            // adresse_medLabel
            // 
            adresse_medLabel.AutoSize = true;
            adresse_medLabel.Location = new System.Drawing.Point(79, 142);
            adresse_medLabel.Name = "adresse_medLabel";
            adresse_medLabel.Size = new System.Drawing.Size(90, 16);
            adresse_medLabel.TabIndex = 8;
            adresse_medLabel.Text = "adresse med:";
            // 
            // tel_medLabel
            // 
            tel_medLabel.AutoSize = true;
            tel_medLabel.Location = new System.Drawing.Point(79, 170);
            tel_medLabel.Name = "tel_medLabel";
            tel_medLabel.Size = new System.Drawing.Size(54, 16);
            tel_medLabel.TabIndex = 10;
            tel_medLabel.Text = "tel med:";
            // 
            // gestion_cabinetDataSet1
            // 
            this.gestion_cabinetDataSet1.DataSetName = "gestion_cabinetDataSet1";
            this.gestion_cabinetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinsBindingSource
            // 
            this.medecinsBindingSource.DataMember = "medecins";
            this.medecinsBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // medecinsTableAdapter
            // 
            this.medecinsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dossiersTableAdapter = null;
            this.tableAdapterManager.medecinsTableAdapter = this.medecinsTableAdapter;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.rendezvousTableAdapter = null;
            this.tableAdapterManager.specialitesTableAdapter = this.specialitesTableAdapter;
            this.tableAdapterManager.UpdateOrder = cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitesTableAdapter
            // 
            this.specialitesTableAdapter.ClearBeforeFill = true;
            // 
            // medecinsBindingNavigator
            // 
            this.medecinsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medecinsBindingNavigator.BindingSource = this.medecinsBindingSource;
            this.medecinsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medecinsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medecinsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medecinsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medecinsBindingNavigatorSaveItem});
            this.medecinsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medecinsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medecinsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medecinsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medecinsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medecinsBindingNavigator.Name = "medecinsBindingNavigator";
            this.medecinsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medecinsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.medecinsBindingNavigator.TabIndex = 0;
            this.medecinsBindingNavigator.Text = "bindingNavigator1";
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
            // medecinsBindingNavigatorSaveItem
            // 
            this.medecinsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medecinsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medecinsBindingNavigatorSaveItem.Image")));
            this.medecinsBindingNavigatorSaveItem.Name = "medecinsBindingNavigatorSaveItem";
            this.medecinsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.medecinsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.medecinsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medecinsBindingNavigatorSaveItem_Click);
            // 
            // medecinsDataGridView
            // 
            this.medecinsDataGridView.AutoGenerateColumns = false;
            this.medecinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medecinsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.medecinsDataGridView.DataSource = this.medecinsBindingSource;
            this.medecinsDataGridView.Location = new System.Drawing.Point(12, 231);
            this.medecinsDataGridView.Name = "medecinsDataGridView";
            this.medecinsDataGridView.RowHeadersWidth = 51;
            this.medecinsDataGridView.RowTemplate.Height = 24;
            this.medecinsDataGridView.Size = new System.Drawing.Size(762, 220);
            this.medecinsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_med";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_med";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_med";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom_med";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email_med";
            this.dataGridViewTextBoxColumn3.HeaderText = "email_med";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adresse_med";
            this.dataGridViewTextBoxColumn4.HeaderText = "adresse_med";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tel_med";
            this.dataGridViewTextBoxColumn5.HeaderText = "tel_med";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_spec";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_spec";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // id_medTextBox
            // 
            this.id_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "id_med", true));
            this.id_medTextBox.Location = new System.Drawing.Point(175, 55);
            this.id_medTextBox.Name = "id_medTextBox";
            this.id_medTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_medTextBox.TabIndex = 3;
            // 
            // nom_medTextBox
            // 
            this.nom_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "nom_med", true));
            this.nom_medTextBox.Location = new System.Drawing.Point(175, 83);
            this.nom_medTextBox.Name = "nom_medTextBox";
            this.nom_medTextBox.Size = new System.Drawing.Size(100, 22);
            this.nom_medTextBox.TabIndex = 5;
            // 
            // email_medTextBox
            // 
            this.email_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "email_med", true));
            this.email_medTextBox.Location = new System.Drawing.Point(175, 111);
            this.email_medTextBox.Name = "email_medTextBox";
            this.email_medTextBox.Size = new System.Drawing.Size(100, 22);
            this.email_medTextBox.TabIndex = 7;
            // 
            // adresse_medTextBox
            // 
            this.adresse_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "adresse_med", true));
            this.adresse_medTextBox.Location = new System.Drawing.Point(175, 139);
            this.adresse_medTextBox.Name = "adresse_medTextBox";
            this.adresse_medTextBox.Size = new System.Drawing.Size(100, 22);
            this.adresse_medTextBox.TabIndex = 9;
            // 
            // tel_medTextBox
            // 
            this.tel_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinsBindingSource, "tel_med", true));
            this.tel_medTextBox.Location = new System.Drawing.Point(175, 167);
            this.tel_medTextBox.Name = "tel_medTextBox";
            this.tel_medTextBox.Size = new System.Drawing.Size(100, 22);
            this.tel_medTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(488, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // specialitesBindingSource
            // 
            this.specialitesBindingSource.DataMember = "specialites";
            this.specialitesBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fKdbomedecinsdbospecialitesidspecBindingSource
            // 
            this.fKdbomedecinsdbospecialitesidspecBindingSource.DataMember = "FK_dbo.medecins_dbo.specialites_id_spec";
            this.fKdbomedecinsdbospecialitesidspecBindingSource.DataSource = this.specialitesBindingSource;
            // 
            // id_specLabel
            // 
            id_specLabel.AutoSize = true;
            id_specLabel.Location = new System.Drawing.Point(94, 198);
            id_specLabel.Name = "id_specLabel";
            id_specLabel.Size = new System.Drawing.Size(54, 16);
            id_specLabel.TabIndex = 20;
            id_specLabel.Text = "id spec:";
            // 
            // id_specComboBox
            // 
            this.id_specComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitesBindingSource, "id_spec", true));
            this.id_specComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.specialitesBindingSource1, "id_spec", true));
            this.id_specComboBox.DataSource = this.specialitesBindingSource1;
            this.id_specComboBox.DisplayMember = "id_spec";
            this.id_specComboBox.FormattingEnabled = true;
            this.id_specComboBox.Location = new System.Drawing.Point(154, 195);
            this.id_specComboBox.Name = "id_specComboBox";
            this.id_specComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_specComboBox.TabIndex = 21;
            this.id_specComboBox.ValueMember = "id_spec";
            // 
            // gestioncabinetDataSet1BindingSource
            // 
            this.gestioncabinetDataSet1BindingSource.DataSource = this.gestion_cabinetDataSet1;
            this.gestioncabinetDataSet1BindingSource.Position = 0;
            // 
            // specialitesBindingSource1
            // 
            this.specialitesBindingSource1.DataMember = "specialites";
            this.specialitesBindingSource1.DataSource = this.gestion_cabinetDataSet1;
            // 
            // gestion_medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(id_specLabel);
            this.Controls.Add(this.id_specComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_medLabel);
            this.Controls.Add(this.id_medTextBox);
            this.Controls.Add(nom_medLabel);
            this.Controls.Add(this.nom_medTextBox);
            this.Controls.Add(email_medLabel);
            this.Controls.Add(this.email_medTextBox);
            this.Controls.Add(adresse_medLabel);
            this.Controls.Add(this.adresse_medTextBox);
            this.Controls.Add(tel_medLabel);
            this.Controls.Add(this.tel_medTextBox);
            this.Controls.Add(this.medecinsDataGridView);
            this.Controls.Add(this.medecinsBindingNavigator);
            this.Name = "gestion_medecin";
            this.Text = "gestion_medecin";
            this.Load += new System.EventHandler(this.gestion_medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingNavigator)).EndInit();
            this.medecinsBindingNavigator.ResumeLayout(false);
            this.medecinsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbomedecinsdbospecialitesidspecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncabinetDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestion_cabinetDataSet1 gestion_cabinetDataSet1;
        private System.Windows.Forms.BindingSource medecinsBindingSource;
        private gestion_cabinetDataSet1TableAdapters.medecinsTableAdapter medecinsTableAdapter;
        private gestion_cabinetDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medecinsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medecinsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medecinsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_medTextBox;
        private System.Windows.Forms.TextBox nom_medTextBox;
        private System.Windows.Forms.TextBox email_medTextBox;
        private System.Windows.Forms.TextBox adresse_medTextBox;
        private System.Windows.Forms.TextBox tel_medTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private gestion_cabinetDataSet1TableAdapters.specialitesTableAdapter specialitesTableAdapter;
        private System.Windows.Forms.BindingSource specialitesBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource fKdbomedecinsdbospecialitesidspecBindingSource;
        private System.Windows.Forms.ComboBox id_specComboBox;
        private System.Windows.Forms.BindingSource specialitesBindingSource1;
        private System.Windows.Forms.BindingSource gestioncabinetDataSet1BindingSource;
    }
}