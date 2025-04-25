using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dsaproject_hashing
{
    public partial class Option : Form
    {
        private conn connection;

        public Option()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            connection = new conn();
        }

        private void lin_Click(object sender, EventArgs e)
        {
            LinearProbing();
        }

        private void qud_Click(object sender, EventArgs e)
        {
            QuadraticProbing();
        }

        private void db_Click(object sender, EventArgs e)
        {
            DoubleHashing();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Input next = new Input();
            next.Show();
            this.Hide();
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
        private void Option_Load(object sender, EventArgs e)
        {
            this.FormClosing += Option_FormClosing;
        }
        private void LinearProbing()
        {
            try
            {
                connection.OpenConnection();
                string fetchval = "SELECT Value FROM storedvaluetable";
                MySqlCommand cmd = new MySqlCommand(fetchval, connection.GetConnection());

                int n = 0;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        n++;
                    }
                }
                int[] values = new int[n];
                int[] hashTable = new int[n];

                cmd = new MySqlCommand(fetchval, connection.GetConnection());
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read())
                    {
                        values[index] = int.Parse(reader["Value"].ToString());
                        index++;
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    int key = values[j];
                    int index = key % n;

                    if (hashTable[index] == 0)
                    {
                        hashTable[index] = key;
                    }
                    else
                    {
                        for (int i = 1; i < n; i++)
                        {
                            index = (index + i) % n;
                            if (hashTable[index] == 0)
                            {
                                hashTable[index] = key;
                                break;
                            }
                        }
                    }
                }

                UpdateDatabase(hashTable);

                MessageBox.Show("Values stored in hash table using Linear Probing.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }

            Table next = new Table();
            next.Show();
            this.Hide();
        }

        private void DoubleHashing()
        {
            try
            {
                connection.OpenConnection();
                string fetchval = "SELECT Value FROM storedvaluetable";
                MySqlCommand cmd = new MySqlCommand(fetchval, connection.GetConnection());
                int n = 0;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        n++;
                    }
                }
                int[] values = new int[n];
                int[] hashTable = new int[n];

                cmd = new MySqlCommand(fetchval, connection.GetConnection());
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read())
                    {
                        values[index] = int.Parse(reader["Value"].ToString());
                        index++;
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    int key = values[j];
                    int index = key % n; 

                    if (hashTable[index] == 0)
                    {
                        hashTable[index] = key;
                    }
                    else
                    {
                        int k = n - 2;
                        int hash1 = index;  
                        int hash2 = k - (key % k);  

                        for (int m = 1; m < n; m++)
                        {
                            index = (hash1 + (m * hash2)) % n;
                            if (hashTable[index] == 0)
                            {
                                hashTable[index] = key;
                                break;
                            }
                        }
                    }
                }

                UpdateDatabase(hashTable);

                MessageBox.Show("Values stored in hash table using Double Hashing.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }
            Table next = new Table();
            next.Show();
            this.Hide();
        }
        private void QuadraticProbing()
        {
            try
            {
                connection.OpenConnection();
                string fetchval = "SELECT Value FROM storedvaluetable";
                MySqlCommand cmd = new MySqlCommand(fetchval, connection.GetConnection());

                int n = 0;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        n++;
                    }
                }
                int[] values = new int[n];
                int[] hashTable = new int[n];

                cmd = new MySqlCommand(fetchval, connection.GetConnection());
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read())
                    {
                        values[index] = int.Parse(reader["Value"].ToString());
                        index++;
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    int key = values[j];
                    int index = key % n;

                    if (hashTable[index] == 0)
                    {
                        hashTable[index] = key;
                    }
                    else
                    {
                        for (int m = 1; m < n; m++)
                        {
                            int quadraticOffset = (int)Math.Pow(m, 2);
                            index = (index + quadraticOffset) % n;

                            if (hashTable[index] == 0)
                            {
                                hashTable[index] = key;
                                break;
                            }
                        }
                    }
                }
                UpdateDatabase(hashTable);

                MessageBox.Show("Values stored in hash table using Quadratic Probing.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }
            Table next = new Table();
            next.Show();
            this.Hide();
        }
        private void UpdateDatabase(int[] hashTable)
        {
            try
            {
                connection.OpenConnection();

                string tableName = "hashtable";
                using (MySqlConnection conn = connection.GetConnection())
                {
                    for (int i = 0; i < hashTable.Length; i++)
                    {

                        string updateQuery = "UPDATE " + tableName + " SET Value = @value WHERE MemoryLocation = @location";
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            if (hashTable[i] == 0)
                            {
                                cmd.Parameters.AddWithValue("@value", DBNull.Value); 
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@value", hashTable[i]);
                            }
                            cmd.Parameters.AddWithValue("@location", i);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Update Error: {"+ex.Message+"}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
