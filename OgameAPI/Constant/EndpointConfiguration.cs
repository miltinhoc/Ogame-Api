namespace OgameAPI.Constant
{
    internal class EndpointConfiguration
    {
        public static readonly string PROTOCOL = "https://";
        public static readonly string BASE_URL = "s{0}-{1}.ogame.gameforge.com/api/";

        public static readonly string ALLIANCES = "alliances.xml";
        public static readonly string PLAYERS = "players.xml";
        public static readonly string UNIVERSES = "universes.xml";
        public static readonly string UNIVERSE = "universe.xml";
        public static readonly string HIGHSCORE = "highscore.xml?category={0}&type={1}";
        public static readonly string PLAYER_DATA = "playerData.xml?id={0}";
        public static readonly string SERVER_DATA = "serverData.xml";
        public static readonly string LOCALIZATION = "localization.xml";
    }
}
