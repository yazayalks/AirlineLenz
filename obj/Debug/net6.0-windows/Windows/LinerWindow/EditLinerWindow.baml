   M S B A M L   `   `   `  ����F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AirlineLenz.Windows.LinerWindowAirlineLenz.Windows.LinerWindow  5   	   5    /AirlineLenz.Windows.LinerWindow.EditLinerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:AirlineLenz.Windows.LinerWindow     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6E     � Title$9  3Редактирование авиалайнера��5   	   $	��450��6,   $	��800��69   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� .+�5      �� $	��300��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Имя��6   $
��Left=�6*   $��Center=�6E   $	��160��6`   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�62   $	��120��6M   ��5      ��  �� Path$ 
Liner.Name�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Дата осмотра��6   $
��Left=�63   $��Center=�6N   $	��160��6i   &   Xceed.Wpf.Toolkit.DateTimePicker  5      $	��120��6*   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�66      FormatString$ dd/MM/yyyy hh:mm tt��6F   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 6l   �� $ Liner.InspectionDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   .+�5      �� $'��!Дата производства��6   $
��Left=�68   $��Center=�6S   $	��160��6n     5      $	��120��6*   $ Custom=�66   $ dd/MM/yyyy hh:mm tt��6F    6m   �� $ Liner.DateOfIssue�$ TwoWay=�$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Тип��6   $��Center=�6+   $	��160��6F   �� 5      $	��120��6   ��6+   �� *LinerTypeColumn+	 �� SelectedItem	 6S   �� *Liner.LinerType+5      �� 5!      $��25,25,25,25q�6   $ 
Horizontal=�64   $��Center=�6M   $
��Auto��6j   $��2��6w   $��40��6�   $	��Top=�6�   .+�5"      �� -   5        $��Сохранить��5"      $	��106��6D   $��5,5,5,5q�6P   �� 5#      -   5        $��Выбрать фото��5#      $	��106��6P   $��5,5,5,5q�6\   5$      5%      5&      �� 5'   
   .+�5(      �� .��6   
Фото5*      �� 5+      -   5        
 ��Name$
 
PhotoImage��5+      $	��300��6G   $	��300��6S   $��34,0,0,0q�6`   $	��300��6r   $	��300��6�   $
��Left=�6�   $��2��6�   ��6(   �� *BitmapPhoto+6�   5-      5.      5/      