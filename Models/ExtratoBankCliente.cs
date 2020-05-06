using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExtratoBank.Models
{
    public class ExtratoBankCliente
    {
        private static DBContext _db = new DBContext();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ContaCliente { get; set; }

        public double SaldoConta { get; set; }

        public string Descricao { get; set; }

        public static List<ExtratoBankCliente> Lista()
        {
            return _db.ExtratoBankClientes.ToList();
        }

        public bool Salvar()
        {
            try
            {
                _db.ExtratoBankClientes.Add(this);
                _db.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                throw error;
                
            }
        }
    }
}
