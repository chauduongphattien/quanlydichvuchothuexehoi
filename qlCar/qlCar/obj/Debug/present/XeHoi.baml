   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5          qlCar.present.XeHoi   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      'localclr-namespace:qlCar.present  5      .��5
      � .+�5   
   �   � RowDefinitions  5      �� 5      $��40 �6    �� 5      $��1* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   .+�5      �� -   5         ��Name$ comboTrangthai��5      $��50��63   $��20��6>   $��20,0,0,0q�6J   5      �� 5      $��Trạng thái��6   
�������$��Center=�6@   $
��Bold"�6b   $��10(�6t   $��	Open Sans)�6�   �� 5      -   5        $ comboboxSoghe��5      $	��100��62   $��20��6>   $��40,0,0,0q�6J   5      �� 5      $��
Số ghế��6   
�������$��Center=�6<   $
��Bold"�6^   $��10(�6p   $��	Open Sans)�6~   �� 5      -   5         ��Name$ 
timkiemBut��5   ^   $��60��6   $��20��6$   
������ $��20,10,10,10q�6I   .��5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ MagnifyingGlass=�6#      
Foreground
 �����6:   5      5      �� 5#      $��1��6   $
��Auto=�6)   $
��Auto=�5$      .��5%      �� -   5         ��Name$ listViewXeHoi��5%   .   
������� �� View 5&      �� 5'      ! �� ColumnHeaderContainerStyle 5)      �� 5*   "   	 �� 
TargetType"	 ��6(   .�5+   &   �� 
 �� Property
 � �� �� Value
 �� ��6C   �� 5,   &   
 � ��
 �����6C   �� 5-   &   
 � ��$ Medium"�6C   �� 5.   &   
 � ��$ 8(�6A   �� 5/   &   
 � ��$ 
Monsterrat)�6C   �� 50   &   
 � ��$ Center=�6S   52   #   .P�5:      �� $��bien so��6-    �� Width$	 100��6f    �� DisplayMemberBinding 6>   �� *bienSo+6f   �� 5;      $��Hang Xe��6-   $	 100��6f    6>   �� *HangXe+6f   �� 5<      $��Mauf sac��6-   $	 100��6g    6?   �� *MauSac+6g   �� 5=      $��So ghe��6-   $	 100��6d    6=   �� *SoGhe+6d   �� 5>      $��nam san xuat��6-   $	 100��6o    6C   �� *
namsanxuat+6o   �� 5?      $��
trang thai��6-   $	 100��6l    6A   �� *	TrangThai+6l   �� 5@      $��gia thue��6-   $	 100��6h    6?   �� *	GiaThue+6h   �� 5A      $ 70��6-    �� CellTemplate 5B   "   �� 5C   &   .R�5D   *   �� $��0q�61   ._�5E   .   �� -   5        
������ $��0q�5E   N   ��6w   �� .��5F   2     $
 Gear=�6?   
 �����$��20��6]   5G   /   5H   +   5I   '   5K      �� 5N      $ 70��6-    5O   "   �� 5P   &   .R�5Q   *   �� $��0q�61   ._�5R   .   �� -   5        
������ $��0q�5R   N   ��6y   �� .��5S   2     $ HandHoldingDollar=�6?   
 �����$��20��6j   5T   /   5U   +   5V   '   5X      5Y      5[      5\      5]      5^      5_      