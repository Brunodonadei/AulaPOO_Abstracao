namespace POO_Abstracao.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public float Saldo{
            get{return saldo;}
            set{saldo = value;}
        }

        public void Pagar(float valor){
            
        }
    }
}