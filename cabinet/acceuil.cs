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
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void acceuil_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = textBox1.Text;

            // Vérification des informations d'identification (exemple simplifié)
            if (CheckCredentials(username, password))
            {
                // Authentification réussie
                MessageBox.Show("Authentification réussie !");
                // Rediriger vers la page principale ou afficher le formulaire principal
                gestion_specialite gestion_specialite = new gestion_specialite();
                gestion_specialite.Show();
                this.Hide();
            }
            else
            {
                // Afficher un message d'erreur si l'authentification échoue
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }

        }
        private bool CheckCredentials(string username, string password)
        {
            // Implémentez votre logique d'authentification ici
            // Par exemple, vérifiez les informations d'identification dans une base de données
            // Cette méthode doit retourner true si les informations d'identification sont valides, sinon false
            return (username == "admin" && password == "admin");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void acceuil_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
