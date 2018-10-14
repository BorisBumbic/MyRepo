using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onlinestore.Viewservice;
using XXXX.Models.RequestAllBoards;
using XXXX.Models.RequestLists;

namespace Onlinestore.Controllers
{
    public class TrelloController : Controller
    {
        TrelloServices _trelloService;

        public async Task<IActionResult> Index()
        {
            List<TrelloRoot> result = await _trelloService.GetAllBoards();
            return View(result);
        }

        public TrelloController()
        {
            _trelloService = new TrelloServices("ace459047a079e34f4ca49642fba1ef2", "dc4c5767f06f49eea18799cd2f6a9666d9286dd953dedaccdba49245caa42bb7");
        }

        public async Task<IActionResult> Board(string id)
        {
            //return Ok("Du vill se listor för boarden" + id);
            List<TrelloList> result = await _trelloService.GetAllListsForBoards(id);
            return View(result);
        }

        public IActionResult AddCardForm(string id)
        {
            var vm = new AddTrelloPost
            {
                TrelloListId = id
            };
            return View("AddCardForm", vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddCardForm(AddTrelloPost post)
        {
            await _trelloService.CreateAcardOnAlist(post.TrelloListId, post.Name, post.Description);
            return View("AddCardFormResponse", post);
        }
    }

    public class AddTrelloPost
    {
        public string Name { get; set; }
        public string TrelloListId { get; set; }
        public string Description { get; set; }
    }
}