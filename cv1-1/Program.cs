class PDA
{
    //Ukol 1.2
    static void namePrint() {
        Console.WriteLine("Zadejte jméno: ");
        string input_name = Console.ReadLine();
        Console.WriteLine("Zadejte příjmení: ");
        string input_surname = Console.ReadLine();

        Console.WriteLine("Vaše jméno a příjmení je: " + input_name + " " + input_surname);
    }

    //Ukol 1.3
    static void rgbToHex()
    {
        Console.WriteLine("Zadejte červenou složku RGB: ");
        int rgb_r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadejte zelenou složku RGB: ");
        int rgb_g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadejte modrou složku RGB: ");
        int rgb_b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Vaše zadané RGB údaje jsou: " + "r:" + rgb_r + " g:" + rgb_g + " b:" + rgb_b);

        //Prevod INT na string a soucasne na hex.tvar
        string rToHex = rgb_r.ToString("X");
        string gToHex = rgb_g.ToString("X");
        string bToHex = rgb_b.ToString("X");

        Console.WriteLine("Hexadecimální tvar vaší barvy je: "  + "#"+ rToHex + gToHex + bToHex);

        //Prevod do binarni soustavy
        string rToString = rgb_r.ToString("X");
        string gToString = rgb_g.ToString("X");
        string bToString = rgb_b.ToString("X");

        String rToBin = Convert.ToInt32(rToString, 2).ToString();
        String gToBin = Convert.ToInt32(gToString, 2).ToString();
        String bToBin = Convert.ToInt32(bToString, 2).ToString();
    }

    //Ukol 1.4
    static void NumToBin() {
        Console.WriteLine("Zadejte celé číslo: ");
        int input = Convert.ToInt32(Console.ReadLine());
        String binary = Convert.ToString(input, 2);
        Console.WriteLine("Vaše zadané celé číslo je: " + input + "a její binární tvar je: " + binary);
    }

    static void Main(String[] args) {
        //Test ukolu 1.2
        //charToDecHex();
        //Test ukolu 1.3
        //namePrint();
        //Test ukolu 1.4
        //rgbToHex();
        //Test ukolu 1.5
        //NumToBin();
    }

    //Ukol 1.5
    //Nacist znak -> vypsat + ascii
    //ascii prevest na hex a dec
     static void charToDecHex() {
        Console.WriteLine("Zadejte znak: ");
        string input = Console.ReadLine();

        Console.WriteLine("Zadaný znak je: " + "' " + input + " '");

        foreach (var c in input) {
            Console.WriteLine("ASCII kod znaku: " + c + " je: " + (int)c);
        }

        string asciiToHex = string.Join(String.Empty, input.Select(c => ((int)c).ToString("X")).ToArray());
        Console.WriteLine("Hexadecimální kód znaku: " + input + " je: " + asciiToHex);
    }

}
