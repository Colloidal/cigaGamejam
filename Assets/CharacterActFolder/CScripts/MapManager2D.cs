using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager2D : MonoBehaviour
{
    public GameObject wall;
    private Transform initialPos;
    private bool mapDone;
    public int mapNumber;
    // Start is called before the first frame update
    void Start()
    {
        mapDone = false;
        //wall = Instantiate(Resources.Load<wall2d>);
    }

    // Update is called once per frame
    void Update()
    {
        if (mapNumber == 1 && !mapDone)
        {
            MapInstance1();
            mapDone = !mapDone;
        }
        if (mapNumber == 2 && !mapDone)
        {
            MapInstance2();
            mapDone = !mapDone;
        }
    }

    private void MapInstance1()
    {
        int i;
        //1行
        Instantiate(wall, new Vector3(16, 1, 0), new Quaternion(0, 0, 0, 0));
        //2行
        Instantiate(wall, new Vector3(16, 2, 0), new Quaternion(0, 0, 0, 0));
        //3行
        Instantiate(wall, new Vector3(16, 3, 0), new Quaternion(0, 0, 0, 0));
        //4行
        for (i = 8; i <= 12; i = i + 1)
            Instantiate(wall, new Vector3(i, 4, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 4, 0), new Quaternion(0, 0, 0, 0));
        for (i = 21; i <= 25; i = i + 1)
            Instantiate(wall, new Vector3(i, 4, 0), new Quaternion(0, 0, 0, 0));
        //5行
        Instantiate(wall, new Vector3(4, 5, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(8, 5, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 5, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(29, 5, 0), new Quaternion(0, 0, 0, 0));
        //6行
        Instantiate(wall, new Vector3(5, 6, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(8, 6, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 6, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(28, 6, 0), new Quaternion(0, 0, 0, 0));
        //7行
        Instantiate(wall, new Vector3(8, 7, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 7, 0), new Quaternion(0, 0, 0, 0));
        //8行
        for (i = 13; i <= 14; i = i + 1)
            Instantiate(wall, new Vector3(i, 8, 0), new Quaternion(0, 0, 0, 0));
        for (i = 19; i <= 21; i = i + 1)
            Instantiate(wall, new Vector3(i, 8, 0), new Quaternion(0, 0, 0, 0));
        //9行
        Instantiate(wall, new Vector3(13, 9, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(21, 9, 0), new Quaternion(0, 0, 0, 0));
        //10行
        for (i = 0; i <= 3; i = i + 1)
            Instantiate(wall, new Vector3(i, 10, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 10, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(21, 10, 0), new Quaternion(0, 0, 0, 0));
        for (i = 30; i <= 32; i = i + 1)
            Instantiate(wall, new Vector3(i, 10, 0), new Quaternion(0, 0, 0, 0));
        //11行
        Instantiate(wall, new Vector3(11, 11, 0), new Quaternion(0, 0, 0, 0));
        //12行
        Instantiate(wall, new Vector3(11, 12, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(19, 12, 0), new Quaternion(0, 0, 0, 0));
        //13行
        Instantiate(wall, new Vector3(5, 13, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(8, 13, 0), new Quaternion(0, 0, 0, 0));
        for (i = 11; i <= 13; i = i + 1)
            Instantiate(wall, new Vector3(i, 13, 0), new Quaternion(0, 0, 0, 0));
        for (i = 18; i <= 19; i = i + 1)
            Instantiate(wall, new Vector3(i, 13, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 13, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(28, 13, 0), new Quaternion(0, 0, 0, 0));
        //14行
        Instantiate(wall, new Vector3(4, 14, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(8, 14, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 14, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(29, 14, 0), new Quaternion(0, 0, 0, 0));
        //15行
        Instantiate(wall, new Vector3(8, 15, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 15, 0), new Quaternion(0, 0, 0, 0));
    }

    private void MapInstance2()
    {

        int i;
        //1行
        Instantiate(wall, new Vector3(8, 1, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 1, 0), new Quaternion(0, 0, 0, 0));
        //2行
        Instantiate(wall, new Vector3(8, 2, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 2, 0), new Quaternion(0, 0, 0, 0));
        //3行
        Instantiate(wall, new Vector3(8, 3, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(25, 3, 0), new Quaternion(0, 0, 0, 0));
        for (i = 15; i <= 18; i = i + 1)
            Instantiate(wall, new Vector3(i, 3, 0), new Quaternion(0, 0, 0, 0));
        //7行
        for (i = 10; i <= 13; i = i + 1)
            Instantiate(wall, new Vector3(i, 7, 0), new Quaternion(0, 0, 0, 0));
        for (i = 20; i <= 23; i = i + 1)
            Instantiate(wall, new Vector3(i, 7, 0), new Quaternion(0, 0, 0, 0));
        //8行
        Instantiate(wall, new Vector3(6, 8, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(27, 8, 0), new Quaternion(0, 0, 0, 0));
        //9行
        Instantiate(wall, new Vector3(6, 9, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(27, 9, 0), new Quaternion(0, 0, 0, 0));
        for (i = 16; i <= 17; i = i + 1)
            Instantiate(wall, new Vector3(i, 9, 0), new Quaternion(0, 0, 0, 0));
        //10行
        Instantiate(wall, new Vector3(6, 10, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(27, 10, 0), new Quaternion(0, 0, 0, 0));
        for (i = 1; i <= 3; i = i + 1)
            Instantiate(wall, new Vector3(i, 10, 0), new Quaternion(0, 0, 0, 0));
        for (i = 16; i <= 17; i = i + 1)
            Instantiate(wall, new Vector3(i, 10, 0), new Quaternion(0, 0, 0, 0));
        for (i = 30; i <= 32; i = i + 1)
            Instantiate(wall, new Vector3(i, 10, 0), new Quaternion(0, 0, 0, 0));
        //11行
        Instantiate(wall, new Vector3(6, 11, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(27, 11, 0), new Quaternion(0, 0, 0, 0));
        for (i = 16; i <= 17; i = i + 1)
            Instantiate(wall, new Vector3(i, 11, 0), new Quaternion(0, 0, 0, 0));
        //12行
        Instantiate(wall, new Vector3(6, 12, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(27, 12, 0), new Quaternion(0, 0, 0, 0));
        //13行
        for (i = 10; i <= 13; i = i + 1)
            Instantiate(wall, new Vector3(i, 13, 0), new Quaternion(0, 0, 0, 0));
        for (i = 20; i <= 23; i = i + 1)
            Instantiate(wall, new Vector3(i, 13, 0), new Quaternion(0, 0, 0, 0));
    }
}
