using BuilderDesignPatternSample.Products;

namespace BuilderDesignPatternSample.Builders.Contracts;

public abstract class ComputerBuilder
{
    protected Computer Computer { get; private set; } = new Computer();

    public abstract ComputerBuilder SetCPU(string value);

    public abstract ComputerBuilder SetRAM(string value);

    public abstract ComputerBuilder SetHardDrive(string value);

    public Computer GetComputer() => Computer;
}
