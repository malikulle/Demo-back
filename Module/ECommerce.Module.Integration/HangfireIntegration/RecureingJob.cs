using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Hangfire;

namespace ECommerce.Module.Integration.HangfireIntegration
{
    public class RecureingJob
    {
        private readonly IProductService _productService;
        private readonly IJobExecutionService _jobExecutionService;
        private readonly IJobService _jobService;

        public RecureingJob(IProductService productService, IJobExecutionService jobExecutionService, IJobService jobService)
        {
            _productService = productService;
            _jobExecutionService = jobExecutionService;
            _jobService = jobService;
        }

        public void Run()
        {
            //   Hangfire.RecurringJob.AddOrUpdate("CheckProductStatus", () => this.CheckProductStatus(), Cron.Minutely());
        }

        public ServiceObjectResult<bool> CheckProductStatus()
        {
            var result = new ServiceObjectResult<bool>();
            var job = _jobService.GetJob("CheckProductStatus");
            return result;
            if (job == null)
                return result;
            try
            {
                var executionID = _jobExecutionService.Start(job.ID).Data.ID;

                if (job.StatusID != StatusValue.ActiveStatusID)
                {
                    _jobExecutionService.WriteLog(executionID, "JOB PASİF DURUMDA");
                    _jobExecutionService.Finish(job.ID);
                    return result;
                }

                var products = _productService.GetProducts().ToList();

                _jobExecutionService.WriteLog(executionID, $"{products.Count} adet ürün bulundu.");
                foreach (var product in products)
                {
                    _jobExecutionService.WriteLog(executionID, $"{product.ID} ID'li ürün için sorgulama yapılıyor.");
                    _productService.CheckProductStatus(product);
                    _jobExecutionService.WriteLog(executionID, $"{product.ID} ID'li ürünün status ID düzeldi");
                }

            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            _jobExecutionService.Finish(job.ID);
            return result;
        }
    }
}
