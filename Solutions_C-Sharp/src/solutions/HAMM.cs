/*==============================================================================
    FILE:          HAMM.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 24, 2025
    LAST MODIFIED: February 24, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Solution for 'HAMM' problem on Rosalind platform.
        Verified correct answer (Feb 24/2025): 481
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class HAMM : Solution {
    /*
        METHOD: Run
        DESCRIPTION:
            Executes the primary logic for the solution and outputs the
            final answer.
    */
    public override void Run() {
        string[]? dnaStrands = FileReader.GetDataLines(GetType().Name);
        // Ensures data is not null or any length other than 2:
        if (dnaStrands is not { Length: 2 }) {
            Console.WriteLine("No DNA-strand data found. Terminating solution...");
            return;
        }
        Console.WriteLine("Calculating hamming distance between provided strands...");
        string strandA = dnaStrands[0], strandB = dnaStrands[1];
        int hDistance = CalculateHammingDistance(strandA, strandB);
        Console.WriteLine($">>>{hDistance}<<<");
    }
    
    /*
        METHOD: CalculateHammingDistance
        DESCRIPTION:
            Calculates the Hamming Distance (# of differing symbols for each index)
            for two equal-length strings, and returns it as an integer.
    */
    private int CalculateHammingDistance(string strandA, string strandB) {
        if (strandA.Length != strandB.Length) {
            Console.WriteLine("Strands must have the same length. Terminating solution...");
            return -1;
        }
        // Iterate over base-pairs in each DNA strand, adding to hamming distance if
        // bases differ at that index:
        int hDistance = 0;
        for (int i = 0; i < strandA.Length; i++) {
            if (strandA[i] != strandB[i]) {
                hDistance++;
            }
        }
        return hDistance;
    }
}