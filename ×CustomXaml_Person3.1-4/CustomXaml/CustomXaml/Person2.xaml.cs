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

namespace CustomXaml
{
    /// <summary>
    /// Person2.xaml の相互作用ロジック
    /// </summary>
    public partial class Person2 : Window
    {
        public Person2()
        {
            InitializeComponent();

            this.Birthday = DateTime.Now;
        }

        public DateTime Birthday { get; private set; }
        

    }

}
