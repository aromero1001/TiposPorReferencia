// Plan (pseudocódigo):
// 1. Definir una función local `ShowMessage(string)` que escriba el mensaje en la consola.
// 2. Usar un delegado compatible (`Action<string>`) para asignar la función `ShowMessage`.
// 3. Invocar el delegado con la cadena deseada.
// 4. Mantener el resto del archivo sin cambios.
//
// Esta solución corrige CS0103 porque define `ShowMessage` en el mismo contexto donde se usa.

using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using TiposPorReferencia.Class;

Teacher teacher = new Teacher(1, "John Doe", "Math Teacher", "Mathematics");
Student student = new Student(2, "Jane Smith", "Computer Science Student", "Computer Science");
Console.WriteLine($"Teacher: {teacher.Name}, Subject: {teacher.Subject}");
Console.WriteLine($"Student: {student.Name}, Course: {student.Course}");


var (id, name, description) = teacher;

Student brother = student with { Description = "Copia de Obejto" };

Console.WriteLine("Original Student: " + student.Description);



//Clases 
Bebida bebida1 = new Bebida("Cocacola",10,12.34);
Console.WriteLine($"Nombre: {bebida1.Nombre}");


// Array unidimensional
int [] numeros = { 1, 2, 3, 4, 5 };

int[] arrayEnteros = new int[5];
arrayEnteros[0] = 1;
arrayEnteros[1] = 2;
arrayEnteros[2] = 3;
arrayEnteros[3] = 4;
arrayEnteros[4] = 5;

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

for(int i = 0; i < arrayEnteros.Length; i++)
{
    Console.WriteLine(arrayEnteros[i]);
}

//Array Multidimensional
    
string[,] matriz = new string[2,2];

matriz[0, 0] = "Ansony";
matriz[0, 1] = "Smith";
matriz[1, 0] = "Romero";
matriz[1, 1] = "Garcia";

foreach (string elemento in matriz)
{
    Console.WriteLine(elemento);
}


//Array Jagged
string [][] jaggedArray = new string[3][];

jaggedArray[0] = new string[3];
jaggedArray[1] = new string[2];
jaggedArray[2] = new string[4];

jaggedArray[0][0] = "Huesca";
jaggedArray[0][1] = "Huesca2";
jaggedArray[0][2] = "Huesca3";

jaggedArray[1][0] = "Zaragoza";
jaggedArray[1][1] = "Zaragoza2";


jaggedArray[2][0] = "Teruel";
jaggedArray[2][1] = "Teruel2";
jaggedArray[2][2] = "Teruel3";
jaggedArray[2][3]  = "Teruel4";
     
for(int i = 0; i < jaggedArray.Length; i++)
    {
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine(jaggedArray[i][j]);
    }
}

Console.ReadKey();

//Colecciones Genericas

List<string> lista = new List<string>();



lista.Add("Elemento 1");
lista.Add("Elemento 2");
lista.AddRange(new string[] { "Elemento 3", "Elemento 4" });

Console.WriteLine($"Elementos en la lista:{ lista}");
int cantidad = lista.Count;
var primero = lista.First();
var ultimo = lista.Last();
lista.Remove("Elemento 2");
lista.Clear();

IReadOnlyList<string> listaInmutable = new List<string> { "Elemento A", "Elemento B", "Elemento C" };
//listaInmutable.Add("Elemento D"); // Esto generará un error de compilación, ya que IReadOnlyList no permite modificaciones

//Lista ordenada
SortedList<int, string> sortedList = new SortedList<int, string>();
{
    sortedList.Add(3, "Tercer elemento");
    sortedList.Add(1, "Primer elemento");
    sortedList.Add(2, "Segundo elemento");
}

//Diccionario
Dictionary<string,int> diccionario = new Dictionary<string, int>();
{
    diccionario.Add("Clave1", 100);
    diccionario.Add("Clave2", 200);
    diccionario.Add("Clave3", 300);
}

diccionario.TryAdd("Clave4", 400);

