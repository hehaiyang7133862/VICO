using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;

namespace upGrade
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] upgradeFileName = new string[]{
            "dateBase.dll",
            "program.exe",
            "lanCN.xaml",
            "lanEN.xaml",
        };
        public static DirectoryInfo dirPath = new DirectoryInfo("d:\\ValmoEngineering");
        MsgBox msgBox = new MsgBox();
        public MainWindow()
        {
            InitializeComponent();
            //FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\upGrade.exe");
            //Console.WriteLine(myFileVersionInfo.FileName + "\t" + myFileVersionInfo.FileVersion);
            //Console.WriteLine(myFileVersionInfo.FileName + "\t" + myFileVersionInfo.ProductVersion);

            cvsMain.Children.Add(msgBox);
            Canvas.SetTop(msgBox, 600);
            Canvas.SetLeft(msgBox, 350);
            if (!checkUsb())
            {
                if (File.Exists("d:\\ValmoEngineering\\program.exe"))
                {
                    System.Diagnostics.Process.Start("d:\\ValmoEngineering\\program.exe");
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("Find no Program!");
                    Environment.Exit(0);
                }
            }
            else
            {

            }
        }
        public static DirectoryInfo upgradePath;
        public bool checkUsb()
        {
            upgradePath = null;
            DriveInfo[] uin = DriveInfo.GetDrives();
            foreach (DriveInfo drive in uin)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    upgradePath = new DirectoryInfo(drive.Name);
                    StringCollection upgradeFileLst = new StringCollection();
                    foreach (string str in upgradeFileName)
                    {
                        if(File.Exists(upgradePath.FullName + "\\" + str))
                        {
                            upgradeFileLst.Add(upgradePath.FullName + "\\" + str);
                        }
                    }
                    if (upgradeFileLst.Count > 0)
                    {
                        msgBox.show(upgradeFileLst);
                        return true;
                    }
                break;
                }
            }
            return false;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
