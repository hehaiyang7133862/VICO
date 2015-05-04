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
using System.Threading;
using System.Windows.Threading;
using System.IO;
using nsDataMgr;

namespace nsVicoClient.ctrls
{
    public delegate void refreshCallbackAlmEvent();
    public delegate void setCtrlsLanEvent();

    public partial class topPanelCtrl : UserControl
    {
        dateCtrl dtCtrl = new dateCtrl();

        UserControl[] uCtrls = new UserControl[8];
        List<string> alarmLst = new List<string>();

        static List<uint> lstNum = new List<uint>();
        public delegate void setTopPanelHandle(topPanelType type, int num);
        //public sendMsgToWinEvent sendMsgToWinHandle;
        public linkPlcCtrl linkPanel
        {
            get
            {
                return valmoWin.SLinkPlcPanel;
            }
        }
		private bool _PLCLinkState = false;

		public bool PLCLinkState {
			get {
				return _PLCLinkState;
			}
			set {
				_PLCLinkState = value;
				ellipsePLCLinkState.Opacity = _PLCLinkState == true ? 0 : 1;
			}
		}
        

        public static setCtrlsLanEvent setCtrlsLanHandle;
        lanSelecCtrl lanSelectPanel = new lanSelecCtrl();
        public topPanelCtrl()
        {
            try
            {
                InitializeComponent();

                cvsMain.Children.Add(dtCtrl);

                valmoWin.lstLanRefresh.Add(setCtrlsLanFunc);
                cvsMain.Children.Add(lanSelectPanel);
                lanSelectPanel.setPos(722, 40);

                valmoWin.BackstageClockTick += SystemClock;
                valmoWin.dv.SysPr[11].addHandle(ShowCurrentPage);

                valmoWin.lstLanRefresh.Add(ShowCurrentPage);
            }
            catch (Exception ex)
            {
                vm.perror(ex.ToString());
            }
        }

        private void ShowCurrentPage()
        {
            ShowCurrentPage(valmoWin.dv.SysPr[11]);
        }

