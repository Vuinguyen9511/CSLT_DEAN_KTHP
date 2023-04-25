{
BatDau:
    Console.WriteLine("Hay chon phim chuc nang tu 1 den 3: ");
    Console.WriteLine("1. Giai phuong trinh ax^4+bx^2+c=0");
    Console.WriteLine("2.Nhap ma tran Amxn ");
    Console.WriteLine("3. Thoat");
    byte chon = 0;
    bool hq = byte.TryParse(Console.ReadLine(), out chon);
    if (!hq || chon > 3 || chon < 0)
        goto BatDau;
    switch (chon)
    {
        case 1:
            double a, b, c;
            double delta, x1, x2, x3, x4;

            Console.WriteLine("Nhap he so a, b, c cua phuong trinh trung phuong ax^4 + bx^2 + c = 0");
            Console.Write("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

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
            Console.ReadKey();
            goto BatDau;
          

        case 2:
            int m, n, col, row;
            Console.Write("Nhap so hang cua ma tran: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]: ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma tran ban dau la:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Ban muon phan chieu theo hang nao (nhap -1 neu khong phan chieu)? ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ban muon phan chieu theo cot nao (nhap -1 neu khong phan chieu)? ");
            col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ma tran phan chieu la:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (row != -1 && col != -1)
                    {
                        Console.Write("{0} ", matrix[m - row - 1, n - col - 1]);
                    }
                    else if (row != -1)
                    {
                        Console.Write("{0} ", matrix[m - row - 1, j]);
                    }
                    else if (col != -1)
                    {
                        Console.Write("{0} ", matrix[i, n - col - 1]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            goto BatDau;

    }
}