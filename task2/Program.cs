﻿int i1 = 5;
int i2 =6;
int sum = i1 + i2;

Console.WriteLine(sum);

//Если типы данных у амперандов которые учавствуют в бинарной операции разные ,
// то в этом случаии тип данных у результата будет формироваться как наиболее обемный  или наиболее вместительный тип данных.

long l1 = 6;
long sum2 = l1 + i1;

Console.WriteLine(sum2);

double d1 = 5.55;
double  sum3 = d1 + i1;   

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;

Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);