using Singleton_DP;

Console.WriteLine("=== Singleton Demo ===");

// Static Property
var s1 = GCard.SingletonObj;
var s2 = GCard.SingletonObj;

Console.WriteLine($"Property Same Instance: {ReferenceEquals(s1, s2)}");
Console.WriteLine($"Data: {s1.Data}");

// Static Method
var m1 = GCard.GetInstance();
var m2 = GCard.GetInstance();

Console.WriteLine($"Method Same Instance: {ReferenceEquals(m1, m2)}");
Console.WriteLine($"Data: {m1.Data}");
