   M S B A M L   `   `   `  ����J  FBoatReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BoatReservationBoatReservation  5   	   "    BoatReservation.AddPassenger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BoatReservation     5   	     � Title$  AddPassenger��5   	   $��444.611��6   $��381.737��6/    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � .+�5
   
   �� -   5         ��Name$ CancelB��5
      $��Annuler��6"   $
��Left=�64   $��222,339,0,0q�6O   $	��Top=�6d   $��75��6|   ���	#FFF56666
�������6�   �� 5   
   -   5        $ ConfirmB��5      $��	Confirmer��6#   $
��Left=�67   $��
97,339,0,0q�6R   $	��Top=�6f   $��75��6~   ���	#FF60B0E8
�������6�   �� 5   
   -   5         ��Name$ 
ErrorLabel��5      $�� ��6$   $
��Left=�6/   $��
84,377,0,0q�6J   $	��Top=�6^   $	��212��6v   �� 5   
   -   5        $ label��5      $	��NOM��6   $
��Left=�6-   $��	97,36,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $ label1��5      $��PRENOM��6    $
��Left=�61   $��	97,90,0,0q�6L   $	��Top=�6_   �� 5   
   -   5        $ label2��5      $	��CIN��6    $
��Left=�6.   $��
97,146,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ label3��5      $��EMAIL��6    $
��Left=�60   $��
97,200,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label4��5      $��	TELEPHONE��6    $
��Left=�64   $��
97,253,0,0q�6O   $	��Top=�6c   �� 5   
   -	   5         ��Name$ 
FnameField��5      $
��Left=�6&   $��23��6A   $��	97,64,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��200��6�    � ToolTip$ 	Votre Nom��6�   �� 5   
   -
   5        $ 
LnameField��5      $
��Left=�6&   $��23��6A   $��
97,118,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $ Votre prénom (Optionnel)��6�   �� 5   
   -   5        $ CinField��5      $
��Left=�6$   $��23��6?   $��
97,177,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��200��6�   $ Votre CIN (optionnel)��6�   �� 5   
   -   5        $ 
EmailField��5      $
��Left=�6&   $��23��6A   $��
97,230,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $ Entrer l'email��6�   �� 5   
   -   5        $ TelField��5      $
��Left=�6$   $��23��6?   $��
97,284,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��200��6�   $$ Entrer le numero de téléphoe��6�   �� 5   
   -   5        $ label5��5      $��*��6    $
��Left=�6,   $��
127,35,0,0q�6G   $	��Top=�6[    J� RenderTransformOrigin$ 0.347,-0.703&�6s   ���	#FFFF05056�   �� 5   
   -   5        $ label5_Copy��5      $��*��6%   $
��Left=�61   $��
147,89,0,0q�6L   $	��Top=�6`   $ 0.347,-0.703&�6x   ���	#FFFF05056�   �� 5   
   -   5        $ label5_Copy1��5      $��*��6&   $
��Left=�62   $��162,249,0,0q�6M   $	��Top=�6b   $ 0.347,-0.703&�6z   ���	#FFFF05056�   5      5      