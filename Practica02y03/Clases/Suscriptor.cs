public class Suscriptor : Perfil {
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

    public override bool sosIgual(Comparable c) {
        return estrategia.sosIgual(
            this,
            (Suscriptor)c
        );
    }

    public override bool sosMenor(Comparable c) {
        return estrategia.sosMenor(
            this,
            (Suscriptor)c
        );
    }

    public override bool sosMayor(Comparable c) {
        return estrategia.sosMayor(
            this,
            (Suscriptor)c
        );
    }

    public override string ToString() {
        return "[Suscriptor: Nombre=" + nombre +
               ", ID=" + id +
               ", Meses=" + mesesDeSuscripcion +
               ", Horas=" + horasVistas + "]";
    }
}