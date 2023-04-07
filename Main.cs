using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Software_Project_2_Commiter;
using Software_Project_2_Commiter.Properties;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace Software_Project_2_Commiter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        private void Start_Click_Click(object sender, EventArgs e)
        {
            Shafin();
        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Portfolio-Cynthia-Lee";

        private void Shafin()
        {
            if (Commit_person.Text == "Shafin")
            {
                git_username.Text = "Shafin5556";
                git_usermail.Text = "shafinahmed5556@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllBytes(path + @"\Portfolio-Cynthia-Lee\public\static\" + "info.json", Resources.Shafin_info);
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\pages\" + "index-dark.js", Resources.Shafin_index_dark);
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\"+"BIO.js", Resources.Shafin_BIO);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if(Commit_person.Text == "Rayhan")
            {
                git_username.Text = "15rayhan";
                git_usermail.Text = "rayhan15-4164@diu.edu.bd";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\pages\"+"index.js", Resources.Rayhan_index);
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "BIO.js", Resources.Rayhan_BIO);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Mahbub")
            {
                git_username.Text = "md-mahabub1712";
                git_usermail.Text = "mastermind1741999@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "RESEARCH.js", Resources.Mahbub_RESEARCH);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Towshib")
            {
                git_username.Text = "Towsib Ahsan";
                git_usermail.Text = "sarantowsib@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "TEACHING.js", Resources.Towshib_TEACHING);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Morsalin")
            {
                git_username.Text = "Morsalin";
                git_usermail.Text = "morsalin186@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "RESEARCH.js", Resources.Morsalim_RESEARCH);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Sadman")
            {
                git_username.Text = "SadmanRabbani";
                git_usermail.Text = "srabbani69@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "PUBLICATIONS.js", Resources.Sadman_PUBLICATIONS);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Palki")
            {
                git_username.Text = "JuiriaHumayan";
                git_usermail.Text = "Khanpowshi@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                string photo = path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.png";
                string zip = path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.zip";
                if (!File.Exists(photo))
                {

                    File.WriteAllBytes(path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.zip", Resources.avatar);
                    System.IO.Compression.ZipFile.ExtractToDirectory(path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.zip", path + @"\Portfolio-Cynthia-Lee\public\img\slider");
                    File.Delete((zip));
                }
                else
                {
                    File.Delete((photo));
                    File.WriteAllBytes(path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.zip", Resources.avatar);
                    System.IO.Compression.ZipFile.ExtractToDirectory(path + @"\Portfolio-Cynthia-Lee\public\img\slider\avatar.zip", path + @"\Portfolio-Cynthia-Lee\public\img\slider");
                    File.Delete((zip));
                }
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\layout\" + "Header.js", Resources.Palki_Header);
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "HOME.js", Resources.Palki_Home);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Toha")
            {
                git_username.Text = "TheLunatic1";
                git_usermail.Text = "ishrak1846@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "TEACHING.js", Resources.Toha_TEACHING);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Mredul")
            {
                git_username.Text = "ARAFIN11";
                git_usermail.Text = "mredularafin11@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "Contact.js", Resources.Mredul_Contact);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
            if (Commit_person.Text == "Shojib")
            {
                git_username.Text = "Hr-Sajib";
                git_usermail.Text = "hrsajib001@gmail.com";
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = path;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.StandardInput.WriteLine(@"cd " + path1);
                p.StandardInput.WriteLine(@"git init");
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git status");
                File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "Contact.js", Resources.Shojib_Contact);
                Thread.Sleep(3000);
                p.StandardInput.WriteLine(@"git status");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git add -A");
                p.StandardInput.WriteLine(@"git commit -m " + commit_text.Text + "");
                p.StandardInput.WriteLine(@"git branch -M main");
                p.StandardInput.WriteLine(@"git remote add origin git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
                p.StandardInput.WriteLine(@"git push -u origin main");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                p.WaitForExit();
            }
        }

        private void Safe_Exit_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            log_in();
            MessageBox.Show("Log in success",git_username.Text);
        }

        private void Commit_person_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Commit_person.Text == "Shafin")
            {
                git_username.Text = "Shafin5556";
                git_usermail.Text = "shafinahmed5556@gmail.com";

            }
            if (Commit_person.Text == "Rayhan")
            {
                git_username.Text = "15rayhan";
                git_usermail.Text = "rayhan15-4164@diu.edu.bd";
            }
            if (Commit_person.Text == "Mahbub")
            {
                git_username.Text = "md-mahabub1712";
                git_usermail.Text = "mastermind1741999@gmail.com";
            }
            if (Commit_person.Text == "Towshib")
            {
                git_username.Text = "Towsib Ahsan";
                git_usermail.Text = "sarantowsib@gmail.com";
            }
            if (Commit_person.Text == "Morsalin")
            {
                git_username.Text = "Morsalin";
                git_usermail.Text = "morsalin186@gmail.com";
            }
            if (Commit_person.Text == "Sadman")
            {
                git_username.Text = "SadmanRabbani";
                git_usermail.Text = "srabbani69@gmail.com";
            }
            if (Commit_person.Text == "Palki")
            {
                git_username.Text = "JuiriaHumayan";
                git_usermail.Text = "Khanpowshi@gmail.com";
            }
            if (Commit_person.Text == "Toha")
            {
                git_username.Text = "TheLunatic1";
                git_usermail.Text = "ishrak1846@gmail.com";
            }
            if (Commit_person.Text == "Mredul")
            {
                git_username.Text = "ARAFIN11";
                git_usermail.Text = "mredularafin11@gmail.com";
            }
            if (Commit_person.Text == "Shojib")
            {
                git_username.Text = "Hr-Sajib";
                git_usermail.Text = "hrsajib001@gmail.com";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Shafin();
        }

        private void git_username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void log_in()
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = path;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.Start();
            p.StandardInput.WriteLine(@"git config --global user.name " + git_username.Text + "");
            p.StandardInput.WriteLine(@"git config --global user.email " + git_usermail.Text + "");
            if (!Directory.Exists(path1))
            {
                p.StandardInput.WriteLine(@"git clone git@github.com:Shafin5556/Portfolio-Cynthia-Lee.git");
            }
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();
        }
        private void git_usermail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void commit_text_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path + @"\Portfolio-Cynthia-Lee\src\components\" + "Contact.js", Resources.Shojib_Contact);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }

        private void button1_Click_3(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
