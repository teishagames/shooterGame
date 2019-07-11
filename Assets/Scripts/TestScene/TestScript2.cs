using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{

    bool isTouch;
    Transform holePos;
    Transform player;

  
    private void Update()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        if (isTouch) {
            transform.position = Vector3.Lerp(transform.position, holePos.transform.position, Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouch = true;
         
        }
    }

    private void NewMethod(Collider other)
    {
        holePos.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
    }
}
