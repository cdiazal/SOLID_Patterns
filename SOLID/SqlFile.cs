using System;

public class SqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
    }
    public string SaveText()
    {
        /* Code to save text into sql file */
    }
}
public class SqlFileManager
{
    public List<SqlFile> lstSqlFiles { get; set}

    public string GetTextFromFiles()
    {
        StringBuilder objStrBuilder = new StringBuilder();
        foreach (var objFile in lstSqlFiles)
        {
            objStrBuilder.Append(objFile.LoadText());
        }
        return objStrBuilder.ToString();
    }
    public void SaveTextIntoFiles()
    {
        foreach (var objFile in lstSqlFiles)
        {
            objFile.SaveText();
        }
    }
}

