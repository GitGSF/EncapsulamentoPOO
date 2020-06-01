using System ;
using System.Diagnostics;

namespace EncapsulamentoPOO
{
    class Program
    {
         Cartao Visa = new Cartao();
            Visa master = new Visa();
            master.parcelas = 6;
            master.titular = "teste";
            master.ComprarComDescontoMastercard(45f);

           Console.WriteLine(master.parcelas);
        }
    }
}    
    