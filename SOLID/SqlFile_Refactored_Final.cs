using System;

public interface IReadableSqlFile
{
    string LoadText();
}
public interface IWritableSqlFile
{
    void SaveText();
}

public class ReadOnlySqlFile : IReadableSqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
    }
}

public class SqlFile : IWritableSqlFile, IReadableSqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
    }
    public void SaveText()
    {
        /* Code to save text into sql file */
    }
}

public class SqlFileManager
{
    public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
    {
        StringBuilder objStrBuilder = new StringBuilder();
        foreach (var objFile in aLstReadableFiles)
        {
            objStrBuilder.Append(objFile.LoadText());
        }
        return objStrBuilder.ToString();
    }
    public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
    {
        foreach (var objFile in aLstWritableFiles)
        {
            objFile.SaveText();
        }
    }
}

