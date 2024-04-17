namespace WebApplication1;

public class Visit
{
    
    public int ID { get; set; }
    public string date { get; set; }
    public Animal animal { get; set; }
    public string description { get; set; }
    public double cost { get; set; }

    public Visit(int ID,string date, Animal animal, string description, double cost)
    {
        this.ID = ID;
        this.date = date;
        this.animal = animal;
        this.description = description;
        this.cost = cost;
    }
}