using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;


    void Start()
    {
        
    }

    // Update is call ed once per frame
    void Update()
    {
        Vector3 newPosition.z += speed * Time.deltaTime;

    }
}
