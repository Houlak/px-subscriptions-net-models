namespace Goova.Subscriptions.Models.Models.Slack
{
    public class SlackNotification
    {
        public string Text { get; set; }

        public SlackNotification(string Text)
        {
            this.Text = Text;
        }
    }
}
