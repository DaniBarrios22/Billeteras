using Billeteras;

var Billetera1 = new Billetera();

Billetera1.BilletesDe10 = 7;
Billetera1.BilletesDe20 = 6;
Billetera1.BilletesDe50 = 5;
Billetera1.BilletesDe100 = 4;
Billetera1.BilletesDe200 = 3;
Billetera1.BilletesDe500 = 2;
Billetera1.BilletesDe1000 = 1;

var Billetera2 = new Billetera();

Billetera2.BilletesDe10 = 1;
Billetera2.BilletesDe20 = 6;
Billetera2.BilletesDe50 = 1;
Billetera2.BilletesDe100 = 4;
Billetera2.BilletesDe200 = 1;
Billetera2.BilletesDe500 = 2;
Billetera2.BilletesDe1000 = 1;

Console.WriteLine(Billetera1.Total());
Console.WriteLine(Billetera2.Total());


Billetera Billetera3 = Billetera2.Combinar(Billetera1);

Console.WriteLine(Billetera3.Total()); 
