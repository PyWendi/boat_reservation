   M S B A M L   `   `   `  ����J  FBoatReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BoatReservationBoatReservation  5   	   %    BoatReservation.UpdatePassenger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BoatReservation     5   	     � Title$  UpdatePassenger��5   	   $��440.174��6!   $��361.572��62   .��5	      � $��0,0,2,-1q�6   .+�5
   
   �� -   5         ��Name$ CancelB��5
      $��Annuler��6"   $
��Left=�64   $��206,366,0,0q�6O   $	��Top=�6d   $��75��6|   ���	#FFF56666
�������6�   �� 5   
   -   5        $ ConfirmB��5      $��	Confirmer��6#   $
��Left=�67   $��
81,366,0,0q�6R   $	��Top=�6f   $��75��6~   ���	#FF60B0E8
�������6�   �� 5   
   -   5         ��Name$ 
ErrorLabel��5      $�� ��6$   $
��Left=�6/   $��68,404,0,-20q�6J   $	��Top=�6`   $	��212��6x   �� 5   
   -   5        $ label��5      $	��NOM��6   $
��Left=�6-   $��	81,63,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $ label1��5      $��PRENOM��6    $
��Left=�61   $��
81,117,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ label2��5      $	��CIN��6    $
��Left=�6.   $��
81,173,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ label3��5      $��EMAIL��6    $
��Left=�60   $��
81,227,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label4��5      $��	TELEPHONE��6    $
��Left=�64   $��
81,280,0,0q�6O   $	��Top=�6c   �� 5   
   -	   5         ��Name$ 
FnameField��5      $
��Left=�6&   $��23��6A   $��	81,91,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��200��6�    � ToolTip$ 	Votre Nom��6�   �� 5   
   -
   5        $ 
LnameField��5      $
��Left=�6&   $��23��6A   $��
81,145,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $ Votre prénom (Optionnel)��6�   �� 5   
   -   5        $ CinField��5      $
��Left=�6$   $��23��6?   $��
81,204,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��200��6�   $ Votre CIN (optionnel)��6�   �� 5   
   -   5        $ 
EmailField��5      $
��Left=�6&   $��23��6A   $��
81,257,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $ Entrer l'email��6�   �� 5   
   -   5        $ TelField��5      $
��Left=�6$   $��23��6?   $��
81,311,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��200��6�   $$ Entrer le numero de téléphoe��6�   �� 5   
   -   5        $ label5��5      $��*��6    $
��Left=�6,   $��
111,62,0,0q�6G   $	��Top=�6[    J� RenderTransformOrigin$ 0.347,-0.703&�6s   ���	#FFFF05056�   �� 5   
   -   5        $ label5_Copy��5      $��*��6%   $
��Left=�61   $��131,116,0,0q�6L   $	��Top=�6a   $ 0.347,-0.703&�6y   ���	#FFFF05056�   �� 5   
   -   5        $ label5_Copy1��5      $��*��6&   $
��Left=�62   $��146,276,0,0q�6M   $	��Top=�6b   $ 0.347,-0.703&�6z   ���	#FFFF05056�   �� 5   
   -   5        $ TextID��5      $
��Left=�6"   $��23��6=   $��	81,34,0,0q�6I   $
 Wrap=�6\   $	��Top=�6p   $	��200��6�   $y�Hidden=�6�    �� 
IsReadOnly . 6�   5      5      