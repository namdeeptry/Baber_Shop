   M S B A M L   `   `   `  ����>  :APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:APP.ViewModelAPP.ViewModel  5   	   -clr-namespace:APP.UtilitiesAPP.Utilities  5   	       APP.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *vmclr-namespace:APP.ViewModel     5   	   ,Menuclr-namespace:APP.Utilities     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � AllowsTransparency$
  True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������ $	��600��5   	   $	��850��6   .��5      � .+�5   
   �� ���#212529 �� CornerRadius$ 20��6&   � 5   
    � RowDefinitions 5      �� 5      -   5        $��35 �5       6,   �� 5      $��* �6    .+�5      � $��0��6   $��Right=�5      $	��Top=�5      $��0,0,10,0q�5       $��35��5!      .+�5"      ��  �� Orientation$ 
Horizontal=�6   .+�5#      �� $
��🗕��6   $��30��5$      $��30��6(      WindowControlButtonStyle#��[  5'      ��5%      �� *MinimizeWindowCommand+��5&      ��  �� RelativeSource ��  �� AncestorType
 Window5'      �� 5(      $
��🗖��6   $��30��5)      $��30��6(   #��[  5,      ��5*      �� *MaximizeRestoreWindowCommand+��5+      ��  �� 
 Window5,      �� 5-      $	��✖��6   $��30��5.      $��30��6(   #��[  51      ��5/      �� *CloseWindowCommand+��50      ��  �� 
 Window51      52      53      � 56      $��1��6    � ColumnDefinitions 57      �� 58      $	��228 �6'   �� 59      $��* �6'   .+�5=      � $��0��6   .+�5>      �� ���#272B2F$ 	20,0,0,20��62   �� 5?      .+�5A      ��   SidebarButtonStyle#��[ 6!   ��5B   !   �� *ShowHomeViewModel+.��5C      �� $ 
Horizontal=�6)   .+�5D   "   "  FontAwesome.WPF.ImageAwesome  	   Icon$
	 Home=�62   $��18��6>   $��18��6I   
   
Foreground
 �#00FFFF$��0,0,10,0q�6j   �� 5E   "   $
��Home��6,   $��Center=�68   5F      5G      �� 5H      #��[ 6!   ��5I   !   �� *ShowCustomersViewCommand+.��5J      �� $ 
Horizontal=�6)   .+�5K   "     $
	 User=�62   $��18��6>   $��18��6I   
 �#00FFFF$��0,0,10,0q�6j   �� 5L   "   $��	Customers��6,   $��Center=�6=   5M      5N      �� 5O      #��[ 6!   ��5P   !   �� *ShowAppointmentsViewCommand+.��5Q      �� $ 
Horizontal=�6)   .+�5R   "     $	 Calendar=�62   $��18��6B   $��18��6M   
 �#00FFFF$��0,0,10,0q�6n   �� 5S   "   $��Appointments��6,   $��Center=�6@   5T      5U      �� 5V      #��[ 6!   ��5W   !   �� *ShowStaffsViewCommand+.��5X      �� $ 
Horizontal=�6)   .+�5Y   "     $	 Users=�62   $��18��6?   $��18��6J   
 �#00FFFF$��0,0,10,0q�6k   �� 5Z   "   $��Staffs��6,   $��Center=�6:   5[      5\      �� 5]      #��[ 6!   ��5^   !   �� *ShowServicesViewCommand+.��5_      �� $ 
Horizontal=�6)   .+�5`   "     $
	 Cogs=�62   $��18��6>   $��18��6I   
 �#00FFFF$��0,0,10,0q�6j   �� 5a   "   $��Services��6,   $��Center=�6<   5b      5c      �� 5d      #��[ 6!   ��5e   !   �� *ShowInvoicesViewCommand+.��5f      �� $ 
Horizontal=�6)   .+�5g   "     $	 FilePdfOutline=�62   $��18��6H   $��18��6S   
 �#00FFFF$��0,0,10,0q�6t   �� 5h   "   $��Invoices��6,   $��Center=�6<   5i      5j      �� 5k      #��[ 6!   ��5l   !   �� *ShowReportsViewCommand+.��5m      �� $ 
Horizontal=�6)   .+�5n   "     $	 BarChart=�62   $��18��6B   $��18��6M   
 �#00FFFF$��0,0,10,0q�6n   �� 5o   "   $��Reports��6,   $��Center=�6;   5p      5q      �� 5r      #��[ 6!   ��5s   !   �� *ShowSettingsViewCommand+.��5t      �� $ 
Horizontal=�6)   .+�5u   "     $		 Cog=�62   $��18��6=   $��18��6H   
 �#00FFFF$��0,0,10,0q�6i   �� 5v   "   $��Settings��6,   $��Center=�6<   5w      5x      5y      5z      � 5}      $��1��6   $��5q�6'   .+�5~      �� $��Stretch=�5   %   $��Stretch=�5�   %   ��5~   %   �� *CurrentView+5�   %   5�      5�      5�      5�      5�      