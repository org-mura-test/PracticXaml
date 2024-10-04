using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticXaml
{
    internal class Person3 : FrameworkElement
    {
        /// <summary>
        /// イベント名Eventの命名規約のstaticフィールドに格納する
        /// </summary>
        public static RoutedEvent ToAgeEvent = EventManager.RegisterRoutedEvent(
            "ToAge",　　　　　　　　// イベント名
            RoutingStrategy.Tunnel,  // イベントタイプ
            typeof(RoutedEventHandler), // イベントハンドラの型
            typeof(Person3));           // イベントのオーナー


        /// <summary>
        /// CLRのイベントのラッパー
        /// </summary>
        public event RoutedEventHandler ToAge
        {
            add { this.AddHandler(ToAgeEvent, value); }
            remove { this.RemoveHandler(ToAgeEvent, value); }
        }

        // 子を追加するメソッド
        public void AddChild(Person3 child)
        {
            this.AddLogicalChild(child);
        }
    }

}
