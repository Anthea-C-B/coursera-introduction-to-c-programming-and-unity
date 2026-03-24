using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Maximum possible score
        const int MaxScore = 100;

        // Example score
        int score = 75;

        // Calculate the percentage
        float percent = (float)score / MaxScore * 100;

        Debug.Log($"Score: {score}/{MaxScore} ({percent}%)");
    }
}
