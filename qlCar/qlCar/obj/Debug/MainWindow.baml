   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:qlCarqlCar  5   	       qlCar.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:qlCar     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   
������   � WindowStyle$
  none=�5
   	    � WindowStartupLocation$ CenterScreen=�5   
    � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��700��6   $
��1200��6)   .��5      � .+�5   
   �� $��2q�6   
���  �� �� CornerRadius$ 10��67   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ Purple��6#   $	 0.5Q�62   � 5      $ Black��6#   $ 1Q�61   5      ._�5      � 	 � ColumnDefinitions	 5      �� 5      $��1* �6'   �� 5      $��5* �6'   .+�5       �� $��0��6   ._�5!      �� 
���� ��.+�5"      � $��40��6   
���� ��6+   	� 5$      -   5        
 	�Name$
 homeBtn��5$   *   ��5%   "   �� 5&   &    �� 
TargetType" 	�6,   .�5'   *   ��  �� Property � �� �� Value$ Center=�6U   �� 5(   *    � �� 5)   .   �� 5*   2    �� 
TargetType" 	�6B   .R�5,   6   ��  �� Orientation$ 
Horizontal=�6B   .+�5-   :   ��  ��Name$ boder��6A   $��80��6P   $��5��6\   
���  �� J� Opacity$ 0Q�6w   !  FontAwesome.Sharp.IconImage  5.   6   $��25��6C   �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ HomeAlt=�6N   $��	20,0,20,0q�6]   $��30��6p      
Foreground
 �  ��6|   �� 5/   6   $��	Trang chu��6<   
