   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:AirlineLenz.Windows.AccessRightWindow%AirlineLenz.Windows.AccessRightWindow  5   	   A    ;AirlineLenz.Windows.AccessRightWindow.EditAccessRightWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:AirlineLenz.Windows.AccessRightWindow     5   	     � Title$:  4Редактирование прав доступа��5   	   $	��450��6-   $	��800��6:   .��5      � -   5         �Name$ AccessRightGridItem��5      $��10q�6)    � RowDefinitions 5   
   �� 5      $��0.90* �6   6-   �� 5      $��0.10* �6   6-    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AccessRightGrid��5         CanUserAddRows$ False��6,      AutoGenerateColumns$ False��6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6&   	   Header$!	 Название формы��6Q   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Form+6j   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $	 Чтение��6B   $
 * 6S    6)   �� *Read+6S     5      $	 Запись��6C   $
 * 6T    6)   �� *Write+6T     5      $"	 Редактирование��6B   $
 * 6[    6)   �� *Edit+6[     5      $	 Удаление��6D   $
 * 6V    6)   �� *Delete+6V   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5       �� -   5         ��Name$ SaveAccessRightButton��5       $��Сохранить��64   $	��100��6k   $��25��6w   �� 5!      $<��6Редактирование пользователя:��6   $��Center=�6;   $
��Auto��6V   �� 5"      -   5         ��Name$ UserEmailTextBox��5"       �� TextWrapping$
 Wrap=�60    �� 
IsReadOnly$
 True��6D   $��Center=�6V   $	��120��6q   ��5#      ��  �� Path$ 
User.Email�5$      5%      5'      