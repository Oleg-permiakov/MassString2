// Написать программу которая найдёт точку пересечения двух прямых, заданых уравнениями y=k1*x + b1, y=k2*x + b2
// значения b1,k1 и b2,k2 задаются пользователем


int[] Point() {
Console.WriteLine("Введите значения через запятую b1,k1,b2,k2");
string input = Console.ReadLine();
string[] arrayStr = input.Split(",");
int[] nam = new int[arrayStr.Length];
for (int i = 0; i < arrayStr.Length; i++)
{
    nam[i] = Convert.ToInt32(arrayStr[i]);
} return nam;
}

void PointCross(int[] array) {
double X;
double Y;
if(array[1] == array[3])
{ 
    
Console.WriteLine("Прямые паралельны, точки пересечения нет");

}
X = (array[2] - array[0]) / (array[1] - array[3]);
Y = ((array[1] * array[2]) - (array[3] * array[0])) / (array[1] - array[3]);

Console.WriteLine("Точка пересечения(" +  X  + "," + Y + ")");

}

int[] array = Point();
PointCross(array);
