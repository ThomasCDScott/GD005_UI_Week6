using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody targetRb;
    [SerializeField] float minSpeed, maxSpeed, minTorque, maxTorque, xRange, ySpawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        //Adding a random upward force
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        //Adding a random torque(rotation) to the object
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        //Random Spawn position
        transform.position = RandomSpawnPosition();
    }

    float RandomNumberGenerator(float minRange, float maxRange)
    {
        return Random.Range(minRange, maxRange);
    }
   Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(minTorque, maxTorque);
    }

    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos, 0);
    }

    private void OnMouseDown ()
    {
        // It is true for one frame whenever the player clicks the collider
        Destroy(gameObject);
    }

    


}
