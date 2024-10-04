using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticXaml
{
    public static class Person2
    {

        #region 依存プロパティ

        // RegisterAttachedメソッドを使って添付プロパティを作成する
        public static readonly DependencyProperty BirthdayProperty2 =
            DependencyProperty.RegisterAttached(
                "Birthday",
                typeof(DateTime),
                typeof(Person2),
                new PropertyMetadata(DateTime.MinValue));

        // プログラムからアクセスするための添付プロパティのラッパー
        public static DateTime GetBirthday(DependencyObject obj)
        {
            return (DateTime)obj.GetValue(BirthdayProperty2);
        }
        public static void SetBirthday(DependencyObject obj, DateTime value)
        {
            obj.SetValue(BirthdayProperty2, value);
        }

        #endregion 依存プロパティ

    }
}
