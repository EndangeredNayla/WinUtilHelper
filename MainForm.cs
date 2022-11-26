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
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

        }

        private void firefoxButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Firefox...");
            string args;
            args = "/C winget install -e --id Mozilla.Firefox";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();

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
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void atomButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Atom...");
            string args;
            args = "/C winget install -e --id GitHub.Atom";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void bracketsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Brackets...");
            string args;
            args = "/C winget install -e --id brackets-cont.brackets";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void gitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Git...");
            string args;
            args = "/C winget install -e --id Git.Git";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void java8Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Temurin Java 8 (JDK)...");
            string args;
            args = "/C winget install -e --id EclipseAdoptium.Temurin.8.JDK";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void javaButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Temurin Java 18 (JDK)...");
            string args;
            args = "/C winget install -e --id EclipseAdoptium.Temurin.18.JDK";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void jetbrainsToolboxButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Jetbrains Toolbox...");
            string args;
            args = "/C winget install -e --id JetBrains.Toolbox";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void nodeJSButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing NodeJS...");
            string args;
            args = "/C winget install -e --id OpenJS.NodeJS";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void nodeLTSButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Node JS (LTS)...");
            string args;
            args = "/C winget install -e --id OpenJS.NodeJS.LTS";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void python2Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Python 2.7 (EOL)...");
            string args;
            args = "/C winget install -e --id Python.Python.2";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void python3Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Python 3.11...");
            string args;
            args = "/C winget install -e --id Python.Python.3.11";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }
        private void rustButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Rust...");
            string args;
            args = "/C winget install -e --id Rustlang.Rust.GNU";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }
        private void sublimeTextButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Sublime Text 4...");
            string args;
            args = "/C winget install -e --id SublimeHQ.SublimeText.4";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }
        private void tortoiseGitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Tortoise Git...");
            string args;
            args = "/C winget install -e --id TortoiseGit.TortoiseGit";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }
        private void unityButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Unity Hub...");
            string args;
            args = "/C winget install -e --id UnityTechnologies.UnityHub";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void vs2022Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Visual Studio 2022...");
            string args;
            args = "/C winget install -e --id Microsoft.VisualStudio.2022.Community";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }

        private void visualStudioCodeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing Visual Studio Code...");
            string args;
            args = "/C winget install -e --id Microsoft.VisualStudioCode";
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Arguments = args;
            process.Start();
            StreamReader reader = process.StandardOutput;
            StringBuilder builder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                builder.Append(line);
                //Winget Hacks
                line = line.Replace("", "");
                line = line.Replace("-\\|/", "");
                line = line.Replace("â–", "");
                line = line.Replace("ˆ", "");
                line = line.Replace("-\\|", "");
                line = line.Replace("-\\", "");
                line = line.Replace("’’", "");
                line = line.Replace("     ", "");
                line = line.Replace("    ", "");
                line = line.Replace("   - ", "");
                line = line.Replace("  ’  ", "");
                Console.WriteLine(line);
            }

            string allLines = builder.ToString();
        }
    }
}