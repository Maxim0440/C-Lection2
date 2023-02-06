int[] array = {1, 12, 31,4, 18, 16, 17, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n )
{

if (array[index] == find)
{
    System.Console.WriteLine(index);
    // break- для остановки, после нахождения первого подходящего
    // значения
    break;
}
   // index = index + 1;  а можно и так:
   index++;
}