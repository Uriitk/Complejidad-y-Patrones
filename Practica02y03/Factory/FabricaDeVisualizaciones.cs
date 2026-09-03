public class FabricaDeVisualizaciones : FabricaDeComparables {
    public override Comparable crearAleatorio() {
        GeneradorDeDatosAleatorios generador =
            new GeneradorDeDatosAleatorios();

        return new Visualizacion(
            generador.numeroAleatorio(100)
        );
    }

    public override Comparable crearPorTeclado() {
        LectorDeDatos lector = new LectorDeDatos();

        Console.Write("Cantidad: ");

        return new Visualizacion(
            lector.numeroPorTeclado()
        );
    }
}