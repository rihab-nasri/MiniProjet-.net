using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane p1 = new Plane
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManufactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane p2 = new Plane
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManufactureDate = new DateTime(2020, 11, 11)
        };
        public static Staff st1 = new Staff
        {
            FullName = new FullName
            {
                FirstName = "captain",
                LastName = "captain"
            },
            EmailAddress ="captain.captain@gmail.com",
            BirthDate=new DateTime(1965,01,01),
            EmploymentDate=new DateTime(1999,01,01),
            Salary=999999
        };
        public static Staff st2 = new Staff
        {
            FullName = new FullName
            {
                FirstName = "hostess1",
                LastName = "hostess1"
            },
            EmailAddress = "hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        public static Staff st3 = new Staff
        {
            FullName = new FullName
            {
                FirstName = "hostess2",
                LastName = "hostess2"
            },
            EmailAddress = "hostess2.hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        public static Traveller t1 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller1",
                LastName = "traveller1"
            },
            
            EmailAddress="traveller1.traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),
            HealthInformation="no troubles",
            Nationality="American"
        };
        public static Traveller t2 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller2",
                LastName = "traveller2"
            },
            EmailAddress = "traveller2.traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "French"
        };
        public static Traveller t3 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller3",
                LastName = "traveller3"
            },
            EmailAddress = "traveller3.traveller3)@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "no troubles",
            Nationality = "Tunisian"
        };
        public static Traveller t4 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller4",
                LastName = "traveller4"
            },
            EmailAddress = "traveller4.traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "American"
        };
        public static Traveller t5 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "traveller5",
                LastName = "traveller5"
            },
            EmailAddress = "traveller5.traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "some troubles",
            Nationality = "Spanich"
        };

        public static Flight f1 = new Flight
        {
            FlightDate=new DateTime(2022,01,01),
            Destination="Paris",
            EffectiveArrival=new DateTime(2022,01,01),
            MyPlane=p2,
            EstimatedDuration= 110,
          //  PassengerList=new List<Passenger>()
          //  { t1,t2,t3,t4,t5}
        };
        public static Flight f2 = new Flight
        {
            FlightDate = new DateTime(2022, 02, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01),
            MyPlane = p1,
            EstimatedDuration = 105,
           
        };
        public static Flight f3 = new Flight
        {
            FlightDate = new DateTime(2022, 03, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01),
            MyPlane = p1,
            EstimatedDuration = 100,
            Airline="tunisair"

        };
        public static Flight f4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01),
            MyPlane = p1,
            EstimatedDuration = 130,

        };
        public static Flight f5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01),
            MyPlane = p1,
            EstimatedDuration = 105,

        };
        public static Flight f6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01),
            MyPlane = p2,
            EstimatedDuration = 200,

        };
        public static List<Flight> ListFlight = new List<Flight>
        {
            f1,f2,f3,f4,f5,f6
        };
    }
}
