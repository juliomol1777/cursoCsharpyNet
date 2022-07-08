using Ejercicio16;


double[] CoordenadaX = new double[4];
double[] CoordenadaY = new double[4];

for (int i = 0; i < CoordenadaX.Length; i++)
{
    Console.WriteLine("Ingrese el valor de la coordenada x del punto N° " + (i+1) );
    int valorX = int.Parse(Console.ReadLine());
    CoordenadaX[i] = valorX;
    Console.WriteLine();
    Console.WriteLine("Ingrese el valor de la coordenada y del punto N° " + (i+1) );
    int valorY = int.Parse(Console.ReadLine());
    CoordenadaY[i] = valorY;
    Console.WriteLine();             
}

for (int j = 0; j < CoordenadaX.Length-1; j++)
{
    var aux = CoordenadaX[0];
    var auxy = CoordenadaY[0];
    //oredena de menor a mayor el array x, cambiando de posicion tambien el el array y el punto del par
    for (int i = 0; i < CoordenadaX.Length-1-j; i++)
    {   
        if (aux > CoordenadaX[i+1])
        {
            CoordenadaX[i] = CoordenadaX[i+1];
            CoordenadaY[i] = CoordenadaY[i+1];
            CoordenadaX[i+1] = aux;
            CoordenadaY[i+1] = auxy;
        }
        else
        {
            CoordenadaX[i] = aux;
            CoordenadaY[i] = auxy;
            aux = CoordenadaX[i+1];
            auxy = CoordenadaY[i+1];
        }
    }
}

double[] lado = new double[4];
double[] pendiente = new double[4];
double[] catetoX = new double[4];
double[] catetoY = new double[4];

for (int i = 0; i < lado.Length; i++)
{
    // determino la longitud de cada lado
    if(i < lado.Length-1)
    {
        catetoX[i] = Math.Abs(CoordenadaX[i+1]- CoordenadaX[i]);
        catetoY[i] = Math.Abs(CoordenadaY[i+1]- CoordenadaY[i]);
        if(catetoX[i] != 0)
        {
            pendiente[i] = catetoY[i]/ catetoX[i];
        }
        else
        {
            pendiente[i] = 0;
        }
        
    }
    else
    {
        catetoX[i] = Math.Abs(CoordenadaX[0]- CoordenadaX[i]);
        catetoY[i] = Math.Abs(CoordenadaY[0]- CoordenadaY[i]);
        if(catetoX[i] != 0)
        {
            pendiente[i] = catetoY[i]/ catetoX[i];
        }
        else
        {
            pendiente[i] = 0;
        }
    }
    //determino el lado considerando que puede tener un angulo repecto a los ejes
    lado[i] = Math.Sqrt(Math.Pow(catetoX[i],2)+Math.Pow(catetoY[i],2));
}


int opcion;
if(lado[0] == lado[1])
{
    opcion= 0;
}
else if (lado[0] != lado[1] && lado[3] == lado[1])
{
    opcion=1;
}
else
{
    opcion=2;
    //uso la posicion 2 del array lado para guardar la altura del trapecio
    if(pendiente[0] == pendiente[2])
    {
        lado[2] = catetoX[3];
    }
    else
    {
        lado [2] = catetoY[0];
    }

}

Console.WriteLine(" El area del Cuadrilatero es: ");
switch (opcion)
{
    case 0:
        Cuadrado cuadrado = new Cuadrado(lado);
        Console.WriteLine(cuadrado.Area(lado));
        break;
    case 1:
        Rectangulo rectangulo = new Rectangulo(lado);
        Console.WriteLine(rectangulo.Area(lado));
        break;
    case 2:
        Trapecio trapecio = new Trapecio(lado);
        Console.WriteLine(trapecio.Area(lado));
        break;
    default:
    break;
}

/*


foreach (var item in CoordenadaX)
{
    Console.WriteLine(item);
}
foreach (var item in CoordenadaY)
{
    Console.WriteLine(item);
}

*/
