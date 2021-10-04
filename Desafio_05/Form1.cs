using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desafio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;
            try
            {
                con.Open();
                con.Close();
                MessageBox.Show("a conexao foi realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Falha na conexao:{0}",ex.Message));
            }

        }
    }
}
