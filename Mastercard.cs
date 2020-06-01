namespace EncapsulamentoPOO
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }        
            
        public void ComprarComDescontoMastercard(float desconto){

            // Protected
            cvc = 5629382;

            System.Console.WriteLine($"Aplicado desconto de {desconto}, no total de {parcelas} parcelas");
        }
    }
}