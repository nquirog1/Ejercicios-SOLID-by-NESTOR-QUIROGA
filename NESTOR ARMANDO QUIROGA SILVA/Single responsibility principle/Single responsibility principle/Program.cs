using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Single responsibility principle
class Coche
{
    string marca;
    Coche(string marca) { this.marca = marca; }
    string getMarcaCoche() { return marca; }
}
class CoheDB
{
    void guardarCoheDB(Coche coche) { }
    void eliminarCoheDB(Coche coche) { }
}