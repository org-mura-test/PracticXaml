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

            // グリッド用
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

            // TreeView用
            // データ表示
            this.treeViewPerson.ItemsSource = new List<ClassPerson>
            {
                new ClassPerson
                {
                    Name = "松本　太郎",
                    Children = new List<ClassPerson>
                    {
                        new ClassPerson { Name = "松本　花子"},
                        new ClassPerson { Name = "松本　一郎"},
                        new ClassPerson
                        {
                            Name = "木村　貫太郎",
                            Children = new List<ClassPerson>
                            {
                                new ClassPerson { Name = "木村 はな"},
                                new ClassPerson { Name = "木村 拓哉"},
                            }
                        }
                    }
                },
                new ClassPerson
                {
                    Name = "松本　二郎",
                    Children = new List<ClassPerson>
                    {
                        new ClassPerson { Name = "松本　三郎"}
                    }
                }
            };

            // カレンダー表示
            // 今日より前は選択不可にする。
            this.calendar.BlackoutDates.AddDatesInPast();
            // 翌日から４日間も選択不可にする。
            this.calendar.BlackoutDates.Add(
                new CalendarDateRange(
                    DateTime.Today.AddDays(1),
                    DateTime.Today.AddDays(4)));


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //　選択された日付を連結して表示
            var selected = string.Join(Environment.NewLine,
                this.calendar.SelectedDates.Select(d => d.ToString()));
            MessageBox.Show(selected);

        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var datePicker = (DatePicker)sender;
            this.textBlockSelectedDate.Text = datePicker.SelectedDate.ToString();   

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