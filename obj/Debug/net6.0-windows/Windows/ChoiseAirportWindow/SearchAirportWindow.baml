   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:AirlineLenz.Windows.ChoiseAirportWindow'AirlineLenz.Windows.ChoiseAirportWindow  5   	   A    ;AirlineLenz.Windows.ChoiseAirportWindow.SearchAirportWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:AirlineLenz.Windows.ChoiseAirportWindow     5   	     � Title$#  Поиск аэропорта��5   	   $	��450��6!   $	��800��6.   .��5
      �� $��1��6    �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   .+�5   
   �� $��
Поиск��6   $��Center=�6    $��50��6;   �� 5   
   -   5         ��Name$ SearchTextBox��5      $
��Left=�6)    �� TextWrapping$
 Wrap=�6D   $��Center=�5   "   $	��300��6=   �� 5   
   -   5        $��Искать��5      $	��100��6<   $��25��6H   5      �� 5   
   .+�5      � -   5         �Name$ AirportGridItem��5      $��10q�6.    � RowDefinitions 5   
   �� 5      $��0.90* �6   6-   �� 5      $��0.10* �6   6-    � ColumnDefinitions 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ AirportGrid��5         
IsReadOnly$
 True��60   	   AutoGenerateColumns$	 False��6B   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6P     5       $ 
Город��6>   $ * 6M    6%   �� *City+6M     5!      $ Страна��6A   $ * 6Q    6%   �� *	Country+6Q   5$      �� 5%   
   $��1��6   $ 
Horizontal=�6"   .+�5&      �� -   5         ��Name$ ChoiseButton��5&      $��Выбрать��63   $	��100��6_   $��25��6k   5(      5)      5*      5+      5,      