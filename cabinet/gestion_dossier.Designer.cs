namespace cabinet
{
    partial class gestion_dossier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_dossier));
            System.Windows.Forms.Label id_dosLabel;
            System.Windows.Forms.Label condition_dosLabel;
            System.Windows.Forms.Label allergie_dosLabel;
            System.Windows.Forms.Label sang_dosLabel;
            System.Windows.Forms.Label diagnosticLabel;
            System.Windows.Forms.Label id_patLabel;
            this.gestion_cabinetDataSet1 = new cabinet.gestion_cabinetDataSet1();
            this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossiersTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.dossiersTableAdapter();
            this.tableAdapterManager = new cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager();
            this.dossiersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dossiersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dossiersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dosTextBox = new System.Windows.Forms.TextBox();
            this.condition_dosTextBox = new System.Windows.Forms.TextBox();
            this.allergie_dosTextBox = new System.Windows.Forms.TextBox();
            this.sang_dosTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_patComboBox = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new cabinet.gestion_cabinetDataSet1TableAdapters.patientsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            id_dosLabel = new System.Windows.Forms.Label();
            condition_dosLabel = new System.Windows.Forms.Label();
            allergie_dosLabel = new System.Windows.Forms.Label();
            sang_dosLabel = new System.Windows.Forms.Label();
            diagnosticLabel = new System.Windows.Forms.Label();
            id_patLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersBindingNavigator)).BeginInit();
            this.dossiersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestion_cabinetDataSet1
            // 
            this.gestion_cabinetDataSet1.DataSetName = "gestion_cabinetDataSet1";
            this.gestion_cabinetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dossiersBindingSource
            // 
            this.dossiersBindingSource.DataMember = "dossiers";
            this.dossiersBindingSource.DataSource = this.gestion_cabinetDataSet1;
            // 
            // dossiersTableAdapter
            // 
            this.dossiersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dossiersTableAdapter = this.dossiersTableAdapter;
            this.tableAdapterManager.medecinsTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.rendezvousTableAdapter = null;
            this.tableAdapterManager.specialitesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cabinet.gestion_cabinetDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dossiersBindingNavigator
            // 
            this.dossiersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dossiersBindingNavigator.BindingSource = this.dossiersBindingSource;
            this.dossiersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dossiersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dossiersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dossiersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dossiersBindingNavigatorSaveItem});
            this.dossiersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dossiersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dossiersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dossiersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dossiersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dossiersBindingNavigator.Name = "dossiersBindingNavigator";
            this.dossiersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dossiersBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.dossiersBindingNavigator.TabIndex = 0;
            this.dossiersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // dossiersBindingNavigatorSaveItem
            // 
            this.dossiersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dossiersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dossiersBindingNavigatorSaveItem.Image")));
            this.dossiersBindingNavigatorSaveItem.Name = "dossiersBindingNavigatorSaveItem";
            this.dossiersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.dossiersBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.dossiersBindingNavigatorSaveItem.Click += new System.EventHandler(this.dossiersBindingNavigatorSaveItem_Click);
            // 
            // dossiersDataGridView
            // 
            this.dossiersDataGridView.AutoGenerateColumns = false;
            this.dossiersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dossiersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dossiersDataGridView.DataSource = this.dossiersBindingSource;
            this.dossiersDataGridView.Location = new System.Drawing.Point(12, 220);
            this.dossiersDataGridView.Name = "dossiersDataGridView";
            this.dossiersDataGridView.RowHeadersWidth = 51;
            this.dossiersDataGridView.RowTemplate.Height = 24;
            this.dossiersDataGridView.Size = new System.Drawing.Size(776, 220);
            this.dossiersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_dos";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_dos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "condition_dos";
            this.dataGridViewTextBoxColumn2.HeaderText = "condition_dos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "allergie_dos";
            this.dataGridViewTextBoxColumn3.HeaderText = "allergie_dos";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sang_dos";
            this.dataGridViewTextBoxColumn4.HeaderText = "sang_dos";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diagnostic";
            this.dataGridViewTextBoxColumn5.HeaderText = "diagnostic";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_pat";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_pat";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // id_dosLabel
            // 
            id_dosLabel.AutoSize = true;
            id_dosLabel.Location = new System.Drawing.Point(53, 47);
            id_dosLabel.Name = "id_dosLabel";
            id_dosLabel.Size = new System.Drawing.Size(47, 16);
            id_dosLabel.TabIndex = 2;
            id_dosLabel.Text = "id dos:";
            // 
            // id_dosTextBox
            // 
            this.id_dosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "id_dos", true));
            this.id_dosTextBox.Location = new System.Drawing.Point(149, 44);
            this.id_dosTextBox.Name = "id_dosTextBox";
            this.id_dosTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_dosTextBox.TabIndex = 3;
            // 
            // condition_dosLabel
            // 
            condition_dosLabel.AutoSize = true;
            condition_dosLabel.Location = new System.Drawing.Point(53, 75);
            condition_dosLabel.Name = "condition_dosLabel";
            condition_dosLabel.Size = new System.Drawing.Size(90, 16);
            condition_dosLabel.TabIndex = 4;
            condition_dosLabel.Text = "condition dos:";
            // 
            // condition_dosTextBox
            // 
            this.condition_dosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "condition_dos", true));
            this.condition_dosTextBox.Location = new System.Drawing.Point(149, 72);
            this.condition_dosTextBox.Name = "condition_dosTextBox";
            this.condition_dosTextBox.Size = new System.Drawing.Size(100, 22);
            this.condition_dosTextBox.TabIndex = 5;
            // 
            // allergie_dosLabel
            // 
            allergie_dosLabel.AutoSize = true;
            allergie_dosLabel.Location = new System.Drawing.Point(53, 103);
            allergie_dosLabel.Name = "allergie_dosLabel";
            allergie_dosLabel.Size = new System.Drawing.Size(81, 16);
            allergie_dosLabel.TabIndex = 6;
            allergie_dosLabel.Text = "allergie dos:";
            // 
            // allergie_dosTextBox
            // 
            this.allergie_dosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "allergie_dos", true));
            this.allergie_dosTextBox.Location = new System.Drawing.Point(149, 100);
            this.allergie_dosTextBox.Name = "allergie_dosTextBox";
            this.allergie_dosTextBox.Size = new System.Drawing.Size(100, 22);
            this.allergie_dosTextBox.TabIndex = 7;
            // 
            // sang_dosLabel
            // 
            sang_dosLabel.AutoSize = true;
            sang_dosLabel.Location = new System.Drawing.Point(53, 131);
            sang_dosLabel.Name = "sang_dosLabel";
            sang_dosLabel.Size = new System.Drawing.Size(66, 16);
            sang_dosLabel.TabIndex = 8;
            sang_dosLabel.Text = "sang dos:";
            // 
            // sang_dosTextBox
            // 
            this.sang_dosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "sang_dos", true));
            this.sang_dosTextBox.Location = new System.Drawing.Point(149, 128);
            this.sang_dosTextBox.Name = "sang_dosTextBox";
            this.sang_dosTextBox.Size = new System.Drawing.Size(100, 22);
            this.sang_dosTextBox.TabIndex = 9;
            // 
            // diagnosticLabel
            // 
            diagnosticLabel.AutoSize = true;
            diagnosticLabel.Location = new System.Drawing.Point(53, 159);
            diagnosticLabel.Name = "diagnosticLabel";
            diagnosticLabel.Size = new System.Drawing.Size(72, 16);
            diagnosticLabel.TabIndex = 10;
            diagnosticLabel.Text = "diagnostic:";
            // 
            // diagnosticTextBox
            // 
            this.diagnosticTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "diagnostic", true));
            this.diagnosticTextBox.Location = new System.Drawing.Point(149, 156);
            this.diagnosticTextBox.Name = "diagnosticTextBox";
            this.diagnosticTextBox.Size = new System.Drawing.Size(100, 22);
            this.diagnosticTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_patLabel
            // 
            id_patLabel.AutoSize = true;
            id_patLabel.Location = new System.Drawing.Point(100, 191);
            id_patLabel.Name = "id_patLabel";
            id_patLabel.Size = new System.Drawing.Size(43, 16);
            id_patLabel.TabIndex = 15;
            id_patLabel.Text = "id pat:";
            // 
            // id_patComboBox
            // 
            this.id_patComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dossiersBindingSource, "id_pat", true));
            this.id_patComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientsBindingSource, "id_pat", true));
            this.id_patComboBox.DataSource = this.patientsBindingSource;
            this.id_patComboBox.DisplayMember = "id_pat";
            this.id_patComboBox.FormattingEnabled = true;
            this.id_patComboBox.Location = new System.Drawing.Point(149, 188);
            this.id_patComboBox.Name = "id_patComboBox";
            this.id_patComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_patComboBox.TabIndex = 16;
            this.id_patComboBox.ValueMember = "id_pat";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gestion_dossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(id_patLabel);
            this.Controls.Add(this.id_patComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_dosLabel);
            this.Controls.Add(this.id_dosTextBox);
            this.Controls.Add(condition_dosLabel);
            this.Controls.Add(this.condition_dosTextBox);
            this.Controls.Add(allergie_dosLabel);
            this.Controls.Add(this.allergie_dosTextBox);
            this.Controls.Add(sang_dosLabel);
            this.Controls.Add(this.sang_dosTextBox);
            this.Controls.Add(diagnosticLabel);
            this.Controls.Add(this.diagnosticTextBox);
            this.Controls.Add(this.dossiersDataGridView);
            this.Controls.Add(this.dossiersBindingNavigator);
            this.Name = "gestion_dossier";
            this.Text = "gestion_dossier";
            this.Load += new System.EventHandler(this.gestion_dossier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersBindingNavigator)).EndInit();
            this.dossiersBindingNavigator.ResumeLayout(false);
            this.dossiersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dossiersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestion_cabinetDataSet1 gestion_cabinetDataSet1;
        private System.Windows.Forms.BindingSource dossiersBindingSource;
        private gestion_cabinetDataSet1TableAdapters.dossiersTableAdapter dossiersTableAdapter;
        private gestion_cabinetDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dossiersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dossiersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dossiersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_dosTextBox;
        private System.Windows.Forms.TextBox condition_dosTextBox;
        private System.Windows.Forms.TextBox allergie_dosTextBox;
        private System.Windows.Forms.TextBox sang_dosTextBox;
        private System.Windows.Forms.TextBox diagnosticTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private gestion_cabinetDataSet1TableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox id_patComboBox;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}