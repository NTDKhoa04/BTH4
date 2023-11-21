using System;
using System.Windows;


namespace Bai05;

/// <summary>
/// Interaction logic for CreateWindow.xaml
/// </summary>
public partial class CreateWindow : Window
{
    public SinhVien sv { get; set; }
    public MainWindow main { get; set; }

    public CreateWindow(MainWindow _main)
    {
        InitializeComponent();
        DataContext = this;
        main = _main;
      
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

        try
        {
            foreach (SinhVien sv in main.SinhVienList)
            {
                if (MaSoSinhVien.Text == sv.Msv)
                {
                    MessageBox.Show("Đã tồn tại mã số sinh viên này", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            main.SinhVienList.Add(
                    new SinhVien(
                    MaSoSinhVien.Text.ToString(),
                    TenSinhVien.Text.ToString(),
                    Khoa.Text.ToString(),
                    float.Parse(DiemTb.Text.ToString())));
            Close();
            
        }
        catch (Exception)
        {

            MessageBox.Show("Thông tin nhập chưa hợp lệ", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        MessageBoxResult r= MessageBox.Show("Mọi thông tin đã nhập sẽ bị xóa, xác nhận thoát?", "Thoát", MessageBoxButton.YesNo, MessageBoxImage.Warning,MessageBoxResult.No);
        if (r == MessageBoxResult.Yes) this.Close();
        else return;

    }
}
