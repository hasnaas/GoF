using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class TwitterService
    {

        public List<Tweet> getTweets()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken("appKey", "secret");
            var accessToken = oauth.getAccessToken(requestToken);

            var twitterClient = new TwitterClient();
            return twitterClient.getRecentTweets(accessToken);
        }
    }
}
