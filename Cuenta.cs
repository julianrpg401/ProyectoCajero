using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCajero
{
    public class Cuenta
    {
        private uint id;
        private uint numCuenta;
        private double saldo;
        private List<Movimiento> movimientos;

        public uint Id { get => id; set => id = value; }
        public uint NumCuenta { get => numCuenta; set => numCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public List<Movimiento> Movimientos { get => movimientos; set => movimientos = value; }

        public Cuenta()
        {
            movimientos = new List<Movimiento>();
        }

        public class Movimiento
        {
            public string Concepto { get; set; }
            public double Valor { get; set; }
            public double Saldo { get; set; }

            public Movimiento(string concepto, double valor, double saldo)
            {
                Concepto = concepto;
                Valor = valor;
                Saldo = saldo;
            }
        }

        public void Retirar(double monto)
        {
            Saldo -= monto;
            movimientos.Add(new Movimiento("Retiro", monto, Saldo));
        }

        public void Consignar(double monto)
        {
            Saldo += monto;
            movimientos.Add(new Movimiento("Consignación", monto, Saldo));
        }
    }
}