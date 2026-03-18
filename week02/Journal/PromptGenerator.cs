public class PromptGenerator
{
    public List<string> _prompt = new List<string>()
    {
        "What made you smile today?",
        "What challenge did you overcome recently?",
        "Describe something you're greatful for.",
        "What is a goal you're working toward?"
    };

    public PromptGenerator() // Parameterless constructor to help keep the defualt of the string intact
    {
        

    }
    public PromptGenerator(List<string> prompt) // construct. THis will me important for later. (getters/setters and protected/private variables)
    
    {
        _prompt = prompt;
    }



    public string GetRandomPrompt()
    {
        Random random = new Random(); // random used for getting a random prompt
        int index = random.Next(_prompt.Count);
        return _prompt[index];

    }

}