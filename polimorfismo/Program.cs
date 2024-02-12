// See https://aka.ms/new-console-template for more information
using polimorfismo;

Console.WriteLine("calculo del cuadrado");



cuadrado cuadrado = new cuadrado();
Console.Write("Lado A: ");
cuadrado.ladoA=double.Parse (Console.ReadLine());
Console.Write("Lado B: ");
cuadrado.ladoB = double.Parse(Console.ReadLine());

Double resultado= cuadrado.calcularArea();
Double perimetro = cuadrado.calcularPerimetro();


Console.WriteLine("area de un cuadrado es: " + resultado);
Console.WriteLine("el perimetro del cuadrado es: " + perimetro);
