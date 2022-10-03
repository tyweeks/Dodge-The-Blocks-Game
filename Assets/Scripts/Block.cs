using UnityEngine;

public class Block : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }
    }
}
