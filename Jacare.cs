public class Jacare : Maquina
{
    public Jacare()
    {
        this.Nome = "Jacare";
        this.valor = 170;
        this.adiciona = 6;
        this.id = 5;
        
    }

    public static void Activate()
    {
        Maquina.AddTipo(new Jacare());
    }
}