namespace WebApplication1.Model;

public class Animal
{
    public int idAnimal { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Area { get; set; }
    
    public Animal(int idAnimal, string name, string description, string category, string area)
    {
        this.idAnimal = idAnimal;
        Name = name;
        Description = description;
        Category = category;
        Area = area;
    }
}   