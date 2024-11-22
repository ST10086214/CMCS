using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Lecturers.xaml
    /// </summary>
    public partial class Lecturers : Page
    {
        public Lecturers()
        {
            InitializeComponent();
        }
        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to submit the claim
            string hoursWorked = HoursWorkedTextBox.Text;
            string hourlyRate = HourlyRateTextBox.Text;
            string notes = NotesTextBox.Text;

            // You can add logic here to save or process the claim data
            MessageBox.Show("Claim Submitted Successfully!");

            // Clear the fields after submission
            HoursWorkedTextBox.Clear();
            HourlyRateTextBox.Clear();
            NotesTextBox.Clear();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to upload supporting document
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"File selected: {filePath}");

                // You can add logic here to store or associate the file with the claim
            }
        }

    }
}
