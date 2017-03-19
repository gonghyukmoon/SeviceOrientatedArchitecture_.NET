using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Prac4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IADODatabaseService" in both code and config file together.
    [ServiceContract]
    public interface IADODatabaseService
    {
        [OperationContract]
        Boolean PatientRegistration(Patient p);
        [OperationContract]
        Boolean DoctorRegistration(Doctor d);
        [OperationContract]
        Patient GetPatientInfo(String firstName, String lastName);
        [OperationContract]
        Doctor GetDoctorInfo(String firstName, String lastName);
        [OperationContract]
        Boolean AppointmentBooking(String pfirstName, String plastName, String dfirstName, String dlastName, DateTime AppoitmentDateAndTime, String clinicName);
        [OperationContract]
        Appointment GetAppointment(String pfirstName, String plastName, String dfirstName, String dlastName);
        [OperationContract]
        Boolean AppointmentReschedule(String pfirstName, String plastName, String dfirstName, String dlastName, DateTime newAppointmentTime);
    }
}
