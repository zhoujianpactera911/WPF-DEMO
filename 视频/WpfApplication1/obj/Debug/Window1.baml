   M S B A M L   `   `   `  ����  WpfApplication1    WpfApplication1.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  Window1��5      $	��293��6   $	��385��6"   .��5      �  � Triggers 5   
   :� 5       :� 
SourceName$ mediaElement1��6    :� RoutedEvent$ MediaElement.Loaded��66   [�5      �� 5	      -   5         ��Name$ sb��5	   &   .��5
      �� .��5      p� -   5         p� Source$ xbox.wmv?�5   1    �� 
TargetName$ mediaElement1��5   1    g� RepeatBehavior$ Forever��5   1   5   1   5      5      5      :� 5      $ btnPause��6   $ Button.Click��61   [�5      ?� 5       �� BeginStoryboardName$ sb��6&   5      :� 5      $ 	btnResume��6   $ Button.Click��62   [�5      �� 5      $ sb��6'   5      .+�5    
   r� -   5        $��mediaElement1��5    ?   $��0,0,0,61q�6T   5!      �� 5"   
   -   5        $��btnPause��5"   J   $��23��6   $
��Left=�6   $��68,0,0,7q�68   $��Bottom=�6Z   $��75��6u   .��6�   Pause6�   �� 5#   
   -   5        $��	btnResume��5#   2   $��23��6   $��162,0,126,7q�6   $��Bottom=�6C   .��6^   Resume6f   �� 5$   
   -   5        $��
timeSlider��5$   1   $��21��6   $��
43,0,55,37q�6   $��Bottom=�6C   5%      5&      