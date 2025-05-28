using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazOnline.Models
{
    public class CartItem
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public float PretUnit { get; set; }
        public int Cantitate { get; set; }
    }

}
