﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        // Đặt chuột vào vị trí giữa màn hình
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
