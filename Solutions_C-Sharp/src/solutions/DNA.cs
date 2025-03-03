/*==============================================================================
    FILE:          DNA.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 23, 2025
    LAST MODIFIED: February 24, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Solution for 'DNA' problem on Rosalind platform.
        Verified correct answer (Feb 24/2025): 222 220 193 219
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class DNA : Solution {
    /*
        METHOD: Run
        DESCRIPTION:
            Executes the primary logic for the solution and outputs the
            final answer.
    */
    public override void Run() {
        string? strandData = FileReader.GetDataBlob(GetType().Name);
        if (strandData == null) {
            Console.WriteLine("No DNA-strand data found. Terminating solution...");
            return;
        }
        Console.WriteLine("Analyzing DNA strand...");
        Dictionary<char, int> nbCounts = GetNucleobaseCount(strandData);
        Console.WriteLine(
            $">>>{nbCounts['A']} {nbCounts['C']} {nbCounts['G']} {nbCounts['T']}<<<"
        );
    }
    
    /*
        METHOD: GetNucleobaseCount
        DESCRIPTION:
            Counts the number of occurrences of A, C, G, and T nucleobases
            within a string representing a DNA strand; returns a dictionary
            with keys corresponding to each nucleobase, and values representing
            the count of each within the strand.
    */
    private Dictionary<char, int> GetNucleobaseCount(string strand) {
        Dictionary<char, int> nucleobaseCounts = new() {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (char nucleobase in strand) {
            if (nucleobaseCounts.ContainsKey(nucleobase)) {
                nucleobaseCounts[nucleobase]++;
            }
        }
        return nucleobaseCounts;
    }
}