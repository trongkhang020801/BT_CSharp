// See https://aka.ms/new-console-template for more information
const double pi_131=3.14159;
// Bài 1
Console.WriteLine("Bài 1: Nhập vào diện tích một mặt cầu. Tính thể tích\n");
Console.WriteLine("Nhập vào diện tích mặt cầu: ");
Double S_131, R_131, V_131;
S_131 = Double.Parse(Console.ReadLine());
R_131 = Math.Sqrt(S_131/(4*pi_131));
V_131 = (4.0/3)*pi_131*Math.Pow(R_131,3);
Console.WriteLine("Thể tích của mặt cầu: "+ V_131);

// Bài 2
Console.WriteLine("\nBài 2: Nhập vào tọa độ 2 điểm A và B. Tính khảong cách AB\n");
Double Xa_131, Ya_131, Xb_131, Yb_131, AB;
Console.WriteLine("Nhập vào tọa độ điểm A: \n");
Console.WriteLine("Xa= "); Xa_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Ya= "); Ya_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập vào tọa độ điểm B: \n");
Console.WriteLine("Xb= "); Xb_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Yb= "); Yb_131 = Double.Parse(Console.ReadLine());
AB= Math.Sqrt(Math.Pow(Xb_131-Xa_131,2)+Math.Pow(Yb_131-Ya_131,2));
Console.WriteLine("Độ dài giữa 2 điểm: "+ Math.Abs(AB));

// Bài 3 
Console.WriteLine("\nBài 3: Giải phương trình bậc 1\n");
Console.WriteLine("Nhập vào công thức phương trình: ax + b = 0\n");
Console.WriteLine("Nhập vào a: ");
Double a_131, b_131;
a_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập vào b: ");
b_131 = Double.Parse(Console.ReadLine());
if (a_131==0)
    Console.WriteLine("Phương trình vô nghiệm");
else
    if (b_131==0)
        Console.WriteLine("Phương trình có vô số nghiệm");
    else
        Console.WriteLine("Nghiệm của phương trình: "+ -b_131/a_131);

// Bài 4
Double a1_131, b1_131,c1_131;
Console.WriteLine("Bài 4: Giải phương trình bậc 2");
Console.WriteLine("Nhập vào công thức phương trình: ax^2 + bx + c = 0\n");
Console.WriteLine("Nhập vào a: ");
a1_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập vào b: ");
b1_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập vào c: ");
c1_131 = Double.Parse(Console.ReadLine());
if (a1_131==0)
    if (b1_131==0)
        Console.WriteLine("Phương trình vô nghiệm");
    else
        Console.WriteLine("X= "+-c1_131/b1_131);
else
    {
        Double x1_131, delta_131;
        delta_131 = Math.Pow(b1_131,2)-(4*a1_131*c1_131);
        if (delta_131>0)
            {
                x1_131 = (-b1_131-Math.Sqrt(delta_131))/(2*a1_131);
                Double x2_131= (-b1_131+Math.Sqrt(delta_131))/(2*a1_131);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                Console.WriteLine("x1= "+ x1_131 + "\nx2= "+x2_131);
            }
        else
            if (delta_131==0)
                {
                    x1_131 = (-b1_131)/(2*a1_131);
                    Console.WriteLine("Phương trình có nghiệm kép: "+ x1_131);
                }
            else
                Console.WriteLine("Phương trình vô nghiệm");
    }

// Bài 5
Console.WriteLine("Bài 5: Viết chương trình nhập vào số giờ,"+
"xuất ra số tương đương tính theo tuần, ngày và the giờ");
int gio_131;
Console.WriteLine("Nhập vào số giờ: ");
gio_131 = Convert.ToInt32(Console.ReadLine());
int tuan_131 = gio_131/168;
int ngay_131 = (gio_131-tuan_131*168)/24;
int the_131 = gio_131-ngay_131*24-tuan_131*168;
Console.WriteLine(tuan_131+" Tuần, "+ngay_131+" Ngày, "+the_131+" giờ");

// Bài 6
Console.WriteLine("\nBài 6: Nhập vào 2 thời điểm. Tính thời gian trải qua giữa 2 thời điểm\n");
int hour_131, mini_131, second_131;
Console.WriteLine("Nhập giờ[1]: "); hour_131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập phút[1]: "); mini_131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập giây[1]: "); second_131 = Convert.ToInt32(Console.ReadLine());
int time_131 = 3600*hour_131 + 60*mini_131 + second_131;
Console.WriteLine("Nhập giờ[2]: "); hour_131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập phút[2]: "); mini_131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập giây[2]: "); second_131 = Convert.ToInt32(Console.ReadLine());
time_131 -=  3600*hour_131 + 60*mini_131 + second_131;
time_131 = Math.Abs(time_131);
Console.WriteLine("Hiệu thời gian: "+time_131/3600+" giờ, "+(time_131%3600)/60+" phút, "+(time_131%3600)%60+" giây");

