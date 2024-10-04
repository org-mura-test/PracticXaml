using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Markup;
using CustomXamlPerson;
using System.ComponentModel;

namespace CustomXaml
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public CustomXaml.Person2 person2local = new CustomXaml.Person2();

        public Window1()
        {
            InitializeComponent();
            //show_Person();
            
            CustomXamlPerson.Person person1 = new CustomXamlPerson.Person();
            this.ctrPerson.Content = person1.Birthday;
            btn1.Content = person1.Birthday;
            
        }

        //public static void shoperson(string[] args)
        public static void show_Person()
        {
            // アセンブリから対象のXAMLのストリームを取得
            //var s = typeof(Window1).Assembly.GetManifestResourceStream("CustomXaml1.Person.xaml");
            //var s = typeof(Window1).Assembly.GetManifestResourceStream("Person.Person.xaml");
            var s = typeof(CustomXaml.Person2Local).Assembly.GetManifestResourceStream("CustomXamlPerson.Person.xaml");
            
            // パース
            //var p = XamlReader.Load(s) as CustomXamlPerson.Person;
            var p = XamlReader.Load(s) as Person2Local;
            // プロパティを表示してみる
            Console.WriteLine("p.Birthday = {0}", p.Birthday);
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            set_birthday();
        }

        void set_birthday()
        {

            // アセンブリから対象のXAMLのストリームを取得
            //var s = typeof(Window1).Assembly.GetManifestResourceStream("CustomXaml.Person.xaml");
            //var s = typeof(Window1).Assembly.GetManifestResourceStream("CustomXamlPerson.Person.xaml");
            //var s = typeof(Window1).Assembly.GetManifestResourceStream("CustomXaml.Person2.xaml");
            var s = typeof(CustomXaml.Person2Local).Assembly.GetManifestResourceStream("CustomXaml.person2.xaml");

            // パース
            var p = XamlReader.Load(s) as Person2Local;
            // プロパティを表示してみる
            Console.WriteLine("p.Birthday = {0}", p.Birthday);
            btn1.Content = p.Birthday;

        }
    }



}
