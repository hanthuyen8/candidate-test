namespace Tests;

public class Animal
{
    public virtual string SaySomething()
    {
        return "...";
    }
}

public class Dog : Animal
{
}

public class Cat : Animal
{
    public new string SaySomething()
    {
        return "Meow";
    }
}