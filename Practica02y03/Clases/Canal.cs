public class Canal {
    private string nombre;
    private List<Suscriptor> observadores;

    public Canal(string n) {
        nombre = n;
        observadores = new List<Suscriptor>();
    }

    public void agregarObservador(Suscriptor suscriptor) {
        observadores.Add(suscriptor);
    }

    public void publicarContenido() {
        Console.WriteLine(
            nombre + " publicó contenido nuevo"
        );

        foreach (Suscriptor suscriptor in observadores) {
            suscriptor.verContenido();
        }
    }

    public void iniciarEnVivo() {
        Console.WriteLine(
            nombre + " está en vivo"
        );

        foreach (Suscriptor suscriptor in observadores) {
            suscriptor.reaccionarANotificacion();
        }
    }

    public List<Suscriptor> getObservadores() {
        return observadores;
    }
}