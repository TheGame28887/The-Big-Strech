using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCat : MonoBehaviour
{
    public Vector3 Offset;
    public Transform Cat;
    public Vector3 Gene; 
    // Start is called before the first frame update
    void Start()
    {
        Gene = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
      Gene.y = Cat.position.y + Offset.y;
      transform.position = Gene;
    
    }
}
