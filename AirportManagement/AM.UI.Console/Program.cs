// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");
/*Plane p1=new Plane();
p1.Capacity = 300;
p1.ManufactureDate = new DateTime(1998,01,18);
p1.PlaneType = PlaneType.Airbus;
Console.WriteLine(p1.ToString());
Plane p2=new Plane(PlaneType.Boing,500,DateTime.Now);
Console.WriteLine(p2.ToString());*/
Plane p3=new Plane() 
    { 
         Capacity=500,
         PlaneType=PlaneType.Airbus,
         ManufactureDate=DateTime.Now
    };
Console.WriteLine(p3.ToString());
Passenger pass1 = new Passenger()
{
    FullName = new FullName
    {
        FirstName = "Rihab",
        LastName = "Nasri"
    },
   
    EmailAddress = "rihab.nasri@esprit.tn"

};
Console.WriteLine(pass1.CheckProfile("Rihab","Nasri","rihab.nasri@esprit.tn"));
Staff st1 = new Staff();
Traveller t1 = new Traveller();
pass1.PassengerType();
st1.PassengerType();
t1.PassengerType();

/*ServiceFlight Sflight=new ServiceFlight();
Sflight.Flights = TestData.ListFlight;

foreach (var item in Sflight.GetFlightDates2("Paris"))
{
    Console.WriteLine(item);
}
Sflight.GetFlights("Destination", "Paris");
Console.WriteLine("detail de l'avion: ");
Sflight.ShowFlightDetails(TestData.p1);
Console.WriteLine(Sflight.DurationAverage("Madrid"));
Console.WriteLine("les vols ordonee");
foreach(var flight in Sflight.OrderedDurationFlights())
{
    Console.WriteLine(flight);
}

Console.WriteLine("Les Top 3 Travellers");
/*
foreach (var f in Sflight.SeniorTravellers(TestData.f1))
{
    Console.WriteLine(f);
}
Console.WriteLine("Les vols par Destination  :");

Sflight.DestinationGroupedFlights();
Console.WriteLine(Sflight.DurationAverageDel("Paris"));
Sflight.FlightDetailsDel(TestData.p1);
*/
AMContext context = new AMContext();//INSTANCACIATION DE CONTEXT POUR AJOUTER 
context.Flights.Add(TestData.f3);//ajouter a la base 
context.SaveChanges();
Console.WriteLine("Test");
Console.WriteLine(context.Flights.First().MyPlane.Capacity);





