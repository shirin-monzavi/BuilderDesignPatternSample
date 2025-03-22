using BuilderDesignPatternSample.Builders.Contracts;
using BuilderDesignPatternSample.Products;

namespace BuilderDesignPatternSample.Builders.Implements;

public class GamingComputerBuilder : ComputerBuilder
{
    private readonly Computer _computer;

    public GamingComputerBuilder()
    {
        _computer = new Computer();
    }

    public override ComputerBuilder SetCPU(string value)
    {
        _computer.CPU = value;

        return this;
    }

    public override ComputerBuilder SetHardDrive(string value)
    {
        _computer.HardDrive = value;

        return this;
    }

    public override ComputerBuilder SetRAM(string value)
    {
        _computer.RAM = value;

        return this;
    }

    public override Computer GetComputer()
    {
        return _computer;
    }
}
