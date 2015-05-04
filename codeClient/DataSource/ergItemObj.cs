using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using nsVicoClient.ctrls;

namespace nsVicoClient
{
    public enum recType : int
    {
        alarmType = 0,
        sysType = 1,
        operateType = 2,
        logType = 3
    }

    public class recUnit
    {
        public recType type;
        public string serialNum;
        public string UserName;
        public DateTime ActiveTime;
        public int Shots;
        public double OldValue;
        public double NewValue;

        /// <summary>
        /// Alarm 初始化
        /// </summary>
        public recUnit(recType Type, string SerialNumber, string UserName, DateTime ActiveTime, int Shots)
        {
            this.type = Type;
            this.serialNum = SerialNumber;
            this.UserName = UserName;
            this.ActiveTime = ActiveTime;
            this.Shots = Shots;
        }
        /// <summary>
        /// Operate 初始化
        /// </summary>
        public recUnit(string SerialNumber, string UserName, DateTime ActiveTime, int Shots,double OldValue,double NewValue)
        {
            this.type = recType.operateType;
            this.serialNum = SerialNumber;
            this.UserName = UserName;
            this.ActiveTime = ActiveTime;
            this.Shots = Shots;
            this.OldValue = OldValue;
            this.NewValue = NewValue;
        }
        /// <summary>
        /// LogIn 初始化
        /// </summary>
        public recUnit(string serialNum, string UserName, DateTime ActiveTime, int Shots)
        {
            this.type = recType.logType;
            this.serialNum = serialNum;
            this.UserName = UserName;
            this.ActiveTime = ActiveTime;
            this.Shots = Shots;
        }
        /// <summary>
        /// 从文件读入
        /// </summary>
        public recUnit(string str)
        {
            if (str.IndexOf(",") != -1)
            {
                string[] strTmp = str.Split(',');

                if (strTmp.Length == 7)
                {
                    serialNum = strTmp[0].Trim();
                    type = (recType)Convert.ToInt16(strTmp[1]);
                    UserName = strTmp[2];
                    ActiveTime = Convert.ToDateTime(strTmp[3]);
                    Shots = Convert.ToInt32(strTmp[4]);
                    OldValue = Convert.ToDouble(strTmp[5]);
                    NewValue = Convert.ToDouble(strTmp[6]);
                }
                else
                {
                    App.log.Error("Log载入失败：" + str);
                }
            }
        }

        public override string ToString()
        {
            string result = "";

            result += serialNum + ",";
            result += ((int)type).ToString() + ",";
            result += UserName + ",";
            result += ActiveTime.ToString() + ",";
            result += Shots + ",";
            result += OldValue + ",";
            result += NewValue;

            return result;
        }
    }
}
