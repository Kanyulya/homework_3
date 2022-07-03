// напишите программу, которая ринимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

//первый набоор чисел

double num(double xa, double ya, double za, double xb, double yb, double zb){ 
    double result = 0;
    if  (xa == xb && xa == yb && za == zb)
    {
        return result;
    }
    else 
    {
        result = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb - za,2));
        return result;
    }
}
double res = num(3, 6, 8, 2, 1, -7);
Console.WriteLine(res);



//второй набор чисел

// double num(double xa, double ya, double za, double xb, double yb, double zb){ 
//     double result = 0;
//     if  (xa == xb && xa == yb && za == zb)
//     {
//         return result;
//     }
//     else 
//     {
//         result = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb - za,2));
//         return result;
//     }
// }
// double res = num(7, -5, 0, 1, -1, 9);
// Console.WriteLine(res);


//если надо вводить всё самостоятельно

// double num(double xa, double ya, double za, double xb, double yb, double zb){ 
//     double result = 0;
//     if  (xa == xb && xa == yb && za == zb)
//     {
//         return result;
//     }
//     else 
//     {
//         result = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb - za,2));
//         return result;
//     }
// }
// Console.WriteLine("введите координату X первой точки");
// double xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату Y первой точки");
// double ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату Z первой точки");
// double za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату X первой точки");
// double xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату Y первой точки");
// double yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату Z первой точки");
// double zb = Convert.ToInt32(Console.ReadLine());
// double res = num(xa, ya, za, xb, yb, zb);
// Console.WriteLine(res);