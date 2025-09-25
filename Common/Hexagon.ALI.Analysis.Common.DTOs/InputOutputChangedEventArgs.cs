using System.IO;

namespace Hexagon.ALI.Analysis.Common.DTOs
{
    public class InputOutputChangedEventArgs
    {
        public InputOutputChangedEventArgs(string databasePath)
        {
            DatabasePath = databasePath ?? "";
        }
        
        public string DatabasePath { get; }

        public string Name => Path.GetFileNameWithoutExtension(DatabasePath);
    }
}
