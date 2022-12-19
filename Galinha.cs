public class Galinha : Maquina
{
    public Galinha()
    {
        this.Nome = "Galinha";
        this.valor = 30;
        this.adiciona = 3;
        this.id = 1;
    }

    public static void Activate()
    {
        Maquina.AddTipo(new Galinha());
    }
    
}