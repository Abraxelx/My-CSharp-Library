using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary
{
    public class MyLinq
    {
        /// <summary>
        /// GİRİLEN GENERIC TIPTEKİ LIST'IN TEK OLANLARINI DÖNER
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> OddNumbers(List<int> list)
        {
            var tekler = list.Where(tek => tek % 2 == 1);
            return tekler;
        }
        /// <summary>
        /// GİRİLEN GENERIC TIPTEKİ LIST'IN ÇİFT OLANLARINI DÖNER
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> EvenNumbers(List<int> list)
        {
            var ciftler = list.Where(cift => cift % 2 == 0);
            return ciftler;
        }
        /// <summary>
        /// GİRİLEN GENERIC TIPTEKİ LIST'IN Küçükten Büyüğe Sıralar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> Ascending(List<int> list)
        {
            var buyugesirala = list.Where(ktenbuyuk => ktenbuyuk > 0).OrderBy(ktenbuyuk => ktenbuyuk);

            return buyugesirala;
        }

        /// <summary>
        /// GİRİLEN GENERIC TIPTEKİ LIST'IN Büyükten Küçüğe Sıralar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> Descenting(List<int> list)
        {
            var kucugesirala = list.Where(btenkucuk => btenkucuk > 0).OrderByDescending(btenkucuk => btenkucuk);
            return kucugesirala;
        }

        /// <summary>
        /// Girilen String Listi Alfabetik Sıralamaya Sokar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> AscendingByCases(List<String> list)
        {
            var harfleriSirala = list.Where(ktenbuyuk => ktenbuyuk.Length > 0).OrderBy(z => z);
            return harfleriSirala;
        }


        /// <summary>
        ///  Girilen String Listi Alfabetik Sıralamanın Tersine Sokar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> DescentingByCases(List<String> list)
        {
            var harfleriSirala = list.Where(btenkucuk => btenkucuk.Length > 0).OrderByDescending(z => z);
            return harfleriSirala;
        }

        /// <summary>
        /// Girilen String Listi Harf Sayısına Göre Küçükten Büyüğe Sıralar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> AscendingByCasesLength(List<String> list)
        {
            var harflerinSayisiniSirala = list.OrderBy(ktenbuyuk => ktenbuyuk.Length);
            return harflerinSayisiniSirala;
        }

        /// <summary>
        /// Girilen String Listi Harf Sayısına Göre Büyükten Küçüğe Sıralar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> DescentingByCasesLength(List<String> list)
        {
            var harflerinSayisiniSirala = list.OrderByDescending(btenkucuk => btenkucuk.Length);
            return harflerinSayisiniSirala;
        }


        /// <summary>
        /// Girilen String Listin Elemanlarını Ters Çevirir
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> ReverseItems(List<String> list)
        {
           var reverselist = list.Select(z => new string (z.Reverse().ToArray()));
            return reverselist;
        }
        /// <summary>
        /// Girilen String Listin Eleman Sırasını Ters Çevir
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<String> ReverseList(List<String> list)
        {
            var reverselist = list.Where(z =>z.Length>0).Reverse();
            return reverselist;
        }
    }
}
