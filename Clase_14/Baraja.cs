using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Baraja:Carta
    {
        public List<Carta> baraja = new List<Carta>();
        private int sigCarta = 0;

        /*
            Crea una baraja ordenada de 40 cartas españolas
        */
        public List<Carta> crearBaraja()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    // excluye los numeros de carta 8 y 9
                    if(i == 7 || i == 8)
                    {
                        continue;
                    }
                // cada carta es un objeto de tipo Carta (numero y palo)
                Carta carta= new Carta();
                switch (j)
                {
                    case 0:
                        carta.ColorCarta = "espadas";
                        break;
                    case 1:
                        carta.ColorCarta = "bastos";
                        break;
                    case 2:
                        carta.ColorCarta = "oros";
                        break;
                    case 3:
                        carta.ColorCarta = "copas";
                        break;
                    default:
                        break;
                }

                carta.NumeroCarta = i+1;
                baraja.Add(carta);

                }
            }
            return baraja;
        }

        /*
            a partir de la baraja ordenada las mezclo aleatoriamente
        */
        public Carta[] Barajar(List<Carta> barajaOrdenada)
        {
            Random aleatorio = new Random();
            // creo un array de Cartas para guardar la baraja aleatoria
            Carta[] barajaRandom = new Carta[40];
            //deermino 40 posiciones aleatorias en un vector
            int[] posicion = new int[40];
            for (int j = 0; j < posicion.Length; j++)
            {
                int posRandom = aleatorio.Next(40);
                int repetido = 0;
                do
                {
                    repetido = 0;
                    //las posiciones no pueden repetirse, si sale una posicion que ya esta se vuelve a generar
                    for (int k = 0; k < j; k++)
                    {
                        if (posicion[k] == posRandom)
                        {
                            posRandom = aleatorio.Next(40); 
                            repetido = 1;
                        }
                    }
                    
                } while (repetido == 1);
                
                posicion[j] = posRandom;
            }

            for (int i = 0; i < 40; i++)
            {   
                barajaRandom[posicion[i]]= barajaOrdenada[i];          
            }
            
            return barajaRandom;
        }

        /*
            retorna la siguiente carta en la baraja aleatoria, uso la var sigCarta para marcar la posicion
            en la baraja de la ultima carta repartida
        */
        public Carta SiguienteCarta(Carta[] cartas)
        {
            Carta SigCarta = cartas[sigCarta];
            sigCarta++;
            return SigCarta;
        }

        /*
            retorna la cantidad de cartas que no fueron dadas, barajaOrdena solo lo uso
            para determinar el numero total de cartas que es 40
        */
        public int CartasDisponibles(List<Carta> barajaOrdenada)
        {
            int cartasDisp = barajaOrdenada.Count()-sigCarta;
            return cartasDisp;
        }
        /*
            retorna un array con las cartas pedidas eje se puede pedir una cantidad 
            de cartas, ademas aumento el var sigCarta para la posicion final despues
            de dar la cantidad de cartas pedidas
            toma como parametros la cantidad y la baraja aleatoria
        */
        public Carta[] DarCartas(int cantidad, Carta[] cartas)
        {
            Carta[] cartasPedidas = new Carta[cantidad];
            int disponibles = CartasDisponibles(baraja);
            if(cantidad <= disponibles)
            {
                for (int i = 0; i < cartasPedidas.Length; i++)
                {
                    cartasPedidas[i] = SiguienteCarta(cartas);
                }
            }
            return cartasPedidas;
        }

        /*
            retorna un array con todas las cartas que ya se dieron, la var sigCarta marca
            la posicion de la ultima carta dada
        */
        public Carta[] CartasMonton(Carta[] cartas)
        {
            Carta[] cartasDadas = new Carta[sigCarta];
            for (int i = 0; i < cartasDadas.Length; i++)
            {
                cartasDadas[i] = cartas[i];
            }
            return cartasDadas;
        }       

        /*
            retorna un array con las cartas que quedan en la baraja, a partir de la posicion sigCarta
            hasta el final de la baraja
        */
        public Carta[] MostrarBaraja(Carta[] cartas)
        {
            int cartasEnBaraja = cartas.Length - sigCarta;
            Carta[] cartasSinDar = new Carta[cartasEnBaraja];
            for (int i = 0; i < cartasEnBaraja; i++)
            {
                cartasSinDar[i] = cartas[sigCarta+i];
            }
            return cartasSinDar;
        }
        
    }

    
}