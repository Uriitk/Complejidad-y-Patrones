class Program {
    static void Main(string[] args) {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Catalogo catalogo = new Catalogo(pila, cola);
        llenarSuscriptores(pila);
        llenarSuscriptores(cola);
        informar(catalogo);
        Console.ReadKey();
    }
    static void llenar(Coleccionable coleccionable) {
        try {
            Random random = new Random();
            for (int i = 0; i < 20; i++) {
                int cantidad = random.Next(1, 101);
                Comparable comparable = new Visualizacion(cantidad);
                coleccionable.agregar(comparable);
            }
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    static void informar(Coleccionable coleccionable) {
        try {
            Console.WriteLine(
                "Cantidad de elementos: " +
                coleccionable.cuantos()
            );
            Console.WriteLine(
                "Mínimo: " +
                coleccionable.minimo()
            );
            Console.WriteLine(
                "Máximo: " +
                coleccionable.maximo()
            );
            Console.Write("Ingrese un valor: ");
            int cantidad = int.Parse(Console.ReadLine());
            Comparable comparable = new Visualizacion(cantidad);
            if (coleccionable.contiene(comparable)) {
                Console.WriteLine(
                    "El elemento leído está en la colección"
                );
            } else {
                Console.WriteLine(
                    "El elemento leído no está en la colección"
                );
            }
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    static void llenarSuscriptores(Coleccionable coleccionable) {
        try {
            Random random = new Random();
            string[] nombres =
            {
                "Juan",
                "Pedro",
                "Maria",
                "Ana",
                "Lucas",
                "Sofia",
                "Martin",
                "Lucia",
                "Nicolas",
                "Camila"
            };
            for (int i = 0; i < 20; i++) {
                string nombre =
                    nombres[random.Next(nombres.Length)];
                int id = random.Next(1, 101);
                int mesesDeSuscripcion =
                    random.Next(1, 61);
                int horasVistas =
                    random.Next(1, 501);
                Comparable comparable =
                    new Suscriptor(
                        nombre,
                        id,
                        mesesDeSuscripcion,
                        horasVistas
                    );
                coleccionable.agregar(comparable);
            }
        } catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}