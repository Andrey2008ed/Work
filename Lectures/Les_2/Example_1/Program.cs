
int Max(int arg1, int arg2, int arg3)       // Функция принимает 3 числа и выбирает из них максимальное число.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;       
    return result;                            // Возвращаем результат.
}

int a1 = 56;
int b1 = 23;
int c1 = 22;
int a2 = 2;
int b2 = 576;
int c2 = 44;
int a3 = 55;
int b3 = 4;
int c3 = 44;

int max1 = Max(a1, b1, c1);                    // Опеределим трех финалистов.
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);