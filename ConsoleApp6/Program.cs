var txtPath = "C:\\Users\\chuba\\AppData\\Roaming\\Lesson12HomeWork.txt";
using var fileStream = new FileStream(txtPath, FileMode.OpenOrCreate);
using var streamReader = new StreamReader(fileStream);
//var csvPath = streamReader.ReadToEnd();
using var fileScvStream = new FileStream(streamReader.ReadToEnd(), FileMode.OpenOrCreate);
using var streamCsvReader = new StreamReader(fileScvStream);
Console.WriteLine(streamCsvReader.Read());