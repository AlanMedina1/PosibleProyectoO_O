using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour
{
    public MonoBehaviour  EstadoPatrulla;
    public MonoBehaviour  EstadoAlerta;
    public MonoBehaviour  EstadoPersecucion;
    public MonoBehaviour  EstadoInicial;

    public MeshRenderer MeshRendererIndicador;
    private MonoBehaviour estadoActual;

    // Start is called before the first frame update
    void Start()
    {
        ActivarEstado(EstadoInicial);
    }
    
    //maquinaDeEstados.MeshRendererIndicador.material.color = ColorEstado;
    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual!=null) estadoActual.enabled = false; 
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }
  
}
