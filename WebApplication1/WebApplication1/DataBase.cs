namespace WebApplication1;

public static class DataBase
{
    public static List<Animal> _animals = new()
    {
        new Animal(1,"Puszek","Kot",4.3,"Biały"),
        new Animal(2,"Emma","Pies",14.9,"Biszkoptowy"),
        new Animal(3,"Kicia","Kot",3.8,"Szylkretowy")
    };
    
    public static List<Visit> _visits = new()
    {
        new Visit(1,"02.07.2023",new Animal(1,"Puszek","Kot",4.3,"Biały"),"Odrobaczanie",45.50),
        new Visit(2,"03.07.2023",new Animal(2,"Emma","Pies",14.9,"Biszkoptowy"),"Odrobaczanie",130.00)
    };
}