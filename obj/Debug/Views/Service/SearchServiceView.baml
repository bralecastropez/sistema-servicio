   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       Proyecto_Servicio7   1Proyecto_Servicio.Views.Service.SearchServiceView   5      Hcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $	��660��5      $	��620��6+     � 	Resources  5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $W Qpack://application:,,,              /MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $k epack://application:,,,                                     /MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $n hpack://application:,,,                                     /MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $r lpack://application:,,,                                     /MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $w qpack://application:,,,                                     /MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $��Búsqueda de Servicio��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $	��580��6u   $��50��6�   $��Center=�6�   $��25(�6�   �� 5   
   $��Buscar por:��6   $
��Left=�6&   $��	10,65,0,0q�6A   $	��Top=�6T   $	��200��6l   	� 5   
   -   5         	�Name$ rbtnUsuario��5      $��Usuario��6+   $
��Left=�6=   $��	10,96,0,0q�6X   $	��Top=�6k   $	��100��6�   	� 5   
   -   5        $ rbtnCliente��5      $��Cliente��6+   $
��Left=�6=   $��
115,96,0,0q�6X   $	��Top=�6l   $	��100��6�   	� 5   
   -   5        $ rbtnProblema��5      $��Problema��6,   $
��Left=�6?   $��
220,96,0,0q�6Z   $	��Top=�6n   $	��100��6�   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��
10,117,0,0q�6=   $	��Top=�6Q   $	��100��6i   �� 5   
   -   5         ��Name$ txtNombreUsuario��5      $
��Left=�6,   $��23��6G   $��
10,143,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��100��6�   �� 5    
   $��Nombre:��6   $
��Left=�6"   $��115,117,0,0q�6=   $	��Top=�6R   $	��100��6j   �� 5!   
   -   5        $ txtNombreCliente��5!      $
��Left=�6,   $��23��6G   $��115,143,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��100��6�   �� 5"   
   -   5         ��Name$ cmbTipoEquipo��5"      $
��Left=�6*   $��
10,218,0,0q�6E   $	��Top=�6Y   $	��100��6q    �� Text$
 Tipo��6}   �� 5#   
   -   5        $ cmbModeloEquipo��5#      $
��Left=�6,   $��115,218,0,0q�6G   $	��Top=�6\   $	��100��6t   $ Modelo��6�   �� 5$   
   -	   5        $ cmbMarcaEquipo��5$      $
��Left=�6+   $��220,218,0,0q�6F   $	��Top=�6[   $	��100��6s   $ Marca��6   (  "System.Windows.Controls.DatePicker  5%   
   -
   5          Name$ dtpFechaIngreso��5%      $
��Left=�6.   $��325,218,0,0q�6I   $	��Top=�6^   $	��100��6v     5&   
   -   5        $ dtpFechaEntrega��5&      $
��Left=�6.   $��430,218,0,0q�6I   $	��Top=�6^   $	��100��6v   �� 5(   
   -   5        $ txtProblema��5(      $
��Left=�6'   $��23��6B   $��220,143,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��100��6�   &   System.Windows.Controls.DataGrid  5)   
   -   5        	  Name$	 dgServicioBuscado��5)      
   CanUserAddRows
 .     CanUserDeleteRows .     SelectionMode$ Single=�6_   $
��Left=�6v   $��
10,290,0,0q�6�   $	��Top=�6�   $	��300��6�   $	��520��6�   �� 5*   
   -   5         ��Name$ btnBuscarServicio��5*      $��Buscar��6,   $
��Left=�6=   $��
10,256,0,0q�6X   $	��Top=�6l   $	��520��6�   �� 5+   
   $	��Ver��6   $
��Left=�6   $��535,290,0,0q�6:   $	��Top=�6O   $	��100��6g   �� 5,   
   $��Eliminar��6   $
��Left=�6$   $��535,317,0,0q�6?   $	��Top=�6T   $	��100��6l   �� 5-   
   $��Editar��6   $
��Left=�6"   $��535,344,0,0q�6=   $	��Top=�6R   $	��100��6j   	� 5.   
   -   5        $ rbtnComponente��5.      $��
Componente��6.   $
��Left=�6C   $��
325,96,0,0q�6^   $	��Top=�6r   $	��100��6�   �� 5/   
   -   5        $ txtComponente��5/      $
��Left=�6)   $��23��6D   $��325,143,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��100��6�   	� 50   
   -   5        $ rbtnFechaIngreso��50      $��Fecha Ingreso��61   $
��Left=�6I   $��325,200,0,0q�6d   $	��Top=�6y   $	��100��6�   	� 51   
   -   5        $ rbtnFechaEntrega��51      $��Fecha Entrega��61   $
��Left=�6I   $��430,200,0,0q�6d   $	��Top=�6y   $	��100��6�   	� 52   
   -   5        $ rbtnTipoEquipo��52      $
��Tipo��6.   $
��Left=�6=   $��
10,200,0,0q�6X   $	��Top=�6l   $	��100��6�   	� 53   
   -   5        $ rbtnModeloEquipo��53      $��Modelo��60   $
��Left=�6A   $��115,200,0,0q�6\   $	��Top=�6q   $	��100��6�   	� 54   
   -   5        $ rbtnMarcaEquipo��54      $��Marca��6/   $
��Left=�6?   $��220,200,0,0q�6Z   $	��Top=�6o   $	��100��6�   �� 55   
   $��Equipo��6   $
��Left=�6!   $��
10,166,0,0q�6<   $	��Top=�6P   $	��310��6h   �� 56   
   $��Fecha��6   $
��Left=�6    $��325,166,0,0q�6;   $	��Top=�6P   $	��205��6h   �� 57   
   $��Nombre:��6   $
��Left=�6"   $��220,117,0,0q�6=   $	��Top=�6R   $	��100��6j   �� 58   
   $��Nombre:��6   $
��Left=�6"   $��325,117,0,0q�6=   $	��Top=�6R   $	��100��6j   59      5:      