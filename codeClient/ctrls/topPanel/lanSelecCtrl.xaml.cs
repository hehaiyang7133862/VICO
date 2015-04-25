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
    /// Interaction logic for lanSelecCtrl.xaml
    /// </summary>
    public partial class lanSelecCtrl : UserControl
    {
        public lanSelecCtrl()
        {
            InitializeComponent();
            this.Visibility = Visibility.Hidden;
        }
        public void show()
        {
            this.Visibility = Visibility.Visible;
        }
        private void imgCN_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Common.lan = lanType.lanCN;
            
            //valmoWin.setCtrlsLanHandle(lanType.lanCN);
            valmoWin.execHandle(opeOrderType.lanChange);
            this.Visibility = Visibility.Hidden;
        }

        private void imgEN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Common.lan = lanType.lanEN;
            valmoWin.execHandle(opeOrderType.lanChange);
            this.Visibility = Visibility.Hidden;
        }
        public void setWidth(double width)
        {
            lbBackPanel.Width = width;
            cvsMain.Width = width;
        }
        public void setHeight(double height)
        {
            lbBackPanel.Height = height;
            cvsMain.Height = height;
        }
        public void setPos(double left, double top)
        {
            Canvas.SetLeft(cvsPanel, left);
            Canvas.SetTop(cvsPanel, top);
        }
        bool isMouseDown = false;
        Point mousePoint;
        private void cvsSetPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //isMouseDown = true;
            //mousePoint = e.GetPosition(cvsMain);
            //vm.printLn(Canvas.GetLeft(cvsPanel) + "," + Canvas.GetTop(cvsPanel));
        }

        private void cvsMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point theMousePoint = e.GetPosition(this.cvsMain);
                    double tmpLeft = Canvas.GetLeft(cvsPanel) + theMousePoint.X - mousePoint.X;
                    double tmpTop = Canvas.GetTop(cvsPanel) + theMousePoint.Y - mousePoint.Y;
                    if (tmpLeft < 0)
                        tmpLeft = 0;
                    else if (tmpLeft > cvsMain.Width - cvsPanel.Width)
                        tmpLeft = cvsMain.Width - cvsPanel.Width;
                    if (tmpTop < 0)
                        tmpTop = 0;
                    else if (tmpTop > cvsMain.Height - cvsPanel.Height)
                        tmpTop = cvsMain.Height - cvsPanel.Height;
                    Canvas.SetLeft(cvsPanel, tmpLeft);
                    Canvas.SetTop(cvsPanel, tmpTop);
                    mousePoint = theMousePoint;
                }

            }
        }

        private void cvsMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
        }

        private void lbBackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
