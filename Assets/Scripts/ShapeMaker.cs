using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMaker : MonoBehaviour
{
    public GenerateGrid theGrid;
    
    private int ClickCount = 0;
    private int pointCount = 0;
    Queue<PointProperties> pointsQueue = new Queue<PointProperties>();
    [SerializeField]
    private LineRenderer theLine;

    RaycastHit hit;
    Ray ray;
    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit,200))
            if(hit.transform.tag == "Point")
            {
                Debug.Log("hit point");
                PointProperties p = hit.transform.gameObject.GetComponent<PointProperties>();
                if(p.isConnected == true)
                {
                    //Do Nothing
                }
                else
                {
                    ClickCount++;
                    p.isConnected = true;
                    pointsQueue.Enqueue(p);
                    
                    if(ClickCount==1)
                    {
                        //Do nothing we already enqueued our first point
                        Debug.Log("First Point position is " + p.transform.position.ToString());
                        theLine.SetPosition(pointCount++, p.transform.position);
                    }
                    if(ClickCount == 2)
                    {
                        theLine.positionCount++;
                        theLine.SetPosition(pointCount++,p.transform.position);
                    }
                    if(ClickCount ==3)
                    {
                        theLine.positionCount++;
                        theLine.SetPosition(pointCount++, p.transform.position);
                        theLine.positionCount++;
                        theLine.SetPosition(pointCount++, pointsQueue.Dequeue().transform.position);
                    }
                    if(ClickCount == 4)
                    {
                        while(pointsQueue.Count > 0)
                        {
                                theLine.positionCount++;
                                theLine.SetPosition(pointCount++, pointsQueue.Dequeue().transform.position);
                        }
                    }
                    
                    

                }
            }
        }
    }

    //private int[] GetNearestUnconnectedNeighbour(int[] indices)
    //{
    //    int i = indices[0];
    //    int j = indices[1];
    //    int k = indices[2];

    //    for(int _i =0;i<4;i++)

    //    p_indices = p.Get
    //    return indices;
    //}

}
