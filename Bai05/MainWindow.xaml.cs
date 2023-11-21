
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace Bai05;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public CreateWindow createWindow { get; set; }
    public ObservableCollection<SinhVien> SinhVienList { get; set; } = new();

    public static string UniToUTF8(string from)
    {
        var bytes = Encoding.ASCII.GetBytes(from);
        return new string(bytes.Select(b => (char)b).ToArray());
    }
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        SinhVienList.CollectionChanged += SinhVienList_CollectionChanged;
        SinhVienList.Add(new SinhVien("11", "Bích Sơn Nhật", "", 10));
        
    }

    

    private void SinhVienList_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (SinhVienList.Count>0)
        {
            for (int i = 0; i < SinhVienList.Count; i++)
            {
                SinhVienList[i].SoTT = i+1;
            } 
        }
        else SinhVienList[0].SoTT = 1;  
    }

    private void ThemMoi(object sender, RoutedEventArgs e)
    {
        var subwindow = new CreateWindow(this);
        subwindow.Show();

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        string searchword = UniToUTF8(SearchBar.Text.ToString());

        if (searchword == "")
        {
            SvList.ItemsSource = SinhVienList;
        }
        else
        {
            ObservableCollection<SinhVien> SinhVienSearchList = new();
            SvList.ItemsSource= SinhVienSearchList;
            foreach (SinhVien sv in SinhVienList)
            {
                if (UniToUTF8(sv.TenSV).ToLower().Contains(searchword.ToLower())) SinhVienSearchList.Add(sv);
            } 
        }
    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}

public class SinhVien
{
    public int SoTT { get; set; }
    public string Msv { get; set; }
    public string TenSV { get; set; }
    public string Khoa { get; set; }
    public float DiemTB { get; set; }
    public SinhVien( string msv, string ten, string khoa, float dtb)
    {
        Msv = msv;
        TenSV = ten;
        Khoa = khoa;
        if (dtb > 10 || dtb < 0) throw new InvalidDataException();
        else DiemTB = dtb;
    }
}

