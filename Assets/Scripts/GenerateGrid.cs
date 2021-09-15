using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrid : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pointPrefab;
    public PointProperties[,,] Points = new PointProperties[4, 4, 4];
    bool[,] GridPoints = new bool[4,4];
    void Start()
    {
        
        //for (int i = 0; i < 40; i+=10)
        //{   
        //    for(int j =0;j<40;j+=10)
        //    {
        //        for(int k=0;k<40;k+=10)
        //        {
        //            GameObject InstantiatedPoint = Instantiate(pointPrefab, new Vector3(i, j, k), Quaternion.identity);
        //            Points[i/10,j/10,k/10] = InstantiatedPoint.transform.GetComponent<PointProperties>();
        //            Points[i/10, j/10, k/10].PointPosition = InstantiatedPoint.transform.position;
        //            Points[i / 10, j / 10, k / 10].SetIndices(i / 10, j / 10, k / 10);
        //        }
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate(int x,int y,int z)
    {
        for (int i = 0; i < x*10; i += 10)
        {
            for (int j = 0; j < y*10; j += 10)
            {
                for (int k = 0; k < z*10; k += 10)
                {
                    GameObject InstantiatedPoint = Instantiate(pointPrefab, new Vector3(i, j, k), Quaternion.identity);
                    Points[i / 10, j / 10, k / 10] = InstantiatedPoint.transform.GetComponent<PointProperties>();
                    Points[i / 10, j / 10, k / 10].PointPosition = InstantiatedPoint.transform.position;
                    Points[i / 10, j / 10, k / 10].SetIndices(i / 10, j / 10, k / 10);
                }
            }
        }
    }
}
