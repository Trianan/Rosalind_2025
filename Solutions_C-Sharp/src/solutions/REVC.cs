/*==============================================================================
    FILE:          REVC.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 24, 2025
    LAST MODIFIED: February 24, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Solution for 'REVC' problem on Rosalind platform.
        Verified correct answer (Feb 24/2025):
        CCTTCGGCACCCGCGTATAAGATCCGGTTAGTCGGAACCATCCAAGCTGCTACTCGAGATCCGACACTAGTCAACAATGCCCATGTCAGGCTATGGTTACACGATACAACTTCGTTGGAAACTAGGCCGACGCTAGGGTTGGGTAGCGACAGGCTTTTGGGAAATTAATTTGTGCGAAGGGCTTCATTCTCACAATGTCAGTCCTATCAAATGACCATTAAACGTATTGACTGATGATTCCCGAACTGGTCCAACTAAACGGAAGTCCAGAACACTCCGCTACGGTAATCATTGTTTACCATAATGAGCGGCACTACGTAACGTCACGCTCCATTGAACGAACGTGATAATAATGCTCGACGCATAGATGTATTCGGCGCAAAACTTCGGCTAAACCCATCCACGGAACCAAGTTCTCTTGTTGCTCAGAACTCGCATGGTGTACTCTTGTGTGTAATGTGCTAACTAACTTTGACTCAGAAGGCCCCCCAATTCGGGTTGACAGCGAATCAGATGGTATGAGCTCACAGTGAGTAATGGTACAAGAATTTTTAAAAGTCCAGTTAATTTCAACACTTTTGCCCATGAGTAGAACAGCTAGAAAACTTGTACAAAGAGGACAGCGTGGTATAAGCGTAAGGAGGCAATACCGCTACCACTGTTCGTAGCGGGTAGACAACTGTGGAGTGGGTTAGTGTGACCCGTGGCCAGGCGAAAATAAGGGATATACATCTTTCGTGCTTCCCCTTCGACTGTAGCTGTAGAGATCCCCCAACGAATCATCGGAGTACGATTGTCCCCTCGTTATTCGTGTTTAGGTAACGAGGAAACCATTCTTCCTATTATTCTCTGTCGTGAGT
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class REVC : Solution {
    /*
        METHOD: Run
        DESCRIPTION:
            Executes the primary logic for the solution and outputs the
            final answer.
    */
    public override void Run() {
        string? dnaStrand = FileReader.GetDataBlob(GetType().Name);
        if (dnaStrand == null) {
            Console.WriteLine("No DNA-strand data found. Terminating solution...");
            return;
        }
        Console.WriteLine("Creating reverse-compliment of provided DNA strand...");
        string complimentStrand = GetComplimentStrand(dnaStrand);
        Console.WriteLine($">>>{complimentStrand}<<<");
    }
    
    /*
        METHOD: GetComplimentStrand
        DESCRIPTION:
            Creates the reverse compliment of the input DNA string; reverses the order
            of the string, then converts each character according to the following rules:
            C <-> G, A <-> T
    */
    private string GetComplimentStrand(string dnaStrand) {
        string complimentStrand = "";
        foreach (char c in dnaStrand) {
            switch (c) {
                case 'A':
                    complimentStrand = complimentStrand.Insert(0, "T");
                    break;
                case 'T':
                    complimentStrand = complimentStrand.Insert(0, "A");
                    break;
                case 'C':
                    complimentStrand = complimentStrand.Insert(0, "G");
                    break;
                case 'G':
                    complimentStrand = complimentStrand.Insert(0, "C");
                    break;
            }
        }
        return complimentStrand;
    }
}