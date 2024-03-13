using Flächen;

Quadrat q1 = new Quadrat(15);

Rechteck r1= new Rechteck(20);

Dreieck d1 = new Dreieck(10);

double summe = r1.GetFlaeche() + q1.GetFlaeche() +d1.GetFlaeche();
Console.WriteLine("Die Fläche des Quadrats beträgt : {0}", q1.GetFlaeche());
Console.WriteLine("Die Fläche des Rechtecks beträgt : {0}", r1.GetFlaeche());

Console.WriteLine("Die Summe der Flächen beträgt : {0}", summe);


