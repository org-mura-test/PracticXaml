using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PracticXaml
{
    public class ClassPersonDataTemplateSlector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var p = (Person)item;
            if(p.Age < 40)
            {
                // Ageが４０より小さければPersonTemplate1
                return (DataTemplate)((FrameworkElement)container).FindResource("PersonTemplate1");
            }
            else
            {
                //// それ以外の場合、PersonTemplate2
                //return (DataTemplate)((FrameworkElement)container).FindResource("PersonTemplate2");

                DataTemplate dataTL;
                FrameworkElement fwEle;
                fwEle = (FrameworkElement)container;
                dataTL = (DataTemplate)fwEle.FindResource("PersonTemplate2");

                return dataTL;

            }
        }

    }
}
