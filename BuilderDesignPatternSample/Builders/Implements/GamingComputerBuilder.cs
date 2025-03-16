using BuilderDesignPatternSample.Builders.Contracts;

namespace BuilderDesignPatternSample.Builders.Implements;

public class GamingComputerBuilder : ComputerBuilder
{
    public override ComputerBuilder SetCPU(string value)
    {
        Computer.CPU = value;

        return this;
    }

    public override ComputerBuilder SetHardDrive(string value)
    {
        Computer.HardDrive = value;

        return this;
    }

    public override ComputerBuilder SetRAM(string value)
    {
        Computer.RAM = value;

        return this;
    }
}
