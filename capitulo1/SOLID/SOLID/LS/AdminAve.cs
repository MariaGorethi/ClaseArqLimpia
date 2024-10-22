using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LS
{//Principio 3, Hacer interfaces mas especializadas (Sustitucion Lysco), que no debe cambiar asi se use una referencia hijo o una padre
    public interface IVolar
    {
        void Volar();
    }
    public interface INadar
    {
        void Nadar();
    }
    public interface ICorrer
    {
        void Correr();
    }
    
    public class Pinguino : ICorrer,INadar
    {
        public void Correr()
        {
            Console.WriteLine("Corre Lindo!!!");
        }

        public void Nadar()
        {
            Console.WriteLine("Si nada, Rapidisiimoooo!!!");
        }

    }
    public class Paloma : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Si Vuela!!");
        }
    }

    public class Eagle : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Si Vuela!!");
        }
    }

    public class AdminAve
    {
        private List<IVolar> voladores = new List<IVolar>();
        public bool InsertVolador(IVolar ave) {
            
                ave.Volar();
                voladores.Add(ave);
                return true;
            
        }
    }
}
