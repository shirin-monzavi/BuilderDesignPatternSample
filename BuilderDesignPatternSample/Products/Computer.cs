#nullable disable
namespace BuilderDesignPatternSample.Products;

public class Computer
{
    #region Properties
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HardDrive { get; set; }
    public string GraphicsCard { get; set; }
    public string SoundCard { get; set; }
    #endregion

    #region Public Method
    public void DisplaySpecifications()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Hard Drive: {HardDrive}");
        Console.WriteLine($"Graphics Card: {GraphicsCard ?? "Not present"}");
        Console.WriteLine($"Sound Card: {SoundCard ?? "Not present"}");
    }
    #endregion
}
