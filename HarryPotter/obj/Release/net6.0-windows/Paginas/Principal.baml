   M S B A M L   `   `   `  ���� F  BHarryPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HarryPotter.PaginasHarryPotter.Paginas  ;"clr-namespace:HarryPotter.UControlHarryPotter.UControl  #    HarryPotter.Paginas.Principal   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:HarryPotter.Paginas     1uc"clr-namespace:HarryPotter.UControl     -     N� Title$  	Principal�� N� ShowsNavigationUI$ False�� � 	Resources  �� MergedDictionaries �� Source 
  Cerrar  Ver 	 Salir��  �� $ /HojaEstilos/Estilos.xaml?�%-   &	        &	      &	 
     �� �� ��  J� InputBindings �� 
 �� Key$ C�� �� 	Modifiers$
 Ctrlf� �� Command# [  �� $ V��$
 Ctrlf�# [ �� $ S��$
 Ctrlf�# [ 	 J� CommandBindings	 )  #System.Windows.Input.CommandBinding  -   
   Command#
 [    -   #
 [   -   #
 [ .���  � ColumnDefinitions �� $	��30* ��� $	��20* ��� $	��20* ��� $	��30* � � RowDefinitions �� $
��279* ��� $
��236* ��� $	��160 �.+�o� $��4��$��0,0,0,0q�$��3������  �� ImageSource$ /Resources/interior.jpg��.@�m� -    m�Name$ Inicio��
�������$��Harry P)�$��40(�$��Inicio�� � ToolTip$ Opciones basicas��.@�m� -   $ Sesion��$��Cerrar Sesion��
���   �$��Harry P)�$��25(�$ Vuelve a Inicio�� m� InputGestureText$ Ctrl+C��m� -   $ 	Registrar��$��Registrar Usuario��
���   �$��Harry P)�$��25(�$ Regista un nuevo Usuario���� 
��� ���m� -   $��Salir��
���   �$��Harry P)�$��25(�$ Cierra la Aplicacion��$ Ctrl+S��m� -	   $ Ayuda��$��Ayuda��
�������$��Harry P)�$��40(�$ Informacion sobre la App��m� -
   $ Administrador��$��Administrador��
�������$��Harry P)�$��40(�$ Opciones de Administrador��.@�m� -   $ RegistrarAd��$��Registar Admnistrador��
���   �$��Harry P)�$��25(�m� -   $ BorrarUs��$��Borrar Usuario��
���   �$��Harry P)�$��25(�m� -   $ VerUs��$��Ver Usuarios��
���   �$��Harry P)�$��25(�$ Ctrl+V���� -    ��Name$ 
Gryffindor��  BotonImagen#���  $��40,56,40,57q�$��1��$ Sala comun Gryffindor������ $ /Resources/G.png�� � ContextMenu �� .@�m� -   $��Asignar Casa Hogwatrs���� -   $ 	Slytherin��#���  $��40,56,40,57q�$��2��$ Sala comun Slytherin������ $ /Resources/S.png�� �� .@�m� -   $��Asignar Casa Hogwatrs���� -   $ 	Ravenclaw��#���  $��38,36,38,32q�$��1��$��1��$ Sala comun Ravenclaw������ $ /Resources/R.png�� �� .@�m� -   $��Asignar Casa Hogwatrs���� -   $ 
Hufflepuff��#���  $��40,36,40,32q�$��2��$��1��$ Sala comun Hufflepuff������ $ /Resources/H.png�� �� .@�m� -   $��Asignar Casa Hogwatrs���� $��Selecciona tu Sala Comun��$��Center=�$��Harry P)�$��60(�$��
10,4,10,80q�$
|�True�� J� RenderTransformOrigin$ 0.5,0.5&�$��Center=�$
}�True��$��1��$��2��$��2������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&� �� Opacity$	 100Q�.���  � Color$ 	#FF291E14�� � Offset$ 0Q�� $ 	#FF8A6432��$ 0.519Q�� $ 	#FF2B1F13��$ 1Q����� .��� $ 	#FFFF0900��$	 0.1Q�� $ 	#FFD7FF00��$ 0.368Q�� $ 	#FF003EFF��$ 0.632Q�� $ 	#FF00FF18��$	 0.9Q�9�  9� ExpandDirection$
 Left=�$	��Top=�$��Right=�$��3��$��1��$��2������ $	��Mas��$��30(�$��Harry P)�
�������$ Mas Opciones del Juego��.��   HarryPotter.UControl.Mas  -     Name$ usercon��$	��511��