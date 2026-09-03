public class FabricaDeSuscriptores : FabricaDeComparables {
    public override Comparable crearAleatorio() {
        GeneradorDeDatosAleatorios generador =
            new GeneradorDeDatosAleatorios();

        string nombre =
            generador.stringAleatorio(5);

        int id =
            generador.numeroAleatorio(100);

        int meses =
            generador.numeroAleatorio(60);

        int horas =
            generador.numeroAleatorio(500);

        return new Suscriptor(
            nombre,
            id,
            meses,
            horas,
            new PorId()
        );
    }

    public override Comparable crearPorTeclado() {
        LectorDeDatos lector = new LectorDeDatos();

        Console.Write("Nombre: ");
        string nombre = lector.stringPorTeclado();

        Console.Write("ID: ");
        int id = lector.numeroPorTeclado();

        Console.Write("Meses: ");
        int meses = lector.numeroPorTeclado();

        Console.Write("Horas: ");
        int horas = lector.numeroPorTeclado();

        return new Suscriptor(
            nombre,
            id,
            meses,
            horas,
            new PorId()
        );
    }
}