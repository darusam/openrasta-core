namespace OpenRasta.Hosting
{
    public interface IContextSession
    {
        object this[string key] { get; set; }

        int Timeout { get; set; }
    }
}
