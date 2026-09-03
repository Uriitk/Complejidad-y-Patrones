using System;
class Program {
    static void imprimirElementos(Coleccionable coleccionable) {
        Iterable iterable = (Iterable)coleccionable;
        Iterador iterador = iterable.crearIterador();
        while (iterador.haySiguiente()) {
            Console.WriteLine(iterador.siguiente());
        }
    }
    static void cambiarEstrategia(
        Coleccionable coleccionable,
        EstrategiaDeComparacion estrategia) {
        Iterable iterable = (Iterable)coleccionable;
        Iterador iterador = iterable.crearIterador();
        while (iterador.haySiguiente()) {
            Suscriptor suscriptor =
                (Suscriptor)iterador.siguiente();
            suscriptor.setEstrategia(estrategia);
        }
    }
    static void llenarSuscriptores(Coleccionable coleccionable) {
        for (int i = 0; i < 20; i++) {
            string nombre =
                GeneradorDeDatosAleatorios.stringAleatorio(5);
            int id =
                GeneradorDeDatosAleatorios.numeroAleatorio(1000);
            int meses =
                GeneradorDeDatosAleatorios.numeroAleatorio(60);
            int horas =
                GeneradorDeDatosAleatorios.numeroAleatorio(100);
            Suscriptor suscriptor =
                new Suscriptor(
                    nombre,
                    id,
                    meses,
                    horas,
                    new PorId()
                );
            coleccionable.agregar(suscriptor);
        }
    }
    static void informar(Coleccionable coleccionable) {
        Console.WriteLine("Cantidad: " + coleccionable.cuantos());
        Console.WriteLine("Mínimo: " + coleccionable.minimo());
        Console.WriteLine("Máximo: " + coleccionable.maximo());
    }
    static void llenarFactory(
        Coleccionable coleccionable,
        int opcion) {
        for (int i = 0; i < 20; i++) {
            Comparable comparable =
                FabricaDeComparables.crearAleatorio(opcion);
            coleccionable.agregar(comparable);
        }
    }


    // EJERCICIO 14
    static void informarFactory(
        Coleccionable coleccionable,
        int opcion) {
        Console.WriteLine("Cantidad: " + coleccionable.cuantos());
        Console.WriteLine("Mínimo: " + coleccionable.minimo());
        Console.WriteLine("Máximo: " + coleccionable.maximo());
        Comparable comparable =
            FabricaDeComparables.crearPorTeclado(opcion);
        if (coleccionable.contiene(comparable)) {
            Console.WriteLine(
                "El elemento leído está en la colección"
            );
        } else {
            Console.WriteLine(
                "El elemento leído no está en la colección"
            );
        }
    }
    static void temporadaDeContenido(Canal canal) {
        for (int i = 0; i < 5; i++) {
            canal.publicarContenido();
            canal.iniciarEnVivo();
        }
    }
    static void Main(string[] args) {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Playlist playlist = new Playlist();

        llenarSuscriptores(pila);
        llenarSuscriptores(cola);
        llenarSuscriptores(playlist);

        Console.WriteLine("----- PILA -----");
        imprimirElementos(pila);

        Console.WriteLine("----- COLA -----");
        imprimirElementos(cola);

        Console.WriteLine("----- PLAYLIST -----");
        imprimirElementos(playlist);
        
        Console.WriteLine();
        Console.WriteLine("===== ESTRATEGIAS =====");

        cambiarEstrategia(pila, new PorNombre());
        Console.WriteLine("Por nombre:");
        informar(pila);

        cambiarEstrategia( pila, new PorMesesDeSuscripcion() );

        Console.WriteLine("Por meses de suscripción:");
        informar(pila);

        cambiarEstrategia( pila, new PorHorasVistas() );

        Console.WriteLine("Por horas vistas:");
        informar(pila);

        cambiarEstrategia( pila, new PorId() );

        Console.WriteLine("Por ID:");
        informar(pila);
        
        Console.WriteLine();
        Console.WriteLine("===== FACTORY =====");

        Pila pilaFactory = new Pila();

        // 1 = Visualizacion
        // 2 = Suscriptor
        int opcion = 2;

        llenarFactory(pilaFactory, opcion);
        informarFactory(pilaFactory, opcion);

        Console.WriteLine();
        Console.WriteLine("===== OBSERVER =====");

        Canal canal = new Canal("CTyPDS UNAJ");

        for (int i = 0; i < 20; i++) {
            Suscriptor suscriptor =
                (Suscriptor)
                FabricaDeComparables.crearAleatorio(2);
            canal.agregarObservador(suscriptor);
        }

        temporadaDeContenido(canal);

        Console.WriteLine();
        Console.WriteLine("===== DECORATOR =====");

        Suscriptor suscriptorEjemplo =
            new Suscriptor(
                "Juan",
                1,
                14,
                45,
                new PorId()
            );

        Mostrable mostrable = suscriptorEjemplo;
        mostrable = new DecoradorAntiguedad(mostrable);
        mostrable = new DecoradorFanatico(mostrable);
        mostrable = new DecoradorEstado(mostrable);
        mostrable = new DecoradorRecuadro(mostrable);
        Console.WriteLine( mostrable.mostrarInfo() );

        Console.WriteLine();
        Console.WriteLine( "===== FACTORY + OBSERVER + DECORATOR =====" );

        Canal canalFinal = new Canal("CTyPDS UNAJ");

        for (int i = 0; i < 10; i++) {
            Suscriptor suscriptor =
                (Suscriptor)
                FabricaDeComparables.crearAleatorio(2);
            canalFinal.agregarObservador(suscriptor);
        }

        temporadaDeContenido(canalFinal);

        foreach ( Suscriptor suscriptor in canalFinal.getObservadores() ) {
            Mostrable decorado = suscriptor;
            decorado = new DecoradorAntiguedad(decorado);
            decorado = new DecoradorFanatico(decorado);
            decorado = new DecoradorEstado(decorado);
            decorado = new DecoradorRecuadro(decorado);
            Console.WriteLine( decorado.mostrarInfo() );
        }
    }
}