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
    public partial class Input : Form
    {
        private conn connection;
        public List<string> valuesArray = new List<string>();
        public Input()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            connection = new conn();
            next.Enabled = false;
        }
        private void size_TextChanged(object sender, EventArgs e)
        {
        }
        private void value_TextChanged(object sender, EventArgs e)
        {
        }
        private void addedvalues_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void add_Click(object sender, EventArgs e)
        {
            string input = value.Text.Trim();
            string siz = size.Text;
            int s;
            int result;
            try
            {
                size.BackColor = Color.White;
                s = int.Parse(siz);
            
            if (s > 0)
            {
                try
            {
                result = int.Parse(input);  
              
                if (valuesArray.Contains(input))
                {
                    MessageBox.Show("Value has already been added.", "Duplicate Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    valuesArray.Add(input);
                    addedvalues.Items.Add(input);
                    value.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter any value to add.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                value.Clear();  
                return;  
            }
            }
            else
            {
                MessageBox.Show("Enter a positive number greater than 0 for tablsize to add values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch (FormatException)
            {
                size.BackColor = Color.Red;
                MessageBox.Show("Enter any valid integer value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too large or too small.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (addedvalues.SelectedItem != null)
            {
                valuesArray.Remove(addedvalues.SelectedItem.ToString());  
                addedvalues.Items.Remove(addedvalues.SelectedItem); 
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            valuesArray.Clear();  
            addedvalues.Items.Clear(); 
        }

        private void next_Click(object sender, EventArgs e)
        {
            Option next = new Option();
            next.Show();
            this.Hide();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            string siz = size.Text;
            int tableSize = -1;

            try
            {
                size.BackColor = Color.White;
                tableSize = int.Parse(siz);
                if (valuesArray.Count == 0)
                {
                    MessageBox.Show("Please add some values before proceeding.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (valuesArray.Count > tableSize)
                {
                    MessageBox.Show("The number of added values should not exceed the table size." , "Too Many Inputs ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (tableSize > 0)
                {
                    try
                    {
                        connection.OpenConnection();
                        string createtable = "DROP TABLE IF EXISTS hashtable; DROP TABLE IF EXISTS storedvaluetable; CREATE TABLE hashtable (MemoryLocation INT PRIMARY KEY, Value VARCHAR(255)); CREATE TABLE storedvaluetable (ID INT AUTO_INCREMENT PRIMARY KEY, Value VARCHAR(255));";

                        using (MySqlCommand cmd = new MySqlCommand(createtable, connection.GetConnection()))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        for (int i = 0; i < tableSize; i++)
                        {
                            string insertml = "INSERT INTO hashtable (MemoryLocation, Value) VALUES ("+i+", 'null')";
                            using (MySqlCommand cmd = new MySqlCommand(insertml, connection.GetConnection()))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        for (int i = 0; i < valuesArray.Count; i++)
                        {
                            string value = valuesArray[i]; 
                            string insertval = "INSERT INTO storedvaluetable (Value) VALUES (" + value + ")";

                            using (MySqlCommand cmd = new MySqlCommand(insertval, connection.GetConnection()))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Tables created of "+tableSize+" rows and values are saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        next.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a positive number greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                size.BackColor = Color.Red;
                MessageBox.Show("Enter any valid integer value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too large or too small.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Are you sure you want to close this window?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void Input_Load(object sender, EventArgs e)
        {
            this.FormClosing += Option_FormClosing;
        }    
    }
}
