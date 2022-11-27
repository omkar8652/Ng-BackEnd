using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgBackend.Domain.Entites.DTOs
{
    public class CustBankInfoDTO
    {
        
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public int? AccountTypeId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? AccountOperatedSince { get; set; }
        public string OrgId { get; set; }
        public string ClientId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal? UUID { get; set; }
        public double? Version { get; set; }
        public string IsActive { get; set; }
    }
}