   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          qlCar.present.BaoCao   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:qlCar.present     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .��5      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��4* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   
������ ._�5      �� $��	Báo cáo��6   
����� �$��20(�68   $��Center=�6F   $��Center=�5      5      �� 5   
   $
��Auto=�6   $	��450��6<   $	��900��6I   $
��Auto=�5      $��1��6:   .��5      �� -   5         ��Name$ listBC��5   0   
������  �� SelectionMode$ Single=�6@   ��5       �� 5!       �� 
TargetType" ��6   .�5"      ��  �� Property � �� �� Value
 �����67   �� 5#       � ��$ 15(�65   �� 5$       � ��$ Center=�6G   5%       �� View 5(      �� 5)      ! �� ColumnHeaderContainerStyle 5*      �� 5+      " ��6$   .�5,   "   ��  � ��
 ���� 6?   �� 5-   "    � ��
 �����6?   �� 5.   "    � ��
 �   �6@   5/      .P�52      �� $��
ma bao cao��6M    �� Width$	 100��6a   	 �� DisplayMemberBinding	 6)   �� *id+6a   �� 53      $��tong xe��6T   $	 100��6e   	 6)   �� *
tongSoXe+6e   �� 54      $��
xe da thue��6U   $	 100��6i   	 6)   �� *
soXeDaThue+6i   �� 55      $��
xe bao tri��6Y   $	 100��6m   	 6)   �� *soxeDangBaoTri+6m   �� 56      $��
xe con lai��6U   $	 100��6i   	 6)   �� *
soxeConLai+6i   �� 57      $��tong doanh thu��6R   $	 100��6j   	 6)   �� *	DoanThu+6j   �� 58      $��ngay bao cao��6U   $	 100��6k   	 6)   �� *
NgayBaoCao+6k   59      5;      5<      �� 5>   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��RightToLeft=�6;   .+�5?      �� $��20,0,0,0q�6   $��0q�6'   
���� ��$	��100��6O    �� CornerRadius$ 9��6[   $��30��6l   ._�5@      �� -   5         ��Name$ xuatvalubaocao��5A      $��Xuất báo cáo��5@      
������ 
�������$��0q�5C   ,   5D      �� 5E      $��10,0,0,0q�6   $��0q�6'   
���� ��$	��100��6O   $ 9��6[   $��30��6l   ._�5F      �� -   5        $ 
thembaocao��5G      $��them moi��5F      
������ 
�������$��0q�5I   ,   5J      �� 5L      $��	500,0,0,0q�6   $��0q�6(   
���� ��$	��100��6P   $ 9��6\   $��30��6m   ._�5M      �� -   5        $ 	bieudoBut��5N      $��Thống kê biểu đồ��5M      
������ 
�������$��0q�5Q   ,   5R      (  "System.Windows.Controls.DatePicker  5S      $��30��6   $��20,0,0,0q�6%   5V      5W      5X      