   M S B A M L   `   `   `  ����F  BHarryPotter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HarryPotter.PaginasHarryPotter.Paginas  5      ;"clr-namespace:HarryPotter.UControlHarryPotter.UControl  5      #    HarryPotter.Paginas.Principal   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:HarryPotter.Paginas     5      1uc"clr-namespace:HarryPotter.UControl     5      -   5          N� Title$  	Principal��5
       N� ShowsNavigationUI$ False��5       � 	Resources 5       �� MergedDictionaries �� Source 
  Cerrar  Ver 	 Salir�� 5   
    5      �� 5      $ /HojaEstilos/Estilos.xaml?�6%   %W   &	        &	      &	 &     �� 5      6   �� 5      6   �� 5      6   5       J� InputBindings 5      �� 5   
   
 �� Key$ C��6    �� 	Modifiers$
 Ctrlf�6    �� Command# [  6.   �� 5   
   $ V��6   $
 Ctrlf�6   # [ 6.   �� 5   
   $ S��6   $
 Ctrlf�6   # [ 6.   	 J� CommandBindings	 5      )  #System.Windows.Input.CommandBinding  5    
   -   5        
   Command#
 [  5       6;     5!   
   -   5        #
 [ 5!      68     5"   
   -   5        #
 [ 5"      6:   .��5%      �  � ColumnDefinitions 5&   
   �� 5'      $	��30* �6   �� 5(      $	��20* �6   �� 5)      $	��20* �6   �� 5*      $	��30* �6    � RowDefinitions 5,   
   �� 5-      $
��279* �6   �� 5.      $
��236* �6   �� 5/      $	��160 �6   .+�51   
   o� $��4��6   $��0,0,0,0q�6#   $��3��64   ��52      �� 53       �� ImageSource$ /Resources/interior.jpg��6   6E   .@�55      m� -   5         m�Name$ Inicio��55      
�������$��Harry P)�6?   $��40(�6T   $��Inicio��6b    � ToolTip$ Opciones basicas��6r   .@�56      m� -   5        $ Sesion��56      $��Cerrar Sesion��6+   
���   �$��Harry P)�6U   $��25(�6j   $ Vuelve a Inicio��6�    m� InputGestureText$ Ctrl+C��6�   m� 57      -   5        $ 	Registrar��57      $��Registrar Usuario��6/   
���   �$��Harry P)�6]   $��25(�6r   $ Regista un nuevo Usuario��6�   �� 58      
��� ���6   m� 59      -   5        $��Salir��59      
���   �$��Harry P)�6=   $��25(�6R   $ Cierra la Aplicacion��6t   $ Ctrl+S��6�   5:      m� 5;      -	   5        $ Ayuda��5;      $��Ayuda��6'   
�������$��Harry P)�6N   $��40(�6c   $ Informacion sobre la App��6�   m� 5<      -
   5        $ Administrador��5<      $��Administrador��6.   
�������$��Harry P)�6]   $��40(�6r   $ Opciones de Administrador��6�   .@�5=      m� -   5        $ RegistrarAd��5=   :   $��Registar Admnistrador��6   
���   �$��Harry P)�6b   $��25(�6w   6�   m� 5>      -   5        $ BorrarUs��5>   3   $��Borrar Usuario��6   
���   �$��Harry P)�6X   $��25(�6m   6{   m� 5?      -   5        $ VerUs��5?   1   $��Ver Usuarios��6   
���   �$��Harry P)�6S   $��25(�6h   $ Ctrl+V��6�   5@      5A      �� 5B   
   -   5         ��Name$ 
Gryffindor��5B   7     BotonImagen#���  6   $��40,56,40,57q�6K   $��1��6y   $ Sala comun Gryffindor��6�   ��5C      �� 5D      $ /Resources/G.png��6    � ContextMenu 5F      �� 5G      .@�5H      m� -   5        $��Asignar Casa Hogwatrs��5H      6>   5I      5K      �� 5L   
   -   5        $ 	Slytherin��5L   7   #���  6   $��40,56,40,57q�6J   $��2��6w   $ Sala comun Slytherin��6�   ��5M      �� 5N      $ /Resources/S.png��6    5P      �� 5Q      .@�5R      m� -   5        $��Asignar Casa Hogwatrs��5R      6>   5S      5U      �� 5V   
   -   5        $ 	Ravenclaw��5V   7   #���  6   $��38,36,38,32q�6J   $��1��6w   $��1��6�   $ Sala comun Ravenclaw��6�   ��5W      �� 5X      $ /Resources/R.png��6    5Z      �� 5[      .@�5\      m� -   5        $��Asignar Casa Hogwatrs��5\      6>   5]      5_      �� 5`   
   -   5        $ 
Hufflepuff��5`   7   #���  6   $��40,36,40,32q�6K   $��2��6y   $��1��6�   $ Sala comun Hufflepuff��6�   ��5a      �� 5b      $ /Resources/H.png��6    5d      �� 5e      .@�5f      m� -   5        $��Asignar Casa Hogwatrs��5f      6>   5g      5i      �� 5j   
   $��Selecciona tu Sala Comun��6   $��Center=�63   $��Harry P)�6W   $��60(�6l   $��
10,4,10,80q�6z   $
|�True��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Center=�6�   $
}�True��6�   $��1��6�   $��2��6  $��2��6  ��5k      �� 5l       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� Opacity$	 100Q�6J   .��5m      �  � Color$ 	#FF291E14��6#    � Offset$ 0Q�65   � 5n      $ 	#FF8A6432��6#   $ 0.519Q�65   � 5o      $ 	#FF2B1F13��6#   $ 1Q�65   5p      ��5r      �� 5s      .��5t      � $ 	#FFFF0900��6#   $	 0.1Q�65   � 5u      $ 	#FFD7FF00��6#   $ 0.368Q�65   � 5v      $ 	#FF003EFF��6#   $ 0.632Q�65   � 5w      $ 	#FF00FF18��6#   $	 0.9Q�65   5x      5z      9� 5{   
    9� ExpandDirection$
 Left=�6   $	��Top=�6*   $��Right=�6I   $��3��6l   $��1��6|   $��2��6�   ��5|      �� 5}      $	��Mas��6   $��30(�6'   $��Harry P)�65   
�������$ Mas Opciones del Juego��6b   .��5         HarryPotter.UControl.Mas  -   5          Name$ usercon��5      $	��511��6&   5�      5�      5�      