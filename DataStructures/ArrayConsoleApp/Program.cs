using Array;
var array = new Array.Array();
array.Add("Gamze"); //0-------> ilk 4 eleman bellekte dizi için ayrılan ilk 4 blokta bulur----->4
array.Add("Hacer"); //1------->4
array.Add("Sıla");  //2------->4
array.Add("Gülsüm");//3------->4
array.Add("Şebnem");//4-------> 4ten sonraki elemanlar ise 4*2=8 blokluk alanda tutulur.------->8
Console.WriteLine(array.Find("Gamze"));//0 çıktısı
Console.WriteLine(array.GetItem(array.Find("Gamze")));//Gamze çıktısı
Console.WriteLine(array.count);

foreach(var item in array)//Gezinme için IEnumarable interfacei şarttır.
{
    Console.WriteLine(item);
}
Console.Read();
