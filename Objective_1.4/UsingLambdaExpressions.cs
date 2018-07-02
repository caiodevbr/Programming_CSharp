using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1._4
{
    public class UsingLambdaExpressions
    {
        public UsingLambdaExpressions()
        {

        }
        //As vezes a Assinatura  de um método pode conter mais código do que o corpo do método.
        //Há também situações em que você precisa criar um método inteiro apenas para usá-lo em um
        //delegate.
        public delegate int Calculate(int x, int y);

        #region Listing 1-79 Lambda epression to create a delegate


        public void UsingDelegatesWithLambda(int firstNum,int SecondNum)
        {
            //Ler a sintaxe lambda do seguinte jeito:
            //x e y vai para a soma de x e y
            Calculate calc = (x, y) => x + y;
            Console.WriteLine("Resultado de uma Expressão Lambda de Soma: " + calc(firstNum, SecondNum));


            //Ler a sintaxe lambda do seguinte jeito:
            //x e y vai para o produto de x e y
            calc = (x, y) => x * y;
            Console.WriteLine("Resultado de uma Expressão Lambda de Multiplicação: " + calc(firstNum, SecondNum));
        }

        #endregion

        #region 1-80 Creating a lambda expression with multiple statements
        Calculate calc = (x, y) =>
        {
            Console.WriteLine("Adding numbers");
            return x + y;
        };
        public int ResultOfMultipleStatements()
        {
            return calc(3, 4);
        }


        #endregion

        #region Using The Action Delegate
        //Se voce precisa de um delegate type que não retorna um vaor,você pode usar o System.Action types.Eles podem pegar 
       //de 0 a 16 parametros,mas eles não podem retornar um valor

        Action<int, int> calcAction = (x, y) =>
        {
            Console.WriteLine(x + y);
        };
        public void UsingActionDelegate()
        {
             calcAction(3, 4);
        }

        #endregion

    }
}
