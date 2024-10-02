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

    public class ClassPerson
    {
        public string Name { get; set; }
        public enumGender Gender { get; set; }
        public int Age { get; set; }
        public bool AuthMember { get; set; }

    }
}
