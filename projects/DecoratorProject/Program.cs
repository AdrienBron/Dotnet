ICafe monCafe = new CafeSimple();
monCafe = new Lait(monCafe);
monCafe = new Sucre(monCafe);
Console.WriteLine($"{monCafe.GetDescription()} - Prix : {monCafe.GetCost()}€");
