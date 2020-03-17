using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (8f, Random.Range (-4f, 4f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (0.1f, 0, 0);
    }
}
