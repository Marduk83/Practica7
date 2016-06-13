using System;
using System.Collections.Generic;
using System.Text;

namespace Practica7
{
    public class Nomina
    {
        #region Variables
        DateTime fechaNomina;
        Empleado empleadoNomina;
        int numHorasExtras;
        #endregion

        #region Constructores
        public Nomina()
        {            
        }

        public Nomina(DateTime fechaNomina, Empleado empleadoNomina, int numHorasExtras)
        {
            this.fechaNomina = fechaNomina;
            this.empleadoNomina = empleadoNomina;
            this.numHorasExtras = numHorasExtras;
        }
        #endregion

        #region Propiedades
        public DateTime FechaNomina
        {
            get
            {
                return fechaNomina;
            }            
            set
            {
                fechaNomina = value;
            }             
        }

        public Empleado EmpleadoNomina
        {
            get
            {
                return empleadoNomina;
            }
            set
            {
                empleadoNomina = value;
            }
        }

        public int NumHorasExtras
        {
            get
            {
                return numHorasExtras;
            }
            set
            {               
                numHorasExtras = value;
            }
        }
        #endregion

        #region Métodos
        /// ---- Cálculo de Devengos -------------------------------------        
        public double totalDevengado()
        {
            return salarioBase() + importeHorasHextras() + importeAntiguedad();
        }
        
        public double salarioBase()
        {
            if (EmpleadoNomina.Categoria == 1)
                return 2500;
            else if (EmpleadoNomina.Categoria == 2)
                return 2000;
            else
                return 1500;
        }
        
        public double importeHorasHextras()
        {
            return this.salarioBase() * 0.01 * numHorasExtras;
        }        
        
        public double importeAntiguedad()
        {
            return this.salarioBase() * 0.04 * EmpleadoNomina.NumTrienios;
        }

        // ---- Cálculo de Descuentos -------------------------------------      
        public double totalDescuentos()
        {
            return cotizacionSegSoc() + cotizacionSegDes() + retencionIRPF();
        }
        
        public double cotizacionSegSoc()
        {
            return 0.0451 * (devengosPagaExtra() + (devengosPagaExtra() / 6));
        }
        
        public double devengosPagaExtra()
        {
            return salarioBase() + importeAntiguedad();
        }
        
        public double cotizacionSegDes()
        {
            return 0.0197 * devengosPagaExtra();
        }
        
        public double retencionIRPF()
        {
            double porIrpf;
            if (EmpleadoNomina.Categoria == 1)
                porIrpf = 18 - EmpleadoNomina.NumHijos;
            else if (EmpleadoNomina.Categoria == 2)
                porIrpf = 15 - EmpleadoNomina.NumHijos;
            else
                porIrpf = 12 - EmpleadoNomina.NumHijos;

            if (porIrpf < 0)
                porIrpf = 0;

            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
                return (totalDevengado()+ devengosPagaExtra()) * porIrpf / 100;
            else
                return totalDevengado() * porIrpf / 100;
        }

        public void hojaSalarial()
        {
            Console.WriteLine("HOJA SALARIAL\n");
            Console.WriteLine("LIQUIDACIÓN de HABERES AL {0}\n",
                                FechaNomina.ToShortDateString());

            Console.WriteLine("Nombre........: " + EmpleadoNomina.Nombre);
            Console.WriteLine("NIF...........: " + EmpleadoNomina.NIF);
            Console.WriteLine("Categoría.....: " + EmpleadoNomina.Categoria);
            Console.WriteLine("Nº de Trienios: " + EmpleadoNomina.NumTrienios);
            Console.WriteLine("Nº de Hijos...: " + EmpleadoNomina.NumHijos);
            Console.WriteLine();

            Console.WriteLine("{0,-32}{1}", "DEVENGOS", "DESCUENTOS");
            Console.WriteLine("{0,-32}{1}", "--------", "----------");
            Console.WriteLine("{0,-20}{1,9:n2}   {2,-20}{3,9:n2}", "Salario base", salarioBase(),
                                                         "Cotización Seg.Soc.", cotizacionSegSoc());
            Console.WriteLine("{0,-20}{1,9:n2}   {2,-20}{3,9:n2}", "Antigüedad", importeAntiguedad(),
                                                         "Cotización Seg.Des.", cotizacionSegDes());
            Console.WriteLine("{0,-20}{1,9:n2}   {2,-20}{3,9:n2}", "Importe Hor.Ext.", importeHorasHextras(),
                                                         "Retención IRPF", retencionIRPF());

            /// SI HAY PAGA EXTRA, SE ACUMULA DICHO DEVENGO -------------------------------------------------            
            double sumaDevengos;
            if (FechaNomina.Month == 6 || FechaNomina.Month == 12)
            {
                Console.WriteLine("{0,-20}{1,9:n2}", "Paga Extra", devengosPagaExtra());
                sumaDevengos = totalDevengado() + devengosPagaExtra();
            }
            else
                sumaDevengos = totalDevengado();

            /// SE CALCULA Y PRESENTA EL IMPORTE LIQUIDO --------------------------------------------------
            double liquido = sumaDevengos - totalDescuentos();
            Console.WriteLine("\n{0,-20}{1,9:n2}   {2,-20}{3,9:n2}", "Total Devengos", sumaDevengos,
                                                         "Total Descuentos", totalDescuentos());

            Console.WriteLine();
            Console.WriteLine("{0,-30}", "-----------------------------");
            Console.WriteLine("{0,-20}{1,9:n2}", "LÍQUIDO A PERCIBIR ", liquido);
            Console.WriteLine("{0,-30}", "-----------------------------");            
        }
        #endregion
    }
}
