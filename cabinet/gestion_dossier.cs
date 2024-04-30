using cabinet.data;
using cabinet.domain.entites;
using cabinet.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cabinet
{
    public partial class gestion_dossier : Form
    {
        public gestion_dossier()
        {
            InitializeComponent();
        }

        private void dossiersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dossiersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_cabinetDataSet1);

        }

        private void gestion_dossier_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestion_cabinetDataSet1.patients);
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.dossiers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dossiersTableAdapter.Fill(this.gestion_cabinetDataSet1.dossiers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dossiersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newDos = new dossier
            {
                condition_dos = condition_dosTextBox.Text,
                allergie_dos = allergie_dosTextBox.Text,
                sang_dos = sang_dosTextBox.Text,
                diagnostic = diagnosticTextBox.Text,
                id_pat = Convert.ToInt32(id_patComboBox.SelectedValue),
            };
            var dosService = new DossierService(new cabinetContext());
            dosService.AddDossier(newDos);
            gestion_dossier_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_dos = int.Parse(id_dosTextBox.Text);


            string condition_dos = condition_dosTextBox.Text;
            string allergie_dos = allergie_dosTextBox.Text;
            string sang_dos = sang_dosTextBox.Text;
            string diagnostic = diagnosticTextBox.Text;
            int id_pat = Convert.ToInt32(id_patComboBox.SelectedValue);

            var updatedossier = new dossier
            {
                id_dos = id_dos,
                condition_dos = condition_dos,
                allergie_dos = allergie_dos,
                sang_dos = sang_dos,
                diagnostic = diagnostic,
                id_pat = id_pat,


            };

            DossierService dosService = new DossierService(new cabinetContext());
            dosService.UpdateDossier(updatedossier);
            gestion_dossier_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DossierService c = new DossierService(new cabinetContext());
            int id = int.Parse(id_dosTextBox.Text);
            c.DeleteDossier(id);
            gestion_dossier_Load(sender, e);
        }
    }

       
    }

