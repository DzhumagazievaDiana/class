using Задание2;

Clothes[] clothesArray = new Clothes[5];
clothesArray[0] = new Clothes("Gucci", "Классический", 32000);
clothesArray[1] = new Clothes("Chanel", "Повседневный", 10000);
clothesArray[2] = new Clothes("Balenciaga", "Минимализм", 12000);
clothesArray[3] = new Clothes("Fendi", "Этно", 7000);
clothesArray[4] = new Clothes("Dior", "Гламур", 5000);

foreach(Clothes clothes in clothesArray)
{
    Console.WriteLine(clothes);
}
