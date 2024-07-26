using UnityEngine;

public class GyroSimulator : MonoBehaviour
{
    public float sensitivity = 1.5f; // Sensibilité de la simulation du gyroscope
    private Quaternion simulatedGyroRotation;

    void Start()
    {
        simulatedGyroRotation = Quaternion.identity;
    }

    void Update()
    {
        // Récupérer les mouvements de la souris
        float rotationY = Input.GetAxis("Mouse X") * sensitivity;
        float rotationX = Input.GetAxis("Mouse Y") * sensitivity;

        // Appliquer les rotations à la simulation du gyroscope
        simulatedGyroRotation *= Quaternion.Euler(rotationX, 0, -rotationY);

        // Appliquer la rotation simulée à l'objet
        transform.rotation = simulatedGyroRotation;
    }
}