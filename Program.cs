using System.Text;
using Varosok;

List<Nagyvaros> varosok = [];

using (StreamReader sr = new StreamReader(@"..\..\..\src\varosok.csv", Encoding.UTF8))
{
    while (!sr.EndOfStream)
    {
        varosok.Add(new Nagyvaros(sr.ReadLine()));
    }
}

//1. feladat
Console.WriteLine($"Kína összes lakosa: {varosok.Where(x => x.Orszag == "Kína").Sum(x => x.Nepesseg):F0} fő\n");


//2. feladat

Console.WriteLine($"India átlaglélekszáma: {varosok.Where(x => x.Orszag == "India").Average(x => x.Nepesseg):F0} fő\n");

//3. feladat
Console.WriteLine($"A legnépesebb város: {varosok.OrderByDescending(x => x.Nepesseg).First()}\n");

//4. feladat

var nagyvarosok = varosok.Where(x => x.Nepesseg > 20000000).OrderByDescending(x => x.Nepesseg);
foreach (var n in nagyvarosok)
{
    Console.WriteLine($"{n.Varos} ({n.Orszag}): {n.Nepesseg:F0} fő");
}

//5. feladat

Console.WriteLine($"\nOlyan országok száma, ahol több nagyváros is szerepel: {varosok.GroupBy(x => x.Orszag).Where(x => x.Count() > 1).Count()}\n");

//6. feladat

var kezdobetu = varosok.GroupBy(x => x.Varos[0]).OrderByDescending(x => x.Count()).First();
Console.WriteLine($"A legtöbb város neve {kezdobetu.Key}-vel kezdődik: {kezdobetu.Count()} db\n");