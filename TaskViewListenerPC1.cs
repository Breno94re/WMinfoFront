using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WMinfo_Front
{
    class TaskViewListenerPC1
    {

        public static readonly HttpListener web = new HttpListener();
        public static string consoletext = "";
        public static string networktext = "";
        public static bool ok = false;
        public static string received = "";
        public static string responsetng = "";


        public static async Task StartListenAsync()
        {

            #region HTTPLISTEN
            try
            {
                
                web.Prefixes.Add("http://*:9090/PC1TASK/");
                web.Start();
                HttpListenerContext context = web.GetContext();
                string ipacesso = context.Request.RemoteEndPoint.ToString();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                //comments//
                #region Comentários PT-BR
                /* Esse Chunk é responsável por capturar a info que vem na string da API
                 * É importante notar a ordem e os divisores de tal
                 */
                #endregion

                #region EN-US Comments
                /* This chunk captures the info that comes with the API string
                 * it's important to notice that all infos are in the correct order
                 */
                #endregion
                //comments//

                string responseString = responsetng;
                
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
                string body = request.RawUrl;//Gets info from URL API string//
                string[] split = body.Split('?');


               

                if (split[1] != "done")
                {
                    if (split[1].Contains("network2423"))
                    {
                        networktext = split[1];
                       
                    }

                    string tempo = "";
                    received += split[1].Replace("$", " ").Replace("&", "\n").Replace("[", ".").Replace("]", "#").Replace("+", ",");

                    if (received.Contains("="))
                    {
                        tempo = received;
                        received = tempo.Replace("=", " ");
                    }


                }
                else
                {
                    consoletext = received;
                    received = "";
                    ok = true;
                }

               

                web.Stop();

            }
            catch (SystemException exception)
            {


                if (exception is HttpListenerException)
                {

                }



                web.Stop();

            }
            #endregion
            responsetng = "";
            await Task.Delay(100);

        }

    }
}
