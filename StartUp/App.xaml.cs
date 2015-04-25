using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace StartUp
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                Process progress = GetRunningInstance();
                if (progress != null)
                {
                    MessageBox.Show("程序已经启动，请勿重复启动");
                    Environment.Exit(0);
                }
                if (checkUpgrade())
                {
                    Environment.Exit(0);
                }
                else
                {
                    Environment.CurrentDirectory = "d:\\ValmoEngineering";
                    Process.Start("Program.exe");
                }
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("[OnStartup] error! " + ex.ToString());
                Environment.Exit(0);
            }
        }

        public bool checkUpgrade()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    if (File.Exists(drive.Name + "upgrade.exe"))
                    {
                        if (File.Exists("d:\\ValmoEngineering\\upgrade.exe"))
                        {
                            File.Delete("d:\\ValmoEngineering\\upgrade.exe");
                        }
                        File.Copy(drive.Name + "upgrade.exe", "d:\\ValmoEngineering\\upgrade.exe");
                    }
                    if (File.Exists("d:\\ValmoEngineering\\upgrade.exe"))
                    {
                        Process.Start("d:\\ValmoEngineering\\upgrade.exe");
                        
                        return true;
                    }
                }
            }
            return false;
        }


        public static Process GetRunningInstance()
        {
            var current = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(current.ProcessName);
            
            foreach (var process in processes)
            {
                if (process.Id != current.Id)
                    if (System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                        return process;
            }
            return null;
        }


    }
}
