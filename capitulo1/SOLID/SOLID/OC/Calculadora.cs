﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OC
{ // Principio 2, tomar y agregar mas funciones en el mismo codigo sin modificar el existente, hacer metodos que sirvan para todas las clases que implementen la interface
  // 
    public interface IArea
    {
        double Area();
    }
    public class Square : IArea
    {
        public double lado { get; set; }

        public double Area()
        {
            return lado * lado;
        }
    }
    public class Triangle: IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return (Base * Height) /2;
        }
    }
    public class Rectangle : IArea
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return (Base * Height);
        }
    }
    public class Calculadora
    {
        public double Area(IArea obj) {
            return obj.Area();
        }

    }
}
