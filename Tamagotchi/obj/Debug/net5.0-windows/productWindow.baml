   M S B A M L   `   `   `  ����E  ATamagotchi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Tamagotchi
Tamagotchi  5   	       Tamagotchi.ProductWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Tamagotchi     5   	   -   5          �Name$  productWindow��5   	   $	��310��5   :   $	��260��6I   $��Center=�6Y   $��Center=�6}    � WindowStartupLocation$ CenterOwner=�6�    � 
ResizeMode$ NoResize=�6�   .��5      � $
��Auto��6   $	��300��6   $	��250��6(   $��Center=�68   $	��Top=�6U   $	��214��6m    � ColumnDefinitions 5	   
   �� 5
      .+�5   
   �� -   5         ��Name$ labelProductName��5      $��Label��6*   $��Center=�6:   $	��Top=�6W   $��Center=�6o   $��0,6,0,0q�6�   $��Franklin Gothic Heavy)�6�   $��16(�6�   �� 5   
   $��	Ціна:��6   $
��Left=�6    $��1,35,0,0q�6;   $	��Top=�6M   $��25��6e   $��2,2,2,2q�6q   $
��Left=�6�   $��Stretch=�6�   $��Franklin Gothic Heavy)�6�   $��14(�6�   �� 5   
   -   5        $ labelNameSatiety��5      $��Ситність:��6*   $
��Left=�6>   $��1,95,0,0q�6Y   $	��Top=�6k   $��25��6�   $��2,2,2,2q�6�   $
��Left=�6�   $��Stretch=�6�   $��Franklin Gothic Heavy)�6�   $��14(�6	  �� 5   
   -   5        $ labelNameTaste��5      $��	Смак:��6(   $
��Left=�68   $��	1,123,0,0q�6S   $	��Top=�6f   $��25��6~   $��2,2,2,2q�6�   $
��Left=�6�   $��Stretch=�6�   $��Franklin Gothic Heavy)�6�   $��14(�6  �� 5   
   -   5        $ labelProductPrice��5      $��Label��6+   $��Right=�6;   $��
148,32,0,0q�6W   $��Stretch=�6k   $��Right=�6�   $��Franklin Gothic Heavy)�6�   $��14(�6�   �� 5   
   -   5        $ labelProductPoints��5      $��Label��6,   $��Right=�6<   $��
0,60,0,111q�6X   $��Right=�6l   $��Franklin Gothic Heavy)�6�   $��14(�6�   �� 5   
   -   5        $ labelProductTastiness��5      $��Label��6/   $��Right=�6?   $��
0,119,0,51q�6[   $��Right=�6o   $��51��6�   $��Franklin Gothic Heavy)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 
buttonFeed��5      $��нагодувати��6%   $
��Left=�6:   $��
11,151,0,0q�6U   $	��Top=�6i   $��91��6�   $��30��6�   ���	#00DDDDDD
���   �$��Franklin Gothic Heavy)�6�   $��5,5,5,5q�6�   $��2,2,2,2q�6  $��14(�6+  �� 5   
   -	   5        $ buttonCancel��5      $��відміна��6'   $��Right=�69   $��
0,151,13,0q�6U   $	��Top=�6i   $��94��6�   $��30��6�   ���	#00DDDDDD
���   �$��Franklin Gothic Heavy)�6�   $��5,5,5,5q�6  $��2,2,2,2q�6  $��14(�6-  �� 5   
   -
   5        $ labelNamePoints��5      $��Бали 
��6)   $
��Left=�6C   $��1,65,0,0q�6^   $	��Top=�6p   $��25��6�   $��2,2,2,2q�6�   $
��Left=�6�   $��Stretch=�6�   $��Franklin Gothic Heavy)�6�   $��14(�6  �� 5   
   -   5        $ labelProductSatiety��5      $��Label��6-   $��Right=�6=   $��	0,90,0,77q�6Y   $��Right=�6l   $��Franklin Gothic Heavy)�6�   $��14(�6�   5      5      