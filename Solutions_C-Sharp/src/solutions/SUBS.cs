/*==============================================================================
    FILE:          SUBS.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 24, 2025
    LAST MODIFIED: February 24, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Solution for 'SUBS' problem on Rosalind platform.
        Verified correct answer (Feb 24/2025):
        12 156 183 190 216 234 253 279 295 302 325 386 409 416 500 517 554 582 589 610 628 716 723 754 880 897 942
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class SUBS : Solution {
    /*
        METHOD: Run
        DESCRIPTION:
            Executes the primary logic for the solution and outputs the
            final answer.
    */
    public override void Run() {
        string[]? strandMotifPair = FileReader.GetDataLines(GetType().Name);
        // Ensures data is not null or any length other than 2:
        if (strandMotifPair is not { Length: 2 }) {
            Console.WriteLine("DNA-strand and motif data not found. Terminating solution...");
            return;
        }
        Console.WriteLine("Calculating locations of motif within DNA strand...");
        string dnaStrand = strandMotifPair[0], motif = strandMotifPair[1];
        List<int>? motifLocations = GetMotifLocations(motif, dnaStrand);
        if (motifLocations is null) {
            Console.WriteLine("Could not read motif-strand pair. Terminating solution...");
            return;
        }
        // Show locations:
        Console.Write(">>>");
        for (int i = 0; i < motifLocations.Count; i++) {
            Console.Write($"{motifLocations[i]}");
            // Add space if not at last location:
            if (i != motifLocations.Count - 1) {
                Console.Write(" ");
            }
        }
        Console.WriteLine("<<<");
    }
    
    /*
        METHOD: GetMotifLocations
        DESCRIPTION:
            Returns a list of locations of a DNA-motif within a DNA string.
            'Location' is defined as the index of the first base of a matching
            motif within the DNA string, plus 1 to make it 1-based instead of 0-based.
    */
    private static List<int>? GetMotifLocations(string motif, string dnaStrand) {
        if (motif.Length > dnaStrand.Length || motif.Length == 0 || dnaStrand.Length == 0) {
            // Malformed arguments.
            return null;
        }
        
        // Check for occurrences of motif within full DNA strand; add locations to list:
        List<int> motifLocations = [];
        for (int i = 0; i < dnaStrand.Length - motif.Length; i++) {
            if (dnaStrand.Substring(i, motif.Length) == motif) {
                motifLocations.Add(i + 1); // +1 to turn 0-base index to 1-based as required for problem.
            }
        }
        return motifLocations;
    }
}