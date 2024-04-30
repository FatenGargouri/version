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
using cabinet.data;

namespace cabinet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newSpecialite = new domain.entites.specialite
            {
                nom_spec = textBox1.Text,


            };
            var categoryService = new SpecialiteService(new cabinetContext());
            categoryService.AddSpecialite(newSpecialite);
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
