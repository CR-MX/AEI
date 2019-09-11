using System.Collections.Generic;
namespace ControlBancario.Clases
public string Nombre 
        {
            get{return nombre;}
        }{
    public class Cliente
    {
        private string nombre;

        private List<CuentaBancaria> cuentas;

        public Cliente(string nombre)
        {
        this .nombre=nombre;
        cuentas = new List<CuentaBancaria>();
        }
        

        public List<CuentaBancaria> Cuentas{
            get{return cuentas;}
        }
        
        public void  AgregarCuenta (CuentaBancaria cta)
        {
            cuentas.Add(cta);
        }
        

    }
}