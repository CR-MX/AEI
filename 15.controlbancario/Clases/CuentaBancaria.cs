namespace ControlBancario.Clases
{
    public class CuentaBancaria
    {
        protected double saldo;// permite al acceso alas clases heredadas 
        public CuentaBancaria(){}
        public CuentaBancaria(double saldo){this.saldo=saldo;}
        public double Saldo
        {
            get { return saldo; }
        }
        public void Deposita(double cantidad){
            if(cantidad>0){saldo+=cantidad;}
        }
        public virtual bool Retira(double cantidad){
            if(saldo>=cantidad){saldo-=cantidad; return true;}
            else return false;
        }
        
    }
}