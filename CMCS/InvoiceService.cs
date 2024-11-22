using CMCS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Services
{
    public class InvoiceService
    {
        private readonly ClaimsRepository _claimsRepository;

        public InvoiceService(ClaimsRepository claimsRepository)
        {
            _claimsRepository = claimsRepository;
        }

        // Method to generate an invoice for approved claims
        public Invoice GenerateInvoice(int lecturerId)
        {
            var approvedClaims = _claimsRepository.GetAllClaims()
                                                   .Where(c => c.LecturerId == lecturerId && c.Status == "Approved")
                                                   .ToList();

            double totalAmount = approvedClaims.Sum(c => c.HoursWorked * c.HourlyRate);
            var invoice = new Invoice
            {
                LecturerId = lecturerId,
                IssueDate = DateTime.Now,
                TotalAmount = totalAmount,
                Status = "Pending"
            };

            // Logic to save invoice in the database (Optional)
            // SaveInvoice(invoice);

            return invoice;
        }
        // Method to fetch all invoices for a specific lecturer
        public List<Invoice> GetLecturerInvoices(int lecturerId)
        {
            return new List<Invoice>();
        }
    }
}
