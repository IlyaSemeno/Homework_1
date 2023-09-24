Console.WriteLine("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number==6 || number == 7 && number <=7 && number >=1){
    Console.WriteLine("Да, это выходной");
}
else{
    Console.WriteLine("Нет, это будни!!");
}