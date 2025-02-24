/*==============================================================================
    FILE:          RNA.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 24, 2025
    LAST MODIFIED: February 24, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Solution for 'RNA' problem on Rosalind platform.
        Verified correct answer (Feb 24/2025):
        UGUAUCAUCCGCCUCAAUAGGUCAAAUCGGGACCAGGACUGCACCAGAAAACGCGCCGUAUCUGACCAAACCUAAGCGUAAGGUAAGACCCGUCCAAUCUUUCAUGUCUUCUUUAUUGUGAGGAUGCUCCGCUCAUGAUCCCCUACAGCUCCGAUCCGGUGACAUAUUGUCCGUGUGUGGGUUAGGCGUCGGGUACGUCCUUAGAAGGCUUGGAGAAAGUUCUCUCUACUGGUUACCUUAGUCGGGAGCAAUCUGUGGAAUGCUCGUUAGCGAUGGGCAGAGAUGAAUUGCGUCACGACAAUAUCACAUUUAAACAAUUACUGGGACCCCUCGAACGUCGCCCGAAUAACGCGCACUUCACAGGCGUCAUCUUCAUCGUUCGUAUUUGGUUACGCCUGGGGGCCUUUUUUCUUCUGGCCGCCCGCCGCGAAUAGGGGUUGAUGGUUUCAACAGUCCGAAAAACGAAGACGUGUCGGCGUAAGUUAUACCUUACCUGGGUGCAUGCAGAUCGUACCCUUUCAUAGCAAUGGUAAGUCGAGUUGUCAGGAAGGAGUGCAAGACGCAACAGGUGUGUUGCUGGGAGAUGGAGAGAACGGUUCUGCUGUUGUGAUGCGAUGGAGGCCGUACUUUAGCUAAGAAAUUAGGCUGUUUUUGCACCACGGUCUCCUAGUGCAGUACGGCACUCACGCAUUUCCGCAUCAUCGAUCUGGCGCGACGACACAGACACUUGAGGACUAGAAAGCGCUCGUGAGGCGUAGGUCGCCCGGUACGAGGCUACCAUUAGGGUCUGUCACAGAAAGUCCUGCGAUAGACCCGCGCGGUUAGUGGUGUAACCGAUCUACGCAAUAAAAAGCCCUCGUCGAGCGUGUCGAAGCGAGGGUGUAUGACAACCCUAAGAGGGACUAGUCGCCCAAUCUUCGUGUGAGUUCUAACGAGGAUAUUUAUGUUUUCUCUGUGAACACGUAGUAGGGACGGGUUGAACCGGUUGU
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class RNA : Solution {
    /*
        METHOD: Run
        DESCRIPTION:
            Executes the primary logic for the solution and outputs the
            final answer.
    */
    private readonly string _dnaBaseSet = "ACGT";
    public override void Run() {
        string? dnaStrand = FileReader.GetDataBlob(GetType().Name);
        if (dnaStrand == null) {
            Console.WriteLine("No DNA-strand data found. Terminating solution...");
            return;
        }
        Console.WriteLine("Transcribing RNA from DNA strand...");
        string rnaStrand = TranscribeRNA(dnaStrand);
        Console.WriteLine($">>>{rnaStrand}<<<");
    }
    
    /*
        METHOD: TranscribeRNA
        DESCRIPTION:
            Transcribes a DNA string into an RNA string by
            converting all 'T' bases into 'U' bases.
    */
    private string TranscribeRNA(string dnaStrand) {
        string rnaStrand = "";
        foreach (char c in dnaStrand) {
            if (_dnaBaseSet.Contains(c)) {
                if (c == 'T') {
                    rnaStrand += 'U';
                }
                else {
                    rnaStrand += c;
                }
            }
        }
        return rnaStrand;
    }
}