using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dependency inversion principle
class DatabaseService
{
    void getDatos()
    { //...}
    }
    class AccesoADatos
    {
        private DatabaseService databaseService;
        public AccesoADatos(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        Dato getDatos()
        {
            databaseService.getDatos();
        }
    }
    interface Conexion
    {
        Dato GetDatos();
        void setDatos();
    }
    class AccesoADatos
    {
        private Conexion conexion;
        public AccesoADatos(Conexion conexion)
        {
            this.conexion = conexion;
        }
        Dato GetDatos()
        {
            conexion.GetDatos();
        }
    }
    class DatabaseService  implements Conexion
    {
        public Dato getDatos() { }
    public void setDatos() { }
}
class APIService  implements  Conexion
{
    public Dato getDatos() { }
public void setDatos() { }
}