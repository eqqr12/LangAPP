   M S B A M L   `   `   `  ����  LanguageApp     LanguageApp.SettingsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Налаштування��5   	   $	��500��6   $	��700��6+      BackgroundColor#���   5   	     ForegroundColor#���  5   	   .��5      � $��20q�6   .+�5	   
   �� $	��Top=�6   $
��Left=�6-   .+�5
      �� -   5        $	��←��5
      $��47��6!   6,   5      �� 5   
   $��Center=�6   $��Center=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�62   .+�5      �� $��Темна тема:��6   $��Center=�6/   $��0,0,10,0q�6J   d� 5      -   5         d�Name$ ThemeToggle��5      $��60��5      $��30��6   $��10q�5      ��5      �� 5       �� 
TargetType" d�6    .�5      ��  �� Property � �� �� Value 5   "   �� 5   &    �� 
TargetType" d�66   .R�5   *   � $��60��6/   $��30��6:   .+�5   .   ��  ��Name$ SwitchBackground��65    �� CornerRadius$ 15��5   %   
�������
�������$��1q�5   %   A� 5    .   	 A�Name$	 SwitchThumb��66   $��28��5!   &   $��28��61   
�������$��1q�5#   &   $
��Left=�5$   &   $��Center=�5%   &   
 J� RenderTransformOrigin$
 0.5,0.5&�5&   &   5'   +    �� Triggers 5(   *   P� 5)   .    P� Property �@d�	IsChecked P� Value$
 TrueY�6K   . �5*   2   ��  �� 
TargetName$ SwitchBackground��69    � �� �#4CD9646m   �� 5+   2   $ SwitchBackground��69    � �� �#4CD9646n   �� 5,   2   $ SwitchThumb��69    � ��$ Right=�6q   5-   /   5/   '   51      52      54      55      �� 56      $��Version 1.2��6   $��Center=�6+   $��0,50,0,0q�6H   $��14(�6Z   57      59      5:      