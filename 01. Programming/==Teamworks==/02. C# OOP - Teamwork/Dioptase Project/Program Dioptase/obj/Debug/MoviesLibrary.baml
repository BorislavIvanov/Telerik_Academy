   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5       ProgramDioptase#   ProgramDioptase.MoviesLibrary   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      6sys&clr-namespace:System;assembly=mscorlib     5      -   5          � Title$  Movies��5	      $	��700��5
      $	��900��5      
������� � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � AllowsTransparency .  � Icon$, &Resources\TaskBar Icons\video-icon.png��5      .��5      � .+�5   
   9� -   5         9�Name$ GenreExpander��5      $��Genres��5      $��15(�5      $��777,138,10,28q�5      .��5      �� -   5         ��Name$ 
GenrePanel��5      $��0,4,-2,0q�5      
�������.+�5      �� -   5        $��3 2 0 0q�5      $��Action��6j   �� 5       -   5        $��3 2 0 0q�5       $��	Adventure��6j   �� 5!      -   5        $��3 2 0 0q�5!      $��	Animation��6j   �� 5"      -   5        $��3 2 0 0q�5"      $��Comedy��6j   �� 5#      -   5        $��3 2 0 0q�5#      $��Crime��6j   �� 5$      -	   5        $��3 2 0 0q�5$      $��Drama��6j   �� 5%      -
   5        $��3 2 0 0q�5%      $��Faction��6j   �� 5&      -   5        $��3 2 0 0q�5&      $��Fantasy��6j   �� 5'      -   5        $��3 2 0 0q�5'      $��
Historical��6j   �� 5(      -   5        $��3 2 0 0q�5(      $��Horror��6j   �� 5)      -   5        $��3 2 0 0q�5)      $��Mistery��6j   �� 5*      -   5        $��3 2 0 0q�5*      $��Philosophical��6j   �� 5+      -   5        $��3 2 0 0q�5+      $��	Political��6j   �� 5,      -   5        $��3 2 0 0q�5,      $��Romance��6j   �� 5-      -   5        $��3 2 0 0q�5-      $��Sci-Fi��6j   �� 5.      -   5        $��3 2 0 0q�5.      $��Thriller��6j   �� 5/      -   5        $��3 2 0 0q�5/      $��Urban��6j   �� 50      -   5        $��3 2 0 0q�50      $��	Adult 18+��6j   �� 52      -   5         ��Name$ ResetCheckBoxexButton��52      $��Reset��53      $��50��54      $��20��55      $��Center=�56      $��Center=�57      $
��Left=�58      $��12(�59      $��4 5 0 0q�5:      5;      5=      5>      �� 5@   
   -   5        	 ��Name$	 TopLeftRectangle��5@      $��0,0,842,643q�5A      
�������5E      �� 5G   
   -   5        
 ��Name$
 ToMainWindow��5G      $��Resources\back-arrow.png��5H      $��0,2,840,644q�5I      5L      �� 5N   
   -   5        $	 TopRightRectangle��5N      $��779,0,0,580q�5O      
����d�5P      �� 5R   
   -   5        $
 	MovieIcon��5R      $)��#Resources\MainWindow\video-icon.png��5S      $��779,10,0,591q�5T      �� 5V   
   $��89,72,158,28q�6   $
��Auto=�5W       � 	Resources 5Y      ��%X   (��       5Z      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   5Q�6^   5[      .��5]      � -   5        $��AllMoviesPanel��5]      5_      �� 5a   
   -   5         ��Name$ SearchFieldCanvas��5a      $��89,24,513,656q�5b      $��Center=�5c      $��Center=�5d      $��20��5e      $	��298��5f      .+�5h      �� -   5         ��Name$ SearchByNameBox��5h       �� Left$ 20��5i      $��Center=�5j      $��20��5k       �� TextWrapping$
 Wrap=�5l      $��Search by name��5m      $��Center=�5n      $	��164��5o      $��Center=�5p       �� 	MaxLength$ 50��5q       �� MaxLines$ 1��5r      5t      �� 5v      -   5        $ SearchButton��5v      $��Search��5w      $��Center=�5x      $��Center=�5y      $��75��5z       �� 	IsDefault . $	 195��5}      5~      5�      5�      