   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AirlineLenz.Windows.PassengerWindow#AirlineLenz.Windows.PassengerWindow  5   	   =    7AirlineLenz.Windows.PassengerWindow.EditPassengerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AirlineLenz.Windows.PassengerWindow     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$5  /Редактирование пассажира��5	   	   $	��450��6*   $	��800��67   .��5
      ��  �� Orientation$ 
Horizontal=�6   .+�5   
   �� $	��500��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Имя��6   $
��Left=�6&   $��Center=�6A   $	��160��6\   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      ��  �� Path$ Passenger.FirstName�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Фамилия��6   $
��Left=�6*   $��Center=�6E   $	��160��6`   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Passenger.LastName�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Отчесвто��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Passenger.Patronymic�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Серия��6   $
��Left=�6(   $��Center=�6C   $	��160��6^   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Passenger.PassportSeries�5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $��
Номер��6   $
��Left=�6(   $��Center=�6C   $	��160��6^   �� 5#      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5$      �� $ Passenger.PassportId�5%      �� 5'      $ 
Horizontal=�6   .+�5(      �� $��Дата выдачи��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   (  "System.Windows.Controls.DatePicker  5*         SelectedDateFormat$ Short=�6   $��Center=�68   $��Center=�6U   $	��120��6p      Text 5+      �� $ Passenger.DateOfIssue� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5,      �� 5.      $ 
Horizontal=�6   .+�5/      �� $��Кем выдан��6   $
��Left=�6,   $��Center=�6G   $	��160��6b   �� 50      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��51      �� $ Passenger.IssuedBy�52      �� 54      -   5        $��Сохранить��54      6)   55      56      57      