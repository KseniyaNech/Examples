﻿int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;// присваеваем к макс значение первой переменной
  
if(a > max) max = a; //если значение первой переменной больше чем макс, то в макс кладется новое значение 
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console. Write("max = ");//формат печати для того чтобы было понятно пользователю вносится такое редактирование текста в терминале
Console.WriteLine(max);//показать значение макс по итогу
