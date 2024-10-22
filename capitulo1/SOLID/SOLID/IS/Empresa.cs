using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IS
{//Hacer interfaces mas explicitas y que una clase no implemente forsozamente toda la interfaz ,(SEgregacion de Interfaces) Usar el Divide y Venceras
    public interface ICommons
    {
        void EntrarAReuniones();
        void Registro();
    }

    public interface IDevelop
    {
        void Desarrolla();
        void EjecutaTest();
    }

    public interface IGerente
    {
        void Gerenciar();
    }
    public interface IFinanza 
    {
        void AdministrarFacturas();
    }
    public class Venta : ICommons
    {
        public void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }

    
    public class Developer : ICommons, IDevelop
    {
        public void Desarrolla()
        {
            throw new NotImplementedException();
        }

        public void EjecutaTest()
        {
            throw new NotImplementedException();
        }

        public void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }
    public class Empresa
    {
    }
}
