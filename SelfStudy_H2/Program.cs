namespace SelfStudy_H2;

internal class Program
{
    static void Main(string[] args)
    {
        /*
         * This will serve as the orchestrator, and explanation file for
         * all the tasks/milestones in the pdf provided
         */

        // Milestone 2 - Basic understanding of C#
        // while the pdf only says to create a program writing my name and age, as well as a returned string from a method
        // i will also be including the variables by themselves, such that the "Research" part of the milestone is shown
        string name = "Nikolaj";
        int age = 23;
        string nameAndAge = GetNameAndAge(name, age);
        Console.WriteLine(nameAndAge);

        // Milestone 6 - Code-standards
        /*
         * Q: What are the naming conventions in C#?
         * A: In C#, the naming conventions are as follows:
         * - Classes, methods, and properties should be in PascalCase (e.g., MyClass, GetNameAndAge).
         * - Variables and fields should be in camelCase (e.g., name, age).
         * - Constants should be in uppercase with underscores (e.g., MAX_VALUE).
         * - Interfaces should start with an "I" followed by PascalCase (e.g., IMyInterface).
         * - Enums should be in PascalCase (e.g., MyEnum).
         * - Namespaces should be in PascalCase and typically follow the pattern of CompanyName.ProjectName (If it were commercial).
         * - Additionally, it's important to use meaningful names that clearly indicate the purpose of the variable, method, or class.
         * - It's also recommended to avoid using abbreviations unless they are widely understood, and to keep names concise while still being descriptive.
         * 
         * Q: What is camelCase and PascalCase? - And are there others that exist?
         * A: camelCase is a naming convention where the first letter of the first word is lowercase, and the first letter of each subsequent word is uppercase (e.g., myVariableName). 
         * PascalCase is a naming convention where the first letter of each word is uppercase (e.g., MyClassName). 
         * Other naming conventions include snake_case (where words are separated by underscores, e.g., my_variable_name) 
         * and kebab-case (where words are separated by hyphens, e.g., my-variable-name), although these are less common in C# (Which is unfortunate given the funny nature of "kebab-case")
         * 
         * Q: Why are indentations important?
         * A: Indentations are important in programming because they improve the readability and maintainability of the code. 
         * Proper indentation helps to visually separate different blocks of code, making it easier for developers to understand the structure and flow of the program. 
         * It also helps to identify which statements belong to which control structures (e.g., loops, conditionals) and can prevent errors that may arise from misinterpreting the code's logic. 
         * In C#, while indentation is not syntactically required (unlike in languages like Python), it is considered a best practice and is essential for writing clean and easily maintainable code.
         * 
         * Q: Why are code standards important?
         * A: Code standards are important because they promote consistency, readability, and maintainability in software development.
         */

        // Milestone 19 - Version control
        /*
         * This repo will have several commits each indicating the completion of a milestone, and will be pushed to GitHub as well as being shared with the teacher.
         * 
         * Q: Why is Git important for teamwork?
         * A: Git is important for teamwork because it allows multiple developers to collaborate on the same codebase without conflicts.
         * This is achieved through features like branching and merging, which enable developers to work on different features or bug fixes simultaneously and then integrate their changes back into the main codebase.
         */
    }

    static string GetNameAndAge(string name, int age)
    {
        return $"My name is {name} and I am {age} years old.";
    }
}
