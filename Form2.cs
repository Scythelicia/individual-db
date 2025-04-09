using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=db_project;Uid=root;Pwd=Kenneth1110@;";

        public Form2(string username)
        {
            InitializeComponent();

            // Display a welcome message with the username
            this.Text = "Dashboard - Welcome " + username;
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome, " + username + "!";
            welcomeLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(20, 20);

            this.Controls.Add(welcomeLabel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a new form to display the transaction history
            Form transactionHistoryForm = new Form();
            transactionHistoryForm.Text = "Transaction History";
            transactionHistoryForm.Size = new Size(800, 400);

            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            transactionHistoryForm.Controls.Add(dataGridView);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT product_name, price, quantity, total_amount, payment, change_amount, transaction_date " +
                                   "FROM transactions ORDER BY transaction_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading transaction history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            transactionHistoryForm.ShowDialog();
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add your functionality here
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrinkForm drinkForm = new DrinkForm();
            drinkForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
    foodForm.Show();
        }

        
        
    }
}
