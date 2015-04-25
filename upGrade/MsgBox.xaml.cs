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
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;

namespace upGrade
{
    /// <summary>
    /// MsgBox.xaml 的交互逻辑
    /// </summary>
    public partial class MsgBox : UserControl
    {
        List<FileInfo> upgradeFiles = new List<FileInfo>();
        public MsgBox()
        {
            InitializeComponent();
            this.Visibility = Visibility.Collapsed;
        }
        public void show(StringCollection strFilename)
        {
            tbDis.Text = "检测到更新:\n";
            string prgVersion = null;
            string lanVersion = null;
            foreach (string str in strFilename)
            {
                FileInfo file = new FileInfo(str);
                if (str.Contains("dateBase.dll"))
                {
                    FileVersionInfo myFileLocalVersionInfo = FileVersionInfo.GetVersionInfo(MainWindow.dirPath + "\\dateBase.dll");
                    prgVersion = myFileLocalVersionInfo.FileVersion;
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(str);
                    prgVersion += "\t==>\t" + myFileVersionInfo.FileVersion;
                }

                if (str.Contains("program.exe"))
                {
                    FileVersionInfo myFileLocalVersionInfo = FileVersionInfo.GetVersionInfo(MainWindow.dirPath + "\\program.exe");
                    prgVersion = myFileLocalVersionInfo.FileVersion;
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(str);
                    prgVersion += "\t" + myFileVersionInfo.FileVersion;
                }


                if(str.Contains("lanCN.xaml"))
                {
                    ResourceDictionary rdLocal = new ResourceDictionary() { Source = new Uri(MainWindow.dirPath + "\\lan\\lanCN.xaml", UriKind.RelativeOrAbsolute) };
                    object objLocal = rdLocal["PrgVersion"];
                    lanVersion = objLocal.ToString();

                    ResourceDictionary rd = new ResourceDictionary() { Source = new Uri(str, UriKind.RelativeOrAbsolute) };
                    object obj = rd["PrgVersion"];
                    lanVersion += "\t==>\t" + obj.ToString();
                }

                if (str.Contains("lanEN.xaml"))
                {
                    ResourceDictionary rdLocal = new ResourceDictionary() { Source = new Uri(MainWindow.dirPath + "\\lan\\lanEN.xaml", UriKind.RelativeOrAbsolute) };
                    object objLocal = rdLocal["PrgVersion"];
                    lanVersion = objLocal.ToString();

                    ResourceDictionary rd = new ResourceDictionary() { Source = new Uri(str, UriKind.RelativeOrAbsolute) };
                    object obj = rd["PrgVersion"];
                    lanVersion += "\t==>\t" + obj.ToString();
                }
                upgradeFiles.Add(file);
            }
            if (prgVersion != null)
            {
                tbDis.Text += "程序文件可更新：\n" + prgVersion;
            }
            if (lanVersion != null)
            {
                tbDis.Text += "语言文件可更新：\n" + lanVersion;
            }
            tbDis.Text += "\n是否更新？";
            this.Visibility = Visibility.Visible;
        }

        private void lbConfirm_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbConfirm.Background = Brushes.DarkBlue;
        }

