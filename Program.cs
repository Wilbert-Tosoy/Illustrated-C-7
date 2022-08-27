using System;
using static System.Console;
using static System.Convert;

namespace Illustrated_CSharp_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int choice;

            do
            {
                WriteLine("\n\t1. C# and the .NET Framework\n\t2. C# and .NET Core\n\t3. Overview of C# Programming" +
                    "\n\t4. Types, Storage, and Variables\n\t5. Classes: The Basics\n\t6. Methods" +
                    "\n\t7. More About Classes\n\t8. Classes and Inheritance\n\t9. Expressions and Operators" +
                    "\n\t10. Statements\n\t11. Structs\n\t12. Enumerations\n\t13. Arrays\n\t14. Delegates" +
                    "\n\t15. Events\n\t16. Interfaces\n\t17. Conversions\n\t18. Generics\n\t19. Enumerators and Iterators" +
                    "\n\t20. Introduction to LINQ\n\t21. Introduction to Asynchronous Programing" +
                    "\n\t22. Namespace and Assemblies\n\t23. Exceptions\n\t24. Preprocessor Directives" +
                    "\n\t25. Reflection and Attributes\n\t26. What's New in C# 6 and 7\n\t27. Other Topics" +
                    "\n\t28. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                Decision(ref choice, ref exit);

            } while (exit != true);
        }        

        public static void ClassesTheBasics()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\tClasses: The Basics\n\n" +
                    "\t- Overview of Classes\n\t- Programs and Classes: A Quick Example\n\t- Declaring a Class" +
                    "\n\t- Class Members\n\t- Creating Variables and Instances of a Class" +
                    "\n\t- Allocating Memory for the Data\n\t- Instance Members\n\t- Access Modifiers" +
                    "\n\t- Accessing Members from Inside the Class\n\t- Accessing Memebers from Outside the Class" +
                    "\n\t- Putting It All Together\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

            } while (choice != 19);

            ReadKey();

            Clear();
        }

        public static void Methods()
        {
            Clear();
            do
            {
                WriteLine("\tMethods\n\n");
                WriteLine("\t- The Structure of a Method\n\t- Code Execution of the Method Body\n\t- Local Variables" +
                    "\n\t- Local Constant\n\t- Flow of Control\n\t- Method Invocations\n\t- Return Values" +
                    "\n\t- The Return Statement and Void Methods\n\t- Local Functions\n\t- Parameters" +
                    "\n\t- Value Parameters\n\t- Reference Parameters\n\t- Reference Types As Value and Reference Parameters" +
                    "\n\t- Output Parameters\n\t- Parameter Arrays\n\t- Summary of Parameter Types\n\t- Method Overloading" +
                    "\n\t- Named Parameters\n\t- Optional Parameters\n\t- Stack Frames\n\t- Recursion");
            } while (ReadKey() == null);
            Clear();
        }

        public static void MoreAboutClasses()
        {
            Clear();
            do
            {
                WriteLine("\tMore About Classes\n\n");
                WriteLine("\t- Class Members\n\t- Order of Member Modifiers\n\t- Instance Class Members\n\t- Static Fields" +
                    "\n\t- Accessing Static Members form Outside the Class\n\t- Static Function Members" +
                    "\n\t- Other Static Class Member Types\n\t- Member Constants\n\t- Constant Are Like Statics" +
                    "\n\t- Properties\n\t- Instance Constructors\n\t- Static Constructors\n\t- Object Initializers" +
                    "\n\t- Destructors\n\t- The readonly Modifier\n\t- The this Keyword\n\t- Access Modifiers on Accessors" +
                    "\n\t- Partial Classes and Partial Types\n\t- Partial Methods");
            } while (ReadKey() == null);
            Clear();
        }

        public static void ClassesAndInheritance()
        {
            Clear();
            do
            {
                WriteLine("\tClasses and Inheritance\n\n");
                WriteLine("\t- Class Inheritance\n\t- Accessing the Inherited Members\n\t- All Classes Are Derived from Class object" +
                    "\n\t- Masking Members of a Base Class\n\t- Base Access\n\t- Using Reference to a Base Class" +
                    "\n\t- Constructor Execution\n\t- Inheritance Between Assemblies\n\t- Member Access Modifiers" +
                    "\n\t- Abstract Members\n\t- Abstract Classes\n\t- Sealed Classes\n\t- Static Classes" +
                    "\n\t- Extension Methods\n\t- Naming Conversions");
            } while (ReadKey() == null);
            Clear();
        }

        public static void ExpressionsAndOperators()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\nExpressions and Operators\n\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit");

                Write("-> ");
                choice = ToInt32(ReadLine());

            } while (choice != 19);
            
            ReadKey();

            Clear();
        }

        public static void Statements()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\nExpressions and Operators\n\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit");

                Write("-> ");
                choice = ToInt32(ReadLine());

            } while (choice != 19);

            ReadKey();

            Clear();
        }

        public static void Structs()
        {

        }

        public static void Enumerations()
        {

        }

        public static void Arrays()
        {

        }

        public static void Delegates()
        {

        }

        public static void Events()
        {

        }

        public static void Interface()
        {

        }

        public static void Conversion()
        {

        }

        public static void Generic()
        {

        }

        public static void EnumeratorsAndIterators()
        {

        }

        public static void IntroductionToLINQ()
        {

        }

        public static void IntroductionToAsynchronousProgramming()
        {

        }

        public static void NamespaceAndAssemblies()
        {

        }

        public static void Exceptions()
        {

        }

        public static void PreprocessorDirectives()
        {

        }

        public static void ReflectionsAndAttributes()
        {

        }

        public static void WhatIsNewInCSharp6And7()
        {

        }

        public static void OtherTopics()
        {

        }

        public static void Decision(ref int choice, ref bool exit)
        {
            switch (choice)
            {
                case 1:
                    One.CSharpAndTheDotNetFramework();
                    break;
                case 2:
                    Two.CSharpAndDotNetCore();
                    break;
                case 3:
                    Three.OverviewOfCSharpProgramming();
                    break;
                case 4:
                    Four.TypesStorageAndVariables();
                    break;
                case 5:
                    ClassesTheBasics();
                    break;
                case 6:
                    Methods();
                    break;
                case 7:
                    MoreAboutClasses();
                    break;
                case 8:
                    ClassesAndInheritance();
                    break;
                case 9:
                    ExpressionsAndOperators();
                    break;
                case 10:
                    Statements();
                    break;
                case 11:
                    Structs();
                    break;
                case 12:
                    Enumerations();
                    break;
                case 13:
                    Arrays();
                    break;
                case 14:
                    Delegates();
                    break;
                case 15:
                    Events();
                    break;
                case 16:
                    Interface();
                    break;
                case 17:
                    Conversion();
                    break;
                case 18:
                    Generic();
                    break;
                case 19:
                    EnumeratorsAndIterators();
                    break;
                case 20:
                    IntroductionToLINQ();
                    break;
                case 21:
                    IntroductionToAsynchronousProgramming();
                    break;
                case 22:
                    NamespaceAndAssemblies();
                    break;
                case 23:
                    Exceptions();
                    break;
                case 24:
                    PreprocessorDirectives();
                    break;
                case 25:
                    ReflectionsAndAttributes();
                    break;
                case 26:
                    WhatIsNewInCSharp6And7();
                    break;
                case 27:
                    OtherTopics();
                    break;
                case 28:
                    exit = true; 
                    break;
                default:
                    Clear();
                    break;
            }
        }
    }

    public static class One
    {
        public static void CSharpAndTheDotNetFramework()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tC# and the .NET Framework\n");
                WriteLine("\t1. Before .NET\n\t2. Enter Microsoft .NET\n\t3. Compiling to the Common Intermediate Language" +
                    "\n\t4. Compiling to Native Code and Execution\n\t5. The Common Language Runtime" +
                    "\n\t6. The Common Language Infrastructure\n\t7. Reviews of the Acronyms\n\t8. The Evolution of C#" +
                    "\n\t9. C# and the Evolution of Windows\n\t10. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                OneDecision(ref choice);

            } while (choice != 10);
            Clear();
        }

        static void OneDecision(ref int choice) 
        {
            switch (choice)
            {
                case 1:
                    BeforeDotNet();
                    break;
                case 2:
                    EnterMicrosoftDotNet();
                    break;
                case 3:
                    CompilingToTheCommonIntermediateLanguage();
                    break;
                case 4:
                    CompilingToNativeCodeAndExecution();
                    break;
                case 5:
                    TheCommonLanguageRuntime();
                    break;
                case 6:
                    TheCommonLanguageInfrastructure();
                    break;
                case 7:
                    ReviewsOfTheAcronyms();
                    break;
                case 8:
                    TheEvolutionOfCSharp();
                    break;
                case 9:
                    CSharpAndTheEvolutionOfWindows();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void BeforeDotNet()
        {
            Clear();

            WriteLine("\nBefore .NET");
            WriteLine("\t- The C# programming language was designed for developing programs for Microsoft's .NET Framework.\n" +
                "\t- The name C# is pronounced \"see sharp\".\n");
            WriteLine("\nWindows Programming in the Late 1990s\n" +
                "\t- In the late 1990s, Windows programming using the Microsoft platform had fractured into a number of branches. Most pogrammers " +
                "were using Visual Basic, C, or C++.\n" +
                "\t- Some C and C++ programmers were using the raw Win32 API, but most were using Microsoft Foundation Classes (MFC). Others " +
                "had moved to the Component Object Model (COM).\n" +
                "\t- All these technologies had their own problems. The raw Win32 API was not object-oriented, and using it required a lot more work than MFC.\n" +
                "\t- MFC was object-oriented but was inconsistent and getting old.\n" +
                "\t- COM, although conceptually simple, was complex in its actual coding and required lots of ugly, inelegant plumbing.\n" +
                "\t- Another shortcoming of all these programming technologies was that they were aimed primarily at developing code for the desktop " +
                "rather than the internet.\n" +
                "\t- At the time, programming for the Web was an afterthought and seemed very different from coding for the desktop.\n");
            WriteLine("\nGoals for the Next-Generation Platform Services\n" +
                "\t- What was really needed is a new start - an integrated, object-oriented development framework that would bring consistency and elegance back " +
                "to programming.\n" +
                "\t- To meet this need, Microsoft set out to develop a code execution environment and a code development environment that met these goals.\n\n" +
                "\t Execution Environment Goals\n" +
                "\t\t- Security\n" +
                "\t\t- Multiple Platforms\n" +
                "\t\t- Performance\n\n" +
                "\t Development Environment Goals\n" +
                "\t\t- Object-Oriented Development Environment\n" +
                "\t\t- Consistent Programming Exercise\n" +
                "\t\t- Communication Using Industry Standards\n" +
                "\t\t- Simplified Deployment\n" +
                "\t\t- Language Independence\n" +
                "\t\t- Interoperability");
            ReadKey();

            Clear();
        }

        static void EnterMicrosoftDotNet()
        {
            Clear();

            WriteLine("\nEnter Microsoft .NET");
            WriteLine("\t- In 2002, Microsoft released the first version of the .NET Framework, which promised to address the " +
                "old problems and meet the goals for the next-generation systems.\n" +
                "\t- The .NET Framework is a much more consistent and object-oriented environment than either the MFC or COM " +
                "programming technologies.\n" +
                "\t- Some of its features include the following:\n" +
                "\t\t- \'Multiple Platforms\': The system runs on a board range of computers, from servers and desktop machines " +
                "to PDAs and cell phones.\n" +
                "\t\t- \'Industry Standards\': The system uses industry-standard communication protocols, such as XML, HTTP, SOAP, " +
                "JSON, and WSDL.\n" +
                "\t\t- \'Security\': The system can provide a much safer execution environment, even in the presence of the code " +
                "obtained from suspect sources.\n");
            WriteLine("\nComponents of the .NET Framework\n" +
                "\t- The execution environment is called the Common Language Runtime (CLR). The CLR manages program execution at " +
                "run time, including the following:\n" +
                "\t\t- Memory management and garbage collection\n" +
                "\t\t- Code safety verification\n" +
                "\t\t- Code execution, thread management, and exception handling\n" +
                "\t- The programming tools include everything you need for coding and debugging, including the following:\n" +
                "\t\t- The Visual Studio integrated development environment (IDE)\n" +
                "\t\t- .NET-compliant compilers (e.g., C#, Visual Basic.NET, F#, IronRuby, and managed C++)\n" +
                "\t\t- Debuggers\n" +
                "\t\t- Web development server-side technologies, such as ASP.NET and WCF\n" +
                "\t- The Base Class Library (BCL) is a large library used by the .NET Framework and available for you to use in " +
                "your programs as well.\n");
            WriteLine("\nAn Improved Programming Environment\n" +
                "\t- The .NET Framework offers programmers considerable improvements over previous Windows programming environments.\n");
            WriteLine("\nObject-Oriented Development Environment\n" +
                "\t- The CLR, the BCL, and C# are designed to be throughly object-oriented and act as a well-integrated environment.\n" +
                "\t- The system provides a consistent, object-oriented model of programming for both local programs and distributed systems.\n" +
                "\t- It also provides a software development interface for desktop application programming, mobile application programming, " +
                "and web development, consistent across a broad range of targets, from servers to cell phones.\n");
            WriteLine("\nAutomatic Garbage Collection\n" +
                "\t- The CLR has a service called the \'garbage collector\', which automatically manages memory for you.\n" +
                "\t- The GC automatically removes objects from memory that your program will no longer access.\n" +
                "\t- With only a few exceptions, the GC relieves programmers of task they have traditionally had to perform, " +
                "such as deallocating memory and hunting for memory leaks.\n" +
                "\t- This is a huge improvement since hunting for memory leaks can be difficult and time-consuming.\n");
            WriteLine("\nInteroperability\n" +
                "\t- The .NET Framework was designed for interoperability between different .NET languages, the operating systems or " +
                "Win32 DLL, and COM.\n" +
                "\t\t- The .NET language interoperability allows software modules written using different .NET languages to interact seamlessly.\n" +
                "\t\t\t- A program written in one .NET language can use and even inherit from a class written in another .NET language, as long " +
                "as certain rules are followed.\n" +
                "\t\t\t- Because of its ability to easily integrate modules produced in different programming languages, the .NET Framework " +
                "is sometimes described as language-agnostic.\n" +
                "\t\t\t- The .NET Framework provides a feature called \'platform invoke (P/Invoke)\', which allows code written for .NET to call " +
                "and use code not written for .NET. It can use raw C functions imported from standard Win32 DLLs, such as the Windows APIs.\n" +
                "\t\t\t- The .NET Framework also allows interoperability with COM. .NET Framework software components can call COM components, and " +
                "COM components can call .NET components as if they were COM components themselves.\n");
            WriteLine("\nNo COM Required\n" +
                "\t- The .NET Framework frees the programmer from the COM legacy. If you're coming from a COM programming environment, you'll be " +
                "happy to know that, as a C# programmer, you don't need to use any of the following:\n" +
                "\t\t- \'The IUnknown interface\': In COM, all objects must implement interface \'IUnkown\'. In contrast, all .NET objects derive from " +
                "a single class called \'object\'. Interface programming is still an important part of .NET, but it's no longer the central theme.\n" +
                "\t\t- \'Type libraries\': In COM, type information is kept in type libraries as \'.tlb\' files, which are separate from the " +
                "executable code. In .NET, a program's type information is kept bundled with the code in the program file.\n" +
                "\t\t- \'Manual reference counting\': In COM, the programmer had to keep track of the number of references to an object to make sure " +
                "it wasn't deleted at the wrong time. In .NET, the GC keeps track of references and removes objects only when appropriate.\n" +
                "\t\t- \'HRESULT\': COM used the \'HRESULT\' data type to return runtime error codes. .NET doesn't use \'HRESULT\'s. Instead, " +
                "all unexpected runtime errors produce exceptions.\n" +
                "\t\t- \'The registry\': COM applications had to be registered in the system registry, which holds information about the configurations " +
                "of the operting system and applications. .NET don't need to use the registry. This simplifies the installation and removal of programs.\n" +
                "\t- Although the amount of COM code that's currently being written is fairly small, there's still quite a number of COM components in " +
                "systems currently being used, and C# programmers sometimes need to write code that interfaces with those components.\n" +
                "\t- C# 4.0 introduced several new features that make that task easier.\n");
            WriteLine("\nSimplified Deployment\n" +
                "\t- Deploying programs written for the .NET Framework can be much easier than it was before, for the following reasons:\n" +
                "\t\t- The fact that .NET programs don't need to be registered with the registry means that in the simplest case, a program " +
                "just needs to be copied to the target machine and it's ready to run.\n" +
                "\t\t- .NET offers a feature called 'side-by-side execution', which allows different versions of a DLL to exist on the same machine. " +
                "This means that every executable can have access to the version of the DLL for which it was built.\n");
            WriteLine("\nType Safety\n" +
                "\t- The CLR checks and ensures the type safety of parameters and other data objects - even between components written in different " +
                "programming languages.\n");
            WriteLine("\nThe Base Class Library\n" +
                "\t- The .NET Framework supplies an extensive base class library, called, not suprisingly, the 'Base Class Library' (BCL). " +
                "It's also sometimes called the Framework Class Library (FCL).\n" +
                "\t- You can use this extensive set of available code when writing your own programs. Some of the categories are the following:\n" +
                "\t\t- 'General base classes': Classes that provide you with an extremely powerful set of tools for a wide range of programming " +
                "tasks, such as file manipulation, string manipulation, security, and encryption.\n" +
                "\t\t- 'Collection classes': Classes that implement lists, dictionaries, hash tables, and bit arrays.\n" +
                "\t\t- 'Threading and synchronization classes': Classes for building multithreaded programs.\n" +
                "\t\t- 'XML classes': Classes for creating, reading, and manipulating XML documents.\n" +
                "\t- In programming, someone else has almost always needed to previously perform that same task that you are now faced with, particularly " +
                "with respect to the most basic tasks.\n" +
                "\t- The idea of the BCL is to provide you with already built functionality for most generalized task so that your responsiblity is limited " +
                "to piecing together this functionality and writing whatever specialized code is required for your application.\n" +
                "\t- Don't worry - that remaining part still requires plenty of knowledge and skill.\n");
            ReadKey();

            Clear();
        }

        static void CompilingToTheCommonIntermediateLanguage()
        {
            Clear();

            WriteLine("\nCompiling to the Common Intermediate Language");
            WriteLine("\t- The compiler for a .NET language takes a source code file and produce an output called an 'assembly'.\n" +
                "\t\t- An assembly is either an executable or a DLL.\n" +
                "\t\t- The code in an assembly isn't native machine code but an intermediate language called the 'Common Intermediate Language' (CIL).\n" +
                "\t\t- An assembly, among other things, contains the following items:\n" +
                "\t\t\t- The program's CIL\n" +
                "\t\t\t- Metadata about the types used in the program\n" +
                "\t\t\t- Metadata about references to other assemblies\n" +
                "\t- The acronym for the intermediate language has changed over time, and references use different terms. Two other terms for the CIL that " +
                "you might encounter are Intermediate Language (IL) and Microsoft Intermediate Language (MSIL).\n" +
                "\t- The terms were frequently used during .NET's initial development and early documentation, although they are used much less frequently now.\n");
            ReadKey();

            Clear();
        }

        static void CompilingToNativeCodeAndExecution()
        {
            Clear();

            WriteLine("\nCompiling to Native Code Execution");
            WriteLine("\t- The program's CIL isn't compiled to native machine code until it is called to run. At run time, the CLR performs the following steps:\n" +
                "\t\t- It checks the assembly's security characteristics.\n" +
                "\t\t- It allocates space in memory.\n" +
                "\t\t- It sends the assembly's executable code to the just-in-time (JIT) compiler, which compiles portion of it to native code.\n" +
                "\t- The executable code in the assembly is compiled by the JIT compiler only as it's needed. It's then cached in case it is needed for " +
                "execution again later in the program.\n" +
                "\t- Using this process means that code that isn't called during execution isn't compiled to native code and that the code that 'is' " +
                "called needs to be compiled only once.\n" +
                "\t- Once the CIL is compiled to native code, the CLR manages it as it runs, performing tasks as releasing orphaned memory, checking array bounds, " +
                "checking parameter types, and managing exceptions. This brings up two important terms:\n" +
                "\t\t- 'Managed Code': Code written for the .NET Framework is called 'managed code' and needs the CLR.\n" +
                "\t\t- 'Unmanaged Code': Code that doesn't run under the control of the CLR, such as Win32 C and C++ DLLs, is called 'unmanaged code'.\n" +
                "\t- Microsoft also supplies a tool called the 'Native Image Generator', or 'Ngen', which takes an assembly and produces native code for the current " +
                "processor. Code that's been run through Ngen avoids the JIT compilation process at run time.\n" +
                "\t- The same compilation and execution process is followed regardless of the language of the original source files.");
            ReadKey();

            Clear();
        }

        static void TheCommonLanguageRuntime()
        {
            Clear();

            WriteLine("\nThe Common Language Runtime");
            WriteLine("\t -The core component of the .NET Framework is the CLR, which sits on top of the operating system and manages program execution.\n" +
                "\t- The CLR also provides the following services:\n" +
                "\t\t- Automatic Garbage Collection\n" +
                "\t\t- Security and Authentication\n" +
                "\t\t- Extensive programming functionality through access to the BCL - including functionality such as web services and data services.\n");
            ReadKey();

            Clear();
        }

        static void TheCommonLanguageInfrastructure()
        {
            Clear();

            WriteLine("\nThe Common Language Infrastructure");
            WriteLine("\t- Every programming language has a set of intrinsic types representing such objects as integers, floating-point numbers, characters, and so on. " +
                "Historically, the characteristics of these types have varied from one programming language to another and from platform to platform.\n" +
                "\t- The lack of uniformity, however, makes it difficult if we want programs to play well with other programs and libraries written in different " +
                "languages. To have order and cooperation, there must be a set of standards.\n" +
                "\t- The Common Language Infrastructure (CLI) is a set of standards that ties all the components of the .NET Framework into a cohesive, consistent " +
                "system. It lays out the concepts and architecture of the system and specifies the rules and conventions to which all the software must adhere.\n" +
                "\t- The different components of CLI:\n" +
                "\t\t- Common Language Runtime\n" +
                "\t\t- Base Class Library\n" +
                "\t\t- Common Type System\n" +
                "\t\t- Common Language Specification\n" +
                "\t\t- Metadata Definition and Semantics\n" +
                "\t\t- Common Intermediate Language (CIL) Instruction Set\n" +
                "\t- Both the CLI and C# have been approved as open international standard specifications by ECMA International. (The name \"ECMA\" used to be " +
                "acronym for the European Computer Manufacturers Association, but it's now just a word in itself.)\n" +
                "\t- Ecma members include Microsoft, IBM, Hewlett-Packard, Google, Yahoo, and many other corporations associated with computers and consumer " +
                "electronics.\n");
            WriteLine("\nImportant Parts of the CLI\n" +
                "\t- Although most programmers don't need to know the details of the CLI specifications, you should at least be familiar with the meaning " +
                "and purpose of the Common Type System (CTS) and the Common Language Specification (CLS).\n");
            WriteLine("\nThe Common Type System\n" +
                "\t- The CTS define the characteristics of the types that must be used in managed code. Some important aspects of the CTS are the following:\n" +
                "\t\t- The CTS defines a rich set of intrinsic types, with fixed, specific characteristics for each type.\n" +
                "\t\t- The types provided by a .NET-compliant programming language generally map to some specific subset of this defined set of intrinsic types.\n" +
                "\t\t- One of the most important characteristics of the CTS is that 'all' types are derived from a common base class-called 'object'.\n" +
                "\t\t- Using the CTS ensures that the system types and types defined by the user can be used by any .NET-compliant language.\n");
            WriteLine("\nThe Common Language Specification\n" +
                "\t- The CLS specifies the rules, properties, and behaviors of a .NET-compliant programming language. The topics include data types, class " +
                "construction, and parameter passing.\n");
            ReadKey();

            Clear();
        }

        static void ReviewsOfTheAcronyms()
        {
            Clear();

            WriteLine("\nReview of the Acronyms");
            WriteLine("\t- Assembly\n" +
                "\t\t CIL, IL, MSIL - Common Intermediate Language\n" +
                "\n\t- Common Language Infrastructure (CLI)\n" +
                "\t\t CTS - Common Type System\n" +
                "\t\t CLS - Common Language Specification\n" +
                "\n\t- Common Language Runtime (CLR)\n" +
                "\t\t GC  - Garbage Collector\n" +
                "\t\t JIT - Just-In-Time Compiler\n" +
                "\t\t BCL - Base Class Library");
            ReadKey();

            Clear();
        }

        static void TheEvolutionOfCSharp()
        {
            Clear();

            WriteLine("\nThe Evolution of C#");
            WriteLine("\t- The current version of the language is version 7.0. Each new release of the language has generally had a " +
                "specific focus for the new features added.\n" +
                "\n\t\tC# 7.0" +
                "\t- ValueTuples. PatternMatching\n" +
                "\t\tC# 6.0" +
                "\t- Language Enhacements, Roslyn Open Source Compiler\n" +
                "\t\tC# 5.0" +
                "\t- Async\n" +
                "\t\tC# 4.0" +
                "\t- Named and Optional Parameters\n" +
                "\t\tC# 3.0" +
                "\t- LINQ\n" +
                "\t\tC# 2.0" +
                "\t- Generics\n" +
                "\t\tC# 1.0" +
                "\t- C#\n");
            ReadKey();

            Clear();
        }

        static void CSharpAndTheEvolutionOfWindows()
        {
            Clear();

            WriteLine("\nC# and the Evolution of Windows");
            WriteLine("\t- The introduction of the iPhone in 2007 started a major trend in the industry toward portable devices. The iPhone was soon " +
                "followed by the first Android device in 2008 and then by the iPad in 2010.\n" +
                "\t- Microsoft has also been involved in the portable device market, albeit less successfully, first with Windows Mobile (initially called " +
                "PocketPC), then with Windows Phone introduced in 2010, and currently with Windows 10 Mobile.\n" +
                "\t- Beginning in 2011, the quantity of portable devices sold anually exceeded the number of personal computers sold.\n" +
                "\t- In response to these market shifts, Microsoft introduced Windows 8 in 2012. A major goal of this version of Windows was introduce to " +
                "user interface that was similar for both desktop computers and portable devices.\n" +
                "\t- Windows 8 was Microsoft's first operating system capable of working on both ARM-based tablets and traditional x86 PCs. It also " +
                "gave a much greater emphasis to a touch-enabled user interface.\n" +
                "\t- Developers for Windows 8 were encouraged by Microsoft to create \"Metro Apps\", which could, with the appropriate customizations, be " +
                "capable of running on both PCs and portable devices. Metro apps could be developed using any of the following:\n" +
                "\t\t- XAML and C# (or VB.NET or C++)\n" +
                "\t\t- HTML5, CSS3, and JavaScript\n" +
                "\t\t- DirectX and C++\n" +
                "\t- Windows 10, which was introduced in 2015, included Universal Windows Platform apps as the next evolutionary step beyond Metro apps. The " +
                "design goal of universal apps was to be capable of running on multiple Microsoft platforms with nearly identical code.\n" +
                "\t- These platforms include PCs, tablets, smartphones, Xbox One, and a number of more specialized devices.\n" +
                "\t- Universal apps do not, however, target either the Android or iOS platform.\n" +
                "\t- Windows 10 Core (not to be confused with .NET Core) is a common platform present on every device running Windows 10.\n" +
                "\t- Universal apps are capable of calling not only the Windows 10 Core APIs that are common to all Windows 10 devices but also any APIs " +
                "that are specific to individual device families, such as desktop, phone, and Xbox.\n" +
                "\t- This represents a significant integration over Windows 8, which required a considerably greater effort to create applications for " +
                "different categories of devices.\n" +
                "\t- Windows 10 has been generally well recieved and has almost achieved the same level of penetration as Windows 7, the most successful of " +
                "Microsoft's operating systems so far.\n" +
                "\t- Even though Microsoft's penetration in the smartphone and tablet market is considerably smaller than that of Android or Apple, universal apps " +
                "nevertheless offer developers a nice extension on the marketplace for their applications.\n" +
                "\t- The same programming languages listed earlier for developing Metro apps can also be used for developing Universal apps. While there are also " +
                "other options, C# is an excellent choice because of its integration with Visual Studio and support from Microsoft.\n" +
                "\t- The 2017 Developer Survey on StackOverflow listed C# as the fourth most used programming language (after JavaScript, SQL, and Java) and the " +
                "eight most loved programming language (ahead of JavaScript, SQL, and Java).\n" +
                "\t- C# didn't even make the top 25 list of most \"dreaded\" programming languages.\n" +
                "\t- The conclusion is obvious, Tens of thousands of developers use C# on a regular basis, and a high percentage are very happy with it. " +
                "It is an elegant language.");
            ReadKey();

            Clear();
        }
    }

    public static class Two
    {
        public static void CSharpAndDotNetCore()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tC# and .NET Core\n");
                WriteLine("\t1. The .NET Framework Background\n\t2. Why .NET Core (and Xamarin)?\n\t3. Goals of .NET Core" +
                    "\n\t4. Multiplatform Support\n\t5. Rapid Development and Upgrades" +
                    "\n\t6. Smaller Application Footprints, Simpler Deployment, and Reduced Versioning Problems" +
                    "\n\t7. Open Source Community Support\n\t8. Improved Application Performance\n\t9. Fresh Start" +
                    "\n\t10. The Development of .NET Core\n\t11. Where Does This Leave the .NET Framework" +
                    "\n\t12. Where Does Xamarin Fit In?\n\t13. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                TwoDecision(ref choice);

            } while (choice != 13);
            Clear();
        }

        static void TwoDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    TheDotNetFrameworkBackground();
                    break;
                case 2:
                    WhyDotNetCoreAndXamarin();
                    break;
                case 3:
                    GoalsOfDotNetCore();
                    break;
                case 4:
                    MultiplatformSupport();
                    break;
                case 5:
                    RapidDevelopmentAndUpgrades();
                    break;
                case 6:
                    SmallerApplicationFootprintsSimplerDeploymentAndReducedVersioningProblems();
                    break;
                case 7:
                    OpenSourceCommunitySupport();
                    break;
                case 8:
                    ImprovedApplicationPerformance();
                    break;
                case 9:
                    FreshStart();
                    break;
                case 10:
                    TheDevelopmentOfDotNetCore();
                    break;
                case 11:
                    WhereDoesThisLeaveTheDotNetFramework();
                    break;
                case 12:
                    WhereDoesXamarinFitIn();
                    break;
                default:
                    Clear();
                    break;                
            }
        }

        static void TheDotNetFrameworkBackground()
        {
            Clear();

            WriteLine("\nThe .NET Framework Background\n" +
                "\t- The .NET Framework was originally released in 2002. In terms of programming frameworks, that makes it \"mature\" in the sense " +
                "that it contains virtually every significant, desirable feature currently available in major programming languages.\n" +
                "\t- Nevertheless, it would be a mistake to think that .NET has reached \"old age\": \"middle-aged\" would be a much closer description.\n" +
                "\t- After all, C and C++ have been around for far longer than C#.\n" +
                "\t- While the .NET Framework is still an excellent choice for developing the type of applications that it was initially designed to create, " +
                "the world of computing has changed a lot in the past several years.");
            ReadKey();

            Clear();
        }

        static void WhyDotNetCoreAndXamarin()
        {
            Clear();

            WriteLine("\nWhy .NET Core and Xamarin?\n" +
                "\t- The .NET Framework was created principally for developing applications to be used on computers (both server and client workstations) " +
                "running the Windows operating system.\n" +
                "\t- At the time that .NET was introduced, Microsoft had a dominant position in operating systems for personal computers, and smartphones " +
                "were still years away. Over time, however, both Unix and Apple managed to cut into Microsoft's market share in computers.\n" +
                "\t- Moreover, a much more significant development has been the massive shift toward mobile devices, an area where Microsoft's share " +
                "(whether measured by hardware and software) has been neglible.\n" +
                "\t- A third major trend has been the increase in the share of web-based applications rather than desktop-based applications.\n" +
                "\t- The effect of these three trends have been a reduction in the importance of Windows desktop application in favor of web and mobile " +
                "applications as well as desktop applications running on operating systems other than Windows.\n" +
                "\t- That by no means, suggest that Windows desktop applications will be dying out any time soon; it's just that most people believe that " +
                "the largest future growth will be in web and mobile applications.\n" +
                "\t- With this in mind, Microsoft concluded that it could better address web development, as well as development for computers running Linux " +
                "or macOS, with a cloud-enabled, cross-platform, open source derivative of the .NET Framework. It labeled that new framework .NET Core.\n" +
                "\t- At about the same time, Microsoft acquired Xamarin to address development on mobile platforms such as Android and iOS.\n" +
                "\t- The key thing to keep in mind is that whether you will be developing full .NET Framework applications, .NET Core applications, or " +
                "Xamarin applications, in each case you can use the C# language.");
            ReadKey();

            Clear();
        }

        static void GoalsOfDotNetCore()
        {
            Clear();

            WriteLine("\nGoals of .NET Core\n" +
                "\t- The following list summarizes the principal goals of .NET Core:\n" +
                "\t\t- Multiplatform support\n" +
                "\t\t- Rapid development and upgrades\n" +
                "\t\t- Smaller application footprints\n" +
                "\t\t- Simpler deployment\n" +
                "\t\t- Reduced versioning problems\n" +
                "\t\t- Open source community support\n" +
                "\t\t- Improved application performance\n" +
                "\t\t- Fresh start");         
            ReadKey();

            Clear();
        }

        static void MultiplatformSupport()
        {
            Clear();

            WriteLine("\nMultiplatform Support\n" +
                "\t- Since the beginning of the computer era, the holy grail of programming framework has been \"Write once. Run everywhere.\"\n" +
                "\t- Even now that goal remains elusive, although most new efforts seem to bring us closer. .NET Core allows developers to create " +
                "applications that will run on Windows and, minor modifications, on Linux and macOS.\n" +
                "\t- There are beta versions of .NET Core that are capable of running on ARM processors (e.g., Raspberry Pi).\n" +
                "\t- Multiplatform support also extends to developing on operating systems beyond Windows. Visual Studio Code is a new integrated " +
                "development environment (IDE) created by Microsoft that can run on Linux, macOS, and Windows.");
            ReadKey();

            Clear();
        }

        static void RapidDevelopmentAndUpgrades()
        {
            Clear();

            WriteLine("\nThe Common Language Runtime\n" +
                "\t- In the past, it was common for software to experience major releases every two or three years. Between releases, there were usually " +
                "one or more service packs containing bug fixes and minor improvements.\n" +
                "\t- Nowadays, users expect improvements to come on a much more accelerated schedule.\n" +
                "\t- The initial version of the .NET Framework was distributed in large measure via CD-ROM, and it was only a few years earlier that major " +
                "software releases involved a large stack of floppy disk.\n" +
                "\t- When the Internet first reached public consciousness, dial-up speeds often were nominally 14.4 ir 28.8 kilobits per second.\n" +
                "\t- Today, by contrast, most software is delivered over the Internet at speeds hundreds or even thousands of times faster than once was " +
                "possible.\n" +
                "\t- Applications are programmed to check the server for available updates and, depending on user preference, either install those updates " +
                "automatically or prompt the user for a decision as to timing.\n" +
                "\t- Applications are typically designed in a modular fashion so that different components can be independently upgraded without requiring " +
                "the entire application to be replaced.\n" +
                "\t- In this regard, .NET Core is highly modular, and upgrades can be performed automatically via NuGet packages.\n");
            ReadKey();

            Clear();
        }

        static void SmallerApplicationFootprintsSimplerDeploymentAndReducedVersioningProblems()
        {
            Clear();

            WriteLine("\nSmaller Application Footprints, Simpler Deployment, and Reduced Versioning Problems\n" +
                "\t- The distribution of .NET Core is based on NuGet packages. 'Packages' are libraries of code that provide certain units of functionality.\n" +
                "\t- Packages are stored in the NuGet Gallery from which they are downloaded as needed. Developers can decide how modular the packages " +
                "they create will be.\n" +
                "\t- By contrast, the .NET Framework, which now contains more than 20,000 classes, must be installed in its entirety both on any development " +
                "workstation and on each application user's computer. \n" +
                "\t- By specifying only relevant packages, the total footprint of a .NET Core application can be smaller that the equivalent footprint of a " +
                "full-fledged .NET Framework application.\n" +
                "\t- Admittedly, the .NET Framework itself only needs to be installed once per client workstation (per version), but that installation is, " +
                "in contrast, quite lengthy.\n" +
                "\t- Moreover, the requirement that all target computers for .NET Framework applications must have the identical version of .NET with which the " +
                "application was developed may present problems if for any reason it's not possible to upgrade the .NET Framework on a target computer.\n" +
                "\t- This may be because of permissions, company policies, or other factors. This may require recompiling the application for that particular " +
                "user or users with an earlier version of .NET.\n" +
                "\t- By contrast, .NET Core applications do not suffer from this same constraint. The .NET Core framework can be distributed side by side with " +
                "the application code, so there can never be a versioning conflict.\n" +
                "\t- In those cases where the .NET Core framework already exists on a target computer, an application can optionally choose to use the existing " +
                "code, thereby further reducing the application's installation footprint.\n" +
                "\t- Moreover, since every application can have its own copy of the .NET Core libraries, it is possible to have multiple .NET Core applications " +
                "running side by side on the same computer using different versions of .NET Core.\n" +
                "\t- This would allow different applications to be upgraded at different times rather than requiring all such applications to be upgraded " +
                "simultaneously.\n");
            ReadKey();

            Clear();
        }

        static void OpenSourceCommunitySupport()
        {
            Clear();

            WriteLine("\nOpen Source Community Support\n" +
                "\t- It is generally percieved that the benefits of open source software are lower costs, greater flexibility (including customizability), " +
                "greater freedom, higher security, and higher accountability.\n" +
                "\t- The source code for proprietory software is generally a closely guarded secret. If that software contains a bug or an anomalous edge case " +
                "behavior, users of that software have no way of knowing how the software works internally.\n" +
                "\t- By contrast, open source software can be seen by anyone with the appropriate tools in order to understand what might be causing the bug or " +
                "anomalous behavior.\n" +
                "\t- With that knowledge in hand, developers can either fix the bug or modify their own code that interacts with the code to avoid undesirable " +
                "results.\n" +
                "\t- When hundreds or even potentially thousands of developers are available to fix bugs as soon as they are discovered, these fixes will likely " +
                "occur much more rapidly than in the case of proprietory software. At least in theory, this can result in more secure and more stable code.\n" +
                "\t- Developers are also free to modify or extend open source software. This gives users greater flexibility than in the case of proprietary " +
                "software. Moreover, if these modifications or extensions are contributed back to the project, other users can benefit from these changes.\n");
            ReadKey();

            Clear();
        }

        static void ImprovedApplicationPerformance()
        {
            Clear();

            WriteLine("\nImproved Application Performance\n" +
                "\t- In most cases, both .NET Framework applications and .NET Core applications use a just-in-time compiler to convert the CIL code into " +
                "machine-specific code on the fly when the application launches.\n" +
                "\t- While this provides a generally acceptable level of performance, .NET Core apps can be precompiled to native code on Windows, Linux, or " +
                "macOS.\n" +
                "\t- While the results of this process will vary depending on a number of factors, in some cases this can result in significant improvements " +
                "in application performance.\n");
            ReadKey();

            Clear();
        }

        static void FreshStart()
        {
            Clear();

            WriteLine("\nFresh Start\n" +
                "\t- By creating a new framework based on the existing .NET Framework but without abandoning the full .NET Framework, Microsoft is able to " +
                "decouple obsolete and legacy elements while implementing a new framework design structure that is more suited to today's environment.\n");
            ReadKey();

            Clear();
        }

        static void TheDevelopmentOfDotNetCore()
        {
            Clear();

            WriteLine("\nThe Development of .NET Core\n" +
                "\t- .NET Core 1.0 was released in June 2016 followed by version 1.1 in March 2017. Version 1.1 added support for several new OS distributions, " +
                "a number of new APIs, and some bug fixes.\n" +
                "\t- Version 2.0 was released in August 2017. This release included a substantial increase in the number of APIs as well as major performance " +
                "improvements. This release also included support for Visual Basic .NET.\n" +
                "\t- As you can see, the pace of improvements in .NET Core is much more rapid than in the .NET Framework.\n");
            ReadKey();

            Clear();
        }

        static void WhereDoesThisLeaveTheDotNetFramework()
        {
            Clear();

            WriteLine("\nWhere Does This Leave The .NET Framework?\n" +
                "\t- There is no need to worry about the fate of the .NET Framework. Microsoft has promised that the .NET Framework will continue to evolve " +
                "and will continue to be supported in the current and future versions of the Windows operating system.\n" +
                "\t- As such, it will continue to play a critical role in the development of Windows desktop applications, particularly in the enterprise space, " +
                "(where coincidentally, many of the highest-paying jobs reside).\n" +
                "\t- The advantages of .NET Core, make it the platform of choice for web (ASP.NET Core) and Universal Windows Platform application development.\n" +
                "\t- At the same time, .NET Core is also generally the best option for developing applications designed to run on Linux or macOS.\n");
            ReadKey();

            Clear();
        }

        static void WhereDoesXamarinFitIn()
        {
            Clear();

            WriteLine("\nWhere Does Xamarin Fit In?\n" +
                "\t- Xamarin is a platform that permits the development of native Android, iOS, and Windows application using C# and the .NET libraries.\n" +
                "\t- On a PC, Xamarin development takes place within Visual Studio (after additional features have been enabled).\n" +
                "\t- On a Mac, development is done using Visual Studion for Mac, the successor to Xamarin Studio.\n" +
                "\t- Regardless of IDE and whether the targeted platform is Android, iOS, or Windows, the development language will be C#. \n" +
                "\t- Xamarin, therefore, provides another broadening of the locations where C# can be your development language of choice.\n" +
                "\t- In 2016, Xamarin was acquired by Microsoft, and subsequently Xamarin has been bundled with Visual Studio.\n" +
                "\t- Even the Community (free) edition of Visual Studio includes Xamarin.\n" +
                "\t- The Xamarin SDK is now open source. \n" +
                "\t- Microsoft refers to Xamarin as \".NET cross-platform mobile\". Technically, Xamarin's capabilities extend somewhat beyond that.\n");               
            ReadKey();

            Clear();
        }
    }

    public static class Three
    {
        public static void OverviewOfCSharpProgramming()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tOverview of C# Programming\n");
                WriteLine("\t1. A Simple C# Program\n\t2. Identifiers\n\t3. Keywords\n\t4. Main: The Starting Point of a Program" +
                    "\n\t5. Whitespace\n\t6. Statements\n\t7. Text Output from a Program\n\t8. Comments: Annotating the Code." +
                    "\n\t9. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                ThreeDecision(ref choice);

            } while (choice != 9);
            Clear();
        }

        static void ThreeDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    ASimpleCSharpProgram();
                    break;
                case 2:
                    Identifiers();
                    break;
                case 3:
                    Keywords();
                    break;
                case 4:
                    MainStartingPointOfAProgram();
                    break;
                case 5:
                    Whitespace();
                    break;
                case 6:
                    Statements();
                    break;
                case 7:
                    TextOutputFromAProgram();
                    break;
                case 8:
                    CommentsAnnotatingTheCode();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void ASimpleCSharpProgram()
        {
            Clear();

            WriteLine("\nA Simple C# Program\n");
            WriteLine("\t- A C# Program consists of one or more type declarations\n");
            WriteLine("\t- The types in a program can be declared in any order.\n");
            WriteLine("\t- A \'namespace\' is a set of type declarations associated with a name.\n");
            WriteLine("\t- To compile the program, you can use Visual Studio or the command-line compiler." +
                "To use the command-line compiler, in its simplest form, use the following command in a command window." +
                "\n\t\t\"csc ProgramName.cs\"" +
                "\n\t  In this command, \'csc\' is the name of the command-line compiler, \'csc\' stands for \"C-sharp compiler\".");
            ReadKey();

            Clear();
        }

        static void Identifiers()
        {
            Clear();

            WriteLine("\nIdentifiers\n");
            WriteLine("\t- \'Identifiers\' are character strings used to name things such as variables, methods, parameters, and a host of other programming constructs.\n");
            WriteLine("\t- You can create self-documenting identifiers by concatenating meaningful words into a single descriptive name, using uppercase and lowercase letters.\n");
            WriteLine("\t- Certain characters are allowed or disallowed at certain positions in an identifier.");
            WriteLine("\t\t- The alphabetic and underscore characters (\'a\' through \'z\', \'A\' through \'Z\', and \'_\') are allowed at any position." +
                "\n\t\t- Digits are not allowed in the first position but are allowed everywhere else." +
                "\n\t\t- The \'@\' character is allowed in the first position of an identifier but not at any other position. Although allowed, its use is generally discouraged.\n");
            WriteLine("\t- Identifiers are case sensitive, using similar names will make code more error-prone and debugging more difficult. " +
                "Those debugging your code at some point later will not be pleased.\n");
            WriteLine("\t- The importance of using clear, consistent, and functionally descriptive terminology cannot be overemphasized.");
            ReadKey();

            Clear();
        }

        static void Keywords()
        {
            Clear();

            WriteLine("\nKeywords\n");
            WriteLine("\t- \'Keywords\' are the character string tokens used to define the C# language.\n");
            WriteLine("\t- Some important things to know about keywords are the following:\n" +
                "\t\t- Keywords cannot be used as variable names or any other form of identifier, unless prefaced with the @ character.\n" +
                "\t\t- All C# keywords consist entirely of lowercase letters. (.NET types names, however, use Pascal casing.)\n");
            WriteLine("\tabstract\tconst\t\textern\t\tint\t\tout\t\tshort\t\ttypeof\n" +
                "\tas\t\tcontinue\tfalse\t\tinterface\toverride\tsizeof\t\tuint\n" +
                "\tbase\t\tdecimal\t\tfinally\t\tinternal\tparams\t\tstackalloc\tulong\n" +
                "\tbool\t\tdefault\t\tfixed\t\tis\t\tprivate\t\tstatic\t\tunchecked\n" +
                "\tbreak\t\tdelegate\tfloat\t\tlock\t\tprotected\tstring\t\tunsafe\n" +
                "\tbyte\t\tdo\t\tfor\t\tlong\t\tpublic\t\tstruct\t\tushort\n" +
                "\tcase\t\tdouble\t\tforeach\t\tnamespace\treadonly\tswitch\t\tusing\n" +
                "\tcatch\t\telse\t\tgoto\t\tnew\t\tref\t\tthis\t\tvirtual\n" +
                "\tchar\t\tenum\t\tif\t\tnull\t\treturn\t\tthrow\t\tvoid\n" +
                "\tchecked\t\tevent\t\timplicit\tobject\t\tsbyte\t\ttrue\t\tvolatile\n" +
                "\tclass\t\texplicit\tin\t\toperator\tsealed\t\ttry\t\twhen\n" +
                "\twhile\n");
            WriteLine("\t- \'Contextual keywords\' are identifiers that act as keywords only in certain language constructs. In those positions, they have particular meanings; " +
                "but unlike keywords, which cannot be used as identifiers, contextual keywords can be used as identifiers in other parts of the code.\n");
            WriteLine("\tadd\t\tascending\tasync\t\tawait\t\tby\t\tdescending\tdynamic\n" +
                "\tequals\t\tfrom\t\tget\t\tglobal\t\tgroup\t\tin\t\tinto\n" +
                "\tjoin\t\tlet\t\ton\t\torderby\t\tpartial\t\tremove\t\tselect\n" +
                "\tset\t\tvalue\t\tvar\t\twhere\t\tyield\n");
            ReadKey();

            Clear();
        }

        static void MainStartingPointOfAProgram()
        {
            Clear();

            WriteLine("\nMain: The Starting Point of a Program\n");
            WriteLine("\t- Every C# Program must have one class with the method called \'Main\'");
            WriteLine("\t\t- The starting point of execution of every C# program is at the first instruction in Main.\n" +
                "\t\t- The name Main must be capitalized.");
            ReadKey();

            Clear();
        }

        static void Whitespace()
        {
            Clear();

            WriteLine("\nWhitespace\n");
            WriteLine("\t- \'Whitespace\' in a program refers to characters that do not have visible output character.\n");
            WriteLine("\t- Whitespace in source code is ignored by the compiler but is used by the programmer to make the code clearer and easier to read.\n");
            WriteLine("\t\t- Space\n" +
                "\t\t- Tab\n" +
                "\t\t- New line\n" +
                "\t\t- Carriage return\n");
            ReadKey();

            Clear();
        }

        static void Statements()
        {
            Clear();

            WriteLine("\nStatements\n");
            WriteLine("\t- The statements in C# are similar to those of C and C++\n");
            WriteLine("\t- A \'statement\' is a source code instruction describing a type or telling the program to perform an action.\n");
            WriteLine("\t- A \'simple statement\' is terminated by a semicolon.\n");
            WriteLine("\nBlocks\n");
            WriteLine("\t- A \'block\' is a sequence of zero or more statements enclosed by a matching set of curly braces; it acts as a single syntactic statement.\n");
            WriteLine("\t- Some important things to know about blocks are the following:");
            WriteLine("\t\t- You can use a block whenever the syntax requires a statement but the action you need requires more than one simple statement.\n" +
                "\t\t- Certain program constructs \'require\' blocks. In these constructs, you cannot substitute a simple statement for the block.\n" +
                "\t\t- Although a simple statement is terminated by a semicolon, a block is not followed by a semicolon.");
            ReadKey();

            Clear();
        }

        static void TextOutputFromAProgram()
        {
            Clear();

            WriteLine("\nText Output From A Program\n");
            WriteLine("\t- A \'console window\' is a simple command prompt window that allows a program to display text and recieve input krom the keyboard.\n");
            WriteLine("\t- The BCL supplies a class called \'Console\' (in the \'System\' namespace), which contains methods for inputting and outputting data to a console window.\n");
            WriteLine("\nWrite\n");
            WriteLine("\t- \'Write\' is a member of the \'Console\' class. It sends a text string to the program's console window.\n");
            WriteLine("\t- \'Write\' sends a literal string of text to the window.\n");
            WriteLine("\t- The string must be enclosed in quotation marks - double qoutes, \'not single qoutes\'.\n");
            WriteLine("\t- The following line of code shows an example of using the \'Write\' member:\n");
            WriteLine("\t\tConsole.Write(\"This is some text.\");\n");
            WriteLine("\nWriteLine\n");
            WriteLine("\t- WriteLine is another member of \'Console\'; it performs the same function as \'Write\' but appends a newline character to the end of each output string.\n");
            WriteLine("\nThe Format String\n");
            WriteLine("\t- The general form of the \'Write\' and \'WriteLine\' statements can take more than a single parameter.");
            WriteLine("\t\t- If there is more than a single parameter, the parameters are separated by commas.\n" +
                "\t\t- The first parameter must always be and is called the \'format string\'. The format string can contain \'substitution markers\'.\n" +
                "\t\t\t- A substitution marker marks the position in the format string where a value should be substituted in the output string.\n" +
                "\t\t\t- A substitution marker consists of an integer enclosed in a set of marching curly braces.\n" +
                "\t\t\t- The integer is the numeric position of the substitution value to be used.\n" +
                "\t\t\t- The parameters following the format string are called \'substitution values\'.\n" +
                "\t\t\t- These substitution values are numbered, starting at 0.\n");
            WriteLine("\t- The syntax is as follows:\n\n" +
                "\t\tConsole.WriteLine( FormatString, SubVal0, SubVal1, SubVal2, ... );\n");
            WriteLine("\t- C# 6.0 introduced a simplified syntax to allow you to restate parameterized strings in an easier-to-understand manner.\n\n" +
                "\t- This syntax is refered to as \'string interpolation\' and consists of inserting the variable name directly into the substitution marker.\n\n" +
                "\t- In effect, the substitution marker tells the compiler that the variable name is to be treated as a variable and not as a string literal - provided that the string " +
                "is preceded by the \'$\' symbol.\n\n" +
                "\t\tConsole.WriteLine($\"Two sample integers are {variable1} and {variable2}\");\n\n" +
                "\t- While the new syntax is easier to understand, the vast majority of the current C# code base uses the old syntax, so it is important that you be able to recognize and " +
                "work with it.\n");
            WriteLine("\nMultiple Markers and Values\n\n" +
                "\t- In C#, you can use any number of markers and any number of values.\n" +
                "\t\t- The values can be used in any order.\n" +
                "\t\t- The values can be substituted any number of times in the format string.\n\n" +
                "\t- A marker must not attempt to reference a value at a position beyond the length of the list of substitution value.\n\n" +
                "\t- If it does, it will \'not produce a compile error but a runtime error\' (called an \'exception\').\n");
            WriteLine("\nFormatting Numeric Strings\n\n" +
                "\t- The syntax for a format specifier consists of three fields inside the set of curly braces: the index (string interpolation variable), the alignment specifier, and" +
                " the format field.\n\n" +
                "\t\t{ index, alignment:format }\n\n" +
                "\t - The index specifies which item from the list following the format string should be formatted. Unless a string interpolation variable is specified, the index is " +
                "required, and the number of the list items starts at 0.\n\n");
            WriteLine("\nThe Alignment Specifier\n\n" +
                "\t- The alignment specifier represents the \'minimum width\' of the field in terms of characters.\n\n" +
                "\t- The alignment specifier has the following characteristics:\n" +
                "\t\t- The alignment specifier is optional and separated from the index with a comma.\n" +
                "\t\t- It consists of a positive or negative integer.\n" +
                "\t\t\t- The integer represents the minimum number of characters to use for the field.\n" +
                "\t\t\t- The sign represents either right or left alignment. A positive number specifies right alignment; a negative number specifies left alignment.\n\n" +
                "\t- The actual representation of the value might take more or fewer characters than specified in the alignment specifier.\n" +
                "\t\t- If the representation takes fewer characters than specified in the alignment specifier, the remaining characters are padded with spaces.\n" +
                "\t\t- If the representation takes more characters than specified, the alignment specifier is ignored, and the representation uses as many characters as are needed.\n\n");
            WriteLine("\nThe Format Field\n\n" +
                "\t- The format field specifies the form that the numeric representation should take.\n\n" +
                "\t- The format field has three parts:\n" +
                "\t\t- The colon character must be next to the format specifier, with no intervening spaces.\n" +
                "\t\t- The \'format specifier\' is a single alphabetic character, from a set of nine built-in character formats.\n" +
                "\t\t- The character can be uppercase or lowercase. The case is significant for some specifiers but not for others.\n" +
                "\t\t- The \'precision specifier\' is optional and consists of one or two digits. Its actual meaning depends on the format specifier.\n\n");
            ReadKey();

            Clear();
        }

        static void CommentsAnnotatingTheCode()
        {
            Clear();

            WriteLine("\nComments: Annotating the Code\n");
            WriteLine("\t- Delimited comments have a two-character start marker ( /* ) and a two-character end marker ( */ ).\n\n" +
                "\t- Text between the matching markers is ignored by the compiler.\n\n" +
                "\t- Delimited comments can span any number of lines.\n\n" +
                "\t- A delimited comment can also span just part of a line.\n\n" +
                "\t- Sinle-line and delimited comments behave in C# just as they do in C and C++.\n");
            WriteLine("\nMore About Comments\n\n" +
                "\t- You cannot nested delimited comments. Only one comment can be in effect at a time.\n\n" +
                "\t- If you attempt to nest comments, the comment that starts first will remain in effect until the end of its scope.\n\n" +
                "\t- The scope for comment types is as follows:\n" +
                "\t\t- For single-line comments, the comment will remain in effect until the end of the current line.\n" +
                "\t\t- For delimited comments, the comment will remain in effect until the \'first\' end delimiter is encountered.\n");
            WriteLine("\nDocumentation Comments\n\n" +
                "\t- Documentation comments contain XML text that can be used to produce program documentation.\n\n" +
                "\t- Comments of this type look like single-line comments except that they have three contiguous slashes rather than two.\n");
            WriteLine("\nSummary of Comment Types\n\n" +
                "\t- Inline comments are sections of text that are ignored by the compiler but are included in the code to document it.\n\n" +
                "\t- Programmers insert comments into thier code to explain and document it.\n\n" +
                "\t- While comments that do little more than repeat the name of a variable or method are generally of minimal value, comments that explain the " +
                "purpose of a given block of code can be enormously useful during subsequent maintenance.\n\n" +
                "\t- Since all valuable code will eventually require maintenance, you can save a lot of effort by reading what the original developer had in mind " +
                "with the block of code at issue.");
            ReadKey();

            Clear();
        }
    }

    public static class Four
    {
        public static void TypesStorageAndVariables()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\tTypes, Storage, and Variables\n");
                WriteLine("\t1. A C# Program Is a Set of Type Declarations\n\t2. A Type is a Template\n\t3. Instantiating a Type" +
                    "\n\t4. Data Members and Function Members\n\t5. Predefined Types\n\t6. User-Defined Types" +
                    "\n\t7. The Stack and the Heap\n\t8. Value Types and Reference Type\n\t9. Variables" +
                    "\n\t10. Static Typing and the dynamic Keyword\n\t11. Nullable Types\n\t12. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                FourDecision(ref choice);

            } while (choice != 12);
            Clear();
        }

        static void FourDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    ACSharpProgramIsASetOfTypeDeclaration();
                    break;
                case 2:
                    ATypeIsATemplate();
                    break;
                case 3:
                    InstantiatingAType();
                    break;
                case 4:
                    DataMembersAndFunctionMembers();
                    break;
                case 5:
                    PredefinedTypes();
                    break;
                case 6:
                    UserDefinedTypes();
                    break;
                case 7:
                    TheStackAndTheHeap();
                    break;
                case 8:
                    ValueTypesAndReferenceTypes();
                    break;
                case 9:
                    Variables();
                    break;
                case 10:
                    StaticTypingAndThedynamicKeyword();
                    break;
                case 11:
                    NullableTypes();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void ACSharpProgramIsASetOfTypeDeclaration()
        {
            Clear();

            WriteLine("\nA C# Program Is a Set of Type Declarations\n" +
                "\t- If you were to broadly characterize the source code of C and C++ programs, you might say that a C program is a set of functions and data " +
                "types and that a C++ program is a set of functions and classes.\n" +
                "\t- A C# program, however is a set of type declarations.\n" +
                "\t\t- The source code of a C# program or DLL is a set of one or more type declarations.\n" +
                "\t\t- For an executable, one of the types declared must be a class that includes a method called 'Main'.\n" +
                "\t\t- A 'namespace' is a way of grouping a related set of type declarations and giving the group a name. Since your program is a related set of " +
                "type declarations, you will generally declare your program type inside a namespace you create.");
            ReadKey();

            Clear();
        }

        static void ATypeIsATemplate()
        {
            Clear();

            WriteLine("\nA Type Is a Template\n" +
                "\t- Since a C# program is just a set of type declarations, learning C# consists of learning how to create and use types, So, the first thing " +
                "you need to do is to look at what a type is.\n" +
                "\t- You can start by thinking of a type as a 'template' for creating data structures. It isn't the data structure itself, but it specifies the " +
                "characteristics of objects constructed from the template.\n" +
                "\t- A type is defined by the following elements:\n" +
                "\t\t- A name\n" +
                "\t\t- A data structure to contain its data members\n" +
                "\t\t- Behavior and constraints\n");
            ReadKey();

            Clear();
        }

        static void InstantiatingAType()
        {
            Clear();

            WriteLine("\nInstantiating a Type\n" +
                "\t- Creating an actual object from the type's template is called 'instantiating' the type.\n" +
                "\t\t- The object created by instantiating a type is called either an 'object' of the type or an 'instance' of the type. The terms are " +
                "interchangeable.\n" +
                "\t\t- Every data item in a C# program is an instance of some type provided by by the language, the BCL, or another library, or defined " +
                "by the programmer.\n");
            ReadKey();

            Clear();
        }

        static void DataMembersAndFunctionMembers()
        {
            Clear();

            WriteLine("\nData Members and Function Members\n" +
                "\t- Some types, such as 'short', and 'long', are called 'simple types' and can store only a single data item.\n" +
                "\t- Other types can store multiple data items. An 'array' is a type that can store multiple items of the same type. The individual " +
                "items are called 'elements' and are referenced by a number, called an 'index'.\n");
            WriteLine("\nTypes of Members\n" +
                "\t- There are other types, however, that can contain data items of many different types. The individual elements in these types are called " +
                "'members', and unlike arrays, in which each member is referred to by a number, these members have a distinct names.\n" +
                "\t- There are two kinds of members: data members and function members.\n" +
                "\t\t- 'Data members' store data that is relevant to the object of the class or to the class as a whole.\n" +
                "\t\t- 'Function members' execute code. Function members define how the type can act.\n");
            ReadKey();

            Clear();
        }

        static void PredefinedTypes()
        {
            Clear();

            WriteLine("\nPredefined Types\n" +
                "\t- C# provides 16 predefined types, they include 13 simple types and 3 nonsimple types.\n" +
                "\t- The names of all the predefined types consist of 'all lowercase' characters. The predefined simple types include the following:\n" +
                "\t\t- Eleven numeric types, including the following:\n" +
                "\t\t\t- Various lengths of signed and unsigned integer types.\n" +
                "\t\t\t- Floating-point types-'float' and 'double'.\n" +
                "\t\t\t- A high-precision decimal type called 'decimal'. Unlike 'float' and 'double', type  'decimal' can represent decimal fractional " +
                "numbers exactly. It's often used for monetary calculations.\n" +
                "\t\t- A Unicode character type, called 'char'.\n" +
                "\t\t- A Boolean type, called 'bool'. Type 'bool' represents Boolean values and must be one of two values-either 'true' of 'false'.\n" +
                "\t- Unlike C and C++, in C# numeric values do not have a Boolean interpretation.\n" +
                "\t- The three nonsimple types are the following:\n" +
                "\t\t- Type 'string', which is an array of Unicode characters.\n" +
                "\t\t- Type 'object', which is the base type on which all other types are based.\n" +
                "\t\t- Type 'dynamic', which is used when using assemblies written in dynamic languages.\n");
            WriteLine("\nMore About Predefined Types\n" +
                "\t- All the predefined types are mapped directly to underlying .NET types. The C# types names are simply aliases for the .NET types, so " +
                "using the .NET names works fine syntactically, although this is discouraged.\n" +
                "\t- Within a C# program, you should use the C# names rather than the .NET names.\n" +
                "\t- The predefined simple types represent a single item of data, along with the ranges of values they can represent and the underlying " +
                ".NET types to which they belong.\n");
            ReadKey();

            Clear();
        }

        static void UserDefinedTypes()
        {
            Clear();

            WriteLine("\nUser-Defined Types\n" +
                "\t- Besides the 16 predefined types provided by C#, you can also create your own user-defined types. There are six kinds of types you can create.\n" +
                "\t\t- 'class' types\n" +
                "\t\t- 'struct' types\n" +
                "\t\t- 'array' types\n" +
                "\t\t- 'enum' types\n" +
                "\t\t- 'delegate' types\n" +
                "\t\t- 'interface' types\n" +
                "\t- You create a type using a 'type declaration', which includes the following information:\n" +
                "\t\t- The kind of type you are writing\n" +
                "\t\t- The name of the new type\n" +
                "\t\t- A declaration (name and specification) of each of the type's members - except for 'array' and 'delegate' types, which don't have named members.\n" +
                "\t- Once you've declared a type, you can create and use objects of the type just as if they were predefined types.\n" +
                "\t- Using a predefined types is a one-step process in which you simply instantiate the objects of the type. Using a user-defined types is a two-step " +
                "process. You must first declare the type and then instantiate objects of the type.\n" +
                "\t- The predefine types requires instantiation only. The user-defined types require two steps: declaration and instantiation.\n");
            ReadKey();

            Clear();
        }

        static void TheStackAndTheHeap()
        {
            Clear();

            WriteLine("\nThe Stack and the Heap\n" +
                "\t- While a program is running, its data must be stored in memory. How much memory is required for an item, and where and how it's stored, " +
                "depends on its type.\n" +
                "\t- A running program uses two region of memory to store data: the 'stack' and the 'heap'.\n");
            WriteLine("\nThe Stack\n" +
                "\t- The stack is an array of memory that acts as a last-in, first-out (LIFO) data structure. It stores several types of data.\n" +
                "\t\t- The values of certain types of variables\n" +
                "\t\t- The program's current execution environment\n" +
                "\t\t- Parameters passed to methods\n" +
                "\t- The system takes care of all stack manipulation. You, as the programmer, don't need to do anything with it explicitly.\n" +
                "\t- But understanding its basic functions will give you a better understanding of what your program is doing when it is running and allow you to better understand " +
                "the C# documentation and literature.\n");
            WriteLine("\nFacts About Stacks\n" +
                "\t- The general characteristics of stacks are the following:\n" +
                "\t\t- Data can be added to and deleted only from the top of the stack.\n" +
                "\t\t- Placing a data item at the top of the stack is called 'pushing' the item onto the stack.\n" +
                "\t\t- Deleting an item from the top of the stack is called 'popping' the item from the stack.\n");
            WriteLine("\nThe Heap\n" +
                "\t- The heap is an area of memory where chunks are allocated to store certain kinds of data objects. Unlike the stack, data can be stored " +
                "and removed from the heap in any order.\n" +
                "\t- Although your program can store items in the heap, it cannot explicitly delete them.\n" +
                "\t- Instead, the CLR's garbage collector (GC) automatically cleans up orphaned heap objects when it determines that your code can no longer " +
                "access them.\n" +
                "\t- This frees you from what in other programming languages can be an error-prone task.\n");
            ReadKey();

            Clear();
        }

        static void ValueTypesAndReferenceTypes()
        {
            Clear();

            WriteLine("\nValue Types and Reference Types\n" +
                "\t- The 'type' of a data item defines how much memory is required to store it and the data members that comprise it.\n" +
                "\t- The type also determines where an object is stored in memory - the stack or the heap.\n" +
                "\t- Types are divided into two categories: value types and reference types. Objects of these types are stored differently in memory.\n" +
                "\t\t- Value types require only a single segment of memory, which stores the actual data.\n" +
                "\t\t- Reference types require two segments of memory.\n" +
                "\t\t\t- The first contains the actual data - and is always located in the heap.\n" +
                "\t\t\t- The second is a reference that points to where the data is stored in the heap.\n" +
                "\t- For value types, data is stored on the stack. For reference types, the actual data is stored in the heap, and the reference is " +
                "stored on the stack.\n");
            WriteLine("\nStoring Members of a Reference Type Object\n" +
                "\t- Data is stored when it isn't a member of another object, when it is a member of another object, data might be stored a little differently.\n" +
                "\t\t- The data portions of a reference type object is always stored in the heap.\n" +
                "\t\t- A value type object, or the reference part of a reference type, can be stored in either the stack or the heap, depending on the " +
                "circumstances.\n" +
                "\t- For any object of a reference type, all its data members are stored in the heap, regardless of whether they are value type or " +
                "reference type.\n");
            WriteLine("\nCategorizing the C# Types\n" +
                "\t- All the types available in C# and what kinds of types they are - value types or reference types.\n\n" +
                "\t\t\t\tValue Types\t\tReference Types\n\n" +
                "\tPredefined Types\tsbyte\tbyte\t\tfloat\tobject\n" +
                "\t\t\t\tshort\tushort\t\tdouble\tstring\n" +
                "\t\t\t\tint\tuint\t\tchar\tdynamic\n" +
                "\t\t\t\tlong\tulong\t\tdecimal\n" +
                "\t\t\t\tbool\n\n" +
                "\tUser-defined Types\tstruct\t\t\tclass\n" +
                "\t\t\t\tenum\t\t\tinterface\n" +
                "\t\t\t\t\t\t\tdelegate\n" +
                "\t\t\t\t\t\t\tarray\n");
            ReadKey();

            Clear();
        }

        static void Variables()
        {
            Clear();

            WriteLine("\nVariables\n" +
                "\t- A general-purpose programming language must allow a program to store and retrieve data.\n" +
                "\t\t- A 'variable' is a name that represents data stored in memory during program execution.\n" +
                "\t\t- C# provides four kinds of variables\n");
            WriteLine("\nThe Four Kinds of Variables\n\n" +
                "\t- Local variable\tHolds temporary data within the scope of a method. Not a member of a type.\n" +
                "\t- Field\t\t\tHolds data associated with a type or an instance of a type. Member of a type.\n" +
                "\t- Parameter\t\tA temporary variable used to pass data from one method to another method. Not a member of a type.\n" +
                "\t- Array element\t\tOne member of a sequenced collection of (usually) homogenous data items. Can be either local or a member of a type.\n");
            WriteLine("\nVariable Declarations\n" +
                "\t- A variable must be declared before it can be used. The variable declaration defines the variable and accomplishes two things.\n" +
                "\t\t- It gives the variable a name and associates a type with it.\n" +
                "\t\t- It allows the compiler to allocate memory for it.\n" +
                "\t- A simple variable declaration requires at least a type and a name.\n");
            WriteLine("\nVariable Initializers\n" +
                "\t- Besides declaring a variable's name and type, you can optionally use the declaration to initialize its memory to a specific value.\n" +
                "\t- A 'variable initializer' consists of an equal sign followed by the initializing value.\n" +
                "\t- Local variables without initializers have an undefined value and cannot be used until they have been assigned a value.\n" +
                "\t- Attempting to use an undefined local variable causes the compiler to produce an error message.\n");
            WriteLine("\nAutomatic Initialization\n" +
                "\t- Some kinds of variables are automatically set to default if they are declared without an initializer, and others do not.\n" +
                "\t- Variables that are not automatically initialized to default values contain undefined values until the program assigns them a value.\n\n" +
                "\tVariable\t\t\tStored in\t\t\tAuto-intialized\t\t\tUse\n\n" +
                "\tLocal Variables\t\t\tStack or stack and heap\t\tNo\t\t\t\tUsed for local computation inside a function member\n" +
                "\tClass Fields\t\t\tHeap\t\t\t\tYes\t\t\t\tMembers of a class\n" +
                "\tStruct Fields\t\t\tStack or heap\t\t\tYes\t\t\t\tMembers of a struct\n" +
                "\tParameters\t\t\tStack\t\t\t\tNo\t\t\t\tUsed for passing values into and out of a method\n" +
                "\tArray Elements\t\t\tHeap\t\t\t\tYes\t\t\t\tMembers of an array\n");
            WriteLine("\nMultiple-Variable Declarations\n" +
                "\t- You can declare multiple variables in a single declaration statement.\n" +
                "\t\t- The variables in a multiple-variable declaration must all be of the same type.\n" +
                "\t\t- The variable names must be separated with commas. Initializers can be included with the variable names.\n");
            WriteLine("\nUsing the Value of a Variable\n" +
                "\t- A variable name represents the value stored by the variable. You can use the value by using the variable name.");
            ReadKey();

            Clear();
        }

        static void StaticTypingAndThedynamicKeyword()
        {
            Clear();

            WriteLine("\nStatic Typing and the dynamic Keyword\n" +
                "\t- One thing you will notice is that every variable declaration includes the 'type' of the variable. This allows the " +
                "compiler to determine the amount of memory it will require at run time and which parts should be stored on the stack and " +
                "which in the heap.\n" +
                "\t- The type of the variable is determined at compile time and cannot be changed at run time. This is called 'static typing'.\n" +
                "\t- Not all languages, though, are statically typed. Many, including scripting languages such as IronPython and IronRuby, are 'dynamically typed'. " +
                "That is, the type of a variable might not be resolved until run time.\n" +
                "\t- Since these are also .NET languages, C# programs need to be able to use assemblies written in these languages. The problem, then, is that C# " +
                "need to be able to resolve at compile time a type from an assembly that doesn't resolve its types until run time.\n" +
                "\t- To solve this problem, C# provides the 'dynamic' keyword to represent a specific C# type that knows how to resolve itself at run time.\n" +
                "\t- At compile time, the compiler doesn't do type checking on variables of type 'dynamic'. Instead, it packages up any inforamtion about the " +
                "variable's operations and includes that information with the variable.\n" +
                "\t- At run time, that information is checked to make sure it's consistent with the actual type to which the variable was resolved. If it isn't, " +
                "the run time throws an exception.\n");
            ReadKey();

            Clear();
        }

        static void NullableTypes()
        {
            Clear();

            WriteLine("\nNullable Types\n" +
                "\t- There are situations, particularly when working with databases, where you want to indicate that a variable does not currently hold a valid value.\n" +
                "\t- For reference types, you can do this easily, by setting the variable to 'null'. When you define a variable of a value type, however, its memory " +
                "is allocated whether or not its contents have any valid meaning.\n" +
                "\t- What you would like in this situation is to have a Boolean indicator associated with the variable so that when the value is valid, the indicator is " +
                "'true', and that when the value is not valid, the indicator is 'false'.\n" +
                "\t- 'Nullable types' allow you to create a value type variable that can be marked as valid or invalid so that you can make sure a variable is valid " +
                "before using it.\n" +
                "\t- Regular value types are called 'non-nullable types'.\n");
            ReadKey();

            Clear();
        }
    }

}