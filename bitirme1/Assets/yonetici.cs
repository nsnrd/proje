using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class yonetici : MonoBehaviour
{

    int yerlestirilen_parca = 0;
    int toplam_puzzle = 9;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sayi_arttir()
    {
        yerlestirilen_parca++;

        if(yerlestirilen_parca == toplam_puzzle)
        {
            Debug.Log("sonraki bölüme geç");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
