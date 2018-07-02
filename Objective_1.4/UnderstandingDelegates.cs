using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Objective_1._4
{
    public class UnderstandingDelegates
    {

        public UnderstandingDelegates()
        {

        }
        //Usamos a keyword delegate para avisar o compilador que você esta criando um type delegate.
        //Um delegate pode fazer uma chamada de diversos métodos de MESMA assinatura
        
        #region Listing 1-75 Using Delegate

        public delegate int Calculate(int x, int y);

        private int Somar(int x, int y)
        {
            return x + y;
        }
        private int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public void UseDelegate()
        {

            Calculate calc = Somar;
            Console.WriteLine(calc(3, 4));

            calc = Multiplicar;
            Console.WriteLine(calc(2, 4));

        }

        #endregion

        #region Listing 1-76 A Multicast Delegate

        public delegate void Del();

        private void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        private void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public Delegate GetInvocationListPartial(int index)
        {
            Del del = MethodOne;
            del += MethodTwo;
            return del.GetInvocationList()[index];
        }

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();

            //Diplays
            //MethodOne
            //MethodTwo
        }



        #endregion

        #region Listing 1-77 Covariance with delegates

        //Pelo motivo de StreamWriter e StringWriter Herdar de TextWriter,você pode usar o delegate CovarianceDel com
        //ambos os métodos

        public delegate TextWriter CovarianceDel();

        private StreamWriter MethodStream()
        {
            return null;
        }
        private StringWriter MethodString()
        {
            return null;
        }

      public TextWriter tel()
        {
            CovarianceDel del;
            del = MethodStream;
            del += MethodString;
            return del();
        }

        #endregion

        #region Listing 1-78 Contravariance With Delegates

        //Pelo motivo do Método DoSomething poder trabalhar com um TextWriter,ele certeamento pode também
        //trabalhar com um StreamWriter.Porque a Contravariancia,você pode chamar um delegate e passar uma
        //instancia de StreamWriter para o método DoSomething

        private void DoSomething(TextWriter tw)
        {
            //Do Something

        }

        public delegate void ContravarianceDelegate(StreamWriter tw);

        public void UsingContravariance()
        {
            ContravarianceDelegate del;
            del = DoSomething;
        }
       
        #endregion


    }
}
