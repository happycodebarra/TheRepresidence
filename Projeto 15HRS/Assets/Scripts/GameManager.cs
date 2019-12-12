using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int dia = 0;
    public int populaçãoFeliz, financeiro, statusAmericano, statusSovietico;
    public Slider sliderPopulação, sliderFinanceiro, sliderStatusAmericano, sliderStatusSovietico;

    public Image governoFoto;
    public Sprite kennedy, leonid;

    public Perguntas perguntas;

    public Text textoPergunta, textoOpcao1, textoOpcao2;

    Pergunta perguntaEscolhida;

    public GameObject endGame;
    public Text endText;

    public Text diaText;

    // Start is called before the first frame update
    void Start()
    {
        sorteioPergunta();
    }

    // Update is called once per frame
    void Update()
    {
        sliderPopulação.value = populaçãoFeliz;
        sliderFinanceiro.value = financeiro;
        sliderStatusAmericano.value = statusAmericano;
        sliderStatusSovietico.value = statusSovietico;

        diaText.text = "Dia " + dia.ToString();
    }

    void checarTurno()
    {
        dia += 1;

        if (statusSovietico <= 10 || statusAmericano <= 10)
        {
            endGame.SetActive(true);
            endText.text = "Seu país foi invadido!";
        }

        else if (financeiro <= 10)
        {
            // Faliu
            endGame.SetActive(true);
            endText.text = "Seu país faliu!";
        }
        
        else if (populaçãoFeliz <= 10)
        {
            // Revolta
            endGame.SetActive(true);
            endText.text = "Você foi deposto!";
        }

        else if (dia > 7)
        {
            // Ganhou
            endGame.SetActive(true);
            endText.text = "Você venceu! O seu país se manteve estavél durante o seu governo.";
        }
    }

    void sorteioPergunta()
    {
        int sorteioPergunta = Random.Range(0, perguntas.listaDePerguntas.Count);

        perguntaEscolhida = perguntas.listaDePerguntas[sorteioPergunta];

        textoPergunta.text = perguntaEscolhida.texto;
        textoOpcao1.text = perguntaEscolhida.opcao1;
        textoOpcao2.text = perguntaEscolhida.opcao2;

        if (perguntaEscolhida.governo == Pergunta.TipoDeGoverno.Americano)
            governoFoto.sprite = kennedy;
        else
            governoFoto.sprite = leonid;
    }

    public void escolha(int id)
    {
        if (id == 1)
        {
            if (perguntaEscolhida.tipoDePergunta == Pergunta.TipoDePergunta.Financeiro)
            {
                financeiro += perguntaEscolhida.valorDaPergunta;
                populaçãoFeliz -= perguntaEscolhida.valorDaPergunta;
            }

            else if (perguntaEscolhida.tipoDePergunta == Pergunta.TipoDePergunta.População)
            {
                populaçãoFeliz += perguntaEscolhida.valorDaPergunta;
                financeiro -= perguntaEscolhida.valorDaPergunta;
            }

            if (perguntaEscolhida.governo == Pergunta.TipoDeGoverno.Americano)
            {
                statusAmericano += perguntaEscolhida.valorDaPergunta;
                statusSovietico -= perguntaEscolhida.valorDaPergunta;
            }

            else if (perguntaEscolhida.governo == Pergunta.TipoDeGoverno.Sovietico)
            {
                statusSovietico += perguntaEscolhida.valorDaPergunta;
                statusAmericano -= perguntaEscolhida.valorDaPergunta;
            }
        }

        else if (id == 2)
        {
            if (perguntaEscolhida.tipoDePergunta == Pergunta.TipoDePergunta.Financeiro)
            {
                financeiro -= perguntaEscolhida.valorDaPergunta;
                populaçãoFeliz += perguntaEscolhida.valorDaPergunta;
            }

            else if (perguntaEscolhida.tipoDePergunta == Pergunta.TipoDePergunta.População)
            {
                populaçãoFeliz -= perguntaEscolhida.valorDaPergunta;
                financeiro += perguntaEscolhida.valorDaPergunta;
            }

            if (perguntaEscolhida.governo == Pergunta.TipoDeGoverno.Americano)
            {
                statusAmericano -= perguntaEscolhida.valorDaPergunta;
                statusSovietico += perguntaEscolhida.valorDaPergunta;
            }

            else if (perguntaEscolhida.governo == Pergunta.TipoDeGoverno.Sovietico)
            {
                statusSovietico -= perguntaEscolhida.valorDaPergunta;
                statusAmericano += perguntaEscolhida.valorDaPergunta;
            }
        }

        sorteioPergunta();
        checarTurno();
    }
}
