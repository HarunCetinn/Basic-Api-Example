using Api_Denemesi.Interfaces;

namespace Api_Denemesi.Repository
{
    public class DummyRepository : IDummyRepository 
    {
        public string GetName() { return "Test"; }
    }
}
