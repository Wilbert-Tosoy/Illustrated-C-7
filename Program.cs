﻿using System;
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

        public static void Interface()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void Conversion()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void Generic()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void EnumeratorsAndIterators()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void IntroductionToLINQ()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void IntroductionToAsynchronousProgramming()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void NamespaceAndAssemblies()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void Exceptions()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void PreprocessorDirectives()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void ReflectionsAndAttributes()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void WhatIsNewInCSharp6And7()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        public static void OtherTopics()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                //NineDecision(ref choice);

            } while (choice != 19);


            Clear();
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
                    Five.ClassesTheBasics();
                    break;
                case 6:
                    Six.Methods();
                    break;
                case 7:
                    Seven.MoreAboutClasses();
                    break;
                case 8:
                    Eight.ClassesAndInheritance();
                    break;
                case 9:
                    Nine.ExpressionsAndOperators();
                    break;
                case 10:
                    Ten.Statements();
                    break;
                case 11:
                    Eleven.Structs();
                    break;
                case 12:
                    Twelve.Enumerations();
                    break;
                case 13:
                    Thirteen.Arrays();
                    break;
                case 14:
                    Fourteen.Delegates();
                    break;
                case 15:
                    Fifteen.Events();
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
                WriteLine("\n\tTypes, Storage, and Variables\n");
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

    public static class Five
    {
        public static void ClassesTheBasics()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tClasses: The Basics\n\n" +
                    "\t1. Overview of Classes\n\t2. Programs and Classes: A Quick Example\n\t3. Declaring a Class" +
                    "\n\t4. Class Members\n\t5. Creating Variables and Instances of a Class" +
                    "\n\t6. Allocating Memory for the Data\n\t7. Instance Members\n\t8. Access Modifiers" +
                    "\n\t9. Accessing Members from Inside the Class\n\t10. Accessing Memebers from Outside the Class" +
                    "\n\t11. Putting It All Together\n\t12. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                FiveDecision(ref choice);

            } while (choice != 12);

            Clear();
        }

        static void FiveDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    OverviewOfClasses();
                    break;
                case 2:
                    ProgramAndClasses();
                    break;
                case 3:
                    DeclaringAClass();
                    break;
                case 4:
                    ClassMembers();
                    break;
                case 5:
                    CreatingVariablesAndInstancesOfAClass();
                    break;
                case 6:
                    AllocatingMemoryForTheData();
                    break;
                case 7:
                    InstanceMembers();
                    break;
                case 8:
                    AccesModifiers();
                    break;
                case 9:
                    AccessingMembersFromInsideTheClass();
                    break;
                case 10:
                    AccessingMembersFromOutsideTheClass();
                    break;
                case 11:
                    PuttingItAllTogether();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void OverviewOfClasses()
        {
            Clear();

            WriteLine("\nOverview of Classes\n" +
                "\t- C# provides six user-defined types. The most important of these is the class.\n");
            WriteLine("\nA Class Is an Active Data Structure\n" +
                "\t- Before the days of object-oriented analysis and design, programmers thought of a program as just a " +
                "sequence of instructions. The focus at that time was on structuring and optimizing those instructions.\n" +
                "\t- With the advent of the object-oriented paradigm, the focus changed from optimizing instructions to " +
                "organizing a program's data and functions into encapsulated sets of logically related data items and functions, " +
                "called 'classes'.\n" +
                "\t- A class is a data structure that can store data and execute code. It contains data members and function members.\n" +
                "\t\t- 'Data members' store data associated with the class or an instance of the class. Data members generally " +
                "model the attributes of the real-world object the class represents.\n" +
                "\t\t- Function members execute code. These generally model the functions and actions of the real-world object that the " +
                "class represents.\n" +
                "\t- A C# class can have any number of data and function members. The members can be any combination of nine possible " +
                "member types.\n");
            WriteLine("\nTypes of Class Members\n\n" +
                "\tData Members Store Data\t\tFunction Members Execute Code\n\n" +
                "\tFields\t\t\t\tMethods\t\tOperators\n" +
                "\tConstants\t\t\tProperties\tIndexers\n" +
                "\t\t\t\t\tConstructors\tEvents\n" +
                "\t\t\t\t\tDestructors\n\n" +
                "\t- Classes are encapsulated sets of logically related data items and functions that generally represent objects " +
                "in the real world or a conceptual world.");
            ReadKey();

            Clear();
        }

        static void ProgramAndClasses()
        {
            Clear();

            WriteLine("\nProgram and Classes: A Quick Example\n" +
                "\t- A running C# program is a group of interacting type objects, most of which are instances of classes.\n" +
                "\t- A real program would be undoubtedly contain dozens of other class.\n" +
                "\t- A running program is a set of objects interacting with each other.\n");
            ReadKey();

            Clear();
        }

        static void DeclaringAClass()
        {
            Clear();

            WriteLine("\nDeclaring a Class\n" +
                "\t- Although types 'int', 'double', and 'char' are defined in the C# language, classes are not defined by " +
                "the language.\n" +
                "\t- If you want to use them in a program, you'll have to define them yourself. You do this by writing a " +
                "'class declaration'.\n" +
                "\t- A 'class declaration' defines the characteristics and members of a new class. It does not create an " +
                "instance of the class but creates the template from which class instances will be created.\n" +
                "\t- The class declaration provides the following:\n" +
                "\t\t- The class name\n" +
                "\t\t- The members of the class\n" +
                "\t\t- The characteristics of the class\n\n" +
                "\tclass MyExcellentClass\n" +
                "\t{\n" +
                "\t\tMemberDeclarations\n" +
                "\t}\n\n" +
                "\t- The following is an example of the minimum syntax for a class declaration.\n" +
                "\t\t- The curly braces contain the member declarations that make up the 'class body'.\n" +
                "\t\t- Class members can be declared in any order inside the class body.\n" +
                "\t\t- This means it is perfectly fine for the declaration of a member to refer to another member that " +
                "is not yet defined until further down in the class declaration.\n\n" +
                "\t- Since a class declaration 'defines' a new class, you will often see a class declaration referred to as a" +
                " 'class definition' both in the literature and in common usage among programmers.\n");
            ReadKey();

            Clear();
        }

        static void ClassMembers()
        {
            Clear();

            WriteLine("\nClass Members\n" +
                "\t- Two of the most important class member types are fields and methods. Fields are data memers, and methods " +
                "are function members.\n");
            WriteLine("\nFields\n" +
                "\t- A 'field' is a variable that belongs to a class.\n" +
                "\t\t- It can be of any type, either predefined or user-defined.\n" +
                "\t\t- Like all variables, fields store data and have the following characteristics:\n" +
                "\t\t\t- They can be written to.\n" +
                "\t\t\t- They can be read from.\n\n" +
                "\tThe minimum syntax for declaring a field is the following:\n\n" +
                "\tType Identifier;\n\n" +
                "\t- Unlike C and C++, in C# there are 'no global variables' (that is, variables or fields) declared outside of " +
                "a type. All fields belong to a type and must be declared within their type declaration.\n");
            WriteLine("\nExplicit and Implicit Field Initialization\n" +
                "\t- Since a field is a kind of variable, the syntax for a field initializer is the same as that of the variable " +
                "intializer.\n" +
                "\t\t- A 'field initializer' is part of the field declaration and consists of an equal sign followed by an " +
                "expression that evaluates to a value.\n" +
                "\t\t- The initialization value must be determinable at compile time.\n" +
                "\t\t- If no initializer is used, the compiler sets the value of a field to a default value, determined by " +
                "the type of the field. The default value for each type is '0' and is 'false' for 'bool'. The default for reference types is 'null'.\n");
            WriteLine("\nDeclarations with Multiple Fields\n" +
                "\t- You can declare multiple fields 'of the same type' in the same statement by separating the names with commas.\n" +
                "\t- You cannot mix different types in a single declaration.\n");
            WriteLine("\nMethods\n" +
                "\t- A method is a named block of executable code that can be executed from many different parts of the program, and even from " +
                "other programs. (There are also anonymous methods, which aren't named).\n" +
                "\t- When a method is 'called', or 'invoked', it executes the method's code and then returns to the code that called it " +
                "continues executing the calling code.\n" +
                "\t- Some methods return a value to the position from which they were called; others do not. Methods " +
                "correspond to member functions in C++.\n" +
                "\t- The minimum syntax for declaring a method includes the following components:\n" +
                "\t\t- 'Return type': This states the type of value the method returns. If a method doesn't return a " +
                "value, the return type is specified as 'void'.\n" +
                "\t\t- 'Name': This is the name of the method.\n" +
                "\t\t- 'Parameter list': This consists of at least an empty set of matching parentheses. If there " +
                "are parameters, they are listed between the parentheses.\n" +
                "\t\t- 'Method body': This consists of a matching set of curly braces containing the executable code.\n" +
                "\t- Unlike C and C++, in C# there are 'no global functions' (that is, method or functions) declared outside " +
                "of a type declaration. Also unlike C and C++, in C# there is no \"default\" return type for a method.\n" +
                "\t- All methods must include a return type or list it as 'void'.\n");
            ReadKey();

            Clear();
        }

        static void CreatingVariablesAndInstancesOfAClass()
        {
            Clear();

            WriteLine("\nCreating Variables and Instances of a Class\n" +
                "\t- The class declaration is just the blueprint from which instances of the class are created.\n" +
                "\t- Once a class is declared, you can create instances of the class.\n" +
                "\t\t- Classes are reference types, which means that they require memory both for the reference " +
                "to the data and for the actual data.\n" +
                "\t\t- The reference to the data is stored in a variable of the class type. So, to create an " +
                "instance of the class, you need to start by declaring a variable of the class type. If the variable " +
                "isn't initialized, its value is undefined.\n");
            ReadKey();

            Clear();
        }

        static void AllocatingMemoryForTheData()
        {
            Clear();

            WriteLine("\nAllocating Memory for the Data\n" +
                "\t- Declaring the variable of the class type allocates the memory to hold the reference, but not the " +
                "memory to hold the actual data of the class object.\n" +
                "\t- To allocate memory for the actual data, you use the 'new' operator.\n" +
                "\t\t- The 'new' operator allocates and initializes memory for an instance of the specified type. It " +
                "allocates the memory from either the stack or the heap, depending on the type.\n" +
                "\t\t- Use the 'new' operator to form an object-creation expression, which consists of the following:\n" +
                "\t\t\t- The keyword 'new'.\n" +
                "\t\t\t- The name of the type of the instance for which memory is to be allocated.\n" +
                "\t\t\t- Matching parentheses - which may or may not included parameters.\n" +
                "\t\t- If the memory allocated is for a reference type, the object-creation expression returns a reference " +
                "to the allocated and initialized instance of the object in the heap.\n\n" +
                "\t- This is exactly what you need to allocate and initialize the memory to hold the class instance data. " +
                "Use the 'new' operator to create an object-creation expression and assign the value returned by it to the " +
                "class variable.\n\n" +
                "\tHere's an example\n\n" +
                "\t\tnew TypeName();\n");
            WriteLine("\nCombining the Steps\n" +
                "\t- You can combine the two steps by 'initializing' the variable with the object-creation expression.\n\n" +
                "\t\tTypeName Identifier = new TypeName();\n");
            ReadKey();

            Clear();
        }

        static void InstanceMembers()
        {
            Clear();

            WriteLine("\nInstance Members\n" +
                "\t- A class declaration acts as a blueprint from which you can create as many instances of the class as you like.\n" +
                "\t\t- 'Instance member': Each instance of a class is a separate entity that has its own set of data members, distinct " +
                "from the other instances of the same class. These are called 'instance members' since they are associated with an " +
                "instance of the class.\n" +
                "\t\t- 'Static members': Instance members are the default, but you can also declare members called static members, which " +
                "are associated with the class, not the instance.\n");
            ReadKey();

            Clear();
        }

        static void AccesModifiers()
        {
            Clear();

            WriteLine("\nAccess Modifiers\n" +
                "\t- From within a class, any function member can access any other member of the class by simply using that member's name.\n" +
                "\t- The 'access modifier' is an optional part of a member declaration that specifies what other parts of the program have " +
                "access to the member.\n" +
                "\t- The access modifier is placed before the simple declaration forms.\n" +
                "\t- The following is the syntax for fields and methods:\n\n" +
                "\tFields\n" +
                "\t\tAccesModifier Type Identifier;\n\n" +
                "\tMethods\n" +
                "\t\tAccessModifier ReturnType MethodName()\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t}\n");
            WriteLine("\nThe Five Categories of Member Access\n" +
                "\t- Private\n" +
                "\t- Public\n" +
                "\t- Protected\n" +
                "\t- Internal\n" +
                "\t- Protected Internal\n");
            WriteLine("\nPrivate and Public Access\n" +
                "\t- Private members are accesible only from which the class in which they are declared - other classes cannot see or " +
                "access them.\n" +
                "\t\t- Private access is the default access level, so if a member is declared without an access modifier, it is a " +
                "private member.\n" +
                "\t\t- You can also use the 'private' access modifier to explicitly declare a member as private. There's no semantic difference " +
                "between declaring a private member implicitly as opposed to explicitly. The forms are equivalent.\n\n" +
                "\t- Public members of an instance are accesible to other objects in the program. You must use the 'public' access modifier to " +
                "specify public access.");
            ReadKey();

            Clear();
        }

        static void AccessingMembersFromInsideTheClass()
        {
            Clear();

            WriteLine("\nAccessing Members from Inside the Class\n" +
                "\t- Members of a class can access the other class members by just using their names.\n" +
                "\t- Even though the fields and methods are declared 'private', all members of a class can be " +
                "accessed by any method (or any function member) of the class.\n");
            ReadKey();

            Clear();
        }

        static void AccessingMembersFromOutsideTheClass()
        {
            Clear();

            WriteLine("\nAccessing Members from Outside the Class\n" +
                "\t- To access public instance member from outside the class, you must include the variable name and the member " +
                "name, separated by a period (dot). This is called 'dot-syntax notation'.\n");
            ReadKey();

            Clear();
        }

        static void PuttingItAllTogether()
        {
            Clear();

            WriteLine("\nPutting It All Together\n" +
                "\t- Declaring a class\n" +
                "\t- Creating instances of the class\n" +
                "\t- Accessing the class members (that is, writing to a field and reading from a field).");
            ReadKey();

            Clear();
        }
    }

    public static class Six
    {
        public static void Methods()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tMethods\n");
                WriteLine("\t1. The Structure of a Method\n\t2. Code Execution in the Method Body\n\t3. Local Variables" +
                    "\n\t4. Local Constants\n\t5. Flow of Control\n\t6. Method Invocations\n\t7. Return Values" +
                    "\n\t8. The Return Statement and Void Methods\n\t9. Local Functions\n\t10. Parameters" +
                    "\n\t11. Value Parameters\n\t12. Reference Parameters\n\t13. Reference Types As Value and Reference Parameters" +
                    "\n\t14. Output Parameters\n\t15. Parameter Arrays\n\t16. Summary of Parameter Types\n\t17. Method Overloading" +
                    "\n\t18. Named Parameters\n\t19. Optional Parameters\n\t20. Stack Frames\n\t21. Recursion\n\t22. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                SixDecision(ref choice);

            } while (choice != 22);
            Clear();
        }

        static void SixDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    TheStructureOfAMethod();
                    break;
                case 2:
                    CodeExecutionInTheMethodBody();
                    break;
                case 3:
                    LocalVariables();
                    break;
                case 4:
                    LocalConstants();
                    break;
                case 5:
                    FlowOfControl();
                    break;
                case 6:
                    MethodInvocations();
                    break;
                case 7:
                    ReturnValues();
                    break;
                case 8:
                    TheReturnStatementAndVoidMethods();
                    break;
                case 9:
                    LocalFunctions();
                    break;
                case 10:
                    Parameters();
                    break;
                case 11:
                    ValueParameters();
                    break;
                case 12:
                    ReferenceParameters();
                    break;
                case 13:
                    ReferenceTypesAsValueAndReferenceParameters();
                    break;
                case 14:
                    OutputParameters();
                    break;
                case 15:
                    ParameterArrays();
                    break;
                case 16:
                    SummaryOfParameterTypes();
                    break;
                case 17:
                    MethodOverloading();
                    break;
                case 18:
                    NamedParameters();
                    break;
                case 19:
                    OptionalParameters();
                    break;
                case 20:
                    StackFrames();
                    break;
                case 21:
                    Recursion();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void TheStructureOfAMethod()
        {
            Clear();

            WriteLine("\nThe Structure of a Method\n" +
                "\t- A 'method' is a block of code with a name.\n" +
                "\t- You can execute the code from somewhere else in the program by using the method's name.\n" +
                "\t- You can also pass data into a method and recieve data back as output.\n" +
                "\t- Methods have two major sections - the method header and the method body.\n" +
                "\t\t- The 'method header' specifies the method's characteristics, including the following:\n" +
                "\t\t\t- Whether the method returns data and, if so, what type\n" +
                "\t\t\t- The name of the method\n" +
                "\t\t\t- What types of data can be passed to and from the method and how that data should be treated\n" +
                "\t\t-The 'method body' contains the sequence of executable code statements. Execution starts at the first " +
                "statement in the method body and continues sequentially through the method.\n\n" +
                "\tMethod Header\t->\tvoid MethodName()\n" +
                "\t\t\t\t{\n" +
                "\t\t\t\t\tStatement1;\n" +
                "\tMethod Body\t->\t\tStatement2;\n" +
                "\t\t\t\t\t...\n" +
                "\t\t\t\t}\n");
            ReadKey();

            Clear();
        }

        static void CodeExecutionInTheMethodBody()
        {
            Clear();

            WriteLine("\nCode Execution in the Method Body\n" +
                "\t- The method body is a 'block', which is a sequence of statements between curly braces.\n" +
                "\t- A block can contain the following items:\n" +
                "\t\t- Local variables\n" +
                "\t\t- Flow-of-control constructs\n" +
                "\t\t- Method invocations\n" +
                "\t\t- Blocks nested within it\n" +
                "\t\t- Other methods, known as local functions\n");
            ReadKey();

            Clear();
        }

        static void LocalVariables()
        {
            Clear();

            WriteLine("\nLocal Variables\n" +
                "\t- Like fields, local variables also store data.\n" +
                "\t- While fields usually store data about the state of the object, local variables are usually " +
                "created to store data for local, or transitory, computations.\n" +
                "\n\t- The following line of code shows the syntax of local variable declarations. The optional intializer " +
                "consists of an equal sign followed by a value to be used to intialize the variable.\n\n" +
                "\t\tType Identifier = Value;\n\n" +
                "\t\t- The existence and lifetime of a local variable is limited to the block in which it is created and the " +
                "blocks nested within that block.\n" +
                "\t\t\t- The variable comes into existence at the point at which it is declared.\n" +
                "\t\t\t- It goes out of existence when the block completes execution.\n" +
                "\t\t- You can declare local variables at any position in the method body, but you must declare them before " +
                "you can use them.\n");
            WriteLine("\nInstance Fields vs. Local Variables\n" +
                "\t- Instance Fields\n" +
                "\t\t- The lifetime of instance fields starts when the class instance is created. Ends when the class instance is no " +
                "longer accessible.\n" +
                "\t\t- Implicit initialization is initialized to a default value for the type.\n" +
                "\t\t- Because instance fields are members of a class, all instance fields are stored in the heap, regardless of whether " +
                "they are value types or reference types.\n\n" +
                "\t- Local Variables\n" +
                "\t\t- The lifetime of local variables starts at the point in the block where it is declared. Ends when the block " +
                "completes execution.\n" +
                "\t\t- No implicit intialization. The compiler produces an error message if nothing is assigned to the variable before " +
                "it is used.\n" +
                "\t\t- Value types are stored in the stack, while the reference of reference types are stored on the stack and data are stored " +
                "in the heap.\n");
            WriteLine("\nType Inference and the var Keyword\n" +
                "\t- Supplying information that the compiler can already infer from the right side of the intialization, including the " +
                "explicit type name at the beginning of the declaration is redundant.\n" +
                "\t- To avoid this redundancy, C# allows you to use the keyword 'var' in place of the explicit type name at the beginning " +
                "of the variable declaration.\n" +
                "\t- The 'var' keyword does 'not' signal a special kind of variable. It is just a syntactic shorthand for whatever type can " +
                "be inferred from the initialization on the right side of the statement.\n" +
                "\t- The preceding code segment with the explicit type names and the code segment with the 'var' keywords are semantically " +
                "equivalent.\n\n" +
                "\t- Some important conditions on using the 'var' keyword are the following:\n" +
                "\t\t- You can use it only local variables - not with fields.\n" +
                "\t\t- You can use it only when the variable declaration includes an initialization.\n" +
                "\t\t- Once the compiler infers the type of a variable, it is fixed and unchangeable.\n\n" +
                "\t- The 'var' keyword is 'not' like the JavaScript 'var' that can reference different types. It is shorthand for the actual " +
                "type inferred from the right side of the equal sign. The 'var' keyword 'does not change the strongly typed nature of C#'.\n");
            WriteLine("\nLocal Variables Inside Nested Blocks\n" +
                "\t- Method bodies can have other blocks nested inside them.\n" +
                "\t\t- There can be any number of blocks, and they can be sequential or nested further. Blocks can be nested to any level.\n" +
                "\t\t- Local variables can be declared inside nested blocks, and like all local variables, their lifetime and visibility are " +
                "limited to the block in which they are declared and the blocks nested within it.\n" +
                "\t\t- When control passes out of the nested block, its local variables are popped from the stack.\n\n" +
                "\t- In C and C++ you can declare a local variable, and then within a nested block you can declare another local variable " +
                "with the same name. The inner masks the outer name while within the inner scope.\n" +
                "\t- In C#, however, you cannot declare another local variable with the same name within the scope of the first name, regardless " +
                "of the level of nesting.\n");
            ReadKey();

            Clear();
        }

        static void LocalConstants()
        {
            Clear();

            WriteLine("\nLocal Constants\n" +
                "\t- A local constant is much like a local variable, except that once initialized, its value cannot be changed.\n" +
                "\t- Like a local variable, a local constant must be declared inside a block.\n\n" +
                "\t- The two most impotant characteristics of a constant are the following:\n" +
                "\t\t- A constant 'must be intialized' at its declaration.\n" +
                "\t\t- A constant 'cannot be changed' after its declaration.\n\n" +
                "\t- The core declaration for a syntax is the following:\n\n" +
                "\t\tconst Type Indentifier = Value;\n\n" +
                "\t- The syntax is the same as that of a field or variable declaration, except for the following:\n" +
                "\t\t- The addition of the keyword 'const' before the type.\n" +
                "\t\t- The mandatory initializer. The initializer value must be determinable at compile time and usually " +
                "one of the predefined simple types or an expression made up of them.\n" +
                "\t\t- The intializer can also be the 'null' reference, but it cannot be a reference to an object " +
                "because references to objects are determined at run time.\n\n" +
                "\t- The keyword 'const' is not a modifier but part of the core declaration. It must be placed immediately before " +
                "the type.\n\n" +
                "\t- A local constant, like a local variable, is declared in a method body or code block, and it goes out of scope " +
                "at the end of the block in which it is declared.\n");
            ReadKey();

            Clear();
        }

        static void FlowOfControl()
        {
            Clear();

            WriteLine("\nFlow of Control\n" +
                "\t- Methods contain most of the code for the actions that comprise a program. The remainder is in other function " +
                "members, such as properties and operators.\n" +
                "\t- The term 'flow of control' refers to the flow of execution through a program. By default, program execution moves " +
                "sequentially from one statement to the next.\n" +
                "\t- The flow-of-control statements allow you to modify the order of execution.\n\n" +
                "\t- 'Selection statements' : These statements allow you to select which statement or block of statements to execute.\n" +
                "\t\t- 'if'\t\t\t: Conditional execution of a statement\n" +
                "\t\t- 'if ... else'\t\t: Conditional execution of one statement or another\n" +
                "\t\t- 'switch'\t\t: Conditional execution of one statement from a set.\n\n" +
                "\t- 'Iteration statements' : These statements allow you to loop, or iterate, on a block of statements.\n" +
                "\t\t- 'for'\t\t\t: Loop - testing at the top\n" +
                "\t\t- 'while'\t\t: Loop - testing at the top\n" +
                "\t\t- 'do'\t\t\t: Loop - testing at the bottom\n" +
                "\t\t- 'foreach'\t\t: Executes once for each member of a set.\n\n" +
                "\t- 'Jump statements' : These statements allow you to jump from one place in the block or method to another.\n" +
                "\t\t- 'break'\t\t: Exits the current loop\n" +
                "\t\t- 'continue'\t\t: Goes to the bottom of the current loop\n" +
                "\t\t- 'goto'\t\t: Goes to a named statement\n" +
                "\t\t- 'return'\t\t: Returns execution to the calling method.\n");
            ReadKey();

            Clear();
        }

        static void MethodInvocations()
        {
            Clear();

            WriteLine("\nMethod Invocations\n" +
                "\t- You can call other methods from inside a method body.\n" +
                "\t\t- The phrases 'call a method' and 'invoke a method' are synonymous.\n" +
                "\t\t- You call a method by using its name, along with parameter list.\n\n" +
                "\t- The sequence of actions when a method is called.\n" +
                "\t\t- Execution of the current method suspends at that point of the invocation.\n" +
                "\t\t- Control transfers to the beginning of the invoked method.\n" +
                "\t\t- The invoked method executes until it completes.\n" +
                "\t\t- Control returns to the calling method.\n");
            ReadKey();

            Clear();
        }

        static void ReturnValues()
        {
            Clear();

            WriteLine("\nReturn Values\n" +
                "\t- A method can return a value to the calling code. \n" +
                "\t- The returned value is inserted into the calling code at the position in the expression where the invocation occured.\n" +
                "\t- To return a value, the method must declare a 'return type' before the method name.\n" +
                "\t\t- If a method doesn't return a value, it must declare a return type of 'void'.\n" +
                "\t- A method that declares a return type must return a value from the method by using the following form of the return " +
                "statement, which includes an expression after the keyword 'return'.\n" +
                "\t- Every path through the method must end with a 'return' statement of this form.\n\n" +
                "\t\treturn Expression;\n\n" +
                "\t- You can returns a value type and you can also returns objects of user-defined types.\n");
            ReadKey();

            Clear();
        }

        static void TheReturnStatementAndVoidMethods()
        {
            Clear();

            WriteLine("\nThe Return Statement and Void Methods\n" +
                "\t- Methods that return a value must contain return statements. Void methods do not require return statements.\n" +
                "\t- When the flow of control reaches the closing curly brace of the method body, control returns to the calling code, " +
                "and no value is inserted back into the calling code.\n" +
                "\t- Often, however, you can simplify your program logic by exiting the method early when certain conditions apply.\n" +
                "\t\t- You can exit a 'void' method at any time by using the following form of the 'return' statement, with no parameters.\n\n" +
                "\t\t\treturn;\n\n" +
                "\t\t- This form of the 'return' statement can be used only with methods declared 'void'.\n");
            WriteLine("\n\tExample:\n\n" +
                "\t\tvoid MethodName()\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t\tif ( SomeCondition )\n" +
                "\t\t\t\treturn;\n" +
                "\t\t\t...\n" +
                "\t\t\tif ( OtherCondition )\n" +
                "\t\t\t\treturn;\n" +
                "\t\t\t...\n" +
                "\t\t}\n");
            ReadKey();

            Clear();
        }

        static void LocalFunctions()
        {
            Clear();

            WriteLine("\nLocal Functions\n" +
                "\t- The code inside a method block can call another method. If that other method is in the same class, it can be called simply " +
                "by using its name and passing any required parameters.\n" +
                "\t- If that method is in another class, it must generally be called using an object instance of the other class. Methods in " +
                "other classes also must have been declared using the 'public' access modifier.\n" +
                "\t- Beginning with C# 7.0 you can declare a separate method directly inside another method. This isolates the contained " +
                "method from other code as it can only be called from within the method in which it is contained.\n" +
                "\t- When used properly, this can also lead to clearer code and easier maintenance. These contained methods are called " +
                "'local functions'.\n" +
                "\t- Unlike local variables, which must be declared before they can be used, you can declare a local function ay any point " +
                "within its containing method.\n");
            ReadKey();

            Clear();
        }

        static void Parameters()
        {
            Clear();

            WriteLine("\nParameters\n" +
                "\t- Methods are named units of code that can be called from many places in a program and can return a single value to the " +
                "calling code.\n" +
                "\t- Returning a single value is certainly valuable, but what if you need to return multiple values? Also, it would be useful " +
                "to be able to pass data into a method when it starts execution.\n" +
                "\t- 'Parameters' are a special kind of variable that can allow you to do both these things.\n");
            WriteLine("\nFormal Parameters\n" +
                "\t- 'Formal Parameters' are local variables that are declared in the method declaration's parameter list, rather than in the " +
                "body of the method.\n" +
                "\t\t- Because formal parameters are variables, they have a data type and a name, and they can be written to and read from.\n" +
                "\t\t- Unlike a method's other local variables, the parameters are defined outside the method body and are intialized before " +
                "the method starts (except for one type, called 'output parameters').\n" +
                "\t\t- The parameter list can have any number of formal parameter declarations, and the declarations must be separated by commas.\n");
            WriteLine("\nActual Parameters\n" +
                "\t- When your code calls a method, the values of the formal parameters must be initialized before the code in the methods begins " +
                "execution.\n" +
                "\t- The expressions or variables used to initialize the formal parameters are called the 'actual parameters'. They are also " +
                "sometimes called 'arguments'.\n" +
                "\t\t- The actual parameters are placed in the parameter list of the method invocation.\n" +
                "\t\t- Each actual parameter must match the type of the corresponding formal parameter, or the compiler must be able to implicitly " +
                "convert the actual parameter to that type.\n\n" +
                "\t- When the method is called, the value of each actual parameter is used to initialize the corresponding formal parameter. The " +
                "method is then executed.\n" +
                "\t- The number of actual parameters matches the number of formal parameters, and each actual parameters matches the type of the " +
                "corresponding formal parameter. Parameters that follow this pattern are called 'positional parameters'.\n");
            ReadKey();

            Clear();
        }

        static void ValueParameters()
        {
            Clear();

            WriteLine("\nValue Parameters\n" +
                "\t- There are several kinds of parameters, each of which passes data to and from the method in slightly different ways. The " +
                "default type and is called a 'value parameters'.\n" +
                "\t- When using value parameters, data is passed to the method by copying the value of the actual parameter to the formal parameter. " +
                "When a method is called, the system does the following:\n" +
                "\t\t- It allocates space on the stack for the formal parameters.\n" +
                "\t\t- It copies the values of the actual parameters to the formal parameters.\n" +
                "\t- An actual parameter for a value parameter doesn't have to be a variable. It can be any expression evaluating to the matching " +
                "data type.\n" +
                "\t- Before you can use a variable as an actual parameter, that variable must be assigned a value (except in the case of the " +
                "'ouput parameters'). For reference types, the variable can be assigned either an actual reference or 'null'.\n\n" +
                "\t- 'Value typee' are types that contain their own data, 'value parameters' are parameters where the value of the actual parameter " +
                "is copied to the formal parameters. Don't be confused about the two, they are entirely different.\n");
            ReadKey();

            Clear();
        }

        static void ReferenceParameters()
        {
            Clear();

            WriteLine("\nReference Parameters\n" +
                "\t- The second type of parameters is called a 'reference parameters'.\n" +
                "\t\t- When using a reference parameter, you must use the 'ref' modifier in both the declaration and the invocation of the method.\n" +
                "\t\t- The actual parameter 'must' be a variable, and it must be assigned to before being used as the actual parameter. If it is a " +
                "reference type variable, it can be assigned either an actual parameter or the value 'null'.\n\n" +
                "\t- The System allocates memory on the stack for the formal parameters. In contrast, reference parameters have the following " +
                "characteristics:\n" +
                "\t\t- They do not allocate memory on the stack for the formal parameters.\n" +
                "\t\t- Instead, a formal parameter name acts as an alias for the actual parameter variable, referring to the same memory location.\n\n" +
                "\t- Since the formal parameter name and the actual parameter name are referencing the same memory location, clearly any changes made " +
                "to the formal parameter during method execution are visible after the method is complete, through the actual parameter variable.\n" +
                "\t- Remember to use the 'ref' keyword in both the method declaration 'and' the invocation.\n");
            ReadKey();

            Clear();
        }

        static void ReferenceTypesAsValueAndReferenceParameters()
        {
            Clear();

            WriteLine("\nReference Type As Value and Reference Parameters\n" +
                "\t- For a reference type object, you can modify its members inside the method call, regardless of whether you send the object in as " +
                "a value parameter or as a reference parameter.\n" +
                "\t- What happens when you assign to the formal parameter of a reference type inside the method is the following:\n" +
                "\t\t- 'Passing a reference type object as a value parameter': If you create a new object inside the method and assign it to the formal " +
                "parameter, it breaks the connection between the formal parameter and actual parameter, and the new object does not persist after the " +
                "method call.\n" +
                "\t- 'Passing a reference type object as a reference parameter': If you create a new object inside the method and assign it to the " +
                "formal parameter, that new object persists after the method is ended and is the value referenced by the actual parameter.\n\n" +
                "\t- A reference parameter acts as an alias for the formal parameter.\n" +
                "\t\t- When the method is invoked, the formal and actual parameters point at the same object in the heap.\n" +
                "\t\t- The modification of the member value is seen by both the formal and actual parameters.\n" +
                "\t\t- When the method creates a new object and assigns it to the formal parameter, the references of both the formal and actual parameters " +
                "point to the new object.\n" +
                "\t\t- After the method, the actual parameter is left pointing at the object that was created inside the method.\n");
            ReadKey();

            Clear();
        }

        static void OutputParameters()
        {
            Clear();

            WriteLine("\nOutput Parameters\n" +
                "\t- 'Output parameters' are used to pass data from inside the method back to the calling code. Their behavior is similar to " +
                "reference parameters.\n" +
                "\t- Like reference parameters, output parameters have the following requirements:\n" +
                "\t\t- You must use a modifier in both the method declaration and the invocation. With output parameters, the modifier is 'out', " +
                "rather than 'ref'.\n" +
                "\t\t- Like a reference parameters, the actual parameter 'must' be a variable - it cannot be another type of expression. This " +
                "makes sense since the method needs a memory location to store the value it's returning.\n\n" +
                "\t- Like reference parameters, the formal parameters of output parameters act as aliases for the actual parameters.\n" +
                "\t- Both the formal parameter and actual parameter are names for the same memory location.\n" +
                "\t- Clearly, then, any changes made to a formal parameter inside the method are visible through the actual parameter variable " +
                "after the method completes execution.\n\n" +
                "\t- Unlike the reference parameters, ouput parameters require the following:\n" +
                "\t\t-Inside the method, an output parameter must be assigned to before it can be read from, This means that the intial values of " +
                "the parameters are irrelevant and that you don't have to assign values to the actual parameters before the method call.\n" +
                "\t\t- Inside the method, every possible path through the code must assign a value to every output parameter before the method " +
                "can exit.\n\n" +
                "\t- Since the code inside the method must write to an output parameter before it can read from it, it is 'impossible' to send " +
                "data 'into' a method using output parameters.\n" +
                "\t- In fact, if there is any execution path through the method that attempts to read the value of an output parameter before the " +
                "method assigns it a value, the compiler produces an error message.\n\n" +
                "\t- Starting with C# 7.0 you no longer need to predeclare a variable to be used as an 'out' parameter. You can add a variable type " +
                "to the parameter listing in the method call itself, and it will act as the variable declaration.\n\n" +
                "\t- Using the new syntax, however, you can do the following:\n" +
                "\t\t- Omit the explicit variable declarations.\n" +
                "\t\t- Add the types of the variable directly in the method call.\n");
            ReadKey();

            Clear();
        }

        static void ParameterArrays()
        {
            Clear();

            WriteLine("\nParameter Arrays\n" +
                "\t- 'Parameter arrays' are different in that they allow 'zero or more' actual parameters of a particular type for a " +
                "particular formal parameter.\n" +
                "\t- Important points about parameter arrays are the following:\n" +
                "\t\t- There can be only one parameter array in a parameter list.\n" +
                "\t\t- If there is one, it must be the last parameter in the list.\n" +
                "\t\t- All the parameters represented by the parameter array must be of the same type.\n\n" +
                "\t- To declare a parameter array, you must do the following:\n" +
                "\t\t- Use the 'params' modifier before the data type.\n" +
                "\t\t- Place a set of empty square brackets after the data type.\n\n" +
                "\t- The following method header shows the syntax for the declaration of a parameter array of type 'int'.\n\n" +
                "\t\tvoid MethodName( params int[] ParameterName ) { ... }\n\n" +
                "\t- The empty set of square brackets after the type name specifies that the parameter will be an array of 'ints'.\n" +
                "\t- For our purposes here, though, all you need to know is the following:\n" +
                "\t\t- An array is ordered set of data items of the same type.\n" +
                "\t\t- An array is accessed by using a numerical index.\n" +
                "\t\t- An array is a reference type and therefore stores all its data items in the heap.\n");
            WriteLine("\nMethod Invocation\n" +
                "\t- You can supply the actual parameters for a parameter array in two ways.\n" +
                "\t\t- A comma-separated list of elements of the data type. All the elements must be of the specified in the method " +
                "declaration.\n\n" +
                "\t\t\tMethodName( 10, 20, 30, );\n\n" +
                "\t\t- A one-dimensional array of elements of the data type.\n\n" +
                "\t\t\tint[] Identifier = { 10, 20, 30 };\n" +
                "\t\t\tMethodName( Identifier );\n\n" +
                "\t- Notice in these examples that you do 'not' use the 'params' modifier in the 'invocation'.\n" +
                "\t- The usage of the modifier in parameter arrays doesn't fit the pattern of the other parameter types.\n" +
                "\t\t- The other parameter types are consistent in that they either use a modifier or not use a modifier.\n" +
                "\t\t\t- Value parameters take no modifier in either the declaration or the invocation.\n" +
                "\t\t\t- Reference and output parameters require the modifier in both places.\n\n" +
                "\t\t- The summary for the usage of the 'params' modifier is the following:\n" +
                "\t\t\t- It is required in the declaration.\n" +
                "\t\t\t- It is not allowed in the invocation.\n");
            WriteLine("\nExpanded Form\n" +
                "\t- The first form of method invocation, where you use separate actual parameters in the invocation, is " +
                "sometimes called the 'expanded form'.\n\n" +
                "\t- When you use an invocation with separate actual parameters for a parameter array, the compiler does the following:\n" +
                "\t\t- It takes the list of actual parameters and uses them to create and initialize an array in the heap.\n" +
                "\t\t- It stores the reference to the array in the formal parameter on the stack.\n" +
                "\t\t- If there are no actual parameters at the position corresponding to the formal parameter array, the compiler creates " +
                "an array with zero elements and uses that.\n\n" +
                "\t- An important thing to remember about parameter arrays is that when an array is created in the heap, the values of " +
                "the actual parameters are 'copied' to the array. In this way, they are like value parameters.\n" +
                "\t\t- If the array parameter is a value type, the 'values' are copied, and the actual parameters 'cannot be affected' " +
                "inside the method.\n" +
                "\t\t- If the array parameter is a reference type, the 'references' are copied, and the objects referenced by the actual " +
                "parameters 'can be affected' inside the method.\n");
            WriteLine("\nArray As Actual Parameters\n" +
                "\t- You can also create and populate an array before the method call and pass the single array variable as the actual parameter.\n" +
                "\t- In this case, the compiler uses 'your array', rather than creating one.");
            ReadKey();

            Clear();
        }

        static void SummaryOfParameterTypes()
        {
            Clear();

            WriteLine("\nSummary of Parameter Types\n" +
                "\t- Since there are four parameter types, it is sometimes difficult to remember their various characteristics.\n\n" +
                "\tParameter Type\t\tModifier\t\tUsed at Declaration?\t\tUsed at Invocation?\t\tImplementation\n\n" +
                "\tValue\t\t\tNone\t\t\t\t\t\t\t\t\t\t\tThe system copies the value of the actual parameter to the formal parameter.\n" +
                "\tReference\t\tref\t\t\tYes\t\t\t\tYes\t\t\t\tThe formal parameter is an alias for the actual parameter.\n" +
                "\tOutput\t\t\tout\t\t\tYes\t\t\t\tYes\t\t\t\tThe parameter contains only a returned value. The formal parameter is an " +
                "alias for the actual parameter.\n" +
                "\tArray\t\t\tparams\t\t\tYes\t\t\t\tNo\t\t\t\tThe parameter allows passing a variable number of actual parameter to a " +
                "method.\n");
            WriteLine("\nRef Local and Ref Return\n" +
                "\t- Passing a reference to an object into a method call using the 'ref' keyword and any changes made to the object would " +
                "be visible in the calling context when the method returned.\n" +
                "\t- The 'ref return' feature goes the other direction and lets you send a reference 'out of a method' where it can be used " +
                "in the calling context.\n" +
                "\t- A related feature, the 'ref local' feature, allows a variable to be an alias for another variable.\n\n" +
                "\t- We'll start by looking at the 'ref local' feature. The important things to know about the ref local are the following:\n" +
                "\t\t- Using this feature, you can create an alias of a variable even if the referenced object is a value type!\n" +
                "\t\t- Any assignment made to either variable are reflected in the other since they refer to the same object - again, even " +
                "if it is a value type.\n\n" +
                "\t- The syntax to create the alias requires two uses of the keyword 'ref', one in front of the type of the alias declaration " +
                "and the other on the right side of the assignment operator.\n\n" +
                "\t\tref Type VariableName = ref VariableName;\n\n" +
                "\t- But the aliasing feature is not the most common use of the 'ref local' feature. Instead, it is usually used in conjunction " +
                "with the 'ref return' feature.\n" +
                "\t- The 'ref return' feature gives you the means to have a method return a reference to a variable, rather than return the " +
                "variable's value.\n" +
                "\t- The additional syntax required here, again, consists of the following uses of the keyword 'ref':\n" +
                "\t\t- One before the type declaration of the method.\n" +
                "\t\t- The other inside the method after the 'return' keyword and before the variable name of the object being returned.\n\n" +
                "\t- Some additional constraints on these features are the following:\n" +
                "\t\t- You cannot declare a method with a return type of 'void' as a ref return method.\n" +
                "\t\t- A 'ref return' expression cannot return the following:\n" +
                "\t\t\t- The null value\n" +
                "\t\t\t- A constant\n" +
                "\t\t\t- An enumeration member\n" +
                "\t\t\t- A property of either a class or a struct\n" +
                "\t\t\t- A pointer to a read-only location\n" +
                "\t\t- A 'ref return' expression can only point either to a location that originated in the calling scope or to a field. " +
                "Hence, it cannot be a variable local to a method.\n" +
                "\t\t- A 'ref local' variable can be assigned only one time. That is, it cannot be pointer to a 'different' storage location " +
                "after having once been initialized.\n" +
                "\t\t- Even if a method is declared as a 'ref return' method, if a 'call' to that method omits the 'ref' keyword, the value " +
                "returned will be the value, rather than a pointer to the value's memory location.\n" +
                "\t\t- If you pass a 'ref local' variable as a regular actual parameter to some other method, that other method gets only a " +
                "copy of the variable. Even though the ref local variabl holds a pointer to a storage location, when it's used in this way, " +
                "it passes the value rather than the reference.\n");
            ReadKey();

            Clear();
        }

        static void MethodOverloading()
        {
            Clear();

            WriteLine("\nMethod Overloading\n" +
                "\t- A class can have more than one method with same name. This is called 'method overloading'.\n" +
                "\t- Each method with the same name must have a different 'signature' than the others.\n" +
                "\t\t- The signature of a method consists of the following information from the method header of the method declaration:\n" +
                "\t\t\t- The name of the method\n" +
                "\t\t\t- The number of parameters\n" +
                "\t\t\t- The data types and order of the parameters\n" +
                "\t\t\t- The parameter modifiers\n" +
                "\t\t- The return type is not part of the signature - although it is a common mistake to believe that it is.\n" +
                "\t\t- Notice that the 'names' of the formal parameters are 'not' part of the signature.\n");
            ReadKey();

            Clear();
        }
        
        static void NamedParameters()
        {
            Clear();

            WriteLine("\nNamed Parameters\n" +
                "\t- Positional parameters means that the position of each actual parameter matches the position of the corresponding " +
                "formal parameter.\n" +
                "\t- Alternatively, C# allows you to use 'named parameters'. Named parameters allow you to list the actual parameters in your " +
                "method invocation in any order, as long as you explicitly specify the names of the parameters.\n" +
                "\t\t- Nothing changes in the declaration of the method. The formal parameters already have names.\n" +
                "\t\t- In the method invocation, however, you use the formal parameter name, followed by a colon, in front of the actual " +
                "parameter value or expression.\n" +
                "\t- When using named parameters, include the parameter name in the method invocation. No changes are needed in the " +
                "method declaration.\n" +
                "\t- You can use both positional and named parameters in an invocation, but if you do, all the 'positional parameters " +
                "must be listed first'.\n" +
                "\t- Named parameters are useful as a means of self-documenting a program in that they can show, at the position of the " +
                "method call, what values are being assigned to which formal parameters.\n");
            ReadKey();

            Clear();
        }

        static void OptionalParameters()
        {
            Clear();

            WriteLine("\nOptional Parameters\n" +
                "\t- C# also allows 'optional parameters'. An optional parameter is a parameter that you can either include " +
                "or omit when invoking the method.\n" +
                "\t- To specify that a parameter is optional, you need to include a default value for that parameter in the " +
                "method declaration.\n" +
                "\t- The syntax for specifying the default value is the same as that of initializing a local variable.\n\n" +
                "\t- There are several important things to know about declaring optional parameters.\n" +
                "\t\t- Not all types of parameters can be used as optional parameters.\n" +
                "\t\t\t- You can use value types as optional parameters as long as the default value is determinable at compile " +
                "time.\n" +
                "\t\t\t- You can use a reference type as an optional parameter only if the default value is 'null'.\n" +
                "\t- All required parameters must be declared before any optional parameters are declared. If there is a 'params' " +
                "parameter, it must be declared after all the optional parameters.\n" +
                "\t- In the method declaration, optional parameters must be declared after alll the required parameters and before the " +
                "params parameter, if one exits.\n\n" +
                "\t- Instruct the program to use the default value of an optional parameter by leaving out the corresponding actual " +
                "parameter from the method invocation.\n" +
                "\t- You can't, however, omit just any combination of optional parameters because in many situations it would be " +
                "ambigous as to which optional parameters the method is supposed to use.\n" +
                "\t\t- You must omit parameters starting starting from the end of the list of optional parameters and work toward " +
                "the beginning.\n" +
                "\t\t- That is, you can omit the last optional parameter, or the last 'n' optional parameters, but you can't pick " +
                "and choose to omit any arbitrary optional parameters; they must be taken off the end.\n\n" +
                "\t- To omit optional parameters from arbitrary positions within the list of optional parameters, rather than from the " +
                "end of the list, you must use the names of the optional parameters to diambiguate the assignments.\n" +
                "\t- In this case, you are using both the named-parameters and optional-parameters features.\n");
            ReadKey();

            Clear();
        }

        static void StackFrames()
        {
            Clear();

            WriteLine("\nStack Frames\n" +
                "\t- When a method is called, memory is allocated at the top of the stack to hold a number of data items " +
                "associated with the method.\n" +
                "\t- This chunk of memory is called the 'stack frame' for the method.\n" +
                "\t\t- The stack frame contains memory to hold the following:\n" +
                "\t\t\t- The return address - that is, where to resume execution when the method exits.\n" +
                "\t\t\t- Thos parameters that allocate memory - that is, the value parameters of the method, and the " +
                "parameter array if there is one.\n" +
                "\t\t\t- Various other administrive data items relevant to the method call.\n" +
                "\t\t- When a method is called, its entire stack frame is pushed into the stack.\n" +
                "\t\t- When the method exits, its entire stack frame is popped from the stack. Popping a stack frame is " +
                "sometimes called 'unwinding' the stack.");
            ReadKey();

            Clear();
        }

        static void Recursion()
        {
            Clear();

            WriteLine("\nRecursion\n" +
                "\t- Besides calling other methods, a method can also call 'itself'. This is called 'recursion'.\n" +
                "\t- Recursion can produce some very elegant code.\n" +
                "\t- The mechanics of a method calling itself are the same as if it had called another, different method. A " +
                "new stack frame is pushed onto the stack for each call to the method.\n");
            ReadKey();

            Clear();
        }
    }

    public static class Seven
    {
        public static void MoreAboutClasses()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tMore About Classes\n");
                WriteLine("\t1. Class Members\n\t2. Order of Member Modifiers\n\t3. Instance Class Members\n\t4. Static Fields" +
                    "\n\t5. Accessing Static Members form Outside the Class\n\t6. Static Function Members" +
                    "\n\t7. Other Static Class Member Types\n\t8. Member Constants\n\t9. Constant Are Like Statics" +
                    "\n\t10. Properties\n\t11. Instance Constructors\n\t12. Static Constructors\n\t13. Object Initializers" +
                    "\n\t14. Destructors\n\t15. The readonly Modifier\n\t16. The this Keyword\n\t17. Access Modifiers on Accessors" +
                    "\n\t18. Partial Classes and Partial Types\n\t19. Partial Methods\n\t20. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                SevenDecision(ref choice);

            } while (choice != 20);

            Clear();
        }

        static void SevenDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    ClassMembers();
                    break;
                case 2:
                    OrderOfMemberModifiers();
                    break;
                case 3:
                    InstanceClassMembers();
                    break;
                case 4:
                    StaticFields();
                    break;
                case 5:
                    AccessingStaticMembersFromOutsideTheClass();
                    break;
                case 6:
                    StaticFunctionMembers();
                    break;
                case 7:
                    OtherStaticClassMemberTypes();
                    break;
                case 8:
                    MemberConstants();
                    break;
                case 9:
                    ConstantsAreLikeStatics();
                    break;
                case 10:
                    Properties();
                    break;
                case 11:
                    InstanceConstructors();
                    break;
                case 12:
                    StaticConstructors();
                    break;
                case 13:
                    ObjectInitializer();
                    break;
                case 14:
                    Destructors();
                    break;
                case 15:
                    ThereadonlyModifier();
                    break;
                case 16:
                    ThethisKeyword();
                    break;
                case 17:
                    AccessModifierOnAccessors();
                    break;
                case 18:
                    PartialClassesAndPartialTypes();
                    break;
                case 19:
                    PartialMethods();
                    break;
            }
        }

        static void ClassMembers()
        {
            Clear();

            WriteLine("\nClass Members\n" +
                "\t- Types of Class Members\n\n" +
                "\t\tData Members (Store Data)\t\tFunction Members (Execute Code)\n\n" +
                "\t\tFields\t\t\t\t\tMethods\n" +
                "\t\tConstants\t\t\t\tProperties\n" +
                "\t\t\t\t\t\t\tConstructors\n" +
                "\t\t\t\t\t\t\tDestructors\n" +
                "\t\t\t\t\t\t\tOperators\n" +
                "\t\t\t\t\t\t\tIndexers\n" +
                "\t\t\t\t\t\t\tEvents\n");
            ReadKey();

            Clear();
        }

        static void OrderOfMemberModifiers()
        {
            Clear();

            WriteLine("\nOrder of Member Modifiers\n" +
                "\t- Class member declaration statements consist of the following: the core declaration, an optional set of 'modifiers', " +
                "and an optional set of 'attributes'.\n\n" +
                "\t- The syntax used to describe this structure is the following. The square brackets indicate that the enclosed set of " +
                "components is optional.\n\n" +
                "\t\t[ attributes ] [ modifiers ] CoreDeclaration\n\n" +
                "\t- The optional components are the following:\n" +
                "\t\t- Modifiers\n" +
                "\t\t\t- If there are any modifiers, they must be placed before the core declaration.\n" +
                "\t\t\t- If there are multiple modifiers, they can be in any order.\n\n" +
                "\t\t- Attributes\n" +
                "\t\t\t- If there are any attributes, they must be placed before the modifiers and core declaration.\n" +
                "\t\t\t- If there are multiple attributes, they can be in any order.\n");
            ReadKey();

            Clear();
        }

        static void InstanceClassMembers()
        {
            Clear();

            WriteLine("\nInstance Class Members\n" +
                "\t- Class members can be associated with an instance of the class or with the class as a whole, that is, to all the instances " +
                "of the class. By default, members are associated with an instance.\n" +
                "\t- You can think of each instance of a class as having its own copy of each class member. These members are called 'instance " +
                "members'.\n" +
                "\t- Changes to the value of one instance field do not affect the values of the members in any other instance.\n");
            ReadKey();

            Clear();
        }

        static void StaticFields()
        {
            Clear();

            WriteLine("\nStatic Fields\n" +
                "\t- Besides instance fields, classes can have what are called 'static fields'.\n" +
                "\t\t- A static field is 'shared' by 'all the instances of the class', and all the instances access the same memory location. " +
                "Hence, if the value of the memory location is changed by one instance, the change is visible to all the instances.\n" +
                "\t\t- Use the 'static' modifier to declare a field static.\n");
            ReadKey();

            Clear();
        }

        static void AccessingStaticMembersFromOutsideTheClass()
        {
            Clear();

            WriteLine("\nAccessing Static Members from Outside the Class\n" +
                "\t- Dot-syntax notation is used to access 'public' instance members from outside the class.\n" +
                "\t- Dot-syntax notation consists of listing the instance name, followed by a dot, followed by the member name.\n" +
                "\t- Static members, like instance members, can also be accessed from outside the class using dot-syntax notation.\n" +
                "\t- But since there is no instance, the most common technique for accessing static members uses the 'class name'.\n\n" +
                "\t- Another option to access the member doesn't use any prefix at all, provided that you have included a 'using static' declaration " +
                "for the specific class to which that member belongs.\n\n" +
                "\t- You should choose between two forms of accessing a static member based on which approach makes your code clearer and more " +
                "understandable to you and to others responsible for maintaining your code.\n");
            WriteLine("\nLifetimes of Static Members\n" +
                "\t- The lifetimes for static members are different from those of instance members.\n" +
                "\t\t- Instance members come into existence when the instance is created and go out of existence when the instance is destroyed.\n" +
                "\t\t- Static members, however, exist and are accessible 'even if there are no instances' of the class.\n" +
                "\t\t- Static fields with no class instances can still be assigned to and read from because the field is associated with the class, not " +
                "an instance.\n\n" +
                "\t- Static members exist even if there are no instances of the class. If a static field has an initializer, the field is initialized before " +
                "the use of any class's static fields, but not necessarily at the beginning of program execution.\n");
            ReadKey();

            Clear();
        }

        static void StaticFunctionMembers()
        {
            Clear();

            WriteLine("\nStatic Function Members\n" +
                "\t- Besides static fields, there are also static function members.\n" +
                "\t\t- Static function members, like static fields, are independent of any class instance. Even if there are no instance of class, you can " +
                "still call a static method.\n" +
                "\t\t- Static function members 'cannot access instance members'. They can, however, access other static members.\n");
            ReadKey();

            Clear();
        }

        static void OtherStaticClassMemberTypes()
        {
            Clear();

            WriteLine("\nOther Static Class Member Types\n\n" +
                "\t- Class Member Types That Can Be Declared Static\n\n" +
                "\t\tData Members (Store Data)\t\tFunction Members (Execute Code)\n\n" +
                "\t\tFields\t\t\t\t\tMethods\n" +
                "\t\tTypes\t\t\t\t\tProperties\n" +
                "\t\t\t\t\t\t\tConstructors\n" +
                "\t\t\t\t\t\t\tOperators\n" +
                "\t\t\t\t\t\t\tEvents\n\n" +
                "\t- Class Member Types That Cannot Be Declared Static\n\n" +
                "\t\tData Members (Store Data)\t\tFunction Members (Execute Code)\n\n" +
                "\t\tConstants\t\t\t\tIndexers\n");
            ReadKey();

            Clear();
        }

        static void MemberConstants()
        {
            Clear();

            WriteLine("\nMember Constants\n" +
                "\t- Member constants are like the local constants except that they are declared in the class declaration rather than in a method.\n" +
                "\t- Like local constants, the value used to initialize a member constant must be computable at compile time and is usually one " +
                "of the predefined simple types or an expression composed of them.\n" +
                "\t- Like local constants, you cannot assign to a member constant after its declaration.\n\n" +
                "\t- Unlike C and C++, in C# there are no global constants. Every constant must be declared within a type.\n");
            ReadKey();

            Clear();
        }

        static void ConstantsAreLikeStatics()
        {
            Clear();

            WriteLine("\nConstants Are Like Statics\n" +
                "\t- Member constants, however, are more interesting than local constants, in that they act like static values.\n" +
                "\t- They're 'visible' to every instance of the class, and they're available even if there are no instances of the class.\n" +
                "\t- Unlike actual statics, constants do not have their own storage locations and are substituted in by the compiler at compile " +
                "time in a manner similar to '#define' values in C and C++.\n" +
                "\t- Constants fields act like static fields but do not have a storage location in memory.\n" +
                "\t- Although a constant member acts like a static, you cannot declare a constant as 'static'.");
            ReadKey();

            Clear();
        }

        static void Properties()
        {
            Clear();

            WriteLine("\nProperties\n" +
                "\t- A 'property' is a member that represents an item of data in a class instance. \n" +
                "\t- Using a property appears very much like writing to, or reading from, a field. The syntax is the same.\n\n" +
                "\t- A property, like a field, has the following characteristics:\n" +
                "\t\t- It is a named class member.\n" +
                "\t\t- It has a type.\n" +
                "\t\t- It can be assigned to and read from.\n\n" +
                "\t- Unlike a field, however, a property is a function member; hence:\n" +
                "\t\t- It does not necessarily allocate memory for data storage.\n" +
                "\t\t- It executes code.\n\n" +
                "\t- A property is a named set of two matching methods called 'accessors'.\n" +
                "\t\t- The 'set' accessor is used for assigning a value to the property.\n" +
                "\t\t- The 'get' accessor is used for retrieving a value from the property.\n");
            WriteLine("\nProperty Declarations and Accessors\n" +
                "\t- The 'set' and 'get' accessors have predefined syntax and semantics.\n" +
                "\t- You can think of the 'set' accessor as a method with a single parameter taht 'sets' the value of the property.\n" +
                "\t- The 'get' accessor has no parameters and returns the value of the property.\n\n" +
                "\t\t- The 'set' accesor always has the following:\n" +
                "\t\t\t- A single, implicit value parameter named 'value', of the same type as the property\n" +
                "\t\t\t- A return type of 'void'\n\n" +
                "\t\t- The 'get' accessor always has the following:\n" +
                "\t\t\t- No parameters\n" +
                "\t\t\t- A return type of the same type as the property.\n\n" +
                "\t- Neither accessor declaration has 'explicit' parameter or return type declarations. They don't need them because " +
                "they are 'implicit' in the type of the property.\n\n" +
                "\t- The implicit parameter 'value' in the 'set' accessor is a normal value parameter. Like other value parameters, " +
                "you can use it to send data into a method body - or in the accessor block.\n" +
                "\t- Once inside the block, you can use 'value' like a normal variable, including assigning values to it.\n\n" +
                "\t- Other important points about the accessors are the following:\n" +
                "\t\t- All paths through the implementation of a 'get' accessor 'must' include a 'return' statement that returns a value " +
                "of the property type.\n" +
                "\t\t- The 'set' and 'get' accessors can be declared in either order, and no methods other than the two accessors are " +
                "allowed on a property.\n");
            WriteLine("\nUsing a Property\n" +
                "\t- You write to and read from a property in the same way you access a field. The accessors are called implicitly.\n" +
                "\t\t- To write to a property, use the property's name on the left side of an assignment statement.\n" +
                "\t\t- To read from a property, use the property's name in an expression.\n\n" +
                "\t- The appropriate accessor is called implicitly depending on whether you are writing to or reading from the property. " +
                "You cannot explicitly call the accessors. Attempting to do so produces a compiler error.\n");
            WriteLine("\nProperties and Associated Fields\n" +
                "\t- A property is often associated with fields. \n" +
                "\t- A common practice is to encapsulate a field in a class by declaring the field 'private' and declaring a 'public' property " +
                "to give controlled access to the field from outside the class. The field associated with a property is called the 'backing field' " +
                "or 'backing store'.\n\n" +
                "\t- There are several conventions for naming properties and their backing fields. \n" +
                "\t- One convention is to use the same string for both names but use 'camel casing' for the field and 'Pascal casing' for the property. \n" +
                "\t- Another convention is to use Pascal casing for the property, and then for the field, use the camel case version of the same " +
                "identifier, with an underscore in front.\n");
            WriteLine("\nPerforming Other Calculations\n" +
                "\t- Property accessors are not limited to just passing values back and forth from an associated backing field; the 'get' and 'set' accessors " +
                "can perform any, or no, computations. The only action 'required' is that the 'get' accessor return a value of the property type.\n" +
                "\t- C# 7.0 introduced an alternate syntax for property getters and setters that uses 'expression bodies'. Expresion bodies are also known " +
                "as 'lambda expressions'. This alternate syntax can be used only if the accessor body consists of a single expression.\n");
            WriteLine("\nRead-Only and Write-Only Properties\n" +
                "\t- You can leave one or the other (but not both) of a property's accessors undefined by omitting its declaration.\n" +
                "\t\t- A property with only a 'get' accessor is called a 'read-only' property. A read-only property is a safe way of passing an item of " +
                "data out from a class or class instance without allowing the caller to modify the value of the property.\n" +
                "\t\t- A property with only a 'set' accessor is called a 'write-only' property. Write-only properties are rarely seen because there are very " +
                "few practical uses for them. If the intention is to trigger a side effect when the value is assigned, you should use a method rather than a " +
                "property.\n" +
                "\t\t- At least one of the two accessors must be defined, or the compiler will produce an error message.\n");
            WriteLine("\nProperties vs. Public Fields\n" +
                "\t- As a matter of preferred coding practice, properties are preferred over public fields for several reasons.\n" +
                "\t\t- Since properties are function members, as opposed to data members, they allow you to process the input and output, which " +
                "you cannot do with public fields.\n" +
                "\t\t- You can have read-only or write-only properties, but you cannot have these characteristics with a field.\n" +
                "\t\t- The semantics of a compiled variable and a compiled property are different.\n\n" +
                "\t- The third point has implications when you release an assembly that is accessed by other code.");
            WriteLine("\nAutomatically Implemented Properties - Auto-properties\n" +
                "\t- Because properties are so often associated with backing fields, C# provides 'automatically implemented properties', also called " +
                "'auto-implemented properties' or, more commonly, just 'auto-properties', which allow you to declare the property without declaring a " +
                "backing field.\n" +
                "\t- The compiler creates a hidden backing field for you and automatically hooks up the 'get' and 'set' accessors to it.\n\n" +
                "\t- The important points about auto-implemented properties are the following:\n" +
                "\t\t- You do not declare the backing field - the compiler allocates the storage for you, based on the type of the property.\n" +
                "\t\t- You cannot supply the bodies of the accessors - they must be declared simply as semicolons. The 'get' acts as a simple read of the memory, " +
                "and the 'set' as a simple write. However, because you can't access the bodies of auto-properties, it's difficult to debug your code " +
                "when using auto-properties.\n" +
                "\t\t- Beginning with C# 6.0, you can now use read-only auto-properties. Also, it is now possible to initialize auto-properties as part of their " +
                "declaration.\n\n" +
                "\t- Besides being convenient, auto-implemented properties allow you to easily insert a property where you might be tempted to declare a public field.\n");
            WriteLine("\nStatic Properties\n" +
                "\t- Properties can also be declared 'static'. Accessors of static properties, like all static members, have the following characteristics:\n" +
                "\t\t- They cannot access instances members of a class - although they can be accessed by them.\n" +
                "\t\t- They exist regardless of whether there are instances of the class.\n" +
                "\t\t- From inside the class, you reference the static property using just its name.\n" +
                "\t\t- From outside the class, you must reference the property either using its class name or using the 'using static' construct.\n");
            ReadKey();

            Clear();
        }

        static void InstanceConstructors()
        {
            Clear();

            WriteLine("\nInstance Constructors\n" +
                "\t- An 'instance constructors' is a special method that is executed whenever a new instance of a class is created.\n" +
                "\t\t- A constructor is used to initialize the state of the class instance.\n" +
                "\t\t- If you want to be able to create instances of you class from outside the class, you need to declare the constructor 'public'.\n\n" +
                "\t- A constructor looks like the other methods in a class declaration, with the following exceptions:\n" +
                "\t\t- The name of the constructor is the same as the name of the class.\n" +
                "\t\t- A constructor cannot have a return type.\n");
            WriteLine("\nConstructors with Parameters\n" +
                "\t- Constructors are like other methods in the following ways:\n" +
                "\t\t- A constructor can have parameters. The syntax for the parameters is exactly the same a for other methods.\n" +
                "\t\t- A constructor can be overloaded.\n\n" +
                "\t- When using an object-creation expression to create a new instance of a class, you use the 'new' operator followed by one of the class's " +
                "constructors. The 'new' operator uses that constructor to create the instance of the class.\n");
            WriteLine("\nDefault Constructors\n" +
                "\t- If no instance constructors is explicitly supplied in the class declaration, then the compiler supplies an implicit, default constructors, " +
                "which has the following:\n" +
                "\t\t- It takes no parameteres.\n" +
                "\t\t- It has an empty body.\n\n" +
                "\t- If you declare any constructors 'at all' for a class, then the compiler does not define the default constructor for the class.\n\n" +
                "\t- You can assign access modifiers to instance constructors just as you can to other members. \n" +
                "\t- You'll also want to declare the constructos 'public' so that you can create instances from outside the class.\n" +
                "\t- You can also create 'private' constructors, which cannot be called from outside the class but can be used from within the class.\n");
            ReadKey();

            Clear();
        }

        static void StaticConstructors()
        {
            Clear();

            WriteLine("\nStatic Constructors\n" +
                "\t- Constructors can also be declared 'static'. While an instance constructor initializes each new instance of a class, a 'static' constructor " +
                "initializes items at the class level.\n" +
                "\t- Generally, static constructors initialize the static fields of the class.\n\n" +
                "\tClass-level items are initialized at the following times:\n" +
                "\t\t- Before any static member is referenced\n" +
                "\t\t- Before any instance of the class is created\n\n" +
                "\tStatic constructors are like instance constructor in the following ways:\n" +
                "\t\t- The name of the static constructor must be the same as the name of the class.\n" +
                "\t\t- The constructor cannot return a value.\n\n" +
                "\tStatic constructors are unlike instance constructors in the following ways:\n" +
                "\t\t- Static constructors use the 'static' keyword in the declaration.\n" +
                "\t\t- There can be only a single static constructor for a class, and it cannot have parameters.\n" +
                "\t\t- Static constructors cannot have accessibility modifiers.\n\n" +
                "\t- Other important things you should know about static constructors are the following:\n" +
                "\t\t- A class can have both a static constructor and instance constructors.\n" +
                "\t\t- Like static methods, a static constructor cannot access instance members of its class and cannot use the 'this' accessor.\n" +
                "\t\t- You cannot explicitly call static constructors from your program. They are called automatically by the system,at some " +
                "indeterminate time.\n" +
                "\t\t\t- Before any instance of the class is created.\n" +
                "\t\t\t- Before any static members of the class is referenced.\n");
            ReadKey();

            Clear();
        }

        static void ObjectInitializer()
        {
            Clear();

            WriteLine("\nObject Initializers\n" +
                "\t- An object-creation expression consists of the keyword 'new' followed by a class constructor and its parameter list. An " +
                "'object initializer' extends that syntax by placing a list of member initializations at the end of the expression.\n" +
                "\t- An object initializer allows you to set the values of fields and properties when creating a new instance of an object.\n\n" +
                "\t- The syntax has two forms. One form includes the constructor's argument list, and the other doesn't. Notice the first form " +
                "doesn't even use the parentheses that would enclose the argument list.\n\n" +
                "\t\tnew TypeName\t\t{ FieldOrProp = InitExpr, FieldOrProp = InitExpr, ... }\n" +
                "\t\tnew TypeName(ArgList)\t{ FieldOrProp = InitExpr, FieldOrProp = InitExpr, ... }\n\n" +
                "\t- Important things to know about object initializers are the following:\n" +
                "\t\t- The fields and properties being initialized must be 'public' and accessible to code creating the object.\n" +
                "\t\t- The initialization occurs 'after' the constructor has finished execution, so the values might have been set in the " +
                "constructor and then reset to the same or a different value in the object initializer.");
            ReadKey();

            Clear();
        }

        static void Destructors()
        {
            Clear();

            WriteLine("\nDestructors\n" +
                "\t- Destructors performs actions required to clean up or release unmanaged resources after an instance of a class is no longer referenced.\n" +
                "\t- Unmanaged resources are such things as file handles that you have gotten using the Win32 API, or chunks of unmanaged memory.\n" +
                "\t- These aren't things you will get by using .NET resources, so if you stick to the .NET classes, you won't likely have to write destructors " +
                "for your classes.\n");
            ReadKey();

            Clear();
        }

        static void ThereadonlyModifier()
        {
            Clear();

            WriteLine("\nThe readonly Modifier\n" +
                "\t- A field can be declared with the 'readonly' modifier. The effect is similar to declaring a field as 'const', in that once the value " +
                "is set, it cannot be changed.\n" +
                "\t\t- While a 'const' field can be initialized only in the field's declaration statement, a 'readonly' field can have its value set in any " +
                "of the following places:\n" +
                "\t\t\t- The field declaration statement - like a 'const'.\n" +
                "\t\t\t- Any of the class constructors. If it is a 'static' field, then it must be done in the 'static' constructor.\n" +
                "\t\t- While the value of a 'const' field must be determinable at compile time, the value of a 'readonly' field can be determined at run time. " +
                "This additional freedom allows you to set different values under different circumstances or in different constructors!\n" +
                "\t\t- Unlike a 'const', which always acts like a static, the following is true of a 'readonly' field:\n" +
                "\t\t\t- It can be either an instance field or a static field.\n" +
                "\t\t\t- It has a storage location in memory.");
            ReadKey();

            Clear();
        }

        static void ThethisKeyword()
        {
            Clear();

            WriteLine("\nThe this Keyword\n" +
                "\t- The 'this' keyword, used in a clas, is a reference to the current instance. It can be used only in the 'blocks' of the following class members:\n" +
                "\t\t- Instance constructors\n" +
                "\t\t- Instance methods\n" +
                "\t\t- Instance accessors of properties and indexers\n\n" +
                "\tClearly, since static members are not part of an instance, you cannot use the 'this' keyword inside the code of any static function member. Rather, " +
                "it is used for the following:\n" +
                "\t\t- To distinguish between class members and local variables or parameters.\n" +
                "\t\t- As an actual parameter when calling a method.\n\n" +
                "\t- While it is important to understand the purpose and functionality of the 'this' keyword, its actual usage in your code will be likely " +
                "relatively rare.\n");
            WriteLine("\nIndexers\n" +
                "\t- There are times, however, when it would be convenient to be able to access them with an index, as if the instance were an array of fields. " +
                "This is exactly what 'indexers' allow you to do.\n" +
                "\t- Instead of using dot-syntax notation, indexers use 'index notation', which consists of an index between square brackets.\n");
            WriteLine("\nWhat Is an Indexer?\n" +
                "\t- An indexer is a pair of 'get' and 'set' accessors, similar to those of properties.\n");
            WriteLine("\nIndexers and Properties\n" +
                "\t- Indexers and properties are similar in many ways.\n" +
                "\t\t- Like property, an indexer does not allocate memory for storage.\n" +
                "\t\t- Both indexers and properties are used primarily for giving access to 'other' data members with which they are associated and for which they " +
                "provide get and set access.\n" +
                "\t\t\t- A 'property' usually represents a 'single' data member.\n" +
                "\t\t\t- An 'indexer' usually represents 'multiple' data members.\n\n" +
                "\t- You can think of an 'indexer' as a 'property' that gives get and set access to 'multiple data members' of the class. You select which of the many " +
                "possible data members by supplying an index, which itself can be of any type - not just numeric.\n\n" +
                "\t- Some additional points you should know about indexers are the following:\n" +
                "\t\t- Like a property, an indexer can have either one or both of the accessors.\n" +
                "\t\t- Indexers are always instance members; hence, an index cannot be declared 'static'.\n" +
                "\t\t- Like properties, the code implementing the 'get' and 'set' accessors does not have to be associated with any fields or properties. The code can " +
                "do anything, or nothing, as long as the 'get' accessor returns some value of the specified type.\n");
            WriteLine("\nDeclaring an Indexer\n" +
                "\t- The syntax for declaring an indexer is shown next. Notice the following about indexers:\n" +
                "\t\t- An indexer 'does not have a name'. In place of the name is the keyword 'this'.\n" +
                "\t\t- The parameter list is between 'square' brackets.\n" +
                "\t\t- There must be at least one parameter declaration in the parameter list.\n\n" +
                "\t\t\tReturnType this [ Type param1, ... ]\n" +
                "\t\t\t{\n" +
                "\t\t\t\tget\n" +
                "\t\t\t\t{\n" +
                "\t\t\t\t\t...\n" +
                "\t\t\t\t}\n" +
                "\t\t\t\tset\n" +
                "\t\t\t\t{\n" +
                "\t\t\t\t\t...\n" +
                "\t\t\t\t}\n" +
                "\t\t\t}\n\n" +
                "\t- Declaring an indexer is similar to declaring a property.\n");
            WriteLine("\nThe Indexer set Accessor\n" +
                "\t- When the indexer is the target of an assignment, the 'set' accessor is called and recieves two items of data, as follows:\n" +
                "\t\t- An implicit parameter, named 'value', which holds the data to be stored.\n" +
                "\t\t- One or more index parameters that represent where it should be stored.\n\n" +
                "\t- Your code in the 'set' accessor must examine the index parameters, determine where the data should be stored, and then store it.\n\n" +
                "\t- The different syntax and meaning of the 'set' accessor.\n\n" +
                "\t\t- This figure shows the actual syntax of the accessor declaration.\n\n" +
                "\t\t\tReturnType this [ ParameterList ] \n" +
                "\t\t\t{\n" +
                "\t\t\t\tset\n" +
                "\t\t\t\t{\n" +
                "\t\t\t\t\tAccessorBody\n" +
                "\t\t\t\t}\n" +
                "\t\t\t\tget { ... }\n" +
                "\t\t\t}\n\n" +
                "\t\t- This figure shows the semantics of the accessor if it were written using the syntax of a normal method.\n\n" +
                "\t\t\tvoid set ( ParameterList, Type value )\n" +
                "\t\t\t{\n" +
                "\t\t\t\tAccessorBody\n" +
                "\t\t\t}\n\n" +
                "\t- The figure shows that the 'set' accessor has the following:\n" +
                "\t\t- It has a void return type.\n" +
                "\t\t- It uses the same parameter list as that in the indexer declaration.\n" +
                "\t\t- It has an implicit value parameter named 'value', of the same type as the indexer.\n");
            WriteLine("\nThe Indexer get Accessor\n" +
                "\t- When the indexer is used to retrieve a value, the 'get' accessor is called with one or more index parameters.\n" +
                "\t- The index parameters represents which value to retrieve.\n\n" +
                "\t- The code in the 'get' accessor body must examine the index parameters, determine which field they represents, and return the value of that field.\n\n" +
                "\t- The different syntax and meaning of the 'get' accessor.\n\n" +
                "\t\t- This figure shows the actual syntax of the accessor declaration.\n\n" +
                "\t\t\tReturnType this [ ParameterList ]\n" +
                "\t\t\t{\n" +
                "\t\t\t\tget\n" +
                "\t\t\t\t{\n" +
                "\t\t\t\t\tAccessorBody\n" +
                "\t\t\t\t\treturn ValueOfType;\n" +
                "\t\t\t\t}\n" +
                "\t\t\t\tset { ... }\n" +
                "\t\t\t}\n\n" +
                "\t\t- This figure shows the semantics of the accessor if it were written using the syntax of a normal method. \n\n" +
                "\t\t\tReturnType get ( ParameterList )\n" +
                "\t\t\t{\n" +
                "\t\t\t\tAccessorBody\n" +
                "\t\t\t\treturn ValueOfType;\n" +
                "\t\t\t}\n\n" +
                "\t- The semantics of the 'get' accessor are as follows:\n" +
                "\t\t- It has the same parameter list as in the indexer declaration.\n" +
                "\t\t- It returns a value of the same type as the indexer.\n");
            WriteLine("\nMore About Indexers\n" +
                "\t- As with properties, the 'get' and 'set' accessors cannot be called explicitly. Instead, the 'get' accessor is called automatically when the indexer is used " +
                "in an expression for a value. \n" +
                "\t- The 'set' accessor is called automatically when the indexer is assigned a value with the assignment statement.\n" +
                "\t- When an indexer is 'called', the parameters are supplied between the square brackets.\n");
            WriteLine("\nIndexer Overloading\n" +
                "\t- A class can have any number of indexers, as long as the parameter lists are different; however, it isn't sufficient for the indexer 'type' to be different.\n" +
                "\t- This is called 'indexer overloading' because all the indexers have the same 'name' - the 'this' access reference.\n\n" +
                "\t- Remember that the overloaded indexers of a class must have different parameter lists.\n");
            ReadKey();

            Clear();
        }

        static void AccessModifierOnAccessors()
        {
            Clear();

            WriteLine("\nAccess Modifiers on Accessors\n" +
                "\t- There are two types of function members that have 'get' and 'set' accessors: properties and indexers. By default, both a member's accessor have the same " +
                "access level as the member itself.\n" +
                "\t That is, if a property has an access level of 'public', then both its accessor have that same access level. The same is true of indexers.\n" +
                "\t- You can, however, assign different access levels to the two accessors.\n\n" +
                "\t- There are several restrictions on the access modifiers of accessors. The most important ones are the following:\n" +
                "\t\t- An accessor can have an access modifier only if the member (property or indexer) has both a 'get' accessor and a 'set' accessor.\n" +
                "\t\t- Although both accessor must be present, only one of them can have an access modifier.\n" +
                "\t\t- The access modifier of the accessor must be 'strictly more restrictive' than the access level of the member.\n\n" +
                "\tHeirarchy of strictly restrictive accessor levels\n\n" +
                "\t\t      public\n" +
                "\t\t         |\n" +
                "\t\t         |\n" +
                "\t\tprotected internal\n" +
                "\t\t    /        \\\n" +
                "\t\t   /          \\\n" +
                "\t\tprotected   internal\n" +
                "\t\t   \\          /\n" +
                "\t\t    \\        / \n" +
                "\t\t      private\n\n" +
                "\t- The access level of an accessor must be strictly lower in the chart than the access level of the member.");
            ReadKey();

            Clear();
        }

        static void PartialClassesAndPartialTypes()
        {
            Clear();

            WriteLine("\nPartial Classes and Partial Types\n" +
                "\t- The declaration of a class can be partitioned among several partial class declarations.\n" +
                "\t\t- Each of the partial class declarations contains the declarations of some of the class members.\n" +
                "\t\t- The partial class declarations of a class can be in the same file or in different files.\n\n" +
                "\t- Each partial declaration must be labeled as 'partial class', in contrast to the single keyword 'class'. The declaration of a partial class " +
                "looks the same as the declaration of a normal class, other than the addition of the type modifier 'partial'.\n\n" +
                "\t- The type modifier 'partial' is not a keyword, so in other contexts you can use it as an indentifier in your program. But when used immediately " +
                "before the keywords 'class', 'struct', or 'interface', it signals the use of a partial type.\n\n" +
                "\t- All the partial class declarations comprising a class must be compiled together. A class using partial class declarations has the same meaning as " +
                "if all the class members were declared within a single class declaration body.\n" +
                "\t- Visual Studio uses this feature in its standard Window program templates. When you create an ASP.NET project, a Windows Forms project, or a " +
                "Windows Presentation Foundation (WPF) project from the standard templates, the templates create two class files for each web page, form, or WPF window.\n\n" +
                "\t- In the cases of ASP.NET or Windows Forms, the following is true:\n" +
                "\t\t- One file contains the partial class containing the code generated by Visual Studio, declaring the components on the page. You shouldn't modify the " +
                "partial class in this file since it's regenerated by Visual Studio when you modify the components on the page.\n" +
                "\t\t- The other file contains the partial class you use to implement the look and behavior of the components of the page or form.\n\n" +
                "\t- Besides partial classes, you can create two other partial types, which are the following:\n" +
                "\t\t- Partial structs.\n" +
                "\t\t- Partial interfaces.\n");
            ReadKey();

            Clear();
        }

        static void PartialMethods()
        {
            Clear();

            WriteLine("\nPartial Methods\n" +
                "\t- Partial methods are methods that are declared in different parts of a partial class. The different parts of the partial method can be declared in " +
                "different parts of the partial class or in the same part.\n\n" +
                "\t- The two parts of the partial method are the following:\n" +
                "\t\t- The defining partial method declaration\n" +
                "\t\t\t- Lists are signature and return type.\n" +
                "\t\t\t- The implementatiom part of the declaration syntax consists of only a semicolon.\n\n" +
                "\t\t- The implementing partial method declaration\n" +
                "\t\t\t- Lists the signature and return type.\n" +
                "\t\t\t- The implementation is in the normal format, which, as you know, is a statement block.\n\n" +
                "\t- The important things to know about partial methods are the following:\n" +
                "\t\t- The defining and implementing declarations must match in signature and return type. The signature and return type have the following characteristics:\n" +
                "\t\t\t- The return type must be 'void'.\n" +
                "\t\t\t- The signature cannot include access modifiers, 'making partial methods implicitly private'.\n" +
                "\t\t\t- The parameter list cannot contain 'out' parameters.\n" +
                "\t\t\t- The contextual keyword 'partial' must be included in both the defining and implementing declarations immediately before the keyword 'void'.\n" +
                "\t\t- You can have a defining partial method without an implementing partial method. In this case, the compiler removes the declaration and any calls to " +
                "the method made inside the class. You cannot have an implementing partial method without a defining partial method.\n");
            ReadKey();

            Clear();
        }
    }

    static class Eight
    {
        public static void ClassesAndInheritance()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tClasses and Inheritance\n");
                WriteLine("\t1. Class Inheritance\n\t2. Accessing the Inherited Members\n\t3. All Classes Are Derived from Class object" +
                    "\n\t4. Masking Members of a Base Class\n\t5. Base Access\n\t6. Using Reference to a Base Class" +
                    "\n\t7. Constructor Execution\n\t8. Inheritance Between Assemblies\n\t9. Member Access Modifiers" +
                    "\n\t10. Abstract Members\n\t11. Abstract Classes\n\t12. Sealed Classes\n\t13. Static Classes" +
                    "\n\t14. Extension Methods\n\t15. Naming Conversions\n\t16. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                EightDecision(ref choice);

            } while (choice != 16);
            Clear();
        }

        static void EightDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    ClassInheritance();
                    break;
                case 2:
                    AccessingTheInheritedMembers();
                    break;
                case 3:
                    AllClassesAreDerivedFromClassObject();
                    break;
                case 4:
                    MaskingMembersOfABaseClass();
                    break;
                case 5:
                    BaseAccess();
                    break;
                case 6:
                    UsingReferenceToABaseClass();
                    break;
                case 7:
                    ConstructorExecution();
                    break;
                case 8:
                    InheritanceBetweenAssemblies();
                    break;
                case 9:
                    MemberAccessModifiers();
                    break;
                case 10:
                    AbstractMembers();
                    break;
                case 11:
                    AbstractClasses();
                    break;
                case 12:
                    SealedClasses();
                    break;
                case 13:
                    StaticClasses();
                    break;
                case 14:
                    ExtensionMethods();
                    break;
                case 15:
                    NamingConventions();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void ClassInheritance()
        {
            Clear();

            WriteLine("\nClass Inheritance\n" +
                "\t- Inheritance allows you to define a new class that incorporates and extends an already declared class.\n" +
                "\t\t- You can use an existing class, called the 'base class', as the basis for a new class, called the 'derived class'. The members of the derived class consists " +
                "of the following:\n" +
                "\t\t\t- The members in its own declaration.\n" +
                "\t\t\t- The members of the base class.\n" +
                "\t\t- To declare a derived class, you add a class-base specification after the class name. The class-base specification consists of a colon, followed by the " +
                "name of the class to be used as the base class. The derived class is said to directly inherit from the base class listed.\n" +
                "\t\t- A derived class is said to extend its base class because it includes the members of the base class plus any additional functionality provided in its " +
                "own declaration.\n" +
                "\t\t- A derived class 'cannot delete' any of the members it has inherited.\n\n" +
                "\t- Syntax for class inheritance\n\n" +
                "\t\tclass DerivedClass : BaseClass\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t}\n");
            ReadKey();

            Clear();
        }

        static void AccessingTheInheritedMembers()
        {
            Clear();

            WriteLine("\nAccessing the Inherited Members\n" +
                "\t- Inherited members are accessed just as if they had been declared in the derived class itself. Inherited constructors are a bit different.\n" +
                "\t- The code can be seamlessly accessed, regardless of whether they are declared in the base class or the derived class.\n");
            ReadKey();

            Clear();
        }

        static void AllClassesAreDerivedFromClassObject()
        {
            Clear();

            WriteLine("\nAll Classes Are Derived from Class Object\n" +
                "\t- 'All' classes, except the special class 'object', are derived class, even if they don't have a class-base specification. Class 'object' " +
                "is the only class that is not derived since it is the base of the inheritance heirarchy.\n" +
                "\t- Classes without a class-base specification are implicitly derived directly from class 'object'. Leaving off the class-base specification " +
                "is just shorthand for specifying that 'object' is the base class.\n\n" +
                "\t- The two forms are semantically equivalent.\n\n" +
                "\t\tclass BaseClass\t\t\tclass BaseClass : object\n" +
                "\t\t{\t\t\t\t{\n" +
                "\t\t\t...\t\t\t\t...\n" +
                "\t\t}\t\t\t\t}\n\n" +
                "\t- The class declaration on the left implicitly derives from class object, while the one on the right explicitly derives from object.\n\n" +
                "\t- Other important facts about class derivation are the following:\n" +
                "\t\t- A class declaration can have only a single class listed in its class-base specification. This is called 'single inheritance'.\n" +
                "\t\t- Although a class can directly inherit from only a single base class, there is no limit to the 'level' of derivation. That is, the class " +
                "listed as the base class might be derived from another class, which is derived from another class, and so forth, until you eventually reach 'object'.\n\n" +
                "\t- 'Base class' and 'derived class' are relative terms. All classes are derived class, either from 'object' or from another class - so generally when we " +
                "call a class derived class, we mean that it is immediately derived from some class other than 'object'.");
            ReadKey();

            Clear();
        }

        static void MaskingMembersOfABaseClass()
        {
            Clear();

            WriteLine("\nMasking Members of a Base Class\n" +
                "\t- A derived class cannot delete any of the members it has inherited; it can, however, mask a base class member with a member of the same name. This is " +
                "extremely useful, and one of the major features of inheritance.\n" +
                "\t- You might want to inherit from a base class that has a particular method. That method, although perfect for the class in which it is declared, may " +
                "not do exactly what you want in the derived class. If so, what you want to do is mask the base class method with a new member declared in the derived class.\n\n" +
                "\t- Some important aspects of masking a base class member in a derived class are the following:\n" +
                "\t\t- To mask an inherited 'data' member, declare a new member of the same type and with the same 'name'.\n" +
                "\t\t- To mask an inherited 'function' member, declare a new function member with the same signature. Remember that the signature consists of the name and " +
                "parameter list but does not include the return type.\n" +
                "\t\t- To let the compiler know that you're purposely masking an inherited member, use the 'new' modifier. Without it, the program will compile succesfully, " +
                "but the compiler will warn you that you're hiding an inherited member.\n" +
                "\t\t- You can also mask static members.\n\n" +
                "\t- The keyword 'new' is used to explicitly tell the compiler to mask the base class member.\n\n" +
                "\t\tclass BaseClass\n" +
                "\t\t{\n" +
                "\t\t\tAccessModifier Type Identifier;\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t\tclass DerivedClass : BaseClass\n" +
                "\t\t{\n" +
                "\t\t\tnew AccessModifier Type Identifier;\n" +
                "\t\t\t...\n" +
                "\t\t}\n");
            ReadKey();

            Clear();
        }

        static void BaseAccess()
        {
            Clear();

            WriteLine("\nBase Access\n" +
                "\t- If you're derived class absolutely must access a hidden member, you can access it by using a 'base access' expression.\n" +
                "\t- This expression consists of the keyword 'base', followed immediately by a period and the name of the member.\n\n" +
                "\t\tbase.Identifier;\n\n" +
                "\t- If you find that your program's code is frequently using this feature - that is, accessing a hidden inherited member - you " +
                "might want to reevaluate the design of your classes.\n" +
                "\t- Generally there are more elegant designs, but the feature is there if there is a situation where nothing else will do.\n");
            ReadKey();

            Clear();
        }

        static void UsingReferenceToABaseClass()
        {
            Clear();

            WriteLine("\nUsing References to a Base Class\n" +
                "\t- An instance of a derived class consists of an instance of the base class plus the additional members of the derived class. A " +
                "reference to the derived class points to the whole class object, including the base class part.\n" +
                "\t- If you have a reference to a derived class object, you can get a reference to just the base class part of the object by 'casting' " +
                "the reference to the type of the base class by using the 'cast operator'.\n" +
                "\t- The cast operator is placed in front of the object reference and consists of a set of parentheses containing the name of the " +
                "class being cast to.\n" +
                "\t- The effect of casting a derived class object to the base class object is that the resulting variable has access only to members " +
                "of the base class (except in the case of an overriden method).\n");
            WriteLine("\nVirtual and Override Methods\n" +
                "\t- When accessing an object of a derived class by using a reference to the base class, you get only the members from the base class. " +
                "'Virtual methods' allow a reference to the base class to access 'up into' the derived class.\n\n" +
                "\t- You can use a reference to a base class to call a method in the 'derived class' if the following are true:\n" +
                "\t\t- The method in the derived class and the method in the base class each have the same signature and return type.\n" +
                "\t\t- The method in the base class is labeled 'virtual'.\n" +
                "\t\t- The method in the derived class is labeled 'override'.\n\n" +
                "\t- The following code shows the 'virtual' and 'override' modifiers on the methods in the base class and derived class\n\n" +
                "\t\tclass BaseClass\n" +
                "\t\t{\n" +
                "\t\t\tvirtual AccessModifier ReturnType MethodName();\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t\tclass DerivedClass : BaseClass\n" +
                "\t\t{\n" +
                "\t\t\toverride AccessModifier ReturnType MethodName();\n" +
                "\t\t\t..\n" +
                "\t\t}\n\n" +
                "\t- Other important things to know about the 'virtual' and 'override' modifiers are the following:\n" +
                "\t\t- The overriding and overriden methods must have the same accessibility. In other words, the overriden method cannot be, " +
                "for example, 'private', and the overriding method 'public'.\n" +
                "\t\t- You cannot override a method that is 'static' or is not declared as 'virtual'.\n" +
                "\t\t- Methods, properties, and indexers, another member type, called an 'event', can all be declared 'virtual' and 'override'.\n");
            WriteLine("\nOverriding a Method Marked Override\n" +
                "\t- Overriding methods can occur between any levels of inheritance.\n" +
                "\t\t- When you use a reference to the base class part of an object to call an overidden method, the method call is passed up " +
                "the derivation heirarchy for execution to the 'most derived' version of the method marked as 'override'.\n" +
                "\t\t- If there are other declarations of the method at higher levels of derivations that are not marked as 'override', they " +
                "are not invoked.\n" +
                "\t\t- The only difference is whether the method is declared with the modifier 'override' or modifier 'new'.\n");
            ReadKey();

            Clear();
        }

        static void ConstructorExecution()
        {
            Clear();

            WriteLine("\nConstructor Execution\n" +
                "\t- A constructor executes code that prepares a class for use. This includes initializing both the static and instance members " +
                "of the class, and a part of a derived class object is an object of the base class.\n" +
                "\t\t- To create the base class part of an object, a constructor for the base class is implicitly called as part of the " +
                "process of creating the instance.\n" +
                "\t\t- Each class in the inheritance heirarchy chain executes its base class constructor before it executes its own constructor " +
                "body.\n\n" +
                "\t- When an instance is being created, one of the first things that is done is the initialization of all the instance members " +
                "of the object. After that, the base class constructor is called. Only then is the body of the constructor of the class itself executed.\n\n" +
                "\t- Calling a virtual method in a constructor is 'strongly discouraged'. The virtual method in the base class would call the override " +
                "method in the derived class while the base class constructor is being executed.\n" +
                "\t- But that would be before the derived constructor's body is executed. It would, therefore, be calling up into the derived class before " +
                "the class is completely initialized.\n");
            WriteLine("\nConstructor Initializers\n" +
                "\t- By default, the parameterless constructor of the base class is called when an object is being constructed. But constructor can be " +
                "overloaded, so a base class might have more than one.\n" +
                "\t- If you want your derived class to use a specific base class constructor other than the parameterless constructor, you must specify " +
                "it in a 'construct initializer'.\n" +
                "\t\t- There are two forms of constructor initializers.\n" +
                "\t\t\t- The first form uses the keyword 'base' and specifies which base class constructor to use.\n" +
                "\t\t\t- The second form uses the keyword 'this' and specifies which other constructor from this class should be used.\n\n" +
                "\t- A base class constructor initializer is placed after a colon following the parameter list in a class's constructor declaration. " +
                "The constructor initializer consists of the keyword 'base' and the parameter list of the base constructor to call.\n\n" +
                "\t\tAccessModifier DerivedClass( Type Identifier, Type Identifier ) : base( Identifier, Identifier ) \n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t- The constructor initializer specifies that the construction process should call the base class constructor with two parameters.\n" +
                "\t- The parameters in the base parameter list must match the 'intended base constructor's' parameter list in type and order.\n\n" +
                "\t- When you declare a constructor without a constructor initializer, it is a shortcut for the form with a constructor initializer " +
                "consisting of 'base()'. The two forms are semantically equivalent.\n\n" +
                "\t\tclass DerivedClass : BaseClass\t\t\tclass DerivedClass : BaseClass\n" +
                "\t\t{\t\t\t\t\t\t{\n" +
                "\t\t\tDerivedClass()\t\t\t\t\tDerivedClass() : base()\n" +
                "\t\t\t{\t\t\t\t\t\t{\n" +
                "\t\t\t\t...\t\t\t\t\t\t...\n" +
                "\t\t\t}\t\t\t\t\t\t}\n" +
                "\t\t}\t\t\t\t\t\t}\n\n" +
                "\t- The other forms of constructor initializer instructs the construction process (actually, the compiler) to use a different constructor " +
                "from the same class. \n\n" +
                "\t- The following shows a constructor with a single parameter. That single-parameter constructor, however, uses a constructor from the " +
                "same clas, but with two parameters, supplying a default parameter as the second one.\n\n" +
                "\t\tAccessModifier DerivedClass( Type Identifier ) : this( Identifier, \"Default Parameter\")\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t- Another situation where this comes in particularly handy is where you have several constructors for a class and they have common code " +
                "that should always be performed at the beginnig of the object construction process.\n" +
                "\t- In this case, you can factor out the common code and place it in a constructor that is used as a constructor initilizer by all " +
                "the other constructors. In fact, this is a recommended practice since it reduces code duplication.\n\n" +
                "\t- You might think that you could just declare another method that performs those common initializations and have all the constructors " +
                "call that method. This is not as good for several reasons.\n" +
                "\t- The first is that the compiler can optimize certain things when it knows a method is a constructor. \n" +
                "\t- The second is that there are some things that can be done only in a constructor and not elsewhere.\n" +
                "\t- For example, in the previous chapter you learned that 'readonly' fields can be initialized only inside a constructor. You will get " +
                "a compiler error if you attempt to initialize a 'readonly' field in another method, even if that method is only called by a constructor.\n" +
                "\t- Note, however, that this constraints only applies to 'readonly' fields and not to 'readonly' properties.\n\n" +
                "\t- Going back to that common constructor, if it can stand on its own as a valid constructor that initializes everything in the class that " +
                "needs to be initialized, then it's perfectly fine to leave it as a 'public' constructor.\n" +
                "\t- What if, however, it doesn't completely initialize an object? If so, you mustn't allow that constructor to be callable from outside the " +
                "class since it would then create incompletely initialized objects.\n" +
                "\t- To avoid that problem, you can declare tha constructor 'private' instead of 'public' and have it used only by other constructors.\n");
            WriteLine("\nClass Access Modifiers\n" +
                "\t- A class can be seen and accessed by other classes in the system.\n" +
                "\t- The term 'visible' is sometimes used for the term 'accessible'. They can be used interchangeably. There are two levels of class " +
                "accessibility: 'public' and 'internal'.\n" +
                "\t\t- A class marked 'public' can be accessed by code from any assembly in the system. To make a class visible to other assemblies, " +
                "use the 'public' access modifier.\n" +
                "\t\t- A class marked 'internal' can be seen only by classes within its own assembly. \n" +
                "\t\t\t- This is the default accessiblity level, so unless you explicitly specify the modifier 'public' in the class declaration, code " +
                "outside the assembly cannot access the class.\n" +
                "\t\t\t- You can explicitly declare a class internal by using the 'internal' access modifier.\n");
            ReadKey();

            Clear();
        }

        static void InheritanceBetweenAssemblies()
        {
            Clear();

            WriteLine("\nInheritance Between Assemblies\n" +
                "\t- C# also allows you to derive a class from a base class defined in a different assembly.\n" +
                "\t- To have your classes derive from a base class in another assembly, the following must be true:\n" +
                "\t\t- The base class must be declared 'public' so that it can be accessed from outside its assembly.\n" +
                "\t\t- You must include a reference to the assembly containing the base class in the Reference section " +
                "of your Visual Studio project. You can find the heading in Solution Explorer.\n\n" +
                "\t- To make it easier to refer to the classes and types in the other assembly without constantly using their fully qualified names, " +
                "place a 'using' directive at the top of the source file, with the namespace containing the classes or types you want to access.\n\n" +
                "\t- Note, adding a reference to the other assembly and adding a 'using' directive are two separate things. Adding the reference to " +
                "the other assembly tells the compiler where the required types are defined.\n" +
                "\t- Adding the 'using' directive allows you to reference other classes without having to use their fully qualified names.\n");
            ReadKey();

            Clear();
        }

        static void MemberAccessModifiers()
        {
            Clear();

            WriteLine("\nMember Access Modifiers\n" +
                "\t- With class accessibility, there are only two modifiers - 'internal' and 'public'. Class accessiblity describes the visibility " +
                "of a class; 'member accessibility' describes the visibility of the members of a class object.\n" +
                "\t- Each member declared in a class is visible to various parts of the system, depending on the access modifier assigned to it in " +
                "its class declaration.\n\n" +
                "\t- Before looking at the specifics of member accessibility, there are some general things we need to mention first:\n" +
                "\t\t- All members explicitly declared in a class's declaration are visible to each other, regardless of their accessibility specification.\n" +
                "\t\t- Inherited members are explicitly declared in a class's declaration, inherited members might or might not be visible to " +
                "members of a derived class.\n" +
                "\t\t- The following are the names of the five member access levels.\n" +
                "\t\t\t- public" +
                "\t\t\t- private\n" +
                "\t\t\t- protected\n" +
                "\t\t\t- internal\n" +
                "\t\t\t- protected internal\n" +
                "\t\t- You must specify member access levels on a per-member basis. If you don't specify an access level for a member, its implicit " +
                "access level is 'private'.\n" +
                "\t\t- A member cannot be more accessible that its class. That is, if a class has an accessibility level limiting it to the assembly, " +
                "individual members of the class cannot be seen outside the assembly, regardless of their access modifiers, even 'public'.\n");
            WriteLine("\nRegions Accessing a Member\n" +
                "\t- A class specifies which of its members can be accessed by other classes by labeling its members with access modifiers.\n");
            WriteLine("\nPublic Member Accessibility\n" +
                "\t- The 'public' access level is the least restrictive. All classes both inside and outside the assembly have free access to the member.\n" +
                "\t- To declare a member public, use the 'public' access modifier.\n" +
                "\t- A public member of a public class is visible to all classes in the same assembly and other assemblies.\n");
            WriteLine("\nPrivate Member Accessibility\n" +
                "\t- The 'private' access level is the most restrictive.\n" +
                "\t\t- A 'private' class member can be accessed only by members of its own class. It cannot be accessed by other classes, including classes " +
                "that are derived from it.\n" +
                "\t\t- A 'private' member can, however, be accessed by members of classes nested in its class.\n" +
                "\t\t- A private member of any class is visible only to member of its own class or nested classes.\n");
            WriteLine("\nProtected Member Accessibility\n" +
                "\t- The 'protected' access level is like the 'private' access level except that it also allows classes derived from the class to access the " +
                "member.\n" +
                "\t- The protected member of a public class is visible to members of its own class and classes derived from it. The derived classes can " +
                "even be in other assemblies.\n");
            WriteLine("\nInternal Member Accessibility\n" +
                "\t- Members marked 'internal' are visible to all the classes in the assembly, but not to classes outside the assembly.\n" +
                "\t- An internal member of a public class is visible to members of any class in the same assembly, but not to classes outside the assembly.\n");
            WriteLine("\nProtected Internal Member Accessibility\n" +
                "\t- Members marked 'protected internal' are visible to all classes that inherit from the class and also to all classes inside the assembly.\n" +
                "\t- The set of classes allowed access is the combined set of classes allowed by the 'protected' modifier plus the set of classes allowed " +
                "by the 'internal' modifier. Notice that this is the 'union' of 'protected' and 'internal' - not the intersection.\n" +
                "\t- A protected internal member of a public class is visible to members of classes in the same assembly and to members of classes derived " +
                "from that class. It's not visible to classes in other assemblies that are not derived from the class.\n");
            WriteLine("\nSummary of Member Access Modifier\n" +
                "\t- The following summarize the characteristics of the five member access levels.\n\n" +
                "\tMember Access Modifiers\n\n" +
                "\t\tprivate\t\t\t\tAccessible only within the class\n" +
                "\t\tinternal\t\t\tAccessible to all classes within this assembly\n" +
                "\t\tprotected\t\t\tAccessible to all classes derived from this class\n" +
                "\t\tprotected internal\t\tAccessible to all classes that are either derived from this class or declared within this assembly\n" +
                "\t\tpublic\t\t\t\tAccessible to any class\n");
            ReadKey();

            Clear();
        }

        static void AbstractMembers()
        {
            Clear();

            WriteLine("\nAbstract Members\n" +
                "\t- An 'abstract member' is a function member that is designed to be ovverridden. \n" +
                "\t- An abstract member has the following characteristics:\n" +
                "\t\t- It must be a function member. That is, fields and constants cannot be abstract members.\n" +
                "\t\t- It must be marked with the 'abstract' modifier.\n" +
                "\t\t- It must not have an implementation code block. The code of an abstract member is represented by a semicolon.\n\n" +
                "\t- Abstract members can be declared only in 'abstract classes'. Four types of members can be declared as abstract.\n" +
                "\t\t- Methods\n" +
                "\t\t- Properties\n" +
                "\t\t- Events\n" +
                "\t\t- Indexers\n\n" +
                "\t- Other important facts about abstract members are the following:\n" +
                "\t\t- Abstract members, although they must be overriden by a corresponding member in a derived class, 'cannot' use the " +
                "'virtual' modifier in addition to the 'abstract' modifier.\n" +
                "\t\t- As with virtual members, the implementation of an abstract member in a derived class must specify the 'override' " +
                "modifier.\n\n" +
                "\tComparing Virtual and Abstract Members\n\n" +
                "\t\t\t\t\tVirtual Member\t\t\t\tAbstract Member\n\n" +
                "\tKeyword\t\t\t\t'virtual'\t\t\t\t'abstract'\n" +
                "\tImplementation body\t\tHas an implementation body\t\tNo implementation body - semicolon instead\n" +
                "\tOverriden in a derived class\t'Can' be overriden - using 'override'\t'Must' be overriden - using 'override'\n" +
                "\tTypes of members\t\tMethods\t\t\t\t\tMethods\n" +
                "\t\t\t\t\tProperties\t\t\t\tProperties\n" +
                "\t\t\t\t\tEvents\t\t\t\t\tEvents\n" +
                "\t\t\t\t\tIndexers\t\t\t\tIndexers\n");
            ReadKey();

            Clear();
        }

        static void AbstractClasses()
        {
            Clear();

            WriteLine("\nAbstract Classes\n" +
                "\t- Abstract classes are designed to be inherited from. An 'abstract class' can be used only as the base class of " +
                "another class.\n" +
                "\t\t- You cannot create instances of abstract class.\n" +
                "\t\t- An abstract class is declared using the 'abstract' modifier.\n" +
                "\t\t- An abstract class can contain abstract members of regular, nonabstract members. The members of an abstract class " +
                "can be any combination of abstract members and normal members with implementations.\n" +
                "\t\t- An abstract class can be itself be derived from another abstract class.\n" +
                "\t\t- Any class derived from an abstract class must implement all the abstract members of the class by using the 'override' " +
                "keyword, unless the derived class is itself abstract.\n");
            ReadKey();

            Clear();
        }

        static void SealedClasses()
        {
            Clear();

            WriteLine("\nSealed Classes\n" +
                "\t- An abstract class must be used as a base class - it cannot be instantiated as a stand-alone class object. The opposite " +
                "is true of a 'sealed class'.\n" +
                "\t\t- A sealed class can be initiated only as a stand-alone class object - it cannot be used as a base class.\n" +
                "\t\t- A sealed class is labeled with the 'sealed' modifier.\n");
            ReadKey();

            Clear();
        }

        static void StaticClasses()
        {
            Clear();

            WriteLine("\nStatic Classes\n" +
                "\t- A static class is a class where all the members are static. Static classes are used to group data and functions that are not " +
                "affected by instance data. \n" +
                "\t- A common use of a static class might be to create a math library containing sets of mathematical methods and values.\n\n" +
                "\t- The important things to know about a static class are the following:\n" +
                "\t\t- The class itself must be marked 'static'.\n" +
                "\t\t- All the members of the class must be static.\n" +
                "\t\t- The class can have a static constructor, but it cannot have an instance constructor since you cannot create an instance of the " +
                "class.\n" +
                "\t\t- Static classes are implicitly sealed. That is, you cannot inherit from a static class.\n\n" +
                "\t- Access the members of a static class just as you would access any static member - by using the class name and the member name. \n" +
                "\t- Also, starting with C# 6.0 you can access members of a static class without the class name provided that you have a 'using' static " +
                "directive.");
            ReadKey();

            Clear();
        }

        static void ExtensionMethods()
        {
            Clear();

            WriteLine("\nExtension Methods\n" +
                "\t- The 'extension method' feature allows you to write methods associated with classes 'other that the class in which they are declared'.\n" +
                "\t- In real-world development, extension methods are an incredibly useful tool. In fact, almost the entire library of LINQ queries is " +
                "implemented via extension methods.\n\n" +
                "\t- The important requirements for an extension method are the following:\n" +
                "\t\t- The class in which the extension method is declared must be declared 'static'.\n" +
                "\t\t- The extension method itself must be declared 'static'.\n" +
                "\t\t- The extension method must contain as its first parameter type the keyword 'this', followed by the name of the class it is extending.\n");
            ReadKey();

            Clear();
        }

        static void NamingConventions()
        {
            Clear();

            WriteLine("\nNaming Conventions\n" +
                "\t- Writing programs requires coming up with lots of names - names for classes, variables, methods, properties, and lots.\n" +
                "\t- When you are reading through a program, using naming conventions is an important method of giving you a clue as to the kinds of objects " +
                "you are dealing with.\n\n" +
                "\t- Commonly Used Identifier Naming Styles\n\n" +
                "\t\t- Pascal Casing\n" +
                "\t\t\t- Each word in the identifier is capitalized.\n" +
                "\t\t\t- Use for type names and member names visible outside the class. These include the name of the following: classes, methods, namespaces, " +
                "properties, and public fields.\n\n" +
                "\t\t- CamelCasing\n" +
                "\t\t\t- Each word in the identifier, except the first, is capitalized.\n" +
                "\t\t\t- Use for local variable names and the names of formal parameters in methdod declarations.\n\n" +
                "\t\t- Camel case with leading underscore\n" +
                "\t\t\t- This is a camel-cased identifier that starts with an underscore.\n" +
                "\t\t\t- Use for the names of private and protected fields.\n\n" +
                "\t- One major pillar of maintainable code is the use of accurate, self-descriptive variable names. When it comes to variable names, brevity needs " +
                "to bow to the adage that 'haste makes waste'.\n" +
                "\t- Not everyone with these conventions, especially the leading-underscore part. Some find the leading underscore very useful, while others " +
                "find it exceedingly ugly.\n" +
                "\t- One last word about underscores is that they aren't generally used in the body of an identifier, except in the names of event handlers.\n");
            ReadKey();

            Clear();
        }
    }

    class Nine
    {
        public static void ExpressionsAndOperators()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tExpressions and Operators\n" +
                "\n\t1. Expressions\n\t2. Literals\n\t3. Order of Evaluation\n\t4. Simple Arithmetic Operators\n\t5. The Remainder Operator" +
                "\n\t6. Relational and Equality Comparison Operators\n\t7. Increment and Decrement Operators\n\t8. Conditional Logical Operators" +
                "\n\t9. Logical Operators\n\t10. Shift Operators\n\t11. Assignment Operators\n\t12. The Conditional Operator" +
                "\n\t13. Unary Arithmetic Operators\n\t14. User-Defined Type Conversions\n\t15. Operator Overloading\n\t16. The typeof Operator" +
                "\n\t17. The nameof Operator\n\t18. Other Operators\n\t19. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                NineDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        static void NineDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    Expressions();
                    break;
                case 2:
                    Literals();
                    break;
                case 3:
                    OrderOfEvaluations();
                    break;
                case 4:
                    SimpleArithmeticOperators();
                    break;
                case 5:
                    TheRemainderOperators();
                    break;
                case 6:
                    RelationalAndEqualityComparisonOperators();
                    break;
                case 7:
                    IncrementAndDecrementOperators();
                    break;
                case 8:
                    ConditionalLogicalOperators();
                    break;
                case 9:
                    LogicalOperators();
                    break;
                case 10:
                    ShiftOperators();
                    break;
                case 11:
                    AssignmentOperators();
                    break;
                case 12:
                    TheConditionalOperator();
                    break;
                case 13:
                    UnaryArithmeticOperators();
                    break;
                case 14:
                    UserDefinedTypeConversions();
                    break;
                case 15:
                    OperatorOverloading();
                    break;
                case 16:
                    ThetypeofOperator();
                    break;
                case 17:
                    ThenameofOperator();
                    break;
                case 18:
                    OtherOperators();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void Expressions()
        {
            Clear();

            WriteLine("\nExpressions\n" +
                "\t- An 'operator' is a symbol that represents an operation that returns a single result, An 'operand' is a data element " +
                "used as input by the operator.\n\n" +
                "\t- An operator does the following:\n" +
                "\t\t- Takes its operands as inputs.\n" +
                "\t\t- Performs an action.\n" +
                "\t\t- Returns a value, based on the action.\n\n" +
                "\t- An 'expression' is a string of operators and operands. The C# operators take one, two, or three operands.\n\n" +
                "\t- The following are some of the constructs that can act as operands:\n" +
                "\t\t- Literals\n" +
                "\t\t- Constants\n" +
                "\t\t- Variables\n" +
                "\t\t- Method calls\n" +
                "\t\t- Element accessors, such as array accessors and indexers\n" +
                "\t\t- Other expressions\n\n" +
                "\t- Expressions can be combined, using operators, to create more complex expressions.\n\n" +
                "\t- 'Evaluating' an expression is the process of applying each operator to its operands, in the proper sequence, to " +
                "produce a value.\n" +
                "\t\t- The value is returned to the position at which the expression was evaluated. There, it might in turn be used " +
                "as an operand in an enclosing expression.\n" +
                "\t\t- Besides the value returned, some expressions also have side effects, such as setting a value in memory.\n");
            ReadKey();

            Clear();
        }

        static void Literals()
        {
            Clear();

            WriteLine("\nLiterals\n" +
                "\t- Literals are numbers or strings typed into the source code that represent a specific, set value of specific type. \n" +
                "\t- Because literals are written into the source code, their values must be known at compiler time. Several of the " +
                "predefined types have their own forms of literal.\n" +
                "\t\t- Type 'bool' has two literals: 'true' and 'false'. Note that these, like all C# keywords, are lowercase.\n" +
                "\t\t- For reference type variables, literal 'null' means that the variable does not point to data in memory.\n");
            WriteLine("\nInteger Literals\n" +
                "\t- Integer literals are the most commonly used literals. They are written as a sequence of decimal digits, with the " +
                "following characteristics:\n" +
                "\t\t- No decimal point.\n" +
                "\t\t- An optional suffix to specify the type of the integer.\n\n" +
                "\t- Integer-type literals can also be written in hexadecimal (hex) form. The digits must be hex digits (0 through F), " +
                "and the string must be prefaced with either 0x or 0X (numeral 0, letter x).\n" +
                "\t- A third format for integer-type literals is binary notation. All digits must be either 0 or 1 and must be preceeded " +
                "by either 0b or 0B (numeral 0, letter b).\n\n" +
                "\t- Note that only integer-type literals can be expressed in hex or binary-form. Hex and binary notation are specified " +
                "with a prefix, while the actual data type is specified using a suffix.\n\n" +
                "\t- For a given suffix, the compiler will interpret the string of digits as the smallest of the four integer types that " +
                "can represent the value without losing data.\n" +
                "\t- Fortunately, you can now insert separators in a numeric literal to make it easier to interpret.\n");
            WriteLine("\nReal Literals\n" +
                "\t- C# has three real number data types: 'float', 'double' and 'decimal'. These correspond to 32 bits, 64 bits, and " +
                "128 bits of precision.\n" +
                "\t- All three are floating-point data types, meaning that they are represented internally by two components, one " +
                "representing the digits comprising the actual number and one, an exponent, that specifies the location of the decimal " +
                "point.\n" +
                "\t- In practical usage, by far the most common real number data type is 'double'.\n\n" +
                "\t- Literals for real numbers consist of the following:\n" +
                "\t\t- Decimal digits\n" +
                "\t\t- An optional decimal point\n" +
                "\t\t- An optional exponent part\n" +
                "\t\t- An optional suffix\n\n" +
                "\t- Components with names in square brackets are optional. The exponent part consist of:\n" +
                "\t\t- An E, either upper- or lowercase\n" +
                "\t\t- An optional sign\n" +
                "\t\t- Decimal digits\n\n" +
                "\t- Suffixes for the Real Literals\n\n" +
                "\t\tSuffix\t\tReal Type\n\n" +
                "\t\tNone\t\tdouble\n" +
                "\t\tF, f\t\tfloat\n" +
                "\t\tD, d\t\tdouble\n" +
                "\t\tM, m\t\tdecimal\n\n" +
                "\t- Note that real literals without a suffix are of type 'double', not 'float'.\n");
            WriteLine("\nCharacter Literals\n" +
                "\t- A character literals consists of a character representation between two single quote marks. \n" +
                "\t- Character literals are used to represent single character (a), nonprinting characters (\\n)(newline), " +
                "or characters that otherwise perform special task such as escape (\\\\).\n" +
                "\t- Even though it might require multiple characters to express a character literal, each character literal " +
                "represents only a single character. To refer to multiple characters, you must use a string literal.\n\n" +
                "\t- A character representation can be any of the following: a single character, a simple escape sequence, a " +
                "hex escape sequence, or a Unicode escape sequence. \n\n" +
                "\t- Important things to know about character literals are the following:\n" +
                "\t\t- A type of a character literal is 'char'.\n" +
                "\t\t- A 'simple escape sequence' is a backlash followed by a single character.\n" +
                "\t\t- A hex escape sequence is a backlash, followed by an uppercase or lowercase 'x', followed by up to four " +
                "hex digits.\n" +
                "\t\t- A Unicode escape sequence is a backlash, followed by an uppercase or lowercase 'u', followed by up to " +
                "four hex digits.\n\n" +
                "\t- Important Special Characters\n\n" +
                "\t\tName\t\t\tEscape Sequence\t\tHex Encoding\n\n" +
                "\t\tNull\t\t\t\\0\t\t\t0x0000\n" +
                "\t\tAlert\t\t\t\\a\t\t\t0x0007\n" +
                "\t\tBackspace\t\t\\b\t\t\t0x0008\n" +
                "\t\tHorizontal tab\t\t\\t\t\t\t0x0009\n" +
                "\t\tNew line\t\t\\n\t\t\t0x000A\n" +
                "\t\tVertical tab\t\t\\v\t\t\t0x000B\n" +
                "\t\tForm feed\t\t\\f\t\t\t0x000C\n" +
                "\t\tCarriage return\t\t\\r\t\t\t0x000D\n" +
                "\t\tDouble quote\t\t\\\"\t\t\t0x0022\n" +
                "\t\tSingle quote\t\t\\\'\t\t\t0x0027\n" +
                "\t\tBackslash\t\t\\\\\t\t\t0x005C\n");
            WriteLine("\nString Literals\n" +
                "\t- String literals use double quotes marks rather than the single quote marks used in character literals.\n\n" +
                "\t- There are two types of string literals.\n" +
                "\t\t- Regular string literals\n" +
                "\t\t- Verbatim string literal\n\n" +
                "\t- A regular string literal consists of a sequence of characters between a set of double quotes.\n\n" +
                "\t- A regular string literal can include the following:\n" +
                "\t\t- Characters\n" +
                "\t\t- Simple escape sequences\n" +
                "\t\t- Hex and Unicode escape sequences\n\n" +
                "\t- A verbatim string literal is written like a regular string but is prefaced with an '@' character. \n\n" +
                "\t- The important characteristics of verbatim string literals are the following:\n" +
                "\t\t- Verbatim literals differ from regular string literals in that escape sequences within the string are " +
                "not evaluated. Everything between the set of double qoutes - including what would normally be considered " +
                "escape sequences - is printed exactly as it is listed in the string.\n" +
                "\t\t- The only exceptions with verbatim literals are sets of contiguous double quotes, which are interpreted " +
                "as a single double qoute character.\n\n" +
                "\t- Note that the compiler saves memory by having identical string literals share the same memory location in " +
                "the heap.\n");
            ReadKey();

            Clear();
        }

        static void OrderOfEvaluations()
        {
            Clear();

            WriteLine("\nOrder of Evaluation\n" +
                "\t- An expression can be made up od many nested subexpressions. The order in which the subexpressions are evaluated can make a difference " +
                "in the final value of the expression.\n");
            WriteLine("\nPrecedence\n" +
                "\t- Operator Precedence: Highest to Lowest\n\n" +
                "\t\tCategory\t\t\tOperators\n\n" +
                "\t\tPrimary\t\t\t\ta.x, f(x), a[x], x++, x--, new, typeof, checked, unchecked\n" +
                "\t\tUnary\t\t\t\t+, -, !, ~, ++x, --x, (T)x\n" +
                "\t\tMultiplicative\t\t\t*, /, %\n" +
                "\t\tAdditive\t\t\t+, -\n" +
                "\t\tShift\t\t\t\t<<, >>\n" +
                "\t\tRelational and type\t\t<, >, <=, >=, is, as\n" +
                "\t\tEquality\t\t\t==, !=\n" +
                "\t\tLogical AND\t\t\t&\n" +
                "\t\tLogical XOR\t\t\t^\n" +
                "\t\tLogical OR\t\t\t|\n" +
                "\t\tConditional AND\t\t\t&&\n" +
                "\t\tConditional OR\t\t\t||\n" +
                "\t\tConditional\t\t\t?:\n" +
                "\t\tAssignment\t\t\t=, *=, /=, %=, +=, -=, <<=, >>=, &=, ^=, |=\n");
            WriteLine("\nAssociativity\n" +
                "\t- When the compiler is evaluating an expression where all the operators have different levels of precedence, then each subexpression is " +
                "evaluated, starting at the one with the highest level and working down the precedence scale.\n" +
                "\t- When sequential operators have the same level of precedence, the order of evaluation is determined by 'operator associativity'. \n" +
                "\t- That is, given two operators of the same level of precedence, one or the other will have precedence, depending on the operators' " +
                "associativity.\n\n" +
                "\t- Some important characteristics of operator associativity are the following:\n" +
                "\t\t- 'Left-associative' operators are evaluated from left to right.\n" +
                "\t\t- 'Right-associative' operators are evaluated from right to left.\n" +
                "\t\t- Binary operators, except the assignment operators, are left-associative.\n" +
                "\t\t- The assignment operators and the conditional operator are right-associative.\n\n" +
                "\t- Summary of Operator Associativity\n\n" +
                "\t\tType of Operator\t\tAssociativity\n\n" +
                "\t\tAssignment operators\t\tRight-associative\n" +
                "\t\tOther binary operators\t\tLeft-associative\n" +
                "\t\tConditional operator\t\tRight-associative\n\n" +
                "\t- You can explicitly set the order of evaluation of the subexpression of the an expression by using parentheses. Parenthesized " +
                "subexpressions have the following qualities:\n" +
                "\t\t- They override the precedence and associativity rules.\n" +
                "\t\t- They are evaluated in order from the innermost nested set to the outermost.\n");
            ReadKey();

            Clear();
        }

        static void SimpleArithmeticOperators()
        {
            Clear();

            WriteLine("\nSimple Arithmetic Operators\n\n" +
                "\t- The Simple Arithmetic Operators\n\n" +
                "\t\tOperator\t\tName\t\tDescription\n\n" +
                "\t\t+\t\t\tAddition\t\tAdds the two operands.\n" +
                "\t\t-\t\t\tSubtraction\t\tSubstracts the second operand from the first.\n" +
                "\t\t*\t\t\tMultiplication\t\tMultiplies the two operands.\n" +
                "\t\t/\t\t\tDivision\t\tDivides the first operand by the second. Integer division rounds the results toward " +
                "0 to the neares integer.\n\n" +
                "\t- The arithmetic operators perform the standard aritmetic operations on al the predefined simple arithmetic types.\n");
            ReadKey();

            Clear();
        }

        static void TheRemainderOperators()
        {
            Clear();

            WriteLine("\nThe Remainder Operator\n" +
                "\t- The remainder operator (%) divides the first operand by the second operand, ignores the qoutient, and returns the remainder.\n" +
                "\t- The remainder operator is binary and left-associative.\n\n" +
                "\t- The remainder operator can also be used with real numbers to give 'real reminders'.\n");
            ReadKey();

            Clear();
        }

        static void RelationalAndEqualityComparisonOperators()
        {
            Clear();

            WriteLine("\nRelational and Equality Comparison Operators\n" +
                "\t- The relational and equality comparison operators are binary operators that compare their operands and return a value of type 'bool'.\n" +
                "\t- The relational and equality operators are binary and left-associative.\n\n" +
                "\t- The Relational and Equality Comparison Operators\n" +
                "\t\tOperator\tName\t\t\t\tDescription\n\n" +
                "\t\t<\t\tLess than\t\t\t'true' if the first operand is less than the second operand; 'false' otherwise.\n" +
                "\t\t>\t\tGreater than\t\t\t'true' if the first operand is greater is greater than the second operand; 'false' otherwise.\n" +
                "\t\t<=\t\tLess than or equal to\t\t'true' if the first operand is less than or equal to the second operand; 'false' otherwise.\n" +
                "\t\t>=\t\tGreater than or equal to\t'true' if the first operand is greater than or equal to the second operand; 'false' otherwise.\n" +
                "\t\t==\t\tEqual to\t\t\t'true' if the first operand is equal to the second operand; 'false' otherwise.\n" +
                "\t\t!=\t\tNot equal to\t\t\t'true' if the first operand is not equal to the second operand; 'false' otherwise.\n\n" +
                "\t- A binary expression with a relational or equality operator returns a value of type 'bool'.\n\n" +
                "\t- Note that unlike C and C++, numbers in C# do not have a Boolean interpretations.\n");
            WriteLine("\nComparison and Equality Operations\n" +
                "\t- When comparing most reference types for equality, only the references are compared.\n\n" +
                "\t- Objects of type 'string' are also reference types but are compared differently. When strings are compared for equality, they " +
                "are compared for length and case-sensitive content.\n" +
                "\t\t- If two strings have the same length and the same case-sensitive content, the equality comparison returns 'true', even if " +
                "they occupy different areas of memory.\n" +
                "\t\t- This is called a 'deep comparison'.\n\n" +
                "\t- Delegats are also referenced types and also use deep comparison. When delegates are compared for equality, the comparison returns " +
                "'true' if both delegates are 'null' or if both have the same number of members in their invocation list and the invocation lists match.\n\n" +
                "\t- When comparing numeric expressions, the types and values are compared. When comparing 'enum' types, the comparisons are done on the " +
                "underlying values of the operands.\n");
            ReadKey();

            Clear();
        }

        static void IncrementAndDecrementOperators()
        {
            Clear();

            WriteLine("\nIncrement and Decrement Operators\n" +
                "\t- The increment operators adds 1 to the operand. The decrement operators substract 1 from the operand.\n\n" +
                "\t- These operators are unary and have two forms. the 'pre-' form and the 'post-' form, which acts differently.\n" +
                "\t\t- In the pre- form, the operator is placed before the operand.\n" +
                "\t\t- In the post- form, the operator is placed after the operand.\n\n" +
                "\t- The Increment and Decrement Operators\n" +
                "\t\tOperator\tName\t\t\tDescription\n\n" +
                "\t\t++\t\tPre-increment ++var\tIncrement the value of the variable by 1 and save it back into the variable. Return the new value of the variable.\n" +
                "\t\t\t\tPost-increment ++var\tIncrement the value of the variable by 1 and save it back into the variable. Return the old value of the variable " +
                "before it was incremented.\n" +
                "\t\t--\t\tPre-decrement --var\tDecrement the value of the variable by 1 and save it back into the variable. Return the new value of the variable.\n" +
                "\t\t\t\tPost-decrement var--\tDecrement the value of the variable by 1 and save it back into the variable. Retunr the old value of the variable " +
                "before it was decremented.\n\n" +
                "\t- In comparing the pre- and post- forms of the operators,\n" +
                "\t\t- The final, stored value of the operand variable after the statement is executed is the same regardless of whether the pre- or post- form " +
                "of the operator is used.\n" +
                "\t\t- The only differnce is the value 'returned' by the operator to the expression.\n");
            ReadKey();

            Clear();
        }

        static void ConditionalLogicalOperators()
        {
            Clear();

            WriteLine("\nConditional Logical Operators\n" +
                "\t- The logical operators are used for comparing or negating the logical values of their operands and returning the resulting " +
                "logical value.\n" +
                "\t- The logical AND and logical OR operators are binary and left-associative. The logical NOT is unary.\n\n" +
                "\t- The Conditional Logical Operators\n\n" +
                "\t\tOperator\tName\t\t\tDescription\n\n" +
                "\t\t&&\t\tLogical AND\t\t'true' if both operands are 'true'; 'false' otherwise.\n" +
                "\t\t||\t\tLogical OR\t\t'true' if at least one operand is 'true'; 'false' otherwise.\n" +
                "\t\t!\t\tLogical NOT\t\t'true' if the operand is 'false'; 'false' otherwise.\n\n" +
                "\t- The conditional logical operators operate in 'short-circuit' mode, meaning that, if after evaluating Expression1 the result " +
                "can already be determined, then it skips the evaluation of Expression2.\n" +
                "\t- Because of the short-circuit behavior, do not place expressions with desired side effects such as changing a value.\n");
            ReadKey();

            Clear();
        }

        static void LogicalOperators()
        {
            Clear();

            WriteLine("\nLogical Operators\n" +
                "\t- The bitwise logical operators are often used to set the bit patterns for parameters to methods.\n" +
                "\t- These operators, except for the bitwise negation operator, are binary and left-associative. The bitwise negation is unary.\n\n" +
                "\t- The Logical Operators\n\n" +
                "\t\tOperator\tName\t\t\tDescription\n\n" +
                "\t\t&\t\tBitwise AND\t\tProduces the bitwise AND of the two operands. The resulting bit is 1 only if both operand bits are 1.\n" +
                "\t\t|\t\tBitwise OR\t\tProduces the bitwise OR of the two operands. The resulting bit is 1 either corresponding operand bit is 1.\n" +
                "\t\t^\t\tBitwise XOR\t\tProduces the bitwise XOR of the two operands. The resulting bit is 1 if one, but not both, of the corresponding " +
                "operand bits is 1.\n" +
                "\t\t~\t\tBitwise negation\tEach bit in the operand is switched to its opposite. This produces the one's complement of the operand. " +
                "(The 'one's complement' of a number is the inversion of every bit of its binary representation).\n\n" +
                "\t- The binary bitwise operators compare the corresponding bits at each position in each of their two operands, and they set the bit " +
                "in the return value according to the logical operation.\n");
            ReadKey();

            Clear();
        }

        static void ShiftOperators()
        {
            Clear();

            WriteLine("\nShift Operators\n" +
                "\t- The bitwise shift operators shift the bit pattern either right or left a specified number of positions, with the vacated bits " +
                "filled with 0s or 1s.\n" +
                "\t- The shift operators are binary and left-associative. The syntax of the bitwise shift operators is shown here. The number of positions " +
                "to shift is given by 'Count'.\n\n" +
                "\t\tOperand << Count\t\t<- Left Shift\n" +
                "\t\tOperand >> Count\t\t<- Right Shift\n\n" +
                "\t- The Shift Operators\n\n" +
                "\t\tOperator\tName\t\t\tDescription\n\n" +
                "\t\t<<\t\tLeft shift\t\tShifts the bit pattern left by the given number of positions. The bits shifted off the left end are lost. Bit positions " +
                "opening up on the right are filled with 0s.\n" +
                "\t\t>>\t\tRight shift\t\tShifts the bit pattern right by the given number of positions. Bits shifted off the right end are lost.\n\n" +
                "\t- For the vast majority of programming in C#, you don't need to know anything about the hardware underneath. If you're doing bitwise manipulation " +
                "of signed numbers, however, it can be helpful to know about the numeric representation.\n" +
                "\t- The underlying hardware represents signed binary numbers in a form called 'two's complement'. In two's-complement representation, positive " +
                "numbers have their normal binary form. To negate a number, you take the bitwise negation of the number and add 1 to it.\n" +
                "\t- This process turns a positive number into its negative representation, and vice versa. In two's complement, all negative numbers have a " +
                "1 in the leftmost bit position.\n\n" +
                "\t- The underlying representation is important when shifting signed numbers because the result of shifting an integral value one bit to the left " +
                "is the same as multiplying it by two. Shifting it to the right is the same as dividing it by two.\n" +
                "\t- If, however, you were to shift a negative number to the right and the leftmost bit were to be filled with a 0, it would produce the wrong " +
                "result. The 0 in the most leftmost position would indicate a positive number.\n" +
                "\t- But that is incorrect, because dividing a negative number by 2 doesn't produce a positive number.\n\n" +
                "\t- To address this situation, when the operand is a signed integer, if the leftmost bit of the operand is a 1 (indicating a negative number), " +
                "bit positions opening up on the left are filled with 1s rather than 0s.\n" +
                "\t- This maintains the correct two's-complement representations. For positive or unsigned numbers, bit positions opening up on the left are " +
                "filled with 0s.\n");
            ReadKey();

            Clear();
        }

        static void AssignmentOperators()
        {
            Clear();

            WriteLine("\nAssignment Operators\n" +
                "\t- The assignment operators evaluate the expression on the right side of the operator and use the value to set the value of the variable " +
                "expression on the left side of the operator.\n" +
                "\t- The assignment operators are binary and right-associative.\n\n" +
                "\t- The Assignment Operators\n\n" +
                "\t\tOperator\tDescription\n\n" +
                "\t\t=\t\tSimple assignment; evaluate the expression on the right, and assign the returned value to the variable or expression on the left.\n" +
                "\t\t*=\t\tCompound assignment; var = var * expr.\n" +
                "\t\t/=\t\tCompound assignment; var = var / expr.\n" +
                "\t\t%=\t\tCompound assignment; var = var % expr.\n" +
                "\t\t+=\t\tCompound assignment; var = var + expr.\n" +
                "\t\t-=\t\tCompound assignment; var = var - expr.\n" +
                "\t\t<<=\t\tCompound assignment; var = var << expr.\n" +
                "\t\t>>=\t\tCompound assignment; var = var >> expr.\n" +
                "\t\t&=\t\tCompound assignment; var = var & expr.\n" +
                "\t\t^=\t\tCompound assignment; var = var ^ expr.\n" +
                "\t\t|=\t\tCompound assignment; var = var | expr.\n\n" +
                "\t- The syntax is as follows:\n\n" +
                "\t\tVariableExpression Operator Expression\n\n" +
                "\t- Remember that an assignment expression is an 'expression' and therefore returns a value to its position in the statement. The value of an " +
                "assignment expression is the value of the left operand, after the assignment is performed.\n\n" +
                "\t- The types of objects that can be on the left side of an assignment operator are the following:\n" +
                "\t\t- Variables (local fields, fields, parameters)\n" +
                "\t\t- Properties\n" +
                "\t\t- Indexers\n" +
                "\t\t- Events\n");
            WriteLine("\nCompound Assignment\n" +
                "\t- Frequently, you want to evaluate an expression and add the resutls to the current value of a variable.\n" +
                "\t- The compound assignment operators allow a shorthand method for avoiding the repetition of the left-side variable on the right side under " +
                "certain common circumstances.\n" +
                "\t- Other compound assignment statements are analogous.\n");
            ReadKey();

            Clear();
        }

        static void TheConditionalOperator()
        {
            Clear();

            WriteLine("\nThe Conditional Operator\n" +
                "\t- The conditional operator is a powerful and succint way of returning one of two values, based on the result of a condition.\n" +
                "\t- It evaluates an expression and returns one two values, depending on whether the expression returns 'true' or 'false'.\n" +
                "\t- The conditional operator is ternary.\n\n" +
                "\t- The syntax for the conditional operator is shown next. It has a text expression and two resutl expressions.\n" +
                "\t\t- 'Condition' must return a value of type 'bool'.\n" +
                "\t\t- If 'Condition' evaluates to 'true', then 'Expression1' is evaluated and returned. Otherwise, 'Expression2' is evaluated " +
                "and returned.\n\n" +
                "\t\tCondition ? Expression1 : Expression2\n\n" +
                "\t- The conditional operator can be compared with the 'if...else' construct.\n\n" +
                "\t- The conditional operator can perform the same operation in a less verbose form.\n\n" +
                "\t- Placing the condition and each return expression on separate lines makes the intent very easy to understand.\n\n" +
                "\t- Note that 'if...else' statement is a flow-of-control statement. It should be used for doing one or the other of two actions. " +
                "The conditional operator returns an expression. It should be used for returning one or the other of two values.\n");
            ReadKey();

            Clear();
        }

        static void UnaryArithmeticOperators()
        {
            Clear();

            WriteLine("\nUnary Arithmetic Operators\n" +
                "\t- The unary operators set the sign of a numeric value.\n" +
                "\t\t- The unary positive operator simply returns the value of the operand.\n" +
                "\t\t- The unary negative operator returns the value of the operand subtracted from 0.\n");
            ReadKey();

            Clear();
        }

        static void UserDefinedTypeConversions()
        {
            Clear();

            WriteLine("\nUser-Defined Type Conversion\n" +
                "\t- You can define both implicit and explicit conversions for your own classes and structs. This allows you to convert an object " +
                "of your user-defined type to some other type, and vice versa.\n" +
                "\t- C# provides implicit and explicit conversions.\n" +
                "\t\t- With an 'implicit conversion', the compiler automatically makes the conversion, if necessary, when it is resolving what types " +
                "to use in a particular context.\n" +
                "\t\t- With an 'explicit conversion', the compiler will make the conversion only when an explicit cast operator is used.\n\n" +
                "\t- The syntax for declaring an implicit conversion is the following. The 'public' and 'static' modifiers are required for all " +
                "user-defined conversions.\n\n" +
                "\t\tpublic static implicit operator TargetType ( SourceType Identifier )\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t\treturn ObjectOfTargetType;\n" +
                "\t\t}\n\n" +
                "\t- The syntax of the explicit conversion is the same, except the 'explicit' is substituted for 'implicit'.\n\n" +
                "\t- There are two other operators that take a value of one type and return a value of a different, specified type. These are " +
                "the 'is' operator and the 'as' operator.\n");
            ReadKey();

            Clear();
        }

        static void OperatorOverloading()
        {
            Clear();

            WriteLine("\nOperator Overloading\n" +
                "\t- The C# operators are defined to work using the predefined types as operands. If confronted with a user-defined type, an " +
                "operator simply would not know to process it.\n" +
                "\t- Operator overloading allows you to define how the C# operators should operate on operands of your user-defined types.\n" +
                "\t\t- Operator overloading is available only for classes and structs.\n" +
                "\t\t- You can overload an operator 'x' for use with your class or struct by declaring a method named 'operator x' that implements " +
                "behavior.\n" +
                "\t\t\t- The overload methods for unary operators take a single parameter of the 'class' or 'struct' type.\n" +
                "\t\t\t- The overload methods for binary operators take two parameters, at least one of which must be of the 'class' or 'struct' type.\n\n" +
                "\t- The declaration of an operator overload method requires the following:\n" +
                "\t\t- The declaration must use both the 'static' and 'public' modifiers.\n" +
                "\t\t- The operator must be a member of the class or struct for which it is an operator.\n\n" +
                "\t- Note that your overloaded operators should conform to the intuitive meanings of the operators.\n");
            WriteLine("\nRestrictions on Operator Overloading\n" +
                "\t- Not all operators can be overloaded, and there are restrictions on the types of overloading that can be done.\n" +
                "\t- Only the following operators can be overloaded. Prominently missing from the list is the assignment operator.\n" +
                "\t\t\tOverloadable unary operators: +, -, !, ~, ++, --, true, false\n" +
                "\t\t\tOverloadable binary operators: +, -, *, /, %, &, |, ^, <<, >>, ==, !=, >, <, >=, <=\n\n" +
                "\t\t- You 'cannot' do the following things with operator overloading:\n" +
                "\t\t\t- Create a new operator.\n" +
                "\t\t\t- Change the syntax of an operator.\n" +
                "\t\t\t- Redefine how an operator works on the predefined types.\n" +
                "\t\t\t- Change the precedence or associativity of an operator.\n\n" +
                "\t- The increment and decrement operators are overloadable. \n" +
                "\t- For each of these operations, you write a piece of code that either increments or decrements the object: whatever that means for " +
                "your user-defined type.\n\n" +
                "\t\t- At runtime, when your code performs a 'pre-' operation (pre-increment or pre-decrement) on your object, the following happens:\n" +
                "\t\t\t- Your increment or decrement code is executed on the object.\n" +
                "\t\t\t- The object is returned.\n\n" +
                "\t\t- At runtime, when your code performs a 'post-' operation (post-increment or post-decrement) on you object, the following happens:\n" +
                "\t\t\t- If it a value typ, the system makes a copy of the object. If it is a reference type, a copy of the reference is made.\n" +
                "\t\t\t- Your increment or decrement code is executed on the object.\n" +
                "\t\t\t- The saved operand is returned.\n\n" +
                "\t- If your operand object is a value type object, this should all work fine. But you need to be a bit careful when your user-defined " +
                "type is a reference type.\n\n" +
                "\t- For a reference type object, the pre- operations should work fine because no copies are made. But for the post- operations, since " +
                "the copy that is saved is a copy of the reference, this means that both the original reference and the copy are pointing to the same object.\n" +
                "\t- This means that the saved reference points to an object is no longer in its original state. Returning this reference to the altered object " +
                "is probably not what was expected.\n");
            ReadKey();

            Clear();
        }

        static void ThetypeofOperator()
        {
            Clear();

            WriteLine("\nThe typeof Operator\n" +
                "\t- The 'typeof' operator returns the 'System.Type' object of any type given as its parameter. \n" +
                "\t- From this object, you can learn the characteristics of the type. (There is only one 'System.Type' object for any given type.) " +
                "You cannot overload the 'typeof' operator.\n" +
                "\t- The 'typeof' operator is unary.\n\n" +
                "\t- The 'typeof' operator is also called by the 'GetType' method, which is available for every object of every type.\n");
            ReadKey();

            Clear();
        }

        static void ThenameofOperator()
        {
            Clear();

            WriteLine("\nThe nameof Operator\n" +
                "\t- The 'nameof' operator returns a string representation of the item given as its parameter.\n" +
                "\t- The 'nameof' operator returns only the unqualified name of its argument, even if the argument uses a fully qualified name. Also, " +
                "the 'nameof' operator works with static classes and static methods.\n\n" +
                "\t- It might not be clear as to why would you use the 'nameof' operator when the simple string would suffice.\n" +
                "The reason, however, relates to changes in your code. If you use a hard-coded string to refer to the name of any element in a statement, " +
                "that hard-coded string will not change if you later change the name of you property.\n");
            ReadKey();

            Clear();
        }

        static void OtherOperators()
        {
            Clear();

            WriteLine("\nOther Operators\n" +
                "\t- There are other special-usage operators, the nullable types have a special operators called the 'null-coalescing operator' and the " +
                "'null-conditional operator'.\n");
            ReadKey();

            Clear();
        }
    }

    static class Ten
    {
        public static void Statements()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tStatements\n" +
                "\n\t1. What are Statements?\n\t2. Expression Statements\n\t3. Flow-of-Control Statements\n\t4. The if Statement\n\t5. The if...else statement" +
                "\n\t6. The while Loop\n\t7. The do Loop\n\t8. The for Loop" +
                "\n\t9. The switch Statement\n\t10. Jump Statements\n\t11. The break Statement\n\t12. The continue Statement" +
                "\n\t13. Labeled Statement\n\t14. The goto Statement\n\t15. The using Statement\n\t16. Other Statements\n\t17. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                TenDecision(ref choice);

            } while (choice != 17);

            Clear();
        }

        static void TenDecision(ref int choice)
        {
            switch (choice)
            {
                case 1:
                    WhatAreStatements();
                    break;
                case 2:
                    ExpressionStatements();
                    break;
                case 3:
                    FlowOfControlStatements();
                    break;
                case 4:
                    TheIfStatement();
                    break;
                case 5:
                    TheIfElseStatement();
                    break;
                case 6:
                    TheWhileLoop();
                    break;
                case 7:
                    TheDoLoop();
                    break;
                case 8:
                    TheForLoop();
                    break;
                case 9:
                    TheSwitchStatement();
                    break;
                case 10:
                    JumpStatement();
                    break;
                case 11:
                    TheBreakStatement();
                    break;
                case 12:
                    TheContinueStatement();
                    break;
                case 13:
                    LabeledStatement();
                    break;
                case 14:
                    TheGotoStatement();
                    break;
                case 15:
                    TheUsingStatement();
                    break;
                case 16:
                    OtherStatement();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void WhatAreStatements()
        {
            Clear();

            WriteLine("\nWhat Are Statements?\n" +
                "\t- The statements in C# are similar to those of C and C++.\n" +
                "\t\t- A 'statement' is a source code instruction describing a type or telling the program to perform an action.\n" +
                "\t\t- There are three major categories of statements.\n" +
                "\t\t\t- 'Declaration statement' : Statements that declare types or variables.\n" +
                "\t\t\t- 'Embedded statement'    : 'Statements that performs actions or manage flow of control'.\n" +
                "\t\t\t- 'Labeled statement'     : Statement to which control can jump.\n\n" +
                "\t- A 'simple statement' consists of an expression followed by a semicolon.\n" +
                "\t- A 'block' is a sequence of statements enclosed by matching curly braces. The enclosed statements can include the following:\n" +
                "\t\t- Declaration statements\n" +
                "\t\t- Embedded statements\n" +
                "\t\t- Labeled statements\n" +
                "\t\t- Nested blocks\n\n" +
                "\t- Note that a block counts syntactically as a single embedded statement. Anywhere that an embedded statement is required syntactically, " +
                "you can use a block.\n\n" +
                "\t- An 'empty statement' consists of just a semicolon.\n" +
                "\t- You can use an empty statement at any position where the syntax of the language requires an embedded statement but your program logic " +
                "does not require any action.\n");
            ReadKey();

            Clear();
        }

        static void ExpressionStatements()
        {
            Clear();

            WriteLine("\nExpression Statements\n" +
                "\t- Expression return values, but they can also have 'side effects'.\n" +
                "\t\t- A side effect is an action that affects the state of the program.\n" +
                "\t\t- Many expressions are evaluated only for their side effects.\n\n" +
                "\t- You can create a statement from an expression by placing a statement terminator (a semicolon) afte the expression. \n" +
                "\t- Any value returned by the expression is discarded.\n\n" +
                "\t- The whole reason for evaluating the expression is to achieve the side effect.\n");
            ReadKey();

            Clear();
        }

        static void FlowOfControlStatements()
        {
            Clear();

            WriteLine("\nFlow-of-Control Statements\n" +
                "\t- C# provides the flow-of-control constructs common to modern programming languages.\n\n" +
                "\t\t- 'Conditional execution' executes or skips a section of code depending on a condition.\n" +
                "\t\t- The conditional execution statements are the following:\n" +
                "\t\t\t- if\n" +
                "\t\t\t- if...else\n" +
                "\t\t\t- switch\n\n" +
                "\t\t- 'Looping statements' repeatedly execute a section of code. \n" +
                "\t\t- The looping statements are the following:\n" +
                "\t\t\t- while\n" +
                "\t\t\t- do\n" +
                "\t\t\t- for\n" +
                "\t\t\t- foreach\n\n" +
                "\t\t- 'Jump statements' change the flow of control from one section of code to a specific statement in another section of code.\n" +
                "\t\t- The jump statements are the following:\n" +
                "\t\t\t- break\n" +
                "\t\t\t- continue\n" +
                "\t\t\t- return\n" +
                "\t\t\t- goto\n" +
                "\t\t\t- throw\n\n" +
                "\t- Conditional execution and looping constructs (other than foreach) require a test expression, or 'condition', to determine where " +
                "the program should continue execution.\n\n" +
                "\t- Note that unlike C and C++, in C# test expressions must return a value of type 'bool'. Numbers do not have a Boolean representation in C#.\n");
            ReadKey();

            Clear();
        }

        static void TheIfStatement()
        {
            Clear();

            WriteLine("\nThe if Statement\n" +
                "\t- The 'if' statement implements conditional execution.\n" +
                "\t- The syntax for the 'if' statement is the following:\n\n" +
                "\t\t\tif( TestExpression )\n" +
                "\t\t\t\tStatement\n\n" +
                "\t\t- 'TestExpression' must evaluate to a value of type 'bool'.\n" +
                "\t\t- If 'TestExpression' evaluates to 'true', 'Statement' is executed.\n" +
                "\t\t- If it evaluates to 'false', 'Statement' is skipped.\n");
            ReadKey();

            Clear();
        }

        static void TheIfElseStatement()
        {
            Clear();

            WriteLine("\nThe if...else Statement\n" +
                "\t- The 'if...else' statement implements a two-way branch.\n" +
                "\t- The syntax for the 'if...else' is the following:\n\n" +
                "\t\t\tif( TestExpression )\n" +
                "\t\t\t\tStatement1\n" +
                "\t\t\telse\n" +
                "\t\t\t\tStatement2\n\n" +
                "\t\t- If 'TestExpression' evaluates to true, 'Statement1' is executed.\n" +
                "\t\t- Otherwise, 'Statement2' is executed instead.\n\n" +
                "\t- Of course, 'Statement1', 'Statement2', or both could themselves be 'if' or 'if...else' statements, which could be nested further.\n" +
                "\t- If you're looking at code containing nested 'if...else' statements and need to determine which 'else' goes with which 'if', there is a simple " +
                "rule. Every 'else' belongs to the 'closest previous if' that doesn't have an associated 'else clause'.\n\n" +
                "\t- When 'Statement2' is an 'if' or 'if...else' statement, it's common to format the construct as in the following code, putting the second 'if' clause " +
                "on the same line as the 'else' clause. This examples shows two 'if...else' statements, but you can make an arbitrarily long chain.\n\n" +
                "\t\t\tif( TestExpression1 )\n" +
                "\t\t\t\tStatement1\n" +
                "\t\t\telse if ( TestExpression2 )\n" +
                "\t\t\t\tStatement2\n" +
                "\t\t\telse\n" +
                "\t\t\t\tStatement3\n");
            ReadKey();

            Clear();
        }

        static void TheWhileLoop()
        {
            Clear();

            WriteLine("\nThe while Loop\n" +
                "\t- The 'while' loop is a simple loop construct in which the test expression is performed at the top of the loop.\n" +
                "\t- The syntax of the 'while' loop is the following:\n\n" +
                "\t\t\twhile( TestExpression )\n" +
                "\t\t\t\tStatement\n\n" +
                "\t\t- First, 'TestExpression' is evaluated.\n" +
                "\t\t- If 'TestExpression' evaluates to 'false', then execution continues after the end of the 'while' loop.\n" +
                "\t\t- Otherwise, when 'TestExpression' evaluates to 'true', then 'Statement' is executed, and 'TestExpression' is evaluated again. Each time 'TestExpression' " +
                "evaluates to 'true', 'Statement' is executed another time. The loop ends when 'TestExpression' evaluates to 'false'.\n");
            ReadKey();

            Clear();
        }

        static void TheDoLoop()
        {
            Clear();

            WriteLine("\nThe do Loop\n" +
                "\t- The 'do' loop is a simple loop construct in which the test expression is performed at the bottom of the loop.\n" +
                "\t- The syntax for the 'do' loop is the following:\n\n" +
                "\t\t\tdo\n" +
                "\t\t\t\tStatement\n" +
                "\t\t\twhile( TestExpression );\n\n" +
                "\t\t- First, 'Statement' is executed.\n" +
                "\t\t- Then, 'TestExpression' is evaluated.\n" +
                "\t\t- If 'TestExpression' returns 'true', then 'Statement' is executed again.\n" +
                "\t\t- Each time 'TestExpression' returns 'true', 'Statement' is executed again.\n" +
                "\t\t- When 'TestExpression' returns 'false', control passes to the statement following the end of the loop construct.\n\n" +
                "\t- The 'do' loop has several characteristics that set it apart from other flow-of-control constructs. They are the following:\n" +
                "\t\t- The body of the loop, 'Statement', is always executed at least once, even if 'TestExpression' is initially 'false'. The reason for this is the " +
                "'TestExpression' isn't evaluated until the bottom of the loop.\n" +
                "\t\t- The semicolon is required after the closing parentheses of the test expression.\n");
            ReadKey();

            Clear();
        }

        static void TheForLoop()
        {
            Clear();

            WriteLine("\nThe for Loop\n" +
                "\t- The 'for' loop construct executes the body of the loop as long as the test expression returns 'true' when it is evaluated at the top of the loop.\n" +
                "\t- The syntax of the 'for' loop is the following:\n\n" +
                "\t\t\tfor( Intializer ; TestExpression ; IterationExpression )\n" +
                "\t\t\t\tStatement\n\n" +
                "\t\t- At the beginning of the 'for' loop, 'Initializer' is executed once.\n" +
                "\t\t- 'TextExpression' is then evaluated.\n" +
                "\t\t- If 'TestExpression' returns 'true', 'Statement' is executed, followed by 'IterationExpression'.\n" +
                "\t\t- Control then returns to the top of the loop, and 'TestExpression' is evaluated again.\n" +
                "\t\t- As long as 'TestExpression' returns 'true', 'Statement', followed by the 'IterationExpression', is executed.\n\n" +
                "\t- As soon as 'TestExpression' returns 'false', execution continues at the statement following 'Statement'.\n\n" +
                "\t- Some parts of the statement are optional, and others are required.\n" +
                "\t\t- 'Initializer', 'TestExpression', and 'IterationExpression' are all optional. Their positions can be left blank. If the 'TestExpression' is left blank, " +
                "the test is 'assumed to return true'. \n" +
                "\t- Therefore, there must be some other means of exiting the statement if the program is to avoid going into an infinite loop.\n" +
                "\t\t- The two semicolons are always required as field separators, even if any of the optional items are ommitted.\n\n" +
                "\t- Some important things to know about 'for' loop are the following:\n" +
                "\t\t- 'Initializer' is executed only once, before any other part of the 'for' construct. It is usually used to declare and initialize local values to be used " +
                "in the loop.\n" +
                "\t\t- 'TestExpresion' is evaluated to determine whether 'Statement' should be executed or skipped. It must evaluate to a value of type 'bool'. As stated " +
                "previously, if 'TestExpression' is left blank, it is assumed to always be true.\n" +
                "\t\t- 'IterationExpression' is executed immediatedly after the 'Statement' and before returning to the top of the loop to 'TestExpression'.\n");
            WriteLine("\nThe Scope of Variables in a for Statement\n" +
                "\t- Variables declared in the 'initializer', called 'loop variables', are visible 'only within the for statement'.\n" +
                "\t\t- This is different form C and C++, where the declaration introduces the variable into the closing block.\n" +
                "\t\t- The local variables declared within the body of the loop are known only within the loop.\n");
            WriteLine("\nMultiple Expressions in the Initializer and Iteration Expression\n" +
                "\t- Bothe the initializer expression and the iteration expression can contain multiple expressions as long as they are separated by commas.\n");
            ReadKey();

            Clear();
        }

        static void TheSwitchStatement()
        {
            Clear();

            WriteLine("\nThe switch Statement\n" +
                "\t- The 'switch' statement implements multiway branching. \n" +
                "\t- The structure and syntax of the 'switch' statement are the following:\n\n" +
                "\t\t\tswitch( TestExpression )\n" +
                "\t\t\t{\n" +
                "\t\t\t\tcase Expression1:\n" +
                "\t\t\t\t\tStatementList\n" +
                "\t\t\t\t\t\tbreak;\n" +
                "\t\t\t\t\t...\n" +
                "\t\t\t\tcase ExpressionN:\n" +
                "\t\t\t\t\tStatementList\n" +
                "\t\t\t\t\t\tbreak;\n" +
                "\t\t\t\tdefault:\n" +
                "\t\t\t\t\tStatementList\n" +
                "\t\t\t\t\t\tbreak;\n" +
                "\t\t\t}\n\n" +
                "\t\t- The 'switch' statement has a single parameter generally referred to as the 'test' or 'matching expression'. Previously, these test expressions " +
                "had to be one of the following data types: 'char', 'string', 'bool', 'integer', or 'enum'. C# 7.0 now allows the test expression to be of any type.\n" +
                "\t\t- The 'switch' statement contains zero or more 'switch sections'.\n" +
                "\t\t- Each switch section starts with one or more 'switch labels'. Each switch label is followed by a pattern expression that will be compared to the " +
                "test expression. If both the test and pattern expressions are integral types, the comparison is peformed using the C# equality operator (==).\n" +
                "\t\t- In all other cases, the comparison is executed using the static method 'Object.Equals(test, pattern)'. In other words, for nonintegral types, " +
                "C# uses a deep comparison.\n" +
                "\t\t- Each switch section must adhere to the 'no fall through rule'.\n" +
                "\t\t- This means that the flow of control of the statement list in the switch section cannot reach the end and meet the next section. This rule is " +
                "usually implemented by ending the statement list with a 'break' statement or one of the other four jump statements.\n" +
                "\t\t- Note, however, that the 'goto' jump statement cannot be used with nonconstant 'switch' expressions.\n" +
                "\t\t\t- The jump statements are 'break', 'return', 'continue', 'goto', and 'throw'.\n" +
                "\t\t\t- Of the five jump statements, the 'break' statement is the most commonly used for ending a switch section. The 'break' statement branches execution " +
                "to the end of the 'switch' statement.\n" +
                "\t\t- Switch sections are evaluated in order. If one matches the value of the test expression, its switch section is executed, and then control jumps to " +
                "the location specified by the jump statement used in that switch section.\n" +
                "\t\t- Since the 'break' statement is most commonly used jump statement, usually control jumps to the first line of executable code following the end " +
                "of the 'switch' statement.\n\n" +
                "\t- Switch labels have the following form:\n\n" +
                "\t\tcase PatternExpression:\n");
            WriteLine("\nOther Types of Pattern Expressions\n" +
                "\t- A case label consists of the keyword case followed by a pattern.\n" +
                "\t- Patterns can be a simple value, an expression that evaluates to a simple value, or type.\n" +
                "\t- A pattern can include a filter introduced by the keyword 'when'.\n" +
                "\t- Note also that there is no requirement that all case expressions must be either constant values or types. These can be intermingled as desired.\n");
            WriteLine("\nMore on the switch Statement\n" +
                "\t- A 'switch' statement can have any number of switch sections, including none.\n" +
                "\t- The 'default' section is not required. It is, however, generally considered good practice to include it, since it can catch potential errors.\n");
            WriteLine("\nSwitch Labels\n" +
                "\t- The expression following the keyword 'case' in a switch label can be a pattern of any type.\n" +
                "\t- Before C# 7.0, it had to be a constant expression and therefore had to be completely evaluable by the compiler at 'compile time'. This constraints " +
                "no longer applies.\n\n" +
                "\t- Note that unlike C and C++, in C# each 'switch' section, including the optional default section, must end with one of the jump statements. In C#, " +
                "you cannot execute the code in one switch section and then 'fall through' to the next.\n\n" +
                "\t- Although C# does not allow falling through from one switch section to another, you can attach multiple switch labels to any switch section as long " +
                "as there are 'no intervening executable statements' between the switch labels.\n\n" +
                "\t- Although the most common way to end a switch section is to use one of the five jump statements, the compiler is smart enough to determine that a " +
                "particular construct will allow the statement list to meet the 'no fall through rule'.\n");
            ReadKey();

            Clear();
        }

        static void JumpStatement()
        {
            Clear();

            WriteLine("\n\n" +
                "\t- When the flow of control reaches jump statements. program execution is unconditionally transferred to another part of the program.\n" +
                "\t- The jump statements are the following:\n" +
                "\t\t- break\n" +
                "\t\t- continue\n" +
                "\t\t- return\n" +
                "\t\t- goto\n" +
                "\t\t- throw\n");
            ReadKey();

            Clear();
        }

        static void TheBreakStatement()
        {
            Clear();

            WriteLine("\nThe break Statement\n" +
                "\t- 'break' is usually used in the 'switch' statement. It can also be used in the following types:\n" +
                "\t\t- for\n" +
                "\t\t- foreach\n" +
                "\t\t- while\n" +
                "\t\t- do\n\n" +
                "\t- In the body of one of these statements, 'break' causes execution to exit the 'innermost enlosing loop'.\n");
            ReadKey();

            Clear();
        }

        static void TheContinueStatement()
        {
            Clear();

            WriteLine("\nThe continue Statements\n" +
                "\t- The 'continue' statement causes program execution to go to the 'top' of the 'innermost enclosing loop' of the following types:\n" +
                "\t\t- while\n" +
                "\t\t- do\n" +
                "\t\t- for\n" +
                "\t\t- foreach\n");
            ReadKey();

            Clear();
        }

        static void LabeledStatement()
        {
            Clear();

            WriteLine("\nLabeled Statement\n" +
                "\t- A 'labeled statement' consists of an identifier, followed by a colon, followed by a statement.\n" +
                "\t- It has the following form:\n\n" +
                "\t\tIdentifier: Statement\n\n" +
                "\t- A labeled statement is executed exactly as if the label were not there and consisted of just the 'Statement' part.\n" +
                "\t\t- Adding a label to a statement allow control to be transferred to the statement from  another part of the code.\n" +
                "\t\t- Labeled statements are allowed only inside blocks.\n");
            WriteLine("\nLabels\n" +
                "\t- Labels have their own declaration space, so the identifier in a labeled statement can be any valid identifier - including those " +
                "that might be declared in an overlapping scope, such as local variables or parameter names.\n\n" +
                "\t- There are restrictions, however, the identifier cannot be either\n" +
                "\t\t- A keyword\n" +
                "\t\t- The same as another label identifier with an overlapping scope\n");
            WriteLine("\nThe Scope of Labeled Statements\n" +
                "\t- Labeled statements cannot be seen or accessed from 'outside' the block in which they are declared.\n" +
                "\t- The scope of a labeled statement is the following:\n" +
                "\t\t- The block in which it is declared.\n" +
                "\t\t- Any blocks nested inside that block.\n");
            ReadKey();

            Clear();
        }

        static void TheGotoStatement()
        {
            Clear();

            WriteLine("\nThe goto Statement\n" +
                "\t- The 'goto' statement unconditionally transfer control to a 'labeled statement'. Its general form is the following, where " +
                "'Identifier' is the identifer of a labeled statement:\n\n" +
                "\t\tgoto Identifier;\n\n" +
                "\t- The 'goto' statement must be 'within' the scope of the labeled statement.\n" +
                "\t\t- A 'goto' statement can jump to any labeled statement within its own block or jump 'out' to any block in which it is nested.\n" +
                "\t\t- A 'goto' statement cannot jump 'into' any blocks nested within its own block.\n\n" +
                "\t- Using the 'goto' statement is strongly discouraged because it can lead to code that is poorly structured and difficult to debug and " +
                "maintain.\n");
            WriteLine("\nThe goto Statement Inside a switch Statement\n" +
                "\t- There are also two forms of the 'goto' statement, for use inside 'switcht' statement. These 'goto' statements transfer control to the " +
                "correspondingly named switch label in the switch statement.\n" +
                "\t- However, it is only possible to use 'goto' labels that reference compile-time constants (as were used in pre-C# 7.0 switch statements).\n");
            ReadKey();

            Clear();
        }

        static void TheUsingStatement()
        {
            Clear();

            WriteLine("\nThe using Statement\n" +
                "\t- Certain types of unmanaged objects are limited in number or are expensive with system resources. It's important that when your code is done " +
                "with them, they be released as soon as possible.\n" +
                "\t- The 'using' statement helps simplify the process and ensures that these resources are properly disposed of.\n\n" +
                "\t- A 'resource' is a class or struct that implements the 'System.IDisposable' interface. An interface is a collection of unimplemented function " +
                "members that classes and structs can choose to implement. The 'IDisposable' interface contains a single method, named 'Dispose'.\n\n" +
                "\t- The phase of using a resource consist of the following:\n" +
                "\t\t- Allocating the resource\n" +
                "\t\t- Using the resource\n" +
                "\t\t- Disposing of the resource\n\n" +
                "\t- If an unexpected runtime error occurs during the portion of the code using the resource, the code disposing of the resource might not get " +
                "executed.\n\n" +
                "\t- Note that the 'using' statement is different from 'using' directives.\n");
            WriteLine("\nPackaging the Use of a Resource\n" +
                "\t- The 'using' statement helps reduce the potential proble, of an unexpected runtime error by neatly packaging the use of a resource.\n" +
                "\t- There are two forms of the 'using' statement. The first form is the following:\n\n" +
                "\t\tusing ( ResourceType Identifier = Expression ) Statement\n\n" +
                "\t- The code between the parentheses allocates the resource.\n" +
                "\t- 'Statement' is the code that uses the resource.\n" +
                "\t- The 'using' statement 'implicitly generates' the code to dispose of the resource.\n\n" +
                "\t- Unexpected runtime errors are called 'exceptions'. The standard way of handling the possibility of exceptions is to place the code that might cause " +
                "an exception in a 'try' block and place any code that 'must' be executed, whether or not there is an exception, into a 'finally' block.\n" +
                "\t- This form of the 'using' statement dose exactly that. It performs the following:\n" +
                "\t\t- Allocating the resource\n" +
                "\t\t- Placing 'Statement' in a 'try' block\n" +
                "\t\t- Creating a call to the resource's 'Dispose' method and placing it in a finally block.\n");
            WriteLine("\nMultiple Resources and Nesting\n" +
                "\t- The 'using' statement can also be used with multiple resources of the same type, with the resource declarations separated by commas.\n" +
                "\t- The syntax is the following:\n\n" +
                "\t\tusing ( ResourceType Identifier1 = Expression1, Identifier2 = Expression2, ... ) Embedded Statement\n\n" +
                "\t- The 'using' statement can also be nested. \n" +
                "\t- Beside the nesting of the 'using' statements, also note that it is not necessary to use a block with the second 'using' because it consists " +
                "only a single, simple statement.\n");
            WriteLine("\nAnother Form of the using Statement\n" +
                "\t- Another form of the 'using' statement is the following:\n\n" +
                "\t\tusing ( Expression ) EmbeddedStatement\n\n" +
                "\t- In this form, the resource is declared before using the statement.\n\n" +
                "\t- Although this form ensures that the 'Dispose' method will always be called after you finish using the resource, it does not protect you from " +
                "attempting to use the resource after the 'using' statement has released its unmanaged resources, leaving it in an inconsistent state. \n" +
                "\t- It therefore gives less protection and is discouraged.\n");
            ReadKey();

            Clear();
        }

        static void OtherStatement()
        {
            Clear();

            WriteLine("\nOther Statement\n" +
                "\t- There are other statements that are associated with particular features of the language.\n\n" +
                "\t\tStatement\t\t\tDescription\n\n" +
                "\t\tchecked, unchecked\t\tThese statements control the overflow checking context.\n" +
                "\t\tforeach\t\t\t\tThis statement iterates through each member of a collection.\n" +
                "\t\ttry, throw, finally, return\tThese statements are associated with exceptions.\n" +
                "\t\tyield\t\t\t\tThis statement is used with iterators.\n");
            ReadKey();

            Clear();
        }
    }

    static class Eleven
    {
        public static void Structs()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tStructs\n" +
                "\n\t1. What are Structs?\n\t2. Structs are Value Types\n\t3. Assigning to a Struct\n\t4. Constructors and Destructors\n\t5. Property and Field Initializer" +
                "\n\t6. Structs are Sealed\n\t7. Boxing and Unboxing\n\t8. Structs as Return Values and Parameters" +
                "\n\t9. Additional Information About Structs\n\t10. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                ElevenDecision(ref choice);

            } while (choice != 10);


            Clear();
        }

        static void ElevenDecision(ref int choice)
        {
            switch(choice)
            {
                case 1:
                    WhatAreStructs();
                    break;
                case 2:
                    StructsAreValueTypes();
                    break;
                case 3:
                    AssigningToAStruct();
                    break;
                case 4:
                    ConstructorsAndDestructors();
                    break;
                case 5:
                    PropertyAndFieldInitializer();
                    break;
                case 6:
                    StructsAreSealed();
                    break;
                case 7:
                    BoxingAndUnboxing();
                    break;
                case 8:
                    StructsAsReturnValuesAndParameters();
                    break;
                case 9:
                    AdditionalInformationAboutStructs();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void WhatAreStructs()
        {
            Clear();

            WriteLine("\nWhat Are Structs?\n" +
                "\t- Structs are programmer-defined data types, similar to classes.\n" +
                "\t- They have data members and function members. Although structs are similar to classes, there are a number of important differences.\n" +
                "\t- The most important ones are the following:\n" +
                "\t\t- Classes are reference types, and structs are value types.\n" +
                "\t\t- Structs are implicitly sealed, which means they cannot be derived from.\n\n" +
                "\t- The syntax for declaring a struct is similar to that of declaring a classs.\n\n" +
                "\t\tstruct StructName\n" +
                "\t\t{\n" +
                "\t\t\tMemberDeclarations\n" +
                "\t\t}\n" +
                "\n");
            ReadKey();

            Clear();
        }

        static void StructsAreValueTypes()
        {
            Clear();

            WriteLine("\nStructs Are Value Types\n" +
                "\t- As with all value types, a variable of a struct type contains its own data. Consequently,\n" +
                "\t\t- A variable of a struct type cannot be 'null'.\n" +
                "\t\t- Two structs variables cannot refer to the same object.");
            ReadKey();

            Clear();
        }

        static void AssigningToAStruct()
        {
            Clear();

            WriteLine("\nAssigning to a Struct\n" +
                "\t- Assigning one struct to another copies the values from one to the other.\n" +
                "\t- This is quite different from copying from a class variable, where only the reference is copied.\n");
            ReadKey();

            Clear();
        }

        static void ConstructorsAndDestructors()
        {
            Clear();

            WriteLine("\nConstructors and Destructors\n" +
                "\t- Structs can have instance and static constructors, but destructors are not allowed.\n");
            WriteLine("\nInstance Constructors\n" +
                "\t- The language implicitly supplies a parameterless constructor for every struct. \n" +
                "\t- This constructor sets each of the struct's members to the default value for that type.\n" +
                "\t- Value members are set ot their default values. Reference members are set ot 'null'.\n\n" +
                "\t- The predefined parameterless constructor exist for every struct - and you cannot delete or redefine it.\n" +
                "\t- You can, however, create additional constructors, as long as they have parameters.\n" +
                "\t- Notice that this is different from classes. 'For classes', the compiler supplies an implicit parameterless constructor 'only if no other " +
                "constructors are declared'.\n\n" +
                "\t- To invoke a constructor, including the implicit parameterless constructor, use the 'new' operator. \n" +
                "\t- Notice that the 'new' operator is used even though the memory is not allocated from the heap.\n\n" +
                "\t- You can also create an instance of a struct without using the 'new' operator. If you do this, however, there are several restrictions, which " +
                "are the following:\n" +
                "\t\t- You cannot use the value of a data member until you have explicitly set it.\n" +
                "\t\t- You cannot call 'any' function member of the struct until 'all' the data members have been assigned.\n");
            WriteLine("\nStatic Constructors\n" +
                "\t- As with classes, the static construtors of structs create and initialize the static data members and cannot reference instance members.\n" +
                "\t- Static constructors for structs follows the same rules as those for classes, except that parameterless static constructors are permitted.\n" +
                "\t- A static constructor is called before the first of either of the following two actions:\n" +
                "\t\t- A call to an explicitly declared constructor.\n" +
                "\t\t- A reference to a static member of a struct.\n");
            WriteLine("\nSummary of Constructors and Destructors\n\n" +
                "\tType\t\t\t\t\tDescription\n\n" +
                "\tInstance constructor (parameterless)\tCannot be declared in the program. An implicit constructor is always supplied by the system for all structs. " +
                "It cannot be deleted or refefined by the program.\n" +
                "\tInstance construtor (with parameters)\tCan be declared in the program.\n" +
                "\tStatic constructor\t\t\tCan be declared in the program.\n" +
                "\tDestructor\t\t\t\tCannot be declared in the program. Destructors are not allowed.\n");
            ReadKey();

            Clear();
        }

        static void PropertyAndFieldInitializer()
        {
            Clear();

            WriteLine("\nProperty and Field Initializers\n" +
                "\t- Instance property and field initializers are not allowed in struct declarations.\n" +
                "\t- However, both static properties and static fields of a struct can be initialized in their declaration, even though structs themselves cannot be " +
                "static.\n");
            ReadKey();

            Clear();
        }

        static void StructsAreSealed()
        {
            Clear();

            WriteLine("\nStructs Are Sealed\n" +
                "\t- Structs are always implicitly sealed, and hence you cannot derive other structs from them.\n\n" +
                "\t- Since structs do not support inheritance, the use of several of the class member modifiers with struct members would not make sense; thus, " +
                "you cannot use them in their declarations.\n" +
                "\t- The modifiers that cannot be used with structs are the following:\n" +
                "\t\t- protected\n" +
                "\t\t- protected internal\n" +
                "\t\t- abstract\n" +
                "\t\t- sealed\n" +
                "\t\t- virtual\n\n" +
                "\t- Structs themselves are, under the covers, derived from 'System.ValueType', which is derived from 'object'.\n\n" +
                "\t- There are two-inheritance-associated keywords that you 'can' use with struct members: the 'new' and 'override' modifiers. \n" +
                "\t- These keywords are appropriate when creating a member with the same name as a member of the base class 'System.ValueType', from which " +
                "all structs are derived.\n");
            ReadKey();

            Clear();
        }

        static void BoxingAndUnboxing()
        {
            Clear();

            WriteLine("\nBoxing and Unboxing\n" +
                "\t- As with other value type data., if you want to use a struct instance as a reference type object, you must make a boxed copy.\n" +
                "\t- Boxing is the process of making a reference type copy of a value type variable.\n");
            ReadKey();

            Clear();
        }

        static void StructsAsReturnValuesAndParameters()
        {
            Clear();

            WriteLine("\nStructs As Return Values and Parameters\n" +
                "\t- Structs can be used as return values and parameters.\n" +
                "\t\t- 'Return value'           : When a struct is a return value, a copy is created and returned from the function member.\n" +
                "\t\t- 'Value parameter'        : When a struct is used as a value parameter, a copy of the actual parameter struct is created. The copy " +
                "is used in the execution of the method.\n" +
                "\t\t- 'ref and out parameters' : If you use a struct as a 'ref' or 'out' parameter, a reference to the struct is passed into the method " +
                "so that the data members can be changed.\n");
            ReadKey();

            Clear();
        }

        static void AdditionalInformationAboutStructs()
        {
            Clear();

            WriteLine("\nAdditional Information About Structs\n" +
                "\t- Allocating structs requires less overhead than creating instances of a classs, so using structs instead of classes can sometimes improve " +
                "performance - but beware of the high cost of boxing and unboxing.\n\n" +
                "\t- Finally, some last things you should know about structs are the following:\n" +
                "\t\t- The predefined simple types, although considered primitives in .NET and C#, are all actually implemented under the covers in .NET as structs.\n" +
                "\t\t- You can declare 'partial' structs in the same way as 'partial classes'.\n\n" +
                "\t- Structs, like classes, can implement interfaces.");
            ReadKey();

            Clear();
        }
    }

    static class Twelve
    {
        public static void Enumerations()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tEnumerations\n" +
                "\n\t1. Enumerations\n\t2. Bit Flags\n\t3. More About Enums\n\t4. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                TwelveDecision(ref choice);

            } while (choice != 4);


            Clear();
        }

        static void TwelveDecision(ref int choice)
        {
            switch(choice)
            {
                case 1:
                    Enumeration();
                    break;
                case 2:
                    BitFlags();
                    break;
                case 3:
                    MoreAboutEnums();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void Enumeration()
        {
            Clear();

            WriteLine("\nEnumerations\n" +
                "\t- An 'enumearation', or enum, is a programmer-defined type, such as class or a struct.\n" +
                "\t\t- Like structs, enums are value types and therefore store their data directly, rather than separately, with a reference and data.\n" +
                "\t\t- Enums have only one type of member: named constants with integer values.\n" +
                "\t- Note that the list of member declarations is a comma-separated list; there are no semicolons in an enum declaration.\n\n" +
                "\t\tenum EnumName\n" +
                "\t\t{\n" +
                "\t\t\tMember1,\n" +
                "\t\t\tMember2,\n" +
                "\t\t\tMember3,\n" +
                "\t\t\t...\n" +
                "\t\t\tMemberN\n" +
                "\t\t}\n\n" +
                "\t- Every enum type has an underlying integer type, which by default is 'int'.\n" +
                "\t\t- Each enum member is assigned a constant value of underlying type.\n" +
                "\t\t- By default, the compiler assigns 0 to the first member and assigns each subsequent member of the value one more than the previous member.\n\n" +
                "\t- You can assign enum values to variables of the enum type.\n" +
                "\t- You can assign member literals to variables, or you can copy the value from another variable of the same type.\n");
            WriteLine("\nSetting the Underlying Type and Explicit Values\n" +
                "\t- You can use an integer type other than 'int' by placing a colon and the type name after the enum name. The type can be any integer type.\n" +
                "\t- All the member constants are of the enum's underlying type.\n\n" +
                "\t\tenum EnumName : IntegerType\n" +
                "\t\t{\n" +
                "\t\t\tMember1 = SetValue,\n" +
                "\t\t\tMember2 = SetValue,\n" +
                "\t\t\tMember3 = SetValue,\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t- The values of the member constants can be any values of the underlying type. \n" +
                "\t- To explicitly set the value of a member, use an initializer after its name in the enum declaration.\n" +
                "\t- There can duplicate values, although not duplicate names.\n");
            WriteLine("\nImplicit Member Numbering\n" +
                "\t- You can explicitly assign the values for any of the member constants. \n" +
                "\t- If you don't initialize a member constant, the compiler implicitly assigns it a value.\n" +
                "\t- The values associated with the member names do not need to be distinct.\n");
            ReadKey();

            Clear();
        }

        static void BitFlags()
        {
            Clear();

            WriteLine("\nBit Flags\n" +
                "\t- Programmers have long used the different bits in a single word as a compact way of representing a set of on/off flags. We call this word 'flag word'.\n" +
                "\t- Enums offer a convenient way to implement this.\n\n" +
                "\t- The general steps are the following:\n" +
                "\t\t- Determine how many bit flags you need and choose an unsigned integer type.\n" +
                "\t\t- Determine what each bit position represents and give it a name. Declare an enum of the chosen integer type, with each member represented by a bit position.\n" +
                "\t\t- Use the bitwise OR operator to set the appropriate bits in a word holding the bit flags.\n" +
                "\t\t- You can check whether a particular bit flag is set by using either the 'HasFlag' method or the bitwise AND operator.\n\n" +
                "\t- Take note of the following:\n" +
                "\t\t- The members have names that represent binary options.\n" +
                "\t\t\t- Each option is represented by a particular bit position in the word. Bit positions hold either a 0 or a 1.\n" +
                "\t\t\t- Since a bit flag represents a set of bits that are either on or off, you do not want to use 0 as a member value. It already has a meaning - that all the " +
                "bits flags are off.\n" +
                "\t\t- With hexadecimal representation, every hexadecimal digits represents exact bits. Because of this direct correlation between the bit patterns and hexadecimal " +
                "representation, when working with bit patterns, hex is often used rather than decimal representation.\n" +
                "\t\t- Starting with C# 7.0 binary representation is also now available.\n" +
                "\t\t- Decorating the enum with the 'Flags' attribute is not actually necessary but gives some additional convenience. An attribute appears as a string between square " +
                "brackets, immediately preceding a language construct. In this case, the attribute is immediately before the enum declaration.\n");
            WriteLine("\nThe Flags Attribute\n" +
                "\t- The preceding code used te 'Flags' attribute just before declaring the enum:\n\n" +
                "\t\t[ Flags ]\n" +
                "\t\tenum EnumName : IntegerType\n" +
                "\t\t{\n" +
                "\t\t\t...\n" +
                "\t\t}\n\n" +
                "\t- The 'Flags' attribute does not change the calculation at all. It does, however, provide several convenient features.\n" +
                "\t- First, it informs the compiler, object browsers, and other tools looking at the code that the members of the enum are meant to be combined as bit flags, rather than " +
                "used only as seperate values.\n" +
                "\t- This allows the browsers to interpret variables of the enum type more appropriately.\n\n" +
                "\t- Second, it allows the 'ToString' method of an enum to provide more appropriate formatting for the values of bit flags. \n" +
                "\t- The 'ToString' method takes an enum value and compares it to the value of the constant member of the enum.\n" +
                "\t- If it matches one of the members, 'ToString' returns the string name of the member.\n");
            ReadKey();

            Clear();
        }

        static void MoreAboutEnums()
        {
            Clear();

            WriteLine("\nMore About Enums\n" +
                "\t- Enums have only a single member type: the declared member constants.\n" +
                "\t\t- You cannot use modifiers with the members. They all implicitly have the same accessibility as the enum.\n" +
                "\t\t- The members are 'static', which means that they are accessible even if there are no variables of the enum type.\n" +
                "\t\t- As with all statics, there are two ways of accessing their members.\n" +
                "\t\t\t- You can use the type name, followed by a dot and the member name.\n" +
                "\t\t\t- Starting with C# 6.0 you can use the 'using static' directive to avoid the extra work and clutter of having to include the class name with every usage. This " +
                "can make your code considerably cleaner.\n\n" +
                "\t- An enum type is a distinct type. Comparing enum members of different enum types results in a compile-time error.\n\n" +
                "\t- There are also several useful 'static' methods of the .NET Enum type, on which 'enum' is based.\n" +
                "\t\t- The 'GetName' method takes an enum type object and an integer and returns the name of the corresponding enum member.\n" +
                "\t\t- The 'GetName' method takes an enum type object and returns all the names of all the members in the enum.\n");
            ReadKey();

            Clear();
        }
    }

    static class Thirteen
    {
        public static void Arrays()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tArrays\n" +
                "\n\t1. Arrays\n\t2. Types of Arrays\n\t3. An Array as an Object\n\t4. One-Dimensional and Rectangular Arrays\n\t5. Instantiating a One-Dimensional or Rectangular Array" +
                "\n\t6. Accessing Array Elements\n\t7. Initializing an Array\n\t8. Jagged Array\n\t9. Comparing Rectangular and Jagged Arrays\n\t10. The foreach Statement" +
                "\n\t11. Array Covariance\n\t12. Useful Inherited Array Members\n\t13. Comparing Array Types\n\t14. Arrays Ref Local and Ref Return\n\t15. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                ThirteenDecision(ref choice);

            } while (choice != 19);


            Clear();
        }

        static void ThirteenDecision(ref int choice)
        {
            switch(choice)
            {
                case 1:
                    Array();
                    break;
                case 2:
                    TypesOfArrays();
                    break;
                case 3:
                    AnArrayAsAnObject();
                    break;
                case 4:
                    OneDimensionalAndRectangularArrays();
                    break;
                case 5:
                    InstantiatingAOneDimensionalOrRectangularArray();
                    break;
                case 6:
                    AccessingArrayElements();
                    break;
                case 7:
                    InitializingAnArray();
                    break;
                case 8:
                    JaggedArrays();
                    break;
                case 9:
                    ComparingRectangularAndJaggedArrays();
                    break;
                case 10:
                    TheForEachStatement();
                    break;
                case 11:
                    ArrayCovariance();
                    break;
                case 12:
                    UsefulInheritedArrayMembers();
                    break;
                case 13:
                    ComparingArrayTypes();
                    break;
                case 14:
                    ArraysRefLocalAndRefReturn();
                    break;
            }
        }

        static void Array()
        {
            Clear();

            WriteLine("\nArrays\n" +
                "\t- An array is a set of uniform data elements represented by a single variable name.\n" +
                "\t- The individual elements are accessed using the variable name together with one or more indexes between square bracket.\n\n" +
                "\t\tArrayName[ index ]\n");
            WriteLine("\nDefinitions\n" +
                "\t- Let's start with some important definitions having to do with arrays in C#.\n" +
                "\t\t- 'Elements'         : The individual data items of an array are called 'elements'. All elements of an array must be of the same type or derived from the same type.\n" +
                "\t\t- 'Rank/dimensions   : Arrays can have any positive number of dimensions. The number of dimensions an array has is called its 'rank'.\n" +
                "\t\t- 'Dimension length' : Each dimension of an array has a 'length', which is the same number of positions in that direction.\n" +
                "\t\t- 'Array length'     : The total number of elements contained in an array, in 'all' dimensions, is called the 'length' of the array.\n");
            WriteLine("\nImportant Details\n" +
                "\t- The following are some important general facts about C# arrays:\n" +
                "\t\t- Once an array is created, its sized is fixed. C# does not support dynamic arrays.\n" +
                "\t\t- Array indexes are 0-based. That is, if the length of a dimension is n, the index values range from 0 to n - 1.\n");
            ReadKey();

            Clear();
        }

        static void TypesOfArrays()
        {
            Clear();

            WriteLine("\nTypes of Arrays\n" +
                "\t- C# provides two kinds of arrays.\n" +
                "\t\t- One-dimensional arrays can be thought of as a single line, or 'vector', of elements.\n" +
                "\t\t- Multidimensional arrays are composed such that each position in the primary vector is itself an array, called a 'subarray'. " +
                "Positions in the subarray vectors can themselves be subarrays.\n\n" +
                "\t- Additionally, there are two types of multidimensional arrays : 'rectangular arrays' and 'jagged arrays'; they have the following characteristics:\n\n" +
                "\t\t- Rectangular Arrays\n" +
                "\t\t\t- Are multidimensional arrays where all the subarrays in particular dimension have the same length.\n" +
                "\t\t\t- Always use a single set of square brackets, regardless of the number of dimensions.\n\n" +
                "\t\t- Jagged Arrays\n" +
                "\t\t\t- Are multidimensional arrays where each subarray is an independent array.\n" +
                "\t\t\t- Can have subarrays of 'different lengths'.\n" +
                "\t\t\t- Use a separate set of square brackets for each dimension of the array.\n");
            ReadKey();

            Clear();
        }

        static void AnArrayAsAnObject()
        {
            Clear();

            WriteLine("\nAn Array as an Object\n" +
                "\t- An array instance is an object whose type derives from class 'System.Array'. \n" +
                "\t- Since arrays are derived from this BCL base class, they inherit a number of useful members from it, such as the following:\n" +
                "\t\t- 'Rank'   : A property that returns the number of dimensions of the array.\n" +
                "\t\t- 'Length' : A property that returns the length or the total number of elements of the array.\n\n" +
                "\t- Array are reference types, and as with all reference types, they have both a reference to the data and the data object itself.\n" +
                "\t- The reference is either on the stack or in the heap, and the data object itself is always in the heap.\n\n" +
                "\t- Although an array is always a reference type, the elements of the array can be either value types of reference types.\n" +
                "\t\t- An array is called a 'value type array' if the elements stored are value types.\n" +
                "\t\t- An array is called a 'reference type array' if the elements stored in the array are references of references type objects.\n");
            ReadKey();

            Clear();
        }

        static void OneDimensionalAndRectangularArrays()
        {
            Clear();

            WriteLine("\nOne-Dimensional and Rectangular Arrays\n" +
                "\t- Syntactically, one-dimensional arrays and rectangular arrays are similar, so we will treat them together. We will treat jagged " +
                "arrays separately.\n");
            WriteLine("\nDeclaring a One-Dimensional or Rectangular Array\n" +
                "\t- To declare a one-dimensional or rectangular array, use a single set of square brackets between the type and the variable name.\n\n" +
                "\t- The 'rank-specifiers' are commas between the brackets. They specify the number of dimensions the array will have.\n" +
                "\t- The rank is the number of commas, plus one. Having no commas indicates a one-dimensional array, one comma indicates a two-dimensional array, and so forth.\n\n" +
                "\t- The base type, together with the rank specifiers, is the 'type' of the array. \n\n" +
                "\t\tArrayType[ RankSpecifiers ] ArrayName;\n\n" +
                "\t- Take note of the following:\n" +
                "\t\t- You can have as many rank specifiers as you need.\n" +
                "\t\t- You cannot place array dimension lengths in the array type section. The rank part of the array's type, but the lengths of the dimensions are " +
                "'not' part of the type.\n" +
                "\t\t- While an array is declared, the 'number' of dimensions is fixed. The 'length' of the dimensions, however, is not determined until the array " +
                "is instantiated.\n\n" +
                "\t- Note that unlike in C or C++, in C# the brackets follow the base type, not the variable name.\n");
            ReadKey();

            Clear();
        }

        static void InstantiatingAOneDimensionalOrRectangularArray()
        {
            Clear();

            WriteLine("\nInstantiating a One-Dimensional or Rectangular Array\n" +
                "\t- To instantiate an array, you use an 'array-creation expresion'. \n" +
                "\t- An array-creation expression consists of the 'new' operator, followed by the base type, followed by a pair of square brackets.\n" +
                "\t- The length of each dimension is placed in a comma-seperated list between the brackets.\n\n" +
                "\t\tArrayType[ ] ArrayName = new ArrayName[ ];\n\n" +
                "\t- Note that unlike object-creation expressions, array-creation expressions do not contain parentheses - even for reference type arrays.\n");
            ReadKey();

            Clear();
        }

        static void AccessingArrayElements()
        {
            Clear();

            WriteLine("\nAccessing Array Elements\n" +
                "\t- An array element is accessed using an integer value as an index into the array.\n" +
                "\t\t- Each dimension uses 0-based indexing.\n" +
                "\t\t- The index is placed between square brackets following the array name.\n");
            ReadKey();

            Clear();
        }

        static void InitializingAnArray()
        {
            Clear();

            WriteLine("\nInitializing an Array\n" +
                "\t- When an array is created, each  of the elements is automatically initialized to the default value for the type.\n" +
                "\t- The default values for the predefined types are 0 for integer types, 0.0 for floating-point types, false for Booleans and null " +
                "for reference types.\n");
            WriteLine("\nExplicit Initialization of One-Dimensional Array\n" +
                "\t- For a one-dimensional array, you can set explicit initial values by including an 'initialization list' immediately after the " +
                "array-creation expression of an array instantation.\n\n" +
                "\t\tArrayType[ ] ArrayName = new ArrayType[ ] { InitializationList };\n\n" +
                "\t- The initialization values must be separated by commas and enclosed in a set of curly braces.\n" +
                "\t- The dimension lengths are optional since the compiler can infer the lengths from the number of initializing values.\n");
            WriteLine("\nExplicit Initialization of Rectangular Arrays\n" +
                "\t- To explicitly initialize a rectangular array, you need to follow these rules:\n\n" +
                "\t\tArrayType[ , ] ArrayName = new ArrayType[ , ] { { InitializationList } { InitializationList } ... }\n\ns" +
                "\t- Each 'vector of initial values' must be enclosed in curly braces.\n" +
                "\t- Each 'dimension' must also be nested and enclosed in curly braces.\n" +
                "\t- In addition to the initial values, the initialization lists and components of each dimension must also be separated by commas.\n");
            WriteLine("\nSyntax Points for Initializing Rectangular Arrays\n" +
                "\t- Rectangular arrays are initialized with nested, comma-separated initialization list.\n" +
                "\t- This initialization lists are nested in curly braces.\n" +
                "\t- This can sometimes be confusing, so to get the nesting, grouping, and commas right, consider the following tips:\n" +
                "\t\t- Commas are used as 'separators' between all 'elements' and 'groups'.\n" +
                "\t\t- Commas are 'never' placed between left curly braces.\n" +
                "\t\t- Commas are 'never' placed before a right curly brace.\n" +
                "\t\t- If possible, use identation and carriage returns to arrange the groups so that they're visually distinct.\n" +
                "\t\t- Read the rank specifications from left to right, designating the last number as 'elements' and all the others as 'groups'.\n");
            WriteLine("\nShortcut Syntax\n" +
                "\t- When combining declaration, array creation, and initialization in a single statement, you can omit the array-creation expression " +
                "part of the syntax entirely and provide just the initialization portion.\n" +
                "\t- Shortcut syntax, both are equivalent.\n\n" +
                "\t\tArrayType[ ] ArrayName = new ArrayType[ DimensionLength ] { InitializationList };\n" +
                "\t\tArrayType[ ] ArrayName =                                  { InitializationList };\n");
            WriteLine("\nImplicitly Typed Arrays\n" +
                "\t- Like other variables, your local arrays can also be implicitly typed. This means the following:\n" +
                "\t\t- When initializing an array, you can let the compiler infer the array's type from the type of the initializers. This is allowed as long " +
                "as all the initializers can be implicitly converted to a single type.\n" +
                "\t\t- Just as with implicitly typed local variables, use the keyword 'var' instead of the array type.\n\n" +
                "\t\t\tArrayType[ ] ArrayName = new ArrayType[ ] { InitializationList };\n" +
                "\t\t\tvar          ArrayName = new          [ ] { InitializationList };\n");
            ReadKey();

            Clear();
        }

        static void JaggedArrays()
        { 
            Clear();

            WriteLine("\nJagged Arrays\n" +
                "\t- A jagged array is an array of arrays. Unlike rectangular arrays, the subarrays of a jagged array can have different numbers of elements.\n");
            WriteLine("\nDeclaring a Jagged Array\n" +
                "\t- The declaration syntax for jagged arrays requires a separate set of square brackets for each dimension.\n" +
                "\t- The number of sets of square brackets in the declaration of the array variable determines the rank of the array.\n" +
                "\t\t- A jagged array can be of any number of dimensions greater than one.\n" +
                "\t\t- As with rectangular arrays, dimension lengths cannot be included in the array type section of the declaration.\n\n" +
                "\t\t\tArrayType[ ][ ] ArrayName;\n");
            WriteLine("\nShortcut Instantiation\n" +
                "\t- You can combine the jagged array declaration with the creation of the first-level array using an array-creation expression.\n\n" +
                "\t\tArrayType[ ][ ] ArrayName = new ArrayType[ Subarray ][ ];\n\n" +
                "\t- You cannot instantiate more than the first-level array in the declaration statement.\n");
            WriteLine("\nInstantiating a Jagged Array\n" +
                "\t- Unlike other types of arrays, you cannot fully instantiate a jagged array in a single step.\n" +
                "\t- Since a jagged array is an array of independent arrays, each array must be created separately.\n" +
                "\t- Instantiating a full jagged array requires the following:\n" +
                "\t\t- Instantiate the top-level array.\n" +
                "\t\t- Instantiate each subarray separately, assigning the reference of the newly created array to the appropriate element of its containing " +
                "of its containing array.\n\n" +
                "\t\t\tArrayType[ ][ ] ArrayName = new ArrayType[ DimensionLength ][ ];\n" +
                "\t\t\tArrayName[ index[ 0 ] ] = new ArrayType[ ] { InitializationList };\n" +
                "\t\t\tArrayName[ index[ 1 ] ] = new ArrayType[ ] { InitializationList };\n" +
                "\t\t\tArrayName[ index[ 2 ] ] = new ArrayType[ ] { InitializationList };\n");
            WriteLine("\nSubarrays in Jagged Arrays\n" +
                "\t- Since the subarrays in a jagged array are themselves array, it is possible to have rectangular arrays inside jagged arrays.\n" +
                "\t- Use the 'Get.Length( int n )' method of arrays, inherited from 'System.Array', to get the length of the specified dimension of the array.\n");
            ReadKey();

            Clear();
        }

        static void ComparingRectangularAndJaggedArrays()
        {
            Clear();

            WriteLine("\nComparing Rectangular and Jagged Arrays\n" +
                "\t- The structure of rectangular and jagged arrays is significantly different.\n\n" +
                "\t- One-dimensional arrays have specific instructions in the CIL that allow them to be optimized for performance. Rectangular arrays do not " +
                "have these instructions and are not optimized to the same level.\n" +
                "\t- Because of this, it can sometimes be more efficient to use jagged arrays of one-dimensional arrays - which can be optimized - than " +
                "rectangular arrays, which cannot.\n\n" +
                "\t- On the other hand, the programming complexity can be significantly less for for a rectangular array because it can be treated as a single " +
                "unit, rather than an array of arrays.\n");
            ReadKey();

            Clear();
        }

        static void TheForEachStatement()
        {
            Clear();

            WriteLine("\nThe foreach Statement\n" +
                "\t- The 'foreach' statement allows you to sequentially access each element in an array.\n" +
                "\t- It is actually a more general construct in that it also work with other collection types.\n\n" +
                "\t- The important points of the foreach statement are the following:\n" +
                "\t\t- The 'iteration variable' is a temporary variable of the same type as the elements of the array. The 'foreach' statement uses the iteration " +
                "variable to sequentially represent each element in the array.\n" +
                "\t\t- The syntax of the 'foreach' statement is shown next, where:\n" +
                "\t\t\t- Type is the type of the elements of the array. You can explicitly supply its type, or you can use 'var' and let it be implicitly typed and " +
                "inferred by the compiler since the compiler knows the type of the array.\n" +
                "\t\t\t- 'Identifier' is the name of the iteration variable.\n" +
                "\t\t\t- 'ArrayName' is the name of the array to be iterated through.\n" +
                "\t\t\t- 'Statement' is a simple statement or a block that is executed once for each element in the array.\n\n" +
                "\t- Explicitly Typed Iteration Variable Declaration\n\n" +
                "\t\tforeach ( Type Identifier in ArrayName )\n" +
                "\t\t\tStatement\n\n" +
                "\t- Implicitly Typed Iteration Variable Declaration\n\n" +
                "\t\tforeach ( var Identifier in ArrayName )\n" +
                "\t\t\tStatement\n\n" +
                "\t- The 'foreach' statement works in the following way:\n" +
                "\t\t- It starts with the first element of the array and assigns that value to the 'iteration variable'.\n" +
                "\t\t- It then executes the body of the statement. Inside the body, you can use the iteration variable as a read-only alias for the array element.\n" +
                "\t\t- After the body is executed, the 'foreach' statement selects the next element in the array and repeats the process.\n\n" +
                "\t- In this way, it cycles through the array, allowing you to access each element one by one.\n");
            WriteLine("\nThe Iteration Variable Is Read-Only\n" +
                "\t- Since the value of the iteration variable is read-only, clearly it cannot be changed. But this has different effects on value type arrays and " +
                "reference type arrays.\n\n" +
                "\t- For value type arrays, this means you cannot change an element of the array when it is being represented by the iteration variable.\n" +
                "\t- Attempting to change the data in the iteration varaible produces a compile-time error message.\n\n" +
                "\t- For reference type arrays, you still cannot change the iteration variable, but the iteration variable only holds the reference to the data, not the " +
                "data itself.\n" +
                "\t- So although, you cannot change the reference, you can change the 'data' through the iteration variable.\n");
            WriteLine("\nThe foreach Statement with Multidimensional Arrays\n" +
                "\t- In a multidimensional array, the elements are processed in the order in which the rightmost index is incremented fastest.\n" +
                "\t- When the index has gone from 0 to length - 1, the next index to the left is incremented, and the indexes to the right are reset to 0.\n");
            ReadKey();

            Clear();
        }

        static void ArrayCovariance()
        {
            Clear();

            WriteLine("\nArray Covariance\n" +
                "\t- Under certain conditions, you can assign an object to an array element even if the object is not of the array's base type.\n" +
                "\t- This property of arrays is called 'array covariance'.\n" +
                "\t- You can use array covariance if the following are true:\n" +
                "\t\t- The array is a reference type array.\n" +
                "\t\t- There is an implicit or explicit conversion between the type of the object you are assigning and the array's base type.\n\n" +
                "\t- Since there is always an implicit conversion between a derived class and its base class, you can always assign an object of a derived class " +
                "to an array declared for the base class.\n\n" +
                "\t- Note that there is no covariance for value type arrays.\n");
            ReadKey();

            Clear();
        }

        static void UsefulInheritedArrayMembers()
        {
            Clear();

            WriteLine("\nUseful Inherited Array Members\n" +
                "\t- C# arrays are derived from class System.Array. From that base class they inherit a number of useful properties and methods.\n\n" +
                "\t\tMember\t\t\tType\t\tLifetime\t\tMeaning\n\n" +
                "\t\tRank\t\t\tProperty\tInstance\t\tGets the number of dimensions of the array.\n" +
                "\t\tLength\t\t\tProperty\tInstance\t\tGets the total number of elements in all the dimensions of the array.\n" +
                "\t\tGetLength\t\tMethod\t\tInstance\t\tReturns the length of a particular dimension of the array.\n" +
                "\t\tClear\t\t\tMethod\t\tStatic\t\t\tSets a range of elements to 0 or 'null'.\n" +
                "\t\tSort\t\t\tMethod\t\tStatic\t\t\tSorts the elements in a one-dimensional array.\n" +
                "\t\tBinarySearch\t\tMethod\t\tStatic\t\t\tSearches a one-dimensional array for a value, using binary search.\n" +
                "\t\tClone\t\t\tMethod\t\tInstance\t\tPerforms a shallow copy of the array - copying only the elements, both for arrays of value types and reference types.\n" +
                "\t\tIndexOf\t\t\tMethod\t\tStatic\t\t\tReturns the index of the first occurence of a value in a one-dimensional array.\n" +
                "\t\tReverse\t\t\tMethod\t\tStatic\t\t\tReverses the order of the elements of a range of a one-dimensional array.\n" +
                "\t\tGetUpperBound\t\tMethod\t\tInstance\t\tGets the upper bound at the specified dimension.\n\n");
            ReadKey();

            Clear();
        }

        static void ComparingArrayTypes()
        {
            Clear();

            WriteLine("\nComparing Array Types\n" +
                "\t- Some of the important similiraties and differences between three types of arrays.\n\n" +
                "\t\t- One Dimensional\n" +
                "\t\t\t- Has opitimizing instructions in CIL\n" +
                "\t\t\t- One array object\n" +
                "\t\t\t- Single set brackets\n" +
                "\t\t\t- No commas\n\n" +
                "\t\t- Rectangular \n" +
                "\t\t\t- Multidimensional and all subarrays in a multidimensional array must be of the same length\n" +
                "\t\t\t- One array object\n" +
                "\t\t\t- Single set of brackets\n" +
                "\t\t\t- There is commas\n\n" +
                "\t\t- Jagged\n" +
                "\t\t\t- Multidimensional and subarrays can be of different lengths\n" +
                "\t\t\t- Multiple array object\n" +
                "\t\t\t- Multiple sets of brackets\n" +
                "\t\t\t- No commas\n");
            ReadKey();

            Clear();
        }

        static void ArraysRefLocalAndRefReturn()
        {
            Clear();

            WriteLine("\nArrays Ref Local and Ref Return\n" +
                "\t- One of the common uses of 'ref return' and 'ref local', however, is to pass a reference to an array 'element' back to the calling scope.\n" +
                "\t- Remember that using the 'ref return' feature allows you to pass reference back out of a method as a return value, and a 'ref local' allows " +
                "you to use that reference in the calling scope.");
            ReadKey();

            Clear();
        }
    }

    static class Fourteen
    {
        public static void Delegates()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tDelegates\n" +
                "\n\t1. What Is a Delegate? \n\t2. An Overview of Delegates\n\t3. Declaring the Delegate Type\n\t4. Creating the Delegate Object" +
                "\n\t5. Assigning Delegates\n\t6. Combining Delegates\n\t7. Adding Methods to Delegates\n\t8. Removing Methods from a Delegate" +
                "\n\t9. Invoking a Delegate\n\t10. Delegate Example\n\t11. Invoking Delegates with Return Values" +
                "\n\t12. Invoking Delegates with Reference Parameters\n\t13. Anonymous Methods\n\t14. Lambda Expressions\n\t15. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                FourteenDecision(ref choice);

            } while (choice != 15);


            Clear();
        }

        static void FourteenDecision(ref int choice)
        {
            switch(choice)
            {
                case 1:
                    WhatIsADelegates();
                    break;
                case 2:
                    AnOverviewOfDelegates();
                    break;
                case 3:
                    DeclaringTheDelegateType();
                    break;
                case 4:
                    CreatingTheDelegateObject();
                    break;
                case 5:
                    AssigningDelegates();
                    break;
                case 6:
                    CombiningDelegate();
                    break;
                case 7:
                    AddingMethodsToDelegates();
                    break;
                case 8:
                    RemovingMethodsFromADelegate();
                    break;
                case 9:
                    InvokingADelegate();
                    break;
                case 10:
                    DelegateExample();
                    break;
                case 11:
                    InvokingDelegateWithReturnValues();
                    break;
                case 12:
                    InvokingDelegatesWithReferenceParameters();
                    break;
                case 13:
                    AnonymousMethods();
                    break;
                case 14:
                    LambdaExpressions();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void WhatIsADelegates()
        {
            Clear();

            WriteLine("\nWhat Is a Delegate?\n" +
                "\t- You can think of a delegates as an object that holds one or more methods.\n" +
                "\t- Normally, of course, you wouldn't think of 'executing' an 'object', but delegate is different from a typical object.\n" +
                "\t- You can execute a delegate, and when you do so, it executes the method that it 'holds'.\n\n" +
                "\t- If you are coming from a C++ background, the fastest way for you to understand delegates is to think of them as type-safe, " +
                "object-orinted C++ function pointers on steriods.\n");
            ReadKey();

            Clear();
        }

        static void AnOverviewOfDelegates()
        {
            Clear();

            WriteLine("\nAn Overview of Delegates\n" +
                "\t- A delegate is a user-defined type, just as a class is a user-defined type.\n" +
                "\t- But whereas class represents a collection of data and methods, a delegate holds one or more methods and a predefined operations.\n" +
                "\t- You use a delegate by performing the following steps:\n" +
                "\t\t- Declare a delegate type. A delegate declarations looks like a method declaration, except that it doesn't have an " +
                "implementation block.\n" +
                "\t\t- Declare a delegate variable of the delegate type.\n" +
                "\t\t- Create an object of the delegate type and assign it to the delegate variable. The new delegate object includes a reference to a " +
                "method that must have the same signature and return type as the delegate type defined in the first step.\n" +
                "\t\t- You can optionally add additional methods into the delegate object. These methods must have the same signature and return type " +
                "as the delegate type defined in the first step.\n" +
                "\t\t- Throughout your code you can then invoke the delegate, just as if it were a method. When you invoke the delegate, each of the " +
                "methods it contains is executed.\n\n" +
                "\t- You can think of a delegate as an object that contains an ordered list of methods with the same signature and return type.\n" +
                "\t\t- The list of methods is called the 'invocation list'.\n" +
                "\t\t- Methods held by a delegate 'can be from any class or struct', as long as they match 'both' of the following:\n" +
                "\t\t\t- The delegate's return type.\n" +
                "\t\t\t- The delegates signature (including 'ref' and 'out' modifiers).\n" +
                "\t\t- Methods in the invocation list can be either instance methods or static methods.\n" +
                "\t\t- When a delegate is invoked, each method in its invocation list is executed.\n");
            ReadKey();

            Clear();
        }

        static void DeclaringTheDelegateType()
        {
            Clear();

            WriteLine("\nDeclaring the Delegate Type\n" +
                "\t- Delegates are types, just as classes are types.\n" +
                "\t- And as with classes, a delegate type must be declare before you can use it to create variables and objects of the type.\n" +
                "\t- The following is the syntax of a delegate type:\n\n" +
                "\t\tdelegate ReturnType DelegateTypeName( Signature );\n\n" +
                "\t- The declaration of a delegate type looks much like the declaration of a method, in that it has both a 'return type' and a 'signature'. \n" +
                "\t- The return type and signature specify the form of the methods that the delegate will accept.\n\n" +
                "\t- The delegate type declaration differs from a method declaration in two ways. The delegate type declaration \n" +
                "\t\t- Is prefaced with the keyword 'delegate'\n" +
                "\t\t- Does not have a method body\n\n" +
                "\t- Even though the delegate type declaration looks like a method declaration, it doesn't need to be declared inside a class because " +
                "it is a type declaration.\n");
            ReadKey();

            Clear();
        }

        static void CreatingTheDelegateObject()
        {
            Clear();

            WriteLine("\nCreating the Delegate Object\n" +
                "\t- A delegate is a reference type and therefore has both a reference and an object.\n" +
                "\t- After a delegate type is declared, you can declare variables and create objects of the type.\n" +
                "\t- The following code shows the declaration of a variable of a delegate type:\n\n" +
                "\t\tDelegateTypeName VariableName;\n\n" +
                "\t- There are two ways you can create a delegate object. The first is to use an object-creation expression with the 'new' operator.\n" +
                "\t- The operand of the 'new' operator consist of the following:\n" +
                "\t\t- The delegate type name\n" +
                "\t\t- A set of parentheses containing the name of a method to use as the first member in the invocation list. 'The method can be either " +
                "an instance method or static method'.\n\n" +
                "\t\tVariableName = new DelegateTypeName( Instance | Static Method );\n\n" +
                "\t- You can also use the shortcut syntax, which consists of just the method specifier. This code and the preceeding code are sementically " +
                "equivalent. \n" +
                "\t- Using the shortcut syntax works because there is an implicit conversion between a method name and compatible delegate type.\n\n" +
                "\t\tVariableName = Instance | Static Method;\n\n" +
                "\t- Besides allocating the memory for the delegate, creating a delegate object also places the first method in the delegate's invocation " +
                "list.\n" +
                "\t- You can also create the variable and instantiate the object in the same statement, using the initializer syntax.\n");
            ReadKey();

            Clear();
        }

        static void AssigningDelegates()
        {
            Clear();

            WriteLine("\nAssignig Delegates\n" +
                "\t- Because delegates are reference types, you can change the reference contained in a delegate variable by assigning to it.\n" +
                "\t- The old delegate object will be disposed of by the garbage collector (GC) when it gets around to it.\n");
            ReadKey();

            Clear();
        }

        static void CombiningDelegate()
        {
            Clear();

            WriteLine("\nCombining Delegates\n" +
                "\t- All delegate's can be 'combined' by using the addition operator.\n" +
                "\t- The result of the operation is the creation of a new delegate, with an invocation list that is the concatenation of copies of the " +
                "invocation list of the two operand delegates.\n\n" +
                "\t- Although the term 'combining delegates' might give the impression that the operand delegates are modified, they are not changed " +
                "at all.\n" +
                "\t- In fact, 'delegates are immutable'. After a delegate object is created, it cannot be changed.\n");
            ReadKey();

            Clear();
        }

        static void AddingMethodsToDelegates()
        {
            Clear();

            WriteLine("\nAdding Methods to Delegates\n" +
                "\t- Delegates are immutable, C# provides syntax for making it appear that you can add a method to a delegate, using the += operator.\n\n" +
                "\t- What is actually happening, of course, is that when the += operator is used, a new delegate is created, with an invocation list that " +
                "is the combination of the delegate on the left and the method listed in the right.\n" +
                "- This new delegate is then assigned to the variable.\n\n" +
                "\t- You can add a method to a delegate more than once. Each time you add it, it creates a new element in the invocation list.\n");
            ReadKey();

            Clear();
        }

        static void RemovingMethodsFromADelegate()
        {
            Clear();

            WriteLine("\nRemoving Methods from a Delegate\n" +
                "\t- You can also remove a method from a delegate, using the -= operator.\n\n" +
                "\t- As with adding a method to a delegate, the resulting delegate is actually a new delegate.\n" +
                "\t- The new delegate is the copy of the old delegate - but its invocation list no longer contains the reference to the method that was " +
                "removed.\n\n" +
                "\t- The following are some things to remember when removing methods:\n" +
                "\t\t- If there are multiple entries for a method in the invocation list, the -= operator 'starts searching at the bottom of the list' and " +
                "removes the first instance of the matching method it finds.\n" +
                "\t\t- Attempting to delete a method that is not in the invocation list has no effect.\n" +
                "\t\t- Attempting to invoke an empty delegate throws an exception. You an check whether a delegate's invocation list is empty by comparing " +
                "the delegate to 'null'. If the invocation list is empty, the delegate is 'null'.\n");
            ReadKey();

            Clear();
        }

        static void InvokingADelegate()
        {
            Clear();

            WriteLine("\nInvoking a Delegate\n" +
                "\t- The important things to know about invoking a delegate are the following:\n" +
                "\t\t- You can invoke a delegate in either two of two ways. First you can call the delegate as if it were simply a method. Second, you " +
                "can use the 'Invoke' method on the delegate.\n" +
                "\t\t- Place the parameters within the parentheses of the call. The parameters used to invoke the delegate are used to invoke each of the " +
                "methods on the invocation list (unless one of the parameters is an output parameter).\n" +
                "\t\t- If a method is in the invocation list more than once, then when the delegate is invoked, the method will be called each time it is " +
                "encountered in the list.\n" +
                "\t\t- The delegate must not be empty (null) when invoked, or it will throw an exception. You can use an 'if' statement to check, or you " +
                "can use the null condiitonal operator and the 'Invoke' method.\n");
            ReadKey();

            Clear();
        }

        static void DelegateExample()
        {
            Clear();

            WriteLine("\nDelegate Example\n" +
                "\t- The following code defines and uses a delegate with no parameters and no return value. Note the following about the code:\n" +
                "\t\t- Class Test defines two print functions.\n" +
                "\t\t- Method Main creates an instance of the delegate and then adds three more methods.\n" +
                "\t\t- The program then invokes the delegate, which calls the methods. Before invoking the delegate, however, it checks to make sure it " +
                "is not null.\n\n" +
                "\t// Define a delegate type with no return value and no parameters.\n\n" +
                "\tdelegate void PrintFunction();\n\n" +
                "\tclass Test \n" +
                "\t{\n" +
                "\t\tpublic void Print1()\n" +
                "\t\t{\n" +
                "\t\t\tConsole.WriteLine(\"Print1 -- instance\");\n" +
                "\t\t}\n\n" +
                "\t\tpublic static void Print2()\n" +
                "\t\t{\n" +
                "\t\t\tConsole.WriteLine(\"Print2 -- static\");\n" +
                "\t\t}\n" +
                "\t}\n\n" +
                "\tclass Program\n" +
                "\t{\n" +
                "\t\tstatic void Main()\n" +
                "\t\t{\n" +
                "\t\t\tTest t = new Test();\n" +
                "\t\t\tPrintFunction pf;\n\n" +
                "\t\t\tpf = t.Print1;\n\n" +
                "\t\t\tpf += Test.Print2;\n" +
                "\t\t\tpf += t.Print1;\n" +
                "\t\t\tpf += Test.Print2;\n\n" +
                "\t\t\tif (null != pf )\n" +
                "\t\t\t\tpf();\n" +
                "\t\t\telse\n" +
                "\t\t\t\tConsole.WriteLine(\"Delegate is Empty!\");\n" +
                "\t\t}\n" +
                "\t}\n");
            ReadKey();

            Clear();
        }

        static void InvokingDelegateWithReturnValues()
        {
            Clear();

            WriteLine("\nInvoking Delegate with Return Values\n" +
                "\t- If a delegate has a return value and more than one method in its invocation list, the following occurs:\n" +
                "\t\t- The value returned by the last method in the invocation list is the value returned from the delegate invocation.\n" +
                "\t\t- The return values from all other methods in the invocation list are ignored.\n");
            ReadKey();

            Clear();
        }

        static void InvokingDelegatesWithReferenceParameters()
        {
            Clear();

            WriteLine("\nInvoking Delegates with Reference Parameters\n" +
                "\t- If a delegate has a reference parameter, the value of the parameter can change upon return from one or more of the methods in the invocation list.\n" +
                "\t- When calling the next method in the invocation list, the 'new value of the parameter - not the initial value' - is the one passed to the next method.\n");
            ReadKey();

            Clear();
        }

        static void AnonymousMethods()
        {
            Clear();

            WriteLine("\nAnonymous Methods\n" +
                "\t- You can use either static methods or instance methods to instantiate a delegate. \n" +
                "\t- In either case, the method itself can be called explicitly from other parts of the code and, of course, must be a member of some class or struct.\n\n" +
                "\t- What if, however, the method is used only one time - to instantiate the delegate?\n" +
                "\t- In that case, other than the syntactic requirement for creating the delegate, there is no real need for a separate, named method.\n" +
                "\t- Anonymous methods allow you to dispense with separate, named method.\n\n" +
                "\t- An 'anonymous method' is a method that is declared inline, at the point of instantiating a delegate.");
            WriteLine("\nUsing Anonymous Methods\n" +
                "\t- You can use an anonymous method in the following places:\n" +
                "\t\t- As an initializer expression when declaring a delegate variable.\n" +
                "\t\t- On the right side of an assignment statement when combining delegates.\n" +
                "\t\t- On the right side of an assignment statement adding a delegate to an event.\n");
            WriteLine("\nSyntax of Anonymous Methods\n" +
                "\t- The syntax of an anonymous method expression includes the following components:\n" +
                "\t\t- The type keyword 'delegate'\n" +
                "\t\t- The 'parameter list', which can be omitted if the statement block doesn't use any parameters.\n" +
                "\t\t- The 'statement block', which contains the code of the anonymous method.\n\n" +
                "\t\t\tdelegate ( ParameterList ) { ImplementationCode }\n");
            WriteLine("\nReturn Type\n" +
                "\t- An anonymous method does not explicitly declare a return type. \n" +
                "\t- The behavior of the implementation code itself, however, must match the delegate's return type by returning a value of that type.\n" +
                "\t- If the delegate has a return type of 'void', then the anonymous method code cannot return a value.\n");
            WriteLine("\nParameters\n" +
                "\t- Except in the case of array parameters, the parameter list of an anonymous method must match that of the delegate with respect to the following three characteristics:\n" +
                "\t\t- Number of parameters\n" +
                "\t\t- Types and positions of the parameters\n" +
                "\t\t- Modifiers\n\n" +
                "\t- You can simplify the parameter list of an anonymous method by leaving the parentheses empty or omitting them altogether, but only if 'both' of the following are true:\n" +
                "\t\t- The delegate's parameter list does not contain any 'out' parameters.\n" +
                "\t\t- The anonymous method does not use 'any' parameters.\n");
            WriteLine("\nThe params Parameters\n" +
                "\t- If the delegate declaration's parameter list contains a 'params' parameter, then the 'params' keyword is omitted from the parameter list of the anonymous method.\n");
            WriteLine("\nScope of Variables and Parameters\n" +
                "\t- The scopes of parameters and local variables declared inside an anonymous method are limited to the body of the implementation code.\n");
            WriteLine("\nOuter Variables\n" +
                "\t- Unlike the named methods of a delagates, anonymous methods have access to the local variables and environment of the scope surrounding them.\n" +
                "\t\t- Variables from the surrounding scope are called 'outer variables'.\n" +
                "\t\t- An outer variables used in the implementation code od an anonymous method is said to be 'captured' by the method.\n");
            WriteLine("\nExtension of a Captured Variable's Lifetime\n" +
                "\t- A captured outer variable remains alive as long as its capturing method is part of the delegate, even if the variable would have normally gone out of scope.");
            ReadKey();

            Clear();
        }

        static void LambdaExpressions()
        {
            Clear();

            WriteLine("\nLambda Expressions\n" +
                "\t- C# 2.0 introduced anonymous methods. \n" +
                "\t- The syntax for anonymous methods, however, is somewhat verbose and requires information that the compiler itself already knows.\n" +
                "\t- Rather that requiring you to include this redundant information, C# 3.0 introduced 'lambda expressions', which pare down the syntax of anonymous methods.\n" +
                "\t- You will probably want to use lambda expression instead of anonymous methods.\n" +
                "\t- In fact, if lambda expression had been introduced first, there never would have been anonymous methods.\n\n" +
                "\t- In the anonymous method syntax, the 'delegate' keyword is redundant because the compiler can already see that you are assigning the method to a delegate.\n" +
                "\t- You can easily transform an anonymous method into a lambda expression by doing the following:\n" +
                "\t\t- Delete the 'delegate' keyword\n" +
                "\t\t- Place the lambda operator, =>, between the parameter list and the body of the anonymous method. The lambda operator is read as 'goes to'\n\n" +
                "\t- Note that the term 'lambda expression' comes from the 'lambda calculus', which was developed in the 1920s and 1930s by mathematician Alonzo Churct and others.\n" +
                "\t- The lambda calculus is a system for representing functions and uses the Greek letter lambda to represent a nameless function.\n" +
                "\t- More recently, funcitonal programming languages such as Lisp and its dialects use the term to represent expression that can be used to directly describe the definition of a funciton, rather than using a name for it.\n\n" +
                "\t- This simple transformation is less verbose and looks cleaner, but it only saves you six characters. \n" +
                "\t- There is more, however, that the compiler can infer, allowing you to simplify the lambda expression further.\n" +
                "\t- The final form of the lambda expression has about one-fourth the characters of the original anonymous method and is cleaner and easier to understand.\n\n" +
                "Some important points about lambda expression parameter list are the following:\n" +
                "\t\t- The parameters in the parameter list of a lambda expression must match that of the delegate in number, type, and position.\n" +
                "\t\t- THe parameters in the parameter list of an expression do not have to include the type unless the delegate has either 'ref' or 'out' parameters - in which case the types are required.\n" +
                "\t\t- If there are no parameters, you must use an empty set of parentheses.\n");

            ReadKey();

            Clear();
        }
    }

    static class Fifteen
    {
        public static void Events()
        {
            Clear();

            int choice;

            do
            {
                WriteLine("\n\tEvents\n" +
                "\n\t1. Publishers and Subscribers\n\t2. Overview of Source Code Components\n\t3. Declaring an Event\n\t4. Subscribing to an Event" +
                "\n\t5. Raising an Event\n\t6. Standard Event Usage\n\t7. Event Accessors\n\t8. Exit\n");

                Write("-> ");
                choice = ToInt32(ReadLine());

                FifteenDecision(ref choice);

            } while (choice != 8);

            Clear();
        }

        static void FifteenDecision(ref int choice)
        {
            switch(choice)
            {
                case 1:
                    PublishersAndSubscribers();
                    break;
                case 2:
                    OverviewOfSourceCodeComponents();
                    break;
                case 3:
                    DeclaringAnEvent();
                    break;
                case 4:
                    SubscribingToAnEvent();
                    break;
                case 5:
                    RaisingAnEvent();
                    break;
                case 6:
                    StandardEventUsage();
                    break;
                case 7:
                    EventAccessors();
                    break;
                default:
                    Clear();
                    break;
            }
        }

        static void PublishersAndSubscribers()
        {
            Clear();

            WriteLine("\nPublishers and Subscribers\n" +
                "\t- One common requirement in many programs is that when a particular program event occurs, other parts of the program need to be notifierd that the event has occured.\n\n" +
                "\t- One pattern for satisfying this requirement is called the 'publisher/subscriber pattern'. \n" +
                "\t- In this pattern, a class, called the 'publisher', defines a set of events that other parts of the program might be interested in.\n" +
                "\t- Other classes can then 'sign up' to be notified by the publisher when these events occur.\n" +
                "\t- These 'subscriber' classes 'sign up' for notification by supplying a method to the publisher.\n" +
                "\t- When the event occurs, the publisher 'raises the event', and all the methods submitted by the subscribers are executed.\n\n" +
                "\t- The methods supplied by the subscribers are called 'callback methods' because the publisher 'calls the subscriber back' by executing their methods.\n" +
                "\t- They are also called 'event handlers' because they are the code that is called to handle the event.\n\n" +
                "\t- The following are some important terms related to events:\n" +
                "\t\t- Publishers       : A class or struct that publishes an event so that other classes can be notified when the event occurs.\n" +
                "\t\t- Subscriber       : A class or struct that registers to be notified when the event occurs.\n" +
                "\t\t- Event handler    : A method that is registered with the publisher, by the subscriber, and is executed when the publisher raises the event. The event handler method can be declared in the same class or struct as the event or in a different class or struct.\n" +
                "\t\t- Raising an event : The term for 'invoking' or 'firing' an event. When an event is raised, all the methods registered with that event are invoked.\n\n" +
                "\t- Many aspect of events are similar to those of delegates.\n" +
                "\t- In fact, an event is like a simpler delegate that is specialized for a particular use.\n" +
                "\t- There is a good reason for the similarities in the behaviors of delegates and events.\n" +
                "\t- An event contains a private delegate.\n\n" +
                "\t- The important things to know about an event's private delegate are the following:\n" +
                "\t\t- An 'event' gives structured access to its privately controlled delegate. That is, you cannot directly access the delegate.\n" +
                "\t\t- There are fewer operations available than with a delegate. With an event you can only add and remove event handlers and invoke the event.\n" +
                "\t\t- When an event is raised, it invokes the delegate, which sequentially calls the methods in its invocation list.\n");
            ReadKey();

            Clear();
        }

        static void OverviewOfSourceCodeComponents()
        {
            Clear();

            WriteLine("\nOverview of Source Code Components\n" +
                "\t- There are five pieces of code that need to be in place to use events. \n" +
                "\t- These pieces of code are the following:\n" +
                "\t\t- Delegate Type Declaration  : The event and the event handler must have a common signature and return type, which are specified by the delegate type, described by a delegate type.\n" +
                "\t\t- Event Handler Declarations : These are the declarations, in the subscriber classes, of the methods to be executed when the event is raised. These do not have to be explicitly named methods; they can also be anonymouse methods or lambda expressions.\n" +
                "\t\t- Event Declaration          : The publisher class must declare an event member that subscribers can register with. When a class declares a 'public' event, it is said to have 'published the event'.\n" +
                "\t\t- Event Registration         : The subscribers must register with an event in order to be notified when it has been raised. This is the code that connects the event handlers to the event.\n" +
                "\t\t- Code that raises the event : This is the code in the publisher that 'fires' the event, causing it to invoke all the event handlers registered with it.\n");
            ReadKey();

            Clear();
        }

        static void DeclaringAnEvent()
        {
            Clear();

            WriteLine("\nDeclaring an Event\n" +
                "\t- The publisher must provide the event object.\n" +
                "\t- Creating an event is simple - it requires only a delegate type and a name.\n" +
                "\t\t- The event is declared inside a class.\n" +
                "\t\t- It requires the name of a delegate type. Any event handlers attached to the event must match the delegate type in signature and return type.\n" +
                "\t\t- It is declared 'public' so that other classes and structs can register event handlers with it.\n" +
                "\t\t- You do not use an object-creation expression (a 'new' expression) with an event.\n\n" +
                "\t\t\tpublic event EventHandler NameOfEvent;\n\n" +
                "\t- You can declare more than one event in a declaration statement by using a comma-separated list.\n\n" +
                "\t\tpublic event EventHandler Event1, Event2, Event3, OtherEvent;\n\n" +
                "\t- You can also make events static by including the 'static' keyword.\n\n" +
                "\t\tpublic static event EventHandler NameOfEvent;\n");
            WriteLine("\nAn Event Is a Member\n" +
                "\t- A common error is to think of an event as a type - which it's not.\n" +
                "\t- Like a method, or a property, an event is a 'member of a class' or a struct, and there are several important ramifications to this.\n" +
                "\t\t- Because an event is a member,\n" +
                "\t\t\t- You cannot declare an event in a block of executable code.\n" +
                "\t\t\t- It must be declared in a class or struct, with the other members.\n" +
                "\t\t- An event member is implicitly and automatically initialized to 'null' with the other members.\n\n" +
                "\t- To declare an event, you must supply the name of a 'delegate type'.\n" +
                "\t- You can either declare one or use one that already exists.\n" +
                "\t- If you declare a delegate type, it must specify the signature and return type of the methods that will be registered by the event.\n" +
                "\t- The BCL declares a delegate called 'EventHandler' specifically for use with system events.\n");
            ReadKey();

            Clear();
        }

        static void SubscribingToAnEvent()
        {
            Clear();

            WriteLine("\nSubscribing to an Event\n" +
                "\t- Subscribers add event handlers to the event.\n" +
                "\t- For an event handler to be added to an event, the handler must have the same return type and signature as the event's delegate.\n" +
                "\t\t- Use the += operator to add an event handler to an event. The event handler is placed on the right side of the operator.\n" +
                "\t\t- The event handler specification can be any of the following:\n" +
                "\t\t\t- The name of an instance method\n" +
                "\t\t\t- The name of a static method\n" +
                "\t\t\t- An anonymous method\n" +
                "\t\t\t- A lambda expression\n");
            ReadKey();

            Clear();
        }

        static void RaisingAnEvent()
        {
            Clear();

            WriteLine("\nRaising an Event\n" +
                "\t- The event member itself holds the event handlers that need to be invoked.\n" +
                "\t- Nothing happens with them unless the event is raised.\n" +
                "\t- You need to make sure there is code to do just that, at the appropriate times.\n\n" +
                "\t\t- Before raising the event, the code compares it to 'null' to see whether it contains any event handlers. If the event is 'null', it is empty and cannot be executed.\n" +
                "\t\t- The syntax for raising the event is the same as that of invoking a method.\n" +
                "\t\t\t- Use the name of the event, followed by the parameter list enclosed in parentheses.\n" +
                "\t\t\t- The parameter list must match the delegate type of the event.\n\n" +
                "\t- Putting together the event declaration and the code to raise the event gives the following class declaration for the publisher.\n" +
                "\t- The code contains two members: the event and a method which raises the event when appropriate.\n\n");
            ReadKey();

            Clear();
        }

        static void StandardEventUsage()
        {
            Clear();

            WriteLine("\nStandard Event Usage\n" +
                "\t- GUI programming is event driven, which means that while the program is running, it can be interrupted at any time by events such as button clicks, key presses, or system timers.\n" +
                "\t- When this happens, the program needs to handle the event and then continue on its course.\n\n" +
                "\t- Clearly, this asynchronous handling of program events is the perfect situation for using C# events.\n" +
                "\t- Windows GUI programming uses events so extensively that there is a standard .NET Framework pattern for using them.\n" +
                "\t- The foundation of the standard patter for event usage is the 'EventHandler' delegate type, which is declared in the 'System' namespace.\n" +
                "\t- The following line of code shows the declaration of the 'EventHandler' delegate type. The things to notice about the declaration are the following:\n" +
                "\t\t- The first parameter is meant to hold a reference to the object that raised the event. It is of type 'object' and can, therefore, match any instance of any type.\n" +
                "\t\t- The second parameter is meant to hold state information of whatever type is appropriate for the application.\n" +
                "\t\t- The return type is 'void'\n\n" +
                "\t\t\tpublic delegate void EventHandler(object sender, EventArgs e);\n\n" +
                "\t- The second parameter in the 'EventHandler' delegate type is an object of class 'EventArgs', which is declared in the 'System' namespace. \n" +
                "\t- You might be tempted to think that since the second parameter is meant for passing dat, an 'EventArgs' class object would be able to store data of some sort. You would be wrong.\n" +
                "\t\t- The 'EventsArg' class is designed to carry no data. It is used for event handlers that do not need to pass data - and is generally ignored by them.\n" +
                "\t\t- If you want to pass data, you must declare a class 'derived' from 'EventArgs', with the appropriate fields to hold the data you want to pass.\n\n" +
                "\t- Even thought the 'EventArgs' class do not actually pass data, it is an important part of the pattern of using the 'EventHandler' delegate.\n" +
                "\t- These parameter, of types 'objects' and 'EventArgs', are the base classes for whatever actual types are used as the parameters.\n" +
                "\t- This allows the 'EventHandler' delegate to provide a signature that is the lowest common denominator for all events and event handlers, allowing all events to have exactly two parameters, rather than having different signatures for each case.\n");
            WriteLine("\nPassing Data by Extending EventArgs\n" +
                "\t- To pass data in the second parameter of your event handler and adhere to the standard conventions, you need to declare a custom class derived from 'EventArgs' that can store the data you need passed.\n" +
                "\t- By convention, the name of the class should end in 'EventArgs'.\n" +
                "\t- For example, the following code declares a custom class that can store a string in a field called 'Message':\n\n" +
                "\t\tpublic class IncrementEventArgs : EventArgs\n" +
                "\t\t{\n" +
                "\t\t\tpublic int IterationCount { get; set; }\n" +
                "\t\t}\n\n" +
                "\t- Now that you a have a custom class for passing data in the second parameter of your event handlers, you need a delegate type that uses the new custom class.\n" +
                "\t- To obtain this, use the generic version of the delegate 'EventHandler<>'.\n" +
                "\t- To use the generic delegate, do the following, as shown in the subsequent code:\n" +
                "\t\t- Place the name of the custom class between the angle brackets.\n" +
                "\t\t- Use the entier string wherever you would have use the name of you custom delegate type. \n" +
                "\t\t- For example, this is what the event declaration would look like:\n\n" +
                "\t\t\tpublic event EventHandler<CustomClass> EventName;\n");
            WriteLine("\nRemoving Event Handlers\n" +
                "\t- When you are done with an event handler, you can remove it from the event.\n" +
                "\t- You remove an event handler from an event by using the -= operator.\n\n" +
                "\t- If a handler is registered more than once with an event, then when you issue the command to remove the handler, only the last instance of that handler is removed from the list.\n");
            ReadKey();

            Clear();
        }

        static void EventAccessors()
        {
            Clear();

            WriteLine("\nEvent Accessors\n" +
                "\t- The += and -= operators are the only operators allowed for an event.\n" +
                "\t- These operators have the well-defined behaviors that you have seen so far.\n\n" +
                "\t- It is possible, however, to change these operators' behavior and have the event perform whatever custom code you like when they are used.\n" +
                "\t- This is an advanced topic, however, so we'll just mention it here, without going into too much detail.\n\n" +
                "\t- To change the operation of these operators, you must define event accessor for the event.\n" +
                "\t\t- These are two accessors: 'add' and 'remove'.\n" +
                "\t\t- The declaration of an event with accessors looks similar to the declaration of a property.\n\n" +
                "\t- The following example shows the form of an event declaration with accessors.\n" +
                "\t- Both accessors have an implicit value parameter called 'value' that takes a reference to either an instance method or static method.\n\n" +
                "\t\tpublic event EventHandler EventName\n" +
                "\t\t{\n" +
                "\t\t\tadd\n" +
                "\t\t\t{\n" +
                "\t\t\t\t...\t// Code to implement  the += operator\n" +
                "\t\t\t}\n\n" +
                "\t\t\tremove\n" +
                "\t\t\t{\n" +
                "\t\t\t\t...\t// Code to implement the -= operator\n" +
                "\t\t\t}\n" +
                "\t\t}\n\n" +
                "\t- When the event accessors are declared, the event does not contain an embedded delegate object.\n" +
                "\t- You must implement your own storage mechanism for storing and removing the methods registered with the event.\n\n" +
                "\t- The event accessors acts as 'void methods', meaning that they cannot use return statements that return a value.");
            ReadKey();

            Clear();
        }

    }
}