using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeHelloWorld2
{

    public class MainWindow : Window
    {

        private Button helloWorldButton;

        private void initializeComponent()
        {
            // Window のプロパティ設定
            this.Title = "MainWindows1";
            this.Height = 350;
            this.Width = 525;

            //Button の作成
            this.helloWorldButton = new Button
            {
                Content = "Hello world",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,  
                Margin = new Thickness(10,10,0,0),
                Width = 100
            };

            this.helloWorldButton.Click += helloWorldButton_Click;

            // Grid の作成
            var grid = new Grid();
            grid.Children.Add(this.helloWorldButton);

            // grid を window に設定
            this.Content = grid;

        }

        public MainWindow()
        {
            this.initializeComponent();
        }

        private void helloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");

        }
    }
}
