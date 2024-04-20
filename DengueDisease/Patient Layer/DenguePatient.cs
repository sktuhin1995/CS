using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern.BL
{
    public class DenguePatient
    {
        IPatientRepository _repository;

        public DenguePatient(IPatientRepository repository)
        {
            _repository = repository;
        }
        public List<Patient> Get()
        {
            return _repository.Get();
        }

        public Patient Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Patient model)
        {
            return _repository.Add(model);
        }

        public bool Update(Patient model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
