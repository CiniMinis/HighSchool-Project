using PdfSharp.Pdf;
using PdfSharp.Pdf.Actions;
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
        // represents the current page
        enum Page {Home, FileScan, DirScan, Monitor };
        Page curPage = Page.Home;
        //blacklist for viruses
        private static string[] openActionBlacklist = {@"\.saveAs\\\((?<str>['""])([A-Z]:[a-z0-9 A-Z/\\]+)\.hta(\k<str>)\\\)"};
        private static List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();

        public const int REMOVE_ID = 0;
        public const int SUSPICIOUS_ID = 1;
        public const int NOTIFY_ID = 2;

        public AVform()
        {
            InitializeComponent();
        }


        private bool ScanFile(string path)
        {// operation for scanning a file
            if (Path.GetExtension(path) == ".pdf")
            {
                try
                {
                    PdfDocument file = PdfReader.Open(path);
                    PdfReference nextReference = (PdfReference)file.Internals.Catalog.Elements["/OpenAction"];
                    if (nextReference == null) return false;
                    PdfDictionary action = (PdfDictionary)nextReference.Value;
                    if (action == null) return false;
                    do
                    {
                        foreach (string pattern in openActionBlacklist)
                        {
                            if (SettingsBox.GetItemChecked(SUSPICIOUS_ID) ||
                                Regex.Match(action.ToString(), pattern).Success)
                            {
                                if (SettingsBox.GetItemChecked(REMOVE_ID))
                                {
                                    File.Delete(path);
                                }
                                return true;
                            }
                        }
                    }   // a joke line which basicly iterates over the linked list of open actions
                    while ((nextReference = (PdfReference)action.Elements["/Next"]) == null || (action = (PdfDictionary)nextReference.Value) == null);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(String.Format("couldn't handle {0}. Try to rerun as administrator.", path));
                }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("{0} is corrupted. Readers may handle it but it prevents us from scanning it fully.", path));
                }
            }
            return false;
        }
        private void ScanDir(string path)
        {   // uses the file scan to scan all files in a directory and its sub-directories
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
                    if (SettingsBox.GetItemChecked(NOTIFY_ID))
                    {
                        MessageBox.Show(virus);
                    }
                }
            }
        }
        private void MonitorDir(string path)
        {   // creates a file system watcher which monitors infections in a given directory
            FileSystemWatcher watcher = new FileSystemWatcher
            {
                Path = path,
                // monitor creation and update
                NotifyFilter = NotifyFilters.LastWrite,
                // look for pdf only
                Filter = "*.pdf"
            };
            watcher.IncludeSubdirectories = true;
            watcher.Changed += this.MonitorCheck;
            // start watching
            MessageBox.Show("Monitor Started");
            watcher.EnableRaisingEvents = true;
            watchers.Add(watcher);
        }

        private void MonitorCheck(object src, FileSystemEventArgs e)
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
        {   // handles the exit button
            //click.Play();
            System.Threading.Thread.Sleep(300);
            Application.Exit();
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {   // parses a click on the main button
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
        {   // changes the page to the filescan page
            //click.Play();
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
        {   // changes the page to the directory scan page
            //click.Play();
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
        {   // changes the page to the monitor page
            //click.Play();
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
        {   // handles the file/directory selection button
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
        {   // selects a folder
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    PathField.Text = fldrDlg.SelectedPath;
                }
            }
        }

        private void SelectFile()
        {   // selects a file
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
        {   // changes the page to the home page
            //click.Play();
            Home_Show();
            curPage = Page.Home;
            PathField.Text = "";
            PathTxt.Text = "Select a folder";
            ScanBtn.Text = "Download";
            PageTxt.Text = "Welcome!";
            InfoContent.Text = "Welcome to White Blood Cell, an anti-virus built with PDFs in mind. PDFs may seem innocent but recently many security issues have been discovered in the PDF format, so protect yourself from the upcoming danger...";
        }

        private void Home_Show()
        {   // changes the displayed items to fit the home screen
            PathTxt.Hide();
            PathField.Hide();
            ScanBtn.Hide();
            PathBtn.Hide();
            HomeContent.Show();
            HomePanel.Show();
            SettingsBox.Show();
            SettingsTitle.Show();
        }
        private void Home_Hide()
        {   // changes the displayed items to fit non-home screens
            PathTxt.Show();
            PathField.Show();
            ScanBtn.Show();
            PathBtn.Show();
            HomeContent.Hide();
            HomePanel.Hide();
            SettingsBox.Hide();
            SettingsTitle.Hide();
        }

        private void HomeContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
