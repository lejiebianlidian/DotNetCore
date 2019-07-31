namespace Repostitory
{
    public class PersonRepository:IPersonRepository
    {
        public string Eat()
        {
            return "吃饭";
        }

        public string Burn()
        {
            return "来自PersonRepositoryd的Burn方法";
        }
    }
}