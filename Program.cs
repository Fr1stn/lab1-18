Console.Write("Скорость лодки в стоячей воде (V, км/ч): ");
double v = Convert.ToDouble(Console.ReadLine());
Console.Write("Скорость течения реки (U, км/ч, U < V): ");
double u = Convert.ToDouble(Console.ReadLine());
if (u >= v)
{
    Console.WriteLine("Ошибка: скорость течения должна быть меньше скорости лодки!");
    return;
}
Console.Write("Время движения по озеру (T1, ч): ");
double t1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Время движения против течения реки (T2, ч): ");
double t2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"V: {v} км/ч \nU: {u} км/ч \nT1: {t1} ч \nT2: {t2} ч");
Console.WriteLine($"Общий путь (S, км), пройденный лодкой: {(v * t1) + ((v - u) * t2)}");
