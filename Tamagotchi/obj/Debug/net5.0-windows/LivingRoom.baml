   M S B A M L   `   `   `  ����E  ATamagotchi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Tamagotchi
Tamagotchi  5   	       Tamagotchi.LivingRoom   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Tamagotchi     5   	   -   5          �Name$  livingRoomWindow��5   	   $	��650��5   ^   $	��600��6m   $	��650��6}   $	��600��6�   $��Franklin Gothic Heavy)�6�    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�   ��5      �� 5	   
    � FocusVisualStyle 5      �� 5   
   .��5      � -   5         �Name$ livingRoomGrid��5      $��	10,0,10,0q�6#    � ColumnDefinitions 5   
   �� 5      $	��44* �6   �� 5      .+�5   
   �� -   5         ��Name$ pictureBoxPet��5      $
��Left=�6'   $	��100��6B   $��Center=�6O   $	��100��6j   $3��-/Images/Sprites/Regular/frontSheepRegular.png��6v   $��	265,0,0,0q�6�   � 5   
   -   5         �Name$ progressBarEmotions��5      $
��Left=�63   $��40��6N   $��
183,20,0,0q�6Z   $	��Top=�6n   $��40��6�   ���	#19000000 � Value$	 100Q�6�   	 � Orientation$	 Vertical=�6�   ��5      �� 5      
 �� ImageSource$*
 $/Images/Menu/Day/emotionsIconDay.png��6    j� Stretch$ Uniform=�6P   5      � 5   
   -   5        $ progressBarHealth��5      $
��Left=�61   $��40��6L   $��
227,20,0,0q�6X   $	��Top=�6l   $��40��6�   ���	#19000000$ 100.1Q�6�   $	 Vertical=�6�    J� RenderTransformOrigin$ -1.297,0.597&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.034Q�6&   T� 5       T� Y$ 0.013Q�6)   5       ��5"      �� 5#      $(
 "/Images/Menu/Day/healthIconDay.png��6   $ Uniform=�6N   5%      � 5&   
   -   5        $ progressBarSatiety��5&      $
��Left=�62   $��40��6M   $��	93,20,0,0q�6Y   $	��Top=�6l   $��40��6�   $	 100Q�6�   ���	#19000000$	 Vertical=�6�   ��5'      �� 5(      $)
 #/Images/Menu/Day/satietyIconDay.png��6   $ Uniform=�6O   5*      � 5+   
   -   5        $ progressBarEnergy��5+      $��40��61   $��
138,20,0,0q�6=   $	��Top=�6Q   ���	#19000000$	 100Q�6�   $	 Vertical=�6�   $
��Left=�6�   $��40��6�   ��5,      �� 5-      $(
 "/Images/Menu/Day/energyIconDay.png��6   $ Uniform=�6N   5/      �� 50   
   -   5         ��Name$ buttonGiveName��50      $��OK��6)   $
��Left=�66   $��
407,20,0,0q�6Q   $	��Top=�6e   $��40��6�   $��40��6�   ���	#00DDDDDD$��16(�6�   �� 51   
   -	   5         ��Name$ textBoxName��51      $
��Left=�6'   $��
274,20,0,0q�6B   $��Введіть ім'я��6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $��40��6�   $��Center=�6�   $��16(�6�   �� 52   
   -
   5        $ buttonStore��52      $��магазин��6&   $
��Left=�68   $��475,488,0,0q�6S   $	��Top=�6h   $��Center=�6�   $��Normal"�6�   ���	#00DDDDDD
���   �$��10,10,10,10q�6�    K� ZIndex$ 10��6  $��3,3,3,3q�6%  $��16(�6?  $��Franklin Gothic Heavy)�6M  $	��141��6p  $��2��6|  �� 53   
   -   5         ��Name$ labelTotalMoney��53      $��Label��6)   $
��Left=�69   $��
514,21,0,0q�6T   $	��Top=�6h   $��40��6�   $��Center=�6�   $
��Auto��6�   $��16(�6�   �� 54   
   $
��Left=�6   $��40��6+   $��
467,21,0,0q�67   $	��Top=�6K   $��40��6c   $��/Images/Menu/coinIcon.png��6n   �� 55   
   -   5        $ 
buttonPlay��55      $��пограти��6%   $
��Left=�67   $��
10,488,0,0q�6R   $	��Top=�6f   
���   ����	#00DDDDDD$��10,10,10,10q�6�   $��Normal"�6�   $ 10��6�   $��3,3,3,3q�6�   $��16(�6  $��Franklin Gothic Heavy)�6&  $	��141��6I  �� 56   
   -   5        $ buttonSleep��56      $��
спати��6&   $
��Left=�66   $��165,488,0,0q�6Q   $	��Top=�6f   
���   ����	#00DDDDDD$��10,10,10,10q�6�   $��Normal"�6�   $ 10��6�   $��3,3,3,3q�6�   $��16(�6  $��Franklin Gothic Heavy)�6'  $	��141��6J  �� 57   
   -   5        $ 
buttonWork��57      $ ��піти на роботу��6%   $
��Left=�6>   $��320,488,0,0q�6Y   $	��Top=�6n   
���   ����	#00DDDDDD$��10,10,10,10q�6�   $��Normal"�6�   $ 10��6�   $��3,3,3,3q�6  $��16(�6   $��Franklin Gothic Heavy)�6.  $	��141��6Q  �� 58   
   -   5        $ 
buttonMenu��58      $�� ��6%   $
��Left=�60   $��	20,20,0,0q�6K   $	��Top=�6^   $��41��6v   $��45��6�   ���	#00707070��59      �� 5:      $&
  /Images/Menu/Day/menuIconDay.png��6   5<      5>      5?      