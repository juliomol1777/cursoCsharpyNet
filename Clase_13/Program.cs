using Ejercicio13;

Billetera billetera1 = new Billetera(2, 2, 2, 2, 2, 2, 2);
Billetera billetera2 = new Billetera(5, 5, 5, 5, 5, 5, 5);
Console.WriteLine(billetera1.Total());
Console.WriteLine(billetera2.Total());
Billetera billetera3 = billetera1.Combinar(billetera2);
Console.WriteLine(billetera3.Total());
Console.WriteLine(billetera1.Total());
Console.WriteLine(billetera2.Total());




/*
 * Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
 */
