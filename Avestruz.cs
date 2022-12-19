public class Avestruz : Maquina
{
    public Avestruz()
    {
        this.Nome = "Avestruz";
        this.valor = 50;
        this.adiciona = 5;
        this.id = 2;
        
    }

    public static void Activate()
    {
        Maquina.AddTipo(new Avestruz());
    }
}