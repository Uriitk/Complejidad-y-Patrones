public class Catalogo : Coleccionable {
    private Pila pila;
    private Cola cola;
    public Catalogo(Pila p, Cola c) {
        pila = p;
        cola = c;
    }
    public int cuantos() {
        return pila.cuantos() + cola.cuantos();
    }
    public Comparable minimo() {
        if (pila.minimo().sosMenor(cola.minimo())) {
            return pila.minimo();
        }
        return cola.minimo();
    }
    public Comparable maximo() {
        if (pila.maximo().sosMayor(cola.maximo())) {
            return pila.maximo();
        }
        return cola.maximo();
    }
    public void agregar(Comparable c) {
        // No hace nada
    }
    public bool contiene(Comparable c) {
        return pila.contiene(c) || cola.contiene(c);
    }
}