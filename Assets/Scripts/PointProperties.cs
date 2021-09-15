using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointProperties : MonoBehaviour
{
    public Vector3 PointPosition;
    public bool isConnected;

    public int i, j, k;

    public void SetIndices(int i,int j,int k)
    {
        this.i = i;
        this.j = j;
        this.k = k;
    }
    public int[] GetIndices(PointProperties p)
    {
        int[] indices = new int[3];
        indices[0] = p.i;
        indices[1] = p.j;
        indices[2] = p.k;

        return indices;
    }
}

