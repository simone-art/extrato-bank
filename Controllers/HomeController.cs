using ExtratoBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtratoBank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var extratoBankCliente = new ExtratoBankCliente() { ContaCliente = 987654, SaldoConta = 10500, Descricao = "Transferência de Rs 500 feita por Simone Santos, N° Conta 123456" }.Salvar();
            var extratoBankCliente1 = new ExtratoBankCliente() { ContaCliente = 987655, SaldoConta = 500, Descricao = "Transferência de Rs 500 feita por Manu Maia, N° Conta 456789" }.Salvar();
            var extratoBankCliente2 = new ExtratoBankCliente() { ContaCliente = 987656, SaldoConta = 2000, Descricao = "Transferência de Rs 800 feita por Regina Pitanga, N° Conta 567342" }.Salvar();
            
            var extratoBankClientes = ExtratoBankCliente.Lista(); 


            ViewBag.Title = "Home Page";
            ViewBag.ExtratoBankClientes = extratoBankClientes;
            return View();
        }
    }
}
