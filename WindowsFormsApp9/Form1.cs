using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {

        private string originalName;
        private string originalEmail;
        private string originalContact;
        private string originalAddress;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;

            listBoxFeedback.DisplayMember = "";

            // Load feedback data (you already have this line)
            LoadFeedbackData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            originalName = txtName.Text;
            originalEmail = txtEmail.Text;
            originalContact = txtContact.Text;
            originalAddress = txtAddress.Text;

            btnSave.Visible = true;
            btnCancel.Visible = true;
            ToggleEditMode(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToggleEditMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = originalName;
            txtEmail.Text = originalEmail;
            txtContact.Text = originalContact;
            txtAddress.Text = originalAddress;

            ToggleEditMode(false);
        }

        private void ToggleEditMode(bool editing)
        {
            txtName.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            txtContact.ReadOnly = !editing;
            txtAddress.ReadOnly = !editing;

            // Show or hide Save/Cancel buttons

            txtManagerID.ReadOnly = true;

            btnSave.Visible = editing;
            btnCancel.Visible = editing;
        }
        // feedbcak page

        public class Feedback
        {
            public string FeedbackID { get; set; }
            public int CustomerID { get; set; }
            public string Category { get; set; }   // this is your "Type"
            public string Date { get; set; }       // CreatedAt
            public string Message { get; set; }
            public string Status { get; set; }     // <== ADD THIS
            public string Reply { get; set; }      // <== ADD THIS

            public override string ToString()
            {
                // You can include Status if you want:
                return $"CustomerID: {CustomerID} - {Category} ({Status})";
            }
        }



        private void LoadFeedbackData()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER02;Initial Catalog=OOP_FINAL2;Integrated Security=True";

            string query = "SELECT FeedbackID, CustomerID, Category, CreatedAt, Message, Status, Reply FROM Feedback";


            listBoxFeedback.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    

                    while (reader.Read())
                    {

                        Feedback fb = new Feedback
                        {
                            FeedbackID = reader["FeedbackID"].ToString(),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            Category = reader["Category"].ToString(),
                            Date = Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd"),
                            Message = reader["Message"].ToString(),
                            Status = reader["Status"].ToString(),     // Add this line
                            Reply = reader["Reply"] == DBNull.Value ? "" : reader["Reply"].ToString() // Add this line
                        };
                        

                        listBoxFeedback.Items.Add(fb);

                        
                    }

                    reader.Close();


                    if (listBoxFeedback.Items.Count > 0)
                    {
                        listBoxFeedback.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading feedback: " + ex.Message);
                }
            }
        }

        private bool feedbackLoaded = false;

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (!feedbackLoaded)
            {
                LoadFeedbackData();
                feedbackLoaded = true;
            }

        }

        private void btnViewSelectedFeedback_Click(object sender, EventArgs e)
        {
            Feedback selectedFeedback = listBoxFeedback.SelectedItem as Feedback;

            if (selectedFeedback != null)
            {
                FeedbackDetailForm detailForm = new FeedbackDetailForm(selectedFeedback);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select feedback to view.");
            }
        }

        private void listBoxFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnViewSelectedFeedback.Enabled = (listBoxFeedback.SelectedItem != null);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == FeedbackDetailForm && !feedbackLoaded)
            {
                LoadFeedbackData();
                feedbackLoaded = true;
            }
        }

        //top-up page
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void PerformTopUp(int customerId, decimal amount)
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER02;Initial Catalog=OOP_FINAL2;Integrated Security=True";

            string query = @"
        UPDATE E_Wallet
        SET Balance = Balance + @Amount,
            LastUpdated = GETDATE()
        WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("No E_Wallet found for the specified CustomerID.");
                }
            }
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Read values from textboxes
                int customerId = int.Parse(txtCustomerID.Text);
                decimal amount = decimal.Parse(txtAmount.Text);

                // Call method to perform Top-Up
                PerformTopUp(customerId, amount);

                MessageBox.Show("Top-up successful!");

                // Clear textboxes after success
                txtCustomerID.Text = "";
                txtAmount.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid CustomerID and Amount.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error performing top-up: " + ex.Message);
            }
        }

        private void btn_RefundManager_Click(object sender, EventArgs e)
        {
            RequestRefundForm refundForm = new RequestRefundForm();
            refundForm.ShowDialog();
        }
    }
}
