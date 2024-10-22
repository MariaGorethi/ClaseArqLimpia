using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    public interface IFuncion
    {//comportamiento de los metodos que llegan a una misma funcion pero de diferentes formas
        //en interfaces solo se declaran metodos polimorficos
        void Insertar();
        void Saludar(string mensaje);
    }

    public class Impl1 : IFuncion
    {
        public void Insertar()
        {
            Console.WriteLine("Implementación 1");
        }

        public void Saludar(string mensaje)
        {
            Console.WriteLine("Implementación 2");
        }
    }
}
