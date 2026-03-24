using UnityEngine;

public class Jumper : MonoBehaviour
{
    // jump location support
    const float minX = -5.0f;
    const float maxX = 5.0f;
    const float minY = -3.0f;
    const float maxY = 3.0f;

    // timer support
    const float TotalJumpDelaySeconds = 1.0f;
    float elapsedJumpDelaySeconds = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Update timer and check if it's time to jump
        elapsedJumpDelaySeconds += Time.deltaTime;

        if(elapsedJumpDelaySeconds > TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0.0f; // reset timer
            // Generate random x and y coordinates within the defined bounds
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);

            // change the transform position to the new random coordinates
            transform.position = position;
        }
    }
}
