Console.Write("masukan tarifPerjam: ");
int tarifPerjam = int.Parse(Console.ReadLine());

Console.Write(" masukan lamaPenggunaan: ");
int lamaPenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifPerjam * lamaPenggunaan;

Console.WriteLine($"total Biaya = {totalBiaya}");