using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class trrt : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject Menu;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
        count = 0;
        SetCountText();
    }
    float Speed_move = 15.0f;
    float Speed_rot = 90.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {

            this.transform.Translate(Vector3.forward * Time.deltaTime * Speed_move);

        }

        if (Input.GetKey(KeyCode.S))

        {

            this.transform.Translate(Vector3.back * Time.deltaTime * Speed_move);

        }

        if (Input.GetKey(KeyCode.A))

        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * -Speed_rot);

        }

        if (Input.GetKey(KeyCode.D))

        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * Speed_rot);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count - 10;

            // Run the 'SetCountText()' function (see below)
            SetCountText();
            GetComponent<AudioSource>().Play();
        }
        if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 10;

            // Run the 'SetCountText()' function (see below)
            SetCountText();
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.CompareTag("PickUp3"))
        {
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 15;

            // Run the 'SetCountText()' function (see below)
            SetCountText();
            GetComponent<AudioSource>().Play();
        }


    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 120)
        {
            winTextObject.SetActive(true);

        }
    }
}
