using BuilderDesignPatternSample.Builders.Contracts;

namespace BuilderDesignPatternSample.Directors;

public class ComputerShop
{
    public void AssembleComputer(ComputerBuilder builder)
    {
        builder
            .SetCPU("High Performance CPU")
            .SetRAM("16 GB DDR4")
            .SetHardDrive("1 TB SSD");
    }
}
