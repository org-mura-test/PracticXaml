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
        Person mPerson = new Person();

        public MainWindow()
        {
            InitializeComponent();
            getPersonValue();

        }

        private void getPersonValue()
        {
            //// GetValue、SetValueの使用例
            //var p = new Person();

            //　値を取得
            //Console.WriteLine(p.Name);
            Debug.WriteLine(mPerson.Name);
            // 値を設定
            mPerson.Name = "松本　太郎";
            // 値を取得
            //Console.WriteLine(p.Name);
            Debug.WriteLine(mPerson.Name);

        }
        private void setPersonValue()
        {
            // 値を設定
            mPerson.Name = "松本　太郎1";
            // 値を取得
            //Console.WriteLine(p.Name);
            Debug.WriteLine(mPerson.Name);

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
                // これは問題ない
                p.Age = int.MinValue + 1;

            } catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        private void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            getPersonValue();
            getChildValue();
            getAgeValue();

            //
            this.CoerceValue(Person.AgeProperty);

        }
        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {

            //Person p = new Person();
            setPersonValue();
            

            string lname = "";
            lname = mPerson.Name;

            List<Person> Personlist = new List<Person>
            {
                new Person { Name = "名前1", Age= 20 },
                new Person { Name = "名前2", Age= 45 },
                new Person { Name = lname, Age= 34 }
            };


            this.Listbox1.ItemsSource = Personlist;
            this.Listbox2.ItemsSource = Personlist;



        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var p = new Person();
            // person2の誕生日に－２日を設定
            Person2.SetBirthday(p, DateTime.Now.AddDays(-2) );
            // person2の誕生日を取得
            Debug.WriteLine(Person2.GetBirthday(p));

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var parent = new Person3 { Name = "parent" };
            var child = new Person3 { Name = "child" };

            parent.AddChild(child);

            parent.ToAge += (object s, RoutedEventArgs e) =>
            {
                Debug.WriteLine(((Person3)e.Source).Name);
            };

            parent.RaiseEvent(new RoutedEventArgs(Person3.ToAgeEvent));
            child.RaiseEvent(new RoutedEventArgs(Person3.ToAgeEvent));
        }


        #region 添付イベント

        // １.２　stackpanel が動く
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            var p = new Person();
            // person2の誕生日に－２日を設定
            Person2.SetBirthday(p, DateTime.Now.AddDays(-10));
            // person2の誕生日を取得
            Debug.WriteLine(Person2.GetBirthday(p));

        }

        // １．１　ボタンクリックが動いてから
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var p = new Person();
            // person2の誕生日に－２日を設定
            Person2.SetBirthday(p, DateTime.Now.AddDays(-20));
            // person2の誕生日を取得
            Debug.WriteLine(Person2.GetBirthday(p));

            
        }

        #endregion 添付イベント

    }
}