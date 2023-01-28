﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordsA = new int[3];
System.Console.Write("Введите координату X точки А: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y точки А: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z точки А: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];
System.Console.Write("Введите координату X точки В: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y точки В: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z точки В: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0], 2) + Math.Pow(coordsB[1] - coordsA[1], 2) + Math.Pow(coordsB[2] - coordsA[2], 2));

System.Console.WriteLine(Math.Round(distance, 2));