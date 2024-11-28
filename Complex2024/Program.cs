using Complex2024;
var z1 = new Complex();
var z3 = new Complex(7, -2);
var z2 = new Complex()
{
    Re = 3,
    Im = 4
};

Console.WriteLine(z1);
Console.WriteLine(z1.AbsoluteValue);
Console.WriteLine(z1.Conjugate);
Console.WriteLine(z2);
Console.WriteLine(z2.AbsoluteValue);
Console.WriteLine(z2.Conjugate);
Console.WriteLine(z3);
Console.WriteLine(z3.AbsoluteValue);
Console.WriteLine(z3.Conjugate);
Console.WriteLine(z3.Sum(z3.Conjugate));
Console.WriteLine(z3.Diff(z3.Conjugate));

var z4 = new Complex(1, -2);
Complex z5 = new (3, 1);
Console.WriteLine(z4.Quotient(z5));
Console.WriteLine(z4.Product(z5));
z4.ProductAssign(z5);
Console.WriteLine(z4);