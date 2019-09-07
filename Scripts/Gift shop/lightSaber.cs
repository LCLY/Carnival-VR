using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSaber : MonoBehaviour
{
    LineRenderer lineRend;
    public Transform startPos;
    public Transform endPos;
    private float textureOffset = 0f;
    private bool on = false;
    private Vector3 endPosExtendedPos;
    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        endPosExtendedPos = endPos.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            on = !on;
            //Debug.Log("on: " + on);        
        }

        if (on)
        {
            Debug.Log("on: " + on);
            //show line
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, endPosExtendedPos, Time.deltaTime * 5f);
        }
        else
        {
            Debug.Log("on: " + on);
            //hide line
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, startPos.localPosition, Time.deltaTime * 5f);
        }


        lineRend.SetPosition(0, startPos.position);
        lineRend.SetPosition(1, endPos.position);

        //pan texture
        textureOffset -= Time.deltaTime * 2f;
        if(textureOffset < -10f)
        {
            textureOffset += 10f;
        }
        lineRend.sharedMaterials[1].SetTextureOffset("_MainTex", new Vector2(textureOffset,0f));
    }
}
