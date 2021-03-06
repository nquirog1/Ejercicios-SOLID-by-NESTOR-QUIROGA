using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Open/closed principle
public static void main(string[] args)
{
Coche[] arrayCoches = {
        new Coche (Renault)
        new Coche (Audi)
        new Coche (Mercedes)
    };
imprimirPrecioMedioCoche(arrayCoches);
}
public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
{
for (Coche coche:arrayCoches) {
if (coche.marca.equals(Renault)) System.out.println(18000);
if (coche.marca.equals(Audi)) System.out.println(25000);
if (coche.marca.equals(Mercedes)) System.out.println(27000);
}
}
abstract class Coche
{
    abstract int precioMedioCoche();
}
class Renault extends Coche
{
    internal precioMedioCoche() { return 18000; }
}
abstract class Coche
{
    abstract int precioMedioCoche();
}
class Audi extends Coche
{
    internal precioMedioCoche() { return 25000; }
}
abstract class Coche
{
    abstract int precioMedioCoche();
}
class Mercedes extends Coche
{
    internal precioMedioCoche() { return 27000; }
}
public static void main(string[] args)
{
    Coche[] arrayCoches = {
        new Renault(),
        new Audi(),
        new Mercedes(),
    };
    imprimirPrecioMedioCoche(arrayCoches);
}
public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
{
    for (Coche coche:arrayCoches) {
    System.out.println(Coche.precioMedioCoche());
}
}
