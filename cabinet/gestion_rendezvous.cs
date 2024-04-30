using cabinet.data;
using cabinet.domain.entites;
using cabinet.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace cabinet
{
    public partial class gestion_rendezvous : Form
    {
        private Font printFont;
        private StreamReader streamToPrint;
        public gestion_rendezvous()
        {
            InitializeComponent();
        }

        private void rendezvousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezvousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_cabinetDataSet1);

        }

        private void gestion_rendezvous_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestion_cabinetDataSet1.medecins);
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestion_cabinetDataSet1.patients);
            // TODO: cette ligne de code charge les données dans la table 'gestion_cabinetDataSet1.rendezvous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rendezvousTableAdapter.Fill(this.gestion_cabinetDataSet1.rendezvous);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rendezvousBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newRen = new rendezvous
            {
                date_ren = date_renDateTimePicker.Value,
                heure_ren = heure_renTextBox.Text,
                id_pat = Convert.ToInt32(id_patComboBox.SelectedValue),
                id_med = Convert.ToInt32(id_medComboBox.SelectedValue),

            };
            var medService = new RendezvousService(new cabinetContext());
            medService.AddRendezvous(newRen);
            gestion_rendezvous_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_ren = int.Parse(id_renTextBox.Text);


            DateTime date_ren = date_renDateTimePicker.Value;
            string heure_ren = heure_renTextBox.Text;
            int id_pat = Convert.ToInt32(id_patComboBox.SelectedValue);
            int id_med = Convert.ToInt32(id_medComboBox.SelectedValue);

            var updaterendezvous = new rendezvous
            {
                id_ren = id_ren,
                date_ren = date_ren,
                heure_ren = heure_ren,
                id_pat = id_pat,
                id_med = id_med,

            };
            RendezvousService renService = new RendezvousService(new cabinetContext());
            renService.UpdateRendezvous(updaterendezvous);
            gestion_rendezvous_Load(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RendezvousService c = new RendezvousService(new cabinetContext());
            int id = int.Parse(id_renTextBox.Text);
            c.DeleteRendezvous(id);
            gestion_rendezvous_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                streamToPrint = new StreamReader("D:\\sem2\\tp\\.net\\cabinet.txt");
                printFont = new Font("Arial", 10);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamToPrint.Close();
            }
        }

        // Le gestionnaire d'événements PrintPage est appelé pour chaque page à imprimer.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            // Définition des marges
            float marginX = ev.MarginBounds.Left;
            float marginY = ev.MarginBounds.Top;

            // Définition de la position de départ pour l'impression
            float positionY = marginY;

            // Définition de la largeur de chaque colonne
            List<float> columnWidths = new List<float>();
            foreach (DataGridViewColumn column in rendezvousDataGridView.Columns)
            {
                columnWidths.Add(column.Width);
            }

            // Dessiner les en-têtes de colonnes
            using (SolidBrush brush = new SolidBrush(Color.Black))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            {
                float positionX = marginX;
                for (int i = 0; i < rendezvousDataGridView.Columns.Count; i++)
                {
                    ev.Graphics.DrawString(rendezvousDataGridView.Columns[i].HeaderText, headerFont, brush, positionX, positionY);
                    positionX += columnWidths[i];
                }
                positionY += headerFont.Height;
            }

            // Dessiner les lignes de données
            using (SolidBrush brush = new SolidBrush(Color.Black))
            using (Font dataFont = new Font("Arial", 10))
            {
                foreach (DataGridViewRow row in rendezvousDataGridView.Rows)
                {
                    float positionX = marginX;
                    for (int i = 0; i < rendezvousDataGridView.Columns.Count; i++)
                    {
                        string cellValue = row.Cells[i].FormattedValue.ToString();
                        ev.Graphics.DrawString(cellValue, dataFont, brush, positionX, positionY);
                        positionX += columnWidths[i];
                    }
                    positionY += dataFont.Height;
                }
            }

            // Indiquer s'il reste d'autres pages à imprimer
            ev.HasMorePages = false; // Nous n'imprimons qu'une seule page pour l'instant

        }
    }
    }

