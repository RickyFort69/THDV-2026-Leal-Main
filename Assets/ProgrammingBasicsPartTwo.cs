using UnityEngine;

public class ProgrammingBasicsPartTwo : MonoBehaviour {

    private void Start() {

        // (8) - SWITCH:

        // A medida que vayan usando el if, se daran cuenta que su codigo empieza a volverse complejo.
        // Mientras mas if haya, mas dificil leer codigo. Es natural.

        /* 
        string prov = "Buenos Aires";
        if (prov == "Buenos Aires") {
            Debug.Log("Es una provincia de Argentina");
        }
        if (prov == "Montevideo") {
            Debug.Log("Es una provincia de Uruguay");
        }
        if (prov == "Sao Paulo") {
            Debug.Log("Es una provincia de Brasil");
        }
        */         // Estos simbolos de /* y */ les permite comentar secciones de codigo enteras. Borrenlos si quieren ver el codigo en accion.


        // Para esto existe el "switch". Una palabra clave de C# que nos permite comparar logica de una forma mas ordenada.
        // Es particularmente util cuando en una condicion tenemos varios casos distintos que nos interesan.

        string provincia = "Buenos Aires";

        switch (provincia) { // Esto lo que hace es comparar si la variable "provincia" es igual a cualquiera de los valores que tenemos en los casos.

            case "Buenos Aires": // IMPORTANTE: Añadir los ":" antes de escribir el codigo de cada caso.
                Debug.Log("Es una provincia de Argentina");
                break; 

            case "Montevideo":
                Debug.Log("Es una provincia de Uruguay");
                break;          // IMPORTANTE: Añadir el break para indicarle al switch donde termina su ejecucion en cada caso.

            case "Sao Paulo":
                Debug.Log("Es una provincia de Brasil");
                break;
        }

        // COMO FUNCIONA:
        // 1) Primero escribis la palabra "switch" y en los parentesis pones lo que queres evaluar (Lo que va a tener distintos valores).
        // 2) Abris el scope del switch usando los {}
        // 3) Dentro del scope del switch, pones los casos. Para definir un caso escribis la palabra "case" y el valor que buscas.
        // 4) Una vez terminas de escribir el codigo de un caso, se utiliza la palabra "break" indicar que termina la ejecucion del codigo.
        // 5) Cuando el codigo llega al break, sale del scope del switch y continua con el resto del codigo.

        // Tambien los switch, permiten que añadas un caso llamado "default" para cuando ningun caso es valido.
        // Es decir, si el switch no encuentra un caso valido, va a correr el codigo que se encuentra en default.
        // Si no añaden un default, el codigo simplemente se saltea el switch entero, pero no les tira error.

        switch (provincia) { 
            default: // Esto va a correr si "provincia" no hace match con los casos.
                Debug.Log("Nombre invalido");
                break;

            case "Buenos Aires": 
               // Debug.Log("Es una provincia de Argentina");
                break;

            case "Montevideo":
               // Debug.Log("Es una provincia de Uruguay");
                break;          

            case "Sao Paulo":
               // Debug.Log("Es una provincia de Brasil");
                break;
        }

        //------------------------------------------------------------------------------------------------

        // (9) - FOR / WHILE LOOPS:

        // En C# existen palabras clave que nos permiten crear loops. Es decir, codigo que se ejecuta de forma iterativa.
        // Esto es particularmente util para mantener una logica haciendo algo hasta que algo diga lo contrario.
        // Por ejemplo, el Uptade() de Unity justamente funciona haciendo loop constante de lo que pones dentro del metodo.

        //---------------------

        // WHILE LOOP:
        // Este loop te permite ejecutar codigo en base a una condicion.
        // Mientras esa condicion sea true, el bloque de codigo que el loop posee se ejecutara siempre.

        int contador = 0; // Es importante que definan la variable que usan para la condicion fuera del loop.
                          // Si lo hacen dentro, la variable siempre va a reiniciar su valor.
        while (contador < 5) {
            contador++;
            Debug.Log("El contador es: " + contador);
        }

        // En el codigo de arriba, vemos que el loop se mantendra corriendo hasta que el contador llegue a 5.
        // Por cada iteraccion del loop, contador suma 1.
        // Resumiendo: El loop se ejecuta 5 veces en total.

        // Tambien el while loop posee una variante.

        contador = 5;
        do {
            contador++;
            Debug.Log("Este loop va a correr almenos una vez");
        } while (contador < 5);

        // El "do while" loop es igual al while loop, con la diferencia de que la condicion se checkea al final.
        // Esto permite que el loop corra almenos una vez, incluso si la condicion no es true.
        // En el caso de arriba, incluso si contador ya es 5, el loop corre de igual forma. Porque la condicion se checkea al final.
        // Salvo por esa diferencia, es exactamente igual al while loop.

        //---------IMPORTANTE----------
        // Este loop (Y tambien su variante) debe usarse con cuidado. Si la condicion nunca es false, el loop se mantendra corriendo siempre.
        // Es decir, que mientras la condicion sea true, el resto del codigo fuera del loop no se ejecutara nunca.
        // Esto aveces es lo buscado (Como ocurre con el Uptade de Unity), pero muchas veces puede resultar en que se les congele la aplicacion.

        /*
        while (true) { 
         Debug.Log("INFINITO");
        }
        */

        // Eso que ven arriba es un ejemplo de un loop infinito. 
        // Si le dan play a Unity con eso activo, se les va a congelar Unity!!!!!!!!
        // Recuerden esto cuando usen while loops.

        //---------------------

        // FOR LOOP:
        // El "for" es un loop que funciona por un limite de interacciones.
        // Es una forma mas segura y resumida de hacer un while loop, evitando problemas como loops infinitos.
        // Para crear este loop se usa la palabra clave "for". 

        for (int i = 0; i < 5; i++) { 
            Debug.Log("Interaccion Numero: " + i);
        }

        // Dentro de los parentesis se encuentra la condicion de nuestro loop para que funcione o siga iterando. 
        // Pueden apretar la tecla tab despues de escribir la palabra for para que Visual les complete la sintaxis requerida.
        // Por cada tab que apreten, se va a añadir una parte de la sintaxis del loop.

        // COMO FUNCIONA:
        // 1) Primero se define la variable que va ser iterada por el loop (int i = 0). Por lo general se la nombra "i".
        // 2) Se hace una comparacion para decidir si el loop debe continuar (i < 5). En este caso si "i" vale 5, el loop se detendra.
        // 3) Si el loop continua, entonces se incrementa el iterador. Aumentamos el numero de iteracciones para que en algun momento el loop se detenga.
        // 4) Por cada iteraccion, el codigo de bloque entre los {} se ejecutara.
        // 5) Una vez el codigo se ejecute, el loop vuelve a iterar hasta que la comparacion diga lo contrario.

        // Notaran que tiene el mismo efecto que el while loop que usamos arriba con el contador.
        // El for loop existe por eso, para escribir un loop con iteracciones de una forma mas sintetica.
        // Te forza a usar un iterador, cosa que el while loop no. Esto ayuda a prevenir loops infinitos, aunqe sigue siendo posible causarlos.

        // Tambien tengan en cuenta que la varible del iterador se esta definiendo de forma local.
        // Esto quiere decir como vimos antes, que "i" no puede ser usado fuera del scope del loop.
        // Es una medida de prevencion. Generalmente no queres que el iterador sea usado fuera del loop.

        
    }
}

