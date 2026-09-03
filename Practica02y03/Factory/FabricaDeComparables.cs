public abstract class FabricaDeComparables {
    public static Comparable crearAleatorio(int opcion) {
        if (opcion == 1) {
            return new FabricaDeVisualizaciones()
                .crearAleatorio();
        }

        return new FabricaDeSuscriptores()
            .crearAleatorio();
    }

    public static Comparable crearPorTeclado(int opcion) {
        if (opcion == 1) {
            return new FabricaDeVisualizaciones()
                .crearPorTeclado();
        }

        return new FabricaDeSuscriptores()
            .crearPorTeclado();
    }

    public abstract Comparable crearAleatorio();

    public abstract Comparable crearPorTeclado();
}