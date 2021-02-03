using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBlink : MonoBehaviour
{
    [SerializeField]
    public float activeTime;
    [SerializeField]
    public float inactiveTime;

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(BlinkArrow());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BlinkArrow()
    {
        yield return new WaitForSeconds(activeTime);
        renderer.enabled = !renderer.enabled;
        yield return new WaitForSeconds(inactiveTime);
        renderer.enabled = !renderer.enabled;
        StartCoroutine(BlinkArrow());

    }
}
