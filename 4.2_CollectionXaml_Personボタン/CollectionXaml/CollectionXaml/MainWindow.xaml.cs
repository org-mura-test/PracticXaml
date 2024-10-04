using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollectionXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // sender 経由でクリックイベントを発生させたボタンを取得
            var button = (Button)sender;
            // ボタンの表示を更新
            button.Content = string.Format("{0}回", ++count);
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            // sender 経由でクリックイベントを発生させたボタンを取得
            var button = (RepeatButton)sender;
            // ボタンの表示を更新
            button.Content = string.Format("繰り返し　{0}回", ++count);
        }

    }

}