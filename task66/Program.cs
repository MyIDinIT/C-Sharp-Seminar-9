// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
//  элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Job(int M,int N, int Sum)
{
    
    if (M>N) 
    {
        return 0;
    }
    Sum=M+Job(M+1,N,Sum);
       return Sum;
    
}

Console.WriteLine("Ввеите меньшее числе:  ");
int M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввеите большее числе:  ");
int N=Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Job(M,N,0));