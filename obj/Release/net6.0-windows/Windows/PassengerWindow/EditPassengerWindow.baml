   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AirlineLenz.Windows.PassengerWindow#AirlineLenz.Windows.PassengerWindow  =    7AirlineLenz.Windows.PassengerWindow.EditPassengerWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AirlineLenz.Windows.PassengerWindow       � Title$5  /Редактирование пассажира��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� $	��300��.+��� $ 
Horizontal=�.+��� $��Имя��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ Passenger.FirstName��� $ 
Horizontal=�.+��� $��Фамилия��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Passenger.LastName��� $ 
Horizontal=�.+��� $��Отчесвто��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Passenger.Patronymic��� $ 
Horizontal=�.+��� $��
Серия��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Passenger.PassportSeries��� $ 
Horizontal=�.+��� $��
Номер��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Passenger.PassportId��� $ 
Horizontal=�.+��� $��Дата выдачи��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker     SelectedDateFormat$ Short=�$��Center=�$��Center=�$	��120��   Text �� $ Passenger.DateOfIssue� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+��� $��Кем выдан��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Passenger.IssuedBy��� -   $��Сохранить��