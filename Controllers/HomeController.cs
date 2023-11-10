using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using assignment2.Models;



namespace assignment2.Controllers
{
    public class HomeController : Controller
    {
        
        // 类字段，用于存储家具数据
        private List<Furniture> furnitureList = new List<Furniture>
        {
           new Furniture { Id = 1, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa1.jpg", Price = 1200.5m, Category = "Popular"},
                new Furniture { Id = 2, Name = "Sofa", Description = "A wooden sofa.", ImageUrl = "~/images/sofa2.jpg", Price = 3200.5m, Category = "Chinese" },
                new Furniture { Id = 3, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed1.jpg", Price = 1500m, Category = "Annatto" },
                new Furniture { Id = 4, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair1.jpg", Price = 300m, Category = "Chinese" },
                new Furniture { Id = 5, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed2.jpg", Price = 1800m, Category = "Popular" },
                new Furniture { Id = 6, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa3.jpg", Price = 2100m, Category = "Popular" },
                new Furniture { Id = 7, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed3.jpg", Price = 800m, Category = "Popular" },
                new Furniture { Id = 8, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa4.jpg", Price = 1800m, Category = "Popular" },
                new Furniture { Id = 9, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair2.jpg", Price = 300m, Category = "European" },
                new Furniture { Id = 10, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed4.jpg", Price = 2100m, Category = "Popular" },
                new Furniture { Id = 11, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa5.jpg", Price = 3100m, Category = "European" },
                new Furniture { Id = 12, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa6.jpg", Price = 2600m, Category = "Chinese" },
                new Furniture { Id = 13, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair3.jpg", Price = 500m, Category = "Chinese" },
                new Furniture { Id = 14, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed5.jpg", Price = 1100m, Category = "European" },
                new Furniture { Id = 15, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed6.jpg", Price = 1500m, Category = "Popular" },
                new Furniture { Id = 16, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed7.jpg", Price = 2100m, Category = "Annatto" },
                new Furniture { Id = 15, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed8.jpg", Price = 3000m, Category = "Chinese" },
                new Furniture { Id = 16, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed9.jpg", Price = 2200m, Category = "Popular" },
                new Furniture { Id = 17, Name = "Bed", Description = "A comfortable bed.", ImageUrl = "~/images/bed10.jpg", Price = 2100m, Category = "Annatto" },
                new Furniture { Id = 18, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa7.jpg", Price = 3000m, Category = "Popular" },
                new Furniture { Id = 19, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa8.jpg", Price = 3500m, Category = "Annatto" },
                new Furniture { Id = 20, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa9.jpg", Price = 4000m, Category = "European" },
                new Furniture { Id = 21, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa10.jpg", Price = 5000m, Category = "European" },
                new Furniture { Id = 22, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair4.jpg", Price = 500m, Category = "European" },
                new Furniture { Id = 23, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair5.jpg", Price = 600m, Category = "Annatto" },
                new Furniture { Id = 24, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair6.jpg", Price = 500m, Category = "Popular" },
                new Furniture { Id = 25, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair7.jpg", Price = 700m, Category = "Chinese" },
                new Furniture { Id = 26, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair8.jpg", Price = 500m, Category = "Chinese" },
                new Furniture { Id = 27, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair9.jpg", Price = 900m, Category = "Annatto" },
                new Furniture { Id = 28, Name = "Chair", Description = "A comfortable chair.", ImageUrl = "~/images/chair10.jpg", Price = 3100m, Category = "Popular" },
                new Furniture { Id = 29, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet1.jpg", Price = 1300m, Category = "European" },
                new Furniture { Id = 30, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet2.jpg", Price = 2000m, Category = "Popular" },
                new Furniture { Id = 31, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet3.jpg", Price = 2200m, Category = "Chinese" },
                new Furniture { Id = 32, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet4.jpg", Price = 1900m, Category = "Annatto" },
                new Furniture { Id = 33, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet5.jpg", Price = 2500m, Category = "Popular" },
                new Furniture { Id = 34, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet6.jpg", Price = 3000m, Category = "European" },
                new Furniture { Id = 35, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet7.jpg", Price = 2600m, Category = "Popular" },
                new Furniture { Id = 36, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet8.jpg", Price = 3100m, Category = "Annatto" },
                new Furniture { Id = 37, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet9.jpg", Price = 2800m, Category = "Annatto" },
                new Furniture { Id = 38, Name = "Cabinet", Description = "A usful cabinet.", ImageUrl = "~/images/cabinet10.jpg", Price = 3500m, Category = "Chinese" },
                new Furniture { Id = 39, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa11.jpg", Price = 5000m, Category = "Chinese" },
                new Furniture { Id = 40, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa12.jpg", Price = 5200m, Category = "Chinese" },
                new Furniture { Id = 41, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa13.jpg", Price = 4800m, Category = "Chinese" },
                new Furniture { Id = 42, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa14.jpg", Price = 4800m, Category = "European" },
                new Furniture { Id = 44, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa15.jpg", Price = 4800m, Category = "European" },
                new Furniture { Id = 45, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa16.jpg", Price = 6000m, Category = "European" },
                new Furniture { Id = 46, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa17.jpg", Price = 5900m, Category = "Chinese" },
                new Furniture { Id = 47, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa18.jpg", Price = 6200m, Category = "Chinese" },
                new Furniture { Id = 48, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa19.jpg", Price = 6000m, Category = "Annatto" },
                new Furniture { Id = 49, Name = "Sofa", Description = "A comfortable sofa.", ImageUrl = "~/images/sofa20.jpg", Price = 6300m, Category = "Annatto" },
                new Furniture { Id = 50, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table1.jpg", Price = 2200m, Category = "Annatto" },
                new Furniture { Id = 51, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table2.jpg", Price = 2600m, Category = "European" },
                new Furniture { Id = 52, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table3.jpg", Price = 3200m, Category = "European" },
                new Furniture { Id = 53, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table4.jpg", Price = 2400m, Category = "European" },
                new Furniture { Id = 54, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table5.jpg", Price = 1800m, Category = "Chinese" },
                new Furniture { Id = 55, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table6.jpg", Price = 3300m, Category = "Chinese" },
                new Furniture { Id = 56, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table7.jpg", Price = 3600m, Category = "Chinese" },
                new Furniture { Id = 57, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table8.jpg", Price = 4000m, Category = "Annatto" },
                new Furniture { Id = 58, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table9.jpg", Price = 4500m, Category = "Annatto" },
                new Furniture { Id = 59, Name = "Table", Description = "A comfortable table.", ImageUrl = "~/images/table10.jpg", Price = 4200m, Category = "Annatto" },

        };

        public ActionResult Search(int id)
        {
            var furnitureItem = furnitureList.FirstOrDefault(f => f.Id == id);
            if (furnitureItem == null)
            {
                // 没有找到家具，可以选择显示错误消息或重定向回首页
                return HttpNotFound(); // 或者使用 return RedirectToAction("Index");
            }

            // 找到家具，创建一个详情视图并传递家具信息
            return View("FurnitureDetails", furnitureItem);
        }

        public ActionResult Index()
        {
            // 首先按照 Id 进行排序，然后分组并选择每个组的第一个家具项
            var uniqueFurnitureList = furnitureList
                                        .OrderBy(f => f.Id)
                                        .GroupBy(f => f.Id)
                                        .Select(g => g.First())
                                        .Take(6) // 只取前 6 个
                                        .ToList();

            // 将筛选后的家具列表传递给视图
            return View(uniqueFurnitureList);
        }


        // HomeController.cs 中的 Category 方法
        public ActionResult Category(string category, int page = 1, int pageSize = 6) // pageSize 可以根据你的需求进行调整
        {
            if (string.IsNullOrEmpty(category))
            {
                return RedirectToAction("Index");
            }

            var categoryList = furnitureList.Where(f => f.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

            // 使用 Skip 和 Take 方法实现分页
            var pagedFurnitureList = categoryList
                .OrderBy(f => f.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            int totalItems = categoryList.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // 把分页数据传递给视图
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.Category = category;

            return View(pagedFurnitureList);
        }

        private static readonly List<string> FurnitureCategories = new List<string>
{
    "Chinese",
    "European",
    "Annatto",
    "Popular"
};

        public ActionResult Categories()
        {
            var categoryImageMap = new Dictionary<string, string>
    {
        { "Chinese", "Chinese.jpg" },
        { "European", "European.jpg" },
        { "Annatto", "Annatto.jpg" },
        { "Popular", "Popular.jpg" }
    };

            var categoriesWithImages = FurnitureCategories.Where(category => categoryImageMap.ContainsKey(category))
                                                          .Select(category => new CategoryViewModel
                                                          {
                                                              Name = category,
                                                              ImageUrl = $"/images/{categoryImageMap[category]}"
                                                          }).ToList();

            return View(categoriesWithImages);
        }

        public ActionResult Login()
        {
            return View();
        }

        // 处理用户登录
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // 简单的登录验证逻辑，这里仅作演示，实际应用中需要更安全的方式
            if (username == "1" && password == "1") // 假定的账号密码
            {
                // 设置一个简单的Session来标识用户已登录
                Session["IsLoggedIn"] = true;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginError = "Incorrect username or password";
                return View();
            }
        }

        // 添加一个登出的Action
        public ActionResult Logout()
        {
            Session["IsLoggedIn"] = null; // 清除登录状态
            return RedirectToAction("Index");
        }

        // 更新订单信息动作方法
        
        private static List<Order> orders = new List<Order>
{
    new Order { Id = 1, CustomerName = "admin", ProductName = "Sofa", Price = 1200.5m },
    new Order { Id = 2, CustomerName = "admin", ProductName = "Chair", Price = 300m }
    // 添加更多订单
};

        // 现有的OrderInfo方法中添加获取订单信息的逻辑
        public ActionResult OrderInfo()
        {
            // 检查用户是否登录
            if (Session["IsLoggedIn"] == null)
            {
                // 如果用户未登录，重定向到登录页面
                return RedirectToAction("Login");
            }

            // 如果用户已登录，获取订单信息
            var customerOrders = orders.Where(o => o.CustomerName == "admin").ToList(); // 这里硬编码为“admin”
            return View(customerOrders); // 将订单信息传递给视图
        }

        public ActionResult Contact()
        {
            // 你可以在这里添加一些 ViewBag 来传递额外的数据到视图，例如联系信息
            ViewBag.Address = "New Zealand";
            ViewBag.Phone = "16666666";
            ViewBag.Email = "123@email.com";
            return View();
        }
    }
  
}