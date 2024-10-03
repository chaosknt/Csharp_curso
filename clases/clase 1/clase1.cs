static void Main()
    {


#region  Tipos de  Variables + Ejercicio 1 
        /*
        Tipos de Datos       

          string valorString = "Hola, mundo!"; // Secuencia de caracteres
          int valorInt = 2147483647; // -2147483648 a 2147483647
          bool valorBool = true; // True o False
          float valorFloat = 3.402823E+38F; // ±1.5 x 10^−45 a ±3.4 x 10^38


          Declarar variables de diferentes tipos e imprimir por consola: Nombre, apellido, Edad, Genero, Si les gusta la pizza

        */

        sbyte valorSbyte = 127; // -128 a 127
        short valorShort = 32767; // -32768 a 32767
        int valorInt = 2147483647; // -2147483648 a 2147483647
        long valorLong = 9223372036854775807L; // -9223372036854775808 a 9223372036854775807

        byte valorByte = 255; // 0 a 255
        ushort valorUShort = 65535; // 0 a 65535
        uint valorUInt = 4294967295; // 0 a 4294967295
        ulong valorULong = 18446744073709551615UL; // 0 a 18446744073709551615

        float valorFloat = 3.402823E+38F; // ±1.5 x 10^−45 a ±3.4 x 10^38
        double valorDouble = 1.79769313486232E+308D; // ±5.0 × 10−324 a ±1.7 × 10^308
        decimal valorDecimal = 79228162514264337593543950335M; // ±1.0 × 10^−28 a ±7.9 × 10^28

        bool valorBool = true; // True o False

        // Otros tipos de datos
        object valorObject = new object(); // Tipo base de todos los tipos
        char letra = 's';
        string valorString = "Hola, mundo!"; // Secuencia de caracteres

        dynamic valorDynamic = null; // Tipo dinámico
        DateTime valorDateTime = DateTime.Now; // Fecha y hora actual

        Console.WriteLine($"sbyte: {valorSbyte}");
        Console.WriteLine($"short: {valorShort}");
        Console.WriteLine($"int: {valorInt}");
        Console.WriteLine($"long: {valorLong}");
        Console.WriteLine($"byte: {valorByte}");
        Console.WriteLine($"ushort: {valorUShort}");
        Console.WriteLine($"uint: {valorUInt}");
        Console.WriteLine($"ulong: {valorULong}");
        Console.WriteLine($"char: {valorChar}");
        Console.WriteLine($"float: {valorFloat}");
        Console.WriteLine($"double: {valorDouble}");
        Console.WriteLine($"decimal: {valorDecimal}");
        Console.WriteLine($"bool: {valorBool}");
        Console.WriteLine($"object: {valorObject}");
        Console.WriteLine($"string: {valorString}");
        Console.WriteLine($"dynamic: {valorDynamic}");
        Console.WriteLine($"DateTime: {valorDateTime}");
#endregion

#region   Operaciones de asignacion
        /*
            Operaciones de asignacion

            Operador de asignación simple (=): Asigna el valor de la derecha al operando de la izquierda.
            Operador de asignación compuesta (+=, -= *=, /=, %=): Realiza una operación y asigna el resultado al operando de la izquierda. Por ejemplo:

            += suma el valor derecho al operando izquierdo.
            -= resta el valor derecho al operando izquierdo.
            *= multiplica el operando izquierdo por el valor derecho.
            /= divide el operando izquierdo por el valor derecho.
            %= asigna al operando izquierdo el resultado del módulo entre el operando izquierdo y derecho.

            int a = 5;
            a++; // Ahora a = 6

            int x = 8;
            x--; // Ahora x = 7
        */
#endregion

#region  Constantes
        /*
            Constantes

            const decimal PI = 3.14;
        */
#endregion

#region  Operadores y Comentarios

/*

### Operadores  aritmeticos  + Ejercicio


+: sumar
-: resta
*: multiplicacion
/: division
%: modulo o resto de una division

Operadores aritmeticos => Son binarios porque siempre se trabaja con 2 valores

Como se escriben?

operador1 + operador2

int resto = 10 % 2


Escribir en una variable su edad. Asignarle un valor. Multiplicar ese numero por 20. Dividir el resultado por 2. Finalmente restarle 4 a ese valor. Obtener el resto de la division de la dividir 50/15
Mostrar resultado en consola


### Concatenacion

operador + viene sobre cargado

Console.WriteLine("Numero: " + 15);


### Precedencia de operadores y uso de parentesis

en el lenguaje hay una tabla de precendencia de los operadores y eso define que se resuelve primero.
int result = 2 + 3 * 4

SI deseo alterar uso parantesis

int result = (2 + 3) * 4



### Operadores aritmeticos + Asignacion

a++
a+=5;


### Operadores relacionales

< menor
> mayor
<= menor o igual
>= mayor o igual
== igual
!= distinto
! Negacion

operandor1 > operando2

aplicacion mostrar ejemplo de cada tipo:

Entre numeros o entre variables


### Tabla de verdad

| A | B | AND | OR | XOR  (exclusive or)| Solo uno debe ser verdadero
|   |   |     |    |      |
|   |   |     |    |      |
|   |   |     |    |      |
|   |   |     |    |      |


| A | NOT (negacion)
|   |
|   |


### Sintaxis

& AND
| OR
^ XOR
! NOT

### APLICACION operadores logicos

bool resL, log = true, log2 = false

hacer consol.writeline en pantalla comparando cada uno de los operadores logicos (and, or, xor y not)


ejemplo XOR

bool condicionA = true;
bool condicionB = false;

if (condicionA ^ condicionB)
{
    // Esta condición se cumple si una, pero no ambas, condiciones son verdaderas
    Console.WriteLine("La condición A o la condición B es verdadera, pero no ambas.");
}
else
{
    Console.WriteLine("Otra situación.");
}


### Impresion en pantalla de un valor dentro de un string

Console.WriteLine("El numero es {0}", 1);

*/

#endregion

    }