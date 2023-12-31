using EFDemo.DataAccessLibrary.DataAccess;
using EFDemo.DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace EFDemo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleDbContext _peopleDbContext;

        public IndexModel(ILogger<IndexModel> logger, PeopleDbContext peopleDbContext)
        {
            _logger = logger;
            _peopleDbContext = peopleDbContext;

        }

        public void OnGet()
        {
            //LoadSampleData();
            var people = _peopleDbContext.People
                    .Include(a => a.Addresses)
                    .Include(e => e.Emails)
                    .ToList();
        }
        private void LoadSampleData()
        {
            //if (_peopleDbContext.People.Count() == 0)
            //{
            //    string file = System.IO.File.ReadAllText("MOCK_DATA.json");
            //    var people = JsonSerializer.Deserialize<List<Person>>(file);
            //    _peopleDbContext.People.AddRange(people);
            //    _peopleDbContext.SaveChanges();
            //}
        }
        
    }
}