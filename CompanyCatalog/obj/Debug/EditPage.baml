   M S B A M L   `   `   `  ����I  ECompanyCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CompanyCatalogCompanyCatalog  5          CompanyCatalog.EditPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CompanyCatalog     5        N� Title$  EditPage��5	      .��5      � .+�5   
   �� $��Edit Company��5      $��DemiBold"�5      $��20(�5      $��Center=�5      $��40q�5      
�������   	CaptureIt#���   5      $	��Top=�5      �� 5   
   $��Company Name��5      $
��Left=�5      $��150,100,0,0q�5      $	��Top=�5      $��25��5      $	��105��5      
�������#���   5      �� 5   
   -   5         ��Name$ CompanyName_TBox��5      $
��Left=�5       $��20��5!      $��350,100,0,0q�5"      $	��Top=�5#      $	��180��5$      5%      �� 5&   
   $��Company Address��5'      $
��Left=�5(      $��150,150,0,0q�5)      $	��Top=�5*      
�������#���   5,      �� 5-   
   -   5        $ CompanyAddress_TBox��5.      $
��Left=�5/      $��20��50      $��350,150,0,0q�51      $	��Top=�52      $	��180��53      54      �� 55   
   $��Foundation Year��56      $
��Left=�57      $��150,200,0,0q�58      $	��Top=�59      
�������#���   5;      �� 5<   
   -   5        $ FoundationYear_TBox��5=      $
��Left=�5>      $��20��5?      $��350,200,0,0q�5@      $	��Top=�5A      $	��120��5B      5C      �� 5D   
   $��Annual Revenue��5E      $
��Left=�5F      $��150,250,0,0q�5G      $	��Top=�5H      
�������#���   5J      �� 5K   
   -   5        $ AnnualRevenue_TBox��5L      $
��Left=�5M      $��20��5N      $��350,250,0,0q�5O      $	��Top=�5P      $	��120��5Q      5R      �� 5S   
   $��Business Type��5T      $
��Left=�5U      $��150,300,0,0q�5V      $	��Top=�5W      
�������#���   5Y      �� 5Z   
   -   5         ��Name$ BusinessType_TBox��5[      $
��Left=�5\      $��350,300,0,0q�5]      $	��Top=�5^      $	��120��5_      .@�5a      �� 	private6!   �� 5b      public6    �� 5c      
non-profit6$   �� 5d      venture capital6)   5e      �� 5f   
   -   5         ��Name$ 	UpdateBtn��5g      $��Update��5h      $��Center=�5i      $��	0,350,0,0q�5j      $	��Top=�5k      $	��100��5l      $��20��5m      
����������#13242C#���   5p      5q      �� 5r   
   -   5        $ backBtn��5s        CircleShapeButtonStyle#���  5t      $
��Left=�5u      $	��Top=�5v      $��25��5w      $��25��5x      $��	40,40,0,0q�5y      .��5{      �� $��Assets/back.png��6    J� RenderTransformOrigin$ 0.391,1.913&�6-   5|      5}      5~      