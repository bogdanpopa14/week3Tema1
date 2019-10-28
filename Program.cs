using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3h1


{


    class Program
    {


        static void Main(string[] args)
        {
            //SumPare();
            //Pair();
            //Fact();
            //Dupl();
            //FactRec(5);
            //DigitSum();
            //NrMajoritar();
            //SumDigit();
            //Anagram2();
            //FibonacciN();
            //Bit32();
            //NthElem();
            //RemDupl();
            //Armstrong();
            //Prim();
            //PalinNr();
            //Pivot();
            //BubbleSort();
            SelectionSort();
            Console.ReadLine();





        }

        private static void SumPare()
        {
            int i, sum = 0;
            int[] arr = new int[] { 2, 3, 4, 6 };
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }

            }
            Console.WriteLine(sum);

        }


        private static void Pair()
        {
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7 };
            int i, x, j;
            Console.WriteLine("introduceti nr: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    for (j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] + arr[j] == x)
                            Console.WriteLine("avem perechea {0} si {1}", arr[i], arr[j]);

                    }

                }

            }




        }


        private static void Fact()
        {
            int x, i, prod = 1;
            Console.WriteLine("introduceti nr: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= x; i++)
            {
                prod = prod * i;


            }
            Console.WriteLine("Factorial de {0}={1}", x, prod);

        }

        static int FactRec(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * FactRec(x - 1);


        }

        private static void Dupl()
        {
            int x = 0;
            int[] arr = new int[] { 2, 2, 2, 3, 3, 6, 7, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x++;
                    }

                }


            }
            if (x > 0)
            {
                Console.WriteLine("vectorul contine dubluri");
            }
        }

        private static void SumDigit()
        {
            int i, x, n, sum = 0;
            Console.WriteLine("introduceti un nr: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; x > 0; i++)
            {
                n = x % 10;
                sum = sum + n;
                x = x / 10;
            }
            Console.WriteLine("suma este: {0}", sum);
        }

        static int DigitSumRec(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return (n % 10 + DigitSumRec(n / 10));
        }


        private static void DigitSum()
        {
            int x, sum = 0, i, n;
            int[] a = new int[1000];
            Console.WriteLine("introduceti un nr: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 0; x > 0; i++)
            {
                a[i] = x % 2;
                x = x / 2;

            }
            Console.WriteLine("Nr in binar este: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
                sum = sum + a[i];
            }
            Console.WriteLine();
            Console.WriteLine("suma digitilor este:{0} ", sum);
        }


        private static void NrMajoritar()
        {
            int[] arr = new int[] { 0, 2, 2, 2, 2, 3, 4, 5 };
            int i, j, x;
            for (i = 0; i < arr.Length; i++)
            {
                x = 1;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x++;
                    }
                }
                if (x >= arr.Length / 2)
                {
                    Console.WriteLine("Nr apare de mai mult de 50%: {0}", arr[i]);
                }


            }


        }

        private static void Anagram2()
        {
            int x = 0;
            string b = "ddssaasa";
            string a = "aaassddas";
            Dictionary<char, int> dictionar = new Dictionary<char, int>();
            Dictionary<char, int> dictionar2 = new Dictionary<char, int>();

            if (a.Length != b.Length)
            {
                Console.WriteLine("nu sunt anagrame");
            }
            else
            {
                foreach (var num2 in b)
                {
                    if (!dictionar2.ContainsKey(num2))
                    {
                        dictionar2.Add(num2, 0);
                    }
                    dictionar2[num2]++;

                }

                foreach (var num in a)
                {
                    if (!dictionar.ContainsKey(num))
                    {
                        dictionar.Add(num, 0);
                    }
                    dictionar[num]++;
                }

                for (int i = 0; i < dictionar.Count; i++)
                {
                    for (int j = 0; j < dictionar2.Count; j++)
                    {
                        if (dictionar.Keys.ElementAt(i) == dictionar2.Keys.ElementAt(j) && dictionar[dictionar.Keys.ElementAt(i)] == dictionar2[dictionar2.Keys.ElementAt(j)])
                        {
                            x++;
                        }

                    }

                }
            }
            if (x == dictionar.Count)
            {
                Console.WriteLine("Anagrame");
            }
            else
            {
                Console.WriteLine("nu sunt anagrame");
            }

        }



        private static void FibonacciN()
        {
            int a = 0, b = 1;
            int sum;
            int n, x;
            Console.WriteLine("introduceti nr pt care vreti Fibonacci: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti care nr il vreti: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)

            {
                sum = a + b;
                if (x == i)
                {
                    Console.WriteLine(sum);
                }
                a = b;
                b = sum;
            }
        }


        private static void Bit32()
        {
            int x, sum = 0, i, n;
            int[] a = new int[1000];
            Console.WriteLine("introduceti un nr: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 0; x > 0; i++)
            {
                a[i] = x % 2;
                x = x / 2;

            }
            Console.WriteLine("Nr in binar este: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
                if (a[i] == 1)
                {
                    sum++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("nr de biti 1 este: {0}", sum);
        }

        private static void RemDupl()
        {
            int i, j, n, z = 0, x = 0;
            string a = "Hello";
            var c = a.ToCharArray();

            int[] b = new int[a.Length];

            for (i = 0; i < a.Length; i++)
            {

                b[i] = -1;
            }

            for (i = 0; i < a.Length; i++)
            {
                z = 1;
                for (j = i + 1; j < a.Length; j++)
                {

                    if (a[i] == a[j])
                    {
                        b[j] = 0;
                        z++;
                    }

                }
                if (b[i] != 0)
                {
                    b[i] = z;
                }


            }


            for (i = 0; i < a.Length; i++)
            {
                if (b[i] != 0)
                {
                    c[x] = a[i];
                    x++;
                }
            }
            for (i = 0; i < x; i++)
            {
                Console.Write(c[i]);

            }


        }

        private static void NthElem()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            int[] a = new int[list.Count];
            int i = 0;
            foreach (var num in list)
            {
                a[i] = num;
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                if (j == i - 4)
                {
                    Console.WriteLine(a[j]);
                }


            }


        }

        private static void Armstrong()
        {
            int nr, nr2;
            double  sum = 0, aux;
            Console.WriteLine("introduceti un nr: ");
            nr = Convert.ToInt32(Console.ReadLine());
            nr2 = nr;
            while(nr>0)
            {
                aux = nr % 10;
                sum = sum + Math.Pow(aux,3);
                nr = nr / 10;
            }

            if(nr2==sum)
            {
                Console.WriteLine("nr este armstrong");
            }
            else
            {
                Console.WriteLine("nr nu este armstrong");
            }
        }

        private static void Prim()
        {
            int nr,x = 0;
            Console.WriteLine("introduceti un nr: ");
            nr = Convert.ToInt32(Console.ReadLine());
            if(nr==2)
            {
                Console.WriteLine("nr este prim");
            }
            for (int i = 2; i < nr; i++)
            {
                if(nr%i==0)
                {
                    x++;
                }

            }
            if(x==0)
            {
                Console.WriteLine("nr este prim");
            }
            else
            {
                Console.WriteLine("nr nu este prim");
            }
        }

        private static void PalinNr()
        {
            int nr, j = 0, z = 0;
            Console.WriteLine("introduceti un nr: ");
            nr = Convert.ToInt32(Console.ReadLine());
            var a = nr.ToString();
            char[] b = new char[a.Length];

            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[j] = a[i];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(b[i]==a[i])
                {
                    z++;
                }
            }
            if(z==a.Length)
            {
                Console.WriteLine("nr este palindrom");
            }
            else
            {
                Console.WriteLine("nr nu este palindrom");
            }
        }

        private static void Pivot()
        {
            int n, pivot, j = 0;
            Console.WriteLine("introduceti marimea vect: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("introduceti pozitia unde vreti sa rotiti: ");
            pivot = Convert.ToInt32(Console.ReadLine());

            for (int i = a.Length - 1; i >= pivot; i--)
            {
                b[j] = a[i];
                j++;
            }
            for (int i = pivot-1; i >= 0; i--)
            {
                b[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, b[i]);
            }

        }

        private static void BubbleSort()
        {
            int aux, n;
            Console.WriteLine("introduceti marimea vect: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if(a[j]>a[j+1])
                    {
                        aux = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = aux;
                    }
                }

            }
            Console.WriteLine("vectorul sortat este: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
        }

        private static void SelectionSort()
        {
            int aux, n, min, x=0;
            Console.WriteLine("introduceti marimea vect: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < a.Length-1; i++)
            {
                bool exista = false;
                min = a[i];
                for (int j = i+1; j < a.Length; j++)
                {
                    if(min>a[j])
                    {
                        min = a[j];
                        x = j;
                        exista = true;
                    }
                }
                if (exista)
                {
                    a[x] = a[i];
                    a[i] = min;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
        }




        

    }

    
        
        
}
