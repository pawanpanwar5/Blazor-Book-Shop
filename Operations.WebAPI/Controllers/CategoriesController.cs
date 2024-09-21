using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Operations.WebAPI.Models;

namespace Operations.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //Verb          FromQuery                           FromBody
        //HttpGet       inbuil types, complex types         NA
        //HttpPost      inbuil types                        complex types
        //HttpPut
        //HttpDelete



       // public static List<Category> categoriesList = new List<Category>();
        [HttpGet]
        public IActionResult GetCategories()
        {
            // //List<Category> categoriesList = new List<Category>();
            //if(categoriesList.Count == 0)
            //{
            //    categoriesList.Add(new Category { Id = 1, Name = "News" });
            //    categoriesList.Add(new Category { Id = 2, Name = "Media" });
            //    categoriesList.Add(new Category { Id = 3, Name = "Blog" });
            //}
            //return Ok(categoriesList);

            return Ok();
        }
        [HttpPost]
        public IActionResult PostCategories(Category category)
        {
           // categoriesList.Add(category);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutCategories(int id, Category category)
        {
            //var categoryFromList = categoriesList.FirstOrDefault(x=> x.Id==id);
            //categoryFromList.Id = category.Id;
            //categoryFromList.Name = category.Name;
            //return Ok(categoryFromList);

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategories(int id)
        {
            //var categoryFromList = categoriesList.FirstOrDefault(x => x.Id == id);
            //categoriesList.Remove(categoryFromList);
            return Ok();
        }
    }
}
