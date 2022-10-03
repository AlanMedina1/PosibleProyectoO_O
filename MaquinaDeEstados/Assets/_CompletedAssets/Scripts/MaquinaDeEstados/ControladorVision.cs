using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVision : MonoBehaviour
{
    public Transform Ojitos;
    public float rangoVision = 20f;
    public Vector3 offset=new Vector3(0f, 0.75f, 0f);

    private ControladorNavMesh controladorNavMesh;

    void Awake()
    {
        controladorNavMesh = GetComponent<ControladorNavMesh>();
    }
    
     public bool PuedeVerAlJugador(out RaycastHit hit, bool mirarHaciaElJugador = false)
     {
        Vector3 vectorDireccion;
        if (mirarHaciaElJugador)
        {
            vectorDireccion = (controladorNavMesh.perseguirObjetivo.position + offset) - Ojitos.position; 
        }
        else
        {
            vectorDireccion = Ojitos.forward;
        }
        return Physics.Raycast(Ojitos.position, vectorDireccion, out hit, rangoVision) && hit.collider.CompareTag("Player");
    }
     
}
