using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getPersonValue();

        }

        private void getPersonValue()
        {
            // GetValue、SetValueの使用例
            var p = new Person();

            /*
            //　値を取得
            Console.Write(p.GetValue(Person.NameProperty));
            // 値を設定
            p.SetValue(Person.NameProperty, "松本　太郎");
            // 値を取得
            Console.WriteLine(p.GetValue(Person.NameProperty));
            */

            //　値を取得
            //Console.WriteLine(p.Name);
            Debug.WriteLine(p.Name);
            // 値を設定
            p.Name = "松本　太郎";
            // 値を取得
            //Console.WriteLine(p.Name);
            Debug.WriteLine(p.Name);



        }
        private void getChildValue()
        {
            // GetValue、SetValueの使用例
            var p1 = new Person();
            var p2 = new Person();


            //　値を取得


            // 値を設定
            p1.Children.Add(new Person());
            p2.Children.Add(new Person());

            // 値を取得
            //Console.WriteLine("p1.Children.count = {0}", p1.Children.Count);
            //Console.WriteLine("p2.Children.count = {0}", p2.Children.Count);
            Debug.WriteLine("p1.Children.count = {0}", p1.Children.Count);
            Debug.WriteLine("p2.Children.count = {0}", p2.Children.Count);



        }

        private void getAgeValue()
        {
            var p = new Person();

            //　値を取得
            Debug.WriteLine(p.Age);
            // 値を設定
            p.Age = 160;
            // 値を取得
            Debug.WriteLine(p.Age);

            try
            {
                // 不正な値なので例外が出る
                p.Age = int.MinValue;
                p.Age = int.MinValue + 1;

            } catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getPersonValue();
            getChildValue();
            getAgeValue();

            //
            this.CoerceValue(Person.AgeProperty);

        }
    }
}