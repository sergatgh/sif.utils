namespace SIF.Utils.Forms.SelectFile;

public class RecentFileModel
{
    public RecentFileModel()
    {
    }

    public RecentFileModel(string filePath)
    {
        FilePath = filePath;
        LastOpened = DateTime.Now;
    }

    public string FilePath { get; set; } = string.Empty;
    public DateTime LastOpened { get; set; }
    public bool IsPinned { get; set; }
}