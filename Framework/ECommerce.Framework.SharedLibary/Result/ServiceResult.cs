using ECommerce.Framework.SharedLibary.SQL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Result
{
    public class ServiceResult
    {
        public bool HasFailed { get; set; }
        public List<ServiceResultMessage> Messages { get; set; }

        public ServiceResult()
        {
            this.Messages = new List<ServiceResultMessage>();
        }
        public void Fail()
        {
            this.HasFailed = true;
        }
        public void Fail(ServiceResult result)
        {
            this.Messages.AddRange(result.Messages);
            this.Fail();
        }
        public void Fail(List<ServiceResultMessage> Messages)
        {
            this.Messages.AddRange(Messages);
            this.Fail();
        }

        public void Fail(string code, string message)
        {
            this.Messages.Add(new ServiceResultMessage() { Code = code, Description = message, IsError = true });
            this.Fail();
        }
        public void Fail(string message)
        {
            this.Messages.Add(new ServiceResultMessage() { Code = "E1", Description = message, IsError = true });
            this.Fail();
        }
        public void Fail(Exception ex)
        {
            this.Messages.Add(new ServiceResultMessage() { Code = "E1", Description = "SystemFailureSeeLogsForDetail", IsError = true });           
            this.Fail();
            this.WriteLog(ex);
        }
        public void AddSuccessMessage(string message)
        {
            this.AddSuccessMessage("", message);
        }

        public void AddSuccessMessage(string code, string message)
        {
            this.Messages.Add(new ServiceResultMessage() { Code = code, Description = message, IsSuccess = true });
        }

        public void AddWarningMessage(string message)
        {
            this.AddWarningMessage("", message);
        }

        public void AddWarningMessage(string code, string message)
        {
            this.Messages.Add(new ServiceResultMessage() { Code = code, Description = message, IsWarning = true });
        }

        protected void WriteLog(Exception exception)
        {
            var callingFunction = "";
            try
            {
                StackTrace stackTrace = new StackTrace();
                MethodBase methodBase = stackTrace.GetFrame(2).GetMethod();
                callingFunction = methodBase.DeclaringType.Name + "." + methodBase.Name + "(" + stackTrace.GetFrame(2).GetFileLineNumber() + ")";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            ExceptionLogHandler.WriteLog(callingFunction, exception.Message, exception.StackTrace, "", "", "", "", 0);
            if(exception.InnerException != null)
                ExceptionLogHandler.WriteLog(callingFunction, exception.InnerException.Message, exception.InnerException.StackTrace, "", "", "", "", 0);

        }
    }
}
