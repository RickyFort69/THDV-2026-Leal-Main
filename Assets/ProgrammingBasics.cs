using UnityEngine;

// ANTES QUE NADA: Para que el script funcione, tiene que estar agregado a un gameobject
// (hay casos en lo que no es necesario, pero por el momento lo ponemos en uno)

// Tambien no se olviden de modificar / añadir sus propias lineas de codigo mientras leen esto.
// Asi van practicando y familiarizandose con lo que se puede y no se puede en C#.

// Tambien van a ver que Unity les aparece un monton de advertencias amarillas. No se preocupen por el momento.

// Por ultimo: Si no entienden algo de esto, pregunten por Blackboard o Discord!


public class ProgrammingBasics : MonoBehaviour { // Declaracion de la Clase, donde van a estar todos los metodos del script

    int myField; // Una variable field sin valor asignado. Puede usarse en cualquier lado dentro del scope de la clase.

    private void Start() {  // Declaracion de un Metodo, en este caso el Start. Los metodos contienen toda la logica que va a ejecutar el compilador.
                            // Toda la logica se encuentra dentro de las llaves {}. Si esta por fuera, no es parte del metodo (ver punto 3)

        //------------------------------------------------------------------------------------------------

        // (1) - COMO EL CODIGO SE EJECUTA:

        // Toda linea codigo, y todo script siempre corre de arriba hacia abajo en terminos simples. 
        // Tambien de izquierda a derecha.
        // Puede haber saltos de un script al otro, o de una funcion a otra, pero la ejecucion siempre es progresiva.
        // Presten atencion a como cada linea de codigo se ejecuta de forma progresiva.

        // (Para ver la ejecucion denle play al juego en Unity)

        Debug.Log("Primera Instruccion");
        Debug.Log("Segunda Instruccion");
        Debug.Log("Tercera Instruccion"); // Durante toda esta practica, se puede comentar las lineas de codigo para que no se ejecuten si no es necesario.
                                          // Para comentar una linea de codigo, se añade el "//" como en estos mensajes.
                                          // Van a observar que algunas lineas de codigo estan comentadas. Quitenles los // para verlas en accion.

        // Aca estamos usando la clase Debug, que contiene varias funciones para escribir elementos en la consola de Unity.
        // Unity usa esta clase para mostrarte todas las advertencias y errores que puede tener el proyecto. Tambien nosotros podemos poner los mensajes que querramos
        // justamente haciendo uso del termino "debuggear".

        //---------IMPORTANTE----------
        // Que se note como cada linea de codigo termina con un ";".
        // Esto es importante poner al final de cada linea, ya que esto le indica al compilador que la instruccion esta completa y se pueda pasar a la otra.
        // Prueben borrar el ; y fijense como Visual Studio les va a marcar que hay un error. Les pone una linea roja sobre la linea para indicarlo.

        // Esto significa, que si ustedes quieren tambien pueden escribir una linea de la siguiente forma:
        
        Debug.Log
            ("Linea escrita de forma rara")
            ;

        // Esto es codigo valido, lo unico que a C# le importa es que pongas el ; al final de la instruccion.
        // Lo que si no pueden hacer, es separar las palabras claves, como Debug (No pueden poner De Bug).


        //------------------------------------------------------------------------------------------------

        // (2) - CODIGO ES SENSIBLE A COMO ESCRIBEN LAS INSTRUCCIONES:

        // Por ejemplo, tomemos las siguientes dos lineas de codigo:

        // Debug.Log("Linea Correcta");
        // Debug.log("Linea Incorrecta");

        // Si le sacan los // a las dos lineas, veran que la primera esta bien. Pero la segunda les tira error. ¿Por que?.

        // Bueno, porque la segunda linea de codigo tiene la "L" de "Log" en minuscula.
        // Esto para el compilador significa una instruccion distinta, si bien en ingles son lo mismo.
        // Resulta entonces que el compilador esta buscando una funcion "log" que dentro de la clase Debug no existe.

        // Este tipo de error generalmente se puede evitar porque al usar el "."
        // Visual Studio les marca con facilidad cuales son las funciones disponibles.

        // Si les interesa, pueden investigar en internet reglas generales de nomenclatura en codigo y como mantenerlo organizado.

        //------------------------------------------------------------------------------------------------

        // (3) - LAS "{LLAVES} y (PARENTESIS)":

        // Si vamos a la parte superior de este codigo, en el metodo de Start().
        // Pueden observar que despues de declarar la funcion hay un "{".

        // Incluso si van al nombre de la clase (ProgrammingBasics), tambien pueden ver que tiene una llave.
        // Los simbolos de llave { } se utilizan para indicar "Scope" dentro del codigo.

        void MyMethod() { // Abro llave para empezar a escribir codigo para este metodo

            // Toda linea de codigo aca dentro, le pertenece a MyMethod.
            // Esto es importante para cuando usen variables, ya que las variables que se creen aca no se pueden usar fuera de MyMethod().

        } // Cierro llave

        // Tambien, como aca estoy creando un Metodo dentro de la funcion Start(), quiere decir que este metodo solo es valido
        // mientras se use dentro de los {} que Start() posee.

        // Si quieren ver exactamente como esto funciona, hagan scroll para abajo fuera del "}" de Start().

        // Este misma regla de abrir y cerrar llaves, tambien se aplica para los parentesis:

        // Debug.Log("Texto"; 
        // Esa linea de codigo no va andar porque falta el ")" que complete la declaracion del metodo.

        //------------------------------------------------------------------------------------------------

        // (4) - VARIABLES:

        // En programacion usamos distintos tipos de "datos" para crear y guardar informacion.
        // Esta informacion la usamos para crear LOGICA, y la contenemos usando variables.

        // Una variable en C# se declara asi:
        int miEdad = 23;

        // 1) Definimos que tipo de dato. En este caso un int (Un numero entero).
        // 2) Definimos el nombre. Idealmente se usa camelCase (minusculaMayuscula -> miEdad), y un nombre claro e identificativo de lo que la variable representa.
        // 3) Inicializamos la variable (le damos un valor). Para esto se usa el operador "=" que significa asignar un valor.
        //    Podemos inicializarla en otra linea si queremos, separado de su declaracion.
        //    Ejemplo: int miEdad; miEdad = 23;
        // 4) Escribimos el dato que queremos asignar, correspondiente al tipo de dato elegido para la variable (en nuestro caso, 23). 

        // Tambien podemos asignarle el valor de otra variable:
        int numero = miEdad;
        // Debug.Log("El numero es: " + numero);  // Con esto pueden ver el resultado de la variable en consola.

        // Aca un ejemplo de una variable declarada pero no inicializada:
        int año;

        // Podemos definir varias variables a la vez en una misma linea:
        int num1, num2 = -5, num3 = 11;

        // Podemos cambiar el valor de una variable en todo momento:
        num3 = -3;

        //---------ERRORES TIPICOS----------

        // 1) Dos variables no pueden llamarse igual.
        // int miNumero = 3;
        // int miNumero = 5;     // No es valido.
        // Si lo que buscan es que la misma variable tenga otro valor, simplemente asignan un nuevo valor. No creen otra variable con el mismo nombre.

        // 2) Una variable solo puede contener el tipo de dato que es. Un int no puede contener texto, solo numeros enteros.
        // int nombre = Joaquin; // No es valido.

        // 3) El scope donde una variable fue declarada es importante:
        void CrearVariableInt() {
            int otroNumero;
            otroNumero = miEdad; // Se puede usar miEdad porque fue creado dentro del scope de Start(), y este metodo esta dentro de ese scope.
        }
        // otroNumero = 5;       // No es valido porque la variable fue declarada dentro del scope del metodo anterior, no por fuera.

        // 4) No se puede usar una variable que no tiene un valor asignado (A menos que sea un field, leer unas lineas mas abajo):

        //int miNumeroVacio;
        //Debug.Log(miNumeroVacio); // Esto no es valido, porque no se le asigno ningun valor a la variable.

        //---------IMPORTANTE----------

        // Las variables vienen en dos formas: Locales y field. Su tipo varia segun donde son definidas.
        // Si una variable es definida dentro de un metodo (Como venimos haciendo aca con Start), son consideradas locales.
        // Esto se puede reconocer porque son de color celeste (En visual), y no te permiten usarlas fuera de su scope o sin un valor asignado.

        // pero, si nosotros declaramos una variable dentro del scope de una clase (ProgrammingBasics), entonces se considera un field.
        // Arriba de todo podran encontrar el field "myField". En la siguiente linea de codigo hacemos que ese field aparezca en consola.
        // Los fields se se pueden reconocer por su color blanco.

        // Debug.Log("Mi field es: " + myField);

        // Esta linea de codigo es valida, incluso si el field no tiene valor.
        // Los fields que no tienen un valor asignado, agarrar un valor default para el tipo de data que son.
        // En este caso, para un int el valor default es 0.


        //------------------------------------------------------------------------------------------------

        // (5) - OPERACIONES:

        // Las variables pueden ser operadas matematicamente entre ellas, siempre y en cuanto el tipo de dato lo permita.
        // Hay distintos tipos de operadores, y dependiendo el tipo de dato puede cambiar su significado o lo que hacen.
        // En este caso vamos a estar viendo ejemplos usando int.

        // 1) Sumar: Los datos pueden sumarse entre si usando el operador "+";
        int numero2 = 1;
        int numero3 = numero2 + 2; // numero3 vale 3 entonces. Recorda usar Debug.Log(variable) para ver los resultados.

        // Tambien se puede usar operadores de estas formas:
        numero2 += 3; // numero2 valdria 4
        numero2 ++; // numero2 valdria 5

        // Las operaciones pueden hacerse dentro de los parentesis de un metodo tambien.
        // Debug.Log("Mi suma es: " + numero2 + numero2);

        // 2) Restar: Los datos pueden restarse entre si usando el operador "-";
        numero2 = 5;
        numero3 = 10;

        int miResta = numero2 - numero3; // Mi resta valdria -5.

        // Al igual que sumar, tambien podes hacer esto.
        numero2 -= 3; // numero2 valdria 2
        numero2--; // numero2 valdria 1

        // 3) Multiplicar y dividir: Al igual que vimos con la resta y la suma, tambien se puede multiplicar y dividir.
        // Para multiplicar se usa "*", para dividir se usa "/"
        numero2 = 5;
        numero3 = 10;
        int numeroMultiplicado = numero2 * 2; // Mi multiplicacion valdria 10.
        int numeroDividido = numero3 / 2; // Mi division valdria 5.

        // Con estos operadores, no se puede hacer esto:
        //numero2**;
        //numero2//;

        //------------------------------------------------------------------------------------------------

        // (6) - TIPOS DE DATO:

        // En los ejemplos anteriores vimos el int, que se usa para representar numeros enteros.
        // Pero existen varios tipos de datos que podemos contener en una variable. Vamos a ver los mas simples y tipicos.
        // Sepan que cada tipo de dato puede tener sus propias reglas, incluso para ser declarados / asignados a una variable (Como las clases).
        // Tambien cada tipo de dato puede funcionar distintos con los operadores vistos anteriormente.

        // 1) FLOAT: Se usa para crear numeros decimales.
        // Tienen las mismas reglas que un int, salvo porque al final del numero se debe poner una "f".

        float miFloat = 3.14f; // Sin la "f" no es valido.

        // Los floats no necesariamente tienen que tener espacios decimales.
        float unFloatEntero = 3f; 

        // Los floats pueden operarse entre ellos, e incluso usando ints.
        float miSegundoFloat = miFloat * 5;  // Asignando el resultado de la multiplicacion entre un float y un int.

        // Pero los ints no pueden contener un valor decimal.
        // int decimalInvalido = miSegundoFloat * 2; // No es valido

        // Existen otros tipos de data types para numeros decimales aparte del float, pero dentro de Unity no se usan casi nunca.
        decimal miDecimal = 34.4m; // Los decimal type se declaran con una "m" al final.
        double miDouble = 1.5;     // Los double van sin letra al final.

        // Estos existen para numeros mas grandes y precisos que se pueden necesitar en ciertas operaciones matematicas.
        // Los floats no son particularmente grandes y precisos, poreso existen estas alternativas.
        // Pueden leer de eso aca: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

        //------------------------------------------------------------------------------------------------

        // 2) STRING: Una cadena de texto. Se usa para representar texto. 
        // El valor de un string siempre debe ir entre " " si se esta definiendo.

        string miNombre = "Joaquin";         // Valido
        // string miOtroNombre = Exequiel;   // No valido. Faltan los "".

        // Un numero escrito como string no es operable matematicamente.
        string numeroTexto = "2";
        // int nuevaSuma = 1 + numeroTexto;  // No es valido porque numeroTexto es un string.

        // Un string puede ser cualquier caracter de tu teclado, incluso un espacio vacio.
        string espacioVacio = " ";

        // Los strings pueden usar el operador + entre si. Esto los une entre si.
        string helloWorld = "Hello" + espacioVacio + "World"; // Esto crea como resultado "Hello World".
        Debug.Log(helloWorld);

        // Los strings tambien pueden ser interlopados con otras variables para crear textos complejos mas facil.
        // Esto se hace añadiendo el $ antes de abrir el string. 
        // La variables que quieras concatenar van entre los {}.
        float otroFloat = 4f;
        Debug.Log($"El valor es {otroFloat}");

        // El valor default de un string es null. Null significa que la variable no contiene una referencia.
        // Esto es porque los strings son un data type de tipo referencia. No se preocupen si no entienden que singnifica eso, es algo un poco mas avanzado.

        string defaultStringValue = null;
        // Debug.Log(defaultStringValue);

        // Si lo ven en la consola, justamente les va a decir que el valor de este string es null.

        //---------IMPORTANTE----------
        // Normalmente no podes convertir otro tipo de dato a string.
        // Con Debug.Log se puede hacer porque el metodo de Log() se encarga de hacerlo dentro de su logica.
        // Pero para hacerlo manualmente se hace lo siguiente:

        string floatToString = otroFloat.ToString();

        // Todos los data types tienen el metodo ToString(), que te permite convertir dicho valor en string.

        //------------------------------------------------------------------------------------------------

        // 3) CHAR: Un caracter de texto. Los strings estan compuestos por char. 
        // El valor de un char debe ir entre '' para definirlo.

        char miChar = 's';
        //char miOtroChar = 'wasd'; // No es valido porque un char solo puede tener un caracter a la vez.

        //------------------------------------------------------------------------------------------------

        // 4) BOOL: Un numero booleano. Es decir, un valor que es TRUE o FALSE (1 o 0).
        // Otro valor no es posible. Tampoco pueden operarse matematicamente con sumas, restas, etc.

        bool isDead = true;
        bool isAlive = false;

        // Los bools son importantes para el check de condiciones, como en bloques de if y else. Mas adelante veremos esto.
        // El valor default de un bool es siempre false.


        //------------------------------------------------------------------------------------------------

        // 5) VAR: Palabra usada para variables que puede tomar cualquier valor. El compilador lo decide en base a lo que ustedes definen.
        // No recomendado.

        var variableInt = 5;
        var variableString = "Joaquin";
        var variableBool = false;

        // La razon por la cual no lo uso es porque no es explicito que la variable es. 
        // Al hacer operaciones o logica compleja, puede causar problemas.

        // Si quieren ver mas data types, pueden verlos aca: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types


        //------------------------------------------------------------------------------------------------

        // (7) - CONDICIONES:

        // Para crear logica compleja, se necesita evaluar condiciones. 
        // Esto se hace usando los bools.
        // Se crea una condicion que codigo debe checkear, y evaluar si es TRUE o FALSE.
        // En base al resultado, distinto tipo de logica puede ejecutarse.

        // Para poder crear condiciones a evaluar, se utiliza la palabra clave "if"
        // Seguido del if, se utilizan parentesis para encapsular la condicion que debe checkearse.

        // if (condicion)
        // {
        //   CODIGO
        // }

        // En el ejemplo a continuacion, estamos checkeando si 1 es igual a 2.
        // Para checkear si algo es igual a otra cosa, se utiliza el operador "==".

        if (1 == 2) // Es 1 igual a 2? (Esto es false. Por lo cual el codigo dentro del scope nunca se ejecutaria).      
        { // Scope de la condicion se abre.

            Debug.Log("Uno es igual a dos");

        } // Scope de la condicion se cierra.

        // Si cambian el 2 por un 1, obviamente el codigo si se va a ejecutar.

        // Tambien pueden checkear si algo NO ES IGUAL a otro valor.
        // Esto se hace usando el operador "!=".

        if (1 != 3) { // Es 1 diferente a 3? (Esto es true. El bloque de codigo se va a ejecutar).

            Debug.Log("Uno no es igual a tres");
        }

        // Tambien podemos probar si algo es mayor / menor a un numero.
        // Se usan los operadores "<" (Menor a) ">" (Mayor a).

        float distance = 10f; 

        if (distance < 4f) {

           Debug.Log("La distancia es menor a 4");
        }

        // Incluso pueden chekear si algo es mayor e igual / menor e igual a otro valor.
        // Se usan los operadores "<=" y ">=".

        if (distance >= 10f) {

            Debug.Log("La distancia es mayor o igual a 10");
        }

        // Si se modifica el valor de distance, podran ver como se ejectua un if o el otro.
        // Justamente a veces queremos eso, que el codigo se ramifique segun el resultado obtenido.

        // Para poder asegurar que el codigo siempre haga algo, incluso si nuestra condicion no es true podemos usar la palabra clave "else"
        // Este "else" va despues del if, pero no lleva una condicion a evaluar (Ya que evalua si la del if es falsa).

        bool playerDead = false;

        if (playerDead == true) {
            Debug.Log("El jugador esta muerto");
        } else {
            Debug.Log("El jugador esta vivo");
        }

        // Si cambian el valor del bool a true, se va a ejectuar el if.
        // Pero si esta en false, se ejecuta el else.
        // Los else se utilizan para evitar ser redudante, y que el codigo no haga check de una misma condicion otra vez.

        if (playerDead == true) { 

        }
        if (playerDead == false) { 

        }
        // Hacer esto de arriba es redudante y no necesario.
        // Se puede simplemente poner un else como en el ejemplo de arriba si queres hacer algo cuando la condicion es false.


        //---------IMPORTANTE----------
        // Si usan bools para hacer check de las condiciones, pueden diramente evaluarlos asi:

        if (playerDead) { 

        }

        // No es necesario poner el "==", ya que playerDead ya tiene un valor true / false. 
        // Dependiendo su valor se ejectua el codigo o no.

        // Esto justamente nos permite hacer un check adicional.

        if (!playerDead) { 

        }

        // Aca añadimos el operador "!" al principio del bool.
        // Esto les permite evaluar si playerDead no es true (Es decir, si playerDead es falso / si el jugador no esta muerto).
        // Esto es lo mismo que poner (playerDead == false) o (playerDead != true).

        // Adicionalmente tambien pueden hacer check de dos o mas cosas a la vez en una condicion.
        // Para esto se usa el operador "&&" (And) entre cada comparacion logica.

        if (1 > 0 && 1 == 1) { 

        }

        // Aca la condicion esta preguntando si 1 es mayor a 0, y si 1 es igual a 1. En ambos casos es true.
        // Si los casos son true el codigo se ejectua, pero si uno de los casos es false, entonces el codigo no se ejecuta.
        // Para que el codigo de un if que usa && se ejecute, todos los casos tienen que ser true. No basta con uno solo.

        if (1 > 0 && 1 == 1 && 3 == 4) { // Este codigo no va a correr porque "3 == 4" es false. No importa que los otros sean true.

        }

        // Si lo que buscan es chekear que una de las condiciones almenos sea true, entonces pueden usar el operador "||" (Or).

        if (1 > 0 || 3 == 4) { 

        }

        // En este caso el codigo del if si va a correr, porque "1 > 0" es true. Incluso si el otro es false. 
        // Para saber que valor van a obtener usando cada operador, pueden ver la siguiente tabla:
        // https://content.codecademy.com/practice/art-for-practice/new-pngs/Boolean-operators-dk.png

        // Y estos operadores pueden combinarlos en conjunto:
        playerDead = false;
        if (3 == 4 || 4 == 4 && !playerDead) {
            //Debug.Log("Todo eso es true");
        }
        // Ahi arriba primero checkearmos si 3 es igual a 4, y si 4 es igual a 4.
        // 4 es igual a 4, asi que tenemos un true dentro del ||
        // Pero tambien tenemos el && y nos obliga a checkear si la siguiente condicion es true de forma obligatoria.
        // !playerDead es true (El jugador no esta muerto) (Estamos usando el ! para chekear que NO ESTA muerto).
        // Ese codigo entonces se puede ejecutar.










    } // Termina scope de Start().


    //---------------------------------

    // MyMethod(); // No lo pueden usar porque esta fuera de scope.

    // Dentro del scope de una clase ustedes no pueden declarar instrucciones,
    // solo definir datos (Como variables, funciones u otras clases, etc)
    // Por eso el codigo que usamos corre dentro de Start(), y no fuera

    //---------------------------------


} // Termina scope de ProgrammingBasics().
