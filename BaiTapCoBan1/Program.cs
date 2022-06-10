// See https://aka.ms/new-console-template for more information

// Bài tập 1
Console.WriteLine("Bài tập số 1 \n");
Console.WriteLine("Nhập vào 1 số nguyên: ");
int number1_131 = Convert.ToInt32(Console.ReadLine());
if(number1_131 >=0 ) 
    Console.WriteLine("Đây là một số nguyên dương.");
else   
        Console.WriteLine("Đây là một số nguyên âm.");

// bài tập 2

Console.WriteLine("\nBài tập số 2 \n");

Console.WriteLine("Nhập vào 1 số nguyên: ");
int number2_131 = Convert.ToInt32(Console.ReadLine());
switch(number2_131)
{
    case 0: Console.WriteLine("Không");break;
    case 1: Console.WriteLine("Một");break;
    case 2: Console.WriteLine("Hai");break;
    case 3: Console.WriteLine("Ba");break;
    case 4: Console.WriteLine("Bốn");break;
    case 5: Console.WriteLine("Năm");break;
    case 6: Console.WriteLine("Sáu");break;
    case 7: Console.WriteLine("Bảy");break;
    case 8: Console.WriteLine("Tám");break;
    case 9: Console.WriteLine("Chín");break;
}

// Bài tập 3
Console.WriteLine("\nBài tập số 3 \n");

Console.WriteLine("Nhập vào 3 số thực: ");
float a1_131,b1_131,c1_131;
a1_131 = float.Parse(Console.ReadLine());
b1_131 = float.Parse(Console.ReadLine());
c1_131 = float.Parse(Console.ReadLine());
if(a1_131+b1_131 >c1_131 && b1_131+c1_131>a1_131 && a1_131+c1_131 >b1_131)
    Console.WriteLine("Ba số trên đúng là ba cạnh của một tam giác.");
else
    Console.WriteLine("Ba số trên không phải là ba cạnh của một tam giác.");

//Bài tập 4
Console.WriteLine("\nBài tập số 4 \n");

Console.WriteLine("Nhập vào 3 số thực: ");
float a2_131,b2_131,c2_131;
a2_131 = float.Parse(Console.ReadLine());
b2_131 = float.Parse(Console.ReadLine());
c2_131 = float.Parse(Console.ReadLine());

if(a2_131*a2_131+b2_131*b2_131==c2_131*c2_131 || b2_131*b2_131+c2_131*c2_131==a2_131*a2_131 || c2_131*c2_131+a2_131*a2_131==b2_131*b2_131)
    Console.WriteLine("Ba số trên đúng là ba cạnh của một tam giác vuông.");
else
    Console.WriteLine("Ba số trên không phải là ba cạnh của một tam giác vuông.");
