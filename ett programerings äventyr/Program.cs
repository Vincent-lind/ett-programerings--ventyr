Console.WriteLine("första utmaningen ja eller nej?");   
string name = Console.ReadLine();
name = name.ToLower();

if (name == "ja")
{
    Console.WriteLine("Du valde att utmana fängelsehålan och går in jenom den kala porten");
    
    Console.WriteLine("glurb eller glorb");
    string glurb = Console.ReadLine();

    if (glurb == "glurb")
{
    Console.WriteLine("fell");
}
else if (glurb == "glorb") 
{
    Console.WriteLine("rätt");
}
else
{
     Console.WriteLine("Börja om från början");
}
}

else if (name == "nej") 
{
    Console.WriteLine("Du valde att inte ta dig in i fängelsehålan och kom undan med ditt liv i behåll, men du får en känsla att du missat något stort.");
}
else
{
    Console.WriteLine("Börja om från början");
}



Console.ReadLine();