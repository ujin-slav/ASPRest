using Catalog.Entities;
using Catalog.ItemRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ASPRest.Controllers;

[ApiController]
[Route("items")]
public class itemController : ControllerBase
{
    private readonly IItemRepository repository;

    public itemController(IItemRepository repository) {
        this.repository = repository;
    }

    [HttpGet]
    public IEnumerable<item> GetItems(){
        return  repository.GetItems();
    }

    [HttpGet("{id}")]
    public ActionResult<item> GetItem(Guid id){
        var item = repository.GetItem(id);
        if(item is null){
            return NotFound();
        }
        return Ok(item);
    }
}

