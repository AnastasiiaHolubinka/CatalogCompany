   M S B A M L   `   `   `  ����I  ECompanyCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CompanyCatalogCompanyCatalog  5          CompanyCatalog.SearchPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CompanyCatalog     5        N� Title$  
SearchPage��5	      .��5      � .+�5   
   �� $��Search Company Catalog��5      $��DemiBold"�5      $��20(�5      $��Center=�5      $��40q�5      $	��Top=�5      
�������   	CaptureIt#���   5      $	��285��61   �� 5   
   -   5         ��Name$ 	searchBox��5       � ForceCursor . $��Center=�5      $��20��5      $	��105q�5       �� TextAlignment$ Justify=�5      $��12(�5       �� TextWrapping$
 Wrap=�5      $��Enter Company Name��5      $��Italic$�5       $��Light"�5!      $	��Top=�5"      $	��300��5#       �� MaxLines$ 1��5$       �� MinLines$ 1��5%      5&      �� 5'   
   -   5        $��Search��5(      $��Center=�5)      $	��130q�5*      $	��Top=�5+      $	��100��5,      $��20��5-      
����������#13242C#���   50      51      �� 52   
   -   5         ��Name$ EditBtn��54      $
��Edit��53      $��Center=�55      $��0,350,350,0q�56      $	��Top=�57      $	��100��58      $��20��59      
����������#13242C#���   5<       J� RenderTransformOrigin$ 
0.09,0.463&�5=   #   �� 5>   
   -   5        $ DelBtn��5?      $��Delete��5@      $
��Left=�5A      $��400,350,0,0q�5B      $	��Top=�5C      $	��100��5D      $��20��5E      
����������#13242C#���   5H      5I      �� 5K   
   -   5        $ backBtn��5L        CircleShapeButtonStyle#���  5M      
�������$
��Left=�5O      $	��Top=�5P      $��25��5Q      $��25��5R      $��	40,40,0,0q�5S      .��5U      �� $��/Assets/back.png��6   5V      �� 5W   
   -   5        	 ��Name$	 WarningSearchLabel��5X      $��* Enter Company Name��5Y      
���  ��$��10(�5[      $y�Hidden=�5\      $
��Left=�5]      $��
180,80,0,0q�5^      $	��Top=�5_      &   System.Windows.Controls.DataGrid  5`   
   -   5        
  Name$
 	gridTable��5a         AlternatingRowBackground �#576E66$   HorizontalScrollBarVisibility$ Disabled=�5c      "   VerticalScrollBarVisibility$
 Auto=�5d         MinColumnWidth$ 50Q�5e         
IsReadOnly . $
��Left=�5h      $	��156��5i      $��
27,178,0,0q�5j      $	��Top=�5k      $	��613��5l         FrozenColumnCount$ 5��5m         SelectionMode$ Single=�5n      $ 0.508,0.487&�5p      ��5g      �� 5p      5q      5r      