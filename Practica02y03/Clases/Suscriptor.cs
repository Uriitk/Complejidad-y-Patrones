public class Suscriptor : Perfil, Observador, Mostrable {
    private int mesesDeSuscripcion;
    private int horasVistas;
    private EstrategiaDeComparacion estrategia;
    public Suscriptor(
        string n,
        int i,
        int c,
        int h,
        EstrategiaDeComparacion e
    ) : base(n, i) {
        mesesDeSuscripcion = c;
        horasVistas = h;
        estrategia = e;
    }
    public int getMesesDeSuscripcion() {
        return mesesDeSuscripcion;
    }
    public int getHorasVistas() {
        return horasVistas;
    }
    public void setEstrategia(EstrategiaDeComparacion e) {
        estrategia = e;
    }
    public void actualizar(Observado o) {
        Canal canal = (Canal)o;
        verContenido();
    }
    public void verContenido() {
        Console.WriteLine(nombre + " está viendo el contenido");
    }
    public void reaccionarANotificacion() {
        Console.WriteLine(nombre + " reaccionó a la notificación");
    }
    public override bool sosIgual(Comparable c) {
        return estrategia.sosIgual(this, (Suscriptor)c);
    }
    public override bool sosMenor(Comparable c) {
        return estrategia.sosMenor(this, (Suscriptor)c);
    }
    public override bool sosMayor(Comparable c) {
        return estrategia.sosMayor(this, (Suscriptor)c);
    }
    public override string ToString() {
        return "[Suscriptor: Nombre=" + nombre +
               ", ID=" + id +
               ", Meses=" + mesesDeSuscripcion +
               ", Horas=" + horasVistas + "]";
    }
    public string mostrarInfo() {
        return this.ToString();
    }
    public Suscriptor getSuscriptor() {
        return this;
    }
}