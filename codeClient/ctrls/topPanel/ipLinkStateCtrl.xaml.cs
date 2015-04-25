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
using nsDataMgr;
using System.Net.NetworkInformation;  
using System.Threading;
//using interfaceMgr;
namespace nsVicoClient.ctrls
{
    /// <summary>
    /// ipLinkStateCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class ipLinkStateCtrl : UserControl
    {
        DispatcherTimer dtLink = new DispatcherTimer();
        DispatcherTimer dtCheck = new DispatcherTimer();
        Thread tdCheck;
        Ping p = new Ping();
        PingReply pr;
        IPStatus linkState = IPStatus.Success;
        public ipLinkStateCtrl()
        {
            InitializeComponent();
            this.Visibility = Visibility.Hidden;
            dtLink.Tick += new EventHandler(dtLink_Tick);
            dtLink.Interval = new TimeSpan(0, 0, 0, 0, 100);

            dtCheck.Tick += new EventHandler(dtCheck_Tick);
            dtCheck.Interval = new TimeSpan(0, 0, 0, 2, 200);

            tdCheck = new Thread(new ThreadStart(dtCheck_invoke));
            
        }
        public void startCheck()
        {
            //tdCheck.Start();
        }
        void dtCheck_Tick(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(new nullEvent(dtCheck_invoke));
            //endValue = 100;
            //dtCheck.Stop();
        }
        int testNum = 0;
        void dtCheck_invoke()
        {
            while (true)
            {
                //pr = p.Send("www.baidu.com");//百度的IP  
                pr = p.Send("10.10.150.3");//百度的IP  
                if (pr.Status != linkState)
                {
                    if (pr.Status != IPStatus.Success)//如果连接不成功 
                    {
                        //MessageBox.Show("未联网");
                        vm.debug("未联网");
                        valmoWin.execHandle(opeOrderType.ipLinkBreak);
                    }
                    else
                    {
                        //MessageBox.Show("已联网");
                        vm.debug("已联网");
                        valmoWin.execHandle(opeOrderType.ipLinkOk);
                    }
                    linkState = pr.Status;
                }
                //Thread.Sleep(new TimeSpan(0, 0, 1));
                //vm.debug(testNum.ToString());
                testNum++;
            }
        }
        double curPerValue = 0;
        int endValue = 90;
        void dtLink_Tick(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(new nullEvent(dtLink_invoke));
        }
        void dtLink_invoke()
        {
            curPerValue += 0.5;
            if(curPerValue < endValue)
                prsState.Value = curPerValue;
            if (curPerValue > 100)
                dtLink.Stop();
        }
        public void show()
        {
            curPerValue = 0;
            endValue = 90;
            //dtCheck.Start();
            //dtLink.Start();
        }

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            dtCheck.Stop();
            dtLink.Stop();
        }

    }
}
