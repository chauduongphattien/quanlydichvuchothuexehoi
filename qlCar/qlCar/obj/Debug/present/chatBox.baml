   M S B A M L   `   `   `  ����@  <qlCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:qlCar.presentqlCar.present  5   	       qlCar.present.chatBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   'localclr-namespace:qlCar.present  5   	   
������   � WindowStyle$
  none=�5
   	    � WindowStartupLocation$ CenterScreen=�5   
    � AllowsTransparency .  � Title$ chatBox��5   	   $	��500��6   $	��600��6&   .��5      ��  �� CornerRadius$ 20��6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $��20 �6    �� 5      $��1* �6    �� 5      $��80 �6    .+�5      �� -   5         ��Name$ ctrBar��5      $��0��5      
����� �._�5      �� $��RightToLeft=�6    �� Orientation$ 
Horizontal=�69   $��Center=�6R   .+�5      �� -   5         ��Name$ close��5      
������ $��40��5   6   .��5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 X=�6'   
   
Foreground

 �  ��60   5      �� 5      -   5        $	 min��5       
������ $��30��5   6   $��20,0,0,0q�6B   .��5"        $	 Minus=�6'   

 �����64   5#      5$      5%      �� 5(      $��1��6   $
��Auto=�6*   .��5)      �� -   5         ��Name$ 	container��5)      5+      5,      �� 5-      
�������$��2��6-   $ 
Horizontal=�6:   $��Center=�6S   .+�5.      �� -   5         ��Name$ 
contentMes��5/      $��50��5.      $	��540��6&   
������ $��Center=�6K   5/      �� 50      -   5        $ dendBut��51      
������ $��70��50   2   $��0q�6=   .��53        $	 
PaperPlane=�6#   

 �   �$��30��6H   54      55      56      57      58      