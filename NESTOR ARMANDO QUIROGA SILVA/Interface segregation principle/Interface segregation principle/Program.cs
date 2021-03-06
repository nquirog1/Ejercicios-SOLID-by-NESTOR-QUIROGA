using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface segregation principle
interface IAve
{
    void volar();
    void comer();
    void nadar();
}
class Loro implements IAve
{
    public void volar()
{
}
public void comer()
{
}
public void nadar()
{
}
}
class Tucán implements IAve
{
    public void volar()
{
}
public void comer()
{
}
public void nadar()
{
}
}
class Pinguino implements IAve
{
    public void volar()
{
}
public void comer()
{
}
public void nadar()
{
}
}
interface IAve
{
    void comer();
}
interface IAveVoladora
{
    void volar();
}
interface IAveNadadora
{
    void nadar();
}
class Loro implements IAve, IAveVoladora {
    public void volar()
{

}
public void comer()
{

}
}
class Pinguino implements IAve, IAveNadadora {
    public void nadar()
{
}
public void comer()
{
}
}