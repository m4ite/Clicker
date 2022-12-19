public class Pinguim : Maquina
{
    public Pinguim()
    {
        this.Nome = "Pinguim";
        this.valor = 70;
        this.adiciona = 4;
        this.id = 3;
        
    }

    public static void Activate()
    {
        Maquina.AddTipo(new Pinguim());
    }
}