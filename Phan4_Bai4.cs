// See https://aka.ms/new-console-template for more information

    {
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
    }

