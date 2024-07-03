using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    internal class Passenger
    {
        string id;
        string name;
        string surname;
        string username;
        string password;
        string departureCity;
        string arrivalCity;
        public string departureTime;
        public string arrivalTime;
        public string flightDate;
        public string flightPrice;

        public Passenger(string id, string name, string surname, string username, string password, string departureCity, string arrivalCity, string departureTime, string arrivalTime, string flightDate, string flightPrice)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.departureCity = departureCity;
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

        public void setID(string id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
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

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getDepartureCity()
        {
            return this.departureCity;
        }

        public void setDepartureCity( string departureCity )
        {
            this.departureCity = departureCity;
        }

        public string getArrivalCity()
        {
            return this.arrivalCity;
        }

        public void setArrivalCity(string arrivalCity)
        {
            this.arrivalCity = arrivalCity;
        }
    }
}
