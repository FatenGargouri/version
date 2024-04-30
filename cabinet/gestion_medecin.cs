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
    public partial class gestion_medecin : Form
    {
        public gestion_medecin()
        {
            InitializeComponent();
        }

        private void medecinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medecinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_cabinetDataSet1);

        }

        private void gestion_medecin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestion_cabinetDataSet1.specialites);
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestion_cabinetDataSet1.medecins);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            medecinsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newMed = new medecin
            {
                nom_med = nom_medTextBox.Text,
                email_med = email_medTextBox.Text,
                adresse_med = adresse_medTextBox.Text,
                tel_med = tel_medTextBox.Text,
                id_spec = Convert.ToInt32(id_specComboBox.SelectedValue),
            };
            var medService = new MedecinService(new cabinetContext());
            medService.AddMedecin(newMed);
            gestion_medecin_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_med = int.Parse(id_medTextBox.Text);

            string nom_med = nom_medTextBox.Text;
            string email_med = email_medTextBox.Text;
            string adresse_med = adresse_medTextBox.Text;
            string tel_med = tel_medTextBox.Text;
            int id_spec = Convert.ToInt32(id_specComboBox.SelectedValue);

            var updatemedecin = new medecin
            {
                id_med = id_med,
                nom_med = nom_med,
                email_med = email_med,
                adresse_med = adresse_med,
                tel_med = tel_med,
                id_spec = id_spec,

            };

            MedecinService medService = new MedecinService(new cabinetContext());
            medService.UpdateMedecin(updatemedecin);
            gestion_medecin_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedecinService c = new MedecinService(new cabinetContext());
            int id = int.Parse(id_medTextBox.Text);
            c.DeleteMedecin(id);
            gestion_medecin_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Récupérer le terme de recherche saisi par l'utilisateur
            string terme = textBox1.Text.Trim();

            // Filtrer les données du DataGridView en fonction du terme de recherche
            if (!string.IsNullOrEmpty(terme))
            {
                var results = gestion_cabinetDataSet1.medecins.AsEnumerable()
                                .Where(row => row.Field<string>("nom_med").Contains(terme)
                                //|| row.Field<string>("tel_med").Contains(terme)
                                //|| row.Field<string>("adresse_med").Contains(terme)
                                //|| row.Field<string>("email_med").Contains(terme)
                                ).CopyToDataTable();

                // Mettre à jour la source de données du DataGridView avec les résultats de la recherche
                medecinsBindingSource.DataSource = results;
            }
            else
            {
                // Si le terme de recherche est vide, afficher tous les médecins
                medecinsBindingSource.DataSource = gestion_cabinetDataSet1.medecins;
            }


        }

        private void id_specComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
