using Flächen;

Quadrat q1 = new Quadrat(15);

Rechteck r1= new Rechteck(20);


int summe = r1 + q1;
Console.WriteLine("Die Fläche des Quadrats beträgt : {0}", q1.GetFlaeche);
Console.WriteLine("Die Fläche des Rechtecks beträgt : {0}", r1.GetFlaeche);

Console.WriteLine("Die Summe der Flächen beträgt : {0}", summe);


