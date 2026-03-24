using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField]
    int radius;
    float area;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // calculate area
        // note that we're using UnityEngine Mathf instead of System Math
        area = Mathf.PI * Mathf.Pow(radius, 2);

        // scale circle sprite based on radius
        Vector3 scale = transform.localScale;
        scale.x *= radius;
        scale.y *= radius;
        transform.localScale = scale;

        // print radius and area
        Debug.Log("Radius: " + radius +
              ", Area: " + area);
    }
}
