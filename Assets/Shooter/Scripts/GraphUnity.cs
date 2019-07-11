using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphUnity : MonoBehaviour
{
    List<GameObject> points;
    private int i = 0;
    [SerializeField] float LineDrawSpeed;
    float counter;
    float dist;
    [SerializeField] GameObject cube;


    private void Awake()
    {
        points = new List<GameObject>();

    }


    private void Start()
    {
        generateGraph();
    }

    private void Update()
    {
        
        StartCoroutine(drawPoints());
    }

    public void generateGraph() {

        for (int i = 0; i < 10; i++) {

            GameObject _point = Instantiate(cube)as GameObject;
            _point.transform.position = new Vector3(i, 1f, i);
            _point.AddComponent<LineRenderer>();
            _point.AddComponent<TestScript>();
            points.Add(_point);
          
          
        }
    }
    IEnumerator drawPoints() {
      
            i++;
            points[i].GetComponent<LineRenderer>().SetPosition(0, points[i].transform.position);
            points[i].GetComponent<LineRenderer>().SetPosition(1, points[(i + 1) % points.Count].transform.position);
            
            yield return new WaitForSecondsRealtime(0.2f);
        }
       
    }



