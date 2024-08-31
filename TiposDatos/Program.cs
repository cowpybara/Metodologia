using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto pro1 = new Producto(), pro2 = new Producto();
            pro1.leerProducto();
            /*pro1.setCodigo(100);
            pro1.setPrecio(43);
            pro1.setPeso(12);
            pro1.setDescuento(0.21);
            pro1.setNombre("Yogurt");
            pro1.setDisponible(true);
            pro1.setTipo('C');*/

           

            /*pro2.setCodigo(120);
            pro2.setPrecio(25);
            pro2.setPeso(2);
            pro2.setDescuento(0.10);
            pro2.setNombre("Comida para perro");
            pro2.setDisponible(true);
            pro2.setTipo('S');*/
        }
    }

    class Producto
    {
        int codigo;
        decimal precio;
        float peso;
        double descuento;
        string nombre;
        bool disponible;
        char tipo;

        public void setCodigo(int c) {codigo = c;}
        public void setPrecio(decimal p) { precio = p; }
        public void setPeso(float p) { peso = p; }
        public void setDescuento(double d) { descuento = d; }
        public void setNombre(string n) { nombre = n; }
        public void setDisponible(bool d) { disponible = d; }
        public void setTipo(char t) { tipo = t; }

        public int getCodigo() { return this.codigo; }
        public decimal getPrecio() { return this.precio; }
        public float getPeso() { return this.peso; }
        public string getNombre() { return this.nombre; }
        public bool getDisponible() { return this.disponible; }
        public char getTipo() { return this.tipo; }

        public void leerProducto()
        {
            Console.WriteLine("Nuevo Producto");
            Console.WriteLine("******************");
            Console.WriteLine("Digite el codigo: ");
            this.codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite el Nombre: ");
            this.nombre = Console.ReadLine();

            Console.Write("Digite el Precio: ");
            this.precio = decimal.Parse(Console.ReadLine());

            Console.Write("Digite el Descuento: ");
            this.descuento = double.Parse(Console.ReadLine());

            Console.Write("Digite el Preso: ");
            this.peso = float.Parse(Console.ReadLine());

            Console.Write("Digite si esta disponible: ");
            this.disponible = bool.Parse(Console.ReadLine());

            Console.Write("Digite el tipo: ");
            this.tipo = char.Parse(Console.ReadLine());
        }
    }
}
