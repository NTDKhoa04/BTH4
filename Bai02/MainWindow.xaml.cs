
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace BTH4_NguyenThaiDangKhoa_22520679;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        DispatcherTimer TimerClock = new DispatcherTimer();
        TimerClock.Interval = new TimeSpan(0, 0, 1);
        TimerClock.Tick += TimerClock_Tick;
        TimerClock.Start();
    }

    private void TimerClock_Tick(object? sender, EventArgs e)
    {
        CultureInfo ci = new CultureInfo("vi-VN");
        TextBlock.Text = DateTime.Now.ToString("F", ci);
    }


}
