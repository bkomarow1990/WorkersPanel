   M S B A M L   `   `   `  ����G  CWorkersPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WorkersPanelWorkersPanel  5   	       WorkersPanel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WorkersPanel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1280��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   .+�5   
   � .+�5      ��  �� CornerRadius$ 20��6   
���   �$��7q�6;   $��10q�6O   ._�5      �� -   5         ��Name$ workersListBox��5      $��10q�62   $��Stretch=�6o   ��6>   �� *WorkerContext.WorkerList+ �� SelectedItem 6�   �� *SelectedWorker+��5      �� 5      .R�5      �  5   "   �� 5   &   $��1* �67   6D   �� 5   &   69   .+�5      ]� $��5q�6(   $��55��63   $��0��6?   .+�5   "   �� $��45��6(   $
��Left=�6V   $��Center=�6l   $��	10,0,25,0q�6�   ��64   ��  �� Path$ 	ImagePath�6�   �� 5   "   $��16(�6,   $
��Left=�6U   $��Center=�6k   $��0,0,5,0q�6�   ��6:   �� $
 Name�6�   �� 5   "   $��16(�6,   $
��Left=�6X   $��Center=�6n   $��0,0,5,0q�6�   ��6:   �� $ Surname�6�   �� 5   "   $��16(�6,   $
��Left=�6k   $��Center=�6�   $��0,0,20,0q�6�   ��6:   ��  �� StringFormat$ ( {0} )��$	 Age�6�   5      ]� 5   "   $��1��6,   .+�5    &   �� $��Center=�6N   $
��Left=�6i   $
��Left=�6    d� 	IsChecked 6/   �� *
IsActive+6�   �� 5!   &   $��16(�60   $��IsActive��6>   $��Center=�6N   $
��Left=�6i   $��5,0,0,0q�6   6�   5"   #   5#      5$      5&      5'      5(      � 5)   
   $��1��6   .+�5*      �� $ 20��6   
���   �$��7q�6;   $��10q�6O   ._�5+      ]� $��1��6   ��.  $��Center=�6B   $��Center=�6]   .+�5,      �� -   5        $��addNewWorkerBtn��5,   X   $	��Top=�6      ManageButton#��[  62   .��6�   AddNewWorker6�   �� 5-      -   5        $��editWorkerBtn��5-   X   $	��Top=�6   #��[  62   .��6�   
EditWorker6�   �� 5.      -   5        $��deleteWorkerBtn��5.   X   $	��Top=�6   #��[  62   .��6�   DeleteWorker6�   �� 5/      -   5        $��cleanWorkersBtn��5/   X   $	��Top=�6   #��[  62   .��6�   CleanWorkersList6�   50      51      52      53      54      