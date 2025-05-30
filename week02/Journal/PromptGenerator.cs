using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "1- Who was the most interesting person I interacted with today?",
        "2- What was the best part of my day?",
        "3- How did I see the hand of the Lord in my life today?",
        "4- What was the strongest emotion I felt today?",
        "5- If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random indexGenerator = new Random();

        int index = indexGenerator.Next(0, _prompts.Count());   // random nums from 0 to 4 (starts counting at 4)
        string prompt = _prompts[index];

        return prompt;
    }
}