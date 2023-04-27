

//temp <=0 väga külm
//temp > 0 külm
//temp > 10 and <=15 - jahe
//temp >15 and temp < 20 soe
//temp >= 20 and temp <30 kuum
//temp >= 30 väga kuum

Console.WriteLine("Sisestage temperatuur:");
int temp = int.Parse(Console.ReadLine());   

if(temp >= 30)
{
    Console.WriteLine("VÄGA KUUM");
}
else if(temp < 30 && temp >= 20)
{
    Console.WriteLine("Kuum");
}
else if (temp < 20 && temp >=15)
{
    Console.WriteLine("Soe");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Jahe");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("Külm");
}
else
{
    Console.WriteLine("VÄGA KÜLM");
}
