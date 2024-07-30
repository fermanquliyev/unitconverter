using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(Converter.Convert("min","hr", 90));
	}
}

public static class Converter {
	private static Dictionary<string, double> Ratios = new Dictionary<string, double>
	{
    	// Time
    	{"hr-min", 60},
    	{"min-hr", 1.0 / 60},
    	{"min-sec", 60},
    	{"sec-min", 1.0 / 60},
    	{"hr-sec", 3600},
    	{"sec-hr", 1.0 / 3600},

    	// Length
    	{"m-cm", 100},
    	{"cm-m", 1.0 / 100},
    	{"m-mm", 1000},
    	{"mm-m", 1.0 / 1000},
    	{"km-m", 1000},
    	{"m-km", 1.0 / 1000},
    	{"mile-km", 1.60934},
    	{"km-mile", 1.0 / 1.60934},
    	{"ft-m", 0.3048},
    	{"m-ft", 1.0 / 0.3048},
    	{"in-cm", 2.54},
    	{"cm-in", 1.0 / 2.54},
    
    	// Weight
    	{"kg-g", 1000},
    	{"g-kg", 1.0 / 1000},
    	{"lb-kg", 0.453592},
    	{"kg-lb", 1.0 / 0.453592},
    	{"oz-g", 28.3495},
    	{"g-oz", 1.0 / 28.3495},
    
    	// Volume
    	{"l-ml", 1000},
    	{"ml-l", 1.0 / 1000},
    	{"l-gal", 0.264172},
    	{"gal-l", 1.0 / 0.264172},
    	{"qt-l", 0.946353},
    	{"l-qt", 1.0 / 0.946353},
    	{"pt-l", 0.473176},
    	{"l-pt", 1.0 / 0.473176},
    	{"cup-l", 0.24},
    	{"l-cup", 1.0 / 0.24},

    	// Data Storage
    	{"byte-kb", 1.0 / 1024},
    	{"kb-byte", 1024},
    	{"kb-mb", 1.0 / 1024},
    	{"mb-kb", 1024},
    	{"mb-gb", 1.0 / 1024},
    	{"gb-mb", 1024},
    	{"gb-tb", 1.0 / 1024},
    	{"tb-gb", 1024}
	};
	
	public static string Convert(string from, string to, double val){
		from = from.ToLower(); to = to.ToLower();
		if(Converter.Ratios.ContainsKey($"{from}-{to}")){
			var ratio = Converter.Ratios[$"{from}-{to}"];
			return $"answer is {val*ratio}";
		}
		return "Not convertible";
	}
} 
