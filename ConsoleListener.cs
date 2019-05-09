using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMinfo_Front
{
    class ConsoleListener
    {
        public static readonly HttpListener web = new HttpListener();
        public static string consoletext = "";
        public static bool receiving;


        public static async void StartListenAsync()
        {

            #region HTTPLISTEN
            try
            {
                web.Prefixes.Add("http://*:8080/PC1CONSOLE/");
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

                string responseString = "Ok";

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();

                string body = request.RawUrl;//Gets info from URL API string//
                string[] split = body.Split('?');
                if (split[1] != "done")
                {
                    if (ConsolePC1.command.Contains("chkdsk"))
                    {
                        consoletext = split[1].Replace("-", ".").Replace("*", " ").Replace("$", ":").Replace("&", "\n").Replace("[", ";").Replace("]", "%");
                    }
                    if(ConsolePC1.command.Contains("ipconfig"))
                    {
                        consoletext = split[1].Replace("$", ".").Replace("[", " ").Replace("]", ":").Replace("&", "\n").Replace("+", "%");
                    }
                    if (ConsolePC1.command.Contains("taskkill"))
                    {
                        consoletext = split[1].Replace("&", " ").Replace("-", ".").Replace("[", "!");
                    }
                    if (ConsolePC1.command.Contains("netstat") || ConsolePC1.command.Contains("netstat -a") || ConsolePC1.command.Contains("netstat -b") || ConsolePC1.command.Contains("netstat -f") || ConsolePC1.command.Contains("netstat -o") || ConsolePC1.command.Contains("netstat -t") || ConsolePC1.command.Contains("netstat -y"))
                    {
                        consoletext = split[1].Replace("$", ".").Replace("+", ":").Replace("/", " ").Replace("&", "\n");
                    }
                    if (ConsolePC1.command.Contains("netstat -e") || ConsolePC1.command.Contains("netstat -e -s") || ConsolePC1.command.Contains("netstat -s") || ConsolePC1.command.Contains("netstat -n"))
                    {
                        consoletext = split[1].Replace("$", " ").Replace("&", "\n");
                    }

                    if (ConsolePC1.command.Contains("netstat -r"))
                    {
                        consoletext = split[1].Replace("$", " ").Replace("&", "\n").Replace("+", "#").Replace("_", ".");
                    }

                    if (ConsolePC1.command.Contains("tasklist"))
                    {
                        consoletext = split[1].Replace("$", " ").Replace("&", "\n").Replace("[", ".").Replace("]", "#").Replace("+", ",");
                    }

                }
                else
                {
                    consoletext = "Done!";
                    receiving = false;
                }

                web.Stop();

            }
            catch (SystemException exception)
            {

            }
            web.Stop();
            #endregion
            await Task.Delay(100);

        }



    }
}
