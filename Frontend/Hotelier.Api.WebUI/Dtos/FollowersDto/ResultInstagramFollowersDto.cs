using Newtonsoft.Json;

namespace Hotelier.Api.WebUI.Dtos.FollowersDto
{
    public class ResultInstagramFollowersDto
    {
        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }

        [JsonProperty("following_count")]
        public int FollowingCount { get; set; }
    }

    public class InstagramRootDto
    {
        [JsonProperty("user")]
        public ResultInstagramFollowersDto User { get; set; }
    }
}
