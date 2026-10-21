bool hasSuit = true;
int oxygenPercent = 1000;
int pressure = 95;
bool alarmActive = true;

bool canOpenAirlock = hasSuit == true && oxygenPercent >= 30 && pressure >= 90 && pressure <= 110 & alarmActive == false ? true : false;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
