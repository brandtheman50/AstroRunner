using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

        if (true)
        {
            Vector3 current = gameObject.transform.position;

            Vector3 increment =
             new Vector3(current.x,
                         current.y + .4f * Mathf.Sin(Mathf.Deg2Rad * 55),
                         current.z + .4f * Mathf.Cos(Mathf.Deg2Rad * 55));

            gameObject.transform.position = increment;
        }
    }
}