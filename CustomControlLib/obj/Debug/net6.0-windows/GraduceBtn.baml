   M S B A M L   `   `   `  ����K  GCustomControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CustomControlLibCustomControlLib  5      !    CustomControlLib.GraduceBtn   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CustomControlLib     5        � 	Resources  5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  OptionMarkFocusVisual ! RadioButton.Static.Background �� Color  RadioButton.Static.Border  RadioButton.Static.Glyph $  RadioButton.MouseOver.Background   RadioButton.MouseOver.Border  RadioButton.MouseOver.Glyph " RadioButton.Pressed.Background 	 RadioButton.Pressed.Border 
 RadioButton.Pressed.Glyph # RadioButton.Disabled.Background  RadioButton.Disabled.Border  RadioButton.Disabled.Glyph  RadioButtonStyle1 �� 
TargetType �� 
TargetType �Name	 � ColumnDefinitions
 ��Name �� CornerRadius A�Name J� Opacity ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 m    &	 �    &	 �    &	 �    &	 �    &	     &	 ?    &		 b    &	
 �    &	 �    &	 �    &	 �    &	     7   7  7  7  7  7  7  7  7  7  7  7  7 	 7 
 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��14,0,0,0q�6$   $	 1 2R�66   #��� ��6L   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFFFFFFF��6@   �� 5   
   $ 	#FF707070��6<   �� 5   
   $ 	#FFFFFFFF��6;   �� 5   
   $ 	#FFF3F9FF��6C   �� 5    
   $ 	#FF5593FF��6?   �� 5!   
   $ 	#FF3C77DD��6>   �� 5"   
   $ 	#FFD9ECFF��6A   �� 5#   
   $ 	#FF3C77DD��6=   �� 5$   
   $ 	#FF3C77DD��6<   �� 5%   
   $ 	#FFE6E6E6��6B   �� 5&   
   $ 	#FFBCBCBC��6>   �� 5'   
   $ 	#FF707070��6=   �� 5(   
   " 	�6*   .�5)      ��  �@�FocusVisualStyle8   61   �� 5*       � ��8  6+   �� 5+       � ��8  6,   �� 5,       � ��# � ��6+   �� 5-       � ��$ 1q�60   �� 5.       � �� 5/      �� 50      " 	�6&   .R�51      � $ templateRoot��6   
������ $
 True��6N   	 52      �� 53   "   $
��Auto �63   �� 54   "   $��* �63   .+�56      �� $
 radioButtonBorder��6%   
������ 
�������$��2q�6m   $	 100��6�   #��z��6�   $��10,1,0,1q�6�   #��z��6�   ._�57   "   � $ markGrid��6'   $��2q�69   .+�58   &   A� $ 
optionMark��6.   8�� $��10��6s   $��10��6�   $ 0Q�6�   59   #   5:      �� 5;      $ contentPresenter��6/   $��1��6I   $|�False��6Y   #��z��6k   #��z��6�   $
��True��6�   # z 6�   #��z��6(  5<       5=      P� 5>       � ��$
 true��6<   . �5?   "   �� 8   �@�FocusVisualStyle6E   �� 5@   "    � ��$ 4,-1,0,0q�6<   5A      P� 5B       �@J�IsMouseOver$
 true��6=   . �5C   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5D   "   $ radioButtonBorder��6@   8   � ��6_   �� 5E   "   $ 
optionMark��69   8   � ��6Q   5F      P� 5G       � {�$ false��6;   . �5H   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5I   "   $ radioButtonBorder��6@   8 	  � ��6_   �� 5J   "   $ 
optionMark��69   8 
  � ��6Q   5K      P� 5L       � ��$
 true��6;   . �5M   "   �� $ radioButtonBorder��6?   8   � ��6^   �� 5N   "   $ radioButtonBorder��6@   8   � ��6_   �� 5O   "   $ 
optionMark��69   8   � ��6Q   5P      P� 5Q       �@d�	IsChecked$
 trueY�6;   . �5R   "   �� $ 
optionMark��6<    �@J�Opacity$ 1Q�6T   5S      P� 5T       6;   Z�  �@d�	IsChecked. �5U   "   �� $ 
optionMark��6<    �@J�Opacity$
 0.56Q�6T   5V      5X      5Z      5[      5\      .��5]      �� $ 5��6   ���	#7F3D95B9
������ $	��0.3q�6O   ._�5^   
   � 	 5_      �� 5`      $��1* �6#   .+�5c      	� #���  6   $��0��6F   $��Center=�6V   $��Center=�5d      ���#ffffff���#ffffff$��4q�5f      $
��auto��5g      $��24��5h      .��5i      �� $��1��6   $��Цельсий C°��6,   $��Center=�5j      $��Center=�5k      ���#ffffff$��20��5m      $��15(�5n      $��fonts/#Jura Regular)�6"   $��	20 1 30 0q�5o      5p      5q      5r      5s      