{
    double a, b, c, delta, x1, x2, x3, x4;

    Console.Write("Nhap he so a: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Nhap he so b: ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Nhap he so c: ");
    c = Convert.ToDouble(Console.ReadLine());

    delta = Math.Pow(b, 2) - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }
    else if (delta == 0)
    {
        x1 = x2 = -b / (2 * a);
        Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + x1);
    }
    else
    {
        x1 = Math.Sqrt((-b - Math.Sqrt(delta)) / (2 * a));
        x2 = -Math.Sqrt((-b - Math.Sqrt(delta)) / (2 * a));
        x3 = Math.Sqrt((-b + Math.Sqrt(delta)) / (2 * a));
        x4 = -Math.Sqrt((-b + Math.Sqrt(delta)) / (2 * a));
        Console.WriteLine("Phuong trinh co 4 nghiem phan biet: ");
        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
        Console.WriteLine("x3 = " + x3);
        Console.WriteLine("x4 = " + x4);
    }

    Console.ReadKey();
}
# CSLT_DEAN_KTHP
