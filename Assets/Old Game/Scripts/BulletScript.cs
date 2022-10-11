using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float PrefabTimeToLive = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, PrefabTimeToLive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
