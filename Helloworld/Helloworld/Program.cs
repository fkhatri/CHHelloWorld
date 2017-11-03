using API;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string applicationType=Configuration
            var factory = new ApplicationFactory();
            var applicationService = new ApplicationService(factory.Create(ConfigurationManager.AppSettings["ApplicationType"].ToString()));
            Console.WriteLine(applicationService.DisplayHelloWorld());
            Console.ReadLine();
        }
    }
}
