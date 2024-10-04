using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CollectionXaml
{
    /*
    //public class Item : DependencyObject
    public class Item : Control
    {

        public Item()
        {
            this.Children = new ItemCollection();
        }


        //public string Id { get; set; }
        public string ItemId
        {
            get { return (string)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }

        public static readonly DependencyProperty IdProperty =
            DependencyProperty.Register("ItemId", typeof(string), typeof(Item),
                new PropertyMetadata(string.Empty));

        // コレクション型のプロパティ
        //public ItemCollection Children { get; set; }
        public ItemCollection Children { get; set; }

    }

    //public class ItemCollection : Collection<Item> { }
    public class ItemCollection : ObservableCollection<Item> { }
    */


    public class Item : Control
    {

        public Item()
        {
            this.Children = new ItemCollection();
        }


        public string ItemId { get; set; }
        

        
        // コレクション型のプロパティ
        public ItemCollection Children { get; set; }
        
    }

    public class ItemCollection : Collection<Item> { }
    
}
