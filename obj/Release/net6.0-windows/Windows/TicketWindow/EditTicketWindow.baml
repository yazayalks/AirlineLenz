   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AirlineLenz.Windows.TicketWindow AirlineLenz.Windows.TicketWindow  7    1AirlineLenz.Windows.TicketWindow.EditTicketWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:AirlineLenz.Windows.TicketWindow       � Title$/  )Редактирование билета��$	��450��$	��800��.���� $��10q� �� Orientation$ Vertical=�.+��� .+��� $
��Auto��$
��Left=�.+��� $ 
Horizontal=�$��5q�.+��� $ Vertical=�.+��� $ 
Horizontal=�.+��� $��Дата покупки��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker  $��Center=�$��Center=�$	��120��   Text ��  �� Path$ Ticket.PurchaseDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+��� $��
Класс��$��Center=�$	��160���� $	��120������ *ServiceClassColumn+ �� SelectedItem �� *Ticket.ServiceClass+�� $ Vertical=�$��5q�.+��� $ 
Horizontal=�.+��� $��
Место��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������ $ Ticket.Place��� $ 
Horizontal=�.+��� $��Номер кассы��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Ticket.CheckoutNumber��� $ 
Horizontal=�.+��� $��Цена билета��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Ticket.Price��� $��10q�$
��Auto��$
��Auto��$ Vertical=�.+��� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��Пассажир��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��&   System.Windows.Controls.DataGrid  -     Name$ PassengerGrid��	   AutoGenerateColumns$	 False��
   
IsReadOnly$

 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	FirstName+  $ Фамилия��$ *  �� *
LastName+  $ Отчество��$ *  �� *
Patronymic+  $ 
Серия��$ *  �� *PassportSeries+  $ 
Номер��$ *  �� *
PassportId+  $! Дата получения��$ *  �� *DateOfIssue+  $ Кем выдан��$ *  �� *
IssuedBy+�� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��Продавец��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��  -   $ CashierGrid��$	 False��$

 True��   $ Имя��$ *  �� *	FirstName+  $ Фамилия��$ *  �� *
LastName+  $ Отчество��$ *  �� *
Patronymic+  $ Должность��$ *  �� *EmployeeType+�� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��
Вылет��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��  -   $ DepartureGrid��$	 False��$

 True��   $ Время вылета��$ *  �� *DepartureTime+  $' !Время приземления��$ *  �� *ArrivalTime+  $% Название экипажа��$ *  �� *
Crew.Title+  $ Шифр маршрута��$ *  �� *Flight.Route.Id+  $! Название рейса��$ *  �� *Flight.Title+  $' !Пункт отправления��$ *  �� *!Flight.Route.StartingPoint.Name+  $! Пункт прибытия��$ *  �� *Flight.Route.EndingPoint.Name+  $% Название лайнера��$ *  �� *
Liner.Name+�� -   $��Сохранить��$��Right=�$	��100��