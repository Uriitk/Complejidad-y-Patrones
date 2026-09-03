public class IteradorLista : Iterador {
    private List<Comparable> elementos;
    private int posicion;

    public IteradorLista(List<Comparable> elementos) {
        this.elementos = elementos;
        posicion = 0;
    }

    public bool haySiguiente() {
        return posicion < elementos.Count;
    }

    public Comparable siguiente() {
        Comparable elemento = elementos[posicion];
        posicion++;
        return elemento;
    }

    public void reiniciar() {
        posicion = 0;
    }
}