   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AirlineLenz.Windows.PassengerWindow#AirlineLenz.Windows.PassengerWindow  5   	   ?    9AirlineLenz.Windows.PassengerWindow.SearchPassengerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AirlineLenz.Windows.PassengerWindow     5   	     � Title$#  Поиск пассажира��5   	   $	��450��6!   $	��800��6.   .��5	      �� $��1��6    �� Orientation$ Vertical=�6   .+�5
   
   �� $ 
Horizontal=�6   .+�5      �� $��
Поиск��6   $��Center=�6$   $��50��6?   �� 5      -   5         ��Name$ SearchTextBox��5      $
��Left=�6-    �� TextWrapping$
 Wrap=�6H   $��Center=�5   "   $	��300��6=   �� 5      -   5        $��Искать��5      $	��100��6@   $��25��6L   5      �� 5   
   .+�5      � -   5         �Name$ AirportGridItem��5      $��10q�6.    � RowDefinitions 5      �� 5      $��0.90* �6$   65   �� 5      $��0.10* �6$   65    � ColumnDefinitions 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ PassengerGrid��5         
IsReadOnly$
 True��62   	   AutoGenerateColumns$	 False��6D   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	FirstName+6X     5      $ Фамилия��6J   $ * 6[    6-   �� *
LastName+6[     5       $ Отчество��6L   $ * 6^    6-   �� *
Patronymic+6^     5!      $ 
Серия��6P   $ * 6_    6-   �� *PassportSeries+6_     5"      $ 
Номер��6L   $ * 6[    6-   �� *
PassportId+6[     5#      $! Дата получения��6M   $ * 6e    6-   �� *DateOfIssue+6e     5$      $ Кем выдан��6J   $ * 6]    6-   �� *
IssuedBy+6]   5'      �� 5(      $��1��6   $ 
Horizontal=�6*   .+�5)      �� -   5         ��Name$ ChoiseButton��5)      $��Выбрать��63   $	��100��6_   $��25��6k   5*      5+      5,      5-      5.      