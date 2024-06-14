using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tası : MonoBehaviour
{

    Camera kamera;
    Vector2 baslangıc_pozisyonu;

    GameObject[] kutu_dizisi;

    yonetici yonet;

    public AudioClip sesEfekt;
    AudioSource sesOynatici;

    private void OnMouseDrag()
    {
        Vector3 poziyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        poziyon.z = 0;
        transform.position = poziyon;
    }

    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangıc_pozisyonu = transform.position;

        kutu_dizisi = GameObject.FindGameObjectsWithTag("kutu");
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();

        sesOynatici = GetComponent<AudioSource>();
        sesOynatici.clip = sesEfekt;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach(GameObject kutu in kutu_dizisi)
            {
                if(kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);

                    if(mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        yonet.sayi_arttir();
                        sesOynatici.Play();

                        this.enabled = false;
                        Destroy(this);
                    }
                    else
                    {
                        transform.position = baslangıc_pozisyonu;
                        Debug.Log("Oyun bitti!");

                    }
                }
            }
        }
    }
}
