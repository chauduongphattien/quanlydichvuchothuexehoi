   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5   	       qlCar.present.baotriForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:qlCar.present     5   	   
������   � WindowStyle$
  none=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   
    � AllowsTransparency .  � Title$ 
baotriForm��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   ��  �� CornerRadius$ 20��6   $��0q�6#   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 0,1&�67   .��5      �  � Color$ DarkBlue��6#    � Offset$ 0Q�64   � 5      $ DarkBlue��6#   $ 0Q�64   � 5      $ White��6#   $ 1Q�61   5      ._�5      � 	 � RowDefinitions	 5      �� 5      $	��100 �6$   �� 5      $��40 �6$   �� 5      $��40 �6$   �� 5      $��40 �6$   �� 5      $��40 �6$   �� 5      $��1* �6$   .+�5       �� -   5        
 ��Name$
 ctrBar��5    &   $��0��6   ._�5!      �� $��Chi tiết đặt xe��6   
�������$��20(�6I   $��	ExtraBold"�5"      $��Center=�63   $��Center=�5#      5$      �� 5%       �� Orientation$ 
Horizontal=�6   $��1��66   $��Center=�6C   .+�5&      �� $��ten: ��6   
���   �$
��Bold"�6?   $��15(�6Q   $��Center=�5'      �� 5(      -   5         ��Name$ tenKHtxt��5(   6   $	��200��6   $��20��6*   66   �� 5)      $��CMND: ��6   
���   �$
��Bold"�6@   $��15(�6R   $��Center=�5*      �� 5+      -   5        $ 	cmndKhTXT��5+   6   $	��200��6   $��20��6*   66   5,      �� 5-      $ 
Horizontal=�6   $��2��66   $��Center=�6C   .+�5.      �� $��SDT: ��6   
���   �$
��Bold"�6?   $��15(�6Q   $��Center=�5/      �� 50      -   5        $ sdtKHTxt��50   6   $	��200��6   $��20��6*   66   �� 51      $��	Mail KH: ��6   
���   �$
��Bold"�6C   $��15(�6U   $��Center=�52      �� 53      -   5        $ 	mailKHtxt��53   6   $	��200��6   $��20��6*   66   54      �� 55      $ 
Horizontal=�6   $��3��66   $��Center=�6C   .+�56      �� $��Địa chỉ: ��6   
���   �$
��Bold"�6C   $��15(�6U   $��Center=�57      �� 58      -   5        $ diachiKHtxt��58   6   $	��450��6   $��20��6*   66   5:      �� 5;      $ 
Horizontal=�6   $��4��66   $��Center=�6C   .+�5<      �� $��Ngày nhận xe: ��6   
���   �$
��Bold"�6H   $��15(�6Z   $��Center=�5=      (  "System.Windows.Controls.DatePicker  5>      -   5          Name$ ngaynhanPicker��5>   H   $	��150��6!   $��Center=�6-   6H   �� 5?      $��Ngày trả xe: ��6   
���   �$
��Bold"�6G   $��15(�6Y   $��Center=�5@        5A      -   5        $ ngaytraPicker��5A   H   $��Center=�6!   $	��150��6<   6H   5B      �� 5C      $ 
Horizontal=�6   $��5��66   $��Center=�5D      .+�5E      �� -	   5         ��Name$ XNbut��5E      $��Xác nhận ��6@   $	��200��6T   $��50��6`   $��25(�6l   $
��Bold"�6z   �� 5F      -
   5        $ dongbut��5F      $��	100,0,0,0q�6D   $��Đóng ��6W   $	��200��6g   $��50��6s   $��25(�6   $
��Bold"�6�   5H      5I      5J      5K      5L      