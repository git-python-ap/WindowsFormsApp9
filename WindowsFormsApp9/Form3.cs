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

namespace WindowsFormsApp9
{
    public partial class RequestRefundForm : Form
    {
        public RequestRefundForm()
        {
            InitializeComponent();
        }

        public class RefundRequest
        {
            public string RefundID { get; set; }
            public string Reason { get; set; }
            public string Status { get; set; }

            public override string ToString()
            {
                return $"RefundID: {RefundID} - Reason: {Reason} - Status: {Status}";
            }
        }


        private void LoadPendingRefunds()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER02;Initial Catalog=OOP_FINAL2;Integrated Security=True";

            string query = "SELECT RefundID, Reason, Status FROM Request_Refund WHERE Status = 'Pending'";

            listBoxRefunds.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        RefundRequest refund = new RefundRequest
                        {
                            RefundID = reader["RefundID"].ToString(),
                            Reason = reader["Reason"].ToString(),
                            Status = reader["Status"].ToString()
                        };

                        listBoxRefunds.Items.Add(refund);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading refunds: " + ex.Message);
                }
            }
        }

        private void TopUpDetailForm_Load(object sender, EventArgs e)
        {
            LoadPendingRefunds();
        }

        private void UpdateRefundStatus(string refundID, string newStatus)
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER02;Initial Catalog=OOP_FINAL2;Integrated Security=True";

            string query = "UPDATE Request_Refund SET Status = @Status, ReviewedAt = GETDATE(), ReviewedBy = 1 WHERE RefundID = @RefundID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@RefundID", refundID);

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"{rowsAffected} refund(s) updated to {newStatus}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating refund: " + ex.Message);
                }
            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            RefundRequest selectedRefund = listBoxRefunds.SelectedItem as RefundRequest;

            if (selectedRefund != null)
            {
                UpdateRefundStatus(selectedRefund.RefundID, "Approved");
                LoadPendingRefunds(); // Refresh list after action
            }
            else
            {
                MessageBox.Show("Please select a refund to approve.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefundRequest selectedRefund = listBoxRefunds.SelectedItem as RefundRequest;

            if (selectedRefund != null)
            {
                UpdateRefundStatus(selectedRefund.RefundID, "Rejected");
                LoadPendingRefunds(); // Refresh list after action
            }
            else
            {
                MessageBox.Show("Please select a refund to reject.");
            }

        }

        private void btnBackToTopUpPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
