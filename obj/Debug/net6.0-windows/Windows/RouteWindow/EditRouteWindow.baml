   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AirlineLenz.Windows.RouteWindowAirlineLenz.Windows.RouteWindow  5   	   5    /AirlineLenz.Windows.RouteWindow.EditRouteWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:AirlineLenz.Windows.RouteWindow     5   	     � Title$3  -Редактирование маршрута��5   	   $	��450��6)   $	��800��66   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� .+�5   
   �� $	��350��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $#��Начальный пункт��6   $
��Left=�62   $��Center=�6M   $	��160��6h   �� 5      -   5         ��Name$ StartingPointTextBox��5       �� 
IsReadOnly$
 True��68    �� TextWrapping$
 Wrap=�6J   $��Center=�6^   $	��120��6y   ��5      ��  �� Path$ Route.StartingPoint.Name��� 5      -   5        $��Выбрать��5      6+   5      �� 5      $ 
Horizontal=�6   .+�5      �� $!��Конечный пункт��6   $
��Left=�61   $��Center=�6L   $	��160��6g   �� 5      -   5        $ EndingPointTextBox��5      $
 True��66   $
 Wrap=�6H   $��Center=�6\   $	��120��6w   ��5      �� $ Route.EndingPoint.Name��� 5      -   5        $��Выбрать��5      6+   5      �� 5!      -   5        $��Сохранить��5!      $	��100��6<   5"      5#      �� 5$   
   $��10q�6   $
��Auto��6!   .+�5%      �� $ 
Horizontal=�6   $��Center=�62   .+�5&      �� -   5        $��Добавить��5&      $
��Auto��6K   �� 5'      -   5        $��Удалить��5'      $
��Auto��6M   5(      &   System.Windows.Controls.DataGrid  5)      -   5          Name$ WayPointGrid��5)         AutoGenerateColumns$ False��6-      
IsReadOnly$
 True��6I   	   Columns	 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn
   Header$-
 'Промежуточные пункты��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5,   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5+   )   �� *Name+5,   )   5.      5/      51      52      