using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NavtoGameObject(GameObject target) {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();

        navAgent.SetDestination (target.transform.position);

	}

    public void StopNavigation()
    {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();
        navAgent.Stop();        
    }

    public void ResumeNavigation()
    {
        NavMeshAgent navAgent = GetComponent<NavMeshAgent>();
        navAgent.Resume();
    }
}
