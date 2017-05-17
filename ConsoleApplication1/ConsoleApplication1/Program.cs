using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        static string result = string.Empty;
        
        static void Main(string[] args)
        {

            RestService myRS = new RestService();
            myRS.GetHttpClientData4();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public void recupera()
        {
            RestService myRS = new RestService();
            myRS.GetHttpClientData4();
            
        }
    }
}
