   M S B A M L   `   `   `  ����I  ECollectionXaml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CollectionXamlCollectionXaml  5   	       CollectionXaml.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CollectionXaml     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5
      � $��0,0,0,80q�6    � ShowGridLines$
 True��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��2��6   $��Menu1��62   �� 5   
   $��1��6   $��2��6   $��Toolbar��62   �� 5"   
   $��4��6   $��2��6   $��	StatusBar��62   �� 5%   
   $��2��6   $
��Tree��6   �� 5)   
   $��2��5*      $��1��6   $
��Left=�5+      $��Stretch=�6(   $��10��6D   �� 5.   
   $��2��6   $��1��6   $��Content��6.   $��10,0,0,0q�6@   R� 50   
   $��2��6   .@�51      Q� $��Item1��6   .@�52      Q� $��Item1-1��6   .@�53      Q� $��	Item1-1-1��6#   Q� 54      $��	Item1-1-2��6#   Q� 55      $��	Item1-1-3��6#   56      Q� 57      $��Item1-2��6   .@�58      Q� $��	Item1-2-1��6#   Q� 59      $��	Item1-2-2��6#   5:      5;      Q� 5<      $��Item2��6    Q� 
IsExpanded$
 True��6*   .@�5=      Q� $��Item2-1��6   $
 True��60    Q� 
IsSelected$
 True��6B   .@�5>      Q� $��	Item2-1-1��6#   Q� 5?      $��	Item2-1-2��6#   Q� 5@      $��	Item2-1-3��6#   5A      5B      5D      &   System.Windows.Controls.DataGrid  5R   
   -   5        $��	datagrid1��5R      $��2��6$   $��1��61      AutoGenerateColumns$ False��5S      $��15,0,0,0q�6/      Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ 名前��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Name+4  .System.Windows.Controls.DataGridCheckBoxColumn  5V      $ 認証済み��6)   	 67   �� *
AuthMember+4  .System.Windows.Controls.DataGridComboBoxColumn  5X      $ 性別��6)   
   DisplayMemberPath$
 Label��5Y   %      SelectedValuePath$ Value��5Z   %      SelectedValueBinding 5X   5   �� *Gender+   ItemsSource 5[      �� 5\       �� Type'   !CollectionXaml.GenderComboboxItem"  6"   .s�5]           Label$ 	未選択��67      Value$
 None=�6C     5^      $	 男��67   $	 Men=�6A     5_      $	 女��67   $ Women=�6A   5a      5c      4  .System.Windows.Controls.DataGridTemplateColumn  5f         HeaderStyle 5g      �� 5h       �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6    .�5i      ��  �� Property � �� �� Value$ Stretch=�6K   5j         HeaderTemplate 5l      �� 5m      .R�5n      �� .+�5o   "   �� $��名前��6,   �� 5p   "   �� 5q   "   $��認証済み��6,   5r      5s         CellTemplate 5u      �� 5v      .R�5w      �� .+�5x   "   �� ��6,   �� *Name+�� 5y   "   �� 5z   "   ${�False��6+    d� 	IsChecked 6=   �� *
AuthMember+5{      5|         CellEditingTemplate 5~      �� 5      .R�5�      �� .+�5�   "   �� ��6*   �� *Name+�� 5�   "   �� 5�   "    6+   �� *
AuthMember+5�      5�      5�      5�      5�      5�      