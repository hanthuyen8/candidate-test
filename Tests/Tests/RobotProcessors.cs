namespace Tests;

public interface IMachine
{
    public string GetOutput(string input);
}

public class Machine : IMachine
{
    private IMachine? _processor;

    public string GetOutput(string input)
    {
        _processor ??= new Robot1(this);
        return _processor.GetOutput(input);
    }
}

internal class Robot1(IMachine proxy) : IMachine
{
    private readonly IMachine _processor = new Robot2(proxy);

    public string GetOutput(string input)
    {
        return _processor.GetOutput($"[ROBOT_1] {input}");
    }
}

internal class Robot2(IMachine proxy) : IMachine
{
    private readonly IMachine _processor = new Robot3(proxy);

    public string GetOutput(string input)
    {
        return _processor.GetOutput($"[ROBOT_2] {input}");
    }
}

internal class Robot3(IMachine proxy) : IMachine
{
    public string GetOutput(string input)
    {
        return proxy.GetOutput($"[ROBOT_3] {input}");
    }
}