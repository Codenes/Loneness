using System;

class BasicInputOutput
{
    static void Main(string[] args)
    {
        int password;
        String type;
        
        Console.Write ("Input your Password : ");
        int.TryParse(Console.ReadLine(), out password);
        Console.Write ("Input Type : ");
        type = Console.ReadLine();
        
        int one_digit = password/100000;
        int two_digit = (password/10000)%10;
        int three_digit = (password/1000)%10;
        int forth_digit = (password/100)%10;
        int fifth_digit = (password/10)%10;
        int sixth_digit = (password/1)%10;
        
        //Console.WriteLine("one_digit : {0}", one_digit);
        //Console.WriteLine("two_digit : {0}", two_digit);
        //Console.WriteLine("three_digit : {0}", three_digit);
        //Console.WriteLine("forth_digit : {0}", forth_digit);
        //Console.WriteLine("fifth_digit : {0}", fifth_digit);
        //Console.WriteLine("sixth_digit : {0}", sixth_digit);
        
        switch (type)
        {
        case "CIA":
            if (((sixth_digit%3) == 0) && (fifth_digit != 1) && (fifth_digit != 3) && (fifth_digit != 5) && (three_digit != 8) && (three_digit > 6) ) 
            {
            Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        break;
        case "FBI":
            if ((one_digit >= 4) && (one_digit <= 7) && (forth_digit != 6) && ((forth_digit%2) == 0) && ((two_digit%2) != 0) ) 
            {
            Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        break;
        case "NSA":
            if ((sixth_digit <= 6) && (sixth_digit != 4) && (sixth_digit != 0) && ((forth_digit%3) == 0) && ((forth_digit%2) != 0  ) && (one_digit == 7) || (two_digit == 7) || (three_digit == 7) || (fifth_digit == 7)  ) 
            {
            Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        break;
        default:
        Console.WriteLine("False");
        break;
        }
    }
}
    