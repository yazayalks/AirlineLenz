   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:AirlineLenz.Windows.EmployeeWindow"AirlineLenz.Windows.EmployeeWindow  5   	   ;    5AirlineLenz.Windows.EmployeeWindow.EditEmployeeWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:AirlineLenz.Windows.EmployeeWindow     5   	     � Title$7  1Редактирование сотрудника��5   	   $	��450��6+   $	��800��68   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� $	��300��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Имя��6   $
��Left=�6&   $��Center=�6A   $	��160��6\   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      ��  �� Path$ Employee.FirstName�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Фамилия��6   $
��Left=�6*   $��Center=�6E   $	��160��6`   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Employee.LastName�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Отчесвто��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Employee.Patronymic�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Должность��6   $��Center=�6-   $	��160��6H   �� 5      $	��120��6   ��6'   �� *EmployeeTypeColumn+ �� SelectedItem 6R   �� *Employee.EmployeeType+5      �� 5$      -   5        $��Сохранить��5$      6)   5%      5&      5'      