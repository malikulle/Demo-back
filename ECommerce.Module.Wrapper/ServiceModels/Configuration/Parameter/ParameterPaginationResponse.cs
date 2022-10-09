using ECommerce.Framework.SharedLibary.Paging;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter
{
    public class ParameterPaginationResponse : BasePageableModel
    {
        public List<ParameterModel> Items { get; set; }
    }
}
