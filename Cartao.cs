namespace EncapsulamentoPOO
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        private string token = "jafkahvfbkeanlfjnarklejmç34w84jr9r43i038g2h9u58l24";
        protected int cvc { get; set; }

        public string AprovarCompra(){
            return "Compra Aprovada";
        }
        public string CompraRealizadaComDesconto(){
            return "Compra Realizada Com Desconto ";
        }

        private bool ValidarToken(){
             if(token != null & token != ""){
                return true;}

            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}