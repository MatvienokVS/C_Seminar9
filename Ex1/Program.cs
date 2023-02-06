//Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(),out int stop);

WriteLine(RecRangeRevers(stop));


string RecRangeRevers(int n)
{
	if (n == 1) return n.ToString();
	else return $"{n},{RecRangeRevers(n - 1)}";	
}
