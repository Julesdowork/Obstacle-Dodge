using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpeed = 0.25f;
    [SerializeField] float ySpeed = 0.25f;
    [SerializeField] float zSpeed = 0.25f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpeed, ySpeed, zSpeed);
    }
}
