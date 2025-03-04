using System.ComponentModel.Design;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sisesta oma vanus!");
        int vanus = int.Parse(Console.ReadLine());

        if (vanus >= 0 && vanus <= 18)
        {
            Console.WriteLine("Oled alaealine!");
        }
        else if (vanus >= 18 && vanus <= 65)
        {
            Console.WriteLine("Oled täisealine");
        }
        else
        {
            Console.WriteLine("Oled pentsionär");
        }
    }
}