using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject wall;
    private Transform initialPos;
    private bool mapDone;
    public int mapNumber;

    void Start()
    {
        mapDone = false;
        wall = (GameObject)Resources.Load("wall2D");
    }

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
        Instantiate(wall, new Vector3(32, 0, 1), new Quaternion(0, 0, 0, 0));
        //2行
        Instantiate(wall, new Vector3(32, 0, 3), new Quaternion(0, 0, 0, 0));
        //3行
        Instantiate(wall, new Vector3(32, 0, 5), new Quaternion(0, 0, 0, 0));
        //4行
        for (i = 16; i <= 24; i = i+2)
        Instantiate(wall, new Vector3(i, 0, 7), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(32, 0, 7), new Quaternion(0, 0, 0, 0));
        for (i = 42; i <= 50; i = i + 2)
        Instantiate(wall, new Vector3(i, 0, 7), new Quaternion(0, 0, 0, 0));
        //5行
        Instantiate(wall, new Vector3(8, 0, 9), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 0, 9), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 9), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(58, 0, 9), new Quaternion(0, 0, 0, 0));
        //6行
        Instantiate(wall, new Vector3(10, 0, 11), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 0, 11), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 11), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(56, 0, 11), new Quaternion(0, 0, 0, 0));
        //7行
        Instantiate(wall, new Vector3(16, 0, 13), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 13), new Quaternion(0, 0, 0, 0));
        //8行
        for (i = 26; i <= 28; i = i + 2)
        Instantiate(wall, new Vector3(i, 0, 15), new Quaternion(0, 0, 0, 0));
        for (i = 38; i <= 42; i = i + 2)
        Instantiate(wall, new Vector3(i, 0, 15), new Quaternion(0, 0, 0, 0));
        //9行
        Instantiate(wall, new Vector3(26, 0, 17), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(42, 0, 17), new Quaternion(0, 0, 0, 0));
        //10行
        for (i = 0; i <= 6; i = i + 2)
        Instantiate(wall, new Vector3(i, 0, 19), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(32, 0, 19), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(42, 0, 19), new Quaternion(0, 0, 0, 0));
        for (i = 60; i <= 64; i = i + 2)
        Instantiate(wall, new Vector3(i, 0, 19), new Quaternion(0, 0, 0, 0));

        //11行
        Instantiate(wall, new Vector3(22, 0, 21), new Quaternion(0, 0, 0, 0));
        //12行
        Instantiate(wall, new Vector3(22, 0, 23), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(38, 0, 23), new Quaternion(0, 0, 0, 0));
        //13行
        Instantiate(wall, new Vector3(10, 0, 25), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 0, 25), new Quaternion(0, 0, 0, 0));
        for (i = 22; i <= 26; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 25), new Quaternion(0, 0, 0, 0));
        for (i = 36; i <= 38; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 25), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 25), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(56, 0, 25), new Quaternion(0, 0, 0, 0));
        //14行
        Instantiate(wall, new Vector3(8, 0, 27), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(16, 0, 27), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 27), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(58, 0, 27), new Quaternion(0, 0, 0, 0));
        //15行
        Instantiate(wall, new Vector3(16, 0, 29), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 29), new Quaternion(0, 0, 0, 0));
        //16行
        for (i = 16; i <= 24; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 31), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(32, 0, 31), new Quaternion(0, 0, 0, 0));
        for (i = 42; i <= 50; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 31), new Quaternion(0, 0, 0, 0));
        //17行
        Instantiate(wall, new Vector3(32, 0, 33), new Quaternion(0, 0, 0, 0));
        //18行
        Instantiate(wall, new Vector3(32, 0, 35), new Quaternion(0, 0, 0, 0));
    }

    private void MapInstance2()
    {
        int i;
        //1行
        Instantiate(wall, new Vector3(16, 0, 1), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 1), new Quaternion(0, 0, 0, 0));
        //2行
        Instantiate(wall, new Vector3(16, 0, 3), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 3), new Quaternion(0, 0, 0, 0));
        //3行
        Instantiate(wall, new Vector3(16, 0, 5), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(50, 0, 5), new Quaternion(0, 0, 0, 0));
        for (i = 30; i <= 36; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 5), new Quaternion(0, 0, 0, 0));
        //7行
        for (i = 20; i <= 26; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 13), new Quaternion(0, 0, 0, 0));
        for (i = 40; i <= 46; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 13), new Quaternion(0, 0, 0, 0));
        //8行
        Instantiate(wall, new Vector3(12, 0, 15), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(54, 0, 15), new Quaternion(0, 0, 0, 0));
        //9行
        Instantiate(wall, new Vector3(12, 0, 17), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(54, 0, 17), new Quaternion(0, 0, 0, 0));
        for (i = 32; i <= 34; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 17), new Quaternion(0, 0, 0, 0));
        //10行
        Instantiate(wall, new Vector3(12, 0, 19), new Quaternion(0, 0, 0, 0));
        Instantiate(wall, new Vector3(54, 0, 19), new Quaternion(0, 0, 0, 0));
        for (i = 2; i <= 6; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 19), new Quaternion(0, 0, 0, 0));
        for (i = 32; i <= 34; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 19), new Quaternion(0, 0, 0, 0));
        for (i = 60; i <= 64; i = i + 2)
            Instantiate(wall, new Vector3(i, 0, 19), new Quaternion(0, 0, 0, 0));

    }

}
