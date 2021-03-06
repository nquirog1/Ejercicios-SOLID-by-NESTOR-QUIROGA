using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Liskov substitution principle
public static void imprimirNumAsientos(Coche[] arrayCoches)
{
for (Coche coche:arrayCoches){
if (Coche instanceof Renault)
            System.out.println(numAsientosRenault(coche));
if (Coche instanceof Renault)
            System.out.println(numAsientosAudi(coche));
if (Coche instanceof Renault)
            System.out.println(numAsientosMercedes(coche));
}
}
imprimirNumAsientos(arrayCoches);
public static void imprimirNumAsientos(Coche[] arrayCoches)
{
for (Coche cohe:arrayCoches){
System.out.println(coche.numAsientos());
}
}
abstract class Coche
{
    abstract int numAsientos();
}
class Renault extends Coche
{
    internal numAsientos()
{
    int numAsientos()
    {
        return 5;
    }
}
class Audi extends Coche
{
    internal numAsientos()
{
    int numAsientos()
    {
        return 5;
    }
}
class Mercedes extends Coche
{
    internal numAsientos()
{
    int numAsientos()
    {
        return 5;
    }
}