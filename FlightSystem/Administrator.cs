using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    internal class Administrator
    {
        string id;
        string name;
        string surname;
        string username;
        string password;
        public string departureCity;
        public string arrivalCity;
        public string departureTime;
        public string arrivalTime;
        public string flightDate;
        public string flightPrice;

        public Administrator(string id, string name, string surname, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
        }

        public Administrator(string deparutureCity, string arrivalCity, string departureTime, string arrivalTime, string flightDate, string flightPrice)
        {
            this.departureCity = deparutureCity;
            this.arrivalCity = arrivalCity;
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.flightDate = flightDate;
            this.flightPrice = flightPrice;
        }

        public string getID()
        {
            return this.id;
        }

        public void setID( string id )
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName( string name )
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setUsername( string username )
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword( string password )
        {
            this.password = password;
        }

    }
}
