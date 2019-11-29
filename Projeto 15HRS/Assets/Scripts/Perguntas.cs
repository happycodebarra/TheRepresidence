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
    public enum Tipo {População, Financeiro, StatusAmericano, StatusSovietico }

    public Tipo tipoDePergunta;

    public int valorDaPergunta;
}
