   M S B A M L   `   `   `  ����K  GCustomControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CustomControlLibCustomControlLib  5      "    CustomControlLib.WeatherCard   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CustomControlLib     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��1.2* �6   �� 5      $
��0.9* �6   �� 5      $
��0.9* �6   .+�5   
   � $��0��6   .+�5      �� ���#3D95B9 J� Opacity$	 0.5Q�6'   �� 5      $Y��S                 pack://application:,,,/CustomControlLib;component/Images/Sunny.png��6   $
��60px��5      $��Center=�5      $��Center=�6,   5      � 5   
   $��1��6     5      �� 5      $
��0.8* �6    �� 5       .+�5#      �� $��2��6   ���#3D95B96)   �� 5&      -   5         ��Name$ TimeTbl��5&      $��12:00��6)   
�������$
��17px(�5'   ,   $��fonts/#Jura Regular)�5(      $��0��5)      $��Bottom=�5+      $��Center=�64   �� 5,      -   5        $ TempreatureTbl��5,      $
��21°��60   
�������$
��22px(�5-   ,   $��fonts/#Jura Regular)�5.      $��1��5/      $	��Top=�51      $��Center=�61   52      � 54   
   $��2��6     55      �� 56      �� 57       � ColumnDefinitions 59      �� 5:      �� 5;      .+�5>      �� $��2��6   $��2��6)   ���#3D95B9$	 0.5Q�6L   �� 5A      -   5        $ HumidityTbl��5A      $��	Влаж.��6-   
�������$
��15px(�5B   +   $��fonts/#Jura Regular)�5C      $��0��5D      $��0��6(   $��Bottom=�5E      $��Center=�63   �� 5F      -   5        $ 
FeelingTbl��5F      $��	Ощущ.��6,   
�������$
��15px(�5G   +   $��fonts/#Jura Regular)�5H      $��1��5I      $��0��6(   $��Bottom=�5J      $��Center=�63   �� 5K      -   5        $ HumidityPercentTbl��5K      $	��40%��64   
�������$
��14px(�5L   +   $��fonts/#Jura Regular)�5M      $��0��5N      $��1��6(   $	��Top=�5P      $��Center=�60   �� 5Q      -   5        $ FeelingDegreeTbl��5Q      $
��19°��62   
�������$
��14px(�5R   +   $��fonts/#Jura Regular)�5S      $��1��5T      $��1��6(   $	��Top=�5V      $��Center=�60   5W      5Y      5[      