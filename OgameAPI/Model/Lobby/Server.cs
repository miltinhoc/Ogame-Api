using System;

namespace OgameAPI.Model.Lobby
{
    internal class Server
    {
        public string language { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int playerCount { get; set; }
        public int playersOnline { get; set; }
        public DateTime opened { get; set; }
        public DateTime startDate { get; set; }
        public object endDate { get; set; }
        public int serverClosed { get; set; }
        public int prefered { get; set; }
        public int signupClosed { get; set; }
        public Settings settings { get; set; }
    }
}
