using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
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

        // データグリッド列の設定
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

        // メニュー　クリック時
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        // メニュー　クリック時
        private void MenuItem_Click_OpenImage(object sender, RoutedEventArgs e)
        {
            // 画像を開く
            var dialog = new OpenFileDialog();
            dialog.Filter = "画像|*.jpg;*.jpeg;*.png";
            if(dialog.ShowDialog() != true)
            {
                return;
            }
            //ファイルをメモリにコピー
            var ms = new MemoryStream();
            using ( var s = new FileStream(dialog.FileName, FileMode.Open))
            {
                s.CopyTo(ms);
            }
            // ストリームの位置をリセット
            ms.Seek(0, SeekOrigin.Begin);
            // ストリームをもとにBitmapImage　を作成
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.StreamSource = ms;
            bmp.EndInit();
            // BitmapImage をSourceに指定して画像を表示する
            this.image1.Source = bmp;

        }


        // ポップアップボタン　クリック時
        private void PopupButton_Click(object sender, RoutedEventArgs e)
        {
            var popups = new[]
            {
                this.popup1,
                this.popup2,
                this.popup3,
                this.popup4
            };

            foreach(var popup in popups)
            {
                popup.IsOpen = !popup.IsOpen;
            }
        }
    }

}