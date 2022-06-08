
Console.WriteLine("Ingrese el tamaño de las filas: ");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tamaño de las columnas: ");
int columnas = int.Parse(Console.ReadLine());

int [,] numeros = new int[filas, columnas];

double [] promedios = new double[columnas];

int longFilas = numeros.GetUpperBound(0) + 1;
int longColumnas = numeros.GetUpperBound(1) + 1;

for (int i = 0; i < longFilas; i++)
{
    Console.WriteLine();
    Console.WriteLine("Ingrese los numeros de la fila " + (i+1));
    for (int j = 0; j < longColumnas; j++)
    {
        Console.WriteLine("Ingrese el N° " + (j+1) + " de la fila N° " + (i+1) );
        numeros[i,j] = int.Parse(Console.ReadLine());
        
    }
}

Console.WriteLine("----------------------------------------");

for (int i = 0; i < longFilas; i++)
{
    Console.WriteLine();
    Console.WriteLine("Numeros de la fila " + (i+1));
    for (int j = 0; j < longColumnas; j++)
    {
        Console.WriteLine("columna " + (j+1) + ":");
        Console.WriteLine(numeros[i,j]);
    }
}

Console.WriteLine("----------------------------------------");

for (int i = 0; i < longColumnas; i++)
{
    int suma = 0;
    for (int j = 0; j < longFilas; j++)
    {
        suma = suma +  numeros[j,i];
    }
    promedios[i] = suma/longColumnas;
}

Console.WriteLine("----------------------------------------");
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine("Los promedios para cada columna son: ");
    Console.WriteLine(promedios[i]);
}




/*
Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/