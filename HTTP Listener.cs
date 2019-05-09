using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

#region Project INFO ##### READ-ME ######

#region References, Legal deployment and contact.
/* - This project uses OpenHardWareMonitor.DLL, it's an opensource code that is availabe at: https://github.com/openhardwaremonitor/openhardwaremonitor -
 * - The dev team is aware of the use, and ANY comercial effect that this code may have, it needs to be made with the knowledge of the original devs. -
 * - This project is not authorized in ANY way to be used on comercial activities, if you do so, there are legal consequences.
 * - This code will be commentend in two languages, English as the main-one and PT-BR as the secondary one, since all members of this project are native Portuguese speakers. -
 * - For any trouble or info, please contact me at: Email: brealmeidaa@hotmail.com Git: https://github.com/Breno94re
 * */
#endregion

#region About the project
/* - This project aims for monitoring any Home-PC or Workstations/Servers via API/HTTP.
 * - The main goal is to archieve a stable and useful tool that can collect'n show info to the user, with the possibility of PDF - Reports, with graphics and usefull Statistics.
 * */
#endregion

#region Devs Info
/* - Version - 1.2 Beta -
 * - Type: Client  -
 * - Last Updated at: 04/04/2019 (DD/MM/YYYY) -
 * 
 * 
 * - ######## What's New ######### -
 *  
 *  -Added support to GPU report's
 *  -Added support to HDD report's
 *  -Added suport to RAM report's
 *  -Added suport to ping's report's
 *  -Added suport to API's report's
 * 
 * - ######## What's New ######### -
 * 
 * 
 * - ######## Bugs to fix ######### -
 * 
 * 
 * - ######## Bugs to fix ######### -
 * 
 * 
 * - ######## Last Changes ######### -
 * 
 *   
 * 
 *     -----------1.1b-------------
 * - Added Global support for CPU report's;
 *     -----------1.1b-------------
 *     
 *     -----------1.0b-------------
 * - Added Global support for HTTP Comunication's;
 *     -----------1.0b-------------
 *     
 *     
 * - ######## Last Changes ######### -
 * 
 * */
#endregion

#endregion

namespace WMinfo_Front
{
    class ListenerPC1
    {
        public static readonly HttpListener web = new HttpListener();
        public static string responses = "Accept";
        
