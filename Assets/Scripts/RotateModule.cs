using System;
using System.Collections.Generic;

using UnityEngine;


class RotateModule : MonoBehaviour
{
    //1. 행성계 구현하기
    //1++. 행성계 곡선으로 구현하기
    //2. isRotate 구현하기

    public float speed = 10;
    [SerializeField] private bool isRotate = false;


    private void Update()
    {
        transform.RotateAround(Vector3.zero, new Vector3(0 ,0 ,1), speed);
    }
    





}


