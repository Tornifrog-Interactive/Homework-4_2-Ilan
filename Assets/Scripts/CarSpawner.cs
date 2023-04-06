using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    Car carPrefab;

    [SerializeField]
    float spawnRate = 1.0f;

    [SerializeField]
    int spawnAmount = 1;

    [SerializeField]
    Vector3 velocityOfSpawnedObject;

    [SerializeField]
    float rotationDirection = 0f;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, this.spawnRate);
    }

    private void Spawn()
    {
        for (int i = 0; i < this.spawnAmount; i++)
        {
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z
            );

            Quaternion rotationOfSpawnedObject = Quaternion.Euler(0f, rotationDirection, 0f);
            GameObject newObject = Instantiate(
                carPrefab.gameObject,
                positionOfSpawnedObject,
                rotationOfSpawnedObject
            );
            newObject.GetComponent<Car>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
