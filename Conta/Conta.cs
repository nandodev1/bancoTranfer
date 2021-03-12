using System;

namespace DIO.Bank
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        private TipoConta TipoConta {get; set;}
        private double Saldo { get; set; }
        private double Credito {get; set;}
        public string Nome { get ; set;}
        public bool Sacar(double valorSaque)
        
        {
            if(this.Saldo - valorSaque < (this.Credito * -1))
            {
                this.Saldo -= valorSaque;
                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);   
            }
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDetino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDetino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "|";
            retorno += " TipoConta " + this.TipoConta;
            retorno += " | Saldo " + this.Saldo;
            retorno += " | Credito " + this.Credito;
            retorno += " | Nome " + this.Nome;            
            return retorno;
        }
    }

}