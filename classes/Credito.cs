namespace POO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        public void Pagar(float valor){

        }
    }
}