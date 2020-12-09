namespace POO_Abstracao.classes
{
    public class Boleto : Pagamentos
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
            set{codigoDeBarras = value;}
        }
        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }

        public override string Desconto(float valor)
        {
            return "";
        }    
    }
}