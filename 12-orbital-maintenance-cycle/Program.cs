for (int cycle = 1; cycle <= 30; cycle++)
{
    string result = "";
    
    if (cycle % 4 == 0 && cycle % 6 == 0)
    {
        result = "FULL SERVICE";
    }
    else if (cycle % 4 == 0)
    {
        result = "FILTER CHECK";
    }
    else if (cycle % 6 == 0)
    {
        result = "THRUSTER CHECK";
    }
    else
    {
        result = cycle.ToString();
    }


    Console.WriteLine(result);
}
