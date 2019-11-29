using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int populaçãoFeliz, financeiro, statusAmericano, statusSovietico;
    public Slider sliderPopulação, sliderFinanceiro, sliderStatusAmericano, sliderStatusSovietico;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderPopulação.value = populaçãoFeliz;
        sliderFinanceiro.value = financeiro;
        sliderStatusAmericano.value = statusAmericano;
        sliderStatusSovietico.value = statusSovietico;
    }
}
