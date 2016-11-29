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

            WSR_Params p = new WSR_Params();
            
            /*p.Add("pseudo", "titi");
            Response("Login", p);*/

            Response("GetPseudos", p);
            Console.ReadKey();
        }

        public static async void Response(string resource, WSR_Params p)
        {
            _CancellationAsync = new CancellationTokenSource();
            
            WSR_Result r = await ConsumeWSR.Call(@"http://localhost:4000/Service.svc/" + resource, p, TypeSerializer.Json, _CancellationAsync.Token);


            List<string> lst = (List<string>)r.Data;
            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
            
            //Console.WriteLine("mot de passe : " + r.Data);
        }
    }
}
