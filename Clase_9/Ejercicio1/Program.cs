Console.WriteLine("Ingrese la longitud del vector: ");
int longitud = int.Parse(Console.ReadLine());
int [] vector = new int[longitud];
Random aleatorio = new Random();

//lleno vector con numeros de 1-100
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(100);
}

Console.WriteLine("El Vector creado contiene: ");

foreach (var item in vector)
{
    Console.WriteLine(item);
}

// determino si el vector contiene una cantidad par o impar, y de ahi las posicion max del recorrido
int largoMedio;

if(longitud%2 == 0)
{
    largoMedio = longitud/2;
}
else
{
    largoMedio = (longitud-1)/2;
}

for (int i = 0; i < largoMedio; i++)
{
    int num = vector [i];
    vector [i] = vector [longitud-1-i];
    vector [longitud-1-i] = num;
}

Console.WriteLine("El Vector invertido contiene: ");

foreach (var item in vector)
{
    Console.WriteLine(item);
}

    

/*
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)Pedir al usuario la longitud de un vector
2)Crear el vector del tamaño ingresado.
3)Llenar el mismo con datos aleatorios
4)Mostrar el vector por pantalla
5)Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; 
    el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. 
    En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50,
    una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  
    Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. T
    ampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)Mostrar el vector nuevamente.
*/