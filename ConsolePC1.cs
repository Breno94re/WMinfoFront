using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Timers;

namespace WMinfo_Front
{
    public partial class ConsolePC1 : Form
    {
        public ConsolePC1()
        {
            InitializeComponent();

            if (Home.open == true)
            {
                Home.open = false;
                text = "";
                StreamReader Reader = new StreamReader(Application.StartupPath + "//" + "log.txt");
                text = Reader.ReadToEnd();
                Reader.Close();
                initialization();
            }



        }
        string text = "";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (ConsoleListener.receiving != true)
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                textBox1.Select();
                textBox1.SelectionStart = textBox1.TextLength;
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }

        void initialization()
        {
            richTextBox1.Text = "\n-To Search for a especific data log, use the command: Log.Search(*dd/mm/yyyy*); " +
                "\n\n-To Search for all the data log, use the command: Log.SearchAll();" +
                "\n\n-To send a command to CMD console: Console.Test(*command*);" +
                "\n\n-To List all Remote Console commands availabe: Console.info();" +
                 "\n\n-To Clear the Console: Console.Clear();" +
                "\n\n-To Navigate through the commands, use ↑ and ↓ on the Keyboard";

            textBox1.Select();
            textBox1.SelectionStart = textBox1.TextLength;
            ConsoleCommands[0] = ":>Log.Search(*dd/mm/yyyy*);";
            ConsoleCommands[1] = ":>Log.SearchAll();";
            ConsoleCommands[2] = ":>Console.Command(*command*);";
            ConsoleCommands[3] = ":>Console.info();";
            ConsoleCommands[4] = ":>Console.Clear();";

            consoleinfo[0] = "- ipconfig: Lists every piece of network hardware";
            consoleinfo[1] = "- chkdsk: Check your disks for error";
            consoleinfo[2] = "- taskkill /F /IM 'executable name.exe' /T: Kill any task for good";
            consoleinfo[3] = "- tasklist: Shows Every Process on the computer";
            consoleinfo[4] = "- netstat [-a] [-b] [-e] [-f] [-n] [-o] [-r] [-s] [-x] [-t]: Displays Network Statistics";




        }
        string[] consoleinfo= new string[50];
        string[] ConsoleCommands = new string[5];
        int position = 0;

        void upmenu()
        {
            if (position <= 4)
            {
                textBox1.Text = ConsoleCommands[position];
                position++;
            }
            textBox1.Select();
        }

        void downmenu()
        {
            if (position != 0)
            {
                position--;
                textBox1.Text = ConsoleCommands[position];
            }
            textBox1.Select();
            textBox1.SelectionStart = textBox1.TextLength;
        }

        void insertcommand()
        {
            string material = "";
            string[] materialsplit;
            if (textBox1.Text.Contains("Log"))
            {
                if (text == string.Empty || text == "" || text == " ")
                {
                    richTextBox1.Text = richTextBox1.Text + "\n\n";
                    richTextBox1.AppendText(String.Format("{0}{1}", "\n-You dont have any logs Yet...", Environment.NewLine));
                }
                else
                {
                    material = textBox1.Text.Replace(":>", String.Empty);
                    if (textBox1.Text.Contains("Log.Search("))
                    {
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n-Searching Logs on: " + material, Environment.NewLine));
                        string[] searcheditem = textBox1.Text.Split('*');
                        materialsplit = text.Split('\n');
                        foreach (string textsearched in materialsplit)
                        {
                            if (textsearched.Contains(searcheditem[1]) && textsearched != string.Empty && textsearched != "" && textsearched != "" && textsearched != "\n" && textsearched != "\r" && textsearched != "\t")
                            {
                                richTextBox1.AppendText(String.Format("{0}{1}", "\n-Found: " + textsearched.Replace("&", "\n"), Environment.NewLine));
                            }
                        }
                    }

                    if (textBox1.Text.Contains("Log.SearchAll();"))
                    {

                        richTextBox1.AppendText(String.Format("{0}{1}", "\n-Searching Logs on: " + material, Environment.NewLine));
                        string[] searcheditem = textBox1.Text.Split('*');
                        materialsplit = text.Split('\n');
                        foreach (string textsearched in materialsplit)
                        {
                            if (textsearched != string.Empty && textsearched != "" && textsearched != "" && textsearched != "\n" && textsearched != "\r" && textsearched != "\t")
                            {

                                richTextBox1.AppendText(String.Format("{0}{1}", "\n-Found: " + textsearched.Replace("&", "\n"), Environment.NewLine));
                            }
                        }
                    }



                }
            }

            if (textBox1.Text.Contains("Console.Command("))
            {
                string[] command1 = textBox1.Text.Split('*');
                command = command1[1];
                doworkAsync();

            }

            if (textBox1.Text.Contains("Console.info();"))
            {
                richTextBox1.AppendText(String.Format("{0}{1}", "\n\n-List Of every command supported by the Remote CMD. Note that EVERY Command is case sensitive.", Environment.NewLine));

                foreach (string textsearched in consoleinfo)
                {
                    if (textsearched != string.Empty && textsearched != null && textsearched != "" && textsearched != " ")
                    {
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n\n" + textsearched, Environment.NewLine));
                    }
                }

            }

            if (textBox1.Text.Contains("Console.Clear();"))
            {
                initialization();
            }

            textBox1.Select();
            textBox1.Text = "";
            textBox1.Text = ":>";
            textBox1.SelectionStart = textBox1.TextLength;
        }

        public static string command = "";

        async void doworkAsync()
        {

            ConsoleListener.receiving = true;

            bool firstime = true;
            ListenerPC1.SetResponse("Console*" + command);
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                richTextBox1.AppendText(String.Format("{0}{1}", "\n\n-Waiting on Console Response, this may take a while...", Environment.NewLine));
            });

            while (ConsoleListener.receiving == true)
            {
                await Task.Run(() => ConsoleListener.StartListenAsync());
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    string msg = "";
                    msg = ConsoleListener.consoletext;
                    if(firstime == true)
                    {
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n-Mesage Received!", Environment.NewLine));
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n-Console Output:", Environment.NewLine));
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n" + msg, Environment.NewLine));
                        firstime = false;
                    }
                    else
                    {
                        richTextBox1.AppendText(String.Format("{0}{1}", "\n" + msg, Environment.NewLine));
                    }
                    
                });
            }


        }

        public static bool content = false;

        void Output()
        {
           if (content == true)
           {
                content = false;
                string consoletext = "";
                consoletext = ReadLog();
                richTextBox1.Text = consoletext;
           }
        }

        string ReadLog()
        {
            string text = "";
            StreamReader Reader = new StreamReader(Application.StartupPath + "//" + "log.txt");
            text = Reader.ReadToEnd();
            Reader.Close();
            return text;
        }

        private void Close_Click(object sender, EventArgs e)
        {
           
        }

        private void ConsolePC1_FormClosed(object sender, FormClosedEventArgs e)
        {
                Home.pcform.Dispose();
                Home.pcform = null;
                Home.openform = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                insertcommand();
                position = 0;
            }
        }

        private void ConsolePC1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                upmenu();
            }

            if (e.KeyCode == Keys.Down)
            {
                downmenu();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
