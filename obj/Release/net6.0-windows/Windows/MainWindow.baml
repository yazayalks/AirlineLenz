   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AirlineLenz.WindowsAirlineLenz.Windows  $    AirlineLenz.Windows.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:AirlineLenz.Windows       � Title$%  Главная страница��$	��500��$
��1000��.��� .+��� $��10q�.@��� -    ��Name$ PassengerTabItem��$��Пассажиры��.��� -    �Name$ PassengerGridItem��$��10q� � RowDefinitions �� $��0.90* ��� $��0.10* � � ColumnDefinitions �� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ PassengerGrid��   
IsReadOnly$
 True��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Имя��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	FirstName+  $	 Фамилия��$
 *  �� *
LastName+  $	 Отчество��$
 *  �� *
Patronymic+  $	 
Серия��$
 *  �� *PassportSeries+  $	 
Номер��$
 *  �� *
PassportId+  $!	 Дата получения��$
 *  �� *DateOfIssue+  $	 Кем выдан��$
 *  �� *
IssuedBy+�� $��1�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ AddPassengerButton��$��Добавить��$	��100��$��25���� -   $ EditPassengerButton��$ ��Редактировать��$	��100��$��25���� -   $ DeletePassengerButton��$��Удалить��$	��100��$��25���� $��
Поиск��$��Center=�$��50���� -    ��Name$ SearchTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��Center=�$	��120���� -   $��Искать��$	��100��$��25���� -	   $��Экспорт��$	��100��$��25���� -
   $ LinerTabItem��$��Авиалайнеры��.��� -   $ LinerGridItem��$��10q� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -   $ 	LinerGrid��$
 True��$ False��   $	 Имя��$
 *  �� *Name+  $	 Дата осмотра��$
 *  �� *InspectionDate+  $	 Дата выпуска��$
 *  �� *DateOfIssue+  $	 Тип��$
 *  �� *	LinerType+�� $��1��$ 
Horizontal=�.+��� -   $ AddLinerButton��$��Добавить��$	��100��$��25���� -   $ EditLinerButton��$ ��Редактировать��$	��100��$��25���� -   $ DeleteLinerButton��$��Удалить��$	��100��$��25���� -   $ AirportTabItem��$��Аэропорты��.��� -   $ AirportGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -   $ AirportGrid��$
 True��$ False��   $	 Название��$
 *  �� *Name+  $	 
Город��$
 *  �� *City+  $	 Страна��$
 *  �� *	Country+�� $��1��$ 
Horizontal=�.+��� -   $ AddAirportButton��$��Добавить��$	��100��$��25���� -   $ EditAirportButton��$ ��Редактировать��$	��100��$��25���� -   $ DeleteAirportButton��$��Удалить��$	��100��$��25���� -   $ RouteTabItem��$��Маршруты��.��� -   $ RouteGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -   $ 	RouteGrid��$
 True��$ False��   $	 Шифр��$
 *  �� *Id+  $#	 Начальный пункт��$
 *  �� *StartingPoint.Name+  $!	 Конечный пункт��$
 *  �� *EndingPoint.Name+�� $��1��$ 
Horizontal=�.+��� -   $ AddRouteButton��$��Добавить��$	��100��$��25���� -   $ EditRouteButton��$ ��Редактировать��$	��100��$��25���� -   $ DeleteRouteButton��$��Удалить��$	��100��$��25���� -   $ EmployeeTabItem��$��Сотрудники��.��� -   $ EmployeeGridItem��$��10q� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -   $ EmployeeGrid��$
 True��$ False��   $	 Имя��$
 *  �� *	FirstName+  $	 Фамилия��$
 *  �� *
LastName+  $	 Отчество��$
 *  �� *
Patronymic+  $	 Должность��$
 *  �� *EmployeeType+�� $��1��$ 
Horizontal=�.+��� -   $ AddEmployeeButton��$��Добавить��$	��100��$��25���� -    $ EditEmployeeButton��$ ��Редактировать��$	��100��$��25���� -!   $ DeleteEmployeeButton��$��Удалить��$	��100��$��25���� -"   $ CrewTabItem��$��Экипажы��.��� -#   $ CrewGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -$   $ CrewGrid��$
 True��$ False��   $	 Название��$
 *  �� *Title+�� $��1��$ 
Horizontal=�.+��� -%   $ AddCrewButton��$��Добавить��$	��100��$��25���� -&   $ EditCrewButton��$ ��Редактировать��$	��100��$��25���� -'   $ DeleteCrewButton��$��Удалить��$	��100��$��25���� -(   $ FlightTabItem��$��
Рейсы��.��� -)   $ FlightGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -*   $ 
FlightGrid��$
 True��$ False��   $	 Название��$
 *  �� *Title+  $	 Шифр маршрута��$
 *  �� *
Route.Id+  $#	 Начальный пункт��$
 *  �� *Route.StartingPoint.Name+  $!	 Конечный пункт��$
 *  �� *Route.EndingPoint.Name+�� $��1��$ 
