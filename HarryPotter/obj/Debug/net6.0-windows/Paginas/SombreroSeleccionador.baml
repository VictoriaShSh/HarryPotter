   M S B A M L   `   `   `  ����F  BHarryPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HarryPotter.PaginasHarryPotter.Paginas  5      /    )HarryPotter.Paginas.SombreroSeleccionador   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:HarryPotter.Paginas     5      -   5          N� Title$  SombreroSeleccionador��5	       N� ShowsNavigationUI$
 True��5
       � 	Resources 5       �� Source�� 5   
   $ /HojaEstilos/Estilos.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $
��161* �6   �� 5      $	��86* �6   �� 5      $
��203* �6    � ColumnDefinitions 5   
   �� 5      $
��164* �6   �� 5      $
��275* �6   �� 5      $
��361* �6   ��5   
   �� 5       �� ImageSource$ /Resources/escudo.png��6   .+�5   
   �� -   5         ��Name$ Imagen��5      $��	0,0,29,63q�6    $��/Resources/HP.png��63   $
��Fill=�6N    J� RenderTransformOrigin$ 0.5,0.5&�6]   �� 5    
   -   5        $ pulsame��5       $��	32,0,0,89q�6!   $��/Resources/pulsame.png��64   $
��Fill=�6T   $y�Visible=�6c   $��2��6x   �� 5!   
   -   5        $ pensar��5!      $��0,0,0,72q�6    $��/Resources/pensar.png��62   $
��Fill=�6Q   $y�Hidden=�6`   $��2��6t   �� 5"   
   -   5        $
 casa��5"      $��
68,1,69,20q�6   $��1��62   �� 5#   
   -   5        	 ��Name$	 Sombrero��5#   7      BotonImagen#���   6   $��0,45,111,10q�6I   $��1��6u   $��2��6�   ��5$      �� 5%      
 �� Color$
 	#FF707070��6"    �� Opacity$ 0Q�64   ��5'      �� 5(      $ /Resources/Sombrero.png��6   5*      �� 5+   
   -   5         ��Name$ 	casaTexto��5+      $��Center=�6#   $��1��6G   $��0,8,0,10q�6W   $��Harry P)�6i   $��80(�6~   $��1��6�   ��5,      �� 5-       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5.      �  � Color$ 	#FF42310B��6#    � Offset$ 1Q�65   � 5/      $ 	#FFF5C94E��6#   $ 0Q�65   50      52      53      54      