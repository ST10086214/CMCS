using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.DataAccess
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        public string Name { get; set; }
    }

    public class Claim
    {
        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }

    public class ClaimStatus
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
    }
}
