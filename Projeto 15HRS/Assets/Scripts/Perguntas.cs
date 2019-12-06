using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perguntas : MonoBehaviour
{
    [SerializeField]
    List<Pergunta> listaDePerguntas = new List<Pergunta>();
}

[System.Serializable]
class Pergunta
{
    public string texto;

    public enum TipoDeGoverno {Americano,Sovietico}
    public enum TipoDePergunta {População, Financeiro}

    public TipoDePergunta tipoDePergunta;
    public TipoDeGoverno governo;

    public int valorDaPergunta;
}
