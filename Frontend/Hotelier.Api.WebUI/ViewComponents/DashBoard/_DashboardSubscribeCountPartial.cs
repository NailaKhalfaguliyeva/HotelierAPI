using Hotelier.Api.WebUI.Dtos.FollowersDto;
using Hotelier.Api.WebUI.Models.Dashboard;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelier.Api.WebUI.ViewComponents.DashBoard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new DashboardFollowersViewModel();

            using var client = new HttpClient();

            // ===================== INSTAGRAM =====================
            var instagramRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-scraper-20224.p.rapidapi.com/ig/info_username/?user=murattycedag"),
                Headers =
                {
                    { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
                    { "x-rapidapi-host", "instagram-scraper-20224.p.rapidapi.com" }
                }
            };

            var instaResponse = await client.SendAsync(instagramRequest);
            instaResponse.EnsureSuccessStatusCode();

            var instaBody = await instaResponse.Content.ReadAsStringAsync();

            var instaRoot = JsonConvert.DeserializeObject<InstagramRootDto>(instaBody);

            model.InstagramFollowers = instaRoot.User.FollowerCount;
            model.InstagramFollowing = instaRoot.User.FollowingCount;

            // ===================== TWITTER =====================
            var twitterRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter-followers.p.rapidapi.com/MurattYucedag/following?page=1"),
                Headers =
                {
                    { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
                    { "x-rapidapi-host", "twitter-followers.p.rapidapi.com" }
                }
            };

            var twitterResponse = await client.SendAsync(twitterRequest);
            twitterResponse.EnsureSuccessStatusCode();

            var twitterBody = await twitterResponse.Content.ReadAsStringAsync();

            var twitterUsers =
                JsonConvert.DeserializeObject<List<ResultTwitterFollowersDto>>(twitterBody);

            model.TwitterFollowing = twitterUsers.Count;
            model.TwitterFollowers = twitterUsers.Max(x => x.followersCount);

            return View(model);            
        }

        //    List<ResultInstagramFollowersDto> resultInstagramFollowersDtos=new List<ResultInstagramFollowersDto>();
        //    public async Task<IViewComponentResult> InvokeAsync()
        //    {
        //        var client = new HttpClient();
        //        var request = new HttpRequestMessage
        //        {
        //            Method = HttpMethod.Get,
        //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/murattycedag"),
        //            Headers =
        //{
        //    { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
        //    { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
        //},
        //        };
        //        using (var response = await client.SendAsync(request))
        //        {
        //            response.EnsureSuccessStatusCode();
        //            var body = await response.Content.ReadAsStringAsync();
        //            ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
        //            ViewBag.v1 = resultInstagramFollowersDtos.followers;
        //            ViewBag.v2 = resultInstagramFollowersDtos.following;
        //            return View(resultInstagramFollowersDtos);
        //        }

        //        var client2 = new HttpClient();
        //        var request2 = new HttpRequestMessage
        //        {
        //            Method = HttpMethod.Get,
        //            RequestUri = new Uri("https://twitter-followers.p.rapidapi.com/MurattYucedag/profile"),
        //            Headers =
        //{
        //    { "x-rapidapi-key", "5aef0cb932msh58c539ed1ec8e60p12e54bjsn25909f1139d1" },
        //    { "x-rapidapi-host", "twitter-followers.p.rapidapi.com" },
        //},
        //        };
        //        using (var response2 = await client2.SendAsync(request2))
        //        {
        //            response2.EnsureSuccessStatusCode();
        //            var body2 = await response2.Content.ReadAsStringAsync();
        //            ResultTwittterFollowersDto resultTwittterFollowersDto=JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
        //           // ViewBag.v3 = resultTwittterFollowersDto.
        //           //ViewBag.v4 = resultTwittterFollowersDto.
        //        }
        //        return View();
        //    }
    }
}