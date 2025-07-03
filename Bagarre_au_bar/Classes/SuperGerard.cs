using System;

public class SuperGerard : LeGerard
{
    public SuperGerard() : base()
    {
        Nom = "Super Gerard"; // Change le nom
        Console.WriteLine("Super Gerard (version améliorée)");
    }

    public override int Attaque()
    {
        int attaquebonus = random.Next(1, 10);
        int attaquebasique = random.Next(2, 12);
        int attaquetotel = attaquebasique + attaquebonus;

        Console.WriteLine($"{Nom} lance une SUPER ATTAQUE et inflige {attaquebasique} dégâts !");

        return attaquetotal;
    }
}
