namespace cabinet
{
    partial class gestion_rendezvous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_rendezvous));
            System.Windows.Forms.Label id_renLabel;
            System.Windows.Forms.Label date_renLabel;
            System.Windows.Forms.Label heure_renLabel;
            System.Windows.Forms.Label id_patLabel;
            System.Windows.Forms.Label id_medLabel;
            this.gestion_cabinetDataSet1 = new cabinet.gestion_cabinetDataSet1();
            this.rendezvousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendezvousTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.rendezvousTableAdapter();
            this.tableAdapterManager = new cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager();
            this.rendezvousBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rendezvousBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rendezvousDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_renTextBox = new System.Windows.Forms.TextBox();
            this.date_renDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heure_renTextBox = new System.Windows.Forms.TextBox();
            this.id_patComboBox = new System.Windows.Forms.ComboBox();
            this.id_medComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.patientsTableAdapter();
            this.medecinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinsTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.medecinsTableAdapter();
            id_renLabel = new System.Windows.Forms.Label();
            date_renLabel = new System.Windows.Forms.Label();
            heure_renLabel = new System.Windows.Forms.Label();
            id_patLabel = new System.Windows.Forms.Label();
            id_medLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingNavigator)).BeginInit();
            this.rendezvousBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestion_cabinetDataSet1
            // 
            this.gestion_cabinetDataSet1.DataSetName = "gestion_cabinetDataSet1";
            this.gestion_cabinetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendezvousBindingSource
            // 
            this.rendezvousBindingSource.DataMember = "rendezvous";
            this.rendezvousBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // rendezvousTableAdapter
            // 
            this.rendezvousTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dossiersTableAdapter = null;
            this.tableAdapterManager.medecinsTableAdapter = this.medecinsTableAdapter;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.rendezvousTableAdapter = this.rendezvousTableAdapter;
            this.tableAdapterManager.specialitesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rendezvousBindingNavigator
            // 
            this.rendezvousBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rendezvousBindingNavigator.BindingSource = this.rendezvousBindingSource;
            this.rendezvousBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rendezvousBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rendezvousBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rendezvousBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rendezvousBindingNavigatorSaveItem});
            this.rendezvousBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rendezvousBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rendezvousBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rendezvousBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rendezvousBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rendezvousBindingNavigator.Name = "rendezvousBindingNavigator";
            this.rendezvousBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rendezvousBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.rendezvousBindingNavigator.TabIndex = 0;
            this.rendezvousBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // rendezvousBindingNavigatorSaveItem
            // 
            this.rendezvousBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rendezvousBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rendezvousBindingNavigatorSaveItem.Image")));
            this.rendezvousBindingNavigatorSaveItem.Name = "rendezvousBindingNavigatorSaveItem";
            this.rendezvousBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rendezvousBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.rendezvousBindingNavigatorSaveItem.Click += new System.EventHandler(this.rendezvousBindingNavigatorSaveItem_Click);
            // 
            // rendezvousDataGridView
            // 
            this.rendezvousDataGridView.AutoGenerateColumns = false;
            this.rendezvousDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rendezvousDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rendezvousDataGridView.DataSource = this.rendezvousBindingSource;
            this.rendezvousDataGridView.Location = new System.Drawing.Point(12, 240);
            this.rendezvousDataGridView.Name = "rendezvousDataGridView";
            this.rendezvousDataGridView.RowHeadersWidth = 51;
            this.rendezvousDataGridView.RowTemplate.Height = 24;
            this.rendezvousDataGridView.Size = new System.Drawing.Size(679, 169);
            this.rendezvousDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_ren";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_ren";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_ren";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_ren";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "heure_ren";
            this.dataGridViewTextBoxColumn3.HeaderText = "heure_ren";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_pat";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_pat";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_med";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_med";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // id_renLabel
            // 
            id_renLabel.AutoSize = true;
            id_renLabel.Location = new System.Drawing.Point(69, 70);
            id_renLabel.Name = "id_renLabel";
            id_renLabel.Size = new System.Drawing.Size(43, 16);
            id_renLabel.TabIndex = 2;
            id_renLabel.Text = "id ren:";
            // 
            // id_renTextBox
            // 
            this.id_renTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "id_ren", true));
            this.id_renTextBox.Location = new System.Drawing.Point(141, 67);
            this.id_renTextBox.Name = "id_renTextBox";
            this.id_renTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_renTextBox.TabIndex = 3;
            // 
            // date_renLabel
            // 
            date_renLabel.AutoSize = true;
            date_renLabel.Location = new System.Drawing.Point(69, 99);
            date_renLabel.Name = "date_renLabel";
            date_renLabel.Size = new System.Drawing.Size(59, 16);
            date_renLabel.TabIndex = 4;
            date_renLabel.Text = "date ren:";
            // 
            // date_renDateTimePicker
            // 
            this.date_renDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rendezvousBindingSource, "date_ren", true));
            this.date_renDateTimePicker.Location = new System.Drawing.Point(141, 95);
            this.date_renDateTimePicker.Name = "date_renDateTimePicker";
            this.date_renDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_renDateTimePicker.TabIndex = 5;
            // 
            // heure_renLabel
            // 
            heure_renLabel.AutoSize = true;
            heure_renLabel.Location = new System.Drawing.Point(69, 126);
            heure_renLabel.Name = "heure_renLabel";
            heure_renLabel.Size = new System.Drawing.Size(66, 16);
            heure_renLabel.TabIndex = 6;
            heure_renLabel.Text = "heure ren:";
            // 
            // heure_renTextBox
            // 
            this.heure_renTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "heure_ren", true));
            this.heure_renTextBox.Location = new System.Drawing.Point(141, 123);
            this.heure_renTextBox.Name = "heure_renTextBox";
            this.heure_renTextBox.Size = new System.Drawing.Size(200, 22);
            this.heure_renTextBox.TabIndex = 7;
            // 
            // id_patLabel
            // 
            id_patLabel.AutoSize = true;
            id_patLabel.Location = new System.Drawing.Point(92, 158);
            id_patLabel.Name = "id_patLabel";
            id_patLabel.Size = new System.Drawing.Size(43, 16);
            id_patLabel.TabIndex = 8;
            id_patLabel.Text = "id pat:";
            // 
            // id_patComboBox
            // 
            this.id_patComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "id_pat", true));
            this.id_patComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientsBindingSource, "id_pat", true));
            this.id_patComboBox.DataSource = this.patientsBindingSource;
            this.id_patComboBox.DisplayMember = "id_pat";
            this.id_patComboBox.FormattingEnabled = true;
            this.id_patComboBox.Location = new System.Drawing.Point(141, 155);
            this.id_patComboBox.Name = "id_patComboBox";
            this.id_patComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_patComboBox.TabIndex = 9;
            this.id_patComboBox.ValueMember = "id_pat";
            // 
            // id_medLabel
            // 
            id_medLabel.AutoSize = true;
            id_medLabel.Location = new System.Drawing.Point(84, 188);
            id_medLabel.Name = "id_medLabel";
            id_medLabel.Size = new System.Drawing.Size(51, 16);
            id_medLabel.TabIndex = 10;
            id_medLabel.Text = "id med:";
            // 
            // id_medComboBox
            // 
            this.id_medComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendezvousBindingSource, "id_med", true));
            this.id_medComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medecinsBindingSource, "id_med", true));
            this.id_medComboBox.DataSource = this.medecinsBindingSource;
            this.id_medComboBox.DisplayMember = "id_med";
            this.id_medComboBox.FormattingEnabled = true;
            this.id_medComboBox.Location = new System.Drawing.Point(141, 185);
            this.id_medComboBox.Name = "id_medComboBox";
            this.id_medComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_medComboBox.TabIndex = 11;
            this.id_medComboBox.ValueMember = "id_med";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(482, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Imprimer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            // gestion_rendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_medLabel);
            this.Controls.Add(this.id_medComboBox);
            this.Controls.Add(id_patLabel);
            this.Controls.Add(this.id_patComboBox);
            this.Controls.Add(id_renLabel);
            this.Controls.Add(this.id_renTextBox);
            this.Controls.Add(date_renLabel);
            this.Controls.Add(this.date_renDateTimePicker);
            this.Controls.Add(heure_renLabel);
            this.Controls.Add(this.heure_renTextBox);
            this.Controls.Add(this.rendezvousDataGridView);
            this.Controls.Add(this.rendezvousBindingNavigator);
            this.Name = "gestion_rendezvous";
            this.Text = "gestion_rendezvous";
            this.Load += new System.EventHandler(this.gestion_rendezvous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingNavigator)).EndInit();
            this.rendezvousBindingNavigator.ResumeLayout(false);
            this.rendezvousBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestion_cabinetDataSet1 gestion_cabinetDataSet1;
        private System.Windows.Forms.BindingSource rendezvousBindingSource;
        private gestion_cabinetDataSet1TableAdapters.rendezvousTableAdapter rendezvousTableAdapter;
        private gestion_cabinetDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rendezvousBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rendezvousBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rendezvousDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_renTextBox;
        private System.Windows.Forms.DateTimePicker date_renDateTimePicker;
        private System.Windows.Forms.TextBox heure_renTextBox;
        private System.Windows.Forms.ComboBox id_patComboBox;
        private System.Windows.Forms.ComboBox id_medComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private gestion_cabinetDataSet1TableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private gestion_cabinetDataSet1TableAdapters.medecinsTableAdapter medecinsTableAdapter;
        private System.Windows.Forms.BindingSource medecinsBindingSource;
    }
}