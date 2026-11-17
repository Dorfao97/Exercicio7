public class Motor
{
    public char combustivel;
    public int cilindrada;
    public int potencia;

    public void setCombustivel(char comb)
    {
        combustivel = comb;
    }

    public char getCombustivel()
    {
        return combustivel;
    }

    public void setCilindrada(int cil)
    {
        cilindrada = cil;
    }

    public int getCilindrada()
    {
        return cilindrada;
    }

    public void setPotencia(int pot)
    {
        potencia = pot;
    }

    public int getPotencia()
    {
        return potencia;
    }

    public override string ToString()
    {
        return $"\nCombustível: {this.combustivel}" +
               $"\nCilindrada: {this.cilindrada}" +
               $"\nPotência: {this.potencia} cv";
    }
}
