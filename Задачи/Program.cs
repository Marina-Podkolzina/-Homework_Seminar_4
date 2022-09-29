//Задача 25: Используя определение степени числа, 
//напишите цикл, который принимает на вход два натуральных
// числа (A и B) и возводит число A в степень B.

void Zadacha25()
{

Console.WriteLine ("Введите число А :");
int numberA= Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число B :");
int numberB= Convert.ToInt32 (Console.ReadLine ());
int result = numberA;
int i = 2;
while (i<=numberB)
{ 
    result = result*numberA;
    i++;
}
Console.WriteLine ($"число А в степени В = {result}");
}
//Zadacha25();   



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Zadacha27()
{
Console.WriteLine ("Введите число:");
int number= Convert.ToInt32 (Console.ReadLine ());
int sum =0;
while (number> 0)
{
    sum= sum + number%10;
    number= number / 10;

}
Console.WriteLine ($" Сумма всех цифр числа = {sum}");
}
//Zadacha27();


//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
// и выводит отсортированный по модулю массив.

void Zadacha29()
{
    Random random = new Random();
    int[] numbers= new int[8];
    void FillArray(int[] num)
        {
         Random random = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(-100, 100);
        }
        }
    FillArray(numbers);


    void PrintArray(int[] num1)
        {
            for (int i=0; i<num1.Length; i++)
            {
                Console.Write(num1[i]+ "  ");
            }
        }
    Console.WriteLine("Создали массив:");
    PrintArray(numbers);




    void Sorting(int[] num2)
        {
        int tmp = 0;
        int i = 0;
        int max = Math.Abs(num2[i]);
        int max_in = 0;
        int size = num2.Length;
        while (size > 0)
        {
            while (i < size)
            {
            if (Math.Abs(num2[i]) >= Math.Abs(max))
                {
                max = num2[i];
                max_in = i;
                }
            i++;
            }  
       
        tmp = num2[size-1];
        num2[size-1] = max;
        num2[max_in] = tmp;
        i = 0;
        max = 0;
        max_in = 0;
        size = size - 1;
        }
        }
    Sorting(numbers);


    Console.WriteLine();
    Console.WriteLine("Отсортировали массив по модулю:");
    PrintArray(numbers);
}
//Zadacha29();