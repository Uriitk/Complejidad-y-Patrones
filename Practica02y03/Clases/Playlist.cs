using System.Collections.Generic;
public class Playlist : Coleccionable, Iterable {
    private List<Comparable> elementos;
    public Playlist() {
        elementos = new List<Comparable>();
    }
    public void agregar(Comparable elemento) {
        if (!pertenece(elemento)) {
            elementos.Add(elemento);
        }
    }
    public bool pertenece(Comparable elemento) {
        foreach (Comparable e in elementos) {
            if (e.sosIgual(elemento)) {
                return true;
            }
        }
        return false;
    }
    public int cuantos() {
        return elementos.Count;
    }
    public Comparable minimo() {
        Comparable menor = elementos[0];
        for (int i = 1; i < elementos.Count; i++) {
            if (elementos[i].sosMenor(menor)) {
                menor = elementos[i];
            }
        }
        return menor;
    }
    public Comparable maximo() {
        Comparable mayor = elementos[0];
        for (int i = 1; i < elementos.Count; i++) {
            if (elementos[i].sosMayor(mayor)) {
                mayor = elementos[i];
            }
        }
        return mayor;
    }
    public bool contiene(Comparable elemento) {
        return pertenece(elemento);
    }
    public Iterador crearIterador() {
        return new IteradorLista(elementos);
    }
}