        public void StartListen()
        {

            do
            {
                #region HTTPLISTEN
                try
                {
                    
                    web.Prefixes.Add("http://*:8080/PC1/");
                    web.Start();
                    HttpListenerContext context = web.GetContext();
                    string ipacesso = context.Request.RemoteEndPoint.ToString();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;

                    #region GET() info


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

                    string responseString = responses;
                    byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();

                    string body = request.RawUrl;//Gets info from URL API string//

                    string[] splitline = body.Split('?');//First split to separate url body from api string

                    string[] splitgroups = splitline[1].Split('$');//second string that separates groups in that order: CPU,GPU,HDD,RAM
                    Form1.PC1ON = true;
                    string bodysplited = splitline[1];
                   

                    string[] splitline1 = splitgroups[0].Split('/'); //1st group CPU

                    string[] splitline2 = splitgroups[1].Split('/'); //2nd group GPU

                    string[] splitline3 = splitgroups[2].Split('/'); //3rd group HDD

                    string[] splitline4 = splitgroups[3].Split('/'); //4th group RAM

                    string[] splitline6 = splitgroups[5].Split('/'); //5th group NETWORK

                    string[] splitline7 = splitgroups[6].Split('/'); //6th group MOBO



                    #region CPU INFO

                    //comments//
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
                    //comments//


                    #region Get() Info


                    string pnomes = "";
                    int pcores = 0;
                    string pclocks = "";
                    string ptemps = "";
                    string pload = "";

                    pnomes = splitline1[0]; //Names

                    pcores = Convert.ToInt32(splitline1[1]); //Cores

                    pclocks = splitline1[2]; //Clocks

                    ptemps = splitline1[3]; //Temperatures

                    pload = splitline1[4]; //Load


                    #endregion

                    #region Global Var's

                    double clock1 = 0;

                    double clock2 = 0;

                    double clock3 = 0;

                    double clock4 = 0;

                    double clockbus = 0;

                    double temp1 = 0;

                    double temp2 = 0;

                    double temp3 = 0;

                    double temp4 = 0;

                    double temppack = 0;

                    double load1 = 0;
                    double load2 = 0;
                    double load3 = 0;
                    double load4 = 0;
                    double loadpack = 0;

                    #endregion

                    #region Quad-Cores


                    if (pcores == 4)
                    {
                        string Nomefinal = pnomes.Replace("&", " ");

                        string[] clocksplit = pclocks.Split('&');

                        clock1 = Convert.ToDouble(clocksplit[0]);
                        clock2 = Convert.ToDouble(clocksplit[1]);
                        clock3 = Convert.ToDouble(clocksplit[2]);
                        clock4 = Convert.ToDouble(clocksplit[3]);
                        clockbus = Convert.ToDouble(clocksplit[4]);

                        string[] tempsplit = ptemps.Split('&');

                        temp1 = Convert.ToDouble(tempsplit[0]);
                        temp2 = Convert.ToDouble(tempsplit[1]);
                        temp3 = Convert.ToDouble(tempsplit[2]);
                        temp4 = Convert.ToDouble(tempsplit[3]);
                        temppack = Convert.ToDouble(tempsplit[4]);

                        string[] loadsplit = pload.Split('&');

                        load1 = Convert.ToDouble(loadsplit[0]);
                        load2 = Convert.ToDouble(loadsplit[1]);
                        load3 = Convert.ToDouble(loadsplit[2]);
                        load4 = Convert.ToDouble(loadsplit[3]);
                        loadpack = Convert.ToDouble(loadsplit[4]);

                        Form1.PC1Cores = pcores;
                        Form1.PC1[0] = "Modelo " + Nomefinal;
                        Form1.PC1[1] = "BUS " + clocksplit[4] + "Mhz";
                        Form1.PC1[2] = "Clock#1 " + clocksplit[0] +"Mhz";
                        Form1.PC1[3] = "Clock#2 " + clocksplit[1] + "Mhz";
                        Form1.PC1[4] = "Clock#3 " + clocksplit[2] + "Mhz";
                        Form1.PC1[5] = "Clock#4 " + clocksplit[3] + "Mhz";
                        Form1.PC1[6] = tempsplit[4];
                        Form1.PC1[7] = "Core#1 " + tempsplit[0] + "ºC";
                        Form1.PC1[8] = "Core#2 " + tempsplit[1] + "ºC";
                        Form1.PC1[9] = "Core#3 " + tempsplit[2] + "ºC";
                        Form1.PC1[10] = "Core#4 " + tempsplit[3] + "ºC";
                        Form1.PC1[11] = loadsplit[4];
                        Form1.PC1[12] = "Core#1 " + loadsplit[0] + "%";
                        Form1.PC1[13] = "Core#2 " + loadsplit[1] + "%";
                        Form1.PC1[14] = "Core#3 " + loadsplit[2] + "%";
                        Form1.PC1[15] = "Core#4 " + loadsplit[3] + "%";



                        //Console.WriteLine("Mensagem último Filtro \nNome: {0}\nCores: {1}\nClock#1: {2}Mhz\nClock#2: {3}Mhz\nClock#3: {4}Mhz\nClock#4: {5}Mhz\nBus#5: {6}Mhz\nTemp#1: {7}ºC\nTemp#2: {8}ºC\nTemp#3: {9}ºC\nTemp#4: {10}ºC\nTemp Pack: {11}ºC\nLoad#1: {12}%\nLoad#2: {13}%\nLoad#3: {14}%\nLoad#4: {15}%\nLoad Pack: {16}%", Nomefinal, pcores, clock1, clock2, clock3, clock4, clockbus, temp1, temp2, temp3, temp4, temppack, load1, load2, load3, load4, loadpack);

                    }
                    #endregion

                    #region Dual-Cores


                    if (pcores == 2)
                    {
                        string Nomefinal = pnomes.Replace("&", " ");

                        string[] clocksplit = pclocks.Split('&');

                        clock1 = Convert.ToDouble(clocksplit[0]);
                        clock2 = Convert.ToDouble(clocksplit[1]);
                        clockbus = Convert.ToDouble(clocksplit[2]);

                        string[] tempsplit = ptemps.Split('&');

                        if (tempsplit.Length == 3)
                        {
                            temp1 = Convert.ToDouble(tempsplit[0]);
                            temp2 = Convert.ToDouble(tempsplit[1]);
                        }

                        if (tempsplit.Length == 4)
                        {
                            temp1 = Convert.ToDouble(tempsplit[0]);
                            temp2 = Convert.ToDouble(tempsplit[1]);
                            temppack = Convert.ToDouble(tempsplit[2]);
                        }

                        string[] loadsplit = pload.Split('&');

                        if (loadsplit.Length == 3)
                        {
                            load1 = Convert.ToDouble(loadsplit[0]);
                            load2 = Convert.ToDouble(loadsplit[1]);
                        }

                        if (loadsplit.Length == 4)
                        {
                            load1 = Convert.ToDouble(loadsplit[0]);
                            load2 = Convert.ToDouble(loadsplit[1]);
                            loadpack = Convert.ToDouble(loadsplit[2]);
                        }

                        Form1.PC1Cores = pcores;
                        Form1.PC1[0] = "Modelo " + Nomefinal;
                        Form1.PC1[1] = "BUS " + clocksplit[2] + "Mhz";
                        Form1.PC1[2] = "Clock#1 " + clocksplit[0] + "Mhz";
                        Form1.PC1[3] = "Clock#2 " + clocksplit[1] + "Mhz";

                        if (tempsplit.Length == 4)
                        {
                            Form1.PC1[4] = tempsplit[2];
                            Form1.PC1[5] = "Core#1 " + tempsplit[0] + "ºC";
                            Form1.PC1[6] = "Core#2 " + tempsplit[1] + "ºC";

                            if (loadsplit.Length == 3)
                            {
                                double pack = 0;
                                pack = Math.Round((Convert.ToDouble(loadsplit[0]) + Convert.ToDouble(loadsplit[1]))/2);

                                Form1.PC1[7] = pack.ToString();
                                Form1.PC1[8] = "Core#1 " + loadsplit[0] + "%";
                                Form1.PC1[9] = "Core#2 " + loadsplit[1] + "%";
                            }

                            if (loadsplit.Length == 4)
                            {
                                Form1.PC1[7] = loadsplit[2];
                                Form1.PC1[8] = "Core#1 " + loadsplit[0] + "%";
                                Form1.PC1[9] = "Core#2 " + loadsplit[1] + "%";
                            }
                            
                        }

                        if (tempsplit.Length == 3)
                        {
                            double pack = 0;
                            pack = Math.Round((Convert.ToDouble(tempsplit[0]) + Convert.ToDouble(tempsplit[1])) / 2);

                            Form1.PC1[4] = pack.ToString();
                            Form1.PC1[5] = "Core#1 " + tempsplit[0] + "ºC";
                            Form1.PC1[6] = "Core#2 " + tempsplit[1] + "ºC";

                            if (loadsplit.Length == 3)
                            {
                                double pack1 = 0;
                                pack1 = Math.Round((Convert.ToDouble(loadsplit[0]) + Convert.ToDouble(loadsplit[1])) / 2);

                                Form1.PC1[7] = pack1.ToString();
                                Form1.PC1[8] = "Core#1 " + loadsplit[0] + "%";
                                Form1.PC1[9] = "Core#2 " + loadsplit[1] + "%";
                            }

                            if (loadsplit.Length == 4)
                            {
                                Form1.PC1[7] = loadsplit[2];
                                Form1.PC1[8] = "Core#1 " + loadsplit[0] + "%";
                                Form1.PC1[9] = "Core#2 " + loadsplit[1] + "%";
                            }
                        }
                    }
                    #endregion


                    #endregion

                    #region GPU INFO

                    //comments//
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
                    //comments//


                    //nessa ordem: nome,MSclock,coretemp,coreload,fan

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

                    #region Nvidia

                    if (nvidia == true)
                    {
                        Form1.vganotdetected = false;

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

                        #region FAN Speed

                        double fanspeed = 0;

                        if (splitline2[4] != "0" && splitline2[4] != " " && splitline2[4] != String.Empty)
                        {
                            fanspeed = Convert.ToDouble(splitline2[4]);
                            Form1.PC1[23] = "Fan Speed " + splitline2[4] + "RPM";
                        }
                        else
                        {
                            fanspeed = 0;

                            Form1.PC1[23] = "Fan Speed 0 RPM";
                        }
                            

                        #endregion

                        Form1.PC1[16] = name;
                        Form1.PC1[17] = "Core Clock " + MSsplit[0] + "Mhz";
                        Form1.PC1[18] = "Memory Clock " + MSsplit[1] + "Mhz";
                        Form1.PC1[19] = "Shader Clock " + MSsplit[2] + "Mhz";
                        Form1.PC1[20] = splitline2[2];
                        Form1.PC1[21] = Coreloadsplit[0];
                        Form1.PC1[22] = "Memory Load " + Coreloadsplit[1] + "Mhz";
                    }
                    #endregion

                    #region AMD
                    #endregion

                    #region Not Detected
                    if(nvidia == false && amd == false)
                    {
                        Form1.vganotdetected = true;
                    }
                    #endregion
                    #endregion

                    #region HDD INFO

                    //comments//
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
                    //comments//

                    #region HDD1
                    if (splitline3.Length >= 1)
                    {

                        Form1.PC1hddcount = splitline3.Length;
                        string[] hdd1split = splitline3[0].Split('&');

                        ulong hdd1used = 0;
                        hdd1used = ulong.Parse(hdd1split[3]) - ulong.Parse(hdd1split[4]);

                        ulong hdd1dfree = 0;
                        hdd1dfree = ulong.Parse(hdd1split[4]);

                        ulong hdd1dTotal = 0;
                        hdd1dTotal = ulong.Parse(hdd1split[3]);


                        double hdd1d = 0;
                        double hdd1df = 0;
                        hdd1d = Math.Round(Convert.ToDouble(hdd1used / 1024),2);
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

                        Form1.PC1hddmath[0] = hdd1df2;//total
                        Form1.PC1hddmath[1] = hdd1df;//used

                        

                        if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null )
                        {
                            double k = 0;

                            if(double.TryParse(hdd1split[7],out k)==false)
                            {

                            }
                            else
                            {
                                Form1.PC1hddmath2[0] = Convert.ToDouble(hdd1split[7]);//POH
                            }
                           
                        }


                        if (hdd1split[8] != "" || hdd1split[8] != " " || hdd1split[8] != string.Empty || hdd1split[8] != null)
                        {
                            double k = 0;

                            if (double.TryParse(hdd1split[8], out k)== false)
                            {

                            }
                            else
                            {
                                Form1.PC1hddmath2[1] = Convert.ToDouble(hdd1split[8]);//pCC
                            }
                        }
                        

                        Form1.PC1[32] = hdd1split[0];
                        Form1.PC1[33] = "Local: " + hdd1split[1];
                        Form1.PC1[34] = "Format: " + hdd1split[2];
                        Form1.PC1[35] = "Total Space: " + hdd1df2.ToString() + "Gbs";
                        Form1.PC1[36] = "Free Space: " + hdd1df1.ToString() + "Gbs";
                        Form1.PC1[37] = "Used Space: " + hdd1df.ToString()+ "Gbs";
                        Form1.PC1[38] = "Worst(lifetime): " + hdd1split[5] + "ºC";
                        Form1.PC1[39] = "Current Temp: " + hdd1split[6] + "ºC";
                        Form1.PC1[40] = "POH(Power On Hours): " + hdd1split[7] + " Hours";
                        Form1.PC1[41] = "PCC(Power Cycle Count): " + hdd1split[8] + " Times";

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

                            Form1.PC1hddmath[2] = hdd2df2;//total
                            Form1.PC1hddmath[3] = hdd2df;//used

                            if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null)
                            {

                                double k = 0;

                                if (double.TryParse(hdd1split[7], out k) == false)
                                {

                                }
                                else
                                {
                                    Form1.PC1hddmath2[2] = Convert.ToDouble(hdd2split[7]);//POH
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
                                    Form1.PC1hddmath2[3] = Convert.ToDouble(hdd2split[8]);//pCC
                                }
                            }

                            Form1.PC1[42] = hdd2split[0];
                            Form1.PC1[43] = "Local: " + hdd2split[1];
                            Form1.PC1[44] = "Format: " + hdd2split[2];
                            Form1.PC1[45] = "Total Space: " + hdd2df2.ToString() + "Gbs";
                            Form1.PC1[46] = "Free Space: " + hdd2df1.ToString() + "Gbs";
                            Form1.PC1[47] = "Used Space: " + hdd2df.ToString() + "Gbs";
                            Form1.PC1[48] = "Worst(lifetime): " + hdd2split[5] + "ºC";
                            Form1.PC1[49] = "Current Temp: " + hdd2split[6] + "ºC";
                            Form1.PC1[50] = "POH(Power On Hours): " + hdd2split[7] + " Hours";
                            Form1.PC1[51] = "PCC(Power Cycle Count): " + hdd2split[8] + " Times";
                            #region 3 HDD's
                            if (splitline3.Length >=3)
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

                                Form1.PC1hddmath[4] = hdd3df2;//total
                                Form1.PC1hddmath[5] = hdd3df;//used

                                if (hdd1split[7] != "" || hdd1split[7] != " " || hdd1split[7] != string.Empty || hdd1split[7] != null)
                                {
                                    double k = 0;

                                    if (double.TryParse(hdd1split[7], out k) == false)
                                    {

                                    }
                                    else
                                    {
                                        Form1.PC1hddmath2[4] = Convert.ToDouble(hdd3split[7]);//POH
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
                                        Form1.PC1hddmath2[5] = Convert.ToDouble(hdd3split[8]);//pCC
                                    }
                                }

                                Form1.PC1[52] = hdd3split[0];
                                Form1.PC1[53] = "Local: " + hdd3split[1];
                                Form1.PC1[54] = "Format: " + hdd3split[2];
                                Form1.PC1[55] = "Total Space: " + hdd3df2.ToString() + "Gbs";
                                Form1.PC1[56] = "Free Space: " + hdd3df1.ToString() + "Gbs";
                                Form1.PC1[57] = "Used Space: " + hdd3df.ToString() + "Gbs";
                                Form1.PC1[58] = "Worst(lifetime): " + hdd3split[5] + "ºC";
                                Form1.PC1[59] = "Current Temp: " + hdd3split[6] + "ºC";
                                Form1.PC1[60] = "POH(Power On Hours): " + hdd3split[7] + " Hours";
                                Form1.PC1[61] = "PCC(Power Cycle Count): " + hdd3split[8] + " Times";

                            }
                            #endregion



                        }
                        #endregion


                    }

                   
                    #endregion





