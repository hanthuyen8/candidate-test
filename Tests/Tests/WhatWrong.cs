namespace Tests;

/**
 * Yêu cầu:
 * - Không được chỉnh sửa Code Test
 * - Chỉ được phép sửa Code Implement sao cho thoả mãn bài Test.
 */
public class WhatWrong
{
    [Test]
    public void WhatWrong1()
    {
        const string incomesData = """
                                   1.0
                                   2.0
                                   3.0
                                   4.0
                                   5.0
                                   6.0
                                   7.0
                                   8.0
                                   9,0
                                   """;
        var data = incomesData.Split('\n');
        var incomes = data.Select(Calculator.ParseFloat);
        var totalIncome = incomes.Sum();

        // Tổng số phải bằng 45
        Assert.That(totalIncome, Is.EqualTo(45.0f));
    }

    [Test]
    public void WhatWrong2()
    {
        int[] numbers = [11, 37, 45, 23, 9, 12];
        var halfSum = Calculator.Calculate(numbers);

        // Tổng số phải bằng 68.5
        Assert.That(halfSum, Is.EqualTo(68.5f));
    }

    [Test]
    public void WhatWrong3()
    {
        var builder = new PersonBuilder();
        var nameList = new HashSet<IPerson>
        {
            builder.CreatePerson("Alice"),
            builder.CreatePerson("Bob"),
            builder.CreatePerson("Charlie"),
            builder.CreatePerson("Alice")
        };

        // Không cho phép tên trùng lặp. Cho nên kết quả phải bằng 3
        Assert.That(nameList, Has.Count.EqualTo(3));
    }
    
    [Test]
    public void WhatWrong4()
    {
        var dictionary = new Dictionary<string, Animal>
        {
            { "Animal", new Animal() },
            { "Dog", new Dog() },
            { "Cat", new Cat() },
        };
        
        Assert.Multiple(() =>
        {
            Assert.That(dictionary["Animal"].SaySomething(), Is.EqualTo("..."));
            Assert.That(dictionary["Dog"].SaySomething(), Is.EqualTo("Woof"));
            Assert.That(dictionary["Cat"].SaySomething(), Is.EqualTo("Meow"));
        });
    }

    [Test]
    public void WhatWrong5()
    {
        var processor = new Machine();
        var result = processor.GetOutput("Hello");

        // Output phải là: [ROBOT_3] [ROBOT_2] [ROBOT_1] Hello
        Assert.That(result, Is.EqualTo("[ROBOT_3] [ROBOT_2] [ROBOT_1] Hello"));
    }
}