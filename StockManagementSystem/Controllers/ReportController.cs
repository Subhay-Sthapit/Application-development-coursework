using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
   
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockListReport()
        {
            List<ProductStockViewModel> lstData = new List<ProductStockViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {

                command.CommandText = "SELECT p.Id as ProductId,ProductName as ProductName,ps.Quantity from Product p inner join ProductStock ps on p.Id=ps.ProductId";
                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {

                    ProductStockViewModel data;
                    while (result.Read())
                    {
                        data = new ProductStockViewModel();
                        data.ProductId = int.Parse(result.GetString(0));
                        data.ProductName = result.GetString(1);
                        data.Quantity = int.Parse(result.GetString(2));
                        lstData.Add(data);
                    }
                }
            }
            return View(lstData);
        }

    }
}