                    #endregion

                    #region RAM INFO

                    string ramtotal = "";
                    string ramavailabe = "";
                    ulong raminuse = 0;
                    ulong ramtotal1 = 0;
                    ulong availabe = 0;

                    ramtotal = splitline4[0].Replace("&", ".");
                    ramavailabe = splitline4[1].Replace("&", ".");

                    Form1.PC1[27] = ramtotal;
                    Form1.PC1[28] = ramavailabe;

                    ramtotal1 = ulong.Parse(splitline4[0].Replace("&", string.Empty));
                    availabe = ulong.Parse(splitline4[1].Replace("&", string.Empty));

                    raminuse = ramtotal1 - availabe;

                    
                    double totalfinal = 0;
                    double usefinal = 0;

                    totalfinal = Math.Round(Convert.ToDouble((ramtotal1 / 1024) ), 2);
                    usefinal = Math.Round(Convert.ToDouble((raminuse / 1024) ), 2);

                    Form1.PC1raminuse = Math.Round(usefinal / totalfinal * 100);

                    totalfinal = Math.Round(totalfinal/1000);
                    usefinal = Math.Round(usefinal/1000,2);

                    Form1.PC1[29] = usefinal.ToString() + "/" + totalfinal.ToString() + "GBs";

                    


                    #endregion

