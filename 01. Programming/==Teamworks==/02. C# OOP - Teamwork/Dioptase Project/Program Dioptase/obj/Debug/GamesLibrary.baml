   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    ProgramDioptase"   ProgramDioptase.GamesLibrary   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  Games��5   	   $	��700��5   	   $	��900��5   	   
������� � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � Icon$, &Resources\TaskBar Icons\games-icon.png��5   	   .��5      � .+�5   
   9� -   5         9�Name$ GenreExpander��5      $��Genres��5      $��15(�5      $��777,138,10,28q�5      .��5      �� -   5         ��Name$ 
GenrePanel��5      $��0,4,-2,0q�5      
�������.+�5      �� -   5        $��3 2 0 0q�5      $��Action��6j   �� 5      -   5        $��3 2 0 0q�5      $��	Adventure��6j   �� 5      -   5        $��3 2 0 0q�5      $��Educational��6j   �� 5      -   5        $��3 2 0 0q�5      $	��FPS��6j   �� 5      -   5        $��3 2 0 0q�5      $��Horror��6j   �� 5       -	   5        $��3 2 0 0q�5       $��MMORPG��6j   �� 5!      -
   5        $��3 2 0 0q�5!      $��Role-Playing��6j   �� 5"      -   5        $��3 2 0 0q�5"      $��
Simulation��6j   �� 5#      -   5        $��3 2 0 0q�5#      $��Strategy��6j   �� 5$      -   5        $��3 2 0 0q�5$      $��Sport��6j   �� 5&      -   5         ��Name$ ResetCheckBoxexButton��5&      $��Reset��5'      $��50��5(      $��20��5)      $��Center=�5*      $��Center=�5+      $
��Left=�5,      $��12(�5-      $��4 5 0 0q�5.      5/      50      51      �� 53   
   -   5        	 ��Name$	 TopLeftRectangle��53      $��0,0,842,643q�54      
�������58      �� 5:   
   -   5        
 ��Name$
 ToMainWindow��5:      $��Resources\back-arrow.png��5;      $��0,2,840,644q�5<      5?      �� 5A   
   -   5        $	 TopRightRectangle��5A      $��779,0,0,580q�5B      
����d�5C      �� 5E   
   -   5        $
 GameIcon��5E      $)��#Resources\MainWindow\games-icon.png��5F      $��779,2,0,580q�5G      �� 5I   
   $��89,72,158,28q�6   $
��Auto=�5J       � 	Resources 5L      ��%X   (��       5M      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   5Q�6^   5N      .��5P      � -   5        $��AllGamesPanel��5P      5R      �� 5T   
   $��89,24,540,656q�6   $��Center=�5U      $��Center=�5V      $��20��5W      $	��271��5X      .+�5Z      �� -   5         ��Name$ 	SearchBox��5Z      $��10 0 0 0q�5[      $��Center=�5\      $��20��5]       �� TextWrapping$
 Wrap=�5^      $��Search by name��5_      $��Center=�5`      $	��164��5a      $��Center=�5b       �� 	MaxLength$ 50��5c       �� MaxLines$ 1��5d      5f      �� 5h      -   5        $��1��5h      $��Search��5i      $��Center=�5j      $��Center=�5k      $��75��5l       �� 	IsDefault .  �� Left$	 179��5o      5p      5r      5s      