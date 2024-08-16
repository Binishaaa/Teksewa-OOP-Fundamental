internal class FolderHandler
{
    public static void CreateFolder(string newFolderName, string rootPath = "D:\\C# Training\\Teksewa-OOP-Fundamental\\FileIO") 
    {
        var folderPath = $"{rootPath}\\{newFolderName}";
        var folderExist = Directory.Exists(folderPath);

        if ( !folderExist)
            Directory.CreateDirectory(folderPath);
    }
}
