   M S B A M L   `   `   `  ����B  >ExamWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ExamWPFExamWPF  5   	       ExamWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ExamWPF     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      !  FontAwesome.WPF.FontAwesome   icon��%   &	          5   
   6(   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��2.5* �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   � $��0��6   $��0��6    5      �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   .+�5!      �� 
����  �.��5"      �� .+�5#      �� $��0��6     FontAwesome.WPF.Awesome   Content$ Desktop=�6)   
�������$��50(�6Z   $��Center=�6h   6�   �� 5$      $��1��6   
�������$��15(�6=   $��DESKTOP��6K   $��Center=�6]   6�   �� 5%      $��2��6   
�������$��10(�6<   $	��WPF��6J   $��Center=�6X   6~   �� 5&      $��3��6   
�������$��10(�6<   $��Window Forms��6J   $��Center=�6a   6�   �� 5'      $��4��6   
�������$��10(�6<   $	��WPF��6J   $��Center=�6X   6~   5(      5)      �� 5*      $��1��6   
��� ���.��5+      �� .+�5,      �� $��0��6   $ Globe=�6)   
�������$��50(�6X   $��Center=�6f   6�   �� 5-      $��1��6   
�������$��15(�6=   $	��WEP��6K   $��Center=�6Y   6   �� 5.      $��2��6   
�������$��10(�6<   $��ASP.NET��6J   $��Center=�6\   6�   �� 5/      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6U   6{   �� 50      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6U   6{   51      52      �� 53      $��2��6   
������.��54      �� .+�55      �� $��0��6   $ Cloud=�6)   
�������$��50(�6X   $��Center=�6f   6�   �� 56      $��1��6   
�������$��15(�6=   $��CLOUD��6K   $��Center=�6[   6�   �� 57      $��2��6   
�������$��10(�6<   $��Azure��6J   $��Center=�6Z   6�   �� 58      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6V   6|   �� 59      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6V   6|   5:      5;      �� 5<      $��3��6   
����p��.��5=      �� .+�5>      �� $��0��6   $ Mobile=�6)   
�������$��50(�6Y   $��Center=�6g   6�   �� 5?      $��1��6   
�������$��15(�6=   $��MOBILE��6K   $��Center=�6\   6�   �� 5@      $��2��6   
�������$��10(�6<   $��Xamarin��6J   $��Center=�6\   6�   �� 5A      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6V   6|   �� 5B      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6V   6|   5C      5D      �� 5E      $��4��6   
���/���.��5F      �� .+�5G      �� $��0��6   $ Gamepad=�6)   
�������$��50(�6Z   $��Center=�6h   6�   �� 5H      $��1��6   
�������$��15(�6=   $��GAMING��6K   $��Center=�6\   6�   �� 5I      $��2��6   
�������$��10(�6<   $��Unity��6J   $��Center=�6Z   6�   �� 5J      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6U   6{   �� 5K      $��3��6   
�������$��10(�6<   $�� ��6J   $��Center=�6U   6{   5L      5M      �� 5N      $��5��6   
����� �.��5O      �� .+�5P      �� $ 	Microchip=�6   
�������$��50(�6O   $��Center=�6]   6�   �� 5Q      
�������$��15(�60   $	��IoT��6>   $��Center=�6L   6r   �� 5R      
�������$��10(�6/   $��ARM32��6=   $��Center=�6M   6s   �� 5S      
�������$��10(�6/   $��ARM64��6=   $��Center=�6M   6s   �� 5T      
�������$��10(�6/   $�� ��6=   $��Center=�6H   6n   5U      5V      �� 5W      $��6��6   
���  ��.��5X      �� .+�5Y      �� $ Magic=�6   
�������$��50(�6K   $��Center=�6Y   6   �� 5Z      
�������$��15(�60   $��AI��6>   $��Center=�6K   6q   �� 5[      
�������$��10(�6/   $��MLNET��6=   $��Center=�6M   6s   �� 5\      $��3��6    
�������$��10(�6@   $&��      .NET for       Apache Spank��6N   $
��Wrap=�6v   6�   �� 5]      
�������$��10(�6/   $�� ��6=   $��Center=�6H   6n   5^      5_      5`      � 5a   
   $��1��6   $��2��6     5b      �� 5c      $
��0.5* �6    60   �� 5d      6"   �� 5e      6"   �� 5f      6"   �� 5g      6"   .+�5i      �� $��0��6   $��TOOLS��6#   
�������$��20(�6I   6Y   �� 5j      -   5        $��1��5j      
�������
 � Tag 6P   ��  �� ElementName$ btnvs�� �� Path$ Content�.��5k      �� .+�5l      �� $��
img\vs.png��6   $��50��60   $��UniformToFill=�6;   6U   �� 5m      -   5        $��btnvs��5m      $��15(�6*   $��VISUAL STUDIO��68   $��Center=�6P   $6 0https://visualstudio.microsoft.com/ru/downloads/��6t   6�   5n      5o      �� 5p      -   5        $��2��5p      
������� 6Q   �� $ btnvsmac��$ Content�.��5q      �� .+�5r      �� $��img\vsmac.png��6   $��50��64   6A   �� 5s      -   5        $��btnvsmac��5s      $��15(�6,   $��VISUAL STUDIO FOR MAC��6:   $��Center=�6Z   6�   5t      5u      �� 5v      -   5        $��3��5v      
������� 6P   �� $ btnvscod��$ Content�.��5w      �� .+�5x      �� $��img\vscod.png��6   $��50��64   6A   �� 5y      -   5        $��btnvscod��5y      $��15(�6,   $��VISUAL STUDIO CODE��6:   $��Center=�6W   6}   5z      5{      �� 5|      -   5        $��4��5|      
������� 6Q   �� $ btncmd��$ Content�.��5}      �� .+�5~      �� $��img\cmd.png��6   $��50��62   6?   �� 5      -   5        $��btncmd��5      $��15(�6*   $��COMMAND LINE INTERFACE��68   $��Center=�6Y   6   5�      5�      5�      � 5�   
   $��1��6   
���� �� 5�      �� 5�      6#   �� 5�      $��2* �6    6.   �� 5�      6$   �� 5�      6$   .+�5�      �� $��.NET STANDART��6   $��Center=�6,   $��Center=�6P   $��10q�6r   $��15(�6   
�������6�   �� 5�      $��1��6   .+�5�      �� -	   5         ��Name$ lbScreen��5�      $��.NET 5 ��6+   
���� ��
�������$��Center=�6d   $��Center=�6�   $��30(�6�   $��5 0 5 0q�6�   6�   �� 5�      
���� ��
�������$��Center=�6@   $��Center=�6d   $��5 0 5 10q�6�   .��5�      �� -
   5        	 �Name$
	 link��5�      .�66   69   5�      5�      �� 5�      $��2��6   $��INFRASTUCTURE��6!   
���� ��
�������$��Center=�6`   $��Center=�6�   $��15(�6�   $��5 0 5 0q�6�   6�   � 5�      $��3��5�      
���� ��$��5 0 5 10q�63    5�      �� 5�      6)   �� 5�      6)   �� 5�      6)   .+�5�      �� $��	10 0 10 8q�6   .��6-   RUNTIME COMPONENTS6A   �� 5�      $��1��6   $��	10 0 10 8q�6)   .��6=   	COMPILERS6H   �� 5�      $��2��6   $��	10 0 10 8q�6)   .��6=   	LANGUAGES6H   5�      5�      5�      5�      