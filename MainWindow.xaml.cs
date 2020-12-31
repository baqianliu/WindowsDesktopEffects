using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WindowsDesktopEffects
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();//创建timer定时器
            timer.Interval = TimeSpan.FromMilliseconds(50);//设置周期为1000毫秒
            timer.Tick += new EventHandler(Refresh_Time);
            timer.Start();
        }
        public void Refresh_Time(object sender, EventArgs e)
        {
            //string time = DateTime.Now.ToString("hh:mm:ss");//获取系统时间
            var p = System.Windows.Forms.Control.MousePosition;
            Canvas.SetLeft(ellipse, p.X + 30);
            Canvas.SetTop(ellipse, p.Y + 30);
            Debug.WriteLine("{0},{1}", p.X, p.Y);
        }
    }
}
