public class Suscriptor : Perfil {
    private int mesesDeSuscripcion;
    private int horasVistas;
    public Suscriptor(
        string n,
        int i,
        int c,
        int h
    ) : base(n, i) {
            mesesDeSuscripcion = c;
            horasVistas = h;
    }
    public int getMesesDeSuscripcion() {
        return mesesDeSuscripcion;
    }
    public int getHorasVistas() {
        return horasVistas;
    }
    public override string ToString() {
        return "[Suscriptor: Nombre=" + nombre +
               ", ID=" + id +
               ", Meses=" + mesesDeSuscripcion +
               ", Horas=" + horasVistas + "]";
    }
    public override bool sosIgual(Comparable c) {
        return mesesDeSuscripcion ==
               ((Suscriptor)c).getMesesDeSuscripcion();
    }
    public override bool sosMenor(Comparable c) {
        return mesesDeSuscripcion <
               ((Suscriptor)c).getMesesDeSuscripcion();
    }
    public override bool sosMayor(Comparable c) {
        return mesesDeSuscripcion >
               ((Suscriptor)c).getMesesDeSuscripcion();
    }
}