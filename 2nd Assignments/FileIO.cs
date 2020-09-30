using System;
using System.IO;
public class FileIO
{
    public void Assignment()
    {
        string rootFolderName = "Nepal";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Beatles",
        "Pink Floyd",
        "21 Pilots",
        "Nirvana",
        "The Creed",
        "The Queen",
        "The Edge",
        "Maroon 5",
        "Greenday",
        "Linkin Park",
        };
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}