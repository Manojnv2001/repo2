﻿using System.Globalization;
using System.Text.RegularExpressions;
string format = "^(((0[13-9]|1[012])[-/]?(0[1-9]|[12][0-9]|30)|(0[13578]|1[02])[-/]?31|02[-/]?(0[1-9]|1[0-9]|2[0-8]))[-/]?[0-9]{4}|02[-/]?29[-/]?([0-9]{2}(([2468][048]|[02468][48])|[13579][26])|([13579][26]|[02468][048]|0[0-9]|1[0-6])00))$";
string data = "avavavav hgsdhsgd12 jshudusdf 02292024 jsbdcjds 121222";
string[] splittedData = data.Split();
foreach (string str in splittedData)
{
    if (Regex.IsMatch(str, format))
    {
        Console.WriteLine("Valid date :" + str);
    }
    else
    {
        Console.WriteLine("Invalid date :" + str);
    }

}



// Console.WriteLine("Hello, World!");
