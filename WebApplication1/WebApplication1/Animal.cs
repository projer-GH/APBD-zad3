namespace WebApplication1;

public class Animal
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Mass { get; set; }
    public string Colour { get; set; }

    public Animal(int id, string name, string category, double mass, string colour)
    {
        ID = id;
        Name = name;
        Category = category;
        Mass = mass;
        Colour = colour;
    }
}