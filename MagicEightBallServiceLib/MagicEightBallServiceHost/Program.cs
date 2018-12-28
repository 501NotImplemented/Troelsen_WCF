using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*** Console based WCF Host ***");

			using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
			{
				serviceHost.Open();

				Console.WriteLine("The service is ready.");
				Console.WriteLine("Press the Enter key to terminate service.");
			}
			Console.ReadLine();
		}
	}
}
