using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models
{
    [TableName("Hozzavalo")]
    [PrimaryKey(nameof(HozzavaloSK), AutoIncrement = true)]
    [Scope("ModuleId")]

    public class Hozzavalo
    {
        public int HozzavaloSK { get; set; }
        public string HozzavaloNev { get; set; }
        public int ReceptFK { get; set; }
        public int ProductFK { get; set; }


    }
}