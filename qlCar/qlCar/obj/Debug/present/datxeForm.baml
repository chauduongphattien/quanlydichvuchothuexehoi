   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5   	       qlCar.present.datxeForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:qlCar.present     5   	     � WindowStyle$
  none=�5   
    � WindowStartupLocation$ CenterScreen=�5	   
    � AllowsTransparency . 
������  � Title$ 	datxeForm��5   	   $	��350��6   $	��600��6(   .��5      � .+�5   
   �� ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 0,1&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ Black��6#   $	 0.3Q�61   � 5      $
 blue��6#   $ 1Q�60   5      ._�5      �  � RowDefinitions 5      �� 5      $��80 �6$   �� 5      $��70 �6$   �� 5      $��70 �6$   �� 5      $��50 �6$   �� 5      $��60 �6$   .+�5      �� -   5        	 ��Name$	 ctrBar��5   &   $��0��6   ._�5      �� $��Chi tiết bảo trì��6   $��Center=�67   $��Center=�5       
�������$��40(�5!      $��	ExtraBold"�6*   5"      �� 5#      
 �� Orientation$
 
Horizontal=�6   $��1��66   $��Center=�6C   .+�5$      �� $��ngay bảo trì: ��6   
�������$��20(�6H   $��Center=�6V   $��Center=�5%      (  "System.Windows.Controls.DatePicker  5&      -   5          Name$ datetimePickerNhan��5&   !   $��30��6=   $��Center=�6I   $	��200��6k   5'      �� 5)      $
 
Horizontal=�6   $��2��66   $��Center=�6C   .+�5*      �� $��0,0,20,0q�6   $��ngay trả xe: ��6.   
�������$��20(�6Y   $��Center=�6g   $��Center=�5+        5,      -   5        $ datetimePickerTra��5,   9   $	��200��6!   $��30��6-   $��Center=�6T   5-      �� 5.      $��3��6   $
 
Horizontal=�6*   $��Center=�6C   .+�5/      �� $��	mô tả:��6   
�������$��Center=�6@   $��Center=�50      $��15(�51      �� 52      -   5         ��Name$ motatxt��52   b   $	��150��6   $��30��6*   $��	20,0,20,0q�66   
������ $��1,0,0,1q�6s   
�������6�   �� 53      $��	chi phí:��6   
�������$��Center=�6B   $��Center=�54      $��15(�55      �� 56      -   5        $ 	chiphitxt��56   `   $��50��6   $��30��6)   $��10,0,0,0q�65   
������ $��1,0,0,1q�6s   
�������6�   58      �� 59      $��4��6   $��Center=�6*   $
 
Horizontal=�6G   .+�5:      �� -   5         ��Name$ okBut��5<      $��OK��5:      $	��100��6*   $��40��66   
�������
���� ��$
��Bold"�6i   $��20(�5;      5=      �� 5?      -   5        $��huyBut��5B      $��Cancal��5?      $	��100��6.   $��40��6:   
�������
�������$��	100,0,0,0q�5@      $
��Bold"�5A      $��20(�5D      5E      5F      5H      5I      5J      