{
    double a, b, c;
    double delta, x1, x2, x3, x4;

    Console.WriteLine("Nhap he so a, b, c cua phuong trinh trung phuong ax^4 + bx^2 + c = 0");
    Console.Write("Nhap a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Nhap c: ");
    c = Convert.ToDouble(Console.ReadLine());

    delta = Math.Pow(b,2) - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem.");
    }
    else if (delta == 0)
    {
        x1 = x2 = -b / (2 * a);
        Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
    }
    else
    {
        double d = Math.Sqrt(delta);
        double h1 = (-b + d) / (2 * a);
        double h2 = (-b - d) / (2 * a);
        double i1 = Math.Sqrt(h1);
        double i2 = Math.Sqrt(h2);
        x1 = i1;
        x2 = -i1;
        x3 = i2;
        x4 = -i2;
        Console.WriteLine("Phuong trinh co 4 nghiem phan biet:");
        Console.WriteLine("x1 = {0}", x1);
        Console.WriteLine("x2 = {0}", x2);
        Console.WriteLine("x3 = {0}", x3);
        Console.WriteLine("x4 = {0}", x4);
    }
}