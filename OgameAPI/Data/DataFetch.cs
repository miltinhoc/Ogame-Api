using System.Net;
using OgameAPI.Xml;
using OgameAPI.Utils;

namespace OgameAPI.Data
{
    public class DataFetch
    {
        public T Get<T>(int universeNumber, string communityLanguage)
        {
            using (WebClient wc = new WebClient())
            {
                string xml = wc.DownloadString(Url.BuildUrl<T>(universeNumber, communityLanguage));
                return SerializeXml<T>(xml);
            }
        }

        public T Get<T>(int universeNumber, string communityLanguage, int playerId)
        {
            using (WebClient wc = new WebClient())
            {
                string xml = wc.DownloadString(Url.BuildUrl<T>(universeNumber, communityLanguage, playerId));
                return SerializeXml<T>(xml);
            }
        }

        public T Get<T>(int universeNumber, string communityLanguage, Highscore_Category catergory, Highscore_Type type)
        {
            using (WebClient wc = new WebClient())
            {
                string xml = wc.DownloadString(Url.BuildUrl<T>(universeNumber, communityLanguage, (int)catergory, (int)type));
                return SerializeXml<T>(xml);
            }
        }

        private T SerializeXml<T>(string xml) => GenericXmlSerializer.Serialize<T>(xml);
    }

    public enum Highscore_Type
    {
        TOTAL = 0,
        ECONOMY = 1,
        RESEARCH = 2,
        MILITARY = 3,
        MILITARY_LOST = 4,
        MILITARY_BUILT = 5,
        MILITARY_DESTROYED = 6,
        HONOR = 7
    }

    public enum Highscore_Category
    {
        PLAYER = 1,
        //ALLIANCE = 2
    }
}
