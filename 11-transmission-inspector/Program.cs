string transmission = "T##S S#O#LD B# S#V#N";
int interferenceCount = 0;

foreach (char d in transmission)
{
    if (d.ToString() == "#")
    {
        interferenceCount += 1;   
    }
}

Console.WriteLine($"Interference markers: {interferenceCount}");
