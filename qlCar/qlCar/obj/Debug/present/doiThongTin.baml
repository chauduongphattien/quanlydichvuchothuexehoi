   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5   	       qlCar.present.doiThongTin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:qlCar.present     5   	   
������ $��0q�5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � Title$ doiThongTin��5   	   $	��450��6   $	��800��6*   .��5      �� $��0q�6    �� CornerRadius$ 25��6!   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ Black��6   $	 0.6Q�6-   � 5      $ White��6   $ 1Q�6-   5      ._�5   
   � 	 � RowDefinitions	 5      �� 5      $	��150 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��1* �6    .+�5      �� $��0��6   ._�5       �� -   5        
 ��Name$
 ctrbar��5"   <   $��Change��5       
�������$��50(�6<   $��Italic$�5!      $��Heavy"�6+   $��Center=�6>   $��Center=�5"      5#      5$      �� 5%      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   .+�5&      �� $��Email: ��6   
�������$��Center=�5'      $��Center=�5(      $��30(�6<   $��	0,10,0,10q�6J   �� 5)      -   5         ��Name$ mailBox��5)      
�������
������ $��1,0,0,1q�5*      $	��300��64   $��Center=�5+      �� 5,      $��(@gmail.com)��6   
�������$��Center=�5-      $��Center=�5.      $��20(�6<   $��Italic$�6J   $��	0,10,0,10q�6]   5/      �� 50      $��2��6   $ 
Horizontal=�6&   $��Center=�6?   .+�51      �� $��Điện thoại: ��6   
�������$��Center=�52      $��Center=�53      $��30(�6<   $��
0,10,60,10q�6J   �� 54      -   5        $ phoneBox��54      
�������
������ $��1,0,0,1q�55      $	��300��64   $��Center=�56      58      �� 59      $��0,40,0,0q�6   $ 
Horizontal=�6+   $��Center=�5:      $��3��5;      .+�5<      �� -   5         ��Name$ okBut��5>      $	��100��5<      $��OK��6%   $��30(�62   $
��Bold"�6@   
�������$��0q�5@      $��	0,0,300,0q�5A      $��50��5B      
���   �5C      �� 5D      -   5        $ canelBut��5H      $	��100��5D      $��Canel��6%   $��30(�65   $
��Bold"�6C   
���   �$��50��5F      $��0q�5G      
�������5J      5K      5L      5O      5Q      