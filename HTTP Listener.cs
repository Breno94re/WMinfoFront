using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WMinfo_Front
{
    class ListenerPC1
    {

        #region Private Hardware's Variables
        static private string cpuinfo = "";
        static private string gpuinfo = "";
        static private string raminfo = "";
        static private string hddinfo = "";
        static private string pinginfo = "";
        static private string moboinfo = "";
        static private string networkinfo = "";
        #endregion

        #region Private Network Variables
        private static string responses = "Accept";
        private static string mastercontent;
        private static string ipacesso;
        private static bool status;
        #endregion

        public void StartListen()
        {
            Task.Run(() => listen());
            do
            {
                #region TCP Listen
                try
                {
                    string content = "";
                    content = mastercontent;
                    #region GET() info

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

                    if (content != "" && content != null)
                    {
                        string[] splitgroups = content.Split('$');//string that separates groups in that order: CPU,GPU,HDD,RAM

                        
                        #region CPU info

                        cpuinfo = splitgroups[0];//1st group CPU

                        #endregion

                        #region GPU INFO

                        gpuinfo = splitgroups[1]; //2nd group GPU

                        #endregion

                        #region HDD INFO
                        hddinfo = splitgroups[2]; //3rd group HDD
                        #endregion

                        #region RAM INFO

                        raminfo = splitgroups[3]; //4th group RAM

                        #endregion

                        #region PING INFO
                        pinginfo = splitgroups[4];
                        #endregion

                        #region NETWORK INFO

                        networkinfo = splitgroups[5]; //5th group NETWORK

                        #endregion

                        #region MOBO and System INFO

                        moboinfo = splitgroups[6];

                        #endregion

                        #endregion
                    }
                }
                catch (SystemException exception)
                {
                    string currentime = DateTime.Now.ToString("HH:mm:ss tt");
                    DateTime dateTime = DateTime.UtcNow.Date;
                    string data = dateTime.ToString("dd/MM/yyyy");
                    string text = "";
                    StreamReader Reader = new StreamReader(Application.StartupPath + "//" + "log.txt");
                    text = Reader.ReadToEnd();
                    Reader.Close();
                    string specificerror = "";
                    specificerror = exception.ToString().Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace(" ", String.Empty);

                    if (exception is HttpListenerException)
                    {
                        StreamWriter writer = new StreamWriter(Application.StartupPath + "//" + "log.txt");
                        writer.WriteLine(text + "\n");
                        writer.WriteLine("[" + data + "] [" + currentime + "]" + "Unable to Execute the HTTP server, Error 505" + "&Original Error: " + specificerror + "&Error Type: Common, if the program ins't working, try to execute again with Administrator privileges");
                        writer.Close();
                        ConsolePC1.content = true;
                    }

                    else
                    {
                        ConsolePC1.content = true;
                        StreamWriter writer = new StreamWriter(Application.StartupPath + "//" + "log.txt");
                        writer.WriteLine(text + "\n");
                        if (exception.ToString().Contains("121") || exception.ToString().Contains("128"))
                            writer.WriteLine("[" + data + "] " + "Bad string through HTTP server, error 121 or 128" + "&Original Error: " + exception.ToString() + "&Error Type: Common, the program will maintain execution as it should");
                        else
                        {
                            writer.WriteLine("[" + data + "] " + "Unknow error, please contact the devteam " + "&Original error:" + specificerror);
                        }
                        writer.Close();
                    }
                }
                #endregion
               
                Thread.Sleep(50);
            } while (true);

        }

        #region Hardware GetMethod's

        #region CPU info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação da CPU
         * o divisor dessas informações é: "/"
         * é importante notar que a ordem da informação, são: Marca e Modelo,Cores,Clock,Temperaturas e Load
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the CPU info
         * The divisor used to do that is "/"
         * it's importante to notice that all info are in especific order: Brand and Model, Cores, Clock, Temperatures and Load
         */
        #endregion

        public static string GetCPUInfo()
        {
            string infos = cpuinfo;
            cpuinfo = "";
            return infos;
        }
        #endregion

        #region RAM info
        public static string GetRAMinfo()
        {
            string[] ramsplit = raminfo.Split('/');
            raminfo = "";
            string ramtotal = "";
            string ramavailabe = "";
            ulong raminuse = 0;
            ulong ramtotal1 = 0;
            ulong availabe = 0;

            ramtotal = ramsplit[0];
            ramavailabe = ramsplit[1];


            ramtotal1 = ulong.Parse(ramsplit[0]) / 1024;
            availabe = ulong.Parse(ramsplit[1]) / 1024;

            raminuse = ramtotal1 - availabe;

            double totalfinal = 0;
            double usefinal = 0;

            totalfinal = Math.Round(Convert.ToDouble((ramtotal1 / 1024)), 2);
            usefinal = Math.Round(Convert.ToDouble((raminuse / 1024)), 2);

            string count = Math.Round(usefinal / totalfinal * 100).ToString();

            totalfinal = Math.Round(totalfinal / 1000);
            usefinal = Math.Round(usefinal / 1000, 2);

            string info = "";
           
            info = ramtotal + "/" + ramavailabe + "/" + usefinal.ToString() + "/" + totalfinal.ToString() + "/" + count;

            return info;

        }
        #endregion

        #region HDD info


        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação do HDD
         * o divisor dessas informações é: "/"
         * é importante notar que a ordem da informação, são: nome,drivername,driverformat,totalspace,emptyspace,worsttemp,actualtemp,power on hours(POH),power Cycle Count(PCC)
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the HDD info
         * The divisor used to do that is "/"
         * it's importante to notice that all info are in especific order: name,drivername,driverformat,totalspace,emptyspace,worsttemp,actualtemp,power on hours(POH),power Cycle Count(PCC)
         */
        #endregion
       

        public static string GetHDDinfo()
        {
            string[] splitline3 = hddinfo.Split('/');
            hddinfo = "";
            string info = "";
            string mathhdd = "";
            string mathhdd2 = "";
            string Hddcount = "";

            #region HDD's
            if (splitline3.Length >= 1)
            {
                Hddcount = splitline3.Length.ToString();
                string[] hdd1split = splitline3[0].Split('&');

                ulong hdd1used = 0;
                hdd1used = ulong.Parse(hdd1split[3]) - ulong.Parse(hdd1split[4]);

                ulong hdd1dfree = 0;
                hdd1dfree = ulong.Parse(hdd1split[4]);

                ulong hdd1dTotal = 0;
                hdd1dTotal = ulong.Parse(hdd1split[3]);


                double hdd1d = 0;
                double hdd1df = 0;
                hdd1d = Math.Round(Convert.ToDouble(hdd1used / 1024), 2);
                hdd1df = Math.Round((hdd1d / 1000), 2);//usedspace
                hdd1df = Math.Round((hdd1df / 1000), 2);//usedspace

                double hdd1d1 = 0;
                double hdd1df1 = 0;

                hdd1d1 = Math.Round(Convert.ToDouble(hdd1dfree / 1024), 2);
                hdd1df1 = Math.Round((hdd1d1 / 1000), 2);//freespace
                hdd1df1 = Math.Round((hdd1df1 / 1000), 2);//freespace

                double hdd1d2 = 0;
                double hdd1df2 = 0;

                hdd1d2 = Math.Round(Convert.ToDouble(hdd1dTotal / 1024), 2);
                hdd1df2 = Math.Round((hdd1d2 / 1000), 2);//Totalspace
                hdd1df2 = Math.Round((hdd1df2 / 1000), 2);//Totalspace

                mathhdd += hdd1df2.ToString() + "&";
                mathhdd += hdd1df.ToString();

                if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null)
                {
                    double k = 0;

                    if (double.TryParse(hdd1split[7], out k) == false)
                    {

                    }
                    else
                    {
                        mathhdd2 += hdd1split[7]+ "&";
                    }

                }


                if (hdd1split[8] != "" || hdd1split[8] != " " || hdd1split[8] != string.Empty || hdd1split[8] != null)
                {
                    double k = 0;

                    if (double.TryParse(hdd1split[8], out k) == false)
                    {

                    }
                    else
                    {
                        mathhdd2 += hdd1split[8];
                    }
                }

                info+= hdd1split[0] + "&";
                info += "Local: " + hdd1split[1] + "&";
                info +=  "Format: " + hdd1split[2] + "&";
                info += "Total Space: " + hdd1df2.ToString() + "Gbs" + "&";
                info += "Free Space: " + hdd1df1.ToString() + "Gbs" + "&";
                info += "Used Space: " + hdd1df.ToString() + "Gbs" + "&"; ;
                info += "Worst(lifetime): " + hdd1split[5] + "ºC" + "&";
                info += "Current Temp: " + hdd1split[6] + "ºC" + "&";
                info += "POH(Power On Hours): " + hdd1split[7] + " Hours" + "&";
                info += "PCC(Power Cycle Count): " + hdd1split[8] + " Times";

                #region 2 HDD's
                if (splitline3.Length >= 2)
                {

                    string[] hdd2split = splitline3[1].Split('&');


                    ulong hdd2used = 0;
                    hdd2used = ulong.Parse(hdd2split[3]) - ulong.Parse(hdd2split[4]);

                    ulong hdd2dfree = 0;
                    hdd2dfree = ulong.Parse(hdd2split[4]);

                    ulong hdd2dTotal = 0;
                    hdd2dTotal = ulong.Parse(hdd2split[3]);


                    double hdd2d = 0;
                    double hdd2df = 0;
                    hdd2d = Math.Round(Convert.ToDouble(hdd2used / 1024), 2);
                    hdd2df = Math.Round((hdd2d / 1000), 2);//usedspace
                    hdd2df = Math.Round((hdd2df / 1000), 2);//usedspace

                    double hdd2d1 = 0;
                    double hdd2df1 = 0;

                    hdd2d1 = Math.Round(Convert.ToDouble(hdd2dfree / 1024), 2);
                    hdd2df1 = Math.Round((hdd2d1 / 1000), 2);//freespace
                    hdd2df1 = Math.Round((hdd2df1 / 1000), 2);//freespace

                    double hdd2d2 = 0;
                    double hdd2df2 = 0;

                    hdd2d2 = Math.Round(Convert.ToDouble(hdd2dTotal / 1024), 2);
                    hdd2df2 = Math.Round((hdd2d2 / 1000), 2);//Totalspace
                    hdd2df2 = Math.Round((hdd2df2 / 1000), 2);//Totalspace

                    mathhdd += "&" + hdd2df2.ToString() + "&";
                    mathhdd += hdd2df.ToString();

                    if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null)
                    {

                        double k = 0;

                        if (double.TryParse(hdd1split[7], out k) == false)
                        {

                        }
                        else
                        {
                            mathhdd2 += "&" + hdd2split[7] + "&";
                        }


                    }
                    if (hdd1split[8] != "" || hdd1split[8] != " " || hdd1split[8] != string.Empty || hdd1split[8] != null)
                    {
                        double k = 0;

                        if (double.TryParse(hdd1split[7], out k) == false)
                        {

                        }
                        else
                        {
                            mathhdd2 += hdd2split[8];
                        }
                    }

                    info += "&" + hdd2split[0] + "&";
                    info += "Local: " + hdd2split[1] + "&";
                    info += "Format: " + hdd2split[2] + "&";
                    info += "Total Space: " + hdd2df2.ToString() + "Gbs" + "&";
                    info += "Free Space: " + hdd2df1.ToString() + "Gbs" + "&";
                    info += "Used Space: " + hdd2df.ToString() + "Gbs" + "&";
                    info += "Worst(lifetime): " + hdd2split[5] + "ºC" + "&";
                    info += "Current Temp: " + hdd2split[6] + "ºC" + "&";
                    info += "POH(Power On Hours): " + hdd2split[7] + " Hours" + "&";
                    info += "PCC(Power Cycle Count): " + hdd2split[8] + " Times";

                    #region 3 HDD's
                    if (splitline3.Length >= 3)
                    {
                        string[] hdd3split = splitline3[2].Split('&');



                        ulong hdd3used = 0;
                        hdd3used = ulong.Parse(hdd3split[3]) - ulong.Parse(hdd3split[4]);

                        ulong hdd3dfree = 0;
                        hdd3dfree = ulong.Parse(hdd3split[4]);

                        ulong hdd3dTotal = 0;
                        hdd3dTotal = ulong.Parse(hdd3split[3]);


                        double hdd3d = 0;
                        double hdd3df = 0;
                        hdd3d = Math.Round(Convert.ToDouble(hdd3used / 1024), 2);
                        hdd3df = Math.Round((hdd3d / 1000), 2);//usedspace
                        hdd3df = Math.Round((hdd3df / 1000), 2);

                        double hdd3d1 = 0;
                        double hdd3df1 = 0;

                        hdd3d1 = Math.Round(Convert.ToDouble(hdd3dfree / 1024), 2);
                        hdd3df1 = Math.Round((hdd3d1 / 1000), 2);//freespace
                        hdd3df1 = Math.Round((hdd3df1 / 1000), 2);

                        double hdd3d2 = 0;
                        double hdd3df2 = 0;

                        hdd3d2 = Math.Round(Convert.ToDouble(hdd3dTotal / 1024), 2);
                        hdd3df2 = Math.Round((hdd3d2 / 1000), 2);//Totalspace
                        hdd3df2 = Math.Round((hdd3df2 / 1000), 2);

                        mathhdd += "&" + hdd3df2.ToString() + "&";
                        mathhdd += hdd3df.ToString();

                        if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null)
                        {
                            double k = 0;

                            if (double.TryParse(hdd1split[7], out k) == false)
                            {

                            }
                            else
                            {
                                mathhdd2 += "&" + hdd3split[7] + "&";
                            }

                        }
                        if (hdd1split[8] != "" || hdd1split[8] != " " || hdd1split[8] != string.Empty || hdd1split[8] != null)
                        {
                            double k = 0;

                            if (double.TryParse(hdd1split[7], out k) == false)
                            {

                            }
                            else
                            {
                                mathhdd2 += hdd3split[8];
                            }
                        }

                        info += "&" + hdd3split[0] + "&";
                        info += "Local: " + hdd3split[1] + "&";
                        info += "Format: " + hdd3split[2] + "&";
                        info += "Total Space: " + hdd3df2.ToString() + "Gbs" + "&";
                        info += "Free Space: " + hdd3df1.ToString() + "Gbs" + "&";
                        info += "Used Space: " + hdd3df.ToString() + "Gbs" + "&";
                        info += "Worst(lifetime): " + hdd3split[5] + "ºC" + "&";
                        info += "Current Temp: " + hdd3split[6] + "ºC" + "&";
                        info += "POH(Power On Hours): " + hdd3split[7] + " Hours" + "&";
                        info += "PCC(Power Cycle Count): " + hdd3split[8] + " Times";
                    }
                    #endregion



                }
                #endregion


            }
            
            return info + "/" + mathhdd + "/" + mathhdd2 + "/" + Hddcount;

            #endregion

        }
        #endregion

        #region PiNG info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação do PING
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the PING info
         */
        #endregion

        public static string GetPingInfo()
        {
            string infos = pinginfo;
            pinginfo = "";
            return infos;
        }
        #endregion

        #region Network info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação do Network
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the Network info
         */
        #endregion

        public static string GetNetworkInfo()
        {
            string infos = networkinfo;
            networkinfo = "";
            return infos;
        }
        #endregion

        #region MOBO info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação da MOBO
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the MOBO info
         */
        #endregion

        public static string GetMOBOInfo()
        {
            string infos = "";
            infos = moboinfo; //6th group MOBO
            return infos;
        }
        #endregion

        #region GPU info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação da GPU
         * o divisor dessas informações é: "/"
         * é importante notar que a ordem da informação, são: Marca e Modelo,MSclock,coretemp,coreload,fan
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the GPU info
         * The divisor used to do that is "/"
         * it's importante to notice that all info are in especific order: Brand and Model,MSclock,coretemp,coreload,fan
         */
        #endregion

        public static string GetGPUInfo()
        {
            string infos = "";
            string[] splitline2 = gpuinfo.Split('/');
            bool notdetected = false;
            gpuinfo = "";

            #region Brand and Model
            bool nvidia = false;
            bool amd = false;

            string name = " ";
            name = splitline2[0].Replace("&", " ");

            if (name.ToLower().Contains("nvidia"))
                nvidia = true;
            if (name.ToLower().Contains("amd"))
                amd = true;
            if (name.ToLower().Contains("radeon"))
                amd = true;
            #endregion

            #region Memory and Shader Clock

            string[] MSsplit = splitline2[1].Split('&');

            double CoreClock = 0;

            CoreClock = Convert.ToDouble(MSsplit[0]);

            double MemoryClock = 0;

            MemoryClock = Convert.ToDouble(MSsplit[1]);

            double ShaderClock = 0;

            ShaderClock = Convert.ToDouble(MSsplit[2]);


            #endregion

            #region Core Temperature, Memory Load and Core Load

            double CoreTemp = 0;

            CoreTemp = Convert.ToDouble(splitline2[2]);

            string[] Coreloadsplit = splitline2[3].Split('&');

            double CoreLoad = 0;

            CoreLoad = Convert.ToDouble(Coreloadsplit[0]);

            double MemoryLoad = 0;

            MemoryLoad = Convert.ToDouble(Coreloadsplit[1]);

            #endregion

            infos += name + "/";
            infos += "Core Clock " + MSsplit[0] + "Mhz" + "/";
            infos += "Memory Clock " + MSsplit[1] + "Mhz" + "/";
            if(nvidia == true)
            {
                infos += "Shader Clock " + MSsplit[2] + "Mhz" + "/";
            }
            infos += splitline2[2] + "/";
            infos += Coreloadsplit[0] + "/";
            infos += "Memory Load " + Coreloadsplit[1] + "%" + "/";

            #region FAN Speed

            double fanspeed = 0;

            if (splitline2[4] != "0" && splitline2[4] != " " && splitline2[4] != String.Empty)
            {
                fanspeed = Convert.ToDouble(splitline2[4]);
                infos += "Fan Speed " + splitline2[4] + "RPM /";
            }
            else
            {
                fanspeed = 0;
                infos += "Fan Speed 0 RPM /";
            }
            #endregion

            #region Not Detected
            if (nvidia == false && amd == false)
            {
                notdetected = true;
            }
            #endregion

            if(notdetected == true)
            {
                infos += "true";
            }
            else
            {
                infos += "false";
            }
            
            return infos;
        }
        #endregion

        #region IP info

        #region Comentários PT-BR
        /* Esse Chunk é responsável tratar toda a informação da MOBO
         */
        #endregion

        #region EN-US Comments
        /* This chunk filters the MOBO info
         */
        #endregion

        public static string GetIPInfo()
        {
            string infos = "";
            infos = ipacesso; //6th group MOBO
            return infos;
        }
        #endregion


        #endregion

        #region Response Method's
        public static void SetResponse(string response)
        {
          responses = response;
        }
        #endregion

        #region Network Status Method's
        public static bool GetStatus()
        {
            return status;
        }
        public static void ResetStatus()
        {
            status = false;
        }
        #endregion

        #region TCPListen
        void listen()
        {
            while (true)
            {
                try
                {
                    Int32 port = 8080;
                    IPAddress localAddr = IPAddress.Any;
                    TcpListener server = new TcpListener(localAddr, port);
                    server.Start();
                    bool connection = false;
                    TcpClient client = null;
                    byte[] bytes = new byte[2056];
                    String data = null;

                    while (true)
                    {
                        client = server.AcceptTcpClient();
                        client.NoDelay = true;
                        client.ReceiveBufferSize = 1024;
                        NetworkStream stream = client.GetStream();
                        var localEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                        ipacesso = localEndPoint.ToString();
                        connection = true;

                        while (connection == true)
                        {
                            status = true;
                            try
                            {
                                stream.Read(bytes, 0, bytes.Length);
                                data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                                mastercontent = data;
                                data = "";
                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(responses);
                                stream.Write(msg, 0, msg.Length);
                               
                            }
                            catch (SystemException e)
                            {
                                connection = false;
                               // Task.Run(() => MessageBox.Show(e.ToString()));
                                break;
                            }

                            if (responses != "Accept")
                            {
                                responses = "Accept";
                            }

                        }

                        stream.Close();

                        if (connection == false)
                        {
                            break;
                        }

                        if (responses != "Accept")
                        {
                            responses = "Accept";
                        }
                    }
                    client.Close();
                    server.Stop();
                }
                catch(SystemException e)
                {
                   // Task.Run(() => MessageBox.Show(e.ToString()));
                }


                if (responses != "Accept")
                {
                    responses = "Accept";
                }
            }

          

        }
        #endregion

    }
}
