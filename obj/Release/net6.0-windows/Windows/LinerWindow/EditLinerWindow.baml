   M S B A M L   `   `   `  ���� F  BAirlineLenz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AirlineLenz.Windows.LinerWindowAirlineLenz.Windows.LinerWindow  5    /AirlineLenz.Windows.LinerWindow.EditLinerWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:AirlineLenz.Windows.LinerWindow       � Title$9  3Редактирование авиалайнера��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�.+��� .+��� $	��300��.+��� $ 
Horizontal=�.+��� $��Имя��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������  �� Path$ 
Liner.Name��� $ 
Horizontal=�.+��� $��Дата осмотра��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker  $��Center=�$��Center=�$	��120��   Text �� $ Liner.InspectionDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+��� $'��!Дата производства��$
��Left=�$��Center=�$	��160��  $��Center=�$��Center=�$	��120�� �� $ Liner.DateOfIssue�$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�.+��� $��Тип��$��Center=�$	��160���� $	��120������ *LinerTypeColumn+ �� SelectedItem �� *Liner.LinerType+�� $��25,25,25,25q�$ 
Horizontal=�$��Center=�$
��Auto��$��2��$��40��$	��Top=�.+��� -   $��Сохранить��$	��106��$��5,5,5,5q��� -   $��Выбрать фото��$	��106��$��5,5,5,5q��� .+��� .��
Фото�� -    ��Name$ 
PhotoImage��$	��300��$	��300��$��34,0,0,0q�$	��300��$	��300��$
��Left=�$��2������ *BitmapPhoto+