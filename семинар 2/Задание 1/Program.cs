Console.Write("Введите целое число от 100 до 999 включительно =>");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=100 && number<999)
{
    int secondNumber = number%100;
    secondNumber = secondNumber/10;
    Console.WriteLine($"Вторая цифра введенного числа => {secondNumber} ");
}
else{
    Console.WriteLine($"Число {number} не входит в диапазонон от 100 до 999");
}