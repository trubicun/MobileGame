using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float roationSpeed = 1f;

    void Update()
    {
        var rotation = transform.rotation.eulerAngles;
        rotation.y += roationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
