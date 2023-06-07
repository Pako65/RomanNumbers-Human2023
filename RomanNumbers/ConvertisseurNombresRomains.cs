namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
        => chiffreArabe switch
           {
               <= 3 => new string('I', (int)chiffreArabe),
               4    => "IV",
               <= 8 => "V" + Convertir(chiffreArabe - 5),
               9    => "IX",
               <=  13  => "X" + Convertir(chiffreArabe - 10 ),
               14    => "XIV",
               <=  18  => "XV" + Convertir(chiffreArabe - 15 ),
               19    => "XIX",
               <= 23 => "XX" + Convertir(chiffreArabe -20 )


           };

}
