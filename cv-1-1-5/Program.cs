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
    public static void tiskCharASCII(char z)
    {
        /*
        Console.WriteLine("'" + z + "'");
        int cislo = Convert.ToInt32(z);
        Console.WriteLine(cislo);
        string hexcislo = cislo.ToString("x");
        Console.WriteLine(hexcislo + "H");
        */
        Console.WriteLine(tiskCharASCII_2(z));
    }

    public static string tiskCharASCII_2(char z)
    {
        int cislo = Convert.ToInt32(z);
        string hexcislo = cislo.ToString("x");
        string hex = "'" + z + "' " + cislo + " " + hexcislo + "H ";
        return hex;
    }

}
