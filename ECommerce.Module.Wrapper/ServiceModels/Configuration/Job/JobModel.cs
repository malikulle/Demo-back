﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Job
{
    public class JobModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte StatusID { get; set; }
    }
}
