using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Awake()
    {
    	print("Loaded SaveProgress");
        SaveProgress.Load();
    }
}
