using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp9.Form1;

namespace WindowsFormsApp9
{
    public partial class FeedbackDetailForm : Form
    {
        private Form1.Feedback feedback;
        public FeedbackDetailForm()
        {
            InitializeComponent();
        }

        private void FeedbackDetailForm_Load(object sender, EventArgs e)
        {

        }

        public FeedbackDetailForm(Form1.Feedback feedback)
        {
            InitializeComponent();
            this.feedback = feedback;
            DisplayFeedbackDetails();
        }

        private void DisplayFeedbackDetails()
        {
            lblNamee.Text = "Customer ID: " + feedback.CustomerID.ToString();  // No Name, use CustomerID
            lblType.Text = feedback.Category;                                  // Category is your Type
            lblDate.Text = feedback.Date;                                      // Date already formatted
            lblMessage.Text = feedback.Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reply = txtReply.Text;

            string connectionString = @"Data Source=localhost\MSSQLSERVER02;Initial Catalog=OOP_FINAL2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Feedback SET Reply = @Reply, Status = 'Responded' WHERE FeedbackID = @FeedbackID";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Reply", reply);
                    command.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reply sent and feedback status updated!");

                        txtReply.Text = ""; // clear textbox after sending
                    }
                    else
                    {
                        MessageBox.Show("Error updating feedback.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
