using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManeger : MonoBehaviour
{
    public float fadeRate;
    public Image image;

    private float targetAlpha;

    // Use this for initialization
    void Start()
    {
        this.image = this.GetComponent<Image>();
        if(this.image == null)
        {
            Debug.LogError("Error: No image on " + this.name);
        }

        this.image.color = new Color(0, 0, 0, 0);
        this.targetAlpha = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(image.color);
        Color curr = this.image.color;
        float alpha = Mathf.Abs(curr.a - this.targetAlpha);

        if(alpha >= 0f)
        {
            curr.a = Mathf.Lerp(curr.a, targetAlpha, this.fadeRate * Time.deltaTime);
            this.image.color = curr;
        }
    }

    public void FadeTransition()
    {
        //Color trans = new Color(0, 0, 0, 0);
        //img.color = Color.Lerp(trans, Color.black, Mathf.PingPong(Time.time, 1));
        //img.color = Color.Lerp(Color.black, trans, Mathf.PingPong(Time.time, 1));

        //// Fade In
        //for (float i = 0; i >= 0; i += Time.deltaTime)
        //{
        //    img.color = new Color(0, 0, 0, i);
        //}

        //// Fade Out
        //for (float i = 1; i >= 0; i -= Time.deltaTime)
        //{
        //    img.color = new Color(0, 0, 0, i);
        //}

        //if (img.color.a == 1)
        //{
        //    for (float i = 1; i >= 0; i -= Time.deltaTime)
        //    {
        //        img.color = new Color(0, 0, 0, i);
        //    }
        //}
        //else
        //{
        //    for (float i = 0; i >= 0; i += Time.deltaTime)
        //    {
        //        img.color = new Color(0, 0, 0, i);
        //    }
        //}

        // Fade In
        this.targetAlpha = 1.0f;

        // Pause
        new WaitForSeconds(0.5f);

        // Fade Out
        this.targetAlpha = 0f;
    }
}

