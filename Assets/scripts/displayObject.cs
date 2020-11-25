using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayObject : MonoBehaviour
{
    public stackobject stackObject;
    public Vector3 rotation;
    public Vector3 offset = new Vector3(0, 0.05f, 0);
    public int orderInLayer = 0;

    public List<GameObject> partList;
    void GenerateStack()
    {
        
        GameObject parts = new GameObject("Parts");
        parts.transform.parent = transform;
        parts.transform.localPosition = Vector3.zero;
        for (int i = 0; i < stackObject.stack.Count; i++)
        {
            GameObject stackPart = new GameObject("part"+i);
            SpriteRenderer sp = stackPart.AddComponent<SpriteRenderer>();
            sp.sprite = stackObject.stack[i];
            stackPart.transform.parent = parts.transform;
            stackPart.transform.position = Vector3.zero;
           
            partList.Add(stackPart);
        }
    }
    
    void Start()
    {
        GenerateStack();
    }
    void draw_stack()
    {
        int s = orderInLayer;
        Vector3 v = Vector3.zero;
        foreach (GameObject part in partList)
        {
            part.transform.localPosition = v;
            v += offset;
            part.transform.localRotation = Quaternion.Euler(rotation);
            
            part.GetComponent<SpriteRenderer>().sortingOrder = s;
            s += 1;
        }
    }
    void Update()
    {
        draw_stack();
    }
}
