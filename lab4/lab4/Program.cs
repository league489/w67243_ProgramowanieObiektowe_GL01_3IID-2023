using lab4;


Console.WriteLine("Zad 1");
var kształty = new List<Shape>();
Rectangle prostokąt = new Rectangle()
{
    X = 2,
    Y = 4
};
Triangle trójkąt = new Triangle()
{
    X = 2,
    Y = 4,
    Height = 4
};
Circle koło = new Circle()
{
    R = 2
};

kształty.Add(prostokąt);
kształty.Add(trójkąt);
kształty.Add(koło);

foreach (var x in kształty)
{
    x.Draw();
}

Console.WriteLine("Zad 2");

    var pesele = new List<string>()
            {
"48090556298",
"57070551934",
"97042998185",
"63091066748",
"56062581971",
"69032561385",
"90121845244",
"05282992597",
"80021831214",
"56080612873"
            };

    var NauczycielNr1 = new Nauczyciel();

    NauczycielNr1.SetFirstName("Jakub");
    NauczycielNr1.SetLastName("Wędrowycz");
    NauczycielNr1.TytułNaukowy = "Prof.hab.";
    NauczycielNr1.SetSchool(("Szkoła Specjalna im. Jakiegoś Profesora Którego Nikt Nie Zna"));
var studenci = new List<Uczeń>();

    var i = 1;
    foreach (var pesel in pesele)
    {
        var uczeń = new Uczeń();
        uczeń.SetPesel(pesel);
        uczeń.SetFirstName("Student");
        uczeń.SetLastName(i.ToString());
           // uczeń.CanGoAloneToHome();
        studenci.Add(uczeń);
        i++;
    }

    NauczycielNr1.PodwładniUczniowie.AddRange(studenci);

   // NauczycielNr1.WhichStudentCanGoHomeAlone();

    NauczycielNr1.DzisiejszaKlasa(DateTime.Today);