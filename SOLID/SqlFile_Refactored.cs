using System;

public class SqlFile
{
    public string LoadText()
    {
        /* Code to read text from sql file */
    }
    public void SaveText()
    {
        /* Code to save text into sql file */
    }
}
public class ReadOnlySqlFile : SqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
    }
    public void SaveText()
    {
        /* Throw an exception when app flow tries to do save. */
        throw new IOException("Can't Save");
    }
}
public class SqlFileManager
{
    public List<SqlFile> lstSqlFiles {get; set; }
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
            //Check whether the current file object is read only or not.If yes, skip calling it's   
            // SaveText() method to skip the exception.   

            if (!objFile is ReadOnlySqlFile)
                objFile.SaveText();
        }
    }   
}   

