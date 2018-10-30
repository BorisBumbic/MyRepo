using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using XXXX.Models.RequestAllBoards;
using XXXX.Models.RequestLists;

namespace Onlinestore.Viewservice
{
    public class TrelloServices
    {
        string _devkey;
        string _token;
        HttpServicez _httpService = new HttpServicez(); 

        public TrelloServices(string devkey, string token)
        {
            _devkey = devkey;
            _token = token;
        }

        public async Task<List<TrelloRoot>> GetAllBoards()
        {
            string url = $"https://api.trello.com/1/members/borisbumbic/boards?key={_devkey}&token={_token}";
            string result = await _httpService.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloRoot>>(result);
        }

        internal async Task<List<TrelloList>> GetAllListsForBoards(string id)
        {
            string url = $"https://api.trello.com/1/boards/{id}/lists?key={_devkey}&token={_token}";
            string result = await _httpService.Get(url);
            return JsonConvert.DeserializeObject<List<TrelloList>>(result);
        }

        internal async Task CreateAcardOnAlist(string trelloListId, string name, string description)
        {
            string url = $"https://api.trello.com/.......";
            string result = await _httpService.Post(url);
        }
    }
}