   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:AirlineLenz.Windows.EmployeeWindow"AirlineLenz.Windows.EmployeeWindow  ;    5AirlineLenz.Windows.EmployeeWindow.EditEmployeeWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:AirlineLenz.Windows.EmployeeWindow       � Title$7  1Редактирование сотрудника��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� $	��300��.+��� $ 
Horizontal=�.+��� $��Имя��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ Employee.FirstName��� $ 
Horizontal=�.+��� $��Фамилия��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Employee.LastName��� $ 
Horizontal=�.+��� $��Отчесвто��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Employee.Patronymic��� $ 
Horizontal=�.+��� $��Должность��$��Center=�$	��160���� $	��120������ *EmployeeTypeColumn+ �� SelectedItem �� *Employee.EmployeeType+�� -   $��Сохранить��