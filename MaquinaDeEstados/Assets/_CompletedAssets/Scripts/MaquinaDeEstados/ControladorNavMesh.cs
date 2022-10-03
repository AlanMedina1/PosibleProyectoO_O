using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControladorNavMesh : MonoBehaviour
{
    [HideInInspector]
    public Transform perseguirObjetivo;

    private UnityEngine.AI.NavMeshAgent navMeshAgent; 

    void Awake() {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    public void ActualizarPuntoDestinoNavMeshAgent(Vector3 puntoDestino) {
        navMeshAgent.destination = puntoDestino;
        navMeshAgent.Resume();
    }

    public void ActualizarPuntoDestinoNavMeshAgent(){
        ActualizarPuntoDestinoNavMeshAgent(perseguirObjetivo.position);
    }
    
    public void DetenerNavMeshAgent()
    {
        navMeshAgent.Stop();
    }

    public bool HemosLlegado()
    {
        return navMeshAgent.remainingDistance <=  navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
    }
}
