
using System.Windows;
using System.IO;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Bai06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random random {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            random=new Random();
            Source.Text = @"D:\uni\CTRI";
            Destination.Text = @"D:\";
        }

        private void Get_Source(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) Source.Text = browserDialog.SelectedPath;
        }

        private void Get_Des(object sender, RoutedEventArgs e)
        {

            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK) Destination.Text= browserDialog.SelectedPath;
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            CopyDirectory(Source.Text.ToString(), Destination.Text.ToString(), true,Progress, statusbar);

        }
        static async void CopyDirectory(string sourceDir, string destinationDir, bool recursive, System.Windows.Controls.ProgressBar progress, System.Windows.Controls.TextBlock status)
        {
            progress.Value = 0;
            float copied = 0;
            var dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(destinationDir);
            
            
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir , file.Name);
                file.CopyTo(targetFilePath);
                status.Text = "Đang sao chép " + file.FullName;
                await Task.Run(() => Thread.Sleep(random.Next(100, 200)));
                copied++;
                progress.Value = (copied / (float)dir.GetFiles().Count())*100;
            }

            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true,  progress, status);
                }
            }
            status.Text = "";
            progress.Value = 0;
        }

    }
}
