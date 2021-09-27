using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreake : MonoBehaviour
{
    [SerializeField]
    public GameObject downObj;

    Rigidbody rigd;
    Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        rigd = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            if(Vector3.Distance(lastPos, transform.position) < 0.1f)
            {
                Instantiate(downObj, transform);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            lastPos = transform.position;
        }
    }
}
