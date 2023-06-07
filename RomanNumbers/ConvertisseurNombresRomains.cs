﻿namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
        => chiffreArabe switch
           {
               <= 3 => new string('I', (int)chiffreArabe),
               4    => "IV",
               <= 8 => "V" + Convertir(chiffreArabe - 5),
               _    => "IX"
           };
}
