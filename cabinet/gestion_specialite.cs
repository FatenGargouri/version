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
    public partial class gestion_specialite : Form
    {
        public gestion_specialite()
        {
            InitializeComponent();
        }

        private void specialitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_cabinetDataSet1);

        }

        private void gestion_specialite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestion_cabinetDataSet1.specialites);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            specialitesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newSpecialite = new domain.entites.specialite
            {
                
                nom_spec = nom_specTextBox.Text,

            };
            var specialiteService = new SpecialiteService(new cabinetContext());
            specialiteService.AddSpecialite(newSpecialite);
            gestion_specialite_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_specTextBox.Text);


            string nom = nom_specTextBox.Text;


            var updateSpecialite = new specialite
            {
                id_spec = id,
                nom_spec = nom,

            };

            SpecialiteService specialiteService = new SpecialiteService(new cabinetContext());
            specialiteService.UpdateSpecialite(updateSpecialite);
            gestion_specialite_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpecialiteService s = new SpecialiteService(new cabinetContext());
            int id = int.Parse(id_specTextBox.Text);
            s.DeleteSpecialite(id);
            gestion_specialite_Load(sender, e);
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestion_specialite mainForm = new gestion_specialite();
            mainForm.Show();
            this.Hide();
        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            gestion_specialite mainForm = new gestion_specialite();
            mainForm.Show();
            this.Hide();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            gestion_medecin mainForm = new gestion_medecin();
            mainForm.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            gestion_patient mainForm = new gestion_patient();
            mainForm.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            gestion_rendezvous mainForm = new gestion_rendezvous();
            mainForm.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            gestion_dossier mainForm = new gestion_dossier();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            acceuil mainForm = new acceuil();
            mainForm.Show();
            this.Hide();
        }
    }
}
