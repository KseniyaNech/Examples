﻿// Алгоритм
// 1. Определить три точки
// 2. Выбрать две любых
// 3. Найти середину
// 4. Поставить точку
// 5. Выбрать случайную вершину треугольника
// 6. Соединить ее с полученной на 4 шаге точкой
// 7. Перейти к шагу 3
// 8. Шаги 3 - 7 повторить 9, 28, 31 раз


Console.Clear();//Очистка консоли
//Console.SetCursorPosition(10, 4);   //команда которая будет рисовать (отступ от левого края 10 символов, отступ от верхнего края 4 строчки начиная от 0)
//System.Console.WriteLine("^");     // печать на экране, треугольника занками "^"

int xa = 40, ya = 1, //определение вершин треугольника
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //устанавливаем точку ха, уа
Console.Write("^");// показываем точки на экране

Console.SetCursorPosition(xb, yb);
Console.Write("^");

Console.SetCursorPosition(xc, yc);
Console.Write("^");

int x = xa, y = xb;//случайная точка

int count = 0;// счетчик нахождения отрезка и деленное его пополам

while (count < 10000)//
{
    int what = new Random().Next(0, 3); //[0;3] 0 1 2 случайное число, выбор одной из трех точек
    if (what == 0)//если число what (точка) равно 0 то мы 
    {
        x = (x + xa) / 2;//должны положить середину отрезка
        y = (y + ya) / 2;
    }

    if (what == 1)//вторая точка
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)//третья точка
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);//установка в нужной позиции курсора
    Console.WriteLine("^");//печать курсора знаком "^"

    count = count + 1;//с каждым разом счетчик становится больше на одну позицию

}




