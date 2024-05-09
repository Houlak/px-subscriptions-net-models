namespace Goova.Subscriptions.Models.Dtos.Slack
{
    public class SlackNotificationDto
    {
        public string Text { get; set; }

        public SlackNotificationDto(string Text)
        {
            this.Text = Text;
        }
    }
}
