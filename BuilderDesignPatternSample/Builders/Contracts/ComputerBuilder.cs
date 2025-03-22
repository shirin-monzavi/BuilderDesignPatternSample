using BuilderDesignPatternSample.Products;

namespace BuilderDesignPatternSample.Builders.Contracts;

public abstract class ComputerBuilder
{
    public abstract ComputerBuilder SetCPU(string value);

    public abstract ComputerBuilder SetRAM(string value);

    public abstract ComputerBuilder SetHardDrive(string value);

    public abstract Computer GetComputer();
}
