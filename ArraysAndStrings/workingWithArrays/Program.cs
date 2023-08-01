Console.WriteLine("Working With Arrays");

Console.WriteLine();
Console.WriteLine("Single Dimensional Arrays");

int[] marks = new int[5];
marks[0] = 25;
marks[1] = 50;
marks[2] = 75;
marks[3] = 100;
marks[4] = 125;

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}

int[] marks2 = new int[5] { 25, 50, 75, 100, 125 };

foreach (int mark in marks2)
{
    Console.WriteLine(mark);
}

Console.WriteLine();
Console.WriteLine("Two Dimension");

int[,] twoDimension = new int[3, 3];
twoDimension[0, 0] = 1;
twoDimension[0, 1] = 2;
twoDimension[0, 2] = 3;
twoDimension[1, 0] = 4;
twoDimension[1, 1] = 5;
twoDimension[1, 2] = 6;
twoDimension[2, 0] = 7;
twoDimension[2, 1] = 8;
twoDimension[2, 2] = 9;


for(int i = 0; i < twoDimension.GetLength(0); i++)
{
    for(int j = 0; j < twoDimension.GetLength(1); j++)
    {
        Console.WriteLine(twoDimension[i, j]);
    }
}

Console.WriteLine();

int[,] twoDimension2 = new int[2, 3]{ { 1, 2, 3 }, { 4, 5, 6 } };

for(int i = 0; i < twoDimension2.GetLength(0); i++)
{
    for(int j = 0; j < twoDimension2.GetLength(1); j++)
    {
        Console.WriteLine(twoDimension2[i, j]);
    }
}
Console.WriteLine();
Console.WriteLine("Three Dimension");

int[,,] threeDimension = new int[2, 2, 1];
threeDimension[0, 0, 0] = 1;
threeDimension[0, 1, 0] = 2;
threeDimension[1, 0, 0] = 3;
threeDimension[1, 1, 0] = 4;

for(int i = 0; i < threeDimension.GetLength(0); i++)
{
    for(int j = 0; j < threeDimension.GetLength(1); j++)
    {
        for(int k = 0; k < threeDimension.GetLength(2); k++)
        {
            Console.WriteLine(threeDimension[i, j, k]);
        }
    }
}

Console.WriteLine();
Console.WriteLine("Jagged Array");

//I can also set the values of jagged array like this.
int[][] jaggedArray = new int[2][] { new int[] {1,2,3 }, new int[] {4,5,6 } };
//jaggedArray[0] = new int[2];
//jaggedArray[1] = new int[3];

//I can set jagged array like this
//jaggedArray[0] = new int[]{ 1, 2};
//jaggedArray[1] = new int[]{3,4,5 };

foreach (int[] arr in jaggedArray)
{
    foreach(int num in arr)
    {
        Console.WriteLine(num);
    }
}