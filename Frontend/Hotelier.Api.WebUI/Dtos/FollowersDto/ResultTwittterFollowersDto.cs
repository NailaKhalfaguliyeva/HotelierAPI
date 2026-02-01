namespace Hotelier.Api.WebUI.Dtos.FollowersDto
{
    public class ResultTwitterFollowersDto
    {
        public string username { get; set; }
        public int followersCount { get; set; }
        public int friendsCount { get; set; }
        public bool verified { get; set; }
        public string profileImageUrl { get; set; }
    }
}