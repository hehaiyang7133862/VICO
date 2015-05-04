using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using nsVicoClient.ctrls;
using nsDataMgr;
using System.Xml;

namespace nsVicoClient
{
    public class LogList
    {
        public delegate bool FilterFunction(recUnit logUnit);
        public List<FilterFunction> FilterFunctions = new List<FilterFunction>();
        public nullEvent refush;
        public int loadCount = 0;

        private string savePath = @"D:\Valmo\EventRecord";
        private List<recUnit> lstLog = new List<recUnit>();
        public List<recUnit> lstFilter = new List<recUnit>();

        public LogList()
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            Load();
        }

        public void Save()
        {
            FileStream fs = new FileStream(savePath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            for (int i = loadCount; i < lstLog.Count; i++)
            {
                sw.WriteLine(lstLog[i].ToString());
            }

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void Load()
        {
            List<string> loadPath = new List<string>();

            for (int i = 0; (i < 100) && (loadPath.Count < 14); i++)
            {
                string temp = savePath + "\\" + (DateTime.Now - TimeSpan.FromDays(i)).ToString("yyyy-MM-dd") + ".txt";

                if (File.Exists(temp))
                {
                    loadPath.Add(temp);
                }
            }

            lstLog.Clear();

            for (int i = loadPath.Count - 1; i >= 0; i--)
            {
                FileStream fs = new FileStream(loadPath[i], FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                fs.Seek(0, SeekOrigin.Begin);

                while (true)
                {
                    string content = sr.ReadLine();

                    if (content == null)
                    {
                        break;
                    }

                    lstLog.Add(new recUnit(content));
                }
            }

            loadCount = lstLog.Count;
        }

        public void Add(recUnit log)
        {
            lstLog.Add(log);

            Filter();
        }

        public void Delete(recUnit log)
        {
            lstLog.Remove(log);
        }

        public void Filter()
        {
            lstFilter.Clear();

            for (int i = lstLog.Count - 1; i >= 0; i--)
            {
                bool b = true;

                foreach (FilterFunction ff in FilterFunctions)
                {
                    b &= ff(lstLog[i]);
                }

                if (b == true)
                {
                    lstFilter.Add(lstLog[i]);
                }
            }

            if (refush != null)
            {
                refush();
            }
        }
    }
}
