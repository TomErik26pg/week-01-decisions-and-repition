int charge = 50;
int drainPerCycle = 11;

while (charge > 0)
{
    Console.WriteLine("Charge is at " + charge.ToString() + "%");
    charge = charge - drainPerCycle;
}

Console.WriteLine("Power cell offline.");
