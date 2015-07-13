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
using nsDataMgr;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace nsVicoClient.ctrls
{
    public partial class keysPanel : UserControl
    {
        /// <summary>
        /// 视频源
        /// </summary>
        private VideoSource Video;
        public static nullEvent refreshCtrlsHandle;

        public keysPanel()
        {
            InitializeComponent();

            init();

            refreshCtrlsHandle += init;

            //Video = VideoSource.getInstance();
            //Video.NewFarmeEnvent = captureAForge_NewFrame;
        }

        private void init()
        {
            cvsCnt.Children.Clear();
            StringCollection strLst = Properties.Settings.Default.ctrlLst;

            if (strLst != null)
            {
                int i = 0;
                foreach (string str in strLst)
                {
                    cntBtn cnt = new cntBtn();
                    cnt.Type = (ctnBtnType)Convert.ToInt32(str);
                    cvsCnt.Children.Add(cnt);
                    Canvas.SetLeft(cnt, 25 + i % 7 * 148);
                    Canvas.SetTop(cnt, 8 + i / 7 * 113);
                    i++;
                }
            }
        }

        /// <summary>
        /// 将控件设置为合适大小
        /// </summary>
        private void setCtrlMiddle()
        {
            cvsMain.Height = 593;
            cvsCnt.Height = 345;
            cvsMenuBtn.Height = 65;
            lmenu.Opacity = 1;

            imgDown.Opacity = 1;
            imgUp.Opacity = 0;

            valmoWin.MainPanelHeight = 1100;
            productMessageList.refushH();
        }

        /// <summary>
        /// 将控件设置为最小
        /// </summary>
        private void setCtrlMin()
        {
            cvsMain.Height = 185;
            cvsCnt.Height = 0;
            cvsMenuBtn.Height = 0;
            lmenu.Opacity = 0;
            imgDown.Opacity = 0;
            imgUp.Opacity = 1;

            valmoWin.MainPanelHeight = 1510;

            productMessageList.refushH();
        }

        private bool bIsFold = false;
        private void btnFold_MouseUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            if (bIsFold == false)
            {
                bIsFold = true;

                setCtrlMin();

                imgDown.Visibility = Visibility.Hidden;
                imgUp.Visibility = Visibility.Visible;
            }
            else
            {
                bIsFold = false;

                setCtrlMiddle();

                imgDown.Visibility = Visibility.Visible;
                imgUp.Visibility = Visibility.Hidden;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (cvsVideo.Visibility == Visibility.Hidden)
            {
                Video.Start();
                cvsVideo.Visibility = Visibility.Visible;
            }
            else
            {
                Video.Stop();
                cvsVideo.Visibility = Visibility.Hidden;
            }
        }

        void captureAForge_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            vBox.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
            vBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private bool bIsMouseDown = false;
        private System.Windows.Point pLastMousePos;

        private void cvsVideoHead_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            bIsMouseDown = true;
            pLastMousePos = e.GetPosition(cvsMain);
        }

        private void cvsVideoHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (bIsMouseDown == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    System.Windows.Point pCurMousePos = e.GetPosition(cvsMain);

                    double top = Canvas.GetTop(cvsVideo);
                    double topNew = top + pCurMousePos.Y - pLastMousePos.Y;
                    Canvas.SetTop(cvsVideo, topNew);

                    double left = Canvas.GetLeft(cvsVideo);
                    double leftNew = left + pCurMousePos.X - pLastMousePos.X;
                    Canvas.SetLeft(cvsVideo, leftNew);

                    pLastMousePos = pCurMousePos;
                }
            }
        }

        private void cvsVideoHead_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bIsMouseDown = false;
        }

        private void cvsVideoHead_MouseLeave(object sender, MouseEventArgs e)
        {
            bIsMouseDown = false;
        }

        private void btnClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            btnClose.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0x1C, 0x08, 0x7f));
        }

        private void btnClose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            btnClose.Background = new SolidColorBrush(Colors.Transparent);

            cvsVideo.Visibility = Visibility.Hidden;
            Video.Stop();
        }

        private void btnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            btnClose.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}
