public class PorHorasVistas : EstrategiaDeComparacion {
    public bool sosIgual(Suscriptor a, Suscriptor b) {
        return a.getHorasVistas() == b.getHorasVistas();
    }

    public bool sosMenor(Suscriptor a, Suscriptor b) {
        return a.getHorasVistas() < b.getHorasVistas();
    }

    public bool sosMayor(Suscriptor a, Suscriptor b) {
        return a.getHorasVistas() > b.getHorasVistas();
    }
}