   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AirlineLenz.Windows.RouteWindowAirlineLenz.Windows.RouteWindow  5    /AirlineLenz.Windows.RouteWindow.EditRouteWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:AirlineLenz.Windows.RouteWindow       � Title$3  -Редактирование маршрута��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� .+��� $	��350��.+��� $ 
Horizontal=�.+��� $#��Начальный пункт��$
��Left=�$��Center=�$	��160���� -    ��Name$ StartingPointTextBox�� �� 
IsReadOnly$
 True�� �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ Route.StartingPoint.Name��� -   $��Выбрать���� $ 
Horizontal=�.+��� $!��Конечный пункт��$
��Left=�$��Center=�$	��160���� -   $ EndingPointTextBox��$
 True��$
 Wrap=�$��Center=�$	��120������ $ Route.EndingPoint.Name��� -   $��Выбрать���� -   $��Сохранить��$	��100���� $��10q�$
��Auto��.+��� $ 
Horizontal=�$��Center=�.+��� -   $��Добавить��$
��Auto���� -   $��Удалить��$
��Auto��&   System.Windows.Controls.DataGrid  -     Name$ WayPointGrid��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$-
 'Промежуточные пункты��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+