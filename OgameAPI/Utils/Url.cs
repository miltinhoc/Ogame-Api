using System;
using OgameAPI.Constant;

namespace OgameAPI.Utils
{
    internal class Url
    {
        public static string BuildUrl<T>(int universeNumber, string communityLanguage)
        {
            string endpoint = GetEndpoint<T>();
            return $"{EndpointConfiguration.PROTOCOL}{string.Format(EndpointConfiguration.BASE_URL, universeNumber, communityLanguage)}{endpoint}";
        }

        // used for the playerData api endpoint
        public static string BuildUrl<T>(int universeNumber, string communityLanguage, int playerId)
        {
            string endpoint = GetEndpoint<T>();
            return $"{EndpointConfiguration.PROTOCOL}{string.Format(EndpointConfiguration.BASE_URL, universeNumber, communityLanguage)}{string.Format(endpoint, playerId)}";
        }

        // used for the highscore api endpoint
        public static string BuildUrl<T>(int universeNumber, string communityLanguage, int category, int type)
        {
            string endpoint = GetEndpoint<T>();
            return $"{EndpointConfiguration.PROTOCOL}{string.Format(EndpointConfiguration.BASE_URL, universeNumber, communityLanguage)}{string.Format(endpoint, category, type)}";
        }

        private static string GetEndpoint<T>()
        {
            switch (typeof(T).Name)
            {
                case nameof(Model.Alliances):
                    return EndpointConfiguration.ALLIANCES;

                case nameof(Model.Highscore):
                    return EndpointConfiguration.HIGHSCORE;

                case nameof(Model.Localization):
                    return EndpointConfiguration.LOCALIZATION;

                case nameof(Model.PlayerData):
                    return EndpointConfiguration.PLAYER_DATA;

                case nameof(Model.Players):
                    return EndpointConfiguration.PLAYERS;

                case nameof(Model.ServerData):
                    return EndpointConfiguration.SERVER_DATA;

                case nameof(Model.Universe):
                    return EndpointConfiguration.UNIVERSE;

                case nameof(Model.Universes):
                    return EndpointConfiguration.UNIVERSES;

                default:
                    throw new Exception("Type not found");
            }
        }
    }
}
