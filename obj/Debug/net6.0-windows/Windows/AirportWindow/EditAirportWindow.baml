   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:AirlineLenz.Windows.AirportWindow!AirlineLenz.Windows.AirportWindow  5   	   9    3AirlineLenz.Windows.AirportWindow.EditAirportWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:AirlineLenz.Windows.AirportWindow     5   	     � Title$5  /Редактирование аэропорта��5   	   $	��450��6*   $	��800��67   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� .+�5   
   �� $	��300��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Название��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      ��  �� Path$ Airport.Name�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Город��6   $
��Left=�6(   $��Center=�6C   $	��160��6^   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Airport.City�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Страна��6   $
��Left=�6)   $��Center=�6D   $	��160��6_   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   ��5      �� $ Airport.Country�5      �� 5!      -   5        $��Сохранить��5!      6)   5"      5#      5%      5&      