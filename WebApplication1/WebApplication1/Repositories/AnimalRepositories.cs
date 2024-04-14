namespace WebApplication1.Repositories
{
    public class AnimalRepositories
    {
        SqlDataReader dr = com.ExecuteReader();
        List<Animal> animals = new List<Animal>();

    while (dr.Read())
{
        Animal a = new Animal();
        a.Id = (int) dr["id"];
        a.Name = (string) dr["name"];
        a.Description = (string) dr["description"];
        a.Area = (string) dr["Area"];
        a.Category = (string) dr["category"];

        animals.Add(a);
}

return animals;
    }
}
