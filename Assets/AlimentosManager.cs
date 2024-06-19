using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentosManager : MonoBehaviour
{
    public GameObject[] Alimentos;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActivateAll();
        }

     
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                DeactivateAll();
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = Alimentos.Length - 1;
                }
                Alimentos[currentIndex].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                DeactivateAll();
                currentIndex++;
                if (currentIndex >= Alimentos.Length)
                {
                    currentIndex = 0;
                }
                Alimentos[currentIndex].SetActive(true);
            }



        }
        void DeactivateAll()
        {
            for (int i = 0; i < Alimentos.Length; i++)
            {
                Alimentos[i].SetActive(false);
            }
        }

        void ActivateAll()
        {
            for (int i = 0; i < Alimentos.Length; i++)
            {
                Alimentos[i].SetActive(true);
            }
        }

        void ActivateByIndex(int index)
        {
            Alimentos[index].SetActive(true);
        }
    
}
