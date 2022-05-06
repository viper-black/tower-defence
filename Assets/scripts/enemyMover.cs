using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] [Range(0,5)]float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(FollowPath());       
    }

    IEnumerator FollowPath()
    {
        foreach(WayPoint ping in path)
        {
            Vector3 StartPos = transform.position;
            Vector3 endPos = ping.transform.position;
            float travelPrec = 0f;

            transform.LookAt(endPos);

            while(travelPrec < 1)
            {
            transform.position = Vector3.Lerp(StartPos,endPos,travelPrec);
            travelPrec += Time.deltaTime * moveSpeed;
            yield return new WaitForEndOfFrame();
            }



        }
    }
}
