   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AirlineLenz.Windows.CrewWindowAirlineLenz.Windows.CrewWindow  3    -AirlineLenz.Windows.CrewWindow.EditCrewWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:AirlineLenz.Windows.CrewWindow       � Title$1  +Редактирование экипажа��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� .+��� $	��350��.+��� $ 
Horizontal=�.+��� $��Название��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ 
Crew.Title��� -   $��Сохранить��$	��100���� $��10q�$
��Auto��.+��� $ 
Horizontal=�$��Center=�.+��� -   $��Добавить��$
��Auto���� -   $��Удалить��$
��Auto��&   System.Windows.Controls.DataGrid  -     Name$ FlightCrewGrid��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *	FirstName+  $ Фамилия��$
	 auto 
 �� *
LastName+  $ Отчество��$
	 auto 
 �� *
Patronymic+  $ Должность��$
	 auto 
 �� *EmployeeType+