        private void ShowCurrentPage(objUnit CurrentPageNumber)
        {
            string strCurrentPage = string.Empty;

            int numMainMenu = CurrentPageNumber.value / 10;
            strCurrentPage += App.Current.TryFindResource(Enum.GetName(typeof(MainMenu), numMainMenu));

            switch (numMainMenu)
            {
                case 0:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(OverViewMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 2:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(MoldMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 3:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(EjectorMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 6:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(ChargeMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 7:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(HeatingMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 8:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(DataAnalysisMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                case 9:
                    {
                        strCurrentPage += "-" + App.Current.TryFindResource(Enum.GetName(typeof(SettingMenu), CurrentPageNumber.value % 10));
                    }
                    break;
                default:
                    break;
            }

            lbPageDis.Content = strCurrentPage;
        }

        public void setCurPageDis(string msg)
        {
            lbPageDis.Content = msg;
        }
        public void setCtrlsLanFunc()
        {
            switch (Common.lan)
            {
                case lanType.lanCN:
                    tbLan.SelectedIndex = 0;
                    break;
                case lanType.lanEN:
                    tbLan.SelectedIndex = 1;

                    break;
            }
            refreshWinName();
            lstWinMsgCtrl1.refreshAlarmList();
            mainPanelCtrl.lanSetHandle();
            valmoWin.execHandle(opeOrderType.winMsg, new WinMsg(WinMsgType.mwMsg));
            paramSetUnitCtrl.sLanRefresh();
            //btnSetCtrl.sLanRefresh();
        }
       
        public void refreshWinName()
        {
            lstWinCtrl1.refreshWinName();
        }
        public bool linkState = false;
        public void sendMsgToWinFunc(WinMsg msg)
        {
            //if (!valmoWin.flagMainWindowInitOk)
            //    return;
            switch (msg.type)
            {
                case WinMsgType.mwLinkPlcOK:
                    {
                        PLCLinkState = true;
                        linkPanel.flagForceClose = false;
                        linkPanel.active = true;
                        linkPanel.Visibility = Visibility.Hidden;

                        linkState = true;

                        valmoWin.eventMgr.Add(new recUnit(recType.sysType,"Sys000", valmoWin.dv.users.curUser.name, DateTime.Now, valmoWin.dv.getCurPlateNr()));

                        //WinMsg mwMsg = new WinMsg();
                        //mwMsg.type = WinMsgType.mwMsg;
                        //valmoWin.sendMsgToWinHandle(mwMsg);
                    }
                    break;
                case WinMsgType.mwLinkPlcError:
                    {
                        PLCLinkState = false;
                        if (!linkPanel.flagForceClose)
                            linkPanel.show();
                        if (linkState)
                        {
                            linkState = false;

                            valmoWin.eventMgr.Add(new recUnit(recType.sysType, "Sys001", valmoWin.dv.users.curUser.name, DateTime.Now, valmoWin.dv.getCurPlateNr()));
                        }
                        //WinMsg mwMsg = new WinMsg();
                        //mwMsg.type = WinMsgType.mwMsg;
                        //valmoWin.sendMsgToWinHandle(mwMsg);
                    }
                    break;
                case WinMsgType.mwLogInOK:
                    {
                        PLCLinkState = true;
                        imgUserNull.Opacity = 0;
                        imgUserOn.Opacity = 1;
                        lbUserName.Content = valmoWin.dv.users.curUser.name;
                    }
                    break;
                case WinMsgType.mwLogOut:
                    {
                        imgUserNull.Opacity = 1;
                        imgUserOn.Opacity = 0;
                        lbUserName.Content = "null";
                    }
                    break;
                case WinMsgType.mwPidClear:
                    {
                    }
                    break;
                case WinMsgType.mwJumpHeartErr:
                    {
                        //imgLineOn.Visibility = Visibility.Hidden;
                    }
                    break;
                case WinMsgType.mwJumpHeartRetart:
                    {

                    }
                    break;
                case WinMsgType.mwRelink:
                    {
                        PLCLinkState = true;
                        linkPanel.flagForceClose = false;
                        linkPanel.active = true;

                        valmoWin.eventMgr.Add(new recUnit(recType.sysType, "Sys000", valmoWin.dv.users.curUser.name, DateTime.Now, valmoWin.dv.getCurPlateNr()));
                    }
                    break;
            }
            lstWinMsgCtrl1.sendMsgToWinFunc(msg);
        }
        public delegate void getWinMsgEvent(string str);
        public delegate void dispatcherNullEvent();

        private void imgHelpOn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //imgHelpOn.Opacity = 0;
        }
        private void imgHelpOn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }
        private void imgLinkOn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PLCLinkState = false;
        }
        private void imgLinkOff_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PLCLinkState = true;
        }

        private void imgLineOn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (linkPanel.Visibility == Visibility.Hidden)
            {
                valmoWin.SLinkPlcPanel.show();
            }
            else
                valmoWin.SLinkPlcPanel.hide();
        }

        private int tmp = 0;
        private bool flag = false;
        /// <summary>
        /// 系统时间
        /// </summary>
        private void SystemClock()
        {
            int sysDate = tmp = valmoWin.dv.SysPr[13].valueNew;
            int sysTime = valmoWin.dv.SysPr[14].valueNew;

            try
            {
                valmoWin.SysTime = new DateTime(Convert.ToInt32((sysDate >> 16) & 0x0fff), Convert.ToInt32((sysDate >> 12) & 0x0000f), Convert.ToInt32((sysDate >> 4) & 0x00000ff),
                     Convert.ToInt32((sysTime >> 24) & 0x000000ff), Convert.ToInt32((sysTime >> 16) & 0x000000ff), Convert.ToInt32((sysTime >> 8) & 0x000000ff));
            }
            catch
            {
                return;
            }

            lbDateTimeMin.Content = valmoWin.SysTime.Minute.ToString().PadLeft(2, '0');
            lbDateTimeHour.Content = valmoWin.SysTime.Hour.ToString().PadLeft(2, '0');

            if (flag == true)
            {
                lbDateTime.Visibility = Visibility.Visible;
                flag = false;
            }
            else
            {
                lbDateTime.Visibility = Visibility.Hidden;
                flag = true;
            }

            lbDateTimeR.Content = valmoWin.SysTime.ToString("MM-dd\tyyyy");

            switch (valmoWin.SysTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Monday");
                    break;
                case DayOfWeek.Tuesday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Thursday");
                    break;
                case DayOfWeek.Friday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Friday");
                    break;
                case DayOfWeek.Saturday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Saturday");
                    break;
                case DayOfWeek.Sunday:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Sunday");
                    break;
                default:
                    lbDateTimeWeek.SetResourceReference(Label.ContentProperty, "Monday");
                    break;
            }
        }

        public int curPage = 1;
        private topPanelType getCurUCType(UserControl uctrl)
        {
            if (uctrl == null)
                return 0;
            topPanelType retValue = topPanelType.moldSpeed;
            switch ((topPanelType)(Int32.Parse(uctrl.Tag.ToString())))
            {
                case topPanelType.clampForce:
                    retValue = topPanelType.clampForce;
                    break;
                case topPanelType.moldSpeed:
                    retValue = topPanelType.moldSpeed;
                    break;
                case topPanelType.moldPos:
                    retValue = topPanelType.moldPos;
                    break;
                case topPanelType.closeMoldTonnage:
                    retValue = topPanelType.closeMoldTonnage;
                    break;
                case topPanelType.clampTorque:
                    retValue = topPanelType.clampTorque;
                    break;
                case topPanelType.motorTemp:
                    retValue = topPanelType.motorTemp;
                    break;
                case topPanelType.ejectorSpeed:
                    retValue = topPanelType.ejectorSpeed;
                    break;
                case topPanelType.ejectorPos:
                    retValue = topPanelType.ejectorPos;
                    break;
                case topPanelType.ejectorTorque:
                    retValue = topPanelType.ejectorTorque;
                    break;
                case topPanelType.ejectorMotorTemp:
                    retValue = topPanelType.ejectorMotorTemp;
                    break;
                case topPanelType.injSpeed:
                    retValue = topPanelType.injSpeed;
                    break;
                case topPanelType.injPress:
                    retValue = topPanelType.injPress;
                    break;
                case topPanelType.vpPos:
                    retValue = topPanelType.vpPos;
                    break;
                case topPanelType.vpPress:
                    retValue = topPanelType.vpPress;
                    break;
                case topPanelType.vpSpeed:
                    retValue = topPanelType.vpSpeed;
                    break;
                case topPanelType.vpTime:
                    retValue = topPanelType.vpTime;
                    break;
                case topPanelType.screwPos:
                    retValue = topPanelType.screwPos;
                    break;
                case topPanelType.posBeforeInjection:
                    retValue = topPanelType.posBeforeInjection;
                    break;
                case topPanelType.cushionPos:
                    retValue = topPanelType.cushionPos;
                    break;
                case topPanelType.injMotorTemp:
                    retValue = topPanelType.injMotorTemp;
                    break;
                case topPanelType.injTorque:
                    retValue = topPanelType.injTorque;
                    break;
                case topPanelType.screwRpm:
                    retValue = topPanelType.screwRpm;
                    break;
                case topPanelType.backPressure:
                    retValue = topPanelType.backPressure;
                    break;
                case topPanelType.cushionTime:
                    retValue = topPanelType.cushionTime;
                    break;
                case topPanelType.PosBeforeCushion:
                    retValue = topPanelType.PosBeforeCushion;
                    break;
                case topPanelType.injectionUnitPos:
                    retValue = topPanelType.injectionUnitPos;
                    break;
                case topPanelType.cushionTorque:
                    retValue = topPanelType.cushionTorque;
                    break;
                case topPanelType.cushionMotorTemp:
                    retValue = topPanelType.cushionMotorTemp;
                    break;
                case topPanelType.tempfirstSec:
                    retValue = topPanelType.tempfirstSec;
                    break;
                case topPanelType.tempSecondSec:
                    retValue = topPanelType.tempSecondSec;
                    break;
                case topPanelType.tempthirdSec:
                    retValue = topPanelType.tempthirdSec;
                    break;
                case topPanelType.tempFourthSec:
                    retValue = topPanelType.tempFourthSec;
                    break;
                case topPanelType.tempFifthSec:
                    retValue = topPanelType.tempFifthSec;
                    break;
                case topPanelType.tempSixthSec:
                    retValue = topPanelType.tempSixthSec;
                    break;
                case topPanelType.hopperTemp:
                    retValue = topPanelType.hopperTemp;
                    break;
                case topPanelType.oilPumpTemp:
                    retValue = topPanelType.oilPumpTemp;
                    break;
                case topPanelType.cycleTime:
                    retValue = topPanelType.cycleTime;
                    break;
                case topPanelType.totalShot:
                    retValue = topPanelType.totalShot;
                    break;
                case topPanelType.markerShot:
                    retValue = topPanelType.markerShot;
                    break;
                case topPanelType.produceShot:
                    retValue = topPanelType.produceShot;
                    break;
                case topPanelType.goodPart:
                    retValue = topPanelType.goodPart;
                    break;
                case topPanelType.rejct:
                    retValue = topPanelType.rejct;
                    break;
                case topPanelType.eachOneEnergy:
                    retValue = topPanelType.eachOneEnergy;
                    break;
                case topPanelType.eachKgEnergy:
                    retValue = topPanelType.eachKgEnergy;
                    break;
                case topPanelType.eachHourEnergy:
                    retValue = topPanelType.eachHourEnergy;
                    break;
                case topPanelType.allEnergy:
                    retValue = topPanelType.allEnergy;
                    break;
                case topPanelType.robotTime:
                    retValue = topPanelType.robotTime;
                    break;
                case topPanelType.robotFreePer:
                    retValue = topPanelType.robotFreePer;
                    break;
                case topPanelType.takeouttime:
                    retValue = topPanelType.takeouttime;
                    break;
                case topPanelType.tunerState:
                    retValue = topPanelType.tunerState;
                    break;
            }
            return retValue;
        }
        bool isTmMouseDown = false;

        private void lbDateTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isTmMouseDown = true;
            //if (cvsTime.Visibility == Visibility.Hidden)
            //{
            //    cvsTime.Visibility = Visibility.Visible;
            //    dtCtrl.init();
            //}
            //else
            //    cvsTime.Visibility = Visibility.Hidden;
        }

