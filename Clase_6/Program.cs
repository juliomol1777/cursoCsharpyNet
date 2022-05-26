int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

int contador = 0;
int numero;
do
{
    Console.Write("\n");
    Console.Write("Ingrese un numero entre 1 y 20: ");
    numero = int.Parse(Console.ReadLine());
    if (numero == numeroSecreto)
    {
        Console.Write("Felicitaciones, has adivinado el número secreto que era: " + numeroSecreto);
        contador+=1;
        Console.Write("\n");
        Console.Write("Lo has logrado en: " + contador + " intentos!!");
        Console.Write("\n");
    }
    else if (numero>numeroSecreto)
    {
        Console.Write("Numero muy grande, intente de nuevo");
        contador+=1;
    }
    else if (numero<numeroSecreto)
    {
        Console.Write("Numero muy chico, intente de nuevo");
        contador+=1;
    }

} while (numeroSecreto != numero);

/*
1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.
*/
