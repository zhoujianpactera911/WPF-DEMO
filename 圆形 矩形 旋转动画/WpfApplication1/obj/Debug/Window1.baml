   M S B A M L   `   `   `  ����  WpfApplication1    WpfApplication1.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  Window1��5      $	��300��6   $	��300��6"   .��5      � .+�5   
   F� 
���  ����5      @� 5      -   5        ellipse1�� @� Center$ 50 50&�5   4    @� RadiusX$ 40Q�6C    @� RadiusY$ 40Q�6P    � Triggers 5
      :� 5       :� RoutedEvent$ Page.Loaded��6   .[�5      �� .��5      ��  g� RepeatBehavior$ Forever��6%    g� AutoReverse . .��5      ,�  �� 
TargetName$ ellipse1��5   !   	 �� TargetProperty$	 Center�5   !   
 ,� From$
 50 50X�5   !   	 ,� To$ 200 200X�5   !    g� Duration$ 0:0:5D�5   !   5      5      5      5      �� 5   
   -   5        $��
rectangle1��5   )   $��122,63,64,0q�6   
���   �$��45��6J   $	��Top=�6V   ��5      �� 5       �� Color$
 Blue��6"   -   5        
color1��5   /   z�5      �� 5       -   5        rotate1�� �� CenterX$ 0Q�5    3    �� CenterY$ 0Q�6?    �� Angle$ 0Q�6K    5"      :� 5#      $ Page.Loaded��6   .[�5$      �� .��5%      ��  .  $ Forever��69   .��5&      �� $ Forever��6-    .  �� From$
 BlueX�5'   +   	 �� To$	 RedX�5(   ,   $ 0:0:10D�5)   -   $ color1��5*   -   $	 Color�5+   ,   W� 5-      $ rotate1��5.   !   $	 Angle�5/   !    W� From$ 0X�50   !   	 W� To$	 360X�51   !   $ 0:0:10D�52   !   54      55      56      58      59      5:      