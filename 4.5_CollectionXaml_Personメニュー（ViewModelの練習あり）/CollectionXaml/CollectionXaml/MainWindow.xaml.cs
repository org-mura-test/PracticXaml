using System;
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
using System.Windows.Xps;

namespace CollectionXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string pTxt1 { get; set; }
        ComboboxViewModel cmbViewModel = new ComboboxViewModel();

        public MainWindow()
        {
            InitializeComponent();

            // 適当なデータ１００件を生成する
            var data = new ObservableCollection<ClassPerson>(
                Enumerable.Range(1, 100).Select(i => new ClassPerson
                {
                    Name = "松本　太郎" + i,
                    Gender = i % 2 == 0 ? enumGender.Men : enumGender.Women,
                    Age = 20 + i % 50,
                    AuthMember = i % 5 == 0
                }
                ));
            // DataGridに設定する
            this.datagrid1.ItemsSource = data;

            var items = Enumerable.Range(1, 10)
                        .Select(i => new ClassPerson { Name = "おおた" + i, Age = 20 + i })
                        .ToList();
            this.combobox1.ItemsSource = items;
            //コンボボックスに設定
            this.combobox1.ItemsSource = items;

            //lbl1.Content = cmbViewModel;
            DataContext = cmbViewModel;


        }

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
                    ////　列を非表示
                    //e.Cancel = true;
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

 
    }

}