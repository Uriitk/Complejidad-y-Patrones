public class DecoradorRecuadro
    : DecoradorSuscriptor {
    public DecoradorRecuadro(
        Mostrable componente
    ) : base(componente) {
    }

    public override string mostrarInfo() {
        string info = componente.mostrarInfo();

        string linea = "";

        for (int i = 0; i < info.Length + 4; i++) {
            linea += "*";
        }

        return linea + "\n" +
               "* " + info + " *\n" +
               linea;
    }
}