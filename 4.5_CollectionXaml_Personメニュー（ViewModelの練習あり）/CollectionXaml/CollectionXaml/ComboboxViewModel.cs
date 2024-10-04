using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionXaml
{
    public class ComboboxViewModel : INotifyPropertyChanged
    {
        // INotifyPropertyChangedインターフェースの実装
        public event PropertyChangedEventHandler PropertyChanged;

        // 変更通知
        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // 入力プロパティ
        private ClassPerson _comboboxValue;
        public ClassPerson ComboboxValue
        {
            /*
            get { return _comboboxValue; }
            set { if (_comboboxValue != value) 
                 { _comboboxValue = value; RaisePropertyChanged(); } }
            */

            get { return _comboboxValue; }
            set
            {
                if (_comboboxValue != value )
                { _comboboxValue = value; RaisePropertyChanged(); }
            }

        }
    }
}
