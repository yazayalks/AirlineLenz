   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AirlineLenz.Windows.DepartureWindow#AirlineLenz.Windows.DepartureWindow  5   	   =    7AirlineLenz.Windows.DepartureWindow.EditDepartureWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AirlineLenz.Windows.DepartureWindow     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6I     � Title$/  )Редактирование вылета��5   	   $	��450��6'   $	��800��64   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� .+�5      �� $	��350��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Время вылета��6   $
��Left=�63   $��Center=�6N   $	��160��6i   &   Xceed.Wpf.Toolkit.DateTimePicker  5      $	��120��6*   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�66      FormatString$ dd/MM/yyyy hh:mm tt��6F   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 6k   ��  �� Path$ Departure.DepartureTime� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   .+�5      �� $'��!Время приземления��6   $
��Left=�68   $��Center=�6S   $	��160��6n     5      $	��120��6*   $ Custom=�66   $ dd/MM/yyyy hh:mm tt��6F    6k   �� $ Departure.ArrivalTime�$ TwoWay=�$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Лайнер��6   $
��Left=�6-   $��Center=�6H   $	��160��6c   �� 5      -   5         ��Name$ LinerTextBox��5      	 �� TextWrapping$
	 Wrap=�64   
 �� 
IsReadOnly$

 True��6H   $��Center=�6Z   $	��120��6u   ��5      �� $ Departure.Liner.Name��� 5      -   5        $��Выбрать��5      6/   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Экипаж��6   $
��Left=�6-   $��Center=�6H   $	��160��6c   �� 5      -   5        $ CrewTextBox��5      $
	 Wrap=�63   $

 True��6G   $��Center=�6Z   $	��120��6u   ��5      �� $ Departure.Crew.Title��� 5       -   5        $��Выбрать��5       6/   5!      �� 5$      -   5        $��Сохранить��5$      $	��100��6@   5%      5&      �� 5'   
   $��10q�6   $
��Auto��6!   .+�5(      �� $ 
Horizontal=�6   $��Center=�62   .+�5)      �� -   5        $��Изменить��5)      $
��Auto��6I   5*      &   System.Windows.Controls.DataGrid  5+      -   5          Name$ 
FlightGrid��5+         AutoGenerateColumns$ False��6+      
IsReadOnly$
 True��6G      Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5.   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5-   )   �� *Title+5.   )     5/      $ Шифр маршрута��6F   $
 auto 50   )    5/   )   �� *
Route.Id+50   )     51      $# Начальный пункт��6V   $
 auto 52   )    51   )   �� *Route.StartingPoint.Name+52   )     53      $! Конечный пункт��6T   $
 auto 54   )    53   )   �� *Route.EndingPoint.Name+54   )   56      57      58      59      