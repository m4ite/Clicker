public class Gaviao : Maquina
{
    public Gaviao()
    {
        this.Nome = "Gaviao";
        this.valor = 120;
        this.adiciona = 5;
        this.id = 4;
        
    }

    public static void Activate()
    {
        Maquina.AddTipo(new Gaviao());
    }
}