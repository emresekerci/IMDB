using System;
using System.Collections.Generic;
using System.Linq;

class Film
{
    public double ImdbPuanı { get; set; }
    public string İsmi { get; set; }

    public Film(double imdbPuanı, string ismi)
    {
        ImdbPuanı = imdbPuanı;
        İsmi = ismi;
    }

    public override string ToString()
    {
        return $"Film Adı: {İsmi}, IMDb Puanı: {ImdbPuanı}";
    }
}
