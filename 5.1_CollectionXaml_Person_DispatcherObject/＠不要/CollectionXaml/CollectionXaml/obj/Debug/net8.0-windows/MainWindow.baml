   M S B A M L   `   `   `  ����I  ECollectionXaml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CollectionXamlCollectionXaml  5   	       CollectionXaml.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CollectionXaml     5   	     � Title$  
MainWindow��5   	   $	��764��6   $	��850��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Color �� EndPoint �� 
StartPoint � Color	 � Offset��%h  '��       7��'�� h     �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      8   6&   5      5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ White��6'   $	 0Q�65   � 5      $ 	#FFBBB9EF��6'   $	 1Q�69   5      5      5      5      .��5      � $��0,0,0,0q�6   
 � ShowGridLines$

 True��6    � RowDefinitions 5"   
   �� 5#      $
��Auto �6   $��28��6*   �� 5$      $
��Auto �6   $��30��6*   �� 5%      �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6    � ColumnDefinitions 5*   
   �� 5+      $	��150 �6   �� 5,      $��* �6   �� 5-      $	��100 �6   .+�50   
   �� $��0��6   $��2��6   $��Menu1��62   �� 51   
   $��1��6   $��2��6   $��Toolbar��62   $��	0,0,0,297q�6D   $��2��6W   �� 54   
   $��4��6   $��2��6   $��	StatusBar��62   $��0,0,0,0q�6F   �� 56   
   $��3��6   $��2��6   $��ProgressBar��62   $��0,50,0,0q�6H   �� 59   
   $��2��6   $
��Tree��6   �� 5=   
   $��2��5>      $��1��6   $
��Left=�5?      $��5��6(   �� 5B   
   $��2��6   $��1��6   $��	5,0,0,207q�6.   ��5C      �� 5D      $ 0.5,1&�6&   $ 0.5,0&�67   .��5E      � $ White��6#   $	 0Q�61   � 5F      $ 	#FFBBB9EF��6#   $	 0.319Q�65   5G      5I      &   System.Windows.Controls.DataGrid  5U   
   -   5        $��	datagrid1��5U      $��2��6$   $��1��61   $��1��6A   $��	0,297,0,0q�5V   I   �� 5Z   
   -   5        $!��右クリックメニュー��5Z      
���  ��$��5,5,10,0q�65   
���   �$��2��6Z    � ContextMenu 5[      �� 5]      .@�5^      m� -   5        $��メニュー1��5^      6.   m� 5_      $��画像��6   .@�5`      m� -   5        $��画像を開く��5`   #   62   m� 5a      $��メニュー2-2��6#   m� 5b      $��メニュー2-3��6#   5c      m� 5d      $��メニュー3��6   5e      5g      o� 5i   
   $��2��6   .@�5j      m� $��ファイル(_F)��6   .@�5l      m�  m� IsCheckable$
 True��6   $��開く(_F1)��6.   m� 5m      $
 True��6   $)��#開く(_F2と見せかけた名称)��6.   5n      m� 5o      $��
編集(_E)��6   m� 5p      $��オプション(_0)��6   .@�5q      m� $
 True��6   $��オプション1��6.   m� 5r      $
 True��6   $��オプション2��6.   m� 5s      $
 True��6   $��オプション3��6.   5u      5x      `� 5{   
   $��2��6   $��1��6*   .�5|      c� .@�5}      �� $��item1��6   �� 5~      $��item2��6   �� 5      $��item3��6   �� 5�      �� 5�      $��item4��6   �� 5�      $��chkitem5��6   5�      c� 5�      .@�5�      �� $��item6��6   �� 5�      $��item7��6   �� 5�      $��item8��6   �� 5�      d� 5�      $��tglitem9��6   �� 5�      $��item10��6   5�      5�      �� 5�   
   -   5         ��Name$ 	combobox1��5�       �� 
IsEditable$
 True��6&    w� TextPath$
 Name��68   $��1��5�      $��49,38,386,346q�6#   $��2��6:   $	��top=�5�       �� SelectedItem 5�      �� *ComboboxValue+ �� UpdateSourceTrigger$ PropertyChanged=���5�      �� 5�      .R�5�      ��  �� Orientation$ 
Horizontal=�6!   .+�5�      �� $	��2.5q�6:   ��6$   �� *Name+6:   �� 5�      $	��2.5q�69   ��6$   �� *Age+69   5�      5�      5�      �� 5�   
   -   5         ��Name$
 lbl2��5�      $��	名前：��6   $��	49,76,0,0q�6,   $
��Left=�6?   $��2��5�      $��1��6   $��40��6.   $��50��6:    J� RenderTransformOrigin$	 0,0&�6E   $	��Top=�5�      �� 5�   
   -   5         ��Name$
 txt1��5�      $��2��5�      $��1��6   $	��100��6.   $��40��6:   #��� ��6F   $��125,76,375,450q�6�   ��5�   "   �� *ComboboxValue.Age+5�      �� 5�   
   -   5        $
 lbl3��5�      $��	年齢：��6   $��
49,134,0,0q�6,   $
��Left=�6@   $��2��5�      $��1��6   $��40��6.   $��50��6:   $	 0,0&�6E   $	��Top=�5�      �� 5�   
   -	   5        $
 lbl1��5�      $��2��5�      $��1��6   $��40��6-   $	��100��69   $��125,134,375,392q�6E   ��5�      �� *ComboboxValue.Name+��5�      �� 5�      # � ��6"   5�      �� 5�   
   $��2��6   $��1��6!    � Cursor$  ��61   $	��100��6<   �� 5�      $�色々指定できる��6    �� 5�      $��https://www.google.co.jp?�6   .�6?   *(リンクできる　開かない google6S    �� 5�      
���  ��$�色も付けれる��6#    �� 5�      $��メイリオ)�6   $$�フォントも変えられる��6$   5�      �� 5�   
   $��2��6   $��	0,0,0,485q�6"   .+�5�      �� -
   5        $��popup button��5�      $��26��6F   � 5�      -   5         �Name$ popup1��5�      .��5�      �� 
�������$��Buttom(Default)��63   5�      � 5�      -   5        $ popup2��5�      $
��Left=�6%   .��5�      �� 
�������$
��Left��63   5�      � 5�      -   5        $ popup3��5�      $	��Top=�6$   .��5�      �� 
�������$	��Top��63   5�      � 5�      -   5        $ popup4��5�      $��Right=�6$   .��5�      �� 
�������$��Right��63   5�      �� 5�      $��
ToolButton��6    � ToolTip$! ツールチップの表示��6*   $��0,0,0,0q�6>   $��2��6O   $��2��6\   $��27��6p   5�      �� 5�   
   $��5q�6   $��3��6    .+�5�      �� $��Maximum=100 , Value=50��6   � 5�       � Maximum$	 100Q�6    � Value$ 50Q�6(   $��20��63   �� 5�      $��IsIndeterminate = True��6   � 5�       � IsIndeterminate$
 True��6   $��20��62   5�      �� 5�   
   $��4��6   $��2��6!   .@�5�      �� .��5�      �� $*��$ステータスバーのサンプル��6   5�      �� 5�      �� 5�      .��5�      � $
 True��6   $	��150��65   $��10��6A   5�      �� 5�      .��5�      �� $'��!情報表示に使用します。��6   5�      5�      �� 5�   
   -   5         ��Name$ image1��5�      $��2��6    $��Uniform=�60   $��	0,0,0,450q�6B   $��2��6U   5�      5�      