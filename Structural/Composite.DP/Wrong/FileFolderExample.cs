

public class FileItem
{
    public int GetSize() => 10;
}

public class Folder
{
    public List<FileItem> Files = new();

    public int GetTotalSize()
    {
        int size = 0;
        foreach (var file in Files)
            size += file.GetSize();

        return size;
    }
}
