using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            CuentaBancaria nuevaCuenta = new(123, "Patricio", 3200);
            nuevaCuenta.Insercion(400);
            nuevaCuenta.Extraccion(3500, 0);
        }
    }
}
