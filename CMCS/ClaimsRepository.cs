using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMCS.DataAccess
{
    public class ClaimsRepository
    {
        private readonly CMCSContext _context;

        public ClaimsRepository(CMCSContext context)
        {
            _context = context;
        }

        // Add a new claim
        public void AddClaim(Claim claim)
        {
            _context.Claims.Add(claim);
            
        }

        // Get all claims for a specific lecturer
        public Claim GetClaim(int claimId)
        {
            return _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);
        }

        // Get all claims
        public IQueryable<Claim> GetAllClaims()
        {
            return _context.Claims.Include(c => c.Lecturer);
        }

        // Update the status of a claim
        public void UpdateClaimStatus(int claimId, string newStatus)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null)
            {
                claim.Status = newStatus;
              
            }
        }
    }
}
