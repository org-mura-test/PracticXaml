using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CollectionXaml
{
    public class Program
    {
        //static void MainMethod(string[] args)
        public void MainMethod()
        {
            var s = typeof(Program).Assembly.GetManifestResourceStream("CollectionXaml.Item.cs");
            var item = XamlReader.Load(s) as Item;

            Console.WriteLine(item.ItemId);
            foreach (var i in item.Children)
            {
                Console.WriteLine(" {0}", i.ItemId);
            }

        }
    }
}
