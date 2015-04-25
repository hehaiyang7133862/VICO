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
using nsDataMgr;
namespace nsVicoClient.ctrls
{
    /// <summary>
    /// Interaction logic for msgWinModel.xaml
    /// </summary>
    public partial class msgWinModel : UserControl
    {
        topPanelType ctrlType = topPanelType.moldSpeed;
        objUnit objCur;
        objUnit objPerCur;
        objUnit objPerBasic;
        intEvent lnHandle;
        public msgWinModel()
        {
            InitializeComponent();
        }
        public string name
        {
            get
            {
                return lbNameFore.Content.ToString();
            }
            set
            {
                lbNameFore.Content = value;
            }
        }
        public void handle(objUnit obj)
        {
            if (lnHandle != null)
                lnHandle(obj.value);
        }
        public void init()
        {
            if (objCur != null)
                objCur.addHandle(handle);
            if (objPerBasic != null)
                objPerBasic.addHandle(handle);
        }
        public static DependencyProperty disProperty = DependencyProperty.Register(
            "dis",                                                    // Property name
            typeof(Object),                                           // Property type
            typeof(msgWinModel),                                      // Type of the dependency property provider
            new PropertyMetadata("",                                // 默认的值
            new PropertyChangedCallback(OnUriChanged)             // Callback invoked on property value has changes
            )
        );

