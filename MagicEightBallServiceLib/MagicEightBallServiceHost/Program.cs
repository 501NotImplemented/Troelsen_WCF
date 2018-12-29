using System;
using System.ServiceModel;
using System.ServiceModel.Description;

using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("*** Console based WCF Host ***");

			using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
			{
				serviceHost.Open();
				DisplayHostInfo(serviceHost);

				Console.WriteLine("The service is ready.");
				Console.WriteLine("Press the Enter key to terminate service.");
			}

			Console.ReadLine();
		}

		private static void DisplayHostInfo(ServiceHost host)
		{
			Console.WriteLine();
			Console.WriteLine("*** Host Info ***");

			foreach (ServiceEndpoint serviceEndpoint in host.Description.Endpoints)
			{
				Console.WriteLine($"Address '{serviceEndpoint.Address}'");
				Console.WriteLine($"Binding '{serviceEndpoint.Binding.Name}'");
				Console.WriteLine($"Contract '{serviceEndpoint.Contract.Name}'");
				Console.WriteLine("*******");
			}
		}
	}
}
