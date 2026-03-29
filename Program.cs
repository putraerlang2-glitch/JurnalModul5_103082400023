using JurnalModul5_103082400023;

// Menjalankan Fitur Penjumlahan
Penjumlahan hitung = new Penjumlahan();
double hasil = hitung.JumlahTigaAngka<double>(10.0, 30.0, 82.4);
Console.WriteLine("Hasil penjumlahan: " + hasil);

Console.WriteLine(); 

SimpleDataBase<int> db = new SimpleDataBase<int>();
db.AddNewData(12);
db.AddNewData(34);
db.AddNewData(56);
db.PrintAllData();