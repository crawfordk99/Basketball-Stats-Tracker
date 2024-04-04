using System.IO;
using System.Text;
public class Files {
    private string _fileName;
    private string _fileContent;
    public string FileName {get{return _fileName;} set{_fileName = value;}}
    public string FileContent {get{return _fileContent;} set{_fileContent = value;}}

    public Files() {}

    public Files(string fileName) {
        FileName = fileName;
    }
    public Files(string fileName, string fileContent) {
        FileName = fileName;
        FileContent = fileContent;
    }
    
  
    public void WriteToFile() {
        string name = FileName;
        string content = FileContent;
        try
        {
            if (!string.IsNullOrEmpty(name)) {
                string oldContent = File.ReadAllText(name);
                using (StreamWriter writer = new StreamWriter(name))
                {
                    // Write the old content to the file first
                    writer.Write(oldContent + Environment.NewLine + content);
                }
            }
            else{
                using (StreamWriter writer = new StreamWriter(name))
                {
                    // Write the class content to the file
                    writer.Write(content);
                }
            }
                // Create a StreamWriter to write to the file
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while writing the class '{content}' to '{name}': {ex.Message}");
        }
    }
    public void ReadFile() {
        string name = FileName;
        string[] strings = File.ReadAllLines(name);
        foreach (string s in strings) {
            Console.WriteLine(s);
        }
    }
    public void DeleteFileContent() {
        File.WriteAllText(FileName, string.Empty);
    }

}