if(diccionario.TryGetValue("Clave2", out int valor))
{
    Console.WriteLine($"Valor asociado a 'Clave2': {valor}");
}
else
{
    Console.WriteLine("La clave no existe en el diccionario.");
}

if(diccionario.ContainsKey("Clave3"))
{
    diccionario["Clave3"] = 350; // Actualiza el valor asociado a "Clave3"
}


// Cola
Queue<string> cola = new Queue<string>();
{
    cola.Enqueue("Primer elemento");
    cola.Enqueue("Segundo elemento");
    cola.Enqueue("Tercer elemento");
}

foreach (string elemento in cola)
{
    Console.WriteLine(elemento);
}

Console.WriteLine($"Elemento al frente de la cola: {cola.Peek()}");
Console.WriteLine($"Elemento removido de la cola: {cola.Dequeue()}");

// Pila
Stack<string> pila = new Stack<string>();
{
    pila.Push("Primer elemento");
    pila.Push("Segundo elemento");
    pila.Push("Tercer elemento");
}

Console.WriteLine($"Elemento en la cima de la pila: {pila.Peek()}");
Console.WriteLine($"Elemento removido de la pila: {pila.Pop()}");

//Colas de prioridad
PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();
{
    priorityQueue.Enqueue("Tarea de baja prioridad", 3);
    priorityQueue.Enqueue("Tarea de alta prioridad", 1);
    priorityQueue.Enqueue("Tarea de prioridad media", 2);
}

priorityQueue.EnqueueDequeue("Tarea de prioridad media", 2);
Console.WriteLine($"Elemento con mayor prioridad: {priorityQueue.Peek()}");

// Listas enlazadas

LinkedList<string> linkedList = new LinkedList<string>();
{
    linkedList.AddLast("Primer elemento");
    linkedList.AddLast("Segundo elemento");
    linkedList.AddLast("Tercer elemento");
}

//Si elimino uno de los elementos del medio
linkedList.Remove("Segundo elemento");
int indice = 0;
foreach (string elemento in linkedList.ToList())
{
    indice++;
    linkedList.AddFirst($"Primero elemento {indice.ToString()}"); // Agrega un nuevo elemento al principio de la lista
}

Console.WriteLine($"Elementos en la lista enlazada:{linkedList}");

foreach (string elemento in linkedList)
{
    Console.WriteLine(elemento);
}


//Es igual que la lista pero con la diferencia que la lista enlazada no tiene un indice fijo, es decir, no se puede acceder a un elemento por su indice, sino que se debe recorrer la lista desde el principio hasta encontrar el elemento deseado.

//Hashtable en resumidas es una colección de pares clave-valor que permite almacenar y recuperar datos de manera eficiente utilizando una función hash para calcular la ubicación de los elementos en la tabla. Es una estructura de datos que se utiliza para implementar diccionarios, mapas o tablas de símbolos, donde cada clave única se asocia con un valor específico. La clase Hashtable es parte del espacio de nombres System.Collections en .NET y proporciona métodos para agregar, eliminar y buscar elementos en la tabla hash. Sin embargo, es importante tener en cuenta que Hashtable no es genérica y no ofrece la misma seguridad de tipo que las colecciones genéricas como Dictionary<TKey, TValue>, por lo que se recomienda utilizar estas últimas en la mayoría de los casos.

Hashtable hashtable = new Hashtable();
{
    hashtable.Add(1, "Valor1");
    hashtable.Add(2, "Valor2");
    hashtable.Add(3, "Valor3");
}

foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"Clave: {entry.Key}, Valor: {entry.Value}");
}

//Intentamos agrega una clave duplicada
//hashtable.Add(1, "Valor duplicado"); // Esto generará una excepción, ya que la clave 1 ya existe en la hashtable

//ArrayList es una colección que puede contener elementos de diferentes tipos y se redimensiona automáticamente según sea necesario. Es parte del espacio de nombres System.Collections en .NET y proporciona métodos para agregar, eliminar y acceder a los elementos de la lista. Sin embargo, al igual que Hashtable, ArrayList no es genérica y no ofrece la misma seguridad de tipo que las colecciones genéricas como List<T>, por lo que se recomienda utilizar estas últimas en la mayoría de los casos.

