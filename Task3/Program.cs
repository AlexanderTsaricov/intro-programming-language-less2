﻿/*
Создать массив и заполнить его целыми
числами от 1 до N (N - произвольное
натуральное число). Вывести элементы
массива на экран.

Примеры:

N = 4
1 2 3 4

N = 6
1 2 3 4 5 6
*/

int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < arr.Length)
{
	arr[i] = i + 1;
	Console.Write($"{arr[i]} ");
	i = i + 1;
}