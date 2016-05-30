namespace VisioExportPagesToDocs
{
    public class LogRecord
    {
        public ExporterSettings Settings;
        public string PageName;
        public int PageIndex;
        public string OutputFilename;
        public bool OutputFileAlreadyExists;
        public bool OutputFileWritten;
    }
}