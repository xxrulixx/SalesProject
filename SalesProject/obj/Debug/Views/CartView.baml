   M S B A M L   `   `   `  ����G  CSalesProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SalesProject.ViewsSalesProject.Views  5      !    SalesProject.Views.CartView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SalesProject.Views     5      ^ ZCaliburn.Micro.Platform, Version=2.0.2.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   .+�5   
   �� $��Cart Products:��6   $��12(�5      $
��Bold"�6   ���#888888$��0��5      $��0��6!   � 5   
   -   5         �Name$ CartItemsPanel��5      $
��Left=�6,   $��0��6H   $��1��6X   $	��Top=�6e   .+�5      �� ��6   �� *CartProducts+��5      �� 5      .R�5      �  5      �� 5   "   $��* �63   �� 5   "   $��30 �63   �� 5    "   $��40 �63   �� 5!   "   $��30 �63   .+�5#      �� $��12(�6=   $
��Bold"�6K   ���#888888$��0��5$   3   ��5#   $   �� *Name+5$   3   �� 5%      $��12(�6<   $
��Bold"�6J   ���#888888$��1��5&   3   ��5%   $   �� *Qty+5&   3   �� 5'      $��12(�6>   $
��Bold"�6L   ���#888888$��2��5(   3   ��5'   $   �� *Price+5(   3   �� 5)      $��3��6%   $��-��65     Caliburn.Micro.Message   Attach$" ProductRemoved($dataContext)��6A   6u   5*      5+      5-      5.      �� 5/   
   $��2��6    �� Stretch$
 Fill=�6   
�������	 �� X2$ 1��6=   $	��Top=�6D   �� 50   
   -   5         ��Name$ 
TaxesLabel��50      $��Taxes:��6$   $
��Left=�65   $��2��6P   $	��Top=�6]   $
��Bold"�51      ���#8888886"   �� 52   
   -   5        $ Taxes��52      $
��0.00��6   $��Right=�6.   $��2��6J   $	��Top=�6W   $
��Bold"�53      ���#8888886"   �� 54   
   $��3��6   $
 Fill=�6   
�������$ 1��6=   $	��Top=�6D   �� 55   
   -   5        $ SubtotalLabel��55      $��	Subtotal:��6'   $
��Left=�6;   $��3��6V   $	��Top=�6c   $
��Bold"�56      ���#8888886"   �� 57   
   -   5        $ Subtotal��57      $
��0.00��6"   $��Right=�61   $��3��6M   $	��Top=�6Z   $
��Bold"�58      ���#8888886"   59      5:      