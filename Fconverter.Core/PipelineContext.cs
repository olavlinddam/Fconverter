namespace Fconverter.Core;

public class PipelineContext
{
    // IO Steams
    public Stream InputStream { get; set; }
    public Stream OutputStream { get; set; }
    
    // Conversion state
    public ConversionState State { get; set; }
    
    // Metadata
    public ConversionMetaData MetaData { get; set; }

    public PipelineContext(string? inputPath, string? outputPath)
    {
        // Initialize stream based on paths or stdin/stdout
        MetaData = new ConversionMetaData();
        State = ConversionState.Started;
    }
}
public class ConversionMetaData
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public long InputSize { get; set; }
    public long OutputSize { get; set; }
    public string InputFormat { get; set; }
    public string OutputFormat { get; set; }
    public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
}
public enum ConversionState
{
    Started = 0,
    ReadingInput = 1,
    ValidatingInput = 2,
    Converting = 3,
    WritingOutput = 4,
    Completed = 5,
    Failed = 6
}
