﻿using HXF.WebServices;
using HXF.WebServices.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestServer
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    public class Service : HxfHandler
    {
        public Service()
        {
            ServiceConfig sconf = new ServiceConfig("Test");
            sconf.AddInterfaceConfig("test", "test service", typeof(ISampleService), typeof(SampleService));
            this.runtimeConfiguration.ServiceConfiguration = sconf;
        }
        
    }
}