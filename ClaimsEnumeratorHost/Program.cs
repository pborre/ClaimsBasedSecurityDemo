using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ClaimsEnumeratorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ClaimsEnumerationHost";
            using (ServiceHost serviceHost = new ServiceHost(typeof(ClaimsEnumeratorService.ClaimsEnumerator)))
            {
                try
                {
                   
                    
                    serviceHost.Open();

                    Console.WriteLine("The ClaimsEnumerations service is now running.");
                    Console.WriteLine("EndPoints: ");
                    foreach (ServiceEndpoint ep in serviceHost.Description.Endpoints)
                        Console.WriteLine(" " + ep.Address.Uri.ToString());
                    Console.WriteLine("Press <ENTER> to terminate Service.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    // The service can now be accessed.
                    Console.ReadLine();
                    serviceHost.Close();
                }
                catch (CommunicationException exc)
                {
                    serviceHost.Abort();
                    Console.WriteLine(exc.Message);
                    Console.ReadLine();
                }
            }

        }
    }
}
