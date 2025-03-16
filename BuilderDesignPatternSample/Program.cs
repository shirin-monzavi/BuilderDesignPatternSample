using BuilderDesignPatternSample.Builders.Contracts;
using BuilderDesignPatternSample.Builders.Implements;
using BuilderDesignPatternSample.Directors;
using BuilderDesignPatternSample.Products;

ComputerShop shop = new();
ComputerBuilder builder = new GamingComputerBuilder();

shop.AssembleComputer(builder);

Computer computer = builder.GetComputer();
computer.DisplaySpecifications();