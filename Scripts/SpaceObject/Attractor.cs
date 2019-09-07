using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attractor
{
    public class Attractor : MonoBehaviour
    {
        const float G = 6.674f;

        public static List<Attractor> Attractors;

        public Rigidbody rb;


        void FixedUpdate()
        {
            foreach (Attractor attractor in Attractors)
            {
                if (attractor != this)
                    Attract(attractor);

            }
        }

        public void OnEnable()
        {
            if (Attractors == null)
                Attractors = new List<Attractor>();

            Attractors.Add(this);
        }

        public void OnDisable()
        {
            Attractors.Remove(this);
        }

        void Attract(Attractor objToAttract)
        {
            Rigidbody rbToAttract = objToAttract.rb;

            Vector3 direction = rb.position - rbToAttract.position;
            float distance = direction.magnitude;

            if (distance == 0f)
                return;

            float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
            Vector3 force = direction.normalized * forceMagnitude;

            rbToAttract.AddForce(force);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.X))
            {
                OnDisable();
            }

            if (Input.GetKey(KeyCode.Y))
            {
                OnEnable();
            }
        }
    }
}
