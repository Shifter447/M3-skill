using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPixel : MonoBehaviour
{
    public Byte ByteR;
    public Byte ByteG;
    public Byte ByteB;
    public GameObject Pixel;
    public string colorCode;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

       
    }

    private void Update()
    {
        if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
        {
            colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();


            if (ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;

            }
            else
            {
                Debug.LogError("Ongeldige hex kleur: " + colorCode);
            }
        }

    }
}
