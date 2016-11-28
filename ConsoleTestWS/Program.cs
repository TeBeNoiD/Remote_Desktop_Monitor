using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTestWS
{
    class Program
    {
        private static CancellationTokenSource _CancellationAsync;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Response();
            Console.ReadKey();
        }

        public static async void Response()
        {
            _CancellationAsync = new CancellationTokenSource();
            WSR_Params p = new WSR_Params();
            p.Add("pseudo", "toto");
            WSR_Result r = await ConsumeWSR.Call(@"http://localhost:4000/Service.svc/Login", p, TypeSerializer.Json, _CancellationAsync.Token);
            Console.WriteLine("mot de passe : " + r.Data);
        }
    }
}