        private static void OnUriChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as msgWinModel).lbNameFore.Content = e.NewValue;
        }
        public object dis
        {
            set
            {
                lbNameFore.Content = value;
            }
        }
        public topPanelType type
        {
            get
            {
                return ctrlType;
            }
            set
            {
                ctrlType = value;
                imgBackPresFlag.Opacity = 0;
                switch (value)
                {
                    case topPanelType.moldSpeed:
                        {
                            imgMoldFlag.Opacity = 1;
                            lbNameFore.Content = "模板速度[" + objUnit.unitBase[UnitType.Spd_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.MldPr[145];
                            objPerCur = valmoWin.dv.MldPr[146];
                            objPerBasic = valmoWin.dv.MldPr[232];
                            lnHandle = new intEvent(lenLnCtrlHandle);

                        }
                        break;
                    case topPanelType.moldPos:
                        {
                            imgMoldFlag.Opacity = 1;
                            lbNameFore.Content = "模板位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.MldPr[7];
                            objPerCur = valmoWin.dv.MldPr[7];
                            objPerBasic = valmoWin.dv.MldPr[226];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.closeMoldTonnage:
                        {

                        }
                        break;
                    case topPanelType.clampTorque:
                        {
                            imgTorqueFlag.Opacity = 1;
                            lbNameFore.Content = "移模扭矩[" + objUnit.unitBase[UnitType.Torque] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.SysPr[98];
                            objPerCur = valmoWin.dv.SysPr[97];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);

                        }
                        break;
                    case topPanelType.clampForce:
                        {
                            imgClampforceFlag.Opacity = 1;
                            lbNameFore.Content = "锁模力[" + objUnit.unitBase[UnitType.Force_ton] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.MldPr[8];
                            objPerCur = valmoWin.dv.MldPr[8];
                            objPerBasic = valmoWin.dv.MldPr[9];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.motorTemp:
                        {
                            imgMotorTempFlag.Opacity = 1;
                            lbNameFore.Content = "合模马达温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            //curTempLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[173];
                            lnHandle = new intEvent(nullHandle);
                        }
                        break;
                    case topPanelType.ejectorSpeed:
                        {
                            imgEjectorFlag.Opacity = 1;
                            lbNameFore.Content = "顶针速度[" + objUnit.unitBase[UnitType.Spd_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.MldPr[144];
                            objPerCur = valmoWin.dv.MldPr[144];
                            objPerBasic = valmoWin.dv.MldPr[240];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.ejectorPos:
                        {
                            imgEjectorFlag.Opacity = 1;
                            lbNameFore.Content = "顶针位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.MldPr[2];
                            objPerCur = valmoWin.dv.MldPr[2];
                            objPerBasic = valmoWin.dv.MldPr[234];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.ejectorTorque:
                        {
                            imgTorqueFlag.Opacity = 1;
                            lbNameFore.Content = "顶针扭矩[" + objUnit.unitBase[UnitType.Torque] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.SysPr[100];
                            objPerCur = valmoWin.dv.SysPr[99];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);
                        }
                        break;
                    case topPanelType.ejectorMotorTemp:
                        {
                            lbPerValueFore.Visibility = Visibility.Hidden;
                            lbPerValueBg.Visibility = Visibility.Hidden;
                            imgMotorTempFlag.Opacity = 1;
                            lbNameFore.Content = "顶针马达温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            curTempLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[174];
                            objPerBasic = valmoWin.dv.PrdPr[174];
                            lnHandle = new intEvent(curTempLnCtrlHandle);
                        }
                        break;
                    case topPanelType.injSpeed:
                        {
                            imgInjectionFlag.Opacity = 1;
                            lbNameFore.Content = "注射速度[" + objUnit.unitBase[UnitType.Spd_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.InjPr[24];
                            objPerCur = valmoWin.dv.InjPr[24];
                            objPerBasic = valmoWin.dv.InjPr[199];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.injPress:
                        {
                            imgInjPressFlag.Opacity = 1;
                            lbNameFore.Content = "注射峰值压力[" + objUnit.unitBase[UnitType.Prs_Mpa] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[197];
                            objPerBasic = valmoWin.dv.PrdPr[90];
                            pressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.vpPos:
                        {
                            imgVPFlag.Opacity = 1;
                            lbNameFore.Content = "V/P切换位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[196];
                            objPerBasic = valmoWin.dv.PrdPr[48];
                            pressLnCtrl1.setBasicObj(valmoWin.dv.PrdPr[48]);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.vpPress:
                        {
                            imgVPFlag.Opacity = 1;
                            lbNameFore.Content = "V/P切换压力[" + objUnit.unitBase[UnitType.Prs_Mpa] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[195];
                            objPerBasic = valmoWin.dv.PrdPr[55];
                            pressLnCtrl1.setBasicObj(valmoWin.dv.PrdPr[55]);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.vpSpeed:
                        {
                            imgVPFlag.Opacity = 1;
                            lbNameFore.Content = "V/P切换速度[" + objUnit.unitBase[UnitType.Spd_mm] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.InjPr[27];
                            objPerBasic = valmoWin.dv.InjPr[27];
                            pressLnCtrl1.setBasicObj(valmoWin.dv.InjPr[27]);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.vpTime:
                        {
                            imgVPFlag.Opacity = 1;
                            lbNameFore.Content = "V/P切换时间[" + objUnit.unitBase[UnitType.Tm_s] + "]";
                            vpTmLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[194];
                            objPerBasic = valmoWin.dv.PrdPr[62];
                            vpTmLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(vpTmLnCtrlHandle);
                            
                        }
                        break;
                    case topPanelType.screwPos:
                        {
                            imgInjectionFlag.Opacity = 1;
                            lbNameFore.Content = "螺杆位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.InjPr[21];
                            objPerCur = valmoWin.dv.InjPr[21];
                            objPerBasic = valmoWin.dv.InjPr[190];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.posBeforeInjection:
                        {
                            imgRuleFlag.Opacity = 1;
                            lbNameFore.Content = "注射前位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[192];
                            objPerBasic = valmoWin.dv.PrdPr[69];
                            pressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.cushionPos:
                        {
                            imgRuleFlag.Opacity = 1;
                            lbNameFore.Content = "注射最前位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[193];
                            objPerBasic = valmoWin.dv.PrdPr[76];
                            pressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.injMotorTemp:
                        {
                            lbPerValueFore.Visibility = Visibility.Hidden;
                            lbPerValueBg.Visibility = Visibility.Hidden;
                            imgMotorTempFlag.Opacity = 1;
                            lbNameFore.Content = "注射马达温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            curTempLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[175];
                            objPerBasic = valmoWin.dv.PrdPr[175];
                            lnHandle = new intEvent(curTempLnCtrlHandle);
                        }
                        break;
                    case topPanelType.injTorque:
                        {
                            imgTorqueFlag.Opacity = 1;
                            lbNameFore.Content = "注射扭矩[" + objUnit.unitBase[UnitType.Torque] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.SysPr[96];
                            objPerBasic = valmoWin.dv.SysPr[95];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);
                        }
                        break;
                    case topPanelType.screwRpm:
                        {
                            imgScrewFlag.Opacity = 1;
                            lbNameFore.Content = "螺杆转速[" + objUnit.unitBase[UnitType.RSpeed] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.InjPr[32];
                            objPerCur = valmoWin.dv.InjPr[32];
                            objPerBasic = valmoWin.dv.InjPr[146];
                            lnHandle = new intEvent(lenLnCtrlHandle);
                        }
                        break;
                    case topPanelType.backPressure:
                        {
                            imgBackPresFlag.Opacity = 1;
                            lbNameFore.Content = "背压压力[" + objUnit.unitBase[UnitType.Prs_Mpa] + "]";
                            backPressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[190];
                            objPerBasic = valmoWin.dv.PrdPr[216];
                            backPressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(backPressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.cushionTime:
                        {
                            imgTmFlag.Opacity = 1;
                            lbNameFore.Content = "储料时间[" + objUnit.unitBase[UnitType.Tm_s] + "]";
                            objCur = valmoWin.dv.PrdPr[198];
                            objPerBasic = valmoWin.dv.PrdPr[34];
                            vpTmLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(vpTmLnCtrlHandle);
                        }
                        break;
                    case topPanelType.PosBeforeCushion:
                        {
                            imgRuleFlag.Opacity = 1;
                            lbNameFore.Content = "储料前位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[191];
                            objPerBasic = valmoWin.dv.PrdPr[83];
                            pressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.injectionUnitPos://??????
                        {
                            imgCarriageFlag.Opacity = 1;
                            objCur = valmoWin.dv.InjPr[413];
                            lbNameFore.Content = "射台位置[" + objUnit.unitBase[UnitType.Len_mm] + "]";
                        }
                        break;
                    case topPanelType.cushionTorque:
                        {
                            imgTorqueFlag.Opacity = 1;
                            lbNameFore.Content = "储料扭矩[" + objUnit.unitBase[UnitType.Torque] + "]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.SysPr[101];
                            objPerBasic = valmoWin.dv.SysPr[102];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);
                        }
                        break;
                    case topPanelType.cushionMotorTemp:
                        {
                            lbPerValueBg.Visibility = Visibility.Hidden;
                            lbPerValueFore.Visibility = Visibility.Hidden;
                            imgMotorTempFlag.Opacity = 1;
                            lbNameFore.Content = "储料马达温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            curTempLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[176];
                            objPerBasic = valmoWin.dv.PrdPr[176];
                            lnHandle = new intEvent(curTempLnCtrlHandle);
                        }
                        break;
                    case topPanelType.tempfirstSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第一段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[11];
                            objPerCur = valmoWin.dv.PrdPr[208];
                            objPerBasic = valmoWin.dv.TmpPr[10];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.tempSecondSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第二段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[19];
                            objPerCur = valmoWin.dv.PrdPr[209];
                            objPerBasic = valmoWin.dv.TmpPr[18];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.tempthirdSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第三段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[27];
                            objPerCur = valmoWin.dv.PrdPr[210];
                            objPerBasic = valmoWin.dv.TmpPr[26];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.tempFourthSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第四段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[35];
                            objPerCur = valmoWin.dv.PrdPr[211];
                            objPerBasic = valmoWin.dv.TmpPr[34];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.tempFifthSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第五段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[43];
                            objPerCur = valmoWin.dv.PrdPr[212];
                            objPerBasic = valmoWin.dv.TmpPr[42];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.tempSixthSec:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "第六段温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[51];
                            objPerCur = valmoWin.dv.PrdPr[213];
                            objPerBasic = valmoWin.dv.TmpPr[50];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.hopperTemp:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "落料口温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[214];
                            objPerCur = valmoWin.dv.PrdPr[214];
                            objPerBasic = valmoWin.dv.TmpPr[61];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);
                        }
                        break;
                    case topPanelType.oilPumpTemp:
                        {
                            imgBarrelHeatFlag.Opacity = 1;
                            lbNameFore.Content = "油泵温度[" + objUnit.unitBase[UnitType.Temp_C] + "]";
                            recLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.TmpPr[8];
                            objPerCur = valmoWin.dv.TmpPr[8];
                            objPerBasic = valmoWin.dv.TmpPr[9];
                            recLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(recLnCtrlHandle);
                            valmoWin.dv.PrdPr[109].addHandle(handleCycleEnd);

                        }
                        break;
                    case topPanelType.cycleTime:
                        {
                            imgTmFlag.Opacity = 1;
                            lbNameFore.Content = "周期时间[" + objUnit.unitBase[UnitType.Tm_s] + "]";
                            pressLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[171];
                            objPerBasic = valmoWin.dv.PrdPr[41];
                            pressLnCtrl1.setBasicObj(objPerBasic);
                            lnHandle = new intEvent(pressLnCtrlHandle);
                        }
                        break;
                    case topPanelType.totalShot:
                        {
                            lbPerValueFore.Visibility = Visibility.Hidden;
                            lbPerValueBg.Visibility = Visibility.Hidden;

                            imgShotNrFlag.Opacity = 1;
                            lbNameFore.Content = "总模数";
                            objCur = valmoWin.dv.PrdPr[22];
                            lnHandle = new intEvent(nullHandle);
                        }
                        break;
                    case topPanelType.markerShot:
                        {
                            lbPerValueFore.Visibility = Visibility.Hidden;
                            lbPerValueBg.Visibility = Visibility.Hidden;
                            imgMarkerFlag.Opacity = 1;
                            lbNameFore.Content = "标记模数";
                            objCur = valmoWin.dv.PrdPr[95];
                            lnHandle = new intEvent(nullHandle);
                        }
                        break;
                    case topPanelType.produceShot:
                        {
                            imgPShotnrFlag.Opacity = 1;
                            lbNameFore.Content = "生产模数";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[96];
                            objPerBasic = valmoWin.dv.PrdPr[4];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);

                        }
                        break;
                    case topPanelType.goodPart:
                        {
                            imgGoodPartFlag.Opacity = 1;
                            lbNameFore.Content = "成品数[PCS]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[1];
                            objPerCur = valmoWin.dv.PrdPr[1];
                            objPerBasic = valmoWin.dv.PrdPr[8];
                            lnHandle = new intEvent(lenLnCtrlHandle);

                        }
                        break;
                    case topPanelType.rejct:
                        {
                            imgBadPartFlag.Opacity = 1;
                            lbNameFore.Content = "不良品数[PCS]";
                            lenLnCtrl1.Visibility = Visibility.Visible;
                            objCur = valmoWin.dv.PrdPr[2];
                            objPerBasic = valmoWin.dv.PrdPr[5];
                            lnHandle = new intEvent(lenLnPerCtrlHandle);
                        }
                        break;
                    case topPanelType.eachOneEnergy://检查位置★★
                        {
                            imgEnergyFlag.Opacity = 1;
                            lbNameFore.Content = "周期能耗[kW]";
                            objCur = valmoWin.dv.PrdPr[748];
                            objPerBasic = valmoWin.dv.PrdPr[109];
                            lnHandle = new intEvent(nullHandle);
                        }
                        break;
                    case topPanelType.eachKgEnergy:
                        {
                            imgEnergyFlag.Opacity = 1;
                            objCur = valmoWin.dv.PrdPr[757];
                            lbNameFore.Content = "1kg能耗[" + objCur.unit + "]";
                        }
                        break;
                    case topPanelType.eachHourEnergy:
                        {
                            imgEnergyFlag.Opacity = 1;
                            objCur = valmoWin.dv.PrdPr[752];
                            lbNameFore.Content = "每小时能耗["+ objCur.unit + "]";
                        }
                        break;
                    case topPanelType.allEnergy:
                        {
                            imgEnergyFlag.Opacity = 1;
                            objCur = valmoWin.dv.PrdPr[756];
                            lbNameFore.Content = "整机能耗[" + objCur.unit + "]";
                        }
                        break;
                    case topPanelType.robotTime:
                        {
                            imgRobotFlag.Opacity = 1;
                            lbNameFore.Content = "机械手周期[s]";
                        }
                        break;
                    case topPanelType.robotFreePer:
                        {
                            imgRobotFlag.Opacity = 1;
                            lbNameFore.Content = "机械手空闲率[%]";
                        }
                        break;
                    case topPanelType.takeouttime:
                        {
                            imgRobotFlag.Opacity = 1;
                            lbNameFore.Content = "取出时间[s]";
                        }
                        break;
                    case topPanelType.tunerState:
                        {
                            imgTunerFlag.Opacity = 1;
                            tunerStateCtrl1.Visibility = Visibility.Visible;
                            lbNameFore.Content = "转盘位置[°]";
                            objCur = valmoWin.dv.MldPr[585];
                            objCur.addHandle(handleRefreshTunerValue);
                            valmoWin.dv.MldPr[594].addHandle(handleRefreshLight);
                        }
                        break;

                }
                init();
            }
        }
        public void refreshWinName()
        {
            try
            {
                switch (ctrlType)
                {
                    case topPanelType.moldSpeed:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey174") + "[" + objCur.unit + "]"; //模板速度
                        }
                        break;
                    case topPanelType.moldPos:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey127") + "[" + objCur.unit + "]"; //模板位置
                        }
                        break;
                    case topPanelType.closeMoldTonnage:
                        {

                        }
                        break;
                    case topPanelType.clampTorque:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey727") + "[" + objCur.unit + "]";//移模扭矩
                        }
                        break;
                    case topPanelType.clampForce:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("mld_tableSwitch_ClampForce") + "[" + objCur.unit + "]";//锁模力
                        }
                        break;
                    case topPanelType.motorTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey728") + "[" + objCur.unit + "]";//合模马达温度
                        }
                        break;
                    case topPanelType.ejectorSpeed:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey219") + "[" + objCur.unit + "]";//顶针速度
                        }
                        break;
                    case topPanelType.ejectorPos:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey128") + "[" + objCur.unit + "]";//顶针位置
                        }
                        break;
                    case topPanelType.ejectorTorque:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey729") + "[" + objCur.unit + "]";//顶针扭矩
                        }
                        break;
                    case topPanelType.ejectorMotorTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey730") + "[" + objCur.unit + "]";//顶针马达温度
                        }
                        break;
                    case topPanelType.injSpeed:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey286") + "[" + objCur.unit + "]";//注射速度
                        }
                        break;
                    case topPanelType.injPress:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey431") + "[" + objCur.unit + "]";//注射峰值压力
                        }
                        break;
                    case topPanelType.vpPos:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey425") + "[" + objCur.unit + "]";// V/P切换位置
                        }
                        break;
                    case topPanelType.vpPress:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey426") + "[" + objCur.unit + "]";//V/P切换压力
                        }
                        break;
                    case topPanelType.vpSpeed:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey731") + "[" + objCur.unit + "]";//V/P切换速度
                        }
                        break;
                    case topPanelType.vpTime:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey427") + "[" + objCur.unit + "]";//V/P切换时间
                        }
                        break;
                    case topPanelType.screwPos:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey129") + "[" + objCur.unit + "]";//螺杆位置
                        }
                        break;
                    case topPanelType.posBeforeInjection:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey732") + "[" + objCur.unit + "]";//注射前位置
                        }
                        break;
                    case topPanelType.cushionPos:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey733") + "[" + objCur.unit + "]";//注射最前位置
                        }
                        break;
                    case topPanelType.injMotorTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey734") + "[" + objCur.unit + "]";//注射马达温度
                        }
                        break;
                    case topPanelType.injTorque:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey735") + "[" + objCur.unit + "]";//注射扭矩
                        }
                        break;
                    case topPanelType.screwRpm:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey130") + "[" + objCur.unit + "]";//螺杆转速
                        }
                        break;
                    case topPanelType.backPressure:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey736") + "[" + objCur.unit + "]";//背压压力
                        }
                        break;
                    case topPanelType.cushionTime:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey292") + "[" + objCur.unit + "]";//储料时间
                        }
                        break;
                    case topPanelType.PosBeforeCushion:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey430") + "[" + objCur.unit + "]";//储料前位置
                        }
                        break;
                    case topPanelType.injectionUnitPos://??????
                        {
                            imgCarriageFlag.Opacity = 1;
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey737") + "[" + objCur.unit + "]";//射台位置
                        }
                        break;
                    case topPanelType.cushionTorque:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey738") + "[" + objCur.unit + "]";//储料扭矩
                        }
                        break;
                    case topPanelType.cushionMotorTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey739") + "[" + objCur.unit + "]";//储料马达温度
                        }
                        break;
                    case topPanelType.tempfirstSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT201") + "[" + objCur.unit + "]";//第一段温度
                        }
                        break;
                    case topPanelType.tempSecondSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT202") + "[" + objCur.unit + "]";//第二段温度
                        }
                        break;
                    case topPanelType.tempthirdSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT203") + "[" + objCur.unit + "]";//第三段温度
                        }
                        break;
                    case topPanelType.tempFourthSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT204") + "[" + objCur.unit + "]";//第四段温度
                        }
                        break;
                    case topPanelType.tempFifthSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT205") + "[" + objCur.unit + "]";//第五段温度
                        }
                        break;
                    case topPanelType.tempSixthSec:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("IOT206") + "[" + objCur.unit + "]";//第六段温度
                        }
                        break;
                    case topPanelType.hopperTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey740") + "[" + objCur.unit + "]";//落料口温度
                        }
                        break;
                    case topPanelType.oilPumpTemp:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey741") + "[" + objCur.unit + "]";//油泵温度
                        }
                        break;
                    case topPanelType.cycleTime:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey742") + "[" + objCur.unit + "]";//周期时间
                        }
                        break;
                    case topPanelType.totalShot:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey743");// "总模数";
                        }
                        break;
                    case topPanelType.markerShot:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("Prd095");// "标记模数";
                        }
                        break;
                    case topPanelType.produceShot:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey744");//"生产模数";
                        }
                        break;
                    case topPanelType.goodPart:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey745");//"成品数[PCS]";
                        }
                        break;
                    case topPanelType.rejct:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey746");//"不良品数[PCS]";
                        }
                        break;
                    case topPanelType.eachOneEnergy:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey747") + "[" + objCur.unit + "]";//"单个能耗[kW]";
                        }
                        break;
                    case topPanelType.eachKgEnergy:
                        {
                            imgEnergyFlag.Opacity = 1;
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey748") + "[" + objCur.unit + "]";//"1kg能耗[kW]";
                        }
                        break;
                    case topPanelType.eachHourEnergy:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey749") + "[" + objCur.unit + "]";//"每小时能耗[kWh]";
                        }
                        break;
                    case topPanelType.allEnergy:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey750") + "[" + objCur.unit + "]";//"整机能耗[kW]";
                        }
                        break;
                    case topPanelType.robotTime:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey751") + "[s]";//"[" + objCur.unit + "]";// "机械手周期[s]";
                        }
                        break;
                    case topPanelType.robotFreePer:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey752") + "[%]";// "[" + objCur.unit + "]";// "机械手空闲率[%]";
                        }
                        break;
                    case topPanelType.takeouttime:
                        {
                            lbNameFore.Content = valmoWin.dv.getCurDis("lanKey753") + "[s]";//"[" + objCur.unit + "]";// "取出时间[s]";
                        }
                        break;
                    case topPanelType.tunerState:
                        {
                            lbNameFore.Content = "转盘位置" + "[s]";//"[" + objCur.unit + "]";// "取出时间[s]";
                        }
                        break;
                }
                if (objCur != null)
                    setCurValueFore(objCur.vDblStr);
            }
            catch
            {

            }
        }
        public bool flagShow
        {
            get
            {
                if (lbNameBg.Foreground == Brushes.White)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value)
                {
                    lbNameBg.Foreground = Brushes.White;
                    lbNameFore.Foreground = new SolidColorBrush(Color.FromArgb(255, 68, 68, 68));
                    lbPerValueBg.Foreground = Brushes.White;
                    lbPerValueFore.Foreground = new SolidColorBrush(Color.FromArgb(255, 68, 68, 68));
                }
                else
                {
                    lbNameBg.Foreground = Brushes.Transparent;
                    lbNameFore.Foreground = Brushes.White;
                    lbPerValueBg.Foreground = Brushes.Transparent;
                    lbPerValueFore.Foreground = Brushes.White;
                }
            }
        }
        private void lenLnCtrlHandle(int value)
        {
            try
            {
                if (objCur != null)
                {
                    setCurValueFore(objCur.vDblStr);
                    if (objPerBasic != null && objPerCur != null)
                    {
                        if (objPerBasic.value != 0)
                        {
                            double perValue = 100.0 * objPerCur.value / objPerBasic.value;
                            lbPerValueFore.Content = Math.Abs(perValue).ToString("0.0") + "%";
                            lenLnCtrl1.setValue(Math.Abs(perValue));
                        }
                    }
                    else
                    {
                        vm.perror("error : " + ctrlType);
                    }
                }
            }
            catch (Exception ex)
            {
                vm.perror(ex.Message);
            }
        }
        private void lenLnPerCtrlHandle(int value)
        {
            try
            {
                if (objCur != null)
                {
                    setCurValueFore(objCur.vDblStr);
                    if (objPerCur != null)
                    {
                        double perValue = objPerCur.value;
                        lbPerValueFore.Content = Math.Abs(perValue).ToString("0.0") + "%";
                        lenLnCtrl1.setValue(Math.Abs(perValue));
                    }
                }
            }
            catch (Exception ex)
            {
                vm.perror(ex.Message);
            }
        }
        private void curTempLnCtrlHandle(int value)
        {
            try
            {
                double curValue = objPerBasic.getDblValue(value);
                setCurValueFore(objPerBasic.getStrValue(value));
                if (curValue < 0)
                    curValue = 0;
                else if (curValue > 100)
                    curValue = 100;
                curTempLnCtrl1.setValue(curValue);
            }
            catch (Exception ex)
            {
                vm.perror(ex.Message);
            }

        }
        private void recLnCtrlHandle(int value)
        {
            try
            {
                if(objCur != null)
                    setCurValueFore(objCur.vDblStr);
                if (objPerBasic != null && objPerCur != null)
                {
                    if (objPerBasic.value != 0)
                        lbPerValueFore.Content = (100.0 * objPerCur.value / objPerBasic.value).ToString("0.0") + "%";
                }
                //recLnCtrl1.addValue(value);
            }
            catch (Exception ex)
            {
                vm.perror(ex.Message);
            }
        }
        private void handleCycleEnd(objUnit obj)
        {
            if (objPerCur != null)
                recLnCtrl1.addValue(objPerCur.value);
        }
        private void pressLnCtrlHandle(int value)
        {
            try
            {
                if(objCur != null)
                    setCurValueFore(objCur.vDblStr);
                if (objPerBasic != null )
                {
                    if(objPerBasic.value != 0)
                        lbPerValueFore.Content = (100.0 * objCur.value / objPerBasic.value).ToString("0.0") + "%";
                    pressLnCtrl1.addValue(value);
                }
            }
            catch(Exception ex)
            {
                vm.perror(ex.Message);
            }
        }
        private void vpTmLnCtrlHandle(int value)
        {
            try
            {
                if (objCur != null)
                {
                    setCurValueFore(objCur.vDblStr);
                    if (objPerBasic != null && objPerCur != null)
                    {   if(objPerBasic.value != 0)
                        lbPerValueFore.Content = (100.0 * objPerCur.value / objPerBasic.value).ToString("0.0") + "%";
                        vpTmLnCtrl1.addValue(value);
                    }
                }
            }
            catch (Exception ex)
            {
                vm.perror(ex.ToString());
            }
        }
        private void backPressLnCtrlHandle(int value)
        {
            try
            {
                if(objCur != null)
                    setCurValueFore(objCur.vDblStr);
                if (objPerBasic != null && objPerCur != null)
                {
                    if(objPerBasic.value != 0)
                        lbPerValueFore.Content = (100.0 * objPerCur.value / objPerBasic.value).ToString("0.0") + "%";
                    backPressLnCtrl1.addValue(value);
                }
            }
            catch (Exception ex)
            {
                vm.perror(ex.ToString());
            }
        }
        private void nullHandle(int value)
        {
            if(objCur != null)
                setCurValueFore(objCur.vDblStr);
        }
        void handleRefreshLight(objUnit obj)
        {
            tunerStateCtrl1.state = obj.value;

        }
        void handleRefreshTunerValue(objUnit obj)
        {
            setCurValueFore(obj.vDblStr);
        }
        public void setCurValueFore(string str)
        {
            if (str.Length <= 6)
                lbValueFore.FontSize = 36;
            else if(str.Length <= 8)
                lbValueFore.FontSize = 30;
            else if (str.Length <= 10)
                lbValueFore.FontSize = 24;
            else if (str.Length <= 12)
                lbValueFore.FontSize = 20;
            lbValueFore.Content = str;
            //lbValueBg.FontSize = lbValueFore.FontSize;
            //lbValueBg.Content = str;
        }
    }
}
