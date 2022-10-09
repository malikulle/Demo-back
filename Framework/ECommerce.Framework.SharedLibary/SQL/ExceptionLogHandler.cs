using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.SQL
{
    public static class ExceptionLogHandler
    {

        public static void WriteLog(string FunctionName, string Message, string StackTrace, string MachineName, string UserAgent, string IPAddress, string SessionID, long UserID)
        {
            string command = @$"INSERT INTO [Logging].[ExceptionLog] (UserID,Message,StackTrace,IPAddress,MachineName,UserAgent,SessionID,FunctionName,DateCreated,DateModified,StatusID) VALUES (@UserID,@Message,@StackTrace,@IPAddress,@MachineName,@UserAgent,@SessionID,@FunctionName,@DateCreated,@DateModified,@StatusID)";

            SQLExecution.ExecuteCommand(command, new { FunctionName, Message, StackTrace, MachineName, UserAgent, IPAddress, SessionID, UserID, DateModified = DateTime.Now, DateCreated = DateTime.Now, StatusID = 1 });
        }
    }
}
