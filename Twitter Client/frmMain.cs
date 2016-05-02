using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TweetSharp;
using Hammock;

namespace Twitter_Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Consumer key and secret
        public static string consumerKey = TwitterClient.ConsumerKey;
        public static string consumerSecret = TwitterClient.ConsumerSecret;

        // Access token and token secret
        public static string aToken = TwitterClient.AccessToken;
        public static string aTokenSecret = TwitterClient.AccessTokenSecret;

        // Initialize twitter service and get request token
        public static TwitterService service = new TwitterService(consumerKey, consumerSecret);
        public static OAuthRequestToken requestToken = service.GetRequestToken();

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            // Clear text and set forecolor to
            // default control text color when search box is focused
            if (txtSearch.Text == "Find People")
            {
                txtSearch.ForeColor = SystemColors.ControlText;
                txtSearch.Text = ""; 
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            // Reassign default properties to search text box if left empty
            if (txtSearch.Text == "")
            {
                txtSearch.ForeColor = SystemColors.InactiveCaption;
                txtSearch.Text = "Find People";
            }
        }

       private void txtPost_TextChanged(object sender, EventArgs e)                                // 140 character limit indication
        {
            int charsLeft = 140 - txtPost.TextLength;                                               // Number of characters to limit
            lblCharsLeft.Text = Convert.ToString(charsLeft);                                        // Display number of characters left

            if (charsLeft < 0)                                                                      //// If (limit is exceeded):
            {
                lblCharsLeft.ForeColor = Color.Red;                                                 // Display negative numbers in red
                btnPublish.Enabled = false;                                                         // Disable 'Publish' button
            }
            else                                                                                    //// Else:
            {
                lblCharsLeft.ForeColor = SystemColors.ControlText;                                  // Set text color to default
                btnPublish.Enabled = true;                                                          // Enable 'Publish' button
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // Sign Out button closes form
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                string tweetString = txtPost.Text.ToString();                                           // Get tweet string from text box

                // Authenticate service
                service.AuthenticateWith(aToken, aTokenSecret);

                var tweet = service.SendTweet(new SendTweetOptions { Status = tweetString });           // Post tweet
                txtPost.Clear();                                                                        // Clear text box
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    Ex.Message,
                    Ex.GetType().ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "" && txtSearch.Text != "Find People")
                {
                    string screenName = txtSearch.Text.ToString();                                  // Define screenName variable

                    if (screenName.StartsWith("@"))
                        screenName = screenName.TrimStart('@');                                     // Exclude begining '@' if included

                    if (IsValidUsename(screenName))                                                 // Validate username (screenName)
                    {
                        // Authenticate service
                        service.AuthenticateWith(aToken, aTokenSecret);

                        // Get friends (following) list
                        TwitterCursorList<TwitterUser> friends = service.ListFriends(
                            new ListFriendsOptions { ScreenName = "2901TwitProj" });
                        
                        // Get first user object associated with searched screen name (sorted by relevance)
                        IEnumerable<TwitterUser> users = service.SearchForUser(
                            new SearchForUserOptions { Q = screenName, Count = 1 });

                        foreach (TwitterUser user in users)
                        {
                            if (friends.Contains<TwitterUser>(user))
                            {
                                // Request to unfollow if already following (user is in friends list)
                                DialogResult unfollowUser = MessageBox.Show(
                                    "You are currently following @"
                                    + user.ScreenName + ".\n"
                                    + "Would you like to unfollow them?",
                                    user.ScreenName,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.None,
                                    MessageBoxDefaultButton.Button2);

                                // unfollow if user clicks 'Yes'
                                if (unfollowUser == DialogResult.Yes)
                                    service.UnfollowUser(
                                        new UnfollowUserOptions { ScreenName = user.ScreenName });
                            }
                            else
                            {
                                // Request to follow if not already following (user is not in friends list)
                                DialogResult followUser = MessageBox.Show(
                                    "You are not currently following @"
                                    + user.ScreenName + ".\n"
                                    + "Would you like to follow them?",
                                    user.ScreenName,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.None,
                                    MessageBoxDefaultButton.Button2);

                                // follow if user clicks 'Yes'
                                if (followUser == DialogResult.Yes)
                                    service.FollowUser(
                                        new FollowUserOptions { ScreenName = user.ScreenName });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch unhandled exceptions
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }
        }

        public bool IsValidUsename(string username)
        {
            // Overal data validation
            return
                IsCorrectFormat(username) &&
                IsCorrectLength(username);
        }

        public bool IsCorrectLength(string text)
        {
            // Twitter handles (i.e. usernames/screen names)
            // cannot be longer than 15 characters
            if (text.Length > 15)
            {
                MessageBox.Show(
                    "Username may not exceed 15 characters.",
                    "Entry Error");
                return false;
            }
            else
                return true;
        }

        public bool IsCorrectFormat(string text)
        {
            // Username must only be composed of letters and digits
            char[] charArray = text.ToCharArray();
            foreach (char character in charArray)
            {
                if (!(char.IsLetterOrDigit(character)))
                {
                    MessageBox.Show(
                        "Username can only contain letters and numbers.",
                        "Entry Error");
                    return false;
                }
            }
            return true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set search box default properties
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Text = "Find People";

            // Authenticate service
            service.AuthenticateWith(aToken, aTokenSecret);

            // Instantiate timeline enumerable
            IEnumerable<TwitterStatus> timeline = service.ListTweetsOnHomeTimeline(
                new ListTweetsOnHomeTimelineOptions());

            // Instantiate mentions enumerable
            IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(
                new ListTweetsMentioningMeOptions());

            lboTimeline.Items.Clear();                                                              // Clear timeline listbox before adding items
            lboMentions.Items.Clear();                                                              // Clear mentions listbox before adding items

            if (timeline == null)
                lboTimeline.Items.Add("There are no tweets on your timeline.");                     // Display message if timeline is empty
            else
            {
                foreach (TwitterStatus tweet in timeline)
                {
                    // Display timeline in timeline listbox
                    lboTimeline.Items.Add("@" + tweet.User.ScreenName);                             // Display screen name of tweet author
                    lboTimeline.Items.Add(tweet.Text);                                              // Display tweet on new line
                    lboTimeline.Items.Add("");                                                      // Separate tweets with new line
                }
            }

            if (mentions == null)
                lboMentions.Items.Add("You have no mentions.");                                     // Display message if no mentions
            else
            {
                foreach (TwitterStatus tweet in mentions)
                {
                    // Display mentions in mentions listbox
                    lboMentions.Items.Add(String.Format(
                        "@{0} said: {1}", tweet.User.ScreenName, tweet.Text));                      // Display author screen name followes by tweet
                    lboMentions.Items.Add("");                                                      // Sepaprate tweets with new line
                }
            }
        }
    }
}
