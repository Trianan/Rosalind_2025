/*==============================================================================
    FILE:          ExampleSolution.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 23, 2025
    LAST MODIFIED: February 23, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Specialization of Solution class used for testing the launcher.
==============================================================================*/
namespace Solutions_C_Sharp.solutions;

public class ExampleSolution : Solution {
    public override void Run() {
        int length = 10;
        for (int i = 1; i <= length; i++) {
            string row = "";
            for (int j = 0; j < i; j++) {
                row += "*";
            }
            Console.WriteLine(row);
        }
    }
}