                    #region PING INFO

                    string ping = "";
                    ping = splitgroups[4];
                    Form1.PC1[26] = ping;


                    #endregion

                    #region NETWORK INFO


                    if(splitline6[0]!=String.Empty)
                    {
                        string download = splitline6[0].Replace("&", ",");
                        string upload = splitline6[1].Replace("&", ",");
                        string[] downloadsplit = download.Split('-');
                        string[] uploadsplit = upload.Split('-');
                        double downloadd = 0;
                        double uploadd = 0;

                        if(download.ToLower().Contains("mbs"))
                        {
                            downloadd = Convert.ToDouble(downloadsplit[0])*1000;
                        }
                        else
                        {
                            downloadd = Convert.ToDouble(downloadsplit[0]);
                        }

                        if(upload.ToLower().Contains("mbs"))
                        {
                            uploadd = Convert.ToDouble(uploadsplit[0]) * 1000;
                        }
                        else
                        {
                            uploadd = Convert.ToDouble(uploadsplit[0]);
                        }
                        
                        
                        Form1.up = uploadd;
                        Form1.down = downloadd;
                        Form1.PC1[24] = download.Replace("-", " ");
                        Form1.PC1[25] = upload.Replace("-", " ");
                    }

                    #endregion

                    #region MOBO and System INFO

                    string serial = "";
                    if (splitline7[2].Replace("&", " ").ToLower().Contains("oem"))
                        serial = "OEM";
                    else
                        serial = splitline7[2].Replace("&", " ");

                    string version = "";
                    if (splitline7[4].Replace("&", " ").ToLower().Contains("oem"))
                        version = "OEM";
                    else
                        version = splitline7[4].Replace("&", " ");



                    Form1.PC1[30] = "Manufacturer: " + splitline7[0].Replace("&"," ") + "\nModel: " + splitline7[1].Replace("&", " ") + "\nSerial Number: " + serial + "\nVersion: " +splitline7[4].Replace("&", " ");

                    Form1.PC1[31] = "Host-Name:" + splitline7[3] + "\n\nAPI-KEY:#78hjgd6H8" + "\n\nIP:" + ipacesso;




                    #endregion

                    #endregion
                   
                    web.Stop();
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

                    web.Stop();
                    
                }
                #endregion
                responses = "Accept";

            } while (1 < 2);

        }



    }
}
