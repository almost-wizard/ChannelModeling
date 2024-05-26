namespace ChannelModeling.Objects.Data
{
    public interface IBinaryData
    {
        bool HasError { get; }

        int ErrorsCount { get; }

        double ErrorsRate { get; }
    }
}
