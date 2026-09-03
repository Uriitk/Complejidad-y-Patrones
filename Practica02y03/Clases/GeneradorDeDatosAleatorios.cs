public class GeneradorDeDatosAleatorios {
    private Random random = new Random();

    public int numeroAleatorio(int max) {
        return random.Next(0, max + 1);
    }

    public string stringAleatorio(int cant) {
        string caracteres =
            "abcdefghijklmnopqrstuvwxyz";

        string resultado = "";

        for (int i = 0; i < cant; i++) {
            resultado +=
                caracteres[random.Next(caracteres.Length)];
        }

        return resultado;
    }
}