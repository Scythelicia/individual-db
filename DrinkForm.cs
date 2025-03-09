using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // MySQL package

namespace WindowsFormsApp1
{
    public partial class DrinkForm : Form
    {
        public DrinkForm()
        {
            InitializeComponent();
        }

        // Prices for each drink item
        decimal price1 = 500;  // Drink 1
        decimal price2 = 450;  // Drink 2
        decimal price3 = 400;  // Drink 3
        decimal price4 = 350;  // Drink 4

        // Function to process the purchase
        private void BuyDrink(string productName, decimal price)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox($"The price of {productName} is ${price}.\nEnter payment amount:", "Payment", "0");

            if (decimal.TryParse(input, out decimal payment) && payment >= price)
            {
                decimal change = payment - price;
                SaveToDatabase(productName, price, 1, payment, change);

                MessageBox.Show($"Receipt\n\nProduct: {productName}\nPrice: ${price}\nPayment: ${payment}\nChange: ${change}",
                    "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid or insufficient payment. Try again.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Function to insert purchase into the database
        private void SaveToDatabase(string productName, decimal price, int quantity, decimal payment, decimal change)
        {
            string connectionString = "server=127.0.0.1;database=db_project;uid=root;pwd=Kenneth1110@;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO transactions (product_name, price, quantity, total_amount, payment, change, transaction_date) " +
                                   "VALUES (@product_name, @price, @quantity, @total_amount, @payment, @change, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@total_amount", price * quantity);
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


        private void btnBuy1_Click(object sender, EventArgs e)
        {
            BuyDrink("Sparkling Berry Juice", price1);
        }

        private void btnBuy2_Click(object sender, EventArgs e)
        {
            BuyDrink("Wolfhook Juice", price2);
        }

        private void btnBuy3_Click(object sender, EventArgs e)
        {
            BuyDrink("Fruits of the Festival", price3);
        }

        private void btnBuy4_Click(object sender, EventArgs e)
        {
            BuyDrink("Berry & Mint Burst", price4);
        }

        private void DrinkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
