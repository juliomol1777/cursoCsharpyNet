using Ejercicio14;

Baraja baraja = new Baraja();
var barajaOrdenada = baraja.crearBaraja();
Carta[] barajada = new Carta[40];

var maxCartas = 0;
var salir = true;

while (salir)
{
    Console.WriteLine(" ");
    Console.WriteLine("Elija la opcion que desea \n 1 - Barajar \n 2 - Mostrar siguiente carta \n 3 - Mostrar cartas disponibles \n 4 - Dar cartas \n 5 - Mostrar cartas del monton \n 6 - Mostrar baraja \n 7 - Salir");
    int opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            barajada = baraja.Barajar(barajaOrdenada);
            foreach (var item in barajada)
            {
                Console.Write(" ");
                Console.Write(item.NumeroCarta + " " + item.ColorCarta);
            }
            break;
        case 2:
            if(maxCartas < 40)
            {
                var sigCarta = baraja.SiguienteCarta(barajada);
                Console.WriteLine("");
                Console.WriteLine("Ha salido un: " + sigCarta.NumeroCarta + " de " + sigCarta.ColorCarta);
                maxCartas++;
            }
            else
            {
                Console.WriteLine("No hay mas Cartas ");
            }
            break;
        case 3:
            int disponibles = baraja.CartasDisponibles(barajaOrdenada);
            Console.WriteLine("");
            Console.WriteLine("Quedan en la baraja: " + disponibles + " cartas disponibles");
            break;
        case 4:
            Console.WriteLine("Indique el numero de cartas que quiere ");
            int cantidad = int.Parse(Console.ReadLine());
            int disponi = baraja.CartasDisponibles(barajaOrdenada);
            if(cantidad <= disponi)
            {
                var cartasPedidas = baraja.DarCartas(cantidad, barajada);
                foreach (var item in cartasPedidas)
                {
                    Console.Write(" ");
                    Console.Write(item.NumeroCarta + " " + item.ColorCarta);
                }
            }
            else
            {
                Console.WriteLine("No hay tantas cartas en la baraja ");
            }
            break;
        case 5:
            var cartasDadas = baraja.CartasMonton(barajada);
            foreach (var item in cartasDadas)
            {
                Console.Write(" ");
                Console.Write(item.NumeroCarta + " " + item.ColorCarta);
            }
            break;
        case 6:
            var cartasNoDadas = baraja.MostrarBaraja(barajada);
            foreach (var item in cartasNoDadas)
            {
                Console.Write(" ");
                Console.Write(item.NumeroCarta + " " + item.ColorCarta);
            }
            break;
        case 7:
            salir = false;
            break;
        default:
            break;
    }

}
