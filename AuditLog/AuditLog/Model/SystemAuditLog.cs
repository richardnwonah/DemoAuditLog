using System.Security.Principal;
using System.Transactions;

namespace AuditLog.Model
{
    public class SystemAuditLog
    { 
        public Guid? TransactionId { get; set;}
        public TransactionType TransactionType { get; set; }    
        public string TransactingAccountNumber { get; set; }
        public string TransactingAccountName { get; set; }
        public string TransactingBVN { get; set; } 
        public decimal TransactionAmount { get; set; }
        public string BeneficiaryAccountNumber { get; set; }
        public Guid? InitiatorId { get; set; }
        public Guid? AuthorizerId { get; set;} 
        public Guid? BranchSOLId { get; set; } 
        public bool Status { get; set; }

    }
}
