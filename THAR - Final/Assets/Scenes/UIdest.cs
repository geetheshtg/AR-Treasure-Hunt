using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIdest : MonoBehaviour
{
    public void Dest(){
    	GameObject canvas = GameObject.FindGameObjectWithTag("UI");
    	Destroy(canvas);
    }
}