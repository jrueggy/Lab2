namespace Lab2
{
    public class CuentaYape
    {
        int saldo;
        string userId;

        public CuentaYape(int saldo)
        {
            this.saldo = saldo;
        }

        public int consultaSaldo()
        {
            return saldo;
        }

        public void recargaCuenta(int monto)
        {
            this.saldo += monto;
        }

        public bool pagar(CuentaYape cuentaAbono, int monto)
        {
            if(cuentaAbono == null) {
                return false;
            }

            if(this.consultaSaldo() < monto)
            {
                return false;
            }

            this.saldo -= monto;
            cuentaAbono.recargaCuenta(monto);
            return true;
        }
    }
}
