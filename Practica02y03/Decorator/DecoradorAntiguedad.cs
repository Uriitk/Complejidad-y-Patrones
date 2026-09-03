public class DecoradorAntiguedad
    : DecoradorSuscriptor {
    public DecoradorAntiguedad(
        Mostrable componente
    ) : base(componente) {
    }

    public override string mostrarInfo() {
        Suscriptor s = getSuscriptor();

        return componente.mostrarInfo()
            .Replace(
                " - ",
                " (Suscriptor hace " +
                s.getMesesDeSuscripcion() +
                " meses) - "
            );
    }
}