using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionXaml
{
    // 性別
    public enum enumGender
    {
        None,
        Men,
        Women
    }

    class ClassPerson
    {
        // 名前
        public string Name { get; set; }
        // 性別
        public enumGender Gender { get; set; }
        // 年齢
        //public int Age { get; set; }
        // 認証済みユーザーかどうか
        public bool AuthMember { get; set; }

        public List<ClassPerson> Children { get; set; }


    }

    // Gender をComboBoxに表示するためのクラス
    public class GenderComboboxItem
    {
        // 表示用のラベル
        public string Label { get; set; }
        // 値
        public enumGender Value { get; set; }

    }
}
