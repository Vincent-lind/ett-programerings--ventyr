Console.WriteLine("Du står inför den enorma porten till ett fängelse du enbart hört tallas om, av från handelsmänen. Vill du stiga in eller vill du resa hela väg hem, STIG IN eller GÅ HEM?");
string name = Console.ReadLine();             //bit 1
name = name.ToLower();

if (name == "stig in")
{
    Console.WriteLine("Du valde att utmana fängelsehålan och går in jenom den kala porten");

    Console.WriteLine("Du kommer in och tänder din fackla och ser att något åt din höger sveper förbi, åt din vänster ser du en tänd lyckta och en pöl blod som leder runt hörnet. När du bara kommit ett par meter in så slår porten till backom dig och du har val att göra, VÄNSTER eller HÖGER?");
    string glurb = Console.ReadLine();        //bit 2

    if (glurb == "höger")
    {
        Console.WriteLine("Du tar den högra vägen för att undvika doften av blod och det som rörde sig kan omöjligtvis vara något mer än en råta. Det var den sista tanken du hade inan den stor man med kråkhuvud slår dit huvud i bitar med en spikig klubba. :(");
    }
    else if (glurb == "vänster")
    {
        Console.WriteLine("Du valde att följa ljuset och undvika vad det må ha ha rört sig i skugorna. Du kommer runt hörnet och ser en halvt uppbäten man men ingen utövare, längre in i kåridåren står en kista uplyst med en lyckta på var sida, och till din höger så finns ett mörkt rum inte släper igenom ljuset från din fakla.");

        Console.WriteLine("Vad vill du göra SKATTKISTA eller MÖRKT RUM??");
        string glorb = Console.ReadLine();     //bit 3

        if (glorb == "skattkista")
        {
            Console.WriteLine("Du rör dig närmare mot skattkistan och för en sekund tyckte du att du kunde se den öppna sig en liten bit. När du är frame och försöker öppna kistan så ser du dit liv flyga förbi, men inget du ser dens vassa tänder men inget den växer kötiga utt ben och en svans. Den gör ifrån sig ett hund liknande ljud och du klappar den på huvudet och du kan se att svansen svingar. Du tar dig utt ur fängelsähålan med din nya besta vän. :) ");
        }
        else if (glorb == "mörkt rum")
        {
            Console.WriteLine("Du går mot det mörka rummet och du ser ett ben på marken du plockar upp det och ser att skattkistan har växt ben i full fart mot dig, så du springer in i det mörka rummet. Det första steget in rumet och börjar falla, du har blivit genomborrad av ett dussin återanvända råstiga spjut. Sista sekunden av liv du har så tycks du höra en hunds gnyende. :(");
        }
        else
        {
            Console.WriteLine("Börja om från början");
        }
    }

    else if (name == "gå hem")
    {
        Console.WriteLine("Du valde att inte ta dig in i fängelsehålan och kom undan med ditt liv i behåll, men en del av dig tror inte att det är sant.");
    }
    else
    {
        Console.WriteLine("Börja om från början");
    }

}

    Console.ReadLine();