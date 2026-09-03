public class PorMesesDeSuscripcion : EstrategiaDeComparacion {
    public bool sosIgual(Suscriptor a, Suscriptor b) {
        return a.getMesesDeSuscripcion() == b.getMesesDeSuscripcion();
    }

    public bool sosMenor(Suscriptor a, Suscriptor b) {
        return a.getMesesDeSuscripcion() < b.getMesesDeSuscripcion();
    }

    public bool sosMayor(Suscriptor a, Suscriptor b) {
        return a.getMesesDeSuscripcion() > b.getMesesDeSuscripcion();
    }
}