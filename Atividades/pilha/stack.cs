using System;

namespace StackClass
{
    public class Stack 
    {
        static readonly int MAX = 1000;
        int top = -1;
        int [] stack = new int [MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(int data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            //top = top + 1
            //top++;
            //++top;
            stack[top] = data;
            return true;

        }

        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            int valor = stack[top];
            top -= 1;
            return valor;
        }

        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é : {stack[top]}");
        }

        public void PrintStack()
        {
            if(top > 0 )
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da PIlha");
            
            for(int i = top; 1 > -1; )
            {
                string texto = $"Stack [{stack[i]}]";
                Console.WriteLine(texto);

            }
        }
    }
}