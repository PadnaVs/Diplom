   M S B A M L   `   `   `  ????u  qСистема тестирования студентов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Diplom_V4.pagesDiplom_V4.pages  5      &     Diplom_V4.pages.StartPageStudent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Diplom_V4.pages     5      -   5          N? Title$  StartPageStudent??5      .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? $??1??6   $??1??6"   .+?5      ?? $%??Добро пожаловать??6   $??Center=?6/   $??Center=?6L   $??5q?6g   ?? 5      -   5         ??Name$
 lbNT??5      $
??Name??6#   $??Center=?62   $??Center=?6O   $??0q?6j   $??28(?6u   ?? 5      $=??7Выберите тест для прохождения??6   $??5q?6<   ?? 5      -   5         ??Name$ testTab??5      $	??400??6(   $	??500??65   $??14(?6A   ??6O   ??  ?? Path$ TestsLoaded? ?? View 5      ?? 5      .P?5      ?? $!??Название теста??6)    ?? Width$
 auto??6A    ?? DisplayMemberBinding 6N   ?? $
 Name??? 5      $
 auto??6)   $ ??Преподаватель??66    6M   ?? $ 
Creater.fn?5       5"      ?? 5#      -   5        $%??Обновить таблицу??5#      $??24(?60   $	??240??6>   $??40??6J   $??	0,20,0,20q?6m   ?? 5$      	 ?? Orientation$	 
Horizontal=?6   $??Center=?62   $??Center=?6M   .+?5%      ?? -   5        $??Продолжить??5%      $??24(?6.   $	??200??6<   $??40??6H   $??0,0,10,0q?6i   ?? 5&      -   5        $??Вернуться??5&      $??24(?6-   $	??160??6;   $??40??6G   $??10,0,0,0q?6j   5'      5(      5)      5*      