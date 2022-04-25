using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] command = input.Split(":");
                string currentCommand = command[0];

                if (currentCommand == "Add")
                {
                    string lessonTitle = command[1];
                    if (lessons.Contains(lessonTitle))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (currentCommand == "Insert")
                {
                    string lessonTitle = command[1];
                    int indexToInsert = int.Parse(command[2]);
                    if (indexToInsert < 0 || indexToInsert >= lessons.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (lessons.Contains(lessonTitle))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        lessons.Insert(indexToInsert, lessonTitle);
                    }
                }
                else if (currentCommand == "Remove")
                {
                    string lessonTitle = command[1];
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);

                        if (lessons.Contains(lessonTitle + "-Exercise"))
                        {
                            lessons.Remove(lessonTitle + "-Exercise");
                        }
                    }
                    
                }
                else if (currentCommand == "Swap")
                {
                    string lessonsTitle1 = command[1];
                    string lessonsTitle2 = command[2];
                    bool isExist = false;
                    if (lessons.Contains(lessonsTitle1) && lessons.Contains(lessonsTitle2))
                    {
                        isExist = true;
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    int indexOfLesson1 = -1;
                    int indexOfLesson2 = -1;

                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == lessonsTitle1)
                        {
                            indexOfLesson1 = i;
                        }
                        if (lessons[i] == lessonsTitle2)
                        {
                            indexOfLesson2 = i;
                        }
                    }
                    lessons.RemoveAt(indexOfLesson1);
                    lessons.Insert(indexOfLesson1, lessonsTitle2);
                    lessons.RemoveAt(indexOfLesson2);
                    lessons.Insert(indexOfLesson2, lessonsTitle1);

                    if (lessons.Contains(lessonsTitle1 + "-Exercise"))
                    {
                        lessons.Remove(lessonsTitle1 + "-Exercise");
                        lessons.Insert(indexOfLesson2 + 1, lessonsTitle1 + "-Exercise");
                    }
                    if (lessons.Contains(lessonsTitle2 + "-Exercise"))
                    {
                        lessons.Remove(lessonsTitle2 + "-Exercise");
                        lessons.Insert(indexOfLesson1 + 1, lessonsTitle2 + "-Exercise");
                    }
                }

                else
                {
                    string lessonTitle = command[1];
                    int indexOfLesson = -1;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == lessonTitle)
                        {
                            indexOfLesson = i;
                        }
                    }

                    if (lessons.Contains(lessonTitle))
                    {
                        if (indexOfLesson == lessons.Count - 1)
                        {
                            lessons.Add(lessonTitle + "-Exercise");
                        }
                        else
                        {
                            if (lessons[indexOfLesson + 1] == lessonTitle + "-Exercise")
                            {
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                lessons.Insert(indexOfLesson + 1, lessonTitle + "-Exercise");
                            }
                        } 
                    }
                    else
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(lessonTitle + "-Exercise");
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 1; i <= lessons.Count; i++)
            {
                Console.WriteLine($"{i}.{lessons[i - 1]}");
            }
        }
    }
}
