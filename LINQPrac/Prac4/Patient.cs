using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Prac4
{
    [DataContract]
    public class Patient
    {
        String healthInsuranceNO;

        [DataMember]
        public String HealthInsuranceNO
        {
            get { return healthInsuranceNO; }
            set { healthInsuranceNO = value; }
        }
        String firstName;

        [DataMember]
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        String lastName;

        [DataMember]
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        int phoneNumber;

        [DataMember]
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        String address;

        [DataMember]
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        String email;

        [DataMember]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}