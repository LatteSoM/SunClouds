   M S B A M L   `   `   `  ����C  ?SunCloud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SunCloud.View.WindowsSunCloud.View.Windows  5   	   )    #SunCloud.View.Windows.PrimaryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SunCloud.View.Windows     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   $)��#/view/resources/fonts/#Jura Regular)�5	   	     � Title$  PrimaryWindow��5
   	   $	��274��6   $	��353��6/   $	��703��6>   $
��1203��6K    � WindowStyle$
 None=�6X    � 
ResizeMode$ CanResizeWithGrip=�6k    � AllowsTransparency$
 True��6�   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ MouseLeftButtonDown��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *
dragComm+5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   $	��353��6*   �� 5      $
��1.2* �6   $��0��6,   �� 5      $
��1.2* �6   $��0��6,   	 � RowDefinitions	 5   
   �� 5      $	��.1* �6   $
��24px��6)   �� 5      $	��.2* �6   $
��50px��6)   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��4��6;   $��3��6L   ��6   �� *WindowBackgroundStyleKey+6L   �� 5   
   
 �� Orientation$
 
Horizontal=�6   $��0��6.   $��2��6;   $��Right=�6K   $��0 5 5 0q�6g   .+�5       �� -   5         ��Name$ MinimizeWindowBtn��5    �   $
��15px��6   $
��20px��6&   $
��20px��67   $
��20px��6G   $��Stretch=�6�   $��Stretch=�6�   ��6W   �� *MinimizeWindowBtnStyleKey+��6�   �� *minimizeComm+.��5!      �� $,��&/view/resources/images/MinimizeBtn.png��6   5"      �� 5#      -   5        $ MaximizeWindowBtn��5#   �   $
��15px��6   $
��20px��6&   $
��20px��67   $
��20px��6G   $
��20px��6W   $��Stretch=�6�   $��Stretch=�6�   ��6d   �� *MaximizeWindowBtnStyleKey+��6�   �� *maximizeComm+.��5$      �� $,��&/view/resources/images/MaximizeBtn.png��6   5%      �� 5&      -   5        $ CloseWindowBtn��5&   �   $
��15px��6   $
��20px��6&   $
��20px��67   $
��20px��6G   $
��20px��6W   $��Stretch=�6�   $��Stretch=�6�   ��6d   �� *CloseWindowBtnStyleKey+��6�   �� *	closeComm+.��5'      �� $)��#/view/resources/images/CloseBtn.png��6   5(      5)      �� 5+   
   $��0��6   $��0��6$   $��4��61   ���	#FFFFD4C5 J� Opacity$ .5Q�6S    J� BitmapEffect 5,      F� 5-       F� 	Direction$ 0Q�6)    F� Opacity$
 0.25Q�67    F� ShadowDepth$ 2Q�6F    F� Softness$	 0.5Q�6V   5/      �� 50   
   -   5         ��Name$ CurrentCityTb��50      $��Center=�6k   $��Center=�6�   $��Normal"�6�   $��1��6�   $��0��6�   ��6+   �� *CurrCityTbStyleKey+��6P   �� *	p_citySet+6�   �� 51   
   $��1��6   $��0��6!   $��	18 0 18 0q�61   $	��1px��6D   ���#3D95B9$ .5Q�6f   $��Bottom=�6s   z�52      �� 53       �� ScaleY$ 3Q�6!   55      �� 56   
   $��1��6   $��1��6!   $��	18 0 18 0q�61   $	��1px��6D   ���#ffffff$ .5Q�6f   $��Bottom=�6s   z�57      �� 58      $ 3Q�6!   5:      �� 5;   
   $��1��6   $��2��6!   $��	18 0 18 0q�61   $	��1px��6D   ���#ffffff$ .5Q�6f   $��Bottom=�6s   z�5<      �� 5=      $ 3Q�6!   5?      �� 5A   
   -   5        $ WeatherPageBtn��5A   t    %  !WeatherSettingsBtnControlTemplate#���   65   $��1��6�   $��1��6�   $��Погода��6�   $
��Left=�6�   $��Center=�6�   $��Center=�6!  $��Center=�6<  ��6   �� *showWeatherComm+��6�   �� *ChangePageBtnStyleKey+6<  �� 5B   
   -   5        $ SettingsPageBtn��5B   u   #���   66   $��1��6�   $��2��6�   $��Настройки��6�   $��Right=�6�   $��Center=�6  $��Center=�6'  $��Center=�6B  ��6   �� *showSettingsComm+��6�   �� *ChangePageBtnStyleKey+6B  �� 5E   
   $��1��6   $��2��6'   $��2��64   $��2��6H   .��5F      � $��1��6   $��2��6#   $��2��60   $��2��6D   $	��700��6U   .+�5G       � -   5          �Name$ WeatherSettingsPageFrame��5G        � NavigationUIVisibility$ Hidden=�6:   ��6Z   ��  �� Path$ p_pageFrameContent� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5H      5I      �� 5M   
   $��2��6   $��2��6"   $
 Vertical=�63   .+�5N      �� $��10��6   $	��500��6   $��
0 90 140 0q�6,   $%��/view/resources/images/line.png��6@   �� 5O      $	��100��6   $	��100��6    $�� 0 -1000 140 0q�6-   $&�� /view/resources/images/sunny.png��6E    J� Effect 5P      3  -System.Windows.Media.Effects.DropShadowEffect  5Q         	Direction$	 270Q�6'      ShadowDepth$ 4Q�67      Opacity$ .3Q�6G   5S      �� 5T      $��60��6   $��60��6   $�� 0 -680 140 0q�6+   $&�� /view/resources/images/sunny.png��6B    5U        5V      $	 270Q�6'   $ 3Q�67   $ .3Q�6G   5X      �� 5Y      $��60��6   $��60��6   $�� 0 -440 140 0q�6+   $'��!/view/resources/images/cloudy.png��6B    5Z        5[      $	 270Q�6'   $ 2Q�67   $ .3Q�6G   5]      �� 5^      $��60��6   $��60��6   $�� 0 -170 140 0q�6+   $&�� /view/resources/images/rainy.png��6B    5_        5`      $	 270Q�6'   $ 2Q�67   $ .3Q�6G   5b      �� 5c      $
 Vertical=�6   $	��170��60   $��150 -1000 0 0q�6<   $	��100��6S   .+�5d      �� $
 
