   M S B A M L   `   `   `  ����>  :APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:APP.UserControlsAPP.UserControls  5   	       APP.View.LoginView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -ucclr-namespace:APP.UserControls     5   	     � Title$  	LoginView��5   	    � WindowStyle$
 None=�5	   
   $	��650��5
   	   $	��650��6    � AllowsTransparency$
 True��5   	   
������ .��5      ��  �� Padding$ 20q�6   ���#ffffff �� CornerRadius$ 
0 25 25 0 ��6/   ._�5   
   � .+�5      �� $��/Images/closes.png��6   $��25��60   $��0 4 5 0q�6;      iconApp#��[  6L   �� 5      $��/Images/minimizesign.png��6   $��25��66   $��0 7 50 0q�6A   #��[  6T   � 5      $��Center=�6   $��Center=�6.   $��	 0 10 0 0q�6K    � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��	User Name��6   $��0��6-     text#��[ 6:   �� 5       $��	Password ��6   $��1��6-   #��[ 6:       APP.UserControls.MyTextbox  5!      $��1��6   $��0��6/      Hint$ 	User Name��6<     5"      $��1��6   $��1��6/   $ Password��6<   �� 5$       �� Orientation$ 
Horizontal=�6   $��1��67   $��2��6G   $�� 0 10q�6T   .+�5%      !   APP.UserControls.MyCheckbox  	   Icon$	 CheckCircleOutline=�6$   
   Text$
 Display password��6?   5&      � 5(      $��1��6   $��3��6'   $��0 40 0 0q�64    5)      �� 5*      $��* �6+   �� 5+      $��* �6+   .+�5.      �� $��Cancel��6   $��	 0 0 10 0q�6.     
buttonMain#��[ 6A   6g   �� 5/      $
��Save��6   $��	 10 0 0 0q�6,   $��1��6?     buttonMainGreen#��[ 6O   6{   50      52      53      54      56      