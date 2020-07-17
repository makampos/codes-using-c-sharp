using System.Globalization;
namespace ContaBancaria
{
    public class Conta
    {
        private int _numeroConta { get; set; }
        private double _saldo { get; set; }
        private double _valor { get; set; }       
        public string Titular { get; set; }   

        static double taxa = 5.00;    
        

        public Conta(){            
        }

        public Conta(int numeroConta, string titular) {
            this._numeroConta = numeroConta;
            this.Titular = titular;
        }

        public Conta(int numeroConta, string titular, double valor){
            this._numeroConta = numeroConta;
            this.Titular = titular;
             setDepositar(_valor);           
        }


        public int getNumeroConta(){
            return _numeroConta;
        }

        public double getSaldo(){
            return _saldo;
        }

        public string getTitular(){
            return Titular;
        }

        public double getDeposito(){
            return _valor;
        }

        public void setNumeroConta(int numeroConta ) {
            _numeroConta = numeroConta;
        }

        public void SetTitular(string titular) {
            Titular = titular;
        }

        public void  setDepositar( double valor){
            _valor = valor;
            _saldo += _valor;
        }       
               
        public void setEfetuarSaque(double valor){
             _valor = valor;
             _saldo -= _valor;
             _saldo -=taxa ;
        }
       
       
       public override string ToString(){
           return "Dados da conta: "+ "\n"
           + "Conta:  " + getNumeroConta().ToString() + "\n"
           + "Títular: " + getTitular().ToString() + "\n"
           + "Saldo: $ " + getSaldo().ToString("F2",CultureInfo.InvariantCulture);
       }


    }
}