   M S B A M L   `   `   `  ����  	SDKSample    VideoText.Window1   5   	   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        $��myWindow��5        � Title$"  Ball following Video in Text��5      
���   � � WindowState$ 	Maximized=�5      .��5      (�  (� Stretch$ Uniform=�6   .��5	      �� -   5        $��canvas��5
      
���   �$	��400��5      $	��300��5      .+�5      r� -   5        $��myMediaElement��5   	   
 �� Top$ 10��5   	    �� Left$ 40��5   	    � Triggers 5   
   :� 5       :� RoutedEvent$ MediaElement.Loaded��6   [�5      �� 5      .��5      �� .��5      p�  p� Source$ xbox.wmv?�6"    �� 
TargetName$ myMediaElement��64   	 g� RepeatBehavior$	 Forever��5      5      5      5      5    	   F� 5$      -   5        $
��path��5'   	   $ 10��5%   	   $ 40��5&   	   
�������
������ 5)   	   A� 5-      -   5        $��ellipse��5/   	   $y�Hidden=�5.   	   $ 0��50   	   $ 30��51   	   $��20��52   	   $��20��53   	   ��54   
   
� 55      .��56      � 
 � Color$
 #ffff��6    � Offset$ 0Q�6+   � 57      $
 #0fff��6   $ 1Q�6+   58      z�5:   
   u� 5;       5=   
   :� 5>      $ FrameworkElement.Loaded��6   [�5?      �� 5@      .��5A      �� -   5         ��Name$ 
storyboard��5A      .��5B      z� -   5         z�Name$ matrixAnimation��5C       g� Duration$ 0:00:59D�5D      $	 Forever��5E       �� TargetProperty$ RenderTransform.Matrix�5F      5G      5H      5J      5L   	   5N      5O      5P      