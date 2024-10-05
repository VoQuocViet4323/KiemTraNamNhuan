internal class Program
{
    private static void Main(string[] args)
    {
        int nam;
        bool namNhuan = false;
        Console.WriteLine("Nhap nam: ");
        nam = int.Parse(Console.ReadLine());
        bool isDivisibleBy4 = nam % 4 == 0;
        if(isDivisibleBy4){
            bool isDivisibleBy100 = nam % 100 == 0;
            if(isDivisibleBy100){
                bool isDivisibleBy400 = nam % 400 == 0;
                if(isDivisibleBy400){
                    namNhuan = true;
                }
            }else{
                namNhuan = true;
            }
        }if(namNhuan){
            Console.WriteLine("{0} la nam nhuan", nam);            
        }else  
            Console.WriteLine("{0} khong phai nam nhuan", nam);            
    }
}