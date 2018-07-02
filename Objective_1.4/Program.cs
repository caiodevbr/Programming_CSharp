using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1._4
{
    class Program
    {
        //os métodos com static foram declarados para poder ser feitas chamadas entre os mesmos(Protect level)

        static void Main(string[] args)
        {
            UnderstandingDelegates ud = new UnderstandingDelegates();

            //ud.UseDelegate();
            //ud.Multicast

            UsingLambdaExpressions ule = new UsingLambdaExpressions();

            ule.UsingActionDelegate();




        }
    }
}
