using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class ToggleOff : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
			GetComponent<Outline> ().enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}