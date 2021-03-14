    using System;
    using System.Collections.Generic;
    using System.IO;

    namespace ClassLibrary1
    {
        public class Dict
        {
        public static Dictionary<string, int> CountWords(string path)
        {
            var result = new Dictionary<string, int>();
            var line = File.ReadAllText(path);
            var words = line.Split(new[] { ' ', '-', ':', '.', '"', '!', '?', ',', ';', ')', '(', '\\', '/', '<', '>', '*', '[', ']'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
                {
                if (!result.ContainsKey(word))
                    result.Add(word, 0);
                else
                    result[word]++;
                }
            return result;
        }
        }
    }
