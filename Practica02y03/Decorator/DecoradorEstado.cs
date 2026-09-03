public class DecoradorEstado
    : DecoradorSuscriptor {
    public DecoradorEstado(
        Mostrable componente
    ) : base(componente) {
    }

    public override string mostrarInfo() {
        Suscriptor s = getSuscriptor();

        string estado;

        if (s.getHorasVistas() > 0) {
            estado = "Activa";
        } else {
            estado = "Inactiva";
        }

        return componente.mostrarInfo()
            .Replace(
                " - ",
                " (Cuenta " + estado + ") - "
            );
    }
}