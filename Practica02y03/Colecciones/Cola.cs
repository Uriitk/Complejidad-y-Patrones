using System;
using System.Collections.Generic;

public class Cola : Coleccionable, Iterable {
    private List<Comparable> elementos;
    public Cola() {
        elementos = new List<Comparable>();
    }
    public int cuantos() {
        return elementos.Count;
    }
    public void encolar(Comparable e) {
        elementos.Add(e);
    }
    public Comparable desencolar() {
        Comparable e = elementos[0];
        elementos.RemoveAt(0);
        return e;
    }
    public void agregar(Comparable c) {
        encolar(c);
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