using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul5_103082400023
{
    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;

            return a + b + c;
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(
                    "Data " + (i + 1) +
                    " berisi: " + storedData[i] +
                    ", disimpan pada waktu: " + inputDates[i]
                );
            }
        }
    }
}
