namespace Telegram.Bot.Types.ReplyMarkups;

/// <summary>
/// Upon receiving a <see cref="Message"/> with this object, Telegram clients will display a reply interface to the
/// user (act as if the user has selected the bot’s message and tapped 'Reply'). This can be extremely useful if you
/// want to create user-friendly step-by-step interfaces without having to sacrifice
/// <a href="https://core.telegram.org/bots#privacy-mode">privacy mode</a>.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ForceReplyMarkup : ReplyMarkupBase
{
    /// <summary>
    /// Shows reply interface to the user, as if they manually selected the bot’s message and tapped 'Reply'
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public bool ForceReply => true;

    /// <summary>
    /// Optional. The placeholder to be shown in the input field when the reply is active; 1-64 characters
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? InputFieldPlaceholder { get; set; }
}
