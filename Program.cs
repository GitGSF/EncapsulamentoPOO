using System;

namespace EncapsulamentoPOO
{
    class Program
    {
        static void Main(string[] args)
        {   Cartao card = new Cartao();

            Mastercard master = new Mastercard();
            master.titular = "Gabriel";
            master.parcelas = 15;
            master.ComprarComDescontoMastercard(150f);}
        }
}

