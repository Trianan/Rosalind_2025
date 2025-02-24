/*==============================================================================
    FILE:          Launcher.cs
    PROJECT:       Rosalind_2025/Solutions_C-Sharp
    CREATION DATE: February 21, 2025
    LAST MODIFIED: February 23, 2025
    AUTHOR:        Tristin A. Manson (TriaNaN)
    DESCRIPTION:
        Launcher for all my solutions for problems hosted on the
        Rosalind platform.
==============================================================================*/
namespace Solutions_C_Sharp;

using System;
using System.Linq;
using System.Reflection;

using System.IO;
using System.Collections.Generic;
using Solutions_C_Sharp.solutions;

static class Launcher {
    /*
        METHOD: Main
        DESCRIPTION:
            Entry point for Rosalind_2025/Solutions_C-Sharp; provides
            a text-based UI for launching completed Rosalind problems
            stored within /src/solutions/,
    */
    public static void Main(string[] args) {
        
        Console.WriteLine("ROSALIND_2025: C# Solutions\nShowing all solutions:");
        
        // Show all Solution child classes:
        var existingSolutions = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => 
                       typeof(Solution).IsAssignableFrom(t) &&
                       !t.IsAbstract // Don't show abstract classes.
                       );
        foreach (Type existingSolution in existingSolutions) {
            Console.WriteLine(existingSolution.Name);
        }
        
        while (true) {
            Console.Write("Enter which solution to run (or EXIT to end program): ");
            
            // Get and clean input from user:
            string? solutionInput = Console.ReadLine();
            if (solutionInput != null) {
                solutionInput = solutionInput.Trim();
                // Check for exit command; terminate program if received:
                if (solutionInput == "EXIT") {
                    break;
                }
                // Create object corresponding to the solution name entered by the user:
                Solution? solution = CreateSolutionByName(solutionInput);
                if (solution != null) {
                    // Run specified solution:
                    Console.WriteLine($"Executing {solution.GetType().Name}.Run() . . .");
                    solution.Run();
                    Console.WriteLine("Finished");
                }
                else {
                    // No class defined that corresponds to provided solution name:
                    Console.WriteLine($"No solution found for '{solutionInput}'.");
                }
            }
            else {
                // ReadLine failed to get user input.
                Console.WriteLine("No input obtained from console.");
                break;
            }
        }
    }
    
    /*
        METHOD: CreateSolutionByName
        DESCRIPTION:
            Creates instance of an object defined within the assembly of this
            program, by only passing the name of the object's class as a string.
            Used to dynamically instantiate the proper specializations of the
            abstract Solution class through receiving the name of that specialization.
    */
    private static Solution? CreateSolutionByName(string solutionName) {
        Type? solutionType = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t =>
                typeof(Solution).IsAssignableFrom(t) &&
                t.Name.Equals(
                    solutionName,
                    StringComparison.OrdinalIgnoreCase
                    ) &&
                !t.IsAbstract // Avoid attempting to instantiate abstract types and crashing
            );
        if (solutionType != null) {
            return (Solution?)Activator.CreateInstance(solutionType);
        }
        return null;
    }
}
//==============================================================================
// test