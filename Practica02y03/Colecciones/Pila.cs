using System;
using System.Collections.Generic;

public class Pila : Coleccionable, Iterable {
    private List<Comparable> elementos;
    public Pila() {
        elementos = new List<Comparable>();
    }
    public int cuantos() {
        return elementos.Count;
    }
    public void apilar(Comparable e) {
        elementos.Add(e);
    }
    public Comparable desapilar() {
        Comparable e = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return e;
    }
    public void agregar(Comparable c) {
        apilar(c);
    }
    public Comparable minimo() {
        Comparable masChico = elementos[0];
        for (int i = 1; i < elementos.Count; i++) {
            if (elementos[i].sosMenor(masChico)) {
                masChico = elementos[i];
            }
        }
        return masChico;
    }
    public Comparable maximo() {
        Comparable masGrande = elementos[0];
        for (int i = 1; i < elementos.Count; i++) {
            if (elementos[i].sosMayor(masGrande)) {
                masGrande = elementos[i];
            }
        }
        return masGrande;
    }
    public bool contiene(Comparable c) {
        foreach (Comparable elemento in elementos) {
            if (elemento.sosIgual(c)) {
                return true;
            }
        }
        return false;
    }
    public Iterador crearIterador() {
        return new IteradorLista(elementos);
    }
}