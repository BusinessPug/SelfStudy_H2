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

        // ----------------------------------------------------------

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

        // ----------------------------------------------------------

        // Milestone 19 - Version control
        /*
         * This repo will have several commits each indicating the completion of a milestone, and will be pushed to GitHub as well as being shared with the teacher.
         * 
         * Q: Why is Git important for teamwork?
         * A: Git is important for teamwork because it allows multiple developers to collaborate on the same codebase without conflicts.
         * This is achieved through features like branching and merging, which enable developers to work on different features or bug fixes simultaneously and then integrate their changes back into the main codebase.
         */

        // ----------------------------------------------------------

        // Milestone 5 - Collections
        /*
         * The milestone in the PDF mentions Lists, Sets and Map.
         * Only one of these is "correctly" named for C#, which is Lists (List<>).
         * Sets (from the further down explanation) are what in C# are called HashSet<>, and Maps are Dictionary<,>.
         */

        // Lists
        List<string> names = new() { "Nikolaj", "Vladislav", "Jacob", "Jonas", "Tore" };
        foreach(var personName in names)
            Console.WriteLine(personName);
        names.Add("Kenneth");
        Console.WriteLine("After adding Kenneth:");
        Console.WriteLine(string.Join(", ", names)); // This enumerates on it's own.
        /*
         * Q: Does a List keep the order of the elements?
         * A: Yes, a List in C# maintains the order of the elements as they were added. When you add an element to a List, it is appended to the end of the list, and when you iterate over the List, the elements are returned in the order they were added.
         *
         * Q: Can a list contain duplicate elements?
         * A: Yes, a List in C# can contain duplicate elements, there are no restrictions.
         */

        // Sets (HashSet)
        HashSet<string> uniqueNames = new() { "Nikolaj", "Vladislav", "Jacob", "Jonas", "Tore" };
        uniqueNames.Add("Kenneth");
        uniqueNames.Add("Kenneth"); // "Silently fails"
        Console.WriteLine(string.Join(", ", uniqueNames));
        /*
         * Q: Does a Set keep the order of the elements?
         * A: No, a HashSet in C# does not maintain the order of the elements. The order of elements in a HashSet is not guaranteed and can change when new elements are added or removed.
         *
         * Q: Can a Set contain duplicate elements?
         * A: No, a HashSet in C# cannot contain duplicate elements. If you try to add an element that already exists in the HashSet, it will not be added again, and the existing element will remain unchanged.
         * 
         * Furthermore. in real world scenarios one would often do a if (!uniqueNames.Add("Kenneth"))
         * This is because the .Add method of a HashSet returns a boolean indicating whether the element was
         * successfully added (true) or if it already existed in the set (false).
         */

        // Maps (Dictionary)
        Dictionary<string, int> nameToAge = new() 
        { 
            { "Nikolaj", 23 }, 
            { "Vladislav", 20 }, 
            { "Jacob", 28 }, // Det må give bonus-point ;)  
            { "Jonas", 19 }, 
            { "Tore", 130 } 
        };

        Console.WriteLine(nameToAge["Jacob"]);
        foreach(var kvp in nameToAge)
            Console.WriteLine($"{kvp.Key} is {kvp.Value} years old.");
        /*
         * Q: What are keys used for - And can they be duplicated?
         * A: In a Dictionary (or Map) in C#, keys are used to uniquely identify values. 
         * Each key in a Dictionary is associated with a specific value, and you can use the key to retrieve or manipulate the corresponding value.
         * Keys must be unique within a Dictionary, meaning that you cannot have duplicate keys. 
         * When you want to access a value in a Dictionary, you provide the key, and the Dictionary returns the associated value.
         */

        // ----------------------------------------------------------

        // Reflection
        /*
         * Q: When would you use a List?
         * A: In C#, you would use a List when you need an ordered collection of elements that can contain duplicates and allows for dynamic resizing. (That last part being really important for ease of work)
         * 
         * Q: When would you use a Set?
         * A: A HashSet (or Set) in C# is used when you need a collection of unique elements and do not care about the order of the elements. (It is also extremely fast and memory efficient)
         * 
         * Q: When would you use a Map?
         * A: A Dictionary (or Map) in C# is used when you need to associate keys with values, allowing for fast lookups, additions, and deletions based on the key. (Great for caching or any scenario where you want to quickly retrieve data based on a unique identifier)
         */
    }

    static string GetNameAndAge(string name, int age)
    {
        return $"My name is {name} and I am {age} years old.";
    }
}
