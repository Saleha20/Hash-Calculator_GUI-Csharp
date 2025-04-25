using System;
using MySql.Data.MySqlClient; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsaproject_hashing
{
    public partial class Table : Form
    {
        private conn connection;
        public Table()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            connection = new conn();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?","Exit Application", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            Option next = new Option();
            next.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.OpenConnection();
                string query = "SELECT MemoryLocation, Value FROM hashtable"; 
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.GetConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to close this window?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }
        private void Table_Load(object sender, EventArgs e)
        {
            this.FormClosing += Option_FormClosing;
        } 
    }
}
