   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AirlineLenz.Windows.FlightWindow AirlineLenz.Windows.FlightWindow  7    1AirlineLenz.Windows.FlightWindow.EditFlightWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:AirlineLenz.Windows.FlightWindow       � Title$-  'Редактирование рейса��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� .+��� $	��350��.+��� $ 
Horizontal=�.+��� $��Название��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ Flight.Title��� -   $��Сохранить��$	��100���� $��10q�$
��Auto��.+��� $ 
Horizontal=�$��Center=�.+��� -   $��Изменить��$
��Auto��&   System.Windows.Controls.DataGrid  -     Name$ 	RouteGrid��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Шифр��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Id+  $# Начальный пункт��$
	 auto 
 �� *StartingPoint.Name+  $! Конечный пункт��$
	 auto 
 �� *EndingPoint.Name+