using GorevYonetimSistemi.TaskFolder;
using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();

    public List<TaskItem> Tasks
    {
        get { return tasks; }
    }

    public void AddTask(TaskItem task)
    {
        tasks.Add(task);
        Console.WriteLine($"Görev '{task.name}' eklendi.");
    }

    public void ListTasks(bool showDescription = false)
    {
        Console.WriteLine("Görevler:");
        foreach (var task in tasks)
        {
            string status = task.isCompleted ? "Tamamlandı" : "Devam Ediyor";
            Console.WriteLine($"Id: {task.id}, Adı: {task.name}, Durum: {status}");
            if (showDescription)
            {
                Console.WriteLine($"  Açıklama: {task.description}");
            }
        }
    }

    public void ListIncompleteTasks(bool showDescription = false)
    {
        Console.WriteLine("Tamamlanmamış Görevler:");
        foreach (var task in tasks)
        {
            if (!task.isCompleted)
            {
                Console.WriteLine($"Id: {task.id}, Adı: {task.name}, Durum: Devam Ediyor");
                if (showDescription)
                {
                    Console.WriteLine($"  Açıklama: {task.description}");
                }
            }
        }
    }

    public void ShowTaskDescription(int id)
    {
        var task = tasks.Find(t => t.id == id);
        if (task != null)
        {
            Console.WriteLine($"Görev Açıklaması: {task.description}");
        }
        else
        {
            Console.WriteLine("Görev bulunamadı.");
        }
    }

    public void MarkTaskAsCompleted(int id)
    {
        var task = tasks.Find(t => t.id == id);
        if (task != null)
        {
            task.tamamlandimi();
            Console.WriteLine($"Görev '{task.name}' tamamlandı.");
        }
        else
        {
            Console.WriteLine("Görev bulunamadı.");
        }
    }

    public void DeleteTask(int id)
    {
        var task = tasks.Find(t => t.id == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine($"Görev '{task.name}' silindi.");
        }
        else
        {
            Console.WriteLine("Görev bulunamadı.");
        }
    }
}
