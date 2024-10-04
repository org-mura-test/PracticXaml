using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace PracticXaml
{
    public class Person : DependencyObject
    {
        // コンストラクタ
        public Person()
        {
            // デフォルト値をコンストラクタで指定するようにする。
            this.Children = new List<Person>();
        }

        #region プロパティ

        // Name 
        /*
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register(
                "Name",  // プロパティ名を指定
                typeof(string), // プロパティの型を指定
                typeof(Person), // プロパティを所有する型を指定
                new PropertyMetadata("default name"));　// デフォルト値を指定
        */
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register(
                "Name",  // プロパティ名を指定
                typeof(string), // プロパティの型を指定
                typeof(Person), // プロパティを所有する型を指定
                new PropertyMetadata(
                    "default name",      // デフォルト値を指定
                    NamePropertyChanged  // プロパティの変更時に呼ばれるコールバックの設定
                    ));

        // 依存関係プロパティのCLRのプロパティのラッパー
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }

        }

        // プロパティの値が変更されたとき
        private static void NamePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Name プロパティが{0}から{1}に変わりました", e.OldValue, e.NewValue);
        }

        // Children 
        public static readonly DependencyProperty ChildrenProperty =
            DependencyProperty.Register(
                "Children", // プロパティ名を指定
                typeof(List<Person>), // プロパティの型を指定
                typeof(Person), // プロパティを所有する型を指定
                new PropertyMetadata(new List<Person>())); // デフォルト値を指定

        // 依存関係プロパティのCLRのプロパティのラッパー
        public List<Person> Children
        {
            get { return (List<Person>)GetValue(ChildrenProperty); }
            set { SetValue(ChildrenProperty, value); }

        }


        // Age
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register(
                "Age",  // プロパティ名を指定
                typeof(int), // プロパティの型を指定
                typeof(Person), // プロパティを所有する型を指定
                new PropertyMetadata(
                    0,      // デフォルト値を指定
                    AgePropertyChanged,  // プロパティの変更時に呼ばれるコールバックの設定
                    CoerceAgeValue       // プロパティの値の範囲を矯正
                    ),
                ValidateAgeValue
                );

        // 依存関係プロパティのCLRのプロパティのラッパー
        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }

        }

        // プロパティの値が変更されたとき
        private static void AgePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Age プロパティが{0}から{1}に変わりました", e.OldValue, e.NewValue);
        }

        // プロパティの値の範囲を指定
        private static object CoerceAgeValue(DependencyObject d, object baseValue)
        {
            // 年齢の範囲
            var value = (int)baseValue;
            if (value < 0)
            {
                return 0;
            }
            if (value > 120)
            {
                return 120;
            }
            return value;
        }

        // 
        private static bool ValidateAgeValue(object value)
        {
            // int型のMinValueとMaxVaule
            int age = (int)value;
            return age != int.MaxValue && age != int.MinValue;
        }


        // 誕生日
        // RegisterReadOnlyメソッドでDependencyPropertyKeyを取得
        private static readonly DependencyPropertyKey BirthdayPropertyKey =
            DependencyProperty.RegisterReadOnly(
                "Birthday",
                typeof(DateTime),
                typeof(Person),
                new PropertyMetadata(DateTime.Now)
                );

        // DenpendencyPropertyは、DependencyPropertyKeyから取得する。
        public static readonly DependencyProperty BirthdayProperty
             = BirthdayPropertyKey.DependencyProperty;

        public DateTime Birthday
        {
            // get は従来通り
            get { return (DateTime)GetValue(BirthdayProperty); }
            // setはDependencyPropertyKeyを使う。
            private set { SetValue(BirthdayPropertyKey, value); }
        }

        #endregion プロパティ



    }
}
