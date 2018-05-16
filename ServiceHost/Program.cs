﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using ServiceProvider;

namespace ServiceHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service_Person));
            Console.WriteLine("Starting service...");
            host.Open();
            Console.WriteLine("Service started.");
            Console.ReadLine();
        }
    }
}
