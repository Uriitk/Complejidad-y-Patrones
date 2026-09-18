using System;
using System.Collections.Generic;

public class Canal : Observado {
    private string nombre;
    private List<Observador> observadores;

    public Canal(string n) {
        nombre = n;
        observadores = new List<Observador>();
    }
    public void agregarObservador(Observador observador) {
        observadores.Add(observador);
    }
    public void quitarObservador(Observador observador) {
        observadores.Remove(observador);
    }
    public void notificar() {
        foreach (Observador observador in observadores) {
            observador.actualizar(this);
        }
    }
    public void publicarContenido(){
        Console.WriteLine(nombre + " publicó contenido nuevo");

        notificar();
    }
    public void iniciarEnVivo() {
        Console.WriteLine(nombre + " está en vivo" );
        notificar();
    }

    public List<Observador> getObservadores() {
        return observadores;
    }
}