Horizontal=�6   $��Right=�66   .+�5e      �� -   5        $ NowWeatherSituationTb��5e       $��22(�6�   ��6?   �� *WeatherSituationTbDay+��6g   �� *p_opacityNow+$ TwoWay=�6�   �� 5f      -	   5        $ NowRealTemperatureTb��5f       $��22(�6�   ��6>   �� *WeatherSituationTbDay+��6f   �� *p_graduceNow+6�   5g      �� 5h      $
 Vertical=�6   $��Right=�64   .+�5i      �� $��Ощущается как��6H   $��22(�6]   $	��160��6k   ��6    �� *WeatherSituationTbDay+6k   �� 5j      -
   5        $ NowFeelingTemperatureTb��5j       $��22(�6�   $��Right=�6�   ��6A   �� *WeatherSituationTbDay+��6i   �� *p_feelsLikeNow+6�   5k      5l      �� 5n      $
 Vertical=�6   $	��200��60   $��150 -670 0 0q�6<   $��50��6R   .+�5o      �� $
 
Horizontal=�6   .+�5p      �� -   5        $ OneHourWeatherSituationTb��5p       ��6C   �� *WeatherSituationTbDay+��6k   �� *p_opacityPlusOne+�� 5q      -   5        $ OneHourRealTemperatureTb��5q       ��6B   �� *WeatherSituationTbDay+��6j   �� *p_graducePlusOneHour+5r      �� 5s      $
 
Horizontal=�6   .+�5t      �� $��Ощущается как��6H   ��6    �� *WeatherSituationTbDay+6H   �� 5u      -   5        $! OneHourFeelingTemperatureTb��5u       ��6E   �� *WeatherSituationTbDay+��6m   �� *p_feelsLikeOne+5v      5w      �� 5y      $
 Vertical=�6   $	��200��60   $��150 -420 0 0q�6=   $��50��6S   .+�5z      �� $
 
Horizontal=�6   .+�5{      �� -   5        $ TwoHourWeatherSituationTb��5{       ��6C   �� *WeatherSituationTbDay+��6k   �� *p_opacityPlusTwo+�� 5|      -   5        $ TwoHourRealTemperatureTb��5|       ��6B   �� *WeatherSituationTbDay+��6j   �� *p_graducePlusTwoHour+5}      �� 5~      $
 
Horizontal=�6   .+�5      �� $��Ощущается как��6H   ��6    �� *WeatherSituationTbDay+6H   �� 5�      -   5        $! TwoHourFeelingTemperatureTb��5�       $
��25°��6m   ��6E   �� *WeatherSituationTbDay+6m   5�      5�      �� 5�      $
 Vertical=�6   $	��200��60   $��150 -180 0 0q�6<   $��50��6R   .+�5�      �� $
 
Horizontal=�6   .+�5�      �� -   5        $! ThreeHourWeatherSituationTb��5�       ��6E   �� *WeatherSituationTbDay+��6m   �� *p_opacityPlusThree+�� 5�      -   5        $  ThreeHourRealTemperatureTb��5�       ��6D   �� *WeatherSituationTbDay+��6l   �� *p_graducePlusThreeHour+5�      �� 5�      $
 
Horizontal=�6   .+�5�      �� $��Ощущается как��6H   ��6    �� *WeatherSituationTbDay+6H   �� 5�      -   5        $# ThreeHourFeelingTemperatureTb��5�       $
��25°��6o   ��6G   �� *WeatherSituationTbDay+6o   5�      5�      �� 5�      -   5        $ 	OneHourTb��5�      $��40��6r   $��20��6}   $��-260 -680 0 0q�6�   ��6+   �� *WeatherSituationTbDay+��6S   �� *p_hourPlusOne+6�   �� 5�      -   5        $ 	TwoHourTb��5�      $��40��6r   $��20��6}   $��-260 -430 0 0q�6�   ��6+   �� *WeatherSituationTbDay+��6S   �� *p_hourPlusTwo+6�   �� 5�      -   5        $ ThreeHourTb��5�      $��40��6v   $��20��6�   $��-260 -180 0 0q�6�   ��6-   �� *WeatherSituationTbDay+��6U   �� *p_hourPlusThree+6�   5�      5�      5�      