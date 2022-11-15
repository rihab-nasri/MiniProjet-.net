using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        // public int Id { get; set; }//ou Passengerid
        [Display(Name = "DateOfBirth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        public string PasseportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        public  FullName FullName { get; set; }

        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
       // public ICollection<Flight> FlightList { get; set; }
        public virtual ICollection<Ticket> TicketList { get; set; }
        public override string ToString()
        {
            return "First Name= "+ FullName.FirstName + "Last Name= "+ FullName.LastName;
        }
       /* public bool CheckProfile (string firstname,string lastname)
        {
            return FirstName==firstname && LastName==lastname;
        }
        public bool CheckProfile(string firstname, string lastname,string emailadresse)
        {
            return FirstName == firstname && LastName == lastname && EmailAddress==emailadresse;
        }*/
        public bool CheckProfile (string firstname, string lastname, string emailadresse=null)
        {
            if(emailadresse!=null)
            return FullName.FirstName == firstname && FullName.LastName == lastname && EmailAddress == emailadresse; 
            else 
             return FullName.FirstName == firstname && FullName.LastName == lastname;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");

        }
    }
}