// Bài 7
Console.WriteLine("\nBài7: Nhập vào số kW điện tiêu thụ. Tính tiền điện phải trả.");
Console.WriteLine("\nNhập vào số kW tiêu thụ: ");
int kw_131 = Convert.ToInt32(Console.ReadLine());
long money_131;
if(kw_131<=100) money_131 = kw_131*500;
else if (kw_131<=250) money_131 = 500*100 + (kw_131-100)*800;
    else if (kw_131<=350) money_131 = 100*500 + 800*150 + 1000*(kw_131-250);
    else money_131 = 500*100 + 150*800+ 1000*100 + 1500*(kw_131-350);

Console.WriteLine("Chi phí: "+money_131);

// Bài 8
Console.WriteLine("\nBài 8: Nhập vào điểm chuẩn, điểm 3 môn thi, khu vực, đối tượng. Thống báo đậu hay rớt");
Console.WriteLine("Nhập điểm chuẩn: "); Double diemchuan_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập điểm môn thi thứ 1: "); Double diemthi1_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập điểm môn thi thứ 2: "); Double diemthi2_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập điểm môn thi thứ 3: "); Double diemthi3_131 = Double.Parse(Console.ReadLine());
Console.WriteLine("Chọn khu vực (A,B,C,X) (Nhập X nếu không thuộc khu vực nào): "); char khuvuc_131 = char.Parse(Console.ReadLine());
Console.WriteLine("Chọn đối tượng (1,2,3,0) (Nhập 0 nếu không thuộc đối tượng ưu tiên nào):"); int obj_131 = Convert.ToInt32(Console.ReadLine());
Double tongDiem = diemchuan_131+diemthi2_131+diemthi3_131;
if(khuvuc_131=='A') tongDiem+=2;
else if (khuvuc_131 == 'B') tongDiem+=1;
     else if (khuvuc_131=='C') tongDiem+=0.5;

if(obj_131==1) tongDiem+=2.5;
else if(obj_131==2) tongDiem+=1.5;
     else if (obj_131 == 3) tongDiem+=1;

if (tongDiem >= diemchuan_131) Console.WriteLine("Đậu ["+tongDiem+"]");
else  Console.WriteLine("Rớt ["+tongDiem+"]");

// Bài 9
Console.WriteLine("Bài 9: Tìm số hoàn hảo nhỏ hơn một số nguyên dương được nhập vào");
Console.WriteLine("Nhâp vào 1 số nguyên dương: "); int number_131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Các số hoàn hảo nhỏ hơn "+ number_131);
int sum_131, j_131;
for(int i_131=1;i_131<number_131;i_131++)
{
    for (sum_131 =0, j_131=1;sum_131<=i_131 && j_131<i_131;j_131++)
        if (i_131%j_131==0) sum_131+=j_131;
    if(sum_131==i_131) Console.WriteLine(sum_131);
}

// Bài 10
Console.WriteLine("Bài 10: In ra bảng cưu chương từ 2 đến 9");
Console.WriteLine("\nBảng cửu chương");
int i1_131,j1_131;
for(i1_131=1;i1_131<=10;i1_131++)
{
    for(j1_131=2;j1_131<=9;j1_131++)
        Console.WriteLine("||"+j1_131+"X"+i1_131+"= "+i1_131*j1_131);
    Console.WriteLine("||\n");
}

// Bài 11
Console.WriteLine("Bài 11: In ra n số nguyên tố dầu tiên(n được nhập từ bàn phím");
Console.WriteLine("Nhập vào số nguyên n: "); int n_131 = Convert.ToInt32(Console.ReadLine());
int k_131=2, count_131 =0, i2_131;
Console.WriteLine("Các số nguyên tố nhỏ hơn "+n_131+" là: ");
while(count_131<n_131)
{
    for( i2_131 = 2;i2_131*i2_131<=k_131;i2_131++)
        if(k_131 %i2_131==0)break;
    if(i2_131*i2_131>k_131){
        Console.WriteLine(k_131);
        count_131++;
    }
    k_131++;
}