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
using System.Windows.Threading;
using System.IO;
using System.Collections.Specialized;
using nsDataMgr;

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// Interaction logic for lstWinCtrls.xaml
    /// </summary>
    public partial class lstWinCtrls : UserControl
    {
        public delegate void showSelectedPanelHandle();
        long tmStart = 0;
        int curPage = 1;
        DispatcherTimer dtSelect;
        double[] posX = new double[8];
        double posY = 0;
        msgWinModel[] winTopCtrls = new msgWinModel[8];
        msgWinModel[] winGrps = new msgWinModel[51];
        bool flagLstWinsVisible
        {
            get
            {
                if (imgBackBg.Visibility == Visibility.Visible)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value)
                {
                    bdFocus.Visibility = Visibility.Visible;
                    cvsMain.Height = 1200;
                    imgBackBg.Visibility = Visibility.Visible;
                    barrelHeatStp1.Visibility = Visibility.Visible;
                    barrelHeatStp2.Visibility = Visibility.Visible;
                    barrelHeatStp3.Visibility = Visibility.Visible;
                    barrelHeatStp4.Visibility = Visibility.Visible;
                    barrelHeatStp5.Visibility = Visibility.Visible;
                    barrelHeatStp6.Visibility = Visibility.Visible;
                    chargeTimeStp.Visibility = Visibility.Visible;
                    clampForceStp.Visibility = Visibility.Visible;
                    //clampTorqueStp.Visibility = Visibility.Visible;
                    eachHourEnergyStp.Visibility = Visibility.Visible;
                    goodPartStp.Visibility = Visibility.Visible;
                    injPresStp.Visibility = Visibility.Visible;
                    moldPosStp.Visibility = Visibility.Visible;
                    moldSpeedStp.Visibility = Visibility.Visible;
                    motorTempStp.Visibility = Visibility.Visible;
                    posbefChargeStp.Visibility = Visibility.Visible;
                    rejectStp.Visibility = Visibility.Visible;
                    screwRPMStp.Visibility = Visibility.Visible;
                    takeOutTimeStp.Visibility = Visibility.Visible;
                    VPVelStp.Visibility = Visibility.Visible;
                    totalShotStp.Visibility = Visibility.Visible;
                    VPPosStp.Visibility = Visibility.Visible;
                    ejectorSpeedStp.Visibility = Visibility.Visible;
                    injSpeedStp.Visibility = Visibility.Visible;
                    cycleTimeStp.Visibility = Visibility.Visible;
                    robotTimeStp.Visibility = Visibility.Visible;
                    ejectorPosStp.Visibility = Visibility.Visible;
                    backPressureStp.Visibility = Visibility.Visible;
                    robotFreePerStp.Visibility = Visibility.Visible;
                    //closeMoldTonnageStp.Visibility = Visibility.Visible;
                    //ejectorTorqueStp.Visibility = Visibility.Visible;
                    markerShotStp.Visibility = Visibility.Visible;
                    produceShotStp.Visibility = Visibility.Visible;
                    ejectorMotorTempStp.Visibility = Visibility.Visible;
                    VPPressureStp.Visibility = Visibility.Visible;
                    cushionPosStp.Visibility = Visibility.Visible;
                    injectionUnitPosStp.Visibility = Visibility.Visible;
                    oilPumpTempStp.Visibility = Visibility.Visible;
                    VPTimeStp.Visibility = Visibility.Visible;
                    screwPosStp.Visibility = Visibility.Visible;
                    hopperTempStp.Visibility = Visibility.Visible;
                    eachOneEnergyStp.Visibility = Visibility.Visible;
                    eachKgEnergyStp.Visibility = Visibility.Visible;
                    posBeforeInjectionStp.Visibility = Visibility.Visible;
                    injMotorTempStp.Visibility = Visibility.Visible;
                    allEnergyStp.Visibility = Visibility.Visible;
                    //injTorqueStp.Visibility = Visibility.Visible;
                    //cushionTorqueStp.Visibility = Visibility.Visible;
                    cushionMotorTempStp.Visibility = Visibility.Visible;
                    tunerPosStp.Visibility = Visibility.Visible;
                }
                else
                {
                    bdFocus.Visibility = Visibility.Hidden;
                    cvsMain.Height = 180;
                    imgBackBg.Visibility = Visibility.Hidden;
                    barrelHeatStp1.Visibility = Visibility.Hidden;
                    barrelHeatStp2.Visibility = Visibility.Hidden;
                    barrelHeatStp3.Visibility = Visibility.Hidden;
                    barrelHeatStp4.Visibility = Visibility.Hidden;
                    barrelHeatStp5.Visibility = Visibility.Hidden;
                    barrelHeatStp6.Visibility = Visibility.Hidden;
                    chargeTimeStp.Visibility = Visibility.Hidden;
                    clampForceStp.Visibility = Visibility.Hidden;
                    //clampTorqueStp.Visibility = Visibility.Hidden;
                    eachHourEnergyStp.Visibility = Visibility.Hidden;
                    goodPartStp.Visibility = Visibility.Hidden;
                    injPresStp.Visibility = Visibility.Hidden;
                    moldPosStp.Visibility = Visibility.Hidden;
                    moldSpeedStp.Visibility = Visibility.Hidden;
                    motorTempStp.Visibility = Visibility.Hidden;
                    posbefChargeStp.Visibility = Visibility.Hidden;
                    rejectStp.Visibility = Visibility.Hidden;
                    screwRPMStp.Visibility = Visibility.Hidden;
                    takeOutTimeStp.Visibility = Visibility.Hidden;
                    VPVelStp.Visibility = Visibility.Hidden;
                    totalShotStp.Visibility = Visibility.Hidden;
                    VPPosStp.Visibility = Visibility.Hidden;
                    ejectorSpeedStp.Visibility = Visibility.Hidden;
                    injSpeedStp.Visibility = Visibility.Hidden;
                    cycleTimeStp.Visibility = Visibility.Hidden;
                    robotTimeStp.Visibility = Visibility.Hidden;
                    ejectorPosStp.Visibility = Visibility.Hidden;
                    backPressureStp.Visibility = Visibility.Hidden;
                    robotFreePerStp.Visibility = Visibility.Hidden;
                    //closeMoldTonnageStp.Visibility = Visibility.Hidden;
                    //ejectorTorqueStp.Visibility = Visibility.Hidden;
                    markerShotStp.Visibility = Visibility.Hidden;
                    produceShotStp.Visibility = Visibility.Hidden;
                    ejectorMotorTempStp.Visibility = Visibility.Hidden;
                    VPPressureStp.Visibility = Visibility.Hidden;
                    cushionPosStp.Visibility = Visibility.Hidden;
                    injectionUnitPosStp.Visibility = Visibility.Hidden;
                    oilPumpTempStp.Visibility = Visibility.Hidden;
                    VPTimeStp.Visibility = Visibility.Hidden;
                    screwPosStp.Visibility = Visibility.Hidden;
                    hopperTempStp.Visibility = Visibility.Hidden;
                    eachOneEnergyStp.Visibility = Visibility.Hidden;
                    eachKgEnergyStp.Visibility = Visibility.Hidden;
                    posBeforeInjectionStp.Visibility = Visibility.Hidden;
                    injMotorTempStp.Visibility = Visibility.Hidden;
                    allEnergyStp.Visibility = Visibility.Hidden;
                    //injTorqueStp.Visibility = Visibility.Hidden;
                    //cushionTorqueStp.Visibility = Visibility.Hidden;
                    cushionMotorTempStp.Visibility = Visibility.Hidden;
                    tunerPosStp.Visibility = Visibility.Hidden;
                    for (int i = 0; i < 8; i++)
                    {
                        if (winTopCtrls[i] != null)
                            winTopCtrls[i].Visibility = Visibility.Visible;
                    }
                }
            }
        }
        public lstWinCtrls()
        {
            InitializeComponent();
            posX[0] = Canvas.GetLeft(imgWin1);
            posX[1] = Canvas.GetLeft(imgWin2);
            posX[2] = Canvas.GetLeft(imgWin3);
            posX[3] = Canvas.GetLeft(imgWin4);
            posX[4] = Canvas.GetLeft(imgWin5);
            posX[5] = Canvas.GetLeft(imgWin6);
            posX[6] = Canvas.GetLeft(imgWin7);
            posX[7] = Canvas.GetLeft(imgWin8);
            posY = Canvas.GetTop(imgWin1);

            barrelHeatStp1.Tag = getPosTag(barrelHeatStp1);
            barrelHeatStp2.Tag = getPosTag(barrelHeatStp2);
            barrelHeatStp3.Tag = getPosTag(barrelHeatStp3);
            barrelHeatStp4.Tag = getPosTag(barrelHeatStp4);
            barrelHeatStp5.Tag = getPosTag(barrelHeatStp5);
            barrelHeatStp6.Tag = getPosTag(barrelHeatStp6);
            chargeTimeStp.Tag = getPosTag(chargeTimeStp);
            clampForceStp.Tag = getPosTag(clampForceStp);
            //clampTorqueStp.Tag = getPosTag(clampTorqueStp);
            eachHourEnergyStp.Tag = getPosTag(eachHourEnergyStp);
            goodPartStp.Tag = getPosTag(goodPartStp);
            injPresStp.Tag = getPosTag(injPresStp);
            moldPosStp.Tag = getPosTag(moldPosStp);
            moldSpeedStp.Tag = getPosTag(moldSpeedStp);
            motorTempStp.Tag = getPosTag(motorTempStp);
            posbefChargeStp.Tag = getPosTag(posbefChargeStp);
            rejectStp.Tag = getPosTag(rejectStp);
            screwRPMStp.Tag = getPosTag(screwRPMStp);
            takeOutTimeStp.Tag = getPosTag(takeOutTimeStp);
            VPVelStp.Tag = getPosTag(VPVelStp);
            totalShotStp.Tag = getPosTag(totalShotStp);
            VPPosStp.Tag = getPosTag(VPPosStp);
            ejectorSpeedStp.Tag = getPosTag(ejectorSpeedStp);
            injSpeedStp.Tag = getPosTag(injSpeedStp);
            cycleTimeStp.Tag = getPosTag(cycleTimeStp);
            robotTimeStp.Tag = getPosTag(robotTimeStp);
            ejectorPosStp.Tag = getPosTag(ejectorPosStp);
            backPressureStp.Tag = getPosTag(backPressureStp);
            robotFreePerStp.Tag = getPosTag(robotFreePerStp);
            //closeMoldTonnageStp = new closeMoldTonnage_stp();
            //closeMoldTonnageStp.Tag = (int)topPanelType.closeMoldTonnage;
            //ejectorTorqueStp.Tag = getPosTag(ejectorTorqueStp);
            markerShotStp.Tag = getPosTag(markerShotStp);
            produceShotStp.Tag = getPosTag(produceShotStp);
            ejectorMotorTempStp.Tag = getPosTag(ejectorMotorTempStp);
            VPPressureStp.Tag = getPosTag(VPPressureStp);
            //posBeforeCushionStp = new posBeforeCushion_stp();
            //posBeforeCushionStp.Tag = (int)topPanelType.PosBeforeCushion;
            cushionPosStp.Tag = getPosTag(cushionPosStp);
            injectionUnitPosStp.Tag = getPosTag(injectionUnitPosStp);
            oilPumpTempStp.Tag = getPosTag(oilPumpTempStp);
            VPTimeStp.Tag = getPosTag(VPTimeStp);
            screwPosStp.Tag = getPosTag(screwPosStp);
            hopperTempStp.Tag = getPosTag(hopperTempStp);
            eachOneEnergyStp.Tag = getPosTag(eachOneEnergyStp);
            eachKgEnergyStp.Tag = getPosTag(eachKgEnergyStp);
            posBeforeInjectionStp.Tag = getPosTag(posBeforeInjectionStp);
            injMotorTempStp.Tag = getPosTag(injMotorTempStp);
            allEnergyStp.Tag = getPosTag(allEnergyStp);
            //injTorqueStp.Tag = getPosTag(injTorqueStp);
            //cushionTorqueStp.Tag = getPosTag(cushionTorqueStp);
            cushionMotorTempStp.Tag = getPosTag(cushionMotorTempStp);
            tunerPosStp.Tag = getPosTag(tunerPosStp);

            winGrps[(int)topPanelType.moldSpeed] = moldSpeedStp;
            winGrps[(int)topPanelType.moldPos] = moldPosStp;
                //winGrps[(int)topPanelType.closeMoldTonnage] = 
            //winGrps[(int)topPanelType.clampTorque] = clampTorqueStp;
            winGrps[(int)topPanelType.clampForce] = clampForceStp;
            winGrps[(int)topPanelType.motorTemp] = motorTempStp;
            winGrps[(int)topPanelType.ejectorSpeed] = ejectorSpeedStp;
            winGrps[(int)topPanelType.ejectorPos] = ejectorPosStp;
            //winGrps[(int)topPanelType.ejectorTorque] = ejectorTorqueStp;
            winGrps[(int)topPanelType.ejectorMotorTemp] = ejectorMotorTempStp;
            winGrps[(int)topPanelType.injSpeed] = injSpeedStp;

            winGrps[(int)topPanelType.injPress] = injPresStp;
            winGrps[(int)topPanelType.vpPos] = VPPosStp;
            winGrps[(int)topPanelType.vpPress] = VPPressureStp;
            winGrps[(int)topPanelType.vpSpeed] = VPVelStp;
            winGrps[(int)topPanelType.vpTime] = VPTimeStp;
            winGrps[(int)topPanelType.screwPos] = screwPosStp;
            winGrps[(int)topPanelType.posBeforeInjection] = posBeforeInjectionStp;
            winGrps[(int)topPanelType.cushionPos] = cushionPosStp;
            winGrps[(int)topPanelType.injMotorTemp] = injMotorTempStp;
            //winGrps[(int)topPanelType.injTorque] = injTorqueStp;

            winGrps[(int)topPanelType.screwRpm] = screwRPMStp;
            winGrps[(int)topPanelType.backPressure] = backPressureStp;
            winGrps[(int)topPanelType.cushionTime] = chargeTimeStp;
            winGrps[(int)topPanelType.PosBeforeCushion] = posbefChargeStp;
            winGrps[(int)topPanelType.injectionUnitPos] = injectionUnitPosStp;
            //winGrps[(int)topPanelType.cushionTorque] = cushionTorqueStp;
            winGrps[(int)topPanelType.cushionMotorTemp] = cushionMotorTempStp;
            winGrps[(int)topPanelType.tempfirstSec] = barrelHeatStp1;
            winGrps[(int)topPanelType.tempSecondSec] = barrelHeatStp2;
            winGrps[(int)topPanelType.tempthirdSec] = barrelHeatStp3;
           
            winGrps[(int)topPanelType.tempFourthSec] = barrelHeatStp4;
            winGrps[(int)topPanelType.tempFifthSec] = barrelHeatStp5;
            winGrps[(int)topPanelType.tempSixthSec] = barrelHeatStp6;
            winGrps[(int)topPanelType.hopperTemp] = hopperTempStp;
            winGrps[(int)topPanelType.oilPumpTemp] = oilPumpTempStp;
            winGrps[(int)topPanelType.cycleTime] = cycleTimeStp;
            winGrps[(int)topPanelType.totalShot] = totalShotStp;
            winGrps[(int)topPanelType.markerShot] = markerShotStp;
            winGrps[(int)topPanelType.produceShot] = produceShotStp;
            winGrps[(int)topPanelType.goodPart] = goodPartStp;
            
            winGrps[(int)topPanelType.rejct] = rejectStp;
            winGrps[(int)topPanelType.eachOneEnergy] = eachOneEnergyStp;
            winGrps[(int)topPanelType.eachKgEnergy] = eachKgEnergyStp;
            winGrps[(int)topPanelType.eachHourEnergy] = eachHourEnergyStp;
            winGrps[(int)topPanelType.allEnergy] = allEnergyStp;
            winGrps[(int)topPanelType.robotTime] = robotTimeStp;
            winGrps[(int)topPanelType.robotFreePer] = robotFreePerStp;
            winGrps[(int)topPanelType.takeouttime] = takeOutTimeStp;
            winGrps[(int)topPanelType.tunerState] = tunerPosStp; 


            cvsMain.Height = 180;
            dtSelect = new DispatcherTimer();
            dtSelect.Interval = new TimeSpan(1000);
            dtSelect.Tick += new EventHandler(ctrlSelectPanel);

            flagLstWinsVisible = false;
            readParamFile();

            valmoWin.dv.TmpPr[72].addHandle(IsHeatingZoneControl1Visiable);
            valmoWin.dv.TmpPr[79].addHandle(IsHeatingZoneControl2Visiable);
            valmoWin.dv.TmpPr[86].addHandle(IsHeatingZoneControl3Visiable);
            valmoWin.dv.TmpPr[93].addHandle(IsHeatingZoneControl4Visiable);
            valmoWin.dv.TmpPr[100].addHandle(IsHeatingZoneControl5Visiable);
            valmoWin.dv.TmpPr[107].addHandle(IsHeatingZoneControl6Visiable);
        }

        private void IsHeatingZoneControl1Visiable(objUnit obj)
        {
            barrelHeatStp1.Opacity = (obj.value == 1) ? 1 : 0;
        }
        private void IsHeatingZoneControl2Visiable(objUnit obj)
        {
            barrelHeatStp2.Opacity = (obj.value == 1) ? 1 : 0;
        }
        private void IsHeatingZoneControl3Visiable(objUnit obj)
        {
            barrelHeatStp3.Opacity = (obj.value == 1) ? 1 : 0;
        }
        private void IsHeatingZoneControl4Visiable(objUnit obj)
        {
            barrelHeatStp4.Opacity = (obj.value == 1) ? 1 : 0;
        }
        private void IsHeatingZoneControl5Visiable(objUnit obj)
        {
            barrelHeatStp5.Opacity = (obj.value == 1) ? 1 : 0;
        }
        private void IsHeatingZoneControl6Visiable(objUnit obj)
        {
            barrelHeatStp6.Opacity = (obj.value == 1) ? 1 : 0;
        }

        //bool readTopTabelPanelFileOk = true;
        public void readParamFile()
        {
            try
            {
                StringCollection strLst = Properties.Settings.Default.topWinPos;
                //string[] strValue = strLst.Split(',');
                if (strLst.Count == 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        msgWinModel winCtrl = winGrps[Int32.Parse(strLst[i])];
                        if (winCtrl != null)
                        {
                            Canvas.SetLeft(winCtrl, posX[i]);
                            Canvas.SetTop(winCtrl, posY);
                            winTopCtrls[i] = winCtrl;
                            winCtrl.flagShow = true;
                            winCtrl.Visibility = Visibility.Visible;
                        }
                    }
                }
                else
                {
                    int[] baseWinNr = new int[8] { 37, 41, 2, 17, 5, 19, 12, 8 };
                    for (int i = 0; i < 8; i++)
                    {
                        msgWinModel winCtrl = winGrps[baseWinNr[i]];
                        if (winCtrl != null)
                        {
                            Canvas.SetLeft(winCtrl, posX[i]);
                            Canvas.SetTop(winCtrl, posY);
                            winTopCtrls[i] = winCtrl;
                            winCtrl.flagShow = true;
                            winCtrl.Visibility = Visibility.Visible;
                        }
                    }
                    StringCollection strPosLst = new StringCollection() { "37", "41", "2", "17", "5", "19", "12", "8" };
                    Properties.Settings.Default.topWinPos = strPosLst;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                int[] baseWinNr = new int[8] { 37, 41, 2, 17, 5, 19, 12, 8 };
                for (int i = 0; i < 8; i++)
                {
                    msgWinModel winCtrl = winGrps[baseWinNr[i]];
                    if (winCtrl != null)
                    {
                        Canvas.SetLeft(winCtrl, posX[i]);
                        Canvas.SetTop(winCtrl, posY);
                        winTopCtrls[i] = winCtrl;
                        winCtrl.flagShow = true;
                        winCtrl.Visibility = Visibility.Visible;
                    }
                }
                StringCollection strPosLst = new StringCollection() { "37", "41", "2", "17", "5", "19", "12", "8" };
                Properties.Settings.Default.topWinPos = strPosLst;
                Properties.Settings.Default.Save();
                vm.perror("[lstWinCtrls.readParamFile]" + ex.ToString());
            }

        }
        public void init()
        {
            moldSpeedStp.init();
            moldPosStp.init();
            clampForceStp.init();
            motorTempStp.init();
            ejectorSpeedStp.init();
            ejectorPosStp.init();
            ejectorMotorTempStp.init();
            injSpeedStp.init();
            injPresStp.init();
            VPPosStp.init();
            VPPressureStp.init();
            VPVelStp.init();
            VPTimeStp.init();
            screwPosStp.init();
            posBeforeInjectionStp.init();
            cushionPosStp.init();
            injMotorTempStp.init();
            screwRPMStp.init();
            backPressureStp.init();
            chargeTimeStp.init();
            posbefChargeStp.init();
            //cushionTorqueStp.init();
            cushionMotorTempStp.init();
            barrelHeatStp1.init();
            barrelHeatStp2.init();
            barrelHeatStp3.init();
            barrelHeatStp4.init();
            barrelHeatStp5.init();
            barrelHeatStp6.init();
            hopperTempStp.init();
            oilPumpTempStp.init();
            cycleTimeStp.init();
            totalShotStp.init();
            markerShotStp.init();
            produceShotStp.init();
            goodPartStp.init();
            rejectStp.init();
            eachOneEnergyStp.init();
            eachKgEnergyStp.init();
            eachHourEnergyStp.init();
            allEnergyStp.init();
            robotTimeStp.init();
            robotFreePerStp.init();
            takeOutTimeStp.init();
        }
        public void refreshWinName()
        {
            moldSpeedStp.refreshWinName();
            moldPosStp.refreshWinName();
            //clampTorqueStp.refreshWinName();
            clampForceStp.refreshWinName();
            motorTempStp.refreshWinName();
            ejectorSpeedStp.refreshWinName();
            ejectorPosStp.refreshWinName();
            //ejectorTorqueStp.refreshWinName();
            ejectorMotorTempStp.refreshWinName();
            injSpeedStp.refreshWinName();
            injPresStp.refreshWinName();
            VPPosStp.refreshWinName();
            VPPressureStp.refreshWinName();
            VPVelStp.refreshWinName();
            VPTimeStp.refreshWinName();
            screwPosStp.refreshWinName();
            posBeforeInjectionStp.refreshWinName();
            cushionPosStp.refreshWinName();
            injMotorTempStp.refreshWinName();
            //injTorqueStp.refreshWinName();
            screwRPMStp.refreshWinName();
            backPressureStp.refreshWinName();
            chargeTimeStp.refreshWinName();
            posbefChargeStp.refreshWinName();
            //cushionTorqueStp.refreshWinName();
            cushionMotorTempStp.refreshWinName();
            barrelHeatStp1.refreshWinName();
            barrelHeatStp2.refreshWinName();
            barrelHeatStp3.refreshWinName();
            barrelHeatStp4.refreshWinName();
            barrelHeatStp5.refreshWinName();
            barrelHeatStp6.refreshWinName();
            hopperTempStp.refreshWinName();
            oilPumpTempStp.refreshWinName();
            cycleTimeStp.refreshWinName();
            totalShotStp.refreshWinName();
            markerShotStp.refreshWinName();
            produceShotStp.refreshWinName();
            goodPartStp.refreshWinName();
            rejectStp.refreshWinName();
            eachOneEnergyStp.refreshWinName();
            eachKgEnergyStp.refreshWinName();
            eachHourEnergyStp.refreshWinName();
            allEnergyStp.refreshWinName();
            robotTimeStp.refreshWinName();
            robotFreePerStp.refreshWinName();
            takeOutTimeStp.refreshWinName();
            injectionUnitPosStp.refreshWinName();
        }
        private string getPosTag(UIElement ue)
        {
            return Canvas.GetLeft(ue) + "," + Canvas.GetTop(ue);
        }
        private void ctrlSelectPanel(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(new showSelectedPanelHandle(showSelectedPanel), null);
        }
        private void showSelectedPanel()
        {
            if (tmStart == 0)
            {
                tmStart = DateTime.Now.Ticks;
            }
            if (DateTime.Now.Ticks - tmStart > 6000000)
            {
                tmStart = 0;
                dtSelect.Stop();
                flagLstWinsVisible = true;
                //pswp.init(topPanelType.moldPos, 1);
                //topPanelType[] type = new topPanelType[8];
                //for (int i = 0; i < 8; i++)
                //{
                //    type[i] = getCurUCType(uCtrls[i]);
                //}
                //pswp.init(type, curPage);
                //MessageBox.Show("ok");
            }
        }

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
        private void setFocus(Label lb)
        {
            Canvas.SetLeft(bdFocus,Canvas.GetLeft(lb));
            Canvas.SetTop(bdFocus,Canvas.GetTop(lb));
        }
        private void lbWin1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 1;
                dtSelect.Start();
                setFocus(lbWin1);
                //flagLstWinsVisible = true;
            }
            else
            {
                //flagLstWinsVisible = false;
                curPage = 1;
                //dtSelect.Start();
                setFocus(lbWin1);
            }
        }

        private void lbWin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (dtSelect.IsEnabled == true)
                dtSelect.Stop();
        }

        private void lbWin_MouseLeave(object sender, MouseEventArgs e)
        {
            if (dtSelect.IsEnabled == true)
                dtSelect.Stop();
        }

        private void lbWin2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 2;
                dtSelect.Start();
                setFocus(lbWin2);
                //flagLstWinsVisible = true;
            }
            else
            {
                //flagLstWinsVisible = false;
                //tmStart = DateTime.Now.Ticks;
                curPage = 2;
                //dtSelect.Start();
                setFocus(lbWin2);
            }
        }

        private void lbWin3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 3;
                dtSelect.Start();
                setFocus(lbWin3);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 3;
                //dtSelect.Start();
                setFocus(lbWin3);
            }
        }

        private void lbWin4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 4;
                dtSelect.Start();
                setFocus(lbWin4);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 4;
                //dtSelect.Start();
                setFocus(lbWin4);
            }
        }

        private void lbWin5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 5;
                dtSelect.Start();
                setFocus(lbWin5);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 5;
                //dtSelect.Start();
                setFocus(lbWin5);
            }
        }

        private void lbWin6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 6;
                dtSelect.Start();
                setFocus(lbWin6);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 6;
                //dtSelect.Start();
                setFocus(lbWin6);
            }
        }

        private void lbWin7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 7;
                dtSelect.Start();
                setFocus(lbWin7);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 7;
                //dtSelect.Start();
                setFocus(lbWin7);
            }
        }

        private void lbWin8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!flagLstWinsVisible)
            {
                tmStart = DateTime.Now.Ticks;
                curPage = 8;
                dtSelect.Start();
                setFocus(lbWin8);
                //flagLstWinsVisible = true;
            }
            else
            {
                curPage = 8;
                //dtSelect.Start();
                setFocus(lbWin8);
            }
        }

        private void moldSpeedStp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            msgWinModel winCtrl = sender as msgWinModel;
            if (!winCtrl.flagShow)
            {
                if (winTopCtrls[curPage - 1] != null)
                {
                    string strPos = winTopCtrls[curPage - 1].Tag.ToString();
                    string[] pos = strPos.Split(',');
                    Canvas.SetLeft(winTopCtrls[curPage - 1], Double.Parse(pos[0]));
                    Canvas.SetTop(winTopCtrls[curPage - 1], Double.Parse(pos[1]));
                    winTopCtrls[curPage - 1].flagShow = false;
                }
                Canvas.SetLeft(winCtrl, posX[curPage - 1]);
                Canvas.SetTop(winCtrl, posY);
                winCtrl.flagShow = true;
                winTopCtrls[curPage - 1] = winCtrl;
            }
            else
            {
                if(flagLstWinsVisible)
                    flagLstWinsVisible = false;
            }
            string str = "";
            StringCollection strPosLst = new StringCollection();
            for (int i = 0; i < 8; i++)
            {
                if (winTopCtrls[i] != null)
                    strPosLst.Add(((int)winTopCtrls[i].type).ToString());
                //str += (int)winTopCtrls[i].type + ",";
                else
                    strPosLst.Add("0");
                    //str += "0,";
            }
            Properties.Settings.Default.topWinPos = strPosLst;
            Properties.Settings.Default.Save();
            flagLstWinsVisible = false;
        }

        private void imgBackBg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            flagLstWinsVisible = false;
        }

    }
}
