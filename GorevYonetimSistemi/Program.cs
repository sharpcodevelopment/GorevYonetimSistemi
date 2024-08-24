using GorevYonetimSistemi.TaskFolder;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\n1. Görev Ekle");
            Console.WriteLine("2. Görevleri Listele");
            Console.WriteLine("3. Tamamlanmamış Görevleri Listele");
            Console.WriteLine("4. Görevi Tamamla");
            Console.WriteLine("5. Görevi Sil");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminiz: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Görev adı: ");
                    string name = Console.ReadLine();
                    Console.Write("Görev açıklaması: ");
                    string description = Console.ReadLine();
                    int newId = taskManager.Tasks.Count + 1;
                    taskManager.AddTask(new TaskItem(newId, name, description));
                    break;
                case 2:
                    Console.Write("Açıklamaları görmek ister misiniz? (Evet/Hayır): ");
                    string listDesc = Console.ReadLine().ToLower();
                    bool showDescription = listDesc == "evet";
                    taskManager.ListTasks(showDescription);
                    break;
                case 3:
                    Console.Write("Açıklamaları görmek ister misiniz? (Evet/Hayır): ");
                    string incompleteDesc = Console.ReadLine().ToLower();
                    bool showIncompleteDescription = incompleteDesc == "evet";
                    taskManager.ListIncompleteTasks(showIncompleteDescription);
                    break;
                case 4:
                    Console.Write("Tamamlanacak görevin Id'si: ");
                    int completeId = Convert.ToInt32(Console.ReadLine());
                    taskManager.MarkTaskAsCompleted(completeId);
                    break;
                case 5:
                    Console.Write("Silinecek görevin Id'si: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    taskManager.DeleteTask(deleteId);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
