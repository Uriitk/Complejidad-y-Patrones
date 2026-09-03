public class PorId : EstrategiaDeComparacion {
    public bool sosIgual(Suscriptor a, Suscriptor b) {
        return a.getId() == b.getId();
    }

    public bool sosMenor(Suscriptor a, Suscriptor b) {
        return a.getId() < b.getId();
    }

    public bool sosMayor(Suscriptor a, Suscriptor b) {
        return a.getId() > b.getId();
    }
}