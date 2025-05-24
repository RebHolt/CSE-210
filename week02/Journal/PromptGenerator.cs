using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "one",
        "two",
        "three",
        "four",
        "five"
    };
    public string GetRandomPrompt()
    {
        Random indexGenerator = new Random();

        int index = indexGenerator.Next(0, _prompts.Count());   // random nums from 0 to 4 (starts counting at 4)
        string prompt = _prompts[index];

        return prompt;
    }
}