        private void lbDateTime_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isTmMouseDown)
            {
                if (dtCtrl.Visibility == Visibility.Hidden)
                {
                    dtCtrl.show();
                }
            }
            isTmMouseDown = false;
        }

        private void lbDateTime_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isTmMouseDown = false;
        }

        private void lbBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cvsTime.Visibility = Visibility.Hidden;
        }
        private void tbLan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!valmoWin.dv.checkAccesslevel(4))
                return;
            lanSelectPanel.show();
        }


    }

    public enum MainMenu
    {
        PT_OverView = 0,
        PT_MachionState = 1,
        PT_Mold = 2,
        PT_Ejector = 3,
        PT_Interpretor = 4,
        PT_Injection = 5,
        PT_Carriage = 6,
        PT_Heating = 7,
        PT_DataAnalysis = 8,
        PT_Setting = 9,
    }

    public enum OverViewMenu
    {
        PT_OverView_QuickSetting = 0,
        PT_OverView_BreakDown = 1,
        PT_OverView_EventRecord = 2,
        PT_OverView_Picture = 3
    }

    public enum MoldMenu
    {
        PT_Mold_Main = 0,
        PT_Mold_MoldProtect = 1,
        PT_Mold_Lubrication = 2,
    }

    public enum EjectorMenu
    {
        PT_Ejector_Main = 0,
        PT_Ejector_AirBlow = 1,
        PT_Ejector_Core = 2,
        PT_Ejector_Core2 = 3,
        PT_Ejector_TuneTable = 4,
    }

    public enum ChargeMenu
    {
        strCharge_Main = 0,
        PT_Carriage_PressureMonitor = 1,
        strCharge_AutoPurge = 2,
        strCharge_InjUnit = 3,
        PT_Carriage_ValvoGate = 4,
        PT_Carriage_Nozzle = 5,
    }

    public enum HeatingMenu
    {
        PT_Heating_Barrel = 0,
        PT_Heating_HotRunner = 1,
    }

    public enum DataAnalysisMenu
    {
        PT_DataAnalysis_Product = 0,
        PT_DataAnalysis_list = 1,
        PT_DataAnalysis_Curve = 2,
        PT_DataAnalysis_SPC = 3,
        PT_DataAnalysis_Schedule = 4,
        PT_DataAnalysis_Maintain = 5,
    }

    public enum SettingMenu
    {
        PT_Setting_System = 0,
        PT_Setting_FastEXE = 1,
        PT_Setting_FuncSetup = 2,
        PT_Setting_Motion = 3,
        PT_Setting_Injection = 4,
        PT_Setting_Mold = 5,
        PT_Setting_Keyboard = 6,
        PT_Setting_Heat = 7,
        PT_Setting_Hardware = 8,
        PT_Setting_Basic = 9,
    }

    public enum topPanelType : byte
    {
        moldSpeed = 1,          //模板速度
        moldPos,                //模板位置
        closeMoldTonnage,       //合模吨位
        clampTorque ,           //移模扭矩
        clampForce,             //锁模力
        motorTemp,              //移模马达温度
        ejectorSpeed ,          //顶针速度
        ejectorPos ,            //顶针位置
        ejectorTorque ,         //顶针扭矩
        ejectorMotorTemp ,      //顶针马达温度

        injSpeed,               //注射速度
        injPress,               //注射压力
        vpPos,                  //V/P切换位置
        vpPress,                //V/P切换压力
        vpSpeed,                //V/P切换速度
        vpTime,                 //V/P切换时间
        screwPos,               //螺杆位置
        posBeforeInjection,     //注射前位置
        cushionPos,             //残料位置
        injMotorTemp,           //注射马达温度

        injTorque,              //注射扭矩
        screwRpm,               //螺杆转速
        backPressure,           //背压压力
        cushionTime,            //储料时间
        PosBeforeCushion,       //储料前位置
        injectionUnitPos,       //射台位置
        cushionTorque,          //储料扭矩
        cushionMotorTemp,       //储料马达温度
        tempfirstSec,           //第一段温度
        tempSecondSec,          //第二段温度
        
        tempthirdSec,           //第三段温度
        tempFourthSec,          //第四段温度
        tempFifthSec,           //第五段温度
        tempSixthSec,           //第六段温度
        hopperTemp,             //落料口温度
        oilPumpTemp,            //油泵温度
        cycleTime,              //周期时间
        totalShot,              //总模数
        markerShot,             //标记模数
        produceShot,            //生产模数
        
        goodPart,               //产品数
        rejct,                  //不良品数
        eachOneEnergy,          //单个能耗
        eachKgEnergy,           //1kg能耗
        eachHourEnergy,         //1小时能耗
        allEnergy,              //整机能耗
        robotTime,              //机械手周期
        robotFreePer,           //机械手占空比
        takeouttime,             //取出时间
        tunerState             //转盘

    }

    public class alarmPanel:UserControl
    {
        public recUnit erObj;
        public Canvas cvs;
        public int no;
        //public string strTest = "";
        public Label lbTest = new Label();

        Label lbSerialNum;
        Label lbDis;
        Label lbDtStart;
        Label lbNo;
        //Image imgBK;
        public alarmPanel(recUnit ErObj,int no)
        {

            cvs = new Canvas();

            lbSerialNum = new Label();
            lbSerialNum.Width = 80;
            lbSerialNum.Height = 34;
            lbSerialNum.FontSize = 18;
            lbSerialNum.VerticalContentAlignment = VerticalAlignment.Center;
            lbSerialNum.HorizontalContentAlignment = HorizontalAlignment.Center;

            lbDis = new Label();
            lbDis.Width = 707;
            lbDis.Height = 34;
            lbDis.FontSize = 18;
            lbDis.VerticalContentAlignment = VerticalAlignment.Center;
            lbDis.HorizontalContentAlignment = HorizontalAlignment.Left;

            lbDtStart = new Label();
            lbDtStart.Width = 300;
            lbDtStart.Height = 34;
            lbDtStart.FontSize = 18;
            lbDtStart.VerticalContentAlignment = VerticalAlignment.Center;
            lbDtStart.HorizontalContentAlignment = HorizontalAlignment.Center;

            lbNo = new Label();
            lbNo.Width = 55;
            lbNo.Height = 34;
            lbNo.FontSize = 18;
            lbNo.HorizontalContentAlignment = HorizontalAlignment.Right;
            lbNo.VerticalContentAlignment = VerticalAlignment.Center;

            cvs.Children.Add(lbSerialNum);
            Canvas.SetLeft(lbSerialNum, 5);
            cvs.Children.Add(lbDis);
            Canvas.SetLeft(lbDis, 385);
            cvs.Children.Add(lbDtStart);
            Canvas.SetLeft(lbDtStart, 85);
            cvs.Children.Add(lbNo);
            Canvas.SetLeft(lbNo, 992);

            cvs.Height = 34;
            cvs.Width = 1053;

            //imgBK = new Image();
            //imgBK.Source = 

            if(ErObj != null)
            {
                object obj = TryFindResource(ErObj.serialNum);
                if (obj != null)
                {
                    lbDis.SetResourceReference(Label.ContentProperty, ErObj.serialNum);
                }

                lbSerialNum.Content = ErObj.serialNum;
                lbDtStart.Content = ErObj.ActiveTime.ToString("yyyy.MM.dd hh:mm:ss");
                lbNo.Content = no;
            }
            erObj = ErObj;

        }

        public void setValue(recUnit ErObj,int no)
        {
            if (ErObj != null)
            {
                object obj = TryFindResource(ErObj.serialNum);
                if (obj != null)
                {
                    lbDis.SetResourceReference(Label.ContentProperty, ErObj.serialNum);
                }

                lbSerialNum.Content = ErObj.serialNum;
                lbDtStart.Content = ErObj.ActiveTime.ToString("yyyy.MM.dd hh:mm:ss");
                lbNo.Content = no;
            }
            erObj = ErObj;
        }

        private string getString(string str, int width)
        {
            string strRet = null;
            strRet = "  " + str;
            if (str != null)
            {
                for (int i = 0; i < width / 25 - 2 - str.Length; i++)
                    strRet += " ";
            }
            return strRet;
        }
    }
}
