using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//ürünün birim fiyatı
        public int UnitsInStock { get; set; }//stok

        //CRUD / Create - Read - Update - Delete / ekle - oku - güncelle - sil
    }
}
