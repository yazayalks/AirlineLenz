   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AirlineLenz.Windows.TicketWindow AirlineLenz.Windows.TicketWindow  5   	   7    1AirlineLenz.Windows.TicketWindow.EditTicketWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:AirlineLenz.Windows.TicketWindow     5   	     � Title$/  )Редактирование билета��5   	   $	��450��6'   $	��800��64   .��5	      �� $��10q�6    �� Orientation$ Vertical=�6   .+�5
   
   �� .+�5      �� $
��Auto��6   $
��Left=�6&   .+�5      �� $ 
Horizontal=�6   $��5q�66   .+�5      �� $ Vertical=�6!   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Дата покупки��6   $
��Left=�63   $��Center=�6N   $	��160��6i   (  "System.Windows.Controls.DatePicker  5      $��Center=�6!   $��Center=�6>   $	��120��6Y      Text 5      ��  �� Path$ Ticket.PurchaseDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Класс��6   $��Center=�6-   $	��160��6H   �� 5      $	��120��6   ��6+   �� *ServiceClassColumn+ �� SelectedItem 6V   �� *Ticket.ServiceClass+5      5      �� 5      $ Vertical=�6!   $��5q�68   .+�5      �� $ 
Horizontal=�6%   .+�5      �� $��
Место��6   $
��Left=�6,   $��Center=�6G   $	��160��6b   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�63   $	��120��6N   ��5      �� $ Ticket.Place�5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $��Номер кассы��6   $
��Left=�62   $��Center=�6M   $	��160��6h   �� 5#      $
 Wrap=�6   $��Center=�64   $	��120��6O   ��5$      �� $ Ticket.CheckoutNumber�5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��Цена билета��6   $
��Left=�62   $��Center=�6M   $	��160��6h   �� 5(      $
 Wrap=�6   $��Center=�64   $	��120��6O   ��5)      �� $ Ticket.Price�5*      5+      5,      50      51      �� 53   
   $��10q�6   $
��Auto��6!   $
��Auto��6.   $ Vertical=�6<   .+�54      �� $
��Auto��6   $��80��6'   .+�55      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�56      �� $��Пассажир��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 57      -   5        $��Изменить��57      $
��Auto��6L   58      &   System.Windows.Controls.DataGrid  59      -   5          Name$ PassengerGrid��59      	   AutoGenerateColumns$	 False��62   
   
IsReadOnly$

 True��6N      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	FirstName+6X     5=      $ Фамилия��6J   $ * 6[    6-   �� *
LastName+6[     5>      $ Отчество��6L   $ * 6^    6-   �� *
Patronymic+6^     5?      $ 
Серия��6P   $ * 6_    6-   �� *PassportSeries+6_     5@      $ 
Номер��6L   $ * 6[    6-   �� *
PassportId+6[     5A      $! Дата получения��6M   $ * 6e    6-   �� *DateOfIssue+6e     5B      $ Кем выдан��6J   $ * 6]    6-   �� *
IssuedBy+6]   5D      5E      �� 5G      $
��Auto��6   $��80��6'   .+�5H      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�5I      �� $��Продавец��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 5J      -   5        $��Изменить��5J      $
��Auto��6N   5K        5L      -   5        $ CashierGrid��5L      $	 False��60   $

 True��6L    5M        5N      $ Имя��6K   $ * 6X    6-   �� *	FirstName+6X     5O      $ Фамилия��6J   $ * 6[    6-   �� *
LastName+6[     5P      $ Отчество��6L   $ * 6^    6-   �� *
Patronymic+6^     5Q      $ Должность��6N   $ * 6a    6-   �� *EmployeeType+6a   5S      5T      �� 5V      $
��Auto��6   $��80��6'   .+�5W      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�5X      �� $��
Вылет��6   $
��Left=�6,   $��Center=�6G   $	��160��6b   �� 5Y      -   5        $��Изменить��5Y      $
��Auto��6P   5Z        5[      -   5        $ DepartureGrid��5[      $	 False��62   $

 True��6N    5\        5]      $ Время вылета��6O   $ * 6e    6-   �� *DepartureTime+6e     5^      $' !Время приземления��6M   $ * 6h    6-   �� *ArrivalTime+6h     5_      $% Название экипажа��6L   $ * 6f    6-   �� *
Crew.Title+6f     5`      $ Шифр маршрута��6Q   $ * 6h    6-   �� *Flight.Route.Id+6h     5a      $! Название рейса��6N   $ * 6f    6-   �� *Flight.Title+6f     5b      $' !Пункт отправления��6a   $ * 6|    6-   �� *!Flight.Route.StartingPoint.Name+6|     5c      $! Пункт прибытия��6_   $ * 6w    6-   �� *Flight.Route.EndingPoint.Name+6w     5d      $% Название лайнера��6L   $ * 6f    6-   �� *
Liner.Name+6f   5f      5g      5h      �� 5i   
   -   5        $��Сохранить��5i      $��Right=�6%   $	��100��6T   5j      5k      