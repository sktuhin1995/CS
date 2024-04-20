using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class Patient
    {
        public int PatientId;
        public string PatientName;
        public string PatientAddress;
        public string PatientEmail;
        public Patient()
        {

        }
        public Patient(int id, string name, string address, string email)
        {
            PatientId = id;
            PatientName = name;
            PatientAddress = address;
            PatientEmail = email;
        }
    }
}
