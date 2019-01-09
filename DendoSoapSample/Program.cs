using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DendoSoapSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DendoService.DendoService1SoapClient cl = new DendoService.DendoService1SoapClient();
            DendoService.ArrayOfString[] res = cl.DendoRank(2018);

            foreach(DendoService.ArrayOfString vs in res)
            {
                foreach(String str in vs)
                {
                    Console.Out.Write(str + "   ");
                }
                Console.Out.WriteLine();
            }
        }
    }
}
