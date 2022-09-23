using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    class CuentaBancaria {
        private int codigo;
        private string nombreCliente;
        private float cantidadPlata;
        private string tipoCuenta;
        private tipoDeExtraccion tipoExtraccion;

        static string[] tipoDeCuenta = { "Caja_ahorro_pesos", "Cuenta_corriente_pesos", "Cuenta_corriente_dolares" };

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public float CantidadPlata { get => cantidadPlata; set => cantidadPlata = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        private tipoDeExtraccion TipoExtraccion { get => tipoExtraccion; set => tipoExtraccion = value; }

        enum tipoDeExtraccion {
            Cajero_Automatico,
            Cajero_Humano
        }

        public CuentaBancaria(int codigo, string nombreCliente, float cantidadPlata, int tipoCuenta) {
            Codigo = codigo;
            NombreCliente = nombreCliente;
            CantidadPlata = cantidadPlata;
            TipoCuenta = tipoDeCuenta[tipoCuenta];
        }


        public void Insercion(float cant) {
            this.CantidadPlata += cant;
        }

        public void Extraccion(float cant, tipoDeExtraccion tipo) {
            switch(tipo) {
                case 0:

                    break;
            }
        }
    }
}
