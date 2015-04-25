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

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// Interaction logic for progShowWinPart.xaml
    /// </summary>
    public partial class progShowWinPart : UserControl
    {
        public delegate void quitEvent();
        topPanelCtrl.setTopPanelHandle setTopWinPanel;
        Label[] lbUsed = new Label[8];
        //topPanelType type;
        int curNum;
        quitEvent quitHandle;
        public progShowWinPart()
        {
            InitializeComponent();
        }
        public progShowWinPart(quitEvent quitHandle)
        {
            InitializeComponent();
            this.quitHandle = quitHandle;
        }
        public void init(topPanelType type,int num)
        {
            switch (type)
            {
                case topPanelType.clampTorque:

                    break;
                case topPanelType.ejectorPos:

                    break;
                case topPanelType.ejectorSpeed:

                    break;
                case topPanelType.ejectorTorque:

                    break;
                case topPanelType.moldPos:
                    //lbMoldPos.Background = new SolidColorBrush(Color.FromArgb(200, 200, 200, 200));
                    //lbMoldPos.IsEnabled = false;
                    break;
                case topPanelType.moldSpeed:

                    break;
                case topPanelType.PosBeforeCushion:

                    break;
                case topPanelType.posBeforeInjection:

                    break;
                case topPanelType.rejct:

                    break;
                case topPanelType.screwPos:

                    break;
                case topPanelType.screwRpm:

                    break;
                case topPanelType.takeouttime:

                    break;
                case topPanelType.goodPart:

                    break;
                case topPanelType.tempFifthSec:

                    break;
                case topPanelType.tempfirstSec:

                    break;
                case topPanelType.tempFourthSec:

                    break;
                case topPanelType.tempSecondSec:

                    break;
                case topPanelType.tempSixthSec:

                    break;
                case topPanelType.tempthirdSec:

                    break;
                case topPanelType.totalShot:
                    type = topPanelType.totalShot;
                    break;
                case topPanelType.vpPos:

                    break;
                case topPanelType.vpPress:

                    break;
                case topPanelType.vpSpeed:

                    break;
                case topPanelType.vpTime:

                    break;
            }
            curNum = num;
        }
        public void init(topPanelType[] type, int num)
        {
            for (int i = 0; i < 8; i++)
            {
                if (lbUsed[i] != null)
                {
                    lbUsed[i].IsEnabled = true;
                    lbUsed[i].Background = Brushes.Transparent;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                setUsedPanel(i, type[i]);
            }
            curNum = num;
        }
        public void init(int num, topPanelType type0, topPanelType type1, topPanelType type2, topPanelType type3, topPanelType type4, topPanelType type5, topPanelType type6, topPanelType type7)
        {
            foreach(Label lb in lbUsed)
            {
                if (lb != null)
                {
                    lb.IsEnabled = true;
                    lb.Background = Brushes.Transparent;
                }
            }
            setUsedPanel(0, type0);
            setUsedPanel(1, type1);
            setUsedPanel(2, type2);
            setUsedPanel(3, type3);
            setUsedPanel(4, type4);
            setUsedPanel(5, type5);
            setUsedPanel(6, type6);
            setUsedPanel(7, type7);
            curNum = num;
        }
        private void setUsedPanel(int no,topPanelType type)
        {
            switch (type)
            {
                case topPanelType.clampForce:
                    lbUsed[no] = lbClampForce;
                    break;
                case topPanelType.clampTorque:
                    lbUsed[no] = lbClampTorque;
                    break;
                case topPanelType.ejectorPos:
                    lbUsed[no] = lbEjectorPos;
                    break;
                case topPanelType.ejectorSpeed:
                    lbUsed[no] = lbEjectorSpeed;
                    break;
                case topPanelType.ejectorTorque:
                    lbUsed[no] = lbEjectorTorque;
                    break;
                case topPanelType.moldPos:
                    lbUsed[no] = lbMoldPos;
                    break;
                case topPanelType.moldSpeed:
                    lbUsed[no] = lbMoldSpeed;
                    break;
                case topPanelType.PosBeforeCushion:
                    lbUsed[no] = lbPosBeforeCushion1;
                    break;
                case topPanelType.posBeforeInjection:
                    lbUsed[no] = lbPosBeforeInjection;
                    break;
                case topPanelType.rejct:
                    lbUsed[no] = lbRejectNum;
                    break;
                case topPanelType.screwPos:
                    lbUsed[no] = lbScrewPos;
                    break;
                case topPanelType.screwRpm:
                    lbUsed[no] = lbScrewRpm;
                    break;
                case topPanelType.takeouttime:
                    lbUsed[no] = lbTakeOutTime;
                    break;
                case topPanelType.goodPart:
                    lbUsed[no] = lbTemperat;
                    break;
                case topPanelType.tempFifthSec:
                    lbUsed[no] = lbFifthSec; 
                    break;
                case topPanelType.tempfirstSec:
                    lbUsed[no] = lbTempFirstSec;
                    break;
                case topPanelType.tempFourthSec:
                    lbUsed[no] = lbFourthSec;
                    break;
                case topPanelType.tempSecondSec:
                    lbUsed[no] = lbTempSecondSec;
                    break;
                case topPanelType.tempSixthSec:
                    lbUsed[no] = lbSixthSec;
                    break;
                case topPanelType.tempthirdSec:
                    lbUsed[no] = lbthirdSec;
                    break;
                case topPanelType.totalShot:
                    lbUsed[no] = lbTotalShot;
                    break;
                case topPanelType.vpPos:
                    lbUsed[no] = lbVPPos;
                    break;
                case topPanelType.vpPress:
                    lbUsed[no] = lbVPPressure;
                    break;
                case topPanelType.vpSpeed:
                    lbUsed[no] = lbVPSpeed;
                    break;
                case topPanelType.vpTime:
                    lbUsed[no] = lbVPTime;
                    break;
                //case topPanelType.closeMoldTonnage:
                //    lbUsed[no] = lbCloseMoldTonnage;
                //    break;
                case topPanelType.motorTemp:
                    lbUsed[no] = lbMotorTemp;
                    break;
                case topPanelType.ejectorMotorTemp:
                    lbUsed[no] = lbEjectorMotorTemp;
                    break;
                case topPanelType.injSpeed:
                    lbUsed[no] = lbInjSpeed;
                    break;
                case topPanelType.injPress:
                    lbUsed[no] = lbInjPress;
                    break;
                case topPanelType.cushionPos:
                    lbUsed[no] = lbcushionPos;
                    break;
                case topPanelType.injMotorTemp:
                    lbUsed[no] = lbInjMotorTemp;
                    break;
                case topPanelType.injTorque:
                    lbUsed[no] = lbInjTorque;
                    break;
                case topPanelType.backPressure:
                    lbUsed[no] = lbBackPress;
                    break;
                case topPanelType.cushionTime:
                    lbUsed[no] = lbCushionTime;
                    break;
                case topPanelType.cushionMotorTemp:
                    lbUsed[no] = lbcushionMotorTemp;
                    break;
               case topPanelType.injectionUnitPos:
                    lbUsed[no] = lbInjectionUnitPos;
                    break;
               case topPanelType.cushionTorque:
                    lbUsed[no] = lbcushionTorque;
                    break;
              case topPanelType.hopperTemp:
                    lbUsed[no] = lbhopperTemp;
                    break;
              case topPanelType.oilPumpTemp:
                    lbUsed[no] = lbOilPumpTemp;
                    break;
              case topPanelType.cycleTime:
                    lbUsed[no] = lbCycleTime;
                    break;
              case topPanelType.produceShot:
                    lbUsed[no] = lbProduceShot;
                    break;
              case topPanelType.markerShot:
                    lbUsed[no] = lbMarkerShot;
                    break;
              case topPanelType.allEnergy:
                    lbUsed[no] = lbAllEnergy;
                    break;
              case topPanelType.eachOneEnergy:
                    lbUsed[no] = lbEachOneEnergy;
                    break;
              case topPanelType.eachKgEnergy:
                    lbUsed[no] = lbEachKgEnergy;
                    break;
              case topPanelType.eachHourEnergy:
                    lbUsed[no] = lbEachHourEnergy;
                    break;
              case topPanelType.robotTime:
                    lbUsed[no] = lbRobotTime;
                    break;
              case topPanelType.robotFreePer:
                    lbUsed[no] = lbRobotFreePer;
                    break;
              case topPanelType.tunerState:
                    lbUsed[no] = lbRobotFreePer;
                    break;


            }
            if (lbUsed[no] != null)
            {
                lbUsed[no].IsEnabled = false;
                lbUsed[no].Background = new SolidColorBrush(Color.FromArgb(125, 0, 0, 0));
            }
        }
        public void setCallBack(topPanelCtrl.setTopPanelHandle callBack)
        {
            setTopWinPanel = callBack;
        }

        private void lbMoldSpeed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.moldSpeed, curNum);
        }

        private void lbTotalShot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.totalShot, curNum);

        }

        private void lbMoldPos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.moldPos, curNum);
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.clampTorque, curNum);
        }

        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e) //移模马达温度
        {
            setTopWinPanel(topPanelType.motorTemp, curNum);
        }

        private void lbEjectorSpeed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.ejectorSpeed, curNum);
        }

        private void lbEjectorPos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.ejectorPos, curNum);
        }

        private void Label_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.ejectorTorque, curNum);
        }

        private void Label_MouseDown_4(object sender, MouseButtonEventArgs e) //顶针马达温度
        {
            setTopWinPanel(topPanelType.ejectorMotorTemp, curNum);
        }

        private void lbInjSpeed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.injSpeed, curNum);
        }

        private void lbInjPress_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.injPress, curNum);
        }

        private void Label_MouseDown_5(object sender, MouseButtonEventArgs e)  // V/P切换压力
        {
            setTopWinPanel(topPanelType.vpPress, curNum);
        }

        private void Label_MouseDown_6(object sender, MouseButtonEventArgs e)  // V/P切换速度
        {
            setTopWinPanel(topPanelType.vpSpeed, curNum);
        }

        private void Label_MouseDown_7(object sender, MouseButtonEventArgs e) //V/P切换位置
        {
            setTopWinPanel(topPanelType.vpPos, curNum);
        }

        //private void Label_MouseDown_12(object sender, MouseButtonEventArgs e) //螺杆位置
        //{
        //    setTopWinPanel(topPanelType.screwPos, curNum);
        //}

        private void lbVPTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.vpTime, curNum);
        }

        private void lbTemperat_MouseDown(object sender, MouseButtonEventArgs e) //产品数
        {
            setTopWinPanel(topPanelType.goodPart, curNum);
        }

        private void lbFifthSec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.tempFifthSec, curNum);
        }

        private void lbVPSpeed_MouseDown(object sender, MouseButtonEventArgs e)  // V/P切换速度
        {
            setTopWinPanel(topPanelType.vpSpeed, curNum);
        }

        private void lbMotorTemp_MouseDown(object sender, MouseButtonEventArgs e) //移模马达温度
        {
            setTopWinPanel(topPanelType.motorTemp, curNum);
        }

        private void lbFourthSec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.tempFourthSec, curNum);
        }

        private void lbPosBeforeCushion_MouseDown(object sender, MouseButtonEventArgs e) //储料前位置
        {
            setTopWinPanel(topPanelType.PosBeforeCushion, curNum);
        }

        private void lbVPPressure_MouseDown(object sender, MouseButtonEventArgs e)  // V/P切换压力
        {
            setTopWinPanel(topPanelType.vpPress, curNum);
        }

        private void lbEjectorMotorTemp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.ejectorMotorTemp, curNum);
        }

        private void lbTakeOutTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.takeouttime, curNum);
        }

        private void lbthirdSec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.tempthirdSec, curNum);
        }

       private void lbCushionTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setTopWinPanel(topPanelType.cushionTime, curNum);
        }

       private void lbBackPress_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.backPressure, curNum);
       }

       private void lbTempSecondSec_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.tempSecondSec, curNum);
       }

       private void lbCloseMoldTonnage_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.clampForce, curNum);
       }

       private void lbScrewRpm_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.screwRpm, curNum);
       }

       private void lbTempFirstSec_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.tempfirstSec, curNum);
       }

       private void lbCycleTime_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.cycleTime, curNum);
       }

       private void lbRobotTime_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.robotTime, curNum);
       }

       private void lbEjectorTorque_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.ejectorTorque, curNum);
       }

       private void lbVPPos_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.vpPos, curNum);
       }

       private void lbClampTorque_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.clampTorque, curNum);
       }

       private void lbcushionTorque_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.cushionTorque, curNum);
       }

       private void lbSixthSec_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.tempSixthSec, curNum);
       }

       private void lbRejectNum_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.rejct, curNum);
       }

       private void lbScrewPos_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.screwPos, curNum);
       }

       private void lbcushionMotorTemp_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.cushionMotorTemp, curNum);
       }

       private void lbEachOneEnergy_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.eachOneEnergy, curNum);
       }

       private void lbPosBeforeInjection_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.posBeforeInjection, curNum);
       }

       private void lbEachKgEnergy_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.eachKgEnergy, curNum);
       }

       private void lbcushionPos_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.cushionPos, curNum);
       }

       private void lbEachHourEnergy_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.eachHourEnergy, curNum);
       }

       private void lbInjMotorTemp_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.injMotorTemp, curNum);
       }

       private void lbAllEnergy_MouseDown(object sender, MouseButtonEventArgs e)
       {
            setTopWinPanel(topPanelType.allEnergy, curNum);
       }

       private void lbInjTorque_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.injTorque, curNum);
       }

       private void lbRobotFreePer_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.robotFreePer, curNum);
       }

       private void lbMarkerShot_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.markerShot, curNum);
       }

       private void lbProduceShot_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.produceShot, curNum);
       }

       private void lbInjectionUnitPos_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.injectionUnitPos, curNum);
       }

       private void lbhopperTemp_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.hopperTemp, curNum);
       }

       private void oilPumpTemp_MouseDown(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.oilPumpTemp, curNum);
       }

       private void lbInjTorque_MouseDown_1(object sender, MouseButtonEventArgs e)
       {
           setTopWinPanel(topPanelType.injTorque, curNum);
       }

       private void lbBack_MouseDown(object sender, MouseButtonEventArgs e)
       {
           if (this.quitHandle != null)
               quitHandle();
       }
    }
}
