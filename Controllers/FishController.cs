using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Managerment_fish.Data; // Thay thế YourNamespace bằng namespace thực tế của bạn //dòng đã thay thế
using Microsoft.EntityFrameworkCore;

public class FishController : Controller
{
    private readonly ApplicationDbContext _context;

    public FishController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: /Fish
    public IActionResult Index()
    {
        // Thực hiện truy vấn SELECT để lấy danh sách cá từ cơ sở dữ liệu
        List<Fish> fishes = _context.Fishes.ToList(); // Hoặc _context.Fishes.AsQueryable() để sử dụng LINQ

        return View(fishes); // Trả về view với danh sách cá
    }
}
