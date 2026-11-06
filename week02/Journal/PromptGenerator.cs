public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string _defaultPrompt = "How was your day today?";
    public Random _random = new Random();
    //Created a constructor to automagically load on class instantiation 
    public PromptGenerator(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                _prompts.Add(line);
            }
        }
    }


    public string GetRandomPrompt()
    {
        //check to make sure the prompt file loaded correctly and if not display default prompt.
        if (_prompts.Count == 0)
        {
            return _defaultPrompt;
        }

        int prompt = _random.Next(0, _prompts.Count);
        return _prompts[prompt];
    }
}