using System;
using UnityEngine;

public class bullethell : MonoBehaviour
{
    public int number_of_columns;
    public float speed;
    public Texture texture;
    public Color color;
    public float lifetime;
    public float firerate;
    public float size;
    private float angle;
    public Material material;

    public ParticleSystem system;
    void Awake()
    {
        summon();
    }

    // Update is called once per frame
    void summon()
    {
        angle = 360f / number_of_columns;

        for (int i = 0; i < number_of_columns; i++)
        {
            Material particuleMaterial = new Material(Shader.Find("Particles/standard Unlit"));
            var go = new GameObject("Particle System");
            go.transform.Rotate(angle * i, 90, 0);
            go.transform.parent = this.transform;
            go.transform.position = this.transform.position;
            go.GetComponent<ParticleSystemRenderer>().material = particuleMaterial;
            var mainmodule = system.main;
            mainmodule.startColor = Color.green;
            mainmodule.startSize = .5f;

            var emission = system.emission;
            emission.enabled = false;
            var forma = system.shape;
            forma.enabled = true;
            forma.shapeType = ParticleSystemShapeType.Sprite;
            forma.sprite = null;
        }
        InvokeRepeating("Doemit", 2.0f, 2.0f);
    }

   void Doemit()
        {
            foreach (Transform child in transform)
            {
            system = child.GetComponent<ParticleSystem>();
                system = child.GetComponent<ParticleSystem>();
                var emitParams = new ParticleSystem.EmitParams();
                emitParams.startSize = .2f;
                emitParams.startColor = Color.red;
                system.Emit(emitParams, 10);
            }
        }

   
}