ArrayList arrayList = new ArrayList();
{
    arrayList.Add("Elemento1");
    arrayList.Add(123);
    arrayList.Add(45.67);
}

foreach (object elemento in arrayList)
{
    Console.WriteLine($"Elemento: {elemento}");
}

//BitArray 

BitArray bitArray = new BitArray(8);
{
    bitArray.Set(0, true);
    bitArray.Set(1, false);
    bitArray.Set(2, true);
    bitArray.Set(3, false);
    bitArray.Set(4, true);
    bitArray.Set(5, false);
    bitArray.Set(6, true);
    bitArray.Set(7, false);
}

for (int i = 0; i < bitArray.Length; i++)
{
    Console.WriteLine($"Bit {i}: {bitArray.Get(i)}");
}

Console.ReadKey();


HashSet<string> hashSet = new HashSet<string>();
{
    hashSet.Add("Elemento1");
    hashSet.Add("Elemento2");
    hashSet.Add("Elemento3");
   // hashSet.Add("Elemento1"); // Intento de agregar un elemento duplicado, no se agregará al HashSet
}

//Hasset unifica los duplicados, es decir, si intentamos agregar un elemento que ya existe en el HashSet, no se agregará nuevamente y no se generará una excepción. Esto se debe a que HashSet está diseñado para almacenar elementos únicos y no permite duplicados.

foreach (string elemento in hashSet)
{
    Console.WriteLine($"Elemento: {elemento}");
}


//ConcurrentDictionary

var list = new List<int>();

Parallel.For(0, 1000, i =>
{
    list.Add(i);
});

Console.WriteLine($"Cantidad de elementos en la lista: {list.Count}");


//ConcurrentBag
var cache = new ConcurrentDictionary<string, int>();

cache.TryAdd("Clave1", 100);
cache.TryAdd("Clave2", 200);

if(cache.TryGetValue("Clave1", out int valorCache))
{
    Console.WriteLine($"Valor asociado a 'Clave1' en el cache: {valorCache}");
}
else
{
    Console.WriteLine("La clave no existe en el cache.");
}

cache.TryUpdate("Clave1", 150, 100); // Actualiza el valor asociado a "Clave1" si el valor actual es 100


cache.GetOrAdd("Clave3", 300); // Agrega "Clave3" con el valor 300 si no existe, o devuelve el valor existente si ya existe

cache.AddOrUpdate("Clave2", 250, (key, oldValue) => oldValue + 50); // Actualiza el valor asociado a "Clave2" sumando 50 al valor actual

//ConcurrentQueue
var bag = new ConcurrentBag<int>();

Parallel.For(0, 1000, i =>
{
    bag.Add(i);
});

Console.WriteLine(bag.ToString());
Console.ReadKey();


//blockingCollection

//var collection = new BlockingCollection<int>();
//Productor de datos

//Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        collection.Add(i);
//        Console.WriteLine($"Producto agregado: {i}");
//        Thread.Sleep(500); // Simula tiempo de producción
//    }
//    collection.CompleteAdding(); // Indica que no se agregarán más elementos
//});


//Console.ReadKey();

////Consumidor de datos
//Task.Run(() => { 
//    foreach (var item in collection.GetConsumingEnumerable())
//    {
//        Console.WriteLine($"Producto consumido: {item}");
//        Thread.Sleep(1000); // Simula tiempo de consumo
//    }
//});

Bebida del1 = new Bebida("Cocacola",10,12.34);
del1.EjemploDelegado();

del1.EjemploFunc();

//Ejemplo de Span 
Span<char> span = ['H', 'e', 'l', 'l', 'o'];

string[] brands = ["open", "seat"];
ReadOnlySpan<string> readOnlySpan = brands;


//Predicados es una implementacion de los delegado
static bool IsEven(int number)
{
    return number % 2 == 0;
}

var numbers = new List<int>();
numbers.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
var predicate = new Predicate<int>(IsEven);
var dividers = numbers.FindAll(predicate);

Console.ReadKey();