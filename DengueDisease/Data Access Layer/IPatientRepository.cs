using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestRepositoryPattern.DA
{
    public interface IPatientRepository
    {
        List<Patient> Get();
        Patient Get(int id);
        bool Add(Patient model);
        bool Update(Patient model);
        bool Delete(int id);
    }
}
