using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    public class ArrayAB
    {
        public int[] a;
        public int[] b;
        int length = 0;

        
        public int Length { get { return length; }  set { length = value;  } }

        public ArrayAB(int n)
        {
            a = new int[n];
        }

        public void Calc()
        {
            Array.Resize(ref a, length);
            int j = 0;
            int[] b1 = new int[length - 1];

            if (length == 0)
            {
                throw new InvalidOperationException("Масив пустий.");
            }

            int maxIndex = 0;
            int maxElement = a[0];

            // Знаходимо індекс та значення максимального елемента
            for (int i = 0; i < length; i++)
            {
                if (a[i] > maxElement)
                {
                    maxElement = a[i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (a[i] == maxElement) 
                {
                    b1[j] = a[i + 1];
                    j++;
                    i++;
                }
                else
                {
                    b1[j] = a[i];
                    j++;
                }
            }

           // Змінюємо розмір b1 та b2 правильно
     Array.Resize(ref b1, j);

     // Отримуємо результуючий масив b шляхом об'єднання b1 і b2
     b = new int[length - 1];
     for (int i = 0; i < b1.Length; i++)
     {
         b[i] = b1[i];
     }
 }
        }
    }

