int energy = -130;
string classification = "";

if (energy < 20)
{
    classification = "Dormant";
}
else if (energy >= 20 && energy < 50)
{
    classification = "Stable";
}
else if (energy >= 50 && energy < 80)
{
    classification = "Unstable";
}
else if (energy >= 80)
{
    classification = "Critical";
}

Console.WriteLine($"Classification: {classification}");
