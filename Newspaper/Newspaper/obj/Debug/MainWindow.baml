   M S B A M L   `   `   `  ����D  @Newspaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Newspaper	Newspaper  5   	       Newspaper.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Newspaper     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1000��6)   .��5	      � .+�5
   
   ,� .��5      /�  /� PagePadding$ 0q�6   .T�5      �� .r�5      �  � RowDefinitions 5      �� 5      $��* �6,   69   �� 5      $��* �6,   69   �� 5      $��5* �6,   6:   .+�5      �� $��0��6    $��
img\11.jpg��6-   $��60��6A   6O   ]� 5      $��1��6$   
���   �.+�5      � $	��Top=�6#    � ColumnDefinitions 5   "   �� 5   &   69   �� 5   &   69   �� 5   &   69   �� 5   &   69   �� 5   &   69   �� 5   &   69   �� 5   &   69   �� 5   &   69   .+�5    "   �� $��0��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   
Top News6�   �� 5!   "   $��1��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   Local6�   �� 5"   "   $��2��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   National/World6�   �� 5#   "   $��3��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   Business/Tech6�   �� 5$   "   $��4��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   Sports6�   �� 5%   "   $��5��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   	Life arts6�   �� 5&   "   $��6��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   	Opinion6�   �� 5'   "   $��7��6)   $��0 5 0 0q�69   $��0q�6J   
��� ���
�������.��6�   	Most Read6�   5(      (  "System.Windows.Controls.DatePicker  5)      $��Bottom=�6)   $��Center=�6A   $��Bottom=�6e      DisplayDateEnd$ 06/03/2020 22:10:00X�5*         DisplayDateStart$ 06/03/2020 22:10:00X�6>      Text$ 03.06.2020 22:10��6e      SelectedDateFormat$
 Long=�6}      IsTodayHighlighted . 	 J� IsHitTestVisible	 .  #��� ��5,   2   5-      5.      5/      �� 50      
 �� BorderBrush

 �   � �� CellSpacing$ 0��6,    �� Margin$ 0q�6<    �� Padding$ 10q�6G   .�51      �� .�52      �� .�53      ��  �� BorderBrush
 �   � �� BorderThickness$ 0,0,1,0q�6<   $��10(�6V   .�54   "   J� $
 10 0q�6,    �� TextAlignment$ Center=�6;   .*�6R   .*�55   &   �� .�6+   Lorem ipsum dolor sit amet6G   56   #   J� 57   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�58   &   �� .�6+   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup5<   '   5=   #   J� 5>   "   $
 10 0q�6,   $ Center=�6;   .*�6R   .*�5?   &   �� .�6+   Lorem ipsum dolor sit amet6G   5@   #   J� 5A   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�5B   &   �� .�6+   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup5F   '   5G   #   J� 5H   "   $
 10 0q�6,   $ Center=�6;   .*�6R   .*�5I   &   �� .�6+   Lorem ipsum dolor sit amet6G   5J   #   J� 5K   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�5L   &   �� .�6+   IGconsectetur adipiscing elit, sed do eiusmod incididunt ut labore et dol5N   '   5O   #   5P      �� 5Q      
 �   �$ 0,0,1,0q�6=   $��10(�6W    �� 
ColumnSpan$ 2��6e   .�5R   "   �� $ 0q�6(   .�5S   &   �� .�5T   *   �� .�5U   .   �� $ 2��69    �� TextAlignment$ Center=�6H   $��20(�6_    �� Padding$ 0q�6m   .�5V   2   J� .*�6=   .*�5W   6   �� .�6;   .�5Y   :   August roadwork will turn 1-5�� 6F   into parking lot5Z   7   5[   3   5\   /   5]   +   �� 5^   *   .�5_   .   �� 
 �   �$ 0,0,1,0q�6L   $��10(�6f   .�5`   2   J� $
 10 0q�6<   $ Center=�6K   .*�6b   .*�5a   6   �� .�6;   Lorem ipsum dolor sit amet6W   5b   3   J� 5c   2   $ 10q�6<   $
 Left=�6I   .*�6^   .*�5d   6   �� .�6;   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderkjhgkit in volup5h   7   5i   3   J� 5j   2   $
 10 0q�6<   $ Center=�6K   .*�6b   .*�5k   6   �� .�6;   Lorem ipsum dolor sit amet6W   5l   3   J� 5m   2   $ 10q�6<   $
 Left=�6I   .*�6^   .*�5n   6   �� .�6;   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup sequat. Duis aute irure dolor in reprehenderit in ;;;;volupsequat. Duis aute irure dolor in reprehenderit in volup5t   7   5u   3   5v   /   �� 5w   .   .�5x   2   J� $
 10 0q�6<   $ Center=�6K   .*�6b   .*�5y   6   �� .�6;   Lorem ipsum dolor sit amet6W   5z   3   J� 5{   2   $ 10q�6<   $
 Left=�6I   .*�6^   .*�5|   6   �� .�6;   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup5�   7   5�   3   J� 5�   2   $
 10 0q�6<   $ Center=�6K   .*�6b   .*�5�   6   �� .�6;   Lorem ipsum dolor sit amet6W   5�   3   J� 5�   2   $ 10q�6<   $
 Left=�6I   .*�6^   .*�5�   6   �� .�6;   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volupsequat. Duis aute irure dolor in reprehenderit in volup volupsequat. Duis aute irure dolor in reprehenderit in volup volupsequat. Duis aute irure dolor in reprehenderit in volup5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   5�      �� 5�      
 �   �$��10(�6<   .�5�   "   J� $
 10 0q�6,   $ Center=�6;   .*�6R   .*�5�   &   �� .�6+   Lorem ipsum dolor sit amet6G   5�   #   J� 5�   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�5�   &   �� .�6+   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup5�   '   5�   #   J� 5�   "   $
 10 0q�6,   $ Center=�6;   .*�6R   .*�5�   &   �� .�6+   Lorem ipsum dolor sit amet6G   5�   #   J� 5�   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�5�   &   �� .�6+   ��consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in volup5�   '   5�   #   J� 5�   "   $
 10 0q�6,   $ Center=�6;   .*�6R   .*�5�   &   �� .�6+   Lorem ipsum dolor sit amet6G   5�   #   J� 5�   "   $ 10q�6,   $
 Left=�69   .*�6N   .*�5�   &   �� .�6+   B@consectetur adipiscing elit, sed do eiusmod tempor incididunt ut5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      