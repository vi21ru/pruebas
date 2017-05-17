using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApplication1.JsonClases;

namespace ConsoleApplication1
{
    class RestService
    {
        public List<ChargePoint> Items { get; private set; }

        public async Task<string> RefreshDataAsync()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
            //http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json

            Items = new List<ChargePoint>();
            // uri = http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json
            var sresult = string.Empty;
            var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json");

            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    sresult = JsonConvert.DeserializeObject<string>(content);

                }
                else
                    Console.WriteLine("Error");
            }
            catch (Exception ex)
            {
               Debug.WriteLine(@"				ERROR {0}", ex.Message);
           }

            return sresult;
        }
        
        public async void GetHttpClientData4()
        {
            try
            {
                HttpClient clienteHttp = new HttpClient();
                clienteHttp.DefaultRequestHeaders.Accept.TryParseAdd("application/json");

                var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json");

                
                string respuestaJson = await clienteHttp.GetStringAsync(uri);

                var res = JsonConvert.DeserializeObject(respuestaJson);
                var doc = JObject.Parse(res.ToString());
                Console.WriteLine(doc);
                Console.ReadLine();
                //Console.WriteLine(doc);

                //Console.ReadLine();
                //List<Element> elementos = doc.List;
                //foreach(Element e in elementos) {
                //    Element myElement = new Element();
                //    myElement = (Element)e["element"];
                //}

                // var lista = dynObj.List.ToList();
                /*Console.WriteLine(lista);
                foreach (List<Element> element in lista)
                {
                    foreach (Element elemento in element) {
                        foreach (Attribute attr in elemento.Attribute) {
                            Console.WriteLine(attr.String);
                        }
                    }
                }*/
                //ArrayNoticias.Add(news);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }

    }
}