�������$��Roboto)�6c   $��16(�6w   $��Center=�6�   ��50   6   �� 51   :   $	 0,0&�6N   $	 0,1&�6_   .��52   >   � $ Purple��6K   $ 0Q�6Z   � 53   >   $ Black��6K   $ 1Q�6Y   54   ;   56   3    �� Triggers 58   6   P� 59   :    P� Property �@d�	IsChecked P� Value$
 TrueY�6W   . �5:   >   ��  �� 
TargetName$ boder��6E    �@J�Opacity$ 1Q�6k   5;   ;   5?   3   5A   +   5B   '   5D      	� 5J      -   5        $
 taikhoanBtn��5J   &   ��5K      �� 5L   "   " 	�6(   .�5M   &   ��  � ��$ Center=�6Q   �� 5N   &    � �� 5O   *   �� 5P   .   " 	�6>   .R�5R   2   �� $ 
Horizontal=�6>   .+�5S   6   �� $ boder��6=   $��80��6L   $��5��6X   
��� ���$ 0Q�6v     5T   6   $��25��6C   $ UserAlt=�6N   $��	20,0,20,0q�6]   $��30��6p   
 � ���6|   �� 5U   6   $��	Tai khoan��6<   
�������$��Roboto)�6c   $��16(�6w   $��Center=�6�   ��5V   6   �� 5W   :   $	 0,0&�6N   $	 0,1&�6_   .��5X   >   � $ Black��6K   $ 0Q�6Y   � 5Y   >   $ Purple��6K   $ 1Q�6Z   5Z   ;   5\   3    5^   2   P� 5_   6    �@d�	IsChecked$
 TrueY�6S   . �5`   :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5a   7   5e   /   5g   '   5h   #   5j      	� 5p      -   5        $
 carBtn��5p   &   ��5q      �� 5r   "   " 	�6(   .�5s   &   ��  � ��$ Center=�6Q   �� 5t   &    � �� 5u   *   �� 5v   .   " 	�6>   .R�5x   2   �� $ 
Horizontal=�6>   .+�5y   6   �� $ boder��6=   $��80��6L   $��5��6X   
��� ���$ 0Q�6v     5z   6   $��25��6C   $ CarAlt=�6N   $��	20,0,20,0q�6\   $��30��6o   
 � ���6{   �� 5{   6   $��Xe Hoi��6<   
�������$��Roboto)�6`   $��16(�6t   $��Center=�6�   ��5|   6   �� 5}   :   $	 0,0&�6N   $	 0,1&�6_   .��5~   >   � $ Purple��6K   $ 0Q�6Z   � 5   >   $ Black��6K   $ 1Q�6Y   5�   ;   5�   3    5�   2   P� 5�   6    �@d�	IsChecked$
 TrueY�6S   . �5�   :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5�   7   5�   /   5�   '   5�   #   5�      	� 5�      -   5        $
 NhanvienBtn��5�   &   ��5�      �� 5�   "   " 	�6(   .�5�   &   ��  � ��$ Center=�6Q   �� 5�   &    � �� 5�   *   �� 5�   .   " 	�6>   .R�5�   2   �� $ 
Horizontal=�6>   .+�5�   6   �� $ boder��6=   $��80��6L   $��5��6X   
��� � �$ 0Q�6u     5�   6   $��25��6C   $ PeopleGroup=�6N   $��	20,0,20,0q�6a   $��30��6t   
 � � �6�   �� 5�   6   $��	Nhan vien��6<   
�������$��Roboto)�6c   $��16(�6w   $��Center=�6�   ��5�   6   �� 5�   :   $	 0,0&�6N   $	 0,1&�6_   .��5�   >   � $ Black��6K   $ 0Q�6Y   � 5�   >   $ Purple��6K   $ 1Q�6Z   5�   ;   5�   3    5�   2   P� 5�   6    �@d�	IsChecked$
 TrueY�6S   . �5�   :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5�   7   5�   /   5�   '   5�   #   5�      	� 5�      -   5        $
 orderBtn��5�   &   ��5�      �� 5�   "   " 	�6(   .�5�   &   ��  � ��$ Center=�6Q   �� 5�   &    � �� 5�   *   �� 5�   .   " 	�6>   .R�5�   2   �� $ 
Horizontal=�6>   .+�5�   6   �� $ boder��6=   $��80��6L   $��5��6X   
����  �$ 0Q�6t     5�   6   $��25��6C   $ FileAlt=�6N   $��	20,0,20,0q�6]   $��30��6p   
 ��  �6|   �� 5�   6   $��	Đặt Xe��6<   
�������$��Roboto)�6`   $��16(�6t   $��Center=�6�   ��5�   6   �� 5�   :   $	 0,0&�6N   $	 0,1&�6_   .��5�   >   � $ Purple��6K   $ 0Q�6Z   � 5�   >   $ Black��6K   $ 1Q�6Y   5�   ;   5�   3    5�   2   P� 5�   6    �@d�	IsChecked$
 TrueY�6S   . �5�   :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5�   7   5�   /   5�   '   5�   #   5�      	� 5�      -   5        $
 	khachhang��5�   &   ��5�      �� 5�   "   " 	�6(   .�5�   &   ��  � ��$ Center=�6Q   �� 5�   &    � �� 5�   *   �� 5�   .   " 	�6>   .R�5�   2   �� $ 
Horizontal=�6>   .+�5�   6   �� $ boder��6=   $��80��6L   $��5��6X   
���**��$ 0Q�6v     5�   6   $��25��6C   $ HandshakeAlt=�6N   $��	20,0,20,0q�6b   $��30��6u   
 �**��6�   �� 5�   6   $��Khach Hàng��6<   
�������$��Roboto)�6d   $��16(�6x   $��Center=�6�   ��5�   6   �� 5�   :   $	 0,0&�6N   $	 0,1&�6_   .��5�   >   � $ Black��6K   $ 0Q�6Y   � 5�   >   $ Purple��6K   $ 1Q�6Z   5�   ;   5  3    5  2   P� 5  6    �@d�	IsChecked$
 TrueY�6S   . �5  :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5  7   5
  /   5  '   5  #   5     	� 5     -   5        $
 baotri��5  &   ��5     �� 5  "   " 	�6(   .�5  &   ��  � ��$ Center=�6Q   �� 5  &    � �� 5   *   �� 5!  .   " 	�6>   .R�5#  2   �� $ 
Horizontal=�6>   .+�5$  6   �� $ boder��6=   $��80��6L   $��5��6X   
�������$ 0Q�6u     5%  6   $��25��6C   $ Wrench=�6N   $��	20,0,20,0q�6\   $��30��6o   
 �����6{   �� 5&  6   $��Bao trì��6<   
�������$��Roboto)�6a   $��16(�6u   $��Center=�6�   ��5'  6   �� 5(  :   $	 0,0&�6N   $	 0,1&�6_   .��5)  >   � $ Purple��6K   $ 0Q�6[   � 5*  >   $ Black��6K   $ 1Q�6Y   5+  ;   5-  3    5/  2   P� 50  6    �@d�	IsChecked$
 TrueY�6S   . �51  :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   52  7   56  /   58  '   59  #   5;     	� 5C     -   5        $
 	baocaoBtn��5C  &   ��5D     �� 5E  "   " 	�6(   .�5F  &   ��  � ��$ Center=�6Q   �� 5G  &    � �� 5H  *   �� 5I  .   " 	�6>   .R�5K  2   �� $ 
Horizontal=�6>   .+�5L  6   �� $ boder��6=   $��80��6L   $��5��6X   
����� �$ 0Q�6u     5M  6   $��25��6C   $ 	FileExcel=�6N   $��	20,0,20,0q�6_   $��30��6r   
 ��� �6~   �� 5N  6   $��	Báo cáo��6<   
�������$��Roboto)�6a   $��16(�6u   $��Center=�6�   ��5O  6   �� 5P  :   $	 0,0&�6N   $	 0,1&�6_   .��5Q  >   � $ Black��6K   $ 0Q�6Z   � 5R  >   $ Purple��6K   $ 1Q�6Z   5S  ;   5U  3    5W  2   P� 5X  6    �@d�	IsChecked$
 TrueY�6S   . �5Y  :   �� $ boder��6A    �@J�Opacity$ 1Q�6g   5Z  7   5^  /   5`  '   5a  #   5c     5m     5n     �� 5w     $��1��6   ._�5x     �  � RowDefinitions 5y     �� 5z     $��35 �6,   �� 5{     $��35 �6,   �� 5|     $��* �6,   .+�5     �� -	   5         ��Name$ ctrBar��5  n   $ 
Horizontal=�6%   $��RightToLeft=�6>   
������$��0��6�   .+�5�     �� $��10,0,0,0q�6%   
���  ��$��0q�6H   $ 50��6\   $��20��6n   $��20��6y   ._�5�  "   �� -
   5         ��Name$ closeBtn��5�  )   $��Center=�6R   $��Center=�6m   ��5�  &   �� 5�  *   " ��60   .�5�  .   ��  �@�OverridesDefaultStyle .  6V   �� 5�  .    � ��
 ���� 6K   �� 5�  .    � ��
 ���� 6L   �� 5�  .    � �� 5�  2   �� 5�  6   " ��6F   .R�5�  :     $ Xmark=�6G   
 �����$��10��6g   $��10��6s   5�  7   5�  /   5�  +   5�  #   5�     �� 5�     $��10,0,0,0q�6%   
��� � �$��0q�6J   $ 50��6^   $��20��6p   $��20��6{   ._�5�  "   �� -   5        $ minBtn��5�  )   $��Center=�6O   $��Center=�6j   ��5�  &   �� 5�  *   " ��60   .�5�  .   ��  �@�OverridesDefaultStyle .  6V   �� 5�  .    � ��
 ���� 6K   �� 5�  .    � ��
 ���� 6L   �� 5�  .    � �� 5�  2   �� 5�  6   " ��6F   .R�5�  :     $ Minus=�6G   
 �����$��10��6g   $��10��6s   5�  7   5�  /   5�  +   5�  #   5�     5�     �� 5�     $��1��6%   64    � 5�     -   5          �Name$ 	mainFrame��5�      $��2��63   5�     5�     5�     5�     5�     5�     5�     