using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class PatientRepository : IPatientRepository
    {
        List<Patient> listPatient = new List<Patient>()
        {
            new Patient(1, "S.K. Anowar Hossan Tuhin", "Dhaka", "skanowar@gmail.com"),
            new Patient(2, "Sheikh Shahin", "Faridpur", "sheikhshahin@gmail.com"),
            new Patient(3, "MD Shafiq", "Khulna", "mdshafiq@gmail.com"),
            new Patient(4, "Sadikul Islam", "Dhaka", "sadikulislam@gmail.com"),
            new Patient(5, "Kajol Ahmed", "Sylhet", "kajolahmed@gmail.com")
        };
        public List<Patient> Get()
        {
            return listPatient.OrderBy(x => x.PatientName).ToList();
        }

        public Patient Get(int id)
        {
            Patient oPatient = listPatient.Where(x => x.PatientId == id).FirstOrDefault();
            return oPatient;
        }

        public bool Add(Patient model)
        {
            listPatient.Add(model);
            return true;
        }

        public bool Update(Patient model)
        {
            bool isExecuted = false;
            Patient oPatient = listPatient.Where(x => x.PatientId == model.PatientId).FirstOrDefault();
            if (oPatient != null)
            {
                listPatient.Remove(oPatient);
                listPatient.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Patient oPatient = listPatient.Where(x => x.PatientId == id).FirstOrDefault();
            if (oPatient != null)
            {
                listPatient.Remove(oPatient);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
