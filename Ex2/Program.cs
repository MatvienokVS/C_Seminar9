//Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Введите начало диапазона: ");
int.TryParse(ReadLine(), out int start);    //m

Write("Введите окончание диапазона: ");
int.TryParse(ReadLine(), out int stop);     //n

RecRange(start, stop);
//SummRecRange(stop, start);


void RecRange(int m, int n)
{
	//if (m == n) return m.ToString();
	//else return $"{RecRange(n, m - 1)},{m}";

	WriteLine(SummRecRange(m - 1, n));
}

int SummRecRange(int m, int n)
{
	int summ = 0;
	if (m == n) return 0;
	else
	{
		m++;
		summ = m + SummRecRange(m, n);
		return summ;

	}
}