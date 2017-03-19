using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Prac4
{
    [DataContract]
    public class Doctor
    {
        String medicalRegistrationNO;

        [DataMember]
        public String MedicalRegistrationNO
        {
            get { return medicalRegistrationNO; }
            set { medicalRegistrationNO = value; }
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
        String healthProfession;

        [DataMember]
        public String HealthProfession
        {
            get { return healthProfession; }
            set { healthProfession = value; }
        }
        int phoneNumber;

        [DataMember]
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
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