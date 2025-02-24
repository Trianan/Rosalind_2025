/*==============================================================================
    FILE:          Solution.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 23, 2025
    LAST MODIFIED: February 23, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Declaration of abstract Solution class for all solutions to
        inherit from; this allows the Launcher to treat each solution
        as similar objects by calling their overridden Run() methods.
==============================================================================*/
namespace Solutions_C_Sharp;

public abstract class Solution {
    // Executes solution code defined within child classes.
    public abstract void Run();
}