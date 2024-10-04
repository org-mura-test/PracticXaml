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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CustomXaml
{

    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }




    }

    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            // アセンブリから対象のXAMLのストリームを取得
            var s = typeof(Program).Assembly.GetManifestResourceStream("CustomXaml.Person.xaml");
            // パース
            var p = XamlReader.Load(s) as Person;
            //　プロパティを表示する
            Console.WriteLine("p.Birthday = {0}", p.Birthday);

        }

    }

}
