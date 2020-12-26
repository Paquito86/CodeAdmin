using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CodeAdmin
{
    public partial class Inicio : Form
    {
        private static string cs = @"server=207.180.246.84;userid=paco_codeadmin;password=H9vYFL9lF4XyriTn;database=paco_codeadmin";

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'paco_codeadminDataSet.cad_categories' Puede moverla o quitarla según sea necesario.
            this.cad_categoriesTableAdapter.Fill(this.paco_codeadminDataSet.cad_categories);
            // TODO: esta línea de código carga datos en la tabla 'paco_codeadminDataSet.cad_projects' Puede moverla o quitarla según sea necesario.
            this.cad_projectsTableAdapter.Fill(this.paco_codeadminDataSet.cad_projects);
            // TODO: esta línea de código carga datos en la tabla 'paco_codeadminDataSet.cad_features' Puede moverla o quitarla según sea necesario.
            this.cad_featuresTableAdapter.Fill(this.paco_codeadminDataSet.cad_features);
        }
        private void buttonFReload_Click(object sender, EventArgs e)
        {
            this.cad_featuresTableAdapter.Fill(this.paco_codeadminDataSet.cad_features);
        }

        #region Crear nueva Feature

        private void ButtonFSave_Click(object sender, EventArgs e)
        {

            string NewFeatureQuery = "INSERT INTO `cad_features` (`Fcod`, `Fname`, `Fproject`, `Fdescription`, `Fcategory`, `fcomplete`) VALUES (NULL, '"+textBoxFName.Text+"', '"+comboBoxFProject.SelectedValue+"', '"+textBoxFDescription.Text+"', '"+comboBoxFCategory.SelectedValue+"', '0')";
            MySqlConnection MyConn2 = new MySqlConnection(Inicio.cs);
            MySqlCommand MyCommand2 = new MySqlCommand(NewFeatureQuery, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();

        }
        private void buttonFClean_Click(object sender, EventArgs e)
        {
            textBoxFName.Text = "";
            textBoxFDescription.Text = "";

            comboBoxFCategory.SelectedIndex = 0;
            comboBoxFProject.SelectedIndex = 0;
        }

        #endregion

        #region Crear nueva Category
        private void buttonCSave_Click(object sender, EventArgs e)
        {
            string NewCategoryQuery = "INSERT INTO `cad_categories` (`Ccod`, `Cname`, `Cdescription`) VALUES (NULL, '"+textBoxCName.Text+"', '"+textBoxCDesc.Text+"')";
            MySqlConnection MyConn2 = new MySqlConnection(Inicio.cs);
            MySqlCommand MyCommand2 = new MySqlCommand(NewCategoryQuery, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
        }
        private void buttonCClean_Click(object sender, EventArgs e)
        {
            textBoxCName.Text = "";
            textBoxCDesc.Text = "";
        }

        #endregion


    }
}