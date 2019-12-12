using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perguntas : MonoBehaviour
{
    
    public List<Pergunta> listaDePerguntas = new List<Pergunta>();
}

[System.Serializable]
public class Pergunta
{
    public string texto, opcao1, opcao2;

    public enum TipoDeGoverno {Americano,Sovietico}
    public enum TipoDePergunta {População, Financeiro}

    public TipoDePergunta tipoDePergunta;
    public TipoDeGoverno governo;

    public int valorDaPergunta;
}
