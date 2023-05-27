using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models
{
    [TableName("Recept")]
    [PrimaryKey(nameof(ReceptSK), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class Recept
    {
        public int ReceptSK { get; set; }
        public string ReceptNev { get; set; }
        public string Leiras { get; set; }
    }

    
}
