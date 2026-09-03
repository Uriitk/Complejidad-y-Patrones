public class PorNombre : EstrategiaDeComparacion {
    public bool sosIgual(Suscriptor a, Suscriptor b) {
        return a.getNombre() == b.getNombre();
    }

    public bool sosMenor(Suscriptor a, Suscriptor b) {
        return a.getNombre().CompareTo(b.getNombre()) < 0;
    }

    public bool sosMayor(Suscriptor a, Suscriptor b) {
        return a.getNombre().CompareTo(b.getNombre()) > 0;
    }
}