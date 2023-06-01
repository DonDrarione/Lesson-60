Console.WriteLine("rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("depths = ");
int depths = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = ");
int max = Convert.ToInt32(Console.ReadLine()); //вводим данные
while (min<10 || max>99 || min>max || (max-min+1)<rows*columns*depths)
{
    Console.WriteLine("Указаны неверные значения");
    Console.WriteLine("min = ");
     min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("max = ");
     max = Convert.ToInt32(Console.ReadLine()); 
}

var A_B = CreatingArray(rows, columns, depths, min, max); //создаем массив

WriteArray(A_B);
int[,,] CreatingArray(int rows, int columns, int depths, int min, int max)
{
    var array = new int[rows, columns, depths];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                while (true)
                {
                    var A = new Random().Next(min, max+1);
                    var in_ = false;

                    foreach (var b in array)
                    {
                        if (b == A)
                        {
                            in_ = true; 
                        }
                    }
                    if (!in_)
                    {
                        array[i, j, k] = A;
                        break;
                    }
                }
            }
        }
    }
    return array;
}

void WriteArray(int[,,] array)
    
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[j,k,i] +$" ({j},{k},{i})"+ "\t");
            }
            Console.WriteLine();
        }
        
    }

}
