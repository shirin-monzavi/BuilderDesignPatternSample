using BuilderDesignPatternSample.Builders.Contracts;
using BuilderDesignPatternSample.Builders.Implements;
using BuilderDesignPatternSample.Directors;

ComputerShop shop = new();
ComputerBuilder builder = new GamingComputerBuilder();

shop.AssembleComputer(builder);

var computer = builder.GetComputer();
computer.DisplaySpecifications();