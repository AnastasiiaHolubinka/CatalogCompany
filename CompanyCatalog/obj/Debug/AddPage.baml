   M S B A M L   `   `   `  ����I  ECompanyCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CompanyCatalogCompanyCatalog  5          CompanyCatalog.AddPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CompanyCatalog     5        N� Title$	  Add��5	      .��5      � .+�5   
   �� $��Add Company��6   $��DemiBold"�5      $��16(�5      $��Center=�5      $��40��5      
�������   	CaptureIt#���   5      $	��Top=�5      �� 5   
   $��Company Name��5      $
��Left=�5      $��150,100,0,0q�5      $	��Top=�5      $��25��5      $	��118��5      
�������#���   5      �� 5   
   -   5         ��Name$ CompanyName_TBox��5      $
��Left=�5      $��20��5       $��350,100,0,0q�5!       �� TextWrapping$
 Wrap=�5"      $��Enter Company Name��5#      $��Italic$�5$      $��Light"�5%      $	��Top=�5&      $	��180��5'      5(      �� 5)   
   $��Company Address��5*      $
��Left=�5+      $��150,150,0,0q�5,      $	��Top=�5-      
�������#���   5/      �� 50   
   -   5        $ CompanyAddress_TBox��51      $
��Left=�52      $��20��53      $��350,150,0,0q�54      $��Enter Company Address��55      $��Italic$�56      $��Light"�57      $	��Top=�58      $	��180��59      5:      �� 5;   
   $��Foundation Year��5<      $
��Left=�5=      $��150,200,0,0q�5>      $	��Top=�5?      
�������#���   5A      �� 5B   
   -   5        $ FoundationYear_TBox��5C      $
��Left=�5D      $��20��5E      $��350,200,0,0q�5F      $
 Wrap=�5G      $��Enter Foundation Year��5H      $��Italic$�5I      $��Light"�5J      $	��Top=�5K      $	��120��5L      5M      �� 5N   
   $��Annual Revenue��5O      $
��Left=�5P      $��150,250,0,0q�5Q      $	��Top=�5R      
�������#���   5T      �� 5U   
   -   5        $ AnnualRevenue_TBox��5V      $
��Left=�5W      $��20��5X      $��350,250,0,0q�5Y      $
 Wrap=�5Z      $��Enter Annual Revenue��5[      $��Italic$�5\      $��Light"�5]      $	��Top=�5^      $	��120��5_      5`      �� 5a   
   $��Business Type��5b      $
��Left=�5c      $��150,300,0,0q�5d      $	��Top=�5e      
�������#���   5g      �� 5h   
   -   5         ��Name$ BusinessType_TBox��5i      $
��Left=�5j      $��350,300,0,0q�5k      $	��Top=�5l      $	��120��5m      .@�5o      �� 	private6!   �� 5p      public6    �� 5q      
non-profit6$   �� 5r      venture capital6)   5s      �� 5t   
   -   5         ��Name$ AddBtn��5u      $	��Add��5v      $��Center=�5w      $��	0,350,0,0q�5x      $	��Top=�5y      $	��100��5z      $��20��5{      
����������#13242C#���   5~       J� RenderTransformOrigin$ 
0.476,2.96&�5   "   �� 5�   
   -   5        $ backBtn��5�        CircleShapeButtonStyle#���  5�      $
��Left=�5�      $	��Top=�5�      $��25��5�      $��25��5�      $��	40,40,0,0q�5�      .��5�      �� $��Assets/back.png��6   5�      5�      5�      