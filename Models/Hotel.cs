using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjRelMVCDotnetCore.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public Quarto Quarto { get; set; }

    }

}