   M S B A M L   `   `   `  ����R  Nmesajlasma_uygulamasi_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:mesajlasma_uygulamasi_2mesajlasma_uygulamasi_2  5   	   (    "mesajlasma_uygulamasi_2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:mesajlasma_uygulamasi_2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���#EDEDED � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��20q�6"    �� Orientation$ 
Horizontal=�6.   $��Center=�6G   .+�5      �� $��MQTT Broker URL:��6   $��Center=�6/   $��16(�6J   �� 5      -   5         ��Name$ BrokerUrlTextBox��5      $
��10,0q�60   $��Center=�6>   $	��300��6Y   $��16(�6e   ���#CCCCCC$��1q�6�   $��5q�6�   �� 5      -   5         ��Name$ ConnectButton��5      $
��10,0q�6,   $��Center=�6:   $	��100��6U   $��Bağlan��6a   $��16(�6r   ���#4CAF50
�������6�   5      �� 5   
   $��1��6   $��20q�6"   $ 
Horizontal=�6.   $��Center=�6G   .+�5      �� $��	Başlık:��6   $��Center=�6&   $��16(�6A   �� 5      -   5        $ TopicTextBox��5      $
��10,0q�6,   $��Center=�6:   $	��300��6U   $��16(�6a   ���#CCCCCC$��1q�6�   $��5q�6�   5      �� 5   
   $��2��6   $��20q�6"   $ 
Horizontal=�6.   $��Center=�6G   .+�5      �� $��Mesaj:��6   $��Center=�6%   $��16(�6@   �� 5      -   5        $ MessageTextBox��5      $
��10,0q�6.   $��Center=�6<   $	��300��6W   $��16(�6c   ���#CCCCCC$��1q�6�   $��5q�6�   �� 5      -   5        $ 
SendButton��5      $
��10,0q�6)   $��Center=�67   $	��100��6R   $��Gönder��6^   $��16(�6o   ���#2196F3
�������6�   5       �� 5"   
   $��3��6   $��20q�6$   $
��Auto=�60   .��5#      �� -   5         ��Name$ LogTextBlock��5#      $
��Wrap=�6.   $��16(�6B   ���#333333 �� Padding$ 10q�6e   5$      5%      5&      