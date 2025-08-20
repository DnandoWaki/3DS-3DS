using UnityEngine;

public class Camira : MonoBehaviour
{
    [SerializeField] private float CameraSense = 10f;

    [SerializeField] private float MaxMoviCara;
    [SerializeField] private float MinMoviCara;

    float DistOlhar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DistOlhar = transform.localRotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        DistOlhar = Mathf.Clamp(DistOlhar + Input.GetAxis("Mouse X") * CameraSense, MinMoviCara, MaxMoviCara);

        transform.localRotation = Quaternion.Euler(0f, DistOlhar, 0f);
    }
}
