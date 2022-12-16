using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevels : MonoBehaviour
{
    public GameObject[] lanes;
    GameObject tempLane;
    int zPosition = 2;

    // Start is called before the first frame update
    void Start()
    {
        CreateLanes();
    }

    // Update is called once per frame
    void Update() 
    { 
        
    }

    // Create more lanes when game starts and when couple of steps is taken
    public void CreateLanes()
    {
        int i;
        for (i = zPosition; i < zPosition + 20; i++)
        {
            tempLane =
                Instantiate(
                    lanes[Random.Range(0, lanes.Length)],
                    new Vector3(0, 0, i),
                    Quaternion.identity
                ) as GameObject;
            tempLane.transform.SetParent(gameObject.transform);
            i += tempLane.GetComponent<NumberedLanes>().numOfLanes - 1;
        }
        zPosition = i;
    }
}
