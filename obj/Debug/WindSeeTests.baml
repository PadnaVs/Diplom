   M S B A M L   `   `   `  ????u  qСистема тестирования студентов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Diplom_V4.srcDiplom_V4.src  5   	        Diplom_V4.src.WindSeeTests   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Diplom_V4.src     5   	   -   5        ???#5D016D$	??650??5	   	   $	??700??5
   	     ? Title$#  Просмотр тестов??5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? $??0??6   $??1??6"   .+?5      ?? $*??$Всё созданные тесты??6   $??0,10,0,0q?62   ?? 5      -   5         ??Name$ testTab??5      $	??480??6(   $	??500??65   $??14(?6A   ??6O   ??  ?? Path$ TestsLoaded? ?? View 5      ?? 5      .P?5      ?? $!??Название теста??6)    ?? Width$
 auto??6A    ?? DisplayMemberBinding 6N   ?? $
 Name??? 5      $
 auto??6)   $ ??Преподаватель??66    6M   ?? $ 
Creater.fn?5      5!      5"      ?? 5$   
   $??1??6   $??1??6#   .+?5%      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?62   .+?5&      ?? -   5        $%??Обновить таблицу??5&      $??40??64   $	??200??6@   $??	0,10,0,10q?6c   5'      ?? 5(      $ 
Horizontal=?6   $??Center=?62   .+?5)      ?? -   5        $-??'Редактирование теста??5)      $??40??68   $	??220??6D   $??0,0,10,0q?6g   ?? 5*      -   5        $!??Удаление теста??5*      $??40??62   $	??200??6>   $??10,0,0,0q?6_   5+      5,      5-      5.      