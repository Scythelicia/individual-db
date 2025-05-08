using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Exceptions;

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

            // Check if the username is "admin"
            if (username != "admin")
            {
                button4.Enabled = false; // Disable button for non-admin users
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a new form to display the transaction history
            Form transactionHistoryForm = new Form
            {
                Text = "Transaction History",
                Size = new Size(800, 450)
            };

            // Create DataGridView
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 350,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Create Print Report button
            Button btnPrintReport = new Button
            {
                Text = "Print Report",
                Dock = DockStyle.Bottom,
                Height = 40
            };

            // Add the controls to the form
            transactionHistoryForm.Controls.Add(dataGridView);
            transactionHistoryForm.Controls.Add(btnPrintReport);

            // Load data from MySQL into DataGridView
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

                    // Set column headers with friendly names
                    dataGridView.Columns["product_name"].HeaderText = "Product";
                    dataGridView.Columns["price"].HeaderText = "Price";
                    dataGridView.Columns["quantity"].HeaderText = "Quantity";
                    dataGridView.Columns["total_amount"].HeaderText = "Total";
                    dataGridView.Columns["payment"].HeaderText = "Payment";
                    dataGridView.Columns["change_amount"].HeaderText = "Change";
                    dataGridView.Columns["transaction_date"].HeaderText = "Date";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading transaction history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnPrintReport.Click += (s, ev) =>
            {
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No transactions available to export.");
                    return;
                }

                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, $"TransactionReport_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("=== TRANSACTION REPORT ===");
                        writer.WriteLine($"Generated On: {DateTime.Now:f}");
                        writer.WriteLine("==========================\n");

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                writer.WriteLine($"Product: {row.Cells["product_name"].Value}");
                                writer.WriteLine($"Price: {row.Cells["price"].Value}");
                                writer.WriteLine($"Quantity: {row.Cells["quantity"].Value}");
                                writer.WriteLine($"Total: {row.Cells["total_amount"].Value}");
                                writer.WriteLine($"Payment: {row.Cells["payment"].Value}");
                                writer.WriteLine($"Change: {row.Cells["change_amount"].Value}");
                                writer.WriteLine($"Date: {row.Cells["transaction_date"].Value}");
                                writer.WriteLine("-----------------------------");
                            }
                        }

                        writer.WriteLine("\n=== END OF REPORT ===");
                    }

                    MessageBox.Show("Report saved as:\n" + filePath);
                    System.Diagnostics.Process.Start("notepad.exe", filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };


            // Show the form
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
            // Add your functionality here, if needed.
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
