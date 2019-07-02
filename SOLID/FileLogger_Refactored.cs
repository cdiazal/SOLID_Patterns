using System;

public class DbLogger
{
    public void LogMessage(string aMessage)
    {
        //Code to write message in database.   
    }
}
public class FileLogger
{
    public void LogMessage(string aStackTrace)
    {
        //code to log stack trace into a file.   
    }
}
public class ExceptionLogger
{
    public void LogIntoFile(Exception aException)
    {
        FileLogger objFileLogger = new FileLogger();
        objFileLogger.LogMessage(GetUserReadableMessage(aException));
    }
    public void LogIntoDataBase(Exception aException)
    {
        DbLogger objDbLogger = new DbLogger();
        objDbLogger.LogMessage(GetUserReadableMessage(aException));
    }
    private string GetUserReadableMessage(Exception ex)
    {
        string strMessage = string.Empty;
        //code to convert Exception's stack trace and message to user readable format.   
        ////////

        return strMessage;
    }
}
public class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            //code to export data from files to database.   
        }
        catch (IOException ex)
        {
            new ExceptionLogger().LogIntoDataBase(ex);
        }
        catch (Exception ex)
        {
            new ExceptionLogger().LogIntoFile(ex);
        }
    }
}
