   M S B A M L   `   `   `  ����I  ECollectionXaml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CollectionXamlCollectionXaml  5   	       CollectionXaml.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CollectionXaml     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5
      � $��0,0,0,80q�6    � ShowGridLines$
 True��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��2��6   $��Menu1��62   �� 5   
   $��1��6   $��2��6   $��Toolbar��62   �� 5!   
   $��3��6   $��2��6   $��	StatusBar��62   �� 5$   
   $��2��6   $
��Tree��6   �� 5(   
   $��2��5)      $��1��6   $
��Left=�5*      $��Stretch=�6(   $��5��6D   �� 5-   
   $��2��6   $��1��6   $��Content��6.   $��5,0,0,0q�6@   �� 5/   
   -   5        $��０回��5/      $��2��6   $��1��6+   $��50��50      $	��100��6   $��20,40,0,254q�6)   $
��Left=�6>   �� 53   
   -   5        $��繰り返し 0回��53       �� Delay$
 1000��6D    �� Interval$
 2000��6Q   $��2��54      $��1��6%   $��50��65   $	��100��6A   $��150,40,0,254q�6M   $
��Left=�55      57      59      