        private void lbCancle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbCancle.Background = Brushes.DarkBlue;
        }

        private void lbConfirm_MouseLeave(object sender, MouseEventArgs e)
        {
            if( lbConfirm.Background == Brushes.DarkBlue)
            {
                lbConfirm.Background = Brushes.Transparent;

            }
        }

        private void lbCancle_MouseLeave(object sender, MouseEventArgs e)
        {
            if (lbCancle.Background == Brushes.DarkBlue)
            {
                lbCancle.Background = Brushes.Transparent;

            }
        }

        private void lbConfirm_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lbConfirm.Background == Brushes.DarkBlue)
            {
                try
                {
                    if (checkBox.IsChecked == true)
                    {
                        File.Copy("dateBase.dll", "backup\\dateBase.dll");
                        File.Copy("program.exe", "backup\\program.exe");
                        File.Copy("lan\\lanCN.xaml", "backup\\lanCN.xaml");
                        File.Copy("lan\\lanEN.xaml", "backup\\lanEN.xaml");
                    }
                    //MessageBox.Show("upgrade");
                    DirectoryInfo dirLocalUpgrade = new DirectoryInfo(MainWindow.dirPath.FullName + "\\backup");
                    DirectoryInfo dirProgram = MainWindow.dirPath;
                    if (!dirLocalUpgrade.Exists)
                    {
                        dirLocalUpgrade.Create();
                    }
                    if (!dirProgram.Exists)
                    {
                        dirProgram.Create();
                    }
                    int count = 0;
                    foreach (FileInfo file in upgradeFiles)
                    {
                        try
                        {
                            if (file.Name.Contains(".xaml"))
                            {
                                if (!Directory.Exists(dirProgram.FullName + "\\lan"))
                                {
                                    Directory.CreateDirectory(dirProgram.FullName + "\\lan");
                                }
                                if (File.Exists(dirLocalUpgrade.FullName + "\\" + file.Name))
                                {
                                    File.Delete(dirLocalUpgrade.FullName + "\\" + file.Name);
                                }
                                if (File.Exists(dirProgram.FullName + "\\lan\\" + file.Name))
                                {
                                    File.Move(dirProgram.FullName + "\\lan\\" + file.Name, dirLocalUpgrade.FullName + "\\" + file.Name);
                                }
                                File.Copy(file.FullName, dirProgram.FullName + "\\lan\\" + file.Name);
                            }
                            else
                            {
                                if (File.Exists(dirLocalUpgrade.FullName + "\\" + file.Name))
                                {
                                    File.Delete(dirLocalUpgrade.FullName + "\\" + file.Name);
                                }
                                if (File.Exists(dirProgram.FullName + "\\" + file.Name))
                                {
                                    File.Move(dirProgram.FullName + "\\" + file.Name, dirLocalUpgrade.FullName + "\\" + file.Name);
                                }
                                File.Copy(file.FullName, dirProgram.FullName + "\\" + file.Name);
                            }
                            count++;
                        }
                        catch
                        {

                        }
                    }
                    MessageBox.Show("共升级" + count + "个文件！");
                    startVico();
                }
                catch 
                {
            	
                }
 
                //if(dirLocalUpgrade.FullName + "\\" + )
                lbConfirm.Background = Brushes.Transparent;
            }
        }

        private void lbCancle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lbCancle.Background == Brushes.DarkBlue)
            {
                MessageBox.Show("cancle upgrade");
                this.Visibility = Visibility.Hidden;
                startVico();
                lbCancle.Background = Brushes.Transparent;
            }
        }

        private void lbRecover_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbRecover.Background = Brushes.DarkBlue;
        }

        private void lbRecover_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lbRecover.Background == Brushes.DarkBlue)
            {
                DirectoryInfo dir = new DirectoryInfo(MainWindow.dirPath.FullName + "\\backup");
                if (dir.Exists)
                {
                    FileInfo[] files = dir.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        string path = MainWindow.dirPath.FullName + "\\";
                        if (file.Name.Contains(".xaml"))
                        {
                            path = MainWindow.dirPath.FullName + "\\lan\\";
                        }
                        if (File.Exists(path + file.Name))
                        {
                            File.Delete(path + file.Name);
                            File.Copy(file.FullName, path + file.Name);
                        }
                    }
                    startVico();
                }

                lbRecover.Background = Brushes.Transparent;
            }
        }

        private void lbRecover_MouseLeave(object sender, MouseEventArgs e)
        {
            if (lbRecover.Background == Brushes.DarkBlue)
            {

                lbRecover.Background = Brushes.Transparent;
            }
        }
        private void startVico()
        {
            //MessageBox.Show("请拔下U盘");
            //while (true)
            //{
            //    DriveInfo[] uin = DriveInfo.GetDrives();
            //    bool flagGetUsbIprDir = false;
            //    foreach (DriveInfo drive in uin)
            //    {
            //        if (drive.DriveType == DriveType.Removable)
            //        {
            //            DirectoryInfo dirDriver = new DirectoryInfo(drive.Name);
            //            foreach (DirectoryInfo dir in dirDriver.GetDirectories())
            //            {
            //                if (dir.Name == "upgrade")
            //                {
            //                    if (dir.GetFiles().Length != 0)
            //                    {
            //                        flagGetUsbIprDir = true;
            //                    }
            //                    break;
            //                }
            //            }
            //            break;
            //        }
            //    }
            //    if (flagGetUsbIprDir)
            //        MessageBox.Show("请拔下U盘");
            //    else
            //        break;
            //}
            MessageBox.Show("开始启动程序");
            Environment.CurrentDirectory = MainWindow.dirPath.FullName;
            System.Diagnostics.Process.Start(MainWindow.dirPath.FullName + "\\program.exe");
            Environment.Exit(0);
        }
    }
}
