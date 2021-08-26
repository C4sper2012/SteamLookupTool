using Newtonsoft.Json;
using SteamLookupToolModels.Models.Enums;
using System.Collections.Generic;

namespace SteamLookupToolModels.Models
{
    public class UserModel
    {
        [JsonProperty("steamid")]
        public string Steamid { get; set; }

        [JsonProperty("communityvisibilitystate")]
        public int Communityvisibilitystate { get; set; }

        [JsonProperty("profilestate")]
        public int Profilestate { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("commentpermission")]
        public int Commentpermission { get; set; }

        [JsonProperty("profileurl")]
        public string Profileurl { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatarmedium")]
        public string Avatarmedium { get; set; }

        [JsonProperty("avatarfull")]
        public string Avatarfull { get; set; }

        [JsonProperty("avatarhash")]
        public string Avatarhash { get; set; }

        [JsonProperty("lastlogoff")]
        public string Lastlogoff { get; set; }

        [JsonProperty("personastate")]
        public PersonaState Personastate { get; set; }

        [JsonProperty("primaryclanid")]
        public string Primaryclanid { get; set; }

        [JsonProperty("timecreated")]
        public string Timecreated { get; set; }

        [JsonProperty("personastateflags")]
        public int Personastateflags { get; set; }

        [JsonProperty("gameextrainfo")]
        public string Gameextrainfo { get; set; }

        [JsonProperty("gameid")]
        public string Gameid { get; set; }
    }

    public class Response
    {
        [JsonProperty("players")]
        public List<UserModel> Users { get; set; }
    }

    public class Root
    {
        [JsonProperty("response")]
        public Response Response { get; set; }
    }
}