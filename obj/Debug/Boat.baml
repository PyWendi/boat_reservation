   M S B A M L   `   `   `  ����J  FBoatReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BoatReservationBoatReservation  5   	       BoatReservation.Boat   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BoatReservation     5   	     � Title$
  Boat��5   	   $	��600��6   $	��800��6#    � 
ResizeMode$ NoResize=�6/    � WindowStartupLocation$ CenterScreen=�6E   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��561* �6   �� 5      $
��131* �6   �� 5      $
��102* �6   .+�5   
   �� $
��Left=�6   
�������$	��569��6C   $	��Top=�6P   $	��150��6h   .+�5      �� -   5         ��Name$ NavigationLabel��5      $��
Navigation��6-   ���	#FF4A8689$��Center=�6Y   $��21.333(�6}   �� 5      -   5         ��Name$ HomeSection��5      $
��Home��6*   $��31��69   $��16(�6E   6S   �� 5      -   5        $ BoatSection��5      $��Bateaux
��6*   $��31��6A   $��16(�6M   ���	#FF60B0E86[   �� 5      -   5        $ PassengerSection��5      $��Enregistrement
��6/   $��31��6M   $��16(�6Y   6g   �� 5      -   5        $ ReservationSection��5      $��Réservation
��61   $��31��6L   $��16(�6X   6f   �� 5      -   5        $ LogoutSection��5      $��Déconnection
��6,   $��31��6H   $��16(�6T   6b   5      �� 5   
   -   5         ��Name$ Search��5      $
��Left=�6"   $��23��6=   $��
165,14,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�    � ToolTip$ Recherche...��6�   �� 5   
   -   5        $ ValidFiltre��5      $��Valider��6&   $
��Left=�68   $��
511,15,0,0q�6S   $	��Top=�6g   $��75��6   $��2��6�   $��20��6�   �� 5   
   -	   5        	 ��Name$	 	FiltreBox��5      $��
368,15,0,0q�6&   $	��Top=�6:   $
��Left=�6�   $	��120��6�   $��22��6�   .@�5      �� $
��Left=�6   $	��118��66   .��5      �� 
���   �$��1q�6-   $	��100��6A   $	��100��6N   5      5      �� 5   
   -
   5        $ label��5      $��Filtré par :��6   $
��Left=�66   $��
299,12,0,0q�6Q   $	��Top=�6e   $��26��6}   $��63��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dataGrid��5      $��165,56,26,0q�6%   $	��Top=�6:   $	��492��6R   $��3��6�      Columns 5       4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Cocher��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 69   0  *System.Windows.Controls.DataGridTextColumn  5"      $ Design��6[   $	 150 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   Z�    ClipboardContentBinding 68   Z� 6k     5#      $ Status��6[   $	 100 6k    6%   Z�  68   Z� 6k     5$      $ Capacity��6[   $	 100 6m    6%   Z�  68   Z� 6m   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ Action��6L   $	 100 6\      ClipboardContentBinding 6)   Z� 6\   5(      �� 5)   
   -   5        $ Delete��5)      $��	Supprimer��6!   $
��Left=�65   $��	38,15,0,0q�6P   $	��Top=�6c   $��75��6{   ���	#FFF56666
�������$��1��6�   $��20��6�   �� 5*   
   -   5        $	 Add��5*      $��Ajouter��6   $
��Left=�60   $��1,15,0,0q�6L   $	��Top=�6^   $��75��6v   ���	#FF60B0E8
�������
�������$��2��6�   $��20��6�   5-      5.      