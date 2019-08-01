using Repostitory;

namespace Service
{
    public class PersonService:IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        public string Eat()
        {
            return _personRepository.Eat();
        }

        public string Burn()
        {
            return _personRepository.Burn();
        }
    }
}