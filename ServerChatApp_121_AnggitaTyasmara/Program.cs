using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_121;

namespace ServerChatApp_121_AnggitaTyasmara
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostobjek = null;
            try
            {
                hostobjek = new ServiceHost(typeof(ServiceCallback));
                hostobjek.Open();

                Console.WriteLine("Server On, Ready to Use");
                Console.ReadLine();

                hostobjek.Close();
            }
            catch (Exception ex)
            {
                hostobjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
