using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SteamLookupToolLibrary.Models;
using SteamLookupToolLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Net;

namespace SteamLookupTool.Pages
{
    public class UserModel : PageModel
    {
        [BindProperty]
        public string Key { get; set; }
        private Root ReponseUsers { get; set; }
        public List<User> Users { get; set; }

        [HttpGet]
        public void OnGet()
        {
            Key = Request.Cookies["key"];
            string name = Request.Cookies["user"];
            WebClient client = new WebClient();
            var response = client.DownloadString($"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={Key}&steamids={name}");
            ReponseUsers = JsonConvert.DeserializeObject<Root>(response);
            client.Dispose();
            Users = ReponseUsers.Response.Users;
            SetupUserDates();
        }

        private void SetupUserDates()
        {
            foreach (User user in Users)
            {
                user.Timecreated = new DateTime(1970, 1, 1).AddSeconds(Convert.ToDouble(user.Timecreated)).ToString();
                user.Lastlogoff = new DateTime(1970, 1, 1).AddSeconds(Convert.ToDouble(user.Lastlogoff)).ToString();

            }
        }
    }
}