Horizontal=�.+��� -+   $ AddFlightButton��$��Добавить��$	��100��$��25���� -,   $ EditFlightButton��$ ��Редактировать��$	��100��$��25���� --   $ DeleteFlightButton��$��Удалить��$	��100��$��25���� -.   $ DepartureTabItem��$��Вылеты��.��� -/   $ DepartureGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -0   $ DepartureGrid��$
 True��$ False��   $	 Время вылета��$
 *  �� *DepartureTime+  $'	 !Время приземления��$
 *  �� *ArrivalTime+  $%	 Название экипажа��$
 *  �� *
Crew.Title+  $	 Шифр маршрута��$
 *  �� *Flight.Route.Id+  $!	 Название рейса��$
 *  �� *Flight.Title+  $%	 Название лайнера��$
 *  �� *
Liner.Name+�� $��1��$ 
Horizontal=�.+��� -1   $ AddDepartureButton��$��Добавить��$	��100��$��25���� -2   $ EditDepartureButton��$ ��Редактировать��$	��100��$��25���� -3   $ DeleteDepartureButton��$��Удалить��$	��100��$��25���� -4   $ TicketTabItem��$��Билеты��.��� -5   $ TicketGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -6   $ 
TicketGrid��$
 True��$ False��   $	 Номер билета��$
 *  �� *Id+  $	 Фамилия��$
 *  �� *Passenger.LastName+  $	 Цена��$
 *  �� *Price+  $	 
Класс��$
 *  �� *ServiceClass+  $	 
Касса��$
 10  �� *CheckoutNumber+  $	 Время вылета��$
 *  �� *Departure.DepartureTime+  $'	 !Время приземления��$
 *  �� *Departure.ArrivalTime+  $%	 Название лайнера��$
 *  �� *Departure.Liner.Name+  $%	 Название экипажа��$
 *  �� *Departure.Crew.Title+  $!	 Название рейса��$
 *  �� *Departure.Flight.Title+�� $��1��$ 
Horizontal=�.+��� -7   $ AddTicketButton��$��Добавить��$	��100��$��25���� -8   $ EditTicketButton��$ ��Редактировать��$	��100��$��25���� -9   $ DeleteTicketButton��$��Удалить��$	��100��$��25���� -:   $ AdminTabItem��$/��)Панель администратора��.��� -;   $ AdminGridItem��$��10q� �� $��0.90* ��� $��0.10* � .+�  -<   $ UserGrid��   CanUserAddRows$ False��$ False��      
IsReadOnly$
 True��$	 Индефиктор��$
 *  �� *Id+  $	 
Емаил��$
 *  �� *Email+  $
 True��$	 Хэш пароля��$
 *  �� *
Password+4  .System.Windows.Controls.DataGridComboBoxColumn  -=   UserTypeColumn��$	 Тип доступа��$
 *    SelectedItemBinding �� *
UserType+�� $��1��$ 
Horizontal=�.+��� ->   $ 
SaveButton��$��Сохранить��$	��100��$��25���� -?   $ EditAccessRighttButton��$ ��Редактировать��$	��100��$��25���� -@   $ DeleteUserButton��$��Удалить��$	��100��$��25���� -A   $ RecoverPasswordTabItem��$��Смена пароля��.��� -B   $ RecoverPasswordGridItem��$��10q�.+��� $��0,5,0,0q�$ Vertical=�.+��� $��Center=�.+��� $>��8Изменение пароля пользователя��$	��227��$��	ExtraBold"��� ��Для изменения текущего пароля введите старый пароль, новый пароль и повторите новый пароль.�� $��0,5,0,0q�$��Center=�.+��� $ 
Horizontal=�.+��� $��Старый пароль��$��Center=�$	��160��G� -C    G�Name$ OldPasswordTexBox��$
��Left=�$��Center=�$	��140���� $ 
Horizontal=�.+��� $��Новый паролль��$��Center=�$	��160��G� -D   $ NewPasswordTexBox��$
��Left=�$��Center=�$	��140���� $ 
Horizontal=�.+��� $,��&Повтор нового пароля��$��Center=�$	��160��G� -E   $ ConfirmPasswordTexBox��$
��Left=�$��Center=�$	��140���� $��Center=�$ 
Horizontal=�$��0,25,0,0q�$
��Auto��$��50��$	��Top=�.+��� -F   $ RecoverPasswordButton��$��Изменить��$	��100��$��25���� $��Справка��.��� $��10q�.+�� $	��400��.+��� .+��� $1��+Как работает программа:��$
��Auto��$��Center=�$��	ExtraBold"��� $
��Wrap=���Пользователь, при разрешённых правах доступа администратором, может читать, добавлять, редактировать, удалять необходимые данные;�� �� ��Пользователь имеет возможность поиска по таблице Пассажиров, а также может экспортироовать её в эксель и ворд файл;�� �� nlУ всех пользователя есть возможность для изменения пароля;�� �� ...