using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QueerTrip.Models
{
    [Table("users")]
    public class user
    {       
        [Key]
        public int Id {get;set;}
        [ForeignKey("Id_Trip")]
        [DataType(DataType.Text)]
        public string ? Nome {get;set;}
        [DataType(DataType.Text)]
        public string? Partida {get;set;}
        [DataType(DataType.Text)]
        public int Destino{get;set;}
        [DataType(DataType.DateTime)]
        public int Checkin{get;set;}
        public int Checkout{get;set;}
    }
        
}