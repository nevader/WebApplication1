using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1;

[ApiController]
[Route("api/[controller]")]
public class AnimalController : ControllerBase
{
    private readonly string _connectionString = "Server=db-mssql16.pjwstk.edu.pl;Database=Test;User Id=Test;Password=Test;";
    
    [HttpGet]
    public IActionResult GetAnimals (string orderBy = "name")
    {
        var connection = new SqlConnection(_connectionString);
        var command = new SqlCommand($"SELECT * FROM Animals ORDER BY {orderBy}", connection);
        
    }
    
}