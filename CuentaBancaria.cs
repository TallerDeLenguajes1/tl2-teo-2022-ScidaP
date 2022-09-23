using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    enum tipoDeExtraccion {
        Cajero_Automatico,
        Cajero_Humano
    }
    class CuentaBancaria {
        private int codigo;
        private string nombreCliente;
        private float cantidadPlata;
        private tipoDeExtraccion tipoExtraccion;

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public float CantidadPlata { get => cantidadPlata; set => cantidadPlata = value; }
        private tipoDeExtraccion TipoExtraccion { get => tipoExtraccion; set => tipoExtraccion = value; }

        public CuentaBancaria() {

        }

        public CuentaBancaria(int codigo, string nombreCliente, float cantidadPlata) {
            Codigo = codigo;
            NombreCliente = nombreCliente;
            CantidadPlata = cantidadPlata;
        }


        public void Insercion(float cant) {
            this.CantidadPlata += cant;
        }

        public virtual float Extraccion(float cant, tipoDeExtraccion tipo);
    }

    internal class AhorroEnPesos : CuentaBancaria {
        public override float Extraccion(float cant, tipoDeExtraccion tipo) {
            if (this.CantidadPlata == 0) {
                return 0;
            } else {
                if (tipo == tipoDeExtraccion.Cajero_Automatico) {
                    if (cant <= 1000) {
                        this.CantidadPlata -= cant;
                        return cant;
                    } else {
                        Console.WriteLine("Error al extraer de cuenta ahorro en pesos: Máximo $10.000.");
                        return 0;
                    }
                } else {
                    this.CantidadPlata -= cant;
                    return cant;
                }
            }
        }
    }

    class CorrienteDolares: CuentaBancaria {
        public override float Extraccion(float cant, tipoDeExtraccion tipo) {
            if (tipo == tipoDeExtraccion.Cajero_Automatico) {
                if (cant <= 200) {
                    this.CantidadPlata -= cant;
                    return cant;
                } else {
                    Console.WriteLine("Error al extrar dolares por cajero automatico: max 200");
                    return 0;
                }
            } else {
                this.CantidadPlata -= cant;
                return cant;
            }
        }
    }

    class CorrientePesos: CuentaBancaria {
        public override float Extraccion(float cant, tipoDeExtraccion tipo) {
            //Chequeo que no se exceda la deuda de 5000
            if (this.CantidadPlata - cant <= -5000) {
                Console.WriteLine("Error: se excede el limite de $5000 en deuda.");
                return 0;
            } else {
                if (tipo == tipoDeExtraccion.Cajero_Automatico) {
                    if (cant > 20000) {
                        Console.WriteLine("Error: No se puede extraer más de 20000 por cajero automatico en cta cte pesos");
                        return 0;
                    } else {
                        this.CantidadPlata -= cant;
                        return cant;
                    }
                } else {
                    this.CantidadPlata -= cant;
                    return cant;
                }
            }
        }
    }

}
