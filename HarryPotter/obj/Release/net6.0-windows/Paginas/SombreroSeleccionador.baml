   M S B A M L   `   `   `  ���� F  BHarryPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HarryPotter.PaginasHarryPotter.Paginas  /    )HarryPotter.Paginas.SombreroSeleccionador   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:HarryPotter.Paginas     -     N� Title$  SombreroSeleccionador�� N� ShowsNavigationUI$
 True�� � 	Resources  �� Source�� $ /HojaEstilos/Estilos.xaml?�%    .���  � RowDefinitions �� $
��161* ��� $	��86* ��� $
��203* � � ColumnDefinitions �� $
��164* ��� $
��275* ��� $
��361* �����  �� ImageSource$ /Resources/escudo.png��.+��� -    ��Name$ Imagen��$��	0,0,29,63q�$��/Resources/HP.png��$
��Fill=� J� RenderTransformOrigin$ 0.5,0.5&��� -   $ pulsame��$��	32,0,0,89q�$��/Resources/pulsame.png��$
��Fill=�$y�Visible=�$��2���� -   $ pensar��$��0,0,0,72q�$��/Resources/pensar.png��$
��Fill=�$y�Hidden=�$��2���� -   $
 casa��$��
68,1,69,20q�$��1���� -   	 ��Name$	 Sombrero��   BotonImagen#���   $��0,45,111,10q�$��1��$��2������ 
 �� Color$
 	#FF707070�� �� Opacity$ 0Q����� $ /Resources/Sombrero.png���� -    ��Name$ 	casaTexto��$��Center=�$��1��$��0,8,0,10q�$��Harry P)�$��80(�$��1������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF42310B�� � Offset$ 1Q�� $ 	#FFF5C94E��$ 0Q