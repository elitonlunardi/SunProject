namespace Sun.Domain
{
    public interface ICityRepository : IRepository<City>
    {
        City GetByName(string name);
    }
}
