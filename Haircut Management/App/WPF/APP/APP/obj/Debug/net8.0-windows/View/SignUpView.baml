   M S B A M L   `   `   `  ����>  :APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:APP.UserControlsAPP.UserControls  5   	       APP.View.SignUpView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   'ucclr-namespace:APP.UserControls  5   	   -   5          �Name$  SignUp��5	   	    � AllowsTransparency$
 True��5
   	   $	��650��5   	   $
��1000��6   
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � 
������  � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   �� ���#ffd500 �� Padding$ 30q�6'   $��0q�65    �� CornerRadius$ 	25 0 0 25��6I   ._�5      �� $��Center=�6   .+�5      �� $��\Images\Logo_Login.png��6   $	��160��68   $	��160��6D   $��0,0,0,40q�6Q   �� 5      $�� Let's  get you sey up ��6    �� TextAlignment$ Center=�6;   $��SemiBold"�6R   $��28(�6h   ���#3636366�   �� 5      $
��Wrap=�6   $ Center=�61   $��16(�6H   ���#363636$��	0 20 0 20q�6k   $F��@ it should only take a couple of minutes to pair with you watch ��6~   6�   �� 5         ButtonBLack#��[  6   ��6>   �� *LoginChanged+��6_   ��  �� ElementName$ SignUp��.��5      "  FontAwesome.WPF.ImageAwesome  	   Icon$	 
AngleRight=�6&   $��25��68   $��25��6C   
   
Foreground
 �#ffd500$��3 0 0 0 q�6d   6y   5      5      5       �� 5$   
   -   5         ��Name$ 
RightPanel��5$      $��1��6%   $ 20q�66   ���#ffffff$ 
0 25 25 0 ��6X   ._�5%      � .+�5&      �� $��/Images/closes.png��6   $��25��64   $��0 4 5 0q�6?     iconApp#��[ 6P   �� 5'      $��/Images/minimizesign.png��6   $��25��6:   $��0 7 50 0q�6E   #��[ 6X   � 5(      $��Center=�6   $��Center=�62   $��	 0 10 0 0q�6O    5)      �� 5*      $	��150 �6+   �� 5+      $��* �6+    � RowDefinitions 5.      �� 5/      $
��Auto �6(   �� 50      $
��Auto �6(   �� 51      $
��Auto �6(   �� 52      $
��Auto �6(   �� 53      $
��Auto �6(   �� 54      $
��Auto �6(   �� 55      $
��Auto �6(   �� 56      $
��Auto �6(   .+�59      �� $
��Name��6    $��0��6,     text#��[ 69   �� 5:      $��Family ��6    $��1��6/   #��[ 6<   �� 5;      $��Gender��6    $��2��6.   #��[ 6;   �� 5<      $��Date of Birth ��6    $��3��66   #��[ 6C   �� 5=      $��Email��6    $��4��6-   #��[ 6:   �� 5>      $��Mobile��6    $��5��6.   #��[ 6;   �� 5?      $��
Membership��6    $��6��62   #��[ 6?       APP.UserControls.MyTextbox  5A      $��1��6#   $��0��63      Hint$
 Name��6@     5B      $��1��6#   $��1��63   $ (Not Require)��6@     5C      $��1��6#   $��3��63   $ 
02/01/1980��6@     5D      $��1��6#   $��4��63   $ Ex: Email@gmail.com��6@     5E      $��1��6#   $��5��63   $ +03x xxx xxxx��6@   �� 5G       �� Orientation$ 
Horizontal=�6!   $��1��6;   $��2��6K   $�� 0 10q�6X   .+�5H         APP.UserControls.MyOption     Icon$
 Male=�6*      Text$
 Male��67     5I      $ Female=�6*   $ Female��69   5J      �� 5L      $ 
Horizontal=�6!   $��1��6;   $��6��6K   $�� 0 10q�6X   .+�5M        $ 
CreditCard=�6*   $ Classic ��6=     5N      $ 
CreditCard=�6*   $ Silver ��6=     5O      $ 
CreditCard=�6&   $ Gold ��69   5P      � 5R      $��1��6   $��7��6+   $��0 40 0 0q�68    5S      �� 5T      $��* �6/   �� 5U      $��* �6/   .+�5X      �� $��Cancel��6!   $��	 0 0 10 0q�62     
buttonMain#��[ 6E   6k   �� 5Y      $
��Save��6!   $��	 10 0 0 0q�60   $��1��6C     buttonMainGreen#��[ 6S   6   5Z      5\      5]      5^      5a      5b      