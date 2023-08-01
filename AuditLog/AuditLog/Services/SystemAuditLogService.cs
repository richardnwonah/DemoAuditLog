using AuditLog.Helpers;
using AuditLog.Model;
using System.Transactions;
using System.Linq;
using Newtonsoft.Json;

namespace AuditLog.Services
{
    public class SystemAuditLogService : ISystemAuditLogService
    {

        List<SystemAuditLog> _logs;
        public SystemAuditLogService() {
            _logs = new List<SystemAuditLog>
            {
                new SystemAuditLog{
                    TransactionId = new Guid("933dda97-6617-4da0-86e8-a1fa5c63da19"),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "3121784323",
                    TransactingAccountName = "Tomiloba Maryam",
                    TransactingBVN = "0724823333",
                    TransactionAmount = 53000,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true
                },
                 new SystemAuditLog{
                    TransactionId = new Guid("bea90acc-14db-4157-9c09-617542f97a00"),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 600,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true
                },
                   new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "5555784323",
                    TransactingAccountName = "Tomiloba Maryam",
                    TransactingBVN = "0724823333",
                    TransactionAmount = 10055,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true
                },
                 new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "2390572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 500,
                    BeneficiaryAccountNumber = "2080766748",
                   InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true
                },
                   new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "6767784323",
                    TransactingAccountName = "Tomiloba Maryam",
                    TransactingBVN = "0724823333",
                    TransactionAmount = 5000,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true
                },
                 new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1890572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 5650,
                    BeneficiaryAccountNumber = "0080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                   new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1990572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 5000,
                    BeneficiaryAccountNumber = "1490572512",
                   InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                     new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 75000,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                       new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 100000,
                    BeneficiaryAccountNumber = "2080766748",
                   InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = false

                },
                         new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1890572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 20005,
                    BeneficiaryAccountNumber = "0080166748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },

              new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1490572592",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 90000,
                    BeneficiaryAccountNumber = "108076673",
                   InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "2303572582",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 500,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = false

                },
                  new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 56655,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                    new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 56655,
                    BeneficiaryAccountNumber = "2080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                      new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1590572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 10055,
                    BeneficiaryAccountNumber = "0080166748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = false

                },
                        new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "2290572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 22655,
                    BeneficiaryAccountNumber = "2320766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                          new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1880572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 11655,
                    BeneficiaryAccountNumber = "1080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                            new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1190572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 5005,
                    BeneficiaryAccountNumber = "2000766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                              new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1120572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 5655,
                    BeneficiaryAccountNumber = "0080766748",
                   InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                                new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "0090572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 5955,
                    BeneficiaryAccountNumber = "6080766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                                  new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "1670572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 56655,
                    BeneficiaryAccountNumber = "7680766748",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },
                                    new SystemAuditLog{
                    TransactionId = new Guid(),
                    TransactionType = TransactionType.CashWithdrawals,
                    TransactingAccountNumber = "3747572512",
                    TransactingAccountName = "Jadesola Ehigiator",
                    TransactingBVN = "0724829293",
                    TransactionAmount = 1000,
                    BeneficiaryAccountNumber = "780766746",
                    InitiatorId = new Guid("99be0a38-4564-4eb1-b7a4-aad7aaf4122e"),
                    AuthorizerId = new Guid("be5cfc99-abf9-4165-80fc-70f6a3ac5e49"),
                    BranchSOLId = new Guid("85cc8e42-7b78-47b4-af15-6130e17a6555"),
                    Status = true

                },



            };
        }

        public async Task<List<SystemAuditLog>> RetrieveLogs(LoggerParameters loggerParameters)
        {
           
           
           IEnumerable<SystemAuditLog> result = _logs.Skip((loggerParameters.PageNumber - 1) * loggerParameters.PageSize)
                .Take(loggerParameters.PageSize)
        .       ToList();
            return result.ToList();

        }

        public async Task<SystemAuditLog> RetrieveLog(Guid transactionId)
        {
            //  return AuditLog.FirstOrDefault(x => x.TransactionId == transactionId);
            return null;
        }
    }
}
