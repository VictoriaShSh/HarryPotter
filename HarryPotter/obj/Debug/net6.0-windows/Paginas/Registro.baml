   M S B A M L   `   `   `  ����F  BHarryPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HarryPotter.PaginasHarryPotter.Paginas  5      "    HarryPotter.Paginas.Registro   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:HarryPotter.Paginas     5      -   5          N� Title$  Registro��5	       N� ShowsNavigationUI$
 True��5
       � 	Resources 5       �� Source�� 5   
   $ /HojaEstilos/Estilos.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      ��5   
   �� 5       �� ImageSource$ /Resources/hogwarts.jpg��6   6A   .+�5   
   �� -   5         ��Name$ Nombre��5   6      
CajasTexto#��[  6   $��1��6F   $��1��6V   $��
0,10,0,155q�6c   �� 5    
   -   5        $ Usuario��5    6   #��[  6   $��1��6G   $��1��6W   $��	0,84,0,81q�6d   G� 5!   
   -   5         G�Name$ Contraseña��5!   ?     CajaContraseña#���  6   $��	0,165,0,0q�6S   $��1��6f   $��1��6v   �� 5"   
   -   5        	 ��Name$	 	Registrar��5"   9     BotonDegradado#��[ 6   $��	REGISTRAR��6L   $��104,20,104,124q�6`   $��1��6�   $��2��6�   �� 5#   
    	 Texto#���  6   $��Nombre:��60   $��256,10,0,155q�6B   $��1��6X   �� 5$   
   #���  6   $��Usuario:��60   $��259,84,0,81q�6C   $��1��6X   �� 5%   
   #���  6   $��Contraseña:��60   $��200,165,10,0q�6F   $��1��6\   �� 5&   
   -   5        
 ��Name$
 Error��5&   0    	 Error#���  6   $��	5,165,5,5q�6?   $��1��6R   �� 5'   
   $��73,-7,73,80q�6   $ ��/Resources/HarryPotter.png��6%   $��1��6I   �� 5(   
   -   5          
BotonSalir#���  5(      $��Salir��66   $��2��6F   $��25,150,275,25q�6T   6k   5)      5*      