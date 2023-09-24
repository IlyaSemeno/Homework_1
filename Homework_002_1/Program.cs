Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=100 && number<=999){
    int secondnumber = (number/10)%10;
    Console.WriteLine("Вторая цифра: " + secondnumber);
}
else{
    Console.WriteLine("Это не трехзначное число.");
}