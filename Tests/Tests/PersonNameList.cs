namespace Tests;

internal interface IPerson
{
    public string Name { get; }
}

// === CODE IMPLEMENTATION ===

internal class PersonBuilder
{
    public IPerson CreatePerson(string name)
    {
        return new Person(name);
    }

    private class Person(string name) : IPerson
    {
        public string Name => name;
    }
}