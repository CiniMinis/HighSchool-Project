using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteBloodCell
{
    public partial class AVform : Form
    {
        enum Page {Home, FileScan, DirScan, Monitor };
        Page curPage = Page.Home;
        SoundPlayer click = new SoundPlayer("C:\\Users\\jhjht\\Documents\\Audacity\\click.wav");
        private static string[] openActionBlacklist = {@"\.saveAs\\\((?<str>['""])([A-Z]:[a-z0-9 A-Z/\\]+)\.hta(\k<str>)\\\)"};
        private static List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();

        public AVform()
        {
            InitializeComponent();
        }


        private static bool ScanFile(string path)
        {
            if (Path.GetExtension(path) == ".pdf")
            {
                try
                {
                    PdfDocument file = PdfReader.Open(path);
                    PdfReference openAction = (PdfReference)file.Internals.Catalog.Elements["/OpenAction"];
                    if (openAction == null) return false;
                    PdfDictionary action = (PdfDictionary)openAction.Value;
                    if (action == null) return false;
                    foreach (string pattern in openActionBlacklist)
                    {
                        if (Regex.Match(action.ToString(), pattern).Success)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("{0} is corrupted. Readers may handle it but it prevents us from scanning it fully.", path));
                }
            }
            return false;
        }
        private static void ScanDir(string path)
        {
            List<string> viruses = new List<string>();
            foreach (string file in Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories))
            {
                if (ScanFile(file))
                {
                    viruses.Add(file);
                }
            }
            if (viruses.Count == 0)
            {
                MessageBox.Show("All clear!");
            }
            else
            {
                MessageBox.Show(String.Format("{0} viruses found!", viruses.Count));
                foreach (string virus in viruses)
                {
                    MessageBox.Show(virus);
                }
            }
        }
        private static void MonitorDir(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher
            {
                Path = path,
                // monitor creation and update
                NotifyFilter = NotifyFilters.LastWrite,
                // look for pdf only
                Filter = "*.pdf"
            };
            watcher.IncludeSubdirectories = true;
            watcher.Changed += MonitorCheck;
            // start watching
            MessageBox.Show("Monitor Started");
            watcher.EnableRaisingEvents = true;
            watchers.Add(watcher);
        }

        private static void MonitorCheck(object src, FileSystemEventArgs e)
        {
            if (ScanFile(e.FullPath))
                {
                    MessageBox.Show(String.Format("Monitor found virus: {0}", e.FullPath));
                }
        }

private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            click.Play();
            System.Threading.Thread.Sleep(300);
            Application.Exit();
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            switch (curPage)
            {
                case Page.FileScan:
                    if (ScanFile(PathField.Text))
                    {
                        MessageBox.Show("Virus Found!");
                    }
                    else
                    {
                        MessageBox.Show("File Clear!");
                    }
                    break;
                case Page.DirScan:
                    ScanDir(PathField.Text);
                    break;
                case Page.Monitor:
                    MonitorDir(PathField.Text);
                    break;
                default:
                    break;
            }

        }

        private void FileScan_Click(object sender, EventArgs e)
        {
            click.Play();
            if (curPage == Page.Home)
            {
                Home_Hide();
            }
            curPage = Page.FileScan;
            PathField.Text = "";
            PathTxt.Text = "Select a file";
            ScanBtn.Text = "Scan";
            PageTxt.Text = "File Scan";
            InfoContent.Text = "A simple, classic anti-virus operation. It takes the given file and compares it against a known database of viruses. In addition, WBC does a special segmented scan of PDFs.";
        }

        private void DirScan_Click(object sender, EventArgs e)
        {
            click.Play();
            if (curPage == Page.Home)
            {
                Home_Hide();
            }
            curPage = Page.DirScan;
            PathField.Text = "";
            PathTxt.Text = "Select a folder";
            ScanBtn.Text = "Scan";
            PageTxt.Text = "Folder Scan";
            InfoContent.Text = "A recursive version of the file scan. This method scans all files in the selected folder and its subfolders as virus candidates. By scanning an entire user a total scan can be done.";
        }

        private void DirMonitor_Click(object sender, EventArgs e)
        {
            click.Play();
            if (curPage == Page.Home)
            {
                Home_Hide();
            }
            curPage = Page.Monitor;
            PathField.Text = "";
            PathTxt.Text = "Select a folder";
            ScanBtn.Text = "Start";
            PageTxt.Text = "Monitor";
            InfoContent.Text = "A real-time defense of a folder (and its sub folders). This functionality monitors changes live, and scans each file following its modification. A powerful tool for defending yourself with less hassle.";
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            switch (curPage)
            {
                case Page.DirScan:
                case Page.Monitor:
                case Page.Home:
                    SelectFolder();
                    break;
                case Page.FileScan:
                    SelectFile();
                    break;
                default:
                    Console.WriteLine("Select from unexpected location");
                    break;
            }
        }

        private void SelectFolder()
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    PathField.Text = fldrDlg.SelectedPath;
                }
            }
        }

        private void SelectFile()
        {
            using (var fileDlg = new OpenFileDialog())
            {
                fileDlg.Filter = "PDF only|*.pdf";
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    PathField.Text = fileDlg.FileName;
                }
            }
        }

        private void Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            click.Play();
            Home_Show();
            curPage = Page.Home;
            PathField.Text = "";
            PathTxt.Text = "Select a folder";
            ScanBtn.Text = "Download";
            PageTxt.Text = "Welcome!";
            InfoContent.Text = "Welcome to White Blood Cell, an anti-virus built with PDFs in mind. PDFs may seem innocent but recently many security issues have been discovered in the PDF format, so protect yourself from the upcoming danger...";
        }

        private void Home_Show()
        {
            HomeContent.Show();
            HomeLocal.Show();
            HomeOnline.Show();
            HomePanel.Show();
        }
        private void Home_Hide()
        {
            HomeContent.Hide();
            HomeLocal.Hide();
            HomeOnline.Hide();
            HomePanel.Hide();
        }

        private void HomeContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
