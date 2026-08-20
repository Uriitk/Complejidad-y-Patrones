public class Visualizacion : Comparable {
    private int cantidad;

    public Visualizacion(int c) {
        cantidad = c;
    }

    public int getCantidad() {
        return cantidad;
    }

    public bool sosIgual(Comparable c) {
        return cantidad == ((Visualizacion)c).getCantidad();
    }

    public bool sosMenor(Comparable c) {
        return cantidad < ((Visualizacion)c).getCantidad();
    }

    public bool sosMayor(Comparable c) {
        return cantidad > ((Visualizacion)c).getCantidad();
    }

    public override string ToString() {
        return cantidad.ToString();
    }
}