int cargoWeight = 600;
int maxWeight = 800;
int containerCount = 2;
int expectedContainers = 0;

bool isOverweight = cargoWeight > maxWeight ? true : false;
bool isExactlyAtLimit = cargoWeight == maxWeight ? true : false;
bool hasContainers = containerCount > 0 ? true : false;
bool countDiffersFromExpected = containerCount != expectedContainers ? true : false;

Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
