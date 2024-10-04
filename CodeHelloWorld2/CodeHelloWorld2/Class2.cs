using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CodeHelloWorld2
{
    internal class App : Application
    {
        private void initializeComponent()
        {
            // StartupUri は使えないのでStartupイベントを使う
            this.Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            //ウィンドウを作成して表示させるコードを明示的に描く
            var w = new MainWindow();
            w.Show();

        }

        [STAThread]
        public static void Main(string[] args)
        {
            // Appクラスを作成して初期化して実行
            var app = new App();
            app.initializeComponent();
            app.Run();

        }


    }
}
