   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AirlineLenz.Windows.DepartureWindow#AirlineLenz.Windows.DepartureWindow  =    7AirlineLenz.Windows.DepartureWindow.EditDepartureWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AirlineLenz.Windows.DepartureWindow       � Title$/  )Редактирование вылета��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� .+��� $	��350��.+��� $ 
Horizontal=�.+��� $��Время вылета��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker  $��Center=�$��Center=�$	��120��   Text ��  �� Path$ Departure.DepartureTime� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+��� $'��!Время приземления��$
��Left=�$��Center=�$	��160��  $��Center=�$��Center=�$	��120�� �� $ Departure.ArrivalTime�$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�.+��� $��Лайнер��$
��Left=�$��Center=�$	��160���� -    ��Name$ LinerTextBox�� �� TextWrapping$
 Wrap=� �� 
IsReadOnly$
 True��$��Center=�$	��120������ $ Departure.Liner.Name��� -   $��Выбрать���� $ 
Horizontal=�.+��� $��Экипаж��$
��Left=�$��Center=�$	��160���� -   $ CrewTextBox��$
 Wrap=�$
 True��$��Center=�$	��120������ $ Departure.Crew.Title��� -   $��Выбрать���� -   $��Сохранить��$	��100���� $��10q�$
��Auto��.+��� $ 
Horizontal=�$��Center=�.+��� -   $��Изменить��$
��Auto��&   System.Windows.Controls.DataGrid  -   	  Name$	 
FlightGrid��
   AutoGenerateColumns$
 False��   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Название��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Title+  $ Шифр маршрута��$
 auto  �� *
Route.Id+  $# Начальный пункт��$
 auto  �� *Route.StartingPoint.Name+  $! Конечный пункт��$
 auto  �� *Route.EndingPoint.Name+