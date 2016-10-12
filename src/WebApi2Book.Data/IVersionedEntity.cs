namespace WebApi2Book.Data
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}
