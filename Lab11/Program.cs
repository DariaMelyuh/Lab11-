using Lab11;
class Program
{
    static void Main(string[] args)
    {
        IFile file = new FileProxy(@"D:\2 курс\Объектно-ориентированный анализ и проектирование\лр 11.txt");
        Console.WriteLine($"Размер файла: {file.GetSize()} байт");
        Console.WriteLine($"Адрес файла: {file.GetPath()}");
        byte[] fileData = file.Show();
        Console.WriteLine($"Длина данных файла: {fileData.Length} байт");
    }
}