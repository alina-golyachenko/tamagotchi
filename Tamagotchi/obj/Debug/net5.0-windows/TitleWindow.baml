   M S B A M L   `   `   `  ����E  ATamagotchi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Tamagotchi
Tamagotchi  5   	       Tamagotchi.TitleWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Tamagotchi     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          �Name$  titleWindow��5   8    � Title$ 
Tamagotchi��5	   	   $	��600��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�6o    � 
ResizeMode$ NoResize=�6�   .��5
      � $��0,0,0,-6q�6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ buttonLoadGame��5      $��Продовжити��6)   $
��Left=�6>   $��223,295,0,0q�6Y   $	��Top=�6n   $	��160��6�   $��50��6�   ���	#00DDDDDD$��4,4,4,4q�6�   
���   �$��3,3,3,3q�6�   $��Franklin Gothic Heavy)�6  $��16(�65  $y�	Collapsed=�6C  �� 5   
   -   5        $ buttonNewGame��5      $��Нова гра��6(   $
��Left=�6;   $��223,370,0,0q�6V   $	��Top=�6k   $	��160��6�   $��50��6�   ���	#00DDDDDD$��4,4,4,4q�6�   
���   �$��3,3,3,3q�6�   $��Franklin Gothic Heavy)�6  $��16(�61  �� 5   
   -   5        $ buttonQuitGame��5      $��
Вийти��6)   $
��Left=�69   $��223,441,0,0q�6T   $	��Top=�6i   $	��160��6�   $��50��6�   ���	#00DDDDDD$��4,4,4,4q�6�   
���   �$��3,3,3,3q�6�   $��Franklin Gothic Heavy)�6  $��16(�60  �� 5   
   -   5         ��Name$ imageLoading��5      $��Center=�6&   $	��300��6C   $��	0,226,0,0q�6P   $	��Top=�6c   $	��300��6{   $#��/Images/Menu/loadingDoggo.gif��6�    � Cursor$
 Wait��6�   $��Uniform=�6�   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$# /Images/Menu/loadingDoggo.gif��6�   �� 5   
   -   5        	 ��Name$	 labelLoading��5      $��
Loading...��6&   $
��Left=�6;   $��260,531,0,0q�6V   $	��Top=�6k   $��35��6�   $��86��6�   $��18(�6�   $��Franklin Gothic Heavy)�6�   �� 5   
   -   5        $ gameTitleImage��5      $
��Left=�6(   $��97��6C   $��
24,165,0,0q�6O   $	��Top=�6c   $��/Images/Title/title.png��6{   $	��539��6�   
 J� OpacityMask
 5      �� 5       �� ImageSource$ /Images/Title/title.png��6   5      5      5      