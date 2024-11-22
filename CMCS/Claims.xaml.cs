using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMCS
{
    /// <summary>
    /// Interaction logic for Claims.xaml
    /// </summary>
    
    public partial class Claims : Page
    {
        public Claims()
        {
            InitializeComponent();
            // Sample data for claims
            List<Claim> claims = new List<Claim>
            {
                new Claim { LecturerName = "Matlhari Nyathi", HoursWorked = "10", HourlyRate = "200", Notes = "Completed the lectures", Status = "Pending" },
                new Claim { LecturerName = "Vanessa Wayne", HoursWorked = "15", HourlyRate = "180", Notes = "Taught the evening course", Status = "Pending" }
            };

            ClaimsListView.ItemsSource = claims;
        }
        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            // Approve the selected claim
            if (ClaimsListView.SelectedItem != null)
            {
                Claim selectedClaim = (Claim)ClaimsListView.SelectedItem;
                selectedClaim.Status = "Approved";
                MessageBox.Show($"Claim for {selectedClaim.LecturerName} approved.");
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.");
            }
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            // Reject the selected claim
            if (ClaimsListView.SelectedItem != null)
            {
                Claim selectedClaim = (Claim)ClaimsListView.SelectedItem;
                selectedClaim.Status = "Rejected";
                MessageBox.Show($"Claim for {selectedClaim.LecturerName} rejected.");
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.");
            }

        }
    }

    public class Claim
    {
        public string LecturerName { get; set; }
        public string HoursWorked { get; set; }
        public string HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }
    public class ClaimStatus
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
    }

}

