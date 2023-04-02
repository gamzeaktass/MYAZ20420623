var g1 = new List<int>() { 10, 20,25, 30,4 };
var g2 = new List<int>() { 15, 25, 35,3,4 };
var g3 = new List<int>() { 10, 15, 20, 25, 40, 50,4 };
//Ortak OLmayan Elemanları Yazdırma
//dot per line(her satıra bir nokta)

 g1
    .Union(g2)
    .Union(g3)
    .ToList();//Tekrar etmeyecek şekilde tüm elemanları birleştirme
//.union birleştirme işlemi yapar.
//var result = g1;
//result.ForEach(number => Console.WriteLine(number));

/*var result = new List<int>();
foreach (var g in g1)
{
    if (!result.Contains(g))//Burada eğer result gyi içeriyorsanın değilini aldık ve bu sayede ortak olmayanları yazdırdık.
    {
        result.Add(g);
    }
}
foreach(var g in g2)
{
    if (!result.Contains(g))
    {
        result.Add(g);
    }
}
foreach( var g in g3) 
{
    if (!result.Contains(g))
    {
        result.Add(g);
    }
}*/
//Ortak Olan Elemanları Yazdırma
g1
    .Intersect(g2)//.Intersect kesişim alır.
    .Intersect(g3)
    .ToList();
//.ForEach(n => Console.WriteLine(n));
//g1-g1kesişimg2
g1
    .Except(g2)//.except küme-kesişim işlemi yapar
    .ToList()
    .ForEach(g => Console.WriteLine(g));
