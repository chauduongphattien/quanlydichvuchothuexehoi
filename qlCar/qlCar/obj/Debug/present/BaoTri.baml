   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5          qlCar.present.BaoTri   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      'localclr-namespace:qlCar.present  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   
������ ._�5      �� $$��Danh sách xe đang bảo trì��6   
���  ��$��25(�6J   $��Center=�5      $
��Bold"�5      5      �� 5   
   $
��Auto=�6   $
��Auto=�5      $	��500��5      $	��900��6$   $��1��60   .��5      �� -   5         ��Name$ listviewBaotri��5   0   
������  �� SelectionMode$ Single=�6H   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����67   �� 5       � ��$ 15(�65   5        �� View 5%      �� 5&      ! �� ColumnHeaderContainerStyle 5'      �� 5(      " ��6$   .�5)   "   ��  � ��
 ���� 6?   �� 5*   "    � ��
 �����6?   �� 5+   "    � ��$ 1q�6D   �� 5,   "    � ��
 �   �6@   5-      .P�50      �� $��
Ma bao tri��6)    �� Width$	 100��6=   	 �� DisplayMemberBinding	 6I   �� *Ma_BT+�� 51      $��biển số xe��6)   $	 100��6=   	 6I   �� *SoXe+�� 52      $��Ngay bao tri��6)   $	 100��6?   	 6K   �� *
NgayBatDau+
 �� StringFormat$
 {0:dd/MM/yyyy}���� 53      $��ngay ket thuc��6)   $	 100��6@   	 6L   �� *ngayKetThuc+$
 {0:dd/MM/yyyy}���� 54      $��chi phi��6)   $	 100��6:   	 6F   �� *chiphi+58      5:      5;      � 5<   
   $��2��6    � ColumnDefinitions 5=      �� 5>      �� 5?      .+�5A      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5B      �� $��
Chi tiết��6   
�������$��20,0,0,0q�6>   �� 5C      -   5         ��Name$ tBInfor��5C   H   $	��400��6   $	��100��6(   $��10,0,0,0q�65   
�������$��15(�6l   5D      �� 5F      $��Center=�6   $��Center=�64   $��1��6Q   $ 
Horizontal=�6a   .+�5G      �� 
���� �� �� CornerRadius$ 10��6-   $��0q�6?   ._�5H      �� -   5         ��Name$ xemthongtinbut��5J      $	��xem��5H      $��80��6+   $��30��66   $��15(�6B   
�������
������ $��0q�5L      5M      �� 5P      $��	20,0,20,0q�6   
����� �$ 10��6B   $��0q�6T   ._�5Q      �� -   5        $ demxebaotri��5S      $��số lượng��5Q      $	��100��60   $��30��6<   $��15(�6H   
�������
������ $��0q�5U      5V      �� 5X      $��0,0,20,0q�6   
����� �$ 10��6A   $��0q�6S   ._�5Y      �� -   5        $ 
hoantatbtn��5[      $��Hoàn tất��5Y      $	��100��60   $��30��6<   $��15(�6H   
�������
������ $��0q�5]      5^      5b      5c      5d      5e      