﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXF.WebServices.Server
{
    public class RuntimeConfiguration
    {
        public bool ReturnInternalErrors { get; set; }
        public int Latency { get; set; }
        public bool SupportCors { get; set; }
        public ServiceConfiguration ServiceConfiguration { get; set; }
    }
}
