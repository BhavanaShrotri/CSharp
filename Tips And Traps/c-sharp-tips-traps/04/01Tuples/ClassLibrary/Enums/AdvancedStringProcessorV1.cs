using System;
using System.Collections.Generic;

namespace ClassLibrary.Enums
{    
    public enum StringProcessingOptionsV1
    {
        None,
        ConvertToUppercase,
        AddLength,        
    }

    public class AdvancedStringProcessorV1
    {
        public List<string> Process(List<string> stringsToProcess, 
                                    StringProcessingOptionsV1 options)
        {
            var results = new List<string>();

            foreach (var s in stringsToProcess)
            {
                switch (options)
                {
                    case StringProcessingOptionsV1.None:
                        results.Add(s);
                        break;
                    case StringProcessingOptionsV1.ConvertToUppercase:
                        results.Add(s.ToUpperInvariant());
                        break;
                    case StringProcessingOptionsV1.AddLength:
                        results.Add($"{s.Length}-{s}");
                        break;
                    default:
                        throw new NotImplementedException();                      
                }
            }

            return results;
        }        
    }
}
