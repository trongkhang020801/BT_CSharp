using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int bt, n;
            do
            {
                Console.WriteLine("=====Menu=====");
                Console.WriteLine("1. Bai 59");
                Console.WriteLine("2. Bai 60");
                Console.WriteLine("3. Bai 61");
                Console.WriteLine("4. Bai 62");
                Console.WriteLine("5. Bai 63");
                Console.WriteLine("6. Thoat");
                Console.WriteLine("==============");
                Console.Write("Nhap bai tap: ");
                bt = int.Parse(Console.ReadLine());
                switch (bt)
                {
                    case 1:
                        Console.Write("Nhap Nam: ");
                        n = int.Parse(Console.ReadLine());
                        Bai59(n);
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Nhap n: ");
                            n = int.Parse(Console.ReadLine());
                        } while (n < 2 || n % 2 != 0);
                        Bai60(n);
                        break;
                    case 3:
                        do
                        {
                            Console.Write("Nhap n: ");
                            n = int.Parse(Console.ReadLine());
                        } while (n < 1 || n > 99);
                        Bai61(n);
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Nhap n: ");
                            n = int.Parse(Console.ReadLine());
                        } while (n < 1 || n > 99);
                        Bai62(n);
                        break;
                    case 5: 
                       do
                        {
                            Console.Write("Nhap n: ");
                            n = int.Parse(Console.ReadLine());
                        } while (n < 1 || n > 99);
                        Bai63(n);
                        break;
                    default:
                        Console.WriteLine("Thoat");
                        break;
                }
            } while (bt < 6);
            Console.ReadLine();
        }
        static void Bai59(int n) {
            string[] can = {"Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ki"};
            string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

            Console.WriteLine("{0}: {1} {2}", n, can[n % 10], chi[n % 12]);
            Console.WriteLine("{0}: {1} {2}", n+60, can[n % 10], chi[n % 12]);
        }
        static void Bai60(int n) {
            int[] a = new int[100];
            int[] b = new int[100];
            int i, count;
            Random r = new Random();
            for(i = 0;i<n;i++){
                a[i] = b[i] = r.Next(-100,100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            shupffle(ref a, ref n);
            for(i = 0;i<n;i++)
                Console.Write("{0} ",a[i]);
            shupffle(ref b, ref n);
            count = 0;
            do{
                shupffle(ref b, ref n);
                count++;
            }while(isEqual(a,b,n) != 1);
            Console.WriteLine();
            Console.WriteLine("Can {0} lan de shuffle de mang tro ve ban dau", count);

        }
        static void shupffle(ref int []a, ref int n){
            int[] t = new int[100];
            int i;
            for (i = 0; i < n; i++) {
                t[2 * i] = a[i];
                t[2 * i + 1] = a[n / 2 + i];
            }
            for (i = 0; i < n; i++)
                a[i] = t[i];
        }
       static int isEqual(int[] a, int []b, int n) {
            int i;
            for(i=0;i<n;i++)
                if(a[i]!=b[i]) return 0;
            return 1;
        }
       
       static int USCLN(int a, int b) {
           int i, uc=0;
          int j = (a < b) ? a : b;
           for (i = 1; i <= j; i++)
           {
               if (a % i == 0 && b % i == 0)
               {
                   uc = i;
               }
           }
           if (uc == 1)
               return 1;
           else return 0;
       }
       static void Bai61(int n) {
           int[] a = new int[100];
           int i,p, s = 0;
           Random r = new Random();
           for (i = 0; i < n; i++)
           {
               a[i]= r.Next(-100, 100);
               Console.Write("{0} ", a[i]);
           }
           Console.WriteLine();
           for (i = 0; i < n; ++i )
                if ( a[i] > 0 ) s += a[i];
           Console.WriteLine("Tong so duong: {0}", s);
           do
           {
               Console.Write("Nhap p [0 , {0}] = ", n);
               p = int.Parse(Console.ReadLine());

           } while (p < 0 || p > n);
           for (i = p + 1; i < n; ++i)
               a[i - 1] = a[i];
           n--;
           for (i = 0; i < n; ++i)
               Console.Write("{0} ", a[i]);
           Console.WriteLine();

       }
       static void Bai62(int n) {
           int[] a = new int[100];
           int i,j, s1, s2;
           s1 = s2 = 0;
           Random r = new Random();
           for (i = 0; i < n; i++)
           {
               a[i] = r.Next(10, 20);
               Console.Write("{0} ", a[i]);
           }
           Console.WriteLine();
           for (i = 0; i < n; i++) {
               if (i % 2 != 0 && a[i] % 2 == 0) s1 += a[i];
               if (i % 2 == 0 && a[i] % 2 != 0) s2 += a[i];
           }
           Console.WriteLine("Tong le vi tri chan: {0} ", s2);
           Console.WriteLine("Tong chan vi tri le: {0} ", s1);
           if (s1 == s2)
               Console.WriteLine("s1 giong s2");
           else
               Console.WriteLine("s1 khac s2");
           Console.WriteLine("Cac cap so nguyen to trung nhau");
           for (i = 0; i < n; ++i)
               for (j = i + 1; j < n; ++j)
                   if(USCLN(a[i],a[j]) == 1)
                    Console.WriteLine("({0},{1})", a[i], a[j]);

       }
    static  void Bai63(int n)
    {
        int[] a = new int[100];
            int i,j,count=0;
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        for ( i=0;i<n;i++)
            if (a[i]%4 ==0 && Math.Abs(a[i])%10==6) count++;
        Console.WriteLine("\nCo "+count+" phan tu chia het cho 4, tan cung 6\n");

        Console.WriteLine("\nNhan doi phan tu le: \n");
        for (i=0 ; i<n;i++)
            if(a[i]%2!=0)a[i]*=2;

        for (i=0;i<n;i++)
            Console.Write("{0} ",a[i]);
        Console.WriteLine();
    }
    }
}
