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
    public partial class gestion_patient : Form
    {
        public gestion_patient()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_cabinetDataSet1);

        }

        private void gestion_patient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestion_cabinetDataSet1.patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newPat = new patient
            {

                nom_pat = nom_patTextBox.Text,
                email_pat = email_patTextBox.Text,
                adresse_pat = adresse_patTextBox.Text,
                tel_pat = tel_patTextBox.Text,
            };
            var patService = new PatientService(new cabinetContext());
            patService.AddPatient(newPat);
            gestion_patient_Load(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_pat = int.Parse(id_patTextBox.Text);


            string nom_pat = nom_patTextBox.Text;
            string email_pat = email_patTextBox.Text;
            string adresse_pat = adresse_patTextBox.Text;
            string tel_pat = tel_patTextBox.Text;

            
            var updatepatient = new patient
            {
                id_pat = id_pat,
                nom_pat = nom_pat,
                email_pat = email_pat,
                adresse_pat = adresse_pat,
                tel_pat = tel_pat
            };

            PatientService patService = new PatientService(new cabinetContext());
            patService.UpdatePatient(updatepatient);
            gestion_patient_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientService c = new PatientService(new cabinetContext());
            int id = int.Parse(id_patTextBox.Text);
            c.DeletePatient(id);
            gestion_patient_Load(sender, e);
        }

    }
}
