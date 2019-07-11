using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public  class TestScript :MonoBehaviour{

[SerializeField] Image progressBar;
/// <summary>
/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
float timer=0;
void Start()
{
    StartCoroutine(CoroutineTimer());
}

/// <summary>
/// Update is called every frame, if the MonoBehaviour is enabled.
/// </summary>
void Update()
{
    
}
IEnumerator CoroutineTimer(){
    while(true){
        yield return new WaitForSeconds(1f);
        timer++;
        print(timer);
        if(timer>=10){
           GenerateCube();
           yield break;     
        }
    }
}

void GenerateCube(){
    GameObject cube=Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
    cube.transform.position=Vector3.zero;

}
}




   
   







