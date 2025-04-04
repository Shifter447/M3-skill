using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRender;
    bool state = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            spriteRender.color = Color.green;
        }
        else
        {
            spriteRender.color = Color.red;
        }
    }

    private void OnMouseUp()
    {
        state = !state;
    }
}
