/*==============================================================================
    FILE:          FileReader.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 23, 2025
    LAST MODIFIED: February 23, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Contains methods for reading in data input for each solution.
==============================================================================*/
namespace Solutions_C_Sharp;

public static class FileReader {
    // Contains path to input data folder:
    private static readonly string DataDir = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "data",
        "inputData"
        );
    
    /*
        METHOD: GetDataBlob
        DESCRIPTION:
            Reads the input file corresponding to the solution
            that uses it and returns it as a single string for further
            processing.
    */
    public static string? GetDataBlob(string solutionName) {
        string dataFilePath = Path.Combine(DataDir, solutionName + ".txt");
        return File.Exists(dataFilePath) ? File.ReadAllText(dataFilePath) : null;
    }
    
    /*
        METHOD: GetDataLines
        DESCRIPTION:
            Reads the input file corresponding to the solution
            that uses it and returns it as an array of strings for
            further processing.
    */
    public static string[]? GetDataLines(string solutionName) {
        string dataFilePath = Path.Combine(DataDir, solutionName + ".txt");
        return File.Exists(dataFilePath) ? File.ReadAllLines(dataFilePath) : null;
    }
}