using System;

// Abstracción: Creamos una clase abstracta que define un método abstracto
// que será implementado por las clases derivadas.
public abstract class Animal
{
    public abstract void EmitirSonido();
}

// Encapsulación: Creamos una clase que encapsula los datos y métodos relacionados.
public class Perro : Animal
{
    // Propiedades encapsuladas
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    // Constructor
    public Perro(string nombre)
    {
        Nombre = nombre;
    }

    // Implementación del método abstracto
    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau Guau!");
    }
}

public class Gato : Animal
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public Gato(string nombre)
    {
        Nombre = nombre;
    }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau Miau!");
    }
}

// Polimorfismo: Creamos un método que acepta un objeto de la clase base
// pero puede recibir objetos de las clases derivadas.
public class Veterinario
{
    public void Curar(Animal animal)
    {
        Console.WriteLine($"El veterinario está atendiendo a {animal.GetType().Name}:");
        animal.EmitirSonido();
    }
}

// Herencia: La clase Perro y Gato heredan de la clase Animal
class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de perro y gato
        Perro miPerro = new Perro("Bobby");
        Gato miGato = new Gato("Whiskers");

        // Crear una instancia de Veterinario
        Veterinario veterinario = new Veterinario();

        // Utilizar el polimorfismo para tratar perros y gatos con el mismo método
        veterinario.Curar(miPerro);
        veterinario.Curar(miGato);
    }
}
