namespace Lab11
{
    public interface IFile : IDisposable
    {
        double GetSize();
        string GetPath();
        byte[] Show();
    }
}
