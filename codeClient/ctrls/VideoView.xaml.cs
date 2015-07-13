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
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace nsVicoClient.ctrls
{
    /// <summary>
    /// VideoView.xaml 的交互逻辑
    /// </summary>
    public partial class VideoView : UserControl
    {
        public VideoView()
        {
            InitializeComponent();

            VideoSource.getInstance().NewFarmeEnvent = captureAForge_NewFrame;
            VideoSource.getInstance().Start();
        }

        void captureAForge_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //vBox.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
            //vBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
        }

        private void btnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            btnClose.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}
