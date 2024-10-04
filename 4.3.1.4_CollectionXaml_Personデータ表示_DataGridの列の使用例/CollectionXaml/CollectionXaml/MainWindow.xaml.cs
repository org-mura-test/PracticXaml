using System.Collections.ObjectModel;
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

            // 適当なデータ１００件を生成する
            var data = new ObservableCollection<ClassPerson>(
                Enumerable.Range(1, 100).Select(i => new ClassPerson
                {
                    Name = "松本　太郎" + i,
                    AuthMember = i % 5 == 0,
                    Gender = i % 2 == 0 ? enumGender.Men : enumGender.Women
                    //Age = 20 + i % 50,
                }
                ));
            // DataGridに設定する
            this.datagrid1.ItemsSource = data;

        }

        /*
        private void datagrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            // プロパティ名をもとに自動生成する列をカスタマイズします
            switch (e.PropertyName)
            {
                case "Name":
                    // Name 列は最初に表示してヘッダーを名前にする。
                    e.Column.Header = "名前";
                    e.Column.DisplayIndex = 0;
                    break;

                case "Gender":
                    //　列を表示
                    e.Cancel = true;
                    break;

                case "Age":
                    // 列の表示順を変更
                    e.Column.DisplayIndex = 1;
                    break;
                case "AuthMember":
                    break;

                default:
                    throw new InvalidOperationException();

            }

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
        */
    }

}