using System;
using System.ComponentModel.DataAnnotations;


public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something new you learned today?",
        "Describe a challenge you faced today and how you handled it.",
        "What made you smile today?",
        "What is something you are grateful for today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}