using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Make sure to install MySQL.Data package

namespace WindowsFormsApp1
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        // Prices for each food item
        decimal price1 = 1000; // Adeptus' Temptation
        decimal price2 = 900;  // Golden Crab
        decimal price3 = 750;  // Jade Parcels
        decimal price4 = 600;  // Sweet Madame

        // Function to handle the buying process
        private void BuyFood(string productName, decimal price)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"The total cost is ${price}. Please enter your payment amount:",
                "Enter Payment",
                ""
            );

            if (decimal.TryParse(input, out decimal paymentAmount))
            {
                if (paymentAmount >= price)
                {
                    decimal change = paymentAmount - price;

                    // Insert transaction into the database
                    AddToDatabase(productName, price, 1, paymentAmount, change);

                    // Show receipt
                    MessageBox.Show(
                        $"🛒 **Receipt**\n\n" +
                        $"Product: {productName}\n" +
                        $"Price: ${price}\n" +
                        $"Payment: ${paymentAmount}\n" +
                        $"Change: ${change}",
                        "Transaction Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "❌ Insufficient payment. Please enter a valid amount.",
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "⚠ Invalid input. Please enter a numeric value.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Function to insert purchase into the database
        private void AddToDatabase(string productName, decimal price, int quantity, decimal payment, decimal change)
        {
            decimal totalAmount = price * quantity;
            string connectionString = "server=127.0.0.1;database=db_project;uid=root;pwd=Kenneth1110@;"; // Update with your actual database credentials

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO transactions (product_name, price, quantity, total_amount, payment, change_amount, transaction_date) " +
                                   "VALUES (@product_name, @price, @quantity, @total_amount, @payment, @change, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                        cmd.Parameters.AddWithValue("@payment", payment);
                        cmd.Parameters.AddWithValue("@change", change);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // BUY BUTTONS
        private void btnBuy1_Click_1(object sender, EventArgs e)
        {
            BuyFood("Adeptus' Temptation", price1);
        }

        private void btnBuy2_Click_1(object sender, EventArgs e)
        {
            BuyFood("Golden Crab", price2);
        }

        private void btnBuy3_Click_1(object sender, EventArgs e)
        {
            BuyFood("Jade Parcels", price3);
        }

        private void btnBuy4_Click_1(object sender, EventArgs e)
        {
            BuyFood("Sweet Madame", price4);
        }
    }
}
