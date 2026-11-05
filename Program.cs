Console.Write("5000: ");
int tarifPerjam = int.Parse(Console.ReadLine());

Console.Write(" 3 : ");
int lamaPenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifPerjam * lamaPenggunaan;

Console.WriteLine($"total Biaya = {totalBiaya}");