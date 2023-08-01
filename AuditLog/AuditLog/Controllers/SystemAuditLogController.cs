using AuditLog.Helpers;
using AuditLog.Model;
using AuditLog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemAuditLogController : ControllerBase
    {
        private readonly ISystemAuditLogService _logService;
        public SystemAuditLogController(ISystemAuditLogService logService)
        {
            _logService = logService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SystemAuditLog>>> GetSystemLogs([FromQuery] LoggerParameters loggerParameters)
        {
            return _logService.RetrieveLogs(loggerParameters).Result;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SystemAuditLog>> GetSystemLogsById(Guid transationId)
        {
            var logData = _logService.RetrieveLog(transationId);

            if (logData == null)
            {
                return NotFound();
            }

            return logData.Result;
        }
    }
}
