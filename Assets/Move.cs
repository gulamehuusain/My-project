using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode positives;
    [SerializeField]
    KeyCode negatives;
    [SerializeField]
    Vector3 vforce;

    [SerializeField]
    KeyCode rights;
    [SerializeField]
    KeyCode lefts;
    [SerializeField]
    Vector3 vforces;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(positives))
        {
            GetComponent<Rigidbody>().velocity += vforce;

        }
        if (Input.GetKey(negatives))
        {
            GetComponent<Rigidbody>().velocity -= vforce;

        }
        if (Input.GetKey(rights))
        {
            GetComponent<Rigidbody>().velocity += vforces;

        }
        if (Input.GetKey(lefts))
        {
            GetComponent<Rigidbody>().velocity -= vforces;

        }
    }
   
}
