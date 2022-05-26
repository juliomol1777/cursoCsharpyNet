// See https://aka.ms/new-console-template for more information
string opcion = "S";

while(opcion == "S"){
    Console.Clear();
    Console.Write("Ingrese su nombre: ");
    string nombre1 = Console.ReadLine();
    Console.WriteLine("Hola " + nombre1);
    Console.Write("Desea continuar? Ingrese S o N : ");
    opcion = Console.ReadLine();
}

if(opcion=="N"){
    Console.WriteLine("Programa finalizado correctamente");
}
else{
    Console.WriteLine("Opcion no valida");
}

/*
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".

*/