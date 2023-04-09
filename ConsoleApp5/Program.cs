using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Runtime;

if (!Directory.Exists("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo"))
{
    Directory.CreateDirectory("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo");
}
ZipFile.ExtractToDirectory("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\Form.zip", "C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo");
var filePath = "C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5";
if (!File.Exists("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\NewInfo.csv"))
{
    File.Create("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\NewInfo.csv");
}
var newInfo = "C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\NewInfo.csv";

using FileStream fileCsv = new FileStream(newInfo, FileMode.OpenOrCreate);
using var streamWriter = new StreamWriter(fileCsv);
DirectoryInfo di = new DirectoryInfo("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo");
DirectoryInfo[] diArr = di.GetDirectories();
for (var i = 0; i < diArr.Length;i++) 
{
    var b = 0;
    streamWriter.WriteLine("Directory");
    streamWriter.WriteLine(diArr[i].Name);
    streamWriter.WriteLine(diArr[i].LastWriteTime);
    var del = "C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo\\" + diArr[i].Name;
    Directory.Delete(del);

   
}
Directory.Delete("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\ZipInfo");
var fileTxt = "C:\\Users\\chuba\\AppData\\Roaming\\Lesson12HomeWork.txt";
using var fileStreamSecond = new FileStream(fileTxt,FileMode.OpenOrCreate);
using var newStreamWiter = new StreamWriter(fileStreamSecond);
newStreamWiter.WriteLine(Path.GetFullPath("C:\\Users\\chuba\\OneDrive\\Робочий стіл\\Программирование\\Проекты\\HomeWork1\\ConsoleApp5\\NewInfo.csv"));
