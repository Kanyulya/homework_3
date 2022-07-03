// напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

int[] getArray(int num)
{
    int[] squares = new int[num];
    int i =1;               
    while (i<=num)
    {
        squares[i-1] = i*i*i;
        Console.WriteLine(squares[i-1]);
        i++;
    }
    return squares;
}
Console.WriteLine("Введите число");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] result = getArray(numbers);