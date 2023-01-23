var m1 = new Measurement();
Console.WriteLine(m1);

var m2 = default(Measurement);
Console.WriteLine(m2);

var ms = new Measurement[2];
Console.WriteLine(string.Join(", ", ms));

public struct Measurement
{
    public Measurement()
    {
        Value = Double.NaN;
        Description = "Undefined";
    }
    
    public double Value { get; init; }
    public string Description { get; init; }

    public override string ToString()
        => $"{Value} ({Description})";
}