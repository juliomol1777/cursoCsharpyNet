﻿// See https://aka.ms/new-console-template for more information
int contador= 0;
int acumulador = 0;
int mayor;
int menor;
double promedio;

int [] numeros = new int [10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese el valor n° " + (i+1));
    numeros [i] = int.Parse(Console.ReadLine());
    acumulador += numeros [i];
    contador+=1;
    
}

promedio = acumulador/contador;
Console.WriteLine("Los numreros ingresados son: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

mayor = numeros [0];
menor = numeros [0];

for (int i = 1; i < numeros.Length; i++)
{
    
    if(numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    else if (numeros[i] <= menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("La suma de los numeros ingresados es: " + acumulador);
Console.WriteLine("El mayor de los numeros ingresados es: " + mayor);
Console.WriteLine("El menor de los numeros ingresados es: " + menor);
Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);

/*
Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

*/
