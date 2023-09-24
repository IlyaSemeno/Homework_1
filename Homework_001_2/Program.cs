Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a>b && a>c){
    max = a;
    Console.WriteLine("max = " + max);
}
if(b>a && b>c){
    max = b;
    Console.WriteLine("max = " + max);
    
}
if(c>b && c>a){
    max = c;
    Console.WriteLine("max = " + max);
    
}
