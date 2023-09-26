using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TelaBloqueio : MonoBehaviour
{
    [SerializeField] private GameObject telaBloquei1;
    [SerializeField] private GameObject telaBloquei2;
    [SerializeField] private GameObject telaInicio;

    [SerializeField] private TMP_InputField senha;
    [SerializeField] private string senhaVerdadeira;
    [SerializeField] private GameObject imageSenhaErrada;

    void Update()
    {
        senhaVerdadeira = senha.text;
        
    }

    public void ArrastaPracima()
    {
        telaBloquei1.SetActive(false);
        telaBloquei2.SetActive(true);
    }

    public void ConferirSenha()
    {
        if ("ibis" == senhaVerdadeira)
        {
            telaInicio.SetActive(true);
            telaBloquei2.SetActive(false);
            Debug.Log(senhaVerdadeira);
        }
        else
        {
            StartCoroutine(ApareceSenhaErrada());
            senha.text = null;
        }
    }

    IEnumerator ApareceSenhaErrada()
    {
        imageSenhaErrada.SetActive(true);
        yield return new WaitForSeconds(2f);
        imageSenhaErrada.SetActive(false);
    }
}
