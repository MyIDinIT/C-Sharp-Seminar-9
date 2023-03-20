
void Job(int n,int x=1)
{
    if (x > n) return;
    else
    Job(n,x+1);
    Console.Write(x+" ");
}

Console.WriteLine("Ввеите числе:  ");
int n=Convert.ToInt32(Console.ReadLine());

Job(n);
