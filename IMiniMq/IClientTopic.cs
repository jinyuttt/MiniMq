namespace IMiniMq
{
    public interface IClientTopic
    {
        public bool Subscribe(string topic);

        public bool Publish(string topic, byte[] data);
    }
}
