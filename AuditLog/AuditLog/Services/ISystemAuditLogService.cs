using AuditLog.Helpers;
using AuditLog.Model;

namespace AuditLog.Services
{
    public interface ISystemAuditLogService
    {
        Task<List<SystemAuditLog>> RetrieveLogs(LoggerParameters loggerParameters);
        Task<SystemAuditLog> RetrieveLog(Guid transactionId);
    }
}
