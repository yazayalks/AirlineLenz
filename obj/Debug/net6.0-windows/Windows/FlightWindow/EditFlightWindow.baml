   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AirlineLenz.Windows.FlightWindow AirlineLenz.Windows.FlightWindow  5   	   7    1AirlineLenz.Windows.FlightWindow.EditFlightWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:AirlineLenz.Windows.FlightWindow     5   	     � Title$-  'Редактирование рейса��5   	   $	��450��6&   $	��800��63   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� .+�5      �� $	��350��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Название��6   $
��Left=�6/   $��Center=�6J   $	��160��6e   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�62   $	��120��6M   ��5      ��  �� Path$ Flight.Title�5      �� 5      -   5        $��Сохранить��5      $	��100��6@   5      5      �� 5   
   $��10q�6   $
��Auto��6!   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��Изменить��5      $
��Auto��6H   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	RouteGrid��5         AutoGenerateColumns$ False��6*      
IsReadOnly$
 True��6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Шифр��6@   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 5   )   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   )   �� *Id+5   )     5      $# Начальный пункт��6P   $
	 auto 5   )   
 5   )   �� *StartingPoint.Name+5   )     5       $! Конечный пункт��6N   $
	 auto 5!   )   
 5    )   �� *EndingPoint.Name+5!   )   5#      5$      5%      5&      