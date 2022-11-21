using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WinUtilHelper
{
    public partial class MainForm : Form
    {

        TextWriter _writer = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void braveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Brave...");
            string args;
            args = "/C winget install -e --id Brave.Brave";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";             process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");    
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void firefoxButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Firefox...");
            string args;
            args = "/C winget install -e --id Mozilla.Firefox";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";             process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void googleChromeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Google Chrome...");
            string args;
            args = "/C winget install -e --id Google.Chrome";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void libreWolfButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing LibreWolf...");
            string args;
            args = "/C winget install -e --id LibreWolf.LibreWolf";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void operaButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Opera...");
            string args;
            args = "/C winget install -e --id Opera.Opera";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void operaGXButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Opera GX...");
            string args;
            args = "/C winget install -e --id Opera.OperaGX";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void torButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Tor...");
            string args;
            args = "/C winget install -e --id TorProject.TorBrowser";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void ungoogledChromiumButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Ungoogled Chromium...");
            string args;
            args = "/C winget install -e --id eloston.ungoogled-chromium";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void vivaldiButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Vivaldi...");
            string args;
            args = "/C winget install -e --id VivaldiTechnologies.Vivaldi";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void androidMessagesButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Android Messages...");
            string args;
            args = "/C winget install -e --id OrangeDrangon.AndroidMessages.Desktop";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Discord...");
            string args;
            args = "/C winget install -e --id Discord.Discord";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing ZOOM...");
            string args;
            args = "/C winget install -e --id Zoom.Zoom";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void slackButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Slack...");
            string args;
            args = "/C winget install -e --id SlackTechnologies.Slack";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void corporateClashButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Corporate Clash...");
            string args;
            args = "/C winget install -e --id CorporateClashCrew.ToontownCorporateClash";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void epicGamesButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Epic Games...");
            string args;
            args = "/C winget install -e --id EpicGames.EpicGamesLauncher";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void gogGalaxyButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing GOG Galaxy...");
            string args;
            args = "/C winget install -e --id GOG.Galaxy";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void originButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Origin...");
            string args;
            args = "/C winget install -e --id ElectronicArts.EADesktop";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void toontownRewrittenButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Toontown Rewritten...");
            string args;
            args = "/C winget install -e --id TheTTRTeam.ToontownRewritten";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void curseforgeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing CurseForge...");
            string args;
            args = "/C winget install -e --id Overwolf.CurseForge";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void prismButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Prism Launcher...");
            string args;
            args = "/C winget install -e --id PrismLauncher.PrismLauncher";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void hexChatButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing HexChat...");
            string args;
            args = "/C winget install -e --id HexChat.HexChat";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void jamiButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Jami...");
            string args;
            args = "/C winget install -e--id SFLinux.Jami";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void signalButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Signal...");
            string args;
            args = "/C winget install -e --id OpenWhisperSystems.Signal";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void telegramButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Telegram...");
            string args;
            args = "/C winget install -e --id Telegram.TelegramDesktop";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe"; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void viberButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Viber...");
            string args;
            args = "/C winget install -e --id Viber.Viber";
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new ConsoleGUI(txtConsole);

            // Redirect the out Console stream
            Console.SetOut(_writer);

            Console.WriteLine("WinUtil v1.0.0 by Nayla");
        }

        private void retroArchButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing RetroArch...");
            string args;
            args = "/C winget install -e --id Libretro.RetroArch";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            string stdOut = reader.ReadToEnd();

            //Winget Hacks
            stdOut = stdOut.Replace("\b", "");
            stdOut = stdOut.Replace("-\\", "");
            stdOut = stdOut.Replace("��", "");
            stdOut = stdOut.Replace("    \r\n", "");
            stdOut = stdOut.Replace("|/", "");
            stdOut = stdOut.Replace("▒", "");
            stdOut = stdOut.Replace("    ", "");
            stdOut = stdOut.Replace("   - ", "");
            stdOut = stdOut.Replace("   | \r\n", "");
            stdOut = stdOut.Replace("█", "");

            Console.WriteLine(stdOut);
        }
    }
}