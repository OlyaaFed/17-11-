int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0 && z>0)
{
    Console.WriteLine("1");
}
else
{
    if (x < 0 && y > 0 && z>0)
    {
        Console.WriteLine("2");
    }
    else
    {
        if (x < 0 && y < 0 && z>0)
        {
            Console.WriteLine("3");
        }
        else
        {
            if (x > 0 && y < 0 && z > 0)
            {
                Console.WriteLine("4");
            }
            else
            {
                if (x > 0 && y < 0 && z < 0)
                {
                    Console.WriteLine("5");
                }
                else {
                    if (x > 0 && y < 0 && z < 0)
                    {
                        Console.WriteLine("6");
                    }
                    else
                    {
                        if (x > 0 && y < 0 && z < 0)
                        {
                            Console.WriteLine("7");
                        }
                        else {
                            if (x > 0 && y < 0 && z < 0)
                            {
                                Console.WriteLine("8");
                            }
                            else
                            {
                                { Console.WriteLine("На координатной прямой"); }
                            }
                        }
                    }
                }
            }

            
        }
    }
}
