using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int LecturerId { get; set; }
        public DateTime IssueDate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
