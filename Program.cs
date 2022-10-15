Console.WriteLine("введите положительное число");

int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = - numberA;

while (numberB <= numberA)
{
    Console.Write(numberB );
    Console.Write(";");
    numberB+=1;
}