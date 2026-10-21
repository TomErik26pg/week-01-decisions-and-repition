bool hasSuit = true;
int oxygenPercent = 1000;
int pressure = 95;
bool alarmActive = true;

/*- `hasSuit` er `true`
- `oxygenPercent` er minst `30`
- `pressure` er mellom `90` og `110`, inklusive
- `alarmActive` er `false`

Lag ett bool-uttrykk kalt `canOpenAirlock` og bruk deretter en `if/else` til å skrive `ACCESS GRANTED` eller `ACCESS DENIED`.

Endre én variabel om gangen for å kontrollere at hver regel faktisk påvirker resultatet.*/

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = hasSuit == true && oxygenPercent >= 30 && pressure >= 90 && pressure <= 110 & alarmActive == false ? true : false;


if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
