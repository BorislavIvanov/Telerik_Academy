   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    ProgramDioptase$   ProgramDioptase.ClientsLibrary   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  ClientsLibrary��5   	   $	��700��5   	   $	��900��5   	   
������� � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . .��5      �  J� RenderTransformOrigin$ 0.622,0.549&�6   .+�5   
   �� -   5         ��Name$ TopLeftRectangle��5      $��0,0,842,643q�5      
�������5      �� 5   
   -   5         ��Name$ ToMainWindow��5      $��Resources\back-arrow.png��5      $��0,2,840,644q�5      5      �� 5    
   -   5        $ 	MusicIcon��5       $(��"Resources\MainWindow\user-icon.png��5!      $��740,0,0,550q�5"      �� 5$   
   -   5        $ UsersDatabase��5$      $��273,199,10,11q�5%      
�������5&      � 5(   
   -   5         �Name$ InfoAboutClientGrid��5(      $��273,199,10,10q�5*      .+�5,      � -   5        $��PictureBoxContainer��5,      $��10,10,435,310q�5-      �� 5/      -   5        $ 	NameImage��5/      $-��'Resources\InfoAboutCatalogItem\Name.png��50      	 �� Left$		 230��51      

 �� Top$
 57��52      $��275,10,210,456q�6$   �� 54      -	   5         ��Name$ NameText��54      $��20(�55      $��WrapWithOverflow=�56      $		 247��57      $
 92��58      $��196,40,139,417q�6(    �� TextAlignment$ Center=�59      �� 5;      -
   5        $ AgeImage��5;      $$��Resources\Users Window\Age.png��5<      $		 230��5=      $
 57��5>      $��485,10,0,456q�6$   �� 5@      -   5        $ AgeText��5@      $��20(�5A      $��WrapWithOverflow=�5B      $		 247��5C      $
 92��5D      $��516,40,23,417q�6(   $ Center=�5E      �� 5G      -   5        $ AddressImage��5G      $(��"Resources\Users Window\Address.png��5H      $		 230��5I      $
 57��5J      $��196,90,289,376q�6$   �� 5L      -   5        $ AddressText��5L      $��20(�5M      $��WrapWithOverflow=�5N      $		 247��5O      $
 92��5P      $��328,90,7,376q�6(   $ Center=�5Q      �� 5S      -   5        $ 
PhoneImage��5S      $&�� Resources\Users Window\Phone.png��5T      $		 230��5U      $
 57��5V      $��196,156,289,310q�6$   �� 5X      -   5        $ 	PhoneText��5X      $��20(�5Y      $��WrapWithOverflow=�5Z      $		 247��5[      $
 92��5\      $��333,147,2,310q�6(   $ Center=�5]      5_      �� 5a   
   -   5         ��Name$ ClientsScrollViewer��5a      $
��Auto=�5b      $��10,119,650,10q�5c       � 	Resources 5e      ��%X   (��       5f      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   5Q�6^   5g      .��5i      �� -   5         ��Name$ ClientsListBox��5i      $
��Left=�5j      $	��571��5k      $��0,0,0,0q�5l      $	��Top=�5m      $	��240��5n      5p      �� 5r   
   -   5        $  BasketElementsScrollViewer��5r      $
��Auto=�5s      $y�Hidden=�5t      $��10,401,650,10q�5u       5w      ��%X   (��       5x      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   5Q�6^   5y      .��5{      �� -   5         ��Name$ BasketElementsStackPanel��5{       �� Orientation$ Vertical=�6;   5}      �� 5   
   -   5         ��Name$ SearchByNameBox��5      $	 20��5�      $��Center=�5�      $��20��5�       �� TextWrapping$
 Wrap=�5�      $��Search by name��5�      $��Center=�5�      $	��154��5�      $��Center=�5�       �� 	MaxLength$ 50��5�       �� MaxLines$ 1��5�      $��10,94,736,586q�5�      �� 5�   
   -   5         ��Name$ SearchButton��5�      $��Search��5�      $��Center=�5�      $��Center=�5�      $��74��5�       �� 	IsDefault . $		 195��5�      $��176,94,650,586q�5�      5�      5�      