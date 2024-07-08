public class VisualizationActivity : Activity
{
    private List<string> _visualizationScenes = new List<string>
    {
        "Imagine yourself on a peaceful beach, with the sound of waves gently crashing.",
        "Visualize yourself achieving a personal goal, feeling proud and accomplished.",
        "Picture a calm forest, with birds singing and a gentle breeze blowing.",
        "See yourself surrounded by your loved ones, feeling supported and happy."
    };

    public VisualizationActivity() : base("Visualization", "This activity will help you relax and focus by guiding you through positive visualizations. Clear your mind and imagine the scenes as vividly as you can.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        // Shuffle visualization scenes
        List<string> shuffledScenes = new List<string>(_visualizationScenes);
        ShuffleList(shuffledScenes, random);

        int elapsed = 0;
        int sceneIndex = 0;

        while (elapsed < _duration)
        {
            if (sceneIndex >= shuffledScenes.Count)
            {
                // This set of code would help If all scenes have been used, shuffle again and reset index
                ShuffleList(shuffledScenes, random);
                sceneIndex = 0;
            }
            Console.WriteLine($"Close your eyes and visualize the following scene:");
            string scene = shuffledScenes[sceneIndex];
   
            Console.WriteLine($"---{scene}---");
            Console.WriteLine();
            Console.Write("Press Enter to continue to the next scene.");
            Console.ReadLine();
            ShowSpinner();

            sceneIndex++;
            elapsed += 3;
        }
        DisplayEndingingMessage();
    }
}
