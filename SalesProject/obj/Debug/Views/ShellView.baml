   M S B A M L   `   `   `  ����G  CSalesProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SalesProjectSalesProject  5   	   '    !SalesProject.ViewModels.ShellView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^ ZCaliburn.Micro.Platform, Version=2.0.2.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5   	   &localclr-namespace:SalesProject  5   	     � Title$  
MainWindow��5	   	   $	��480��6   $	��640��6)   ���#202020.��5      � -   5        $��
RootLayout��5      $��5q�6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Sales Screen��6   $��15(�5      $
��Bold"�6   ���#AAAAAA$��0��5      $��0��6!   $��3��6.   � 5   
   $��0��6   $��1��6   $��5q�6,   .+�5      �� -   5         ��Name$ CategoryListViewModel��5      5      � 5   
   $��1��6   $��1��6   .+�5      �� -   5        $ ProductListViewModel��5      5       � 5!   
   $��2��6   $��1��6   .+�5"      �� -   5        $ CartViewModel��5"      5#      �� 5$   
   -   5         ��Name$ CartCompleteButton��5$      $��	Complete!��6-   $��2��6A   $��2��6R   $��0q�6`   ���#290000$��20(�5%      $
��Bold"�6   ���#AAAAAA5&